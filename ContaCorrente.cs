using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente : pessoa
    {
        public int numconta;
        public int numagencia;
        private double _saldo = 100;
        public double saldo { get { return _saldo; } private set { } }

        
        public void SomarSaldo(double valor)
        {
            _saldo += valor;
        }
        public bool DiminuSaldo(double valor)
        {
            if(_saldo >= valor)
            {
                _saldo -= valor;                
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            
        }
        public bool Pix(double valor,ContaCorrente contaDest)
        {
            if (_saldo >= valor)
            {
                DiminuSaldo(valor);
                SomarSaldo(valor);
                Console.WriteLine("Pix efetuado com sucesso, Consulte o saldo");
                return true;
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
                return false;
            }
        }    

        
    }
}
