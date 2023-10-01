using System.Runtime.Intrinsics;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema ;
        private double ValorNumero;

        public ESistema Sistema
        {
            get { return sistema; }
        }

        /*public string Valor
        {
            get { return ValorNumero; }
        }
        */
        public Numeracion (double valor, ESistema sistema)
        {
            this.sistema = sistema;
            this.ValorNumero = valor;
        }

        /*public Numeracion(string valor, ESistema sistema)
        {
            this.sistema = sistema;
            this.ValorNumero = valor;
        }

        private double BinarioADecimal(string valor)
        {
            string auxString = "Valor Invalido";
        }*/

        private  void InicializarValores(string valor, ESistema sistema)
        { 
        
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

    }
}