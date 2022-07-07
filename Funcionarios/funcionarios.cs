using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionarios : pessoa
    {
        public double Salario { get; protected set; }
        int totalDeFuncionarios = 0;
        public double salBon { get; private set; }
        public Funcionarios(string nome, string profissao, int idade, string cpf)
        {
           this.Cadastrar(nome, idade, profissao, cpf);
            totalDeFuncionarios++;
            
        }
        public Funcionarios(ContaCorrente cliente)
        {
            this.Cadastrar(cliente.nome, cliente.idade, cliente.profissao, cliente.cpf);
            totalDeFuncionarios++;
        }

        //double aliquS = 0;

        public abstract double Bonificacao();
        
        //public double Bonificacao(short bonific, double salario)
        //{

        //    switch (bonific)
        //    {
        //        case 1:
        //            return aliquS = salario * 0.8;
        //        case 2:
        //            return aliquS = salario * 0.5;
        //        case 3:
        //            return aliquS = salario * 0.3;
        //        case 99:
        //            return aliquS = salario * 0.1;
        //        default:
        //            Console.WriteLine("indique um código válido");
        //            return aliquS;
        //    }

        //}
        
        public double AplicarBonificacao()
        {
            Salario = Bonificacao() + Salario;
            return Salario;
        }
        public abstract double AumentarSal();
    }
}
