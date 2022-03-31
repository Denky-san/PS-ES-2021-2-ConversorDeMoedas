using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
[HttpPost]
public IActionResult Criar(TarefasModel tarefa)
{

try
{
    if (ModelState.IsValid)
    {
        _usuarioRepositorio.Adicionar(tarefa);
        TempData["MensagemSucesso"] = "Contato cadastrado com sucesso.";
        return RedirectToAction("Index");
    }

    return View(usuario);
}
catch (Exception erro)
{
    TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu usuário. Detalhes do erro: {erro.Message}";
    return RedirectToAction("Index");
}
}
*/
    }
}
