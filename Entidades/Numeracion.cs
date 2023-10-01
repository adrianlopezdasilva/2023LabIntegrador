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

        public string Valor
        {
            get { return ValorNumero; }
        }

        private double BinarioADecimal(string valor)
        {
            string auxString = "Valor Invalido";
        }

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

    }
}