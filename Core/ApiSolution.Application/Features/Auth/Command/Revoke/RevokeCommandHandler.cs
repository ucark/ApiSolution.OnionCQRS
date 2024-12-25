﻿using ApiSolution.Application.Bases;
using ApiSolution.Application.Features.Auth.Command.Rules;
using ApiSolution.Application.Interfaces.AutoMapper;
using ApiSolution.Application.Interfaces.UnitOfWorks;
using ApiSolution.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ApiSolution.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public RevokeCommandHandler(UserManager<User> userManager, AuthRules authRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await userManager.FindByEmailAsync(request.Email);
            await authRules.EmailAddressShouldBeValid(user);

            user.RefreshToken = null;
            await userManager.UpdateAsync(user);
            return Unit.Value;
        }
    }
}
