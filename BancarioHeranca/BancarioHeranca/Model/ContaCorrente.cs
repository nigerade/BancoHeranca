using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca.Model
{
    class ContaCorrente: Conta
    {

        // COMEÇO PRIVATE
        private double Limite;
        private double JurosChequeEspecial;
        // FIM PRIVATE


        // COMEÇO GET E SET
        public double getLimite()
        {
            return Limite;
        }
        
        public void setLimite(double Limite)
        {
            this.Limite = Limite;
        }


        public double getJurosChequeEspecial()
        {
            return JurosChequeEspecial;
        }

        public void setJurosChequeEspecial(double JurosChequeEspecial)
        {
            this.JurosChequeEspecial = JurosChequeEspecial;
        }
        // FIM GET E SET 


        // COMEÇO CONSTRUTORES
        public ContaCorrente(): base()
        {
            this.Limite = 0;
            this.JurosChequeEspecial = 0;
        }

        public ContaCorrente(double Limite, double JurosChequeEspecial, int Numero, double Saldo) : base(Saldo, Numero)
        {
            this.Limite = Limite;
            this.JurosChequeEspecial = JurosChequeEspecial;
        }
        // FIM CONSTRUTORES

        public override bool Sacar(double valor)
        {
            if (getSaldo() + getLimite() >= valor)
            {
                setSaldo(getSaldo() - valor); 
                
                return true;
            }
            return false;
        }

        public string CalcularJuros(double taxa)
        {
            if (getSaldo() < 0)
            {
                setSaldo(getSaldo() * taxa);

                return "Juro calculado com Sucesso! ";
            }

            else
            {
                return "O Valor está Positivo! ";
            }

        }

        public override string ConsultarSaldo() 
        {
            return base.ConsultarSaldo() + "\nO Limite é: " + getLimite() +
                "\nJuros Cheque Especial é: " + getJurosChequeEspecial();
        }


    }
}
