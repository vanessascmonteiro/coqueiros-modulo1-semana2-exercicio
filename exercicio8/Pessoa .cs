using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8
{
    public class Pessoa
    {
        public string nome{get; set;}
        public DateTime dataDeNascimento{get; set;}
       
    public Pessoa (string Nome, DateTime DataDeNascimento)
    {
        this.nome = Nome;
        this.dataDeNascimento = DataDeNascimento;
    }

    public void MostrarIdade()
    {
        Console.WriteLine($"Nome: {nome} tem a idade de {CalcularIdade()} anos");
    }
    private int CalcularIdade()
    {
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - dataDeNascimento.Year;
        if(dataDeNascimento > dataAtual.AddYears(-idade))
        {
            idade--;
        }
        return idade;
    }
    }


}