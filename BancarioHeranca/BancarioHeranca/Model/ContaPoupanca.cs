using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca.Model
{
    class ContaPoupanca: Conta 
    {
        // ATRIBUTOS
        private double ReajusteMensal;


        // ENCAPSULAMENTOS
        public void setReajusteMensal(double ReajusteMensal)
        {
            this.ReajusteMensal = ReajusteMensal;
        }

        public double getReajusteMensal()
        {
            return ReajusteMensal;
        }
        // FIM ENCAPSULAMENTOS



        // COMEÇO CONSTRUTORES
        public ContaPoupanca() : base()
        {
            this.ReajusteMensal = 0;
        }

        public ContaPoupanca(double ReajusteMensal, int Numero, double Saldo) : base(Saldo, Numero)
        {
            this.ReajusteMensal = ReajusteMensal;
        
        }
        // FIM CONSTRUTORES 


        // MÉTODOS
        private void AtualizarSaldo()
        {
            setSaldo(getReajusteMensal() + getSaldo());
        }

        public void CalcularRendimento(double taxa)
        {
            if (getSaldo() > 0)
            {
                setReajusteMensal(taxa * getSaldo());

                AtualizarSaldo();


            }
        }
        // FIM  MÉTODOS


    }
}
