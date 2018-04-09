﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using School.Authorization;

namespace School
{
    [DependsOn(
        typeof(SchoolCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchoolApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchoolAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchoolApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}