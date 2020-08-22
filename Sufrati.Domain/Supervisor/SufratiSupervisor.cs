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

        public SufratiSupervisor(
            IMapper Mapper,
            IUserRepository UserRepository,
            IPasswordPolicyRepository PasswordPolicyRepository,
            IGroupRepository GroupRepository,
            ILookupRepository LookupRepository,
            IConfiguration configuration
            )
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _PasswordPolicyRepository = PasswordPolicyRepository;
            _GroupRepository = GroupRepository;
            _LookupRepository = LookupRepository;
            _connectionString = configuration.GetConnectionString("Sufrati_CS");

        }
    }
}
