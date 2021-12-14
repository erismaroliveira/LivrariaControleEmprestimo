using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService oLivroService = new LivroService();

        public IActionResult Index()
        {
            List<Livro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPk(id);
            return View(oLivro);
        }

        public IActionResult Edit(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPk(id);
            ViewBag.anoPublicacao = oLivro.LivroAnoPublicacao.Year;
            return View(oLivro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.Alterar(model);

            int id = oLivro.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
