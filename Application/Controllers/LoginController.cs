using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using ORM.Interfaces;
using ORM;
using System.Security.Cryptography;
using System.Text;

namespace Application.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public static String GetHash(String input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes("Vinicius" + input + "Primata"));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("Login/Cadastrar"), HttpPost]
        public bool Cadastrar(string email, string senha)
        {
            if (ModelState.IsValid)
            {                
                Entities.Usuario usuario = new Entities.Usuario();

                usuario.Email = email;
                usuario.Senha = GetHash(senha);

                _usuarioRepository.Add(usuario);
                                
                return true;
            }
            else
            {                
                return false;
            }
        }

        [HttpPost]
        public bool ValidarLogin(string email, string senha)
        {
            if (ModelState.IsValid)
            {
                string senhaCriptografada = string.Empty;

                if (senha != null)
                    senhaCriptografada  = GetHash(senha);

               if (_usuarioRepository.GetLogin(email, senhaCriptografada) > 0)
                   return true;
               else
                   return false;
            }
            else
            {
                return false;
            }
        }
    }
}
