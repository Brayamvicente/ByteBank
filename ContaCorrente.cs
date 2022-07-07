using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente : pessoa
    {
        private int numconta { get; }
        public int numagencia { get; }
        private double _saldo = 100;
        public double saldo { get { return _saldo; } private set { } }
        public ContaCorrente(int conta, int agencia)
        {
            if (conta <= 0)
            {
                throw new ArgumentException("Erro de argumento na criação de nova conta",nameof(conta));
            }
            if (agencia <= 0)
            {
                throw new ArgumentException("Erro de argumento na criação de nova conta", nameof(agencia));
            }
            numconta = conta;
            numagencia = agencia;
        }

        public void SomarSaldo(double valor)
        {
            _saldo += valor;
        }
        public void DiminuSaldo(double valor)
        {
            if(_saldo >= valor)
            {
                _saldo -= valor;                
            }
            else
            {
                throw new ValueException();
            }
            
        }
        public bool Pix(double valor,ContaCorrente contaDest)
        {
            if (_saldo >= valor)
            {
                DiminuSaldo(valor);
                contaDest.SomarSaldo(valor);
                Console.WriteLine("Pix efetuado com sucesso, Consulte o saldo");
                return true;
            }
            else
            {
                throw new ValueException();
            }
        }    

        
    }
}
