using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Sufrati.Domain.Entities;
using Sufrati.Domain.ApiModels;
using Sufrati.Data;
using Sufrati.Data.Configurations;
using Sufrati.Domain.Supervisor;
using Sufrati.Domain.Repositories;
using Sufrati.Data.Repositories;

namespace Sufrati_backEnd.API.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            ///services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPasswordPolicyRepository, PasswordPolicyRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ILookupRepository, LookupRepository>();
            services.AddScoped<IAttachmentTypeFileTypeRepository, AttachmentTypeFileTypeRepository>();
            services.AddScoped<IAttachmentTypeReository, AttachmentTypeReository>();
            services.AddScoped<IAttachmentRepository, AttachmentRepository>();
            services.AddScoped<IFileTypeRepository, FileTypeRepository>();
            services.AddScoped<ISystemConstantRepository, SystemConstantRepository>();
           // services.AddScoped<IFileTypeRepository, FileTypeRepository>();

            return services;
        }
        public static IServiceCollection ConfigureSupervisor(this IServiceCollection services)
        {
            //services.AddScoped< interface, class>();
            services.AddScoped<ISufratiSupervisor, SufratiSupervisor>();

            return services;
        }
        public static IServiceCollection ConfigureMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, GeneralUserVM>().ReverseMap();
                cfg.CreateMap<User, UserVMForView>().ReverseMap();
                cfg.CreateMap<User, UserInnerVM>().ReverseMap();
                cfg.CreateMap<User, UserVM>().ReverseMap();
                cfg.CreateMap<GeneralLookupValueVM, GeneralLookupValue>().ReverseMap();
                cfg.CreateMap<GeneralLookupTypeVM, GeneralLookupType>().ReverseMap();
                cfg.CreateMap<GeneralLookupValueForView, GeneralLookupValue>().ReverseMap();
                cfg.CreateMap<GeneralLookupTypeInnerVM, GeneralLookupType>().ReverseMap();
                cfg.CreateMap<GeneralLookupInnerValueVM, GeneralLookupValue>().ReverseMap();
                cfg.CreateMap<Groups, GroupVMForView>().ReverseMap();
                cfg.CreateMap<Groups, GeneralGroupVM>().ReverseMap();
                cfg.CreateMap<Groups, GroupVM>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyInnerVM>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyVMForView>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyVM>().ReverseMap();
                cfg.CreateMap<Groups, GroupVMForView>().ReverseMap();
                cfg.CreateMap<Groups, GeneralGroupVM>().ReverseMap();
                cfg.CreateMap<Groups, GroupVM>().ReverseMap();
                cfg.CreateMap<User, UserDetailsVM>().ReverseMap();
                cfg.CreateMap<User, GeneralUserVM>().ReverseMap();
                cfg.CreateMap<User, UserVMForView>().ReverseMap();
                cfg.CreateMap<User, UserInnerVM>().ReverseMap();
                cfg.CreateMap<User, UserVM>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyInnerVM>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyVMForView>().ReverseMap();
                cfg.CreateMap<PasswordPolicy, PasswordPolicyVM>().ReverseMap();
              

            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }

        public static IServiceCollection AddMiddleware(this IServiceCollection services)
        {


            return services;
        }
        public static IServiceCollection AddConnection(this IServiceCollection services, IConfiguration configuration)
        {

            var connection = configuration.GetConnectionString("Sufrati_CS");
            services.AddDbContext<SufratiContext>(options =>
            options.UseSqlServer(connection, b => b.MigrationsAssembly("Sufrati_backEnd.API")));

            return services;
        }

    }

}
