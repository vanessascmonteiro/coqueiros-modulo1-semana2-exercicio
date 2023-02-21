using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Guitarra
    {
        private static string afinacao;  
        
        static Guitarra()
        {
           afinacao = "SOL";
        }

        private void TomAfinado()
        { 
        Console.WriteLine($"A guitarra está com afinação em " + afinacao);
        }
        public void Tocar()
        {
        TomAfinado();
        }   
        public void Tocar(string afinacaoAtual)
        {
        afinacao = afinacaoAtual;
        TomAfinado();
        }
        
        


     }


        
        
    }
