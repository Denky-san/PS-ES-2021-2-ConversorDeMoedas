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
        private bool senhaInvalida = false;

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
                        if (usuario.SenhaValida(loginModel.Senha) == true)
                        {
                            return RedirectToAction("Index", "Tarefas");
                            //Login.loginStatus = "Logado";
                        }

                        senhaInvalida = true;
                    }

                    if (senhaInvalida)
                    {
                        TempData["MensagemErro"] = $"Ops, A Senha é inválida. Por favor, tente novamente.";
                    }
                    else
                    {
                        TempData["MensagemErro"] = $"Ops, Usuário e/ou senha inválidos. Por favor, tente novamente.";
                    }
                    senhaInvalida = false;
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
