﻿using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompanyName.AbpZeroTemplate.Authorization.Accounts.Dto;
using School.Authorization.Accounts.Dto;

namespace School.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {

        Task<RegisterOutput> Register(RegisterInput input);

        Task SendPasswordResetCode(SendPasswordResetCodeInput input);

        Task<ResetPasswordOutput> ResetPassword(ResetPasswordInput input);

        Task SendEmailActivationLink(SendEmailActivationLinkInput input);

        Task ActivateEmail(ActivateEmailInput input);

        Task<ImpersonateOutput> Impersonate(ImpersonateInput input);

        Task<ImpersonateOutput> BackToImpersonator();

        Task<SwitchToLinkedAccountOutput> SwitchToLinkedAccount(SwitchToLinkedAccountInput input);
    }
}
