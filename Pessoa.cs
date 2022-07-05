using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class pessoa
    {
        private string _nome;
        public string nome { get { return _nome; } private set { } }

        private int _idade;
        public int idade { get { return _idade; } private set { } }

        private string _profissao;
        public string profissao { get { return _profissao; } private set { } }

        private string _cpf;
        public string cpf { get { return _cpf; } private set { } }

        public void Cadastrar(string nome, int idade, string profissao, string cpf)
        {
            _nome = nome;
            _idade = idade;
            _profissao = profissao;
            _cpf = cpf;
            Console.WriteLine("Cadastro feito com sucesso, bem vindo ao banco ByteBank");
        }
    }
}
