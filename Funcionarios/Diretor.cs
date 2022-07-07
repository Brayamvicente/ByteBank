using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        internal object logar;

        public Diretor(string nome, string profissao, int idade, string cpf, double salario) : base(nome, profissao, idade, cpf)
        {
            Salario = salario;
        }
        
        public override double Bonificacao()
        {
           double aliq = 0;
           return aliq = Salario * 0.5;
        }
        public override double AumentarSal()
        {
            Salario *= 1.5;
            return Salario;
        }

       
    }
}
