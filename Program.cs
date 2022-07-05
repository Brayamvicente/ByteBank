using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.Cadastrar("Brayam", 21, "desenvolvedor","777.777.777-77");
            ContaCorrente conta2 = new ContaCorrente();
            conta2.Cadastrar("Rafaela", 25, "analista", "888.888.888-88");
            conta1.SomarSaldo(200);           
            conta1.DiminuSaldo(50);
            conta1.Pix(100,conta2);
            funcionarios novofuncio = new funcionarios();
            novofuncio.CadastrarFuncionario(conta1, 1, 15000.00);

        }
    }
}
