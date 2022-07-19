using MeusLivrosMVCWebApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeusLivrosMVCWebApp.Controllers
{


    public class LivrosController : Controller
    {


        Contexto db = new Contexto();
        public int id_Atualiza = 0;

        public async Task<IActionResult> Index()
        {
            ViewData["Livros"] = db.visaoLivros.ToList();

            // var idGenero = db.Livro.Select(id => id.ID_Genero);

            return View();
        }

        public IActionResult Adiciona()
        {

            var generos = Genero.Todos().ToList();
            ViewBag.data = generos;

            return View();
        }

        public async Task<IActionResult> Cadastrar(Livros Livro)
        {

            db.Livro.Add(Livro);
            db.SaveChanges();


            var NomeGenero = db.genero.Where(p => p.Id.Equals(Livro.ID_Genero)).ToList();

            var IdLivro = db.Livro.Where(p => p.NomeLivro.Equals(Livro.NomeLivro)).ToList();

            VisaoLivros vs = new VisaoLivros(IdLivro[0].Id, Livro.NomeLivro, Livro.Autor, Livro.Editora, NomeGenero[0].Estilo_Genero, Livro.StatusLivro);

            db.visaoLivros.Add(vs);
            db.SaveChanges();


            ViewData["JavaScriptFunction"] = string.Format("ShowSuccessMsg();");

            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }

        public async Task<IActionResult> Deletar(Livros Livro, int id)
        {

            Livros livro = db.Livro.Find(id);

            db.Entry(Livro).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();


            var idvisao = db.visaoLivros.Where(p => p.IDLivro.Equals(id)).ToList();

            VisaoLivros vl = db.visaoLivros.Find(idvisao[0].ID);
            db.Entry(vl).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");

            // return View(Livro);

        }




        public IActionResult Editar(int id)
        {

            id_Atualiza = id;

            Contexto db = new Contexto();
            Livros livro = db.Livro.Find(id);

            var generos = Genero.Todos().ToList();
            ViewBag.data = generos;

            return View(livro);
        }

        public async Task<IActionResult> AtualizaDados(Livros Livro, int id)
        {

            Livro.Id = id;
            db.Entry(Livro).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ModelState.Clear();

            return RedirectToAction("Index");

            // return View(Livro);

        }

    

    }
}
