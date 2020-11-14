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
        private readonly IRecipeRepository _RecipeRepository;

        public SufratiSupervisor(
            IMapper Mapper,
            IUserRepository UserRepository,
            IPasswordPolicyRepository PasswordPolicyRepository,
            IGroupRepository GroupRepository,
            ILookupRepository LookupRepository,
             ISystemConstantRepository SystemConstantRepository,
        IConfiguration configuration,
            IAttachmentRepository AttachmentRepository,
               IFileTypeRepository FileTypeRepository,
            IAttachmentTypeReository AttachmentTypeReository,
            IMyNLogRepository IMyNLogRepository,
            IAttachmentTypeFileTypeRepository AttachmentTypeFileTypeRepository,
            IAuthenticationRepository AuthenticationRepository,
            IRecipeRepository RecipeRepository
            )
        {

            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _PasswordPolicyRepository = PasswordPolicyRepository;
            _GroupRepository = GroupRepository;
            _LookupRepository = LookupRepository;
            _IFileTypeRepository = FileTypeRepository;
            _IAttachmentTypeReository = AttachmentTypeReository;
           _SystemConstantRepository = SystemConstantRepository;
            _IAttachmentTypeFileTypeRepository = AttachmentTypeFileTypeRepository;
            _IAttachmentRepository = AttachmentRepository;
            _IMyNLogRepository = IMyNLogRepository;
            _AuthenticationRepository = AuthenticationRepository;
            _RecipeRepository = RecipeRepository;
            _connectionString = configuration.GetConnectionString("Sufrati_CS");

        }
    }
}
