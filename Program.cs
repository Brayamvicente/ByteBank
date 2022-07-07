using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            /*try
            {
                ContaCorrente conta1 = new ContaCorrente(999,999);
                ContaCorrente conta2 = new ContaCorrente(999,999);
                conta1.Cadastrar("Brayam", 21, "desenvolvedor", "777.777.777-77");
                conta2.Cadastrar("Rafaela", 25, "analista", "888.888.888-88");
                conta1.SomarSaldo(200);
                conta1.DiminuSaldo(200);
                conta1.Pix(100, conta2);
                conta1.Pix(50, conta2);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (ValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Coordenador cunha = new Coordenador("Cunha","Analista de sistemas", 40, "só pra ter",4000);
            Console.WriteLine(cunha.Bonificacao());
            Console.WriteLine(cunha.AplicarBonificacao());
            Console.WriteLine(cunha.AumentarSal());*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Diretor brayam = new Diretor("Brayam", "Desenvolvedor", 21, "só pra buildar", 5000);
            brayam.Senha = "123";
            SistemaInterno Sistema = new SistemaInterno();
            Sistema.Logar(brayam, "abc");*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            /*ParceiroComercial samuel = new ParceiroComercial("samuel","123");
            SistemaInterno Sistema = new SistemaInterno();
            Sistema.Logar(samuel, "123");*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////
        }

    }
}
