using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics;

namespace Entidades
{
    public enum ESistema
    {
        Decimal,
        Binario
    }

    public class Numeracion
    {
        private ESistema sistema ;
        private double valorNumerico;

        public ESistema Sistema
        {
            get { return sistema; }
        }

        public string Valor
        {
            get { return valorNumerico.ToString(); }
        }
        
        public Numeracion (double valor, ESistema sistema)
        {
            this.sistema = sistema;
            this.valorNumerico = valor;
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        /// <summary>
        /// Verifica que la cadena ingresada sea un binario y la convierte a decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private double BinarioADecimal(string valor)
        {
            double auxDouble;

            if(EsBinario(valor) != false)
            {
                double.TryParse(valor, out auxDouble);
                auxDouble = Convert.ToDouble(valor);
                return auxDouble;
            }

            return 0;
        }

        /// <summary>
        /// Convierne un numero decimal a binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(int valor)
        {
            string auxString = "Numero invalido";

            if(valor >= 0)
            {
                auxString = Convert.ToString(Convert.ToInt32(valor), 2);

            }

            return auxString;

        }

        /// <summary>
        /// Convierne un numero decimal a binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(string valor)
        {
            int auxValor;
            string auxString = "Numero invalido";
            
            if(int.TryParse(valor, out auxValor))
            {
                auxString = DecimalABinario(auxValor);
            }

            return auxString;

        }

        public string ConvertirA(ESistema sistema)
        {
            return null;
        }

        private void InicializarValores(string valor, ESistema sistema)
        { 

            if(EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }

            else if(int.TryParse(valor, out int auxInt))
            {
                this.valorNumerico = auxInt;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }

        }

        /// <summary>
        /// Valida que la cadena ingresada solo este compuesta por numeros binarios
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsBinario(string valor)
        {
            bool auxBool = true;

            for(int i= 0; i < valor.Length; i++)
            {
                if (valor[i] != '0' && valor[i] != '1')
                {
                    auxBool = false;
                    break;
                }
            }

            return auxBool;
        }

        /// <summary>
        /// Un Sistema y una Numeracion son iguales si el sistema es igual al sistema de la numeracion
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns></returns>
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return (sistema == numeracion.sistema);
          
        }

        /// <summary>
        /// Un Sistema y una Numeracion son distintos si el sistema es distinto al sistema de la numeracion
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns></returns>
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        /// <summary>
        /// Dos numeraciones son iguales si comparten el mismo sistema
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return (n1.sistema == n2.sistema);
        }

        /// <summary>
        /// Dos numeraciones son distintas si tienen distinto sistema
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double resultado;

            resultado = n1.valorNumerico + n2.valorNumerico;

            Numeracion auxNumeracion = new Numeracion(resultado, ESistema.Decimal);

            return auxNumeracion;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resultado;

            resultado = n1.valorNumerico - n2.valorNumerico;

            Numeracion auxNumeracion = new Numeracion(resultado, ESistema.Decimal);

            return auxNumeracion;
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double resultado;

            resultado = n1.valorNumerico * n2.valorNumerico;

            Numeracion auxNumeracion = new Numeracion(resultado, ESistema.Decimal);

            return auxNumeracion;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            double resultado;

            resultado = n1.valorNumerico / n2.valorNumerico;

            Numeracion auxNumeracion = new Numeracion(resultado, ESistema.Decimal);

            return auxNumeracion;
        }
    }
}