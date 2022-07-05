using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : funcionarios, Iautenticavel
    {
        public string Senha {get; set;}
        public FuncionarioAutenticavel(string nome, string profissao, int idade, string cpf)
            :base(nome, profissao, idade, cpf)
        {

        }
        public bool autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
