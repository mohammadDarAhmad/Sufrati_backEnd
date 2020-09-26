using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NLog;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati_backEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ISufratiSupervisor _supervisor;
        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        Logger logger = LogManager.GetCurrentClassLogger();

        public AuthenticationController(ISufratiSupervisor supervisor, IHttpContextAccessor accessor, IMapper mapper)
        {
            _supervisor = supervisor;
            _accessor = accessor;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        [Produces(typeof(LoginVM))]
        public async Task<IActionResult> Login([FromBody] UserLoginVM input, CancellationToken ct = default)
        {

            HttpContext.Session.Clear();
            // delete local authentication cookie
            await HttpContext.SignOutAsync("cookies");


            var user = await _supervisor.Authentication(input, _accessor, ct);
            //var action = await _supervisor.GetUserPermissionForLogin(user.ID, _accessor, ct);
            IActionResult response = Unauthorized();
            if (user != null)
            {
                LogManager.Configuration.Variables["UserID"] = $"{ user.ID}";
                var tokenString = GenerateJWTToken(user);
                var userNew = _mapper.Map<UserInnerVM>(user);

                response = Ok(new LoginVM()
                {
                    token = tokenString,
                    userDetails = userNew,
                    //action = action
                });
                LogManager.Configuration.Variables["Token"] = tokenString;
                logger.Info(input.LoginName + " " + "Login Successfully");
            }
            return response;
        }

        [HttpGet("GetCurrentUser")]
        [Produces(typeof(TokenDetailVM))]

        public async Task<IActionResult> GetCurrentUser()
        {
            var tokenString = Request.Headers["Authorization"];

            var jwtEncodedString = tokenString.ToString().Substring(7); // trim 'Bearer ' from the start since its just a prefix for the token string

            var token = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            var TokenDetail = Ok(new TokenDetailVM()
            {
                Token = token.ToString(),
                UserID = token.Claims.First(c => c.Type == "id").Value,
                UserName = token.Claims.First(c => c.Type == "fullName").Value,
                ExpiryDate = token.Claims.First(c => c.Type == "expiryDate").Value
            });

            return TokenDetail;
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            var token = Request.Headers["Authorization"];
            var checkToken = token.FirstOrDefault().Remove(0, 7);

            _accessor.HttpContext.Session.Clear();
            await _accessor.HttpContext.SignOutAsync("cookies");
            try
            {

                await _supervisor.MyNlogLogoutProperety(checkToken);
            }catch(Exception ex)
            {

            }
                return StatusCode(200, new JsonResult(true));
        }

        string GenerateJWTToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VaibhavBhapkarlkdfhjkfdm;lofdkkndbsdjnj"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userInfo.NameAr),
            new Claim("fullName", userInfo.NameAr.ToString()),
            new Claim("id",userInfo.ID.ToString()),
            new Claim("expiryDate",DateTime.Now.AddMinutes(120).ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddMinutes(120),
            signingCredentials: credentials
            );
            LogManager.Configuration.Variables["TokenValidTo"] = DateTime.Now.AddMinutes(120).ToString();
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
