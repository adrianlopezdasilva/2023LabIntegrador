using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar (char operador)
        {
            Numeracion auxNumeracion;
            switch(operador)
            {
                case '+':
                    auxNumeracion = primerOperando + segundoOperando;
                    break;

                case '-':
                    auxNumeracion = PrimerOperando - SegundoOperando;
                    break;
                case '*':
                    auxNumeracion = PrimerOperando * SegundoOperando;
                    break;
                case '/':
                    auxNumeracion = PrimerOperando / SegundoOperando;
                    break;

                default:
                    auxNumeracion = PrimerOperando + SegundoOperando;
                    break;
            }

            return auxNumeracion;
        }


    }
}
