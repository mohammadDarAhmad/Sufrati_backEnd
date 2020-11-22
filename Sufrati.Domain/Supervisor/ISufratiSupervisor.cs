using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Sufrati.Domain.Supervisor
{
    public interface ISufratiSupervisor
    {
       
        #region User
        Task<UserVM> AddUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> ChangePassword(ChangePassVM changePassVM, IHttpContextAccessor accessor, ClaimsPrincipal User, CancellationToken ct = default);
        Task<bool> ResetPassword(long userId, string newPassword, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<GeneralUserVM> GetUsers(CancellationToken ct = default);
        Task<UserDetailsVM> GetUserById(long id, CancellationToken ct = default);
        Task<PasswordPolicyVM> GetPolicy(long id, CancellationToken ct = default);
        Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateUser(UserForViewVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeleteUser(long id, CancellationToken ct = default);
        Task AddAttachmentToUser(long attachmentID, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task AddAttachmentToUser(long userId, long attachmentID, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
#endregion

        #region PasswordPolicy
        Task<PasswordPolicyVM> AddPasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<List<PasswordPolicyVM>> GetPasswordPolicys(CancellationToken ct = default);
        Task<PasswordPolicyVM> GetPasswordPolicyById(long id, CancellationToken ct = default);
        Task<BaseVM> GetPasswordPolicyInformation(long id, CancellationToken ct = default);
        Task<bool> UpdatePasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeletePasswordPolicy(long id, CancellationToken ct = default);

        #endregion

        #region Group
        Task<bool> AddUsers(long id, List<long> usersId, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<GroupVM> AddGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<GeneralGroupVM> GetGroups(CancellationToken ct = default);
        Task<GroupVM> GetGroupById(long id, CancellationToken ct = default);
        Task<BaseVM> GetGroupInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeleteGroup(long id, CancellationToken ct = default);
        Task<bool> RemoveUsers(long id, List<long> usersId, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);

        #endregion

        #region GeneralLookups
        Task<GeneralLookupValueForView> GetLookupValue(long id, CancellationToken ct = default);
        Task<GeneralLookupsVM> GetGeneralLookupsVM(CancellationToken ct);
        Task<GeneralLookupValueVM> AddGeneralLookup(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct);
        Task<GeneralLookupValueForView> UpdateGeneralLookupAsync(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct);
        Task DeleteGeneralLookupAsync(long id, CancellationToken ct);
        Task<BaseVM> GetLookupInformation(long id, CancellationToken ct = default);
        #endregion
        #region Attachment
        Task<BaseVM> GetFileTypeInformation(long id, CancellationToken ct = default);
        Task<BaseVM> GetAttachmentTypeInformation(long id, CancellationToken ct = default);
        Task<AttachmentVM> UploadAttachmentAsync(IFormFile file, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken));
        Task DeleteAttachmentAsync(long attachmentID, CancellationToken ct = default(CancellationToken));
        Task<AttachmentModel> GetAttachmentByIDAsync(long attachmentID, CancellationToken ct = default(CancellationToken));
        Task<List<FileTypeModel>> GetFileTypes(CancellationToken ct = default(CancellationToken));
        Task<AttachmentTypeWithItsFilesModel> AddAttachment(AttachmentTypesWithFilesForPostModel input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken));
        Task<AttachmentTypeWithItsFilesModel> UpdateAttachment(AttachmentTypesWithFilesForPostModel input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken));
        Task<bool> DeleteAttachmentTypeByID(long id, CancellationToken ct = default(CancellationToken));
        Task<List<AttachmentTypeWithItsFilesModel>> GetAttachmentTypes(CancellationToken ct = default(CancellationToken));
        Task<AttachmentTypeWithItsFilesModel> GetAttachmentTypeByID(long id, CancellationToken ct = default(CancellationToken));
        Task<FileTypeModel> UpdateFileType(FileTypeModel fileType, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken));
        Task<FileTypeModel> AddFileType(FileTypeModel fileType, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default(CancellationToken));
        Task<bool> DeleteFileTypeByID(long id, CancellationToken ct = default(CancellationToken));
        #endregion
        #region SystemConstant
        Task<SystemConstantGetVM> GetSystemConstant(CancellationToken ct = default);
        Task<BaseVM> GetSystemConstantInformation(CancellationToken ct = default);
        Task<bool> UpdateSystemConstant(SystemConstantVM systemConstantVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        #endregion

        #region Authentication
        Task<User> Authentication(UserLoginVM userLogin, IHttpContextAccessor accessor, CancellationToken ct = default);
        //Task<List<long>> GetUserPermissionForLogin(long id, IHttpContextAccessor accessor, CancellationToken ct = default);

        #endregion

        #region MyNLog
        Task MyNlogLogoutProperety(string token, CancellationToken ct = default);

        #endregion
        #region Recipe
        Task<bool> AddRecipe(RecipeVM recipe, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<List<RecipeVM>> GetAllRecipe(CancellationToken ct = default);
        Task<RecipeVM> GetRecipeByID(long id, CancellationToken ct = default);
        Task<bool> UpdateRecipe(RecipeVM recipeVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeleteRecipe(long id, CancellationToken ct = default);

        #endregion
    }
}
