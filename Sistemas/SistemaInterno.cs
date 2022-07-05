using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Iautenticavel cargo ,string senha)
        {
            bool usuautenticado = cargo.autenticar(senha);
            if (usuautenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
