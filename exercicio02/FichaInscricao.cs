using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio02
{
    public class FichaInscricao
    {
        private int id;
        public string nome {get; set;}

        public DateTime dataDeNascimento {get; set;}   

        public Boolean menorIdade {get; set;}

        public FichaInscricao (int Id, string Nome, DateTime DataDeNascimento, Boolean MenorIdade) 
        {
            this.id = Id;
            this.nome = Nome;
            this.dataDeNascimento = DataDeNascimento;
            this.menorIdade = MenorIdade;
        } 
    
        public void ImprimeInscricao()
{
    Console.WriteLine( "Id: {id}");
    Console.WriteLine( "Nome: {nome}");
    Console.WriteLine( "Data de nascimento: {datadeNascimento}");
if(menorIdade == true){
    Console.WriteLine("Maior de Idade");

}
else{
    Console.WriteLine("Menor de Idade");

}
}
    }
}


        

    
                
