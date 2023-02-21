using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3
{
    public class MensagemCelular
    {
        public int telefone{ get; set;}
        public string mensagem{ get; set;}

        public MensagemCelular(int Telefone, string Mensagem)
        {
            this.telefone = Telefone;
            this.mensagem = Mensagem;

        }
        
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine("Telefone " + telefone + " Mensagem " + mensagem);
        }

        public void Executar()
        {
            Console.WriteLine("Método executado pelo console");
            EnviarMensagemAoTelefone();
        }
    }
}