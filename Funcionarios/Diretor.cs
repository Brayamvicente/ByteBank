using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class diretor : FuncionarioAutenticavel
    {
        public diretor(string nome, string profissao, int idade, string cpf, double salario) : base(nome, profissao, idade, cpf)
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
            Salario *= 0.5;
            return Salario;
        }

       
    }
}
