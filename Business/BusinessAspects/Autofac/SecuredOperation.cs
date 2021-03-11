using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constants;

namespace Business.BusinessAspects.Autofac
{
    //JSON WEB TOKEN İÇİN  -jwt
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; //jwt göndererek istek yapıyoruz. her istek için bir httpcontext oluşur.1 milyon istek gelrse 1milyon httpcontext oluşur.

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
