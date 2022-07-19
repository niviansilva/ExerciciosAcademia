using Microsoft.AspNetCore.Mvc;
using MeusLivrosMVCWebApp.Models;

using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace MeusLivrosMVCWebApp.Controllers
{
    public class LivrosEmprestadosController : Controller
    {
        Contexto db = new Contexto();
        public IActionResult Index()
        {
            ViewData["LivrosEmp"] = db.visaoEmprestados.ToList();

            return View();
        }

        public IActionResult Adiciona()
        {

            var livros = Livros.Todos().ToList();
            ViewBag.data = livros;

            return View();
        }

        public async Task<IActionResult> Cadastrar(LivrosEmprestados livrosEmprestados)
        {
            // livrosEmprestados.DataDevolucao = string.Empty;

            livrosEmprestados.DataInicio = DateTime.Now;

            db.livrosemprestados.Add(livrosEmprestados);
            db.SaveChanges();



            Livros livro = db.Livro.Find(livrosEmprestados.IDLivro);

            livro.StatusLivro = true;

            db.Entry(livro).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            var NomeLivro = db.Livro.Where(p => p.Id.Equals(livrosEmprestados.IDLivro)).ToList();

            var IdLivroEmprestado = db.livrosemprestados.Where(p => p.IDLivro.Equals(livro.Id)).ToList();

            VisaoEmprestados ve = new VisaoEmprestados(IdLivroEmprestado[0].ID, NomeLivro[0].NomeLivro, livrosEmprestados.NomeAmigo, livrosEmprestados.Telefone, livrosEmprestados.Email, livrosEmprestados.DataInicio, true);

            db.visaoEmprestados.Add(ve);
            db.SaveChanges();


            ViewData["JavaScriptFunction"] = string.Format("ShowSuccessMsg();");

            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }

        public IActionResult Devolucao(int id)
        {

            Contexto db = new Contexto();
            LivrosEmprestados livrosEmprestados = db.livrosemprestados.Find(id);

            //livrosEmprestados.DataDevolucao = System.DateTime.Now.ToShortDateString();


            var livros = Livros.Todos().ToList();
            ViewBag.data = livros;

            return View(livrosEmprestados);
        }


        public async Task<IActionResult> Devolver(LivrosEmprestados livrosEmprestados, int id)
        {

            livrosEmprestados.ID = id;
            livrosEmprestados.DataDevolucao = DateTime.Now;
            db.Entry(livrosEmprestados).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            Livros livro = db.Livro.Find(livrosEmprestados.IDLivro);

            livro.StatusLivro = false;

            db.Entry(livro).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var IDVe = db.visaoEmprestados.Where(p => p.IDLivroEmprestado.Equals(id)).ToList();

            VisaoEmprestados ve = db.visaoEmprestados.Find(IDVe[0].ID);

            ve.StatusLivro = false;
            ve.DataDevolucao = DateTime.Now;

            db.Entry(ve).State = System.Data.Entity.EntityState.Modified;
           // db.Entry(IDVe).CurrentValues.SetValues(veNovo);
            db.SaveChanges();



            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }

        

    }
}
