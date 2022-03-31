using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Repositorio;

namespace TodoList.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    UsuarioModel usuario =_usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {
                        if(usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Tarefas");
                            //Login.loginStatus = "Logado";
                        }

                        else
                        {
                            TempData["MensagemErro"] = $"Ops, A Senha é inválida. Por favor, tente novamente.";
                        }

                    }

                    TempData["MensagemErro"] = $"Ops, Usuário e/ou senha inválidos. Por favor, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
