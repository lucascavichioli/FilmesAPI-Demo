using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosAPI.Data.Requests;

namespace UsuariosAPI.Services
{
    public class LoginService
    {
        public SignInManager<IdentityUser<int>> _signInManager;

        public LoginService(SignInManager<IdentityUser<int>> signInManager)
        {
            _signInManager = signInManager;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var resultadoIdentity = _signInManager
                                    .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (resultadoIdentity.Result.Succeeded) return Result.Ok();

            return Result.Fail("Login Falhou");
        }
    }
}
