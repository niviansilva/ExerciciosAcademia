using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Livro
    {
        //atributos
        public string titulo;
        public string autor;
        public int paginas;
        public int ano;
        public int edição;
        
        //construtor
        public Livro (String tit, String au, int pag , int an, int ed)
        {
            titulo = tit;
            autor = au;
            paginas = pag;
            ano = an;
            edição = ed;

        }
        //metodos
        public void apresentaInfoLivro()
        {
            Console.WriteLine(" O livro com o titulo de " + titulo + " do autor " + autor + " edição " + edição + " lançado no ano de  " + ano + " com " + paginas + " páginas");
        }


    }
}
