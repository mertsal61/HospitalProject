﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Cryptography;

//namespace HospitalProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        public static User user = new User();

//        [HttpPost("register")]
//        public async Task<ActionResult<User>> Register(UserDto request, byte [] passwordHash, byte [] passwordSalt)
//        {
//            CreatePasswordHash(request.password, passwordHash, passwordSalt);

//            user.username = request.username;
//            user.passwordHash = passwordHash;
//            user.passwordSalt = passwordSalt;
//            return Ok(user);

//        }
//        private void CreatePasswordHash(string password,byte[] passwordHash, byte[] passwordSalt)
//        {
//            using(var hmac =new HMACSHA512())
//            {
//                passwordSalt = hmac.Key;
//                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
//            }
//        }
//    }
//}