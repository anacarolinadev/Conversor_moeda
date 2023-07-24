using System;

namespace moeda
{
    public class Moeda
    {
        private double valor ;
        

        public Moeda()
        {
            this.valor = 0;
        }
       public bool setValor(double valor)
        {
            if (valor == 2 || valor == 0.5 || 
                valor == 0.25 && valor != 1)
            {
                this.valor = valor;
                return true;
            }
            return false;
        }

       public double getValor()
        {
            return valor;
        }

        public string getValorExtenso()
        {
            switch (valor)
            {
                case 2:
                    return "dois reais";
                case 0.5:
                    return "cinquenta centavos";
                case 0.25:
                    return "vinte e cinco centavos";
                case 0.1:
                    return "dez centavos";
                default:
                    return "um centavo";
            }

        }

        
        
    }
}