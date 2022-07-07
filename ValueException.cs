using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ValueException : Exception
    {
        public ValueException()
        {
            Console.WriteLine("Não é permitido saldo negativo");
        }
        public ValueException(string mensagem) : base(mensagem) 
        {

        }
    }
}
