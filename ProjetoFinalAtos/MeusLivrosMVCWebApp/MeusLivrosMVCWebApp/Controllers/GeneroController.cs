using Microsoft.AspNetCore.Mvc;
using MeusLivrosMVCWebApp.Models;

using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace MeusLivrosMVCWebApp.Controllers
{
    public class GeneroController : Controller
    {
        Contexto db = new Contexto();
        public int id_atualiza = 0;
        public IActionResult Index()
        {
             

            return View(db.genero.ToList());
        }

        public async Task<IActionResult> Cadastrar(Genero Genero)
        {

            db.genero.Add(Genero);
            db.SaveChanges();


            ViewData["JavaScriptFunction"] = string.Format("ShowSuccessMsg();");

            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }

        public IActionResult Adiciona()
        {

            return View();
        }

        public IActionResult Editar(int id)
        {
            id_atualiza = id;
            Contexto db = new Contexto();
            Genero genero = db.genero.Find(id);

            return View(genero);
        }

        public async Task<IActionResult> AtualizaDados(Genero genero, int id)
        {

            genero.Id = id;
            db.Entry(genero).State = EntityState.Modified;
            db.SaveChanges();
           


            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }
        public async Task<IActionResult> Deletar(Genero genero, int id)
        {

            Genero generos = db.genero.Find(id);

            db.Entry(generos).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");

            // return View(Livro);

        }
    }
}
