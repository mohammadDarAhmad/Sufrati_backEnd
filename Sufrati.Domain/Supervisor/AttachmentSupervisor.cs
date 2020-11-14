using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task<List<AttachmentTypeWithItsFilesModel>> GetAttachmentTypes(CancellationToken ct = default(CancellationToken))
        {
            var attachmentTypes = await _IAttachmentTypeReository.GetALLAsync();
            return _Mapper.Map<List<AttachmentTypeWithItsFilesModel>>(attachmentTypes);
        }

        public async Task<AttachmentTypeWithItsFilesModel> GetAttachmentTypeByID(long id, CancellationToken ct = default(CancellationToken))
        {
            var attachmentTypes = await _IAttachmentTypeReository.GetByIdAsync(id);
            return _Mapper.Map<AttachmentTypeWithItsFilesModel>(attachmentTypes);
        }

        public async Task<List<FileTypeModel>> GetFileTypes(CancellationToken ct = default(CancellationToken))
        {
            var fileTypes = await _IFileTypeRepository.GetALLAsync();

            return _Mapper.Map<List<FileTypeModel>>(fileTypes);
        }
        public async Task<ApiModels.AttachmentModel> GetAttachmentByIDAsync(long attachmentID, CancellationToken ct = default(CancellationToken))
        {
            var result = await _IAttachmentRepository.GetByIdAttachmentAsync(attachmentID);
            return _Mapper.Map<ApiModels.AttachmentModel>(result);
        }
        public async Task<BaseVM> GetFileTypeInformation(long id, CancellationToken ct = default)
        {
            var result = await _IFileTypeRepository.GetFileTypeInformation(id, ct);
            return result;
        }
        public async Task<BaseVM> GetAttachmentTypeInformation(long id, CancellationToken ct = default)
        {
            var result = await _IAttachmentTypeReository.GetAttacjmentTypeInformation(id, ct);
            return result;
        }
        public async Task<AttachmentTypeWithItsFilesModel> AddAttachment(AttachmentTypesWithFilesForPostModel input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            var toAdd = _Mapper.Map<AttachmentType>(input);
            toAdd.FileTypes = null;
            var added = await _IAttachmentTypeReository.AddAsync(toAdd);
            input.ID = added.ID;
            var returnValue = _Mapper.Map<AttachmentTypeWithItsFilesModel>(added);
            returnValue.FileTypes = await LinkFileTypesToAttachmentTypes(input, accessor, user, ct);
            return returnValue;
        }
        public async Task<AttachmentTypeWithItsFilesModel> UpdateAttachment(AttachmentTypesWithFilesForPostModel input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            var toUpdate = _Mapper.Map<AttachmentType>(input);
            toUpdate.FileTypes = null;
            var added = await _IAttachmentTypeReository.UpdateAsync(toUpdate);
            var returnValue = _Mapper.Map<AttachmentTypeWithItsFilesModel>(added);
            returnValue.FileTypes = await LinkFileTypesToAttachmentTypes(input, accessor, user, ct);
            return returnValue;
        }
        public async Task<List<AttachmentTypeFileTypeForAttachmentModel>> LinkFileTypesToAttachmentTypes(AttachmentTypesWithFilesForPostModel input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            var attachmentTypeFileType = _Mapper.Map<List<AttachmentTypeFileType>>(input.FileTypes);
            var alreadyExist = await _IAttachmentTypeFileTypeRepository.GetAllWithFilterAsync(e => e.AttachmentTypeID == input.ID);
            if (alreadyExist.Count > 0)
            {
                await _IAttachmentTypeFileTypeRepository.DeleteRange(alreadyExist);
            }
            foreach (var item in attachmentTypeFileType)
            {
                GeneralMethod.AddBaseProperties<AttachmentTypeFileType>(item, accessor, user, true);
                item.AttachmentTypeID = input.ID;
            }
            var added = await _IAttachmentTypeFileTypeRepository.AddRangeAsync(attachmentTypeFileType);
            List<AttachmentTypeFileTypeForAttachmentModel> returnvalue = new List<AttachmentTypeFileTypeForAttachmentModel>();
            foreach (var item in attachmentTypeFileType)
            {
                var newval = new AttachmentTypeFileTypeForAttachmentModel();
                newval.FileType = _Mapper.Map<FileTypeModel>(await _IFileTypeRepository.GetByIdAsync(item.FileTypeID, ct));
                returnvalue.Add(newval);
            }
            return returnvalue;
        }

        public async Task<bool> DeleteAttachmentTypeByID(long id, CancellationToken ct = default(CancellationToken))
        {

            try
            {
                var alreadyExist = await _IAttachmentTypeFileTypeRepository.GetAllWithFilterAsync(e => e.AttachmentTypeID == id);

                if (alreadyExist.Count > 0)
                {
                    await _IAttachmentTypeFileTypeRepository.DeleteRange(alreadyExist);
                    await _IAttachmentTypeReository.DeleteAsync(id);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public async Task<AttachmentVM> UploadAttachmentAsync(IFormFile file, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            string storagePath = (await _SystemConstantRepository.GetSystemConstant()).AttachmentPath;

            DateTime now = DateTime.Now;

            var FileNameAndType = file.FileName.Split('.');
            var FileName = FileNameAndType[0] + now.ToString("yyyyMMddHHmmss") + "." + FileNameAndType[FileNameAndType.Count() - 1];
            bool exists = System.IO.Directory.Exists("Attachments");

            if (!exists)
            {
                System.IO.Directory.CreateDirectory("Attachments");

            }
            string StoragePath = $"{storagePath}\\{FileName}";

            using (var fileStream = new FileStream(StoragePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }


            Attachment attachment = new Attachment();
            attachment.PhysicalFileName = FileName;
            attachment.OriginalFileName = file.FileName;
            attachment.FilePath = FileName;

            GeneralMethod.AddBaseProperties<Attachment>(attachment, accessor, user, true);
            await _IAttachmentRepository.AddAttachmentAsync(attachment);
            return _Mapper.Map<AttachmentVM>(attachment);
        }


        public async Task DeleteAttachmentAsync(long attachmentID, CancellationToken ct = default(CancellationToken))
        {
            string storagePath = (await _SystemConstantRepository.GetSystemConstant()).AttachmentPath;

            string pathInDataBase = await _IAttachmentRepository.DeleteAsync(attachmentID);
            string StoragePath = $"{storagePath}\\";

            var fileInfo = new FileInfo(StoragePath + pathInDataBase);
            fileInfo.Delete();
        }

        public async Task<FileTypeModel> AddFileType(FileTypeModel fileType, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            var toBeAddEntity = _Mapper.Map<FileType>(fileType);
            GeneralMethod.AddBaseProperties(toBeAddEntity, accessor, user, true);
            toBeAddEntity = await _IFileTypeRepository.AddAsync(toBeAddEntity);
            return _Mapper.Map<FileTypeModel>(toBeAddEntity);
        }

        public async Task<FileTypeModel> UpdateFileType(FileTypeModel fileType, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken))
        {
            var toBeUpdateEntity = _Mapper.Map<FileType>(fileType);
            GeneralMethod.AddBaseProperties<FileType>(toBeUpdateEntity, accessor, user, false);
            toBeUpdateEntity = await _IFileTypeRepository.UpdateAsync(toBeUpdateEntity, ct);
            return _Mapper.Map<FileTypeModel>(toBeUpdateEntity);
        }

        public async Task<bool> DeleteFileTypeByID(long id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                await _IFileTypeRepository.DeleteAsync(id, ct);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
