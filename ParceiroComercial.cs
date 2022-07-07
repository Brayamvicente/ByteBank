using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{

    public class ParceiroComercial : Iautenticavel
    {
        public ParceiroComercial (string nome,string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
