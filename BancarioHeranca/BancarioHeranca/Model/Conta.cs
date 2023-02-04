using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca
{
    class Conta
    {
        // DECLARAÇÃO VARIÁVEIS
        private double Saldo;
        private int Numero;

        public void Depositar(double Valor) 
        {
            if (Valor > 0) 
            {
                setSaldo(getSaldo() + Valor);
            }
        }
        public virtual bool Sacar(double Valor)
        {
            if (Valor > 0 && getSaldo() >= Valor)
            {
                setSaldo(getSaldo() - Valor);
                return true;
            } 
            return false;
        } 

        public string Transferir(double Valor, Conta destino) 
        {
            if (Sacar(Valor))
            {
                destino.Depositar(Valor);
                return "Valor retornado com Sucesso... ";
            }
            else
                {
                    return "Valor Insuficiente..."; 
                }
           
        }
        
        public virtual string ConsultarSaldo()
        {
            return "\nNúmero da Conta: " + getNumero() + "\nQuantidade do Saldo: " + getSaldo(); 
        }
        // FIM DA DECLARAÇÃO DE VARIÁVEIS



        // PUBLICS
        public void setSaldo(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public double getSaldo()
        {
            return Saldo;
        }


        public void setNumero(int Numero)
        {
            this.Numero = Numero;
        }

        public int getNumero()
        {
            return Numero;
        }
        // FIM PUBLICS



        // COMEÇO CONSTRUTORES 
        public Conta()
        {
            this.Saldo = 0;
            this.Numero = 0;           
        }
             
        public Conta(double Saldo, int Numero)
        {
            this.Saldo = Saldo;
            this.Numero = Numero;
        }

        public Conta(int Numero)
        {
            this.Saldo = 0;
            this.Numero = Numero;
        }
        // FIM CONSTRUTORES 

        // COMEÇO MÉTODOS



    }
}
