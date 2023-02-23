using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5;

    public class Cobrar
    {
        private decimal _valor;
        private decimal _multa;

    
    public Cobrar (decimal valor, decimal multa)
    {
        this._valor = valor;
        this._multa = multa;
    }

    public void Calcular()
    {
      Console.WriteLine( "Valor Cobrado " + _valor + " Multa " + _multa + " Soma Valor " + CalcularMulta());
       
    }
    
    private decimal CalcularMulta() 
    {
        return _valor + _multa;
    }

    
}