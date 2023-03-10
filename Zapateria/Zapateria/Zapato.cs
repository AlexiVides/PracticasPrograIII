using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria
{
    internal class Zapato
    {
        public string estilo;
        public string marca;
        public double size;
        public double precio;

        public string Estilo
        {
            set { estilo = value; }
            get {

                switch (estilo)
                {
                    case "1":
                        this.estilo = "Deportivo";
                        break;

                    case "2":
                        this.estilo = "Casual";
                        break;

                    case "3":
                        this.estilo = "Sandalia";
                        break;

                    default:
                        this.estilo = "Estilo de Zapato no seleccionado";
                        break;
                    case null:
                        this.estilo += "No ha definido ningun estilo de zapato";
                        break;

                }
                return this.estilo; }
        }

        public string Marca
        {
            set { marca = value; }
            get
            {

                switch (marca)
                {
                    case "1":
                        this.marca = "Adidas";
                        break;

                    case "2":
                        this.marca = "Jh";
                        break;

                    case "3":
                        this.marca = "Puma";
                        break;

                    default:
                        this.marca = "La marca de Zapato seleccionado";
                        break;
                    case null:
                        this.marca += "No ha definido ninguna marca de zapato";
                        break;

                }
                return this.marca;
            }
        }

        public double Size
        {
            set { size = value; }
            get
            {

                switch (size)
                {
                    case 1:
                        this.size = 36;
                        break;

                    case 2:
                        this.size = 37;
                        break;

                    case 3:
                        this.size = 38;
                        break;

                    default:
                        this.size = 0;
                        break;
                }
                return this.size;
            }
        }

    }
}

