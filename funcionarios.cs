using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class funcionarios : pessoa
    {
        private double _salario;
        public double salario { get { return _salario; } private set { _salario += aliqu; } }
        
        double aliqu = 0;

        public double Bonificacao(short bonific, double salario)
        {

            switch (bonific)
            {
                case 1:
                    return aliqu = salario;
                case 2:
                    return aliqu = salario * 0.8;
                case 3:
                    return aliqu = salario * 0.5;
                case 99:
                    return aliqu = salario * 0.3;
                default:
                    Console.WriteLine("");
                    return aliqu;
            }

        }
        public void CadastrarFuncionario(ContaCorrente cliente, short bonific,double salario)
        {
            Bonificacao(bonific, salario);
            this.Cadastrar(cliente.nome, cliente.idade, cliente.profissao, cliente.cpf);
            Console.WriteLine("O salário apresentado foi " + salario + " a bonificação no código " + bonific + " total de bonificação " + aliqu);
        }
        public void CadastrarFuncionario(string nome, string profissao, int idade, string cpf, double salario, short bonific)
        {
            this.Cadastrar(nome, idade, profissao, cpf);
            Console.WriteLine("O salário apresentado foi " + salario + " a bonificação no código " + bonific + " total de bonificação " + aliqu);
        }

    }
}
