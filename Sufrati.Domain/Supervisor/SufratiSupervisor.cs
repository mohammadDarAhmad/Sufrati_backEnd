using AutoMapper;
using Microsoft.Extensions.Configuration;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor
    {
        private readonly string _connectionString;
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;
        private readonly IPasswordPolicyRepository _PasswordPolicyRepository;
        private readonly IGroupRepository _GroupRepository;
        private readonly ILookupRepository _LookupRepository;
        private readonly IAttachmentRepository _IAttachmentRepository;
        private readonly IFileTypeRepository _IFileTypeRepository;
        private readonly IAttachmentTypeReository _IAttachmentTypeReository;
        private readonly ISystemConstantRepository _SystemConstantRepository;
        private readonly IAttachmentTypeFileTypeRepository _IAttachmentTypeFileTypeRepository;
        private readonly IMyNLogRepository _IMyNLogRepository;
        private readonly IAuthenticationRepository _AuthenticationRepository;

        public SufratiSupervisor(
            IMapper Mapper,
            IUserRepository UserRepository,
            IPasswordPolicyRepository PasswordPolicyRepository,
            IGroupRepository GroupRepository,
            ILookupRepository LookupRepository,
            IConfiguration configuration,
            IAttachmentRepository AttachmentRepository,
               IFileTypeRepository FileTypeRepository,
            IAttachmentTypeReository AttachmentTypeReository,
            IMyNLogRepository IMyNLogRepository,
            IAttachmentTypeFileTypeRepository AttachmentTypeFileTypeRepository,
            IAuthenticationRepository AuthenticationRepository
            )
        {

            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _PasswordPolicyRepository = PasswordPolicyRepository;
            _GroupRepository = GroupRepository;
            _LookupRepository = LookupRepository;
            _IFileTypeRepository = FileTypeRepository;
            _IAttachmentTypeReository = AttachmentTypeReository;
            _IAttachmentTypeFileTypeRepository = AttachmentTypeFileTypeRepository;
            _IAttachmentRepository = AttachmentRepository;
            _IMyNLogRepository = IMyNLogRepository;
            _AuthenticationRepository = AuthenticationRepository;
            _connectionString = configuration.GetConnectionString("Sufrati_CS");

        }
    }
}
