using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio6;

    public class Filme
{
        public string nomeFilme {get; set;}
        public string categoria {get; set;} 
    
    public Filme(string NomeFilme, string Categoria)   
    {
      this.nomeFilme = NomeFilme;
      this.categoria = Categoria;
    }
    
    public void FilmeEscolhido()
    {
        Console.WriteLine( "Filme " + nomeFilme + " Categoria " + categoria);

    }
}