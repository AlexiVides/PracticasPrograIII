using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zapato zapato = new Zapato();

            int opc;
            double p;

            while (true)
            {
                Console.WriteLine("----------Bienvenido al sistema--------------\n");
                Console.WriteLine("Selecione una tienda para comprar\n");
                Console.WriteLine("Menu");
                Console.WriteLine("1-Tienda La Niña Mary");
                Console.WriteLine("2-Tienda Soto");
                Console.WriteLine("3-Tienda Que bendicion ve");
                Console.WriteLine("4-Salir");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("-------Tienda Niña Mary-------");
                        Menu menuM = new Menu();

                        menuM.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuM.Marca();
                        zapato.marca = Console.ReadLine();

                        menuM.Size();
                        zapato.size = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite el precio:");
                        double p1 = Convert.ToDouble(Console.ReadLine());
                        double desc = 0.05;

                        zapato.precio = p1 - (p1 * desc);

                        Console.WriteLine("\n-------factura-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.Size);
                        Console.WriteLine("Descuento: " + desc);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;
                    case 2:
                        Console.WriteLine("-------Tienda Soto-------");
                        Menu menuS = new Menu();

                        menuS.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuS.Marca();
                        zapato.marca = Console.ReadLine();

                        menuS.Size();
                        zapato.size = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite el precio:");
                        double p2 = Convert.ToDouble(Console.ReadLine());
                        double desc2 = 0.10;

                        zapato.precio = p2 - (p2 * desc2);

                        Console.WriteLine("\n-------factura-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.Size);
                        Console.WriteLine("Descuento: " + desc2);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;
                        
                    case 3:
                        Console.WriteLine("-------Tienda que bendicion-------");
                        Menu menuB = new Menu();

                        menuB.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuB.Marca();
                        zapato.marca = Console.ReadLine();

                        menuB.Size();
                        zapato.size = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite el precio:");
                        double p3 = Convert.ToDouble(Console.ReadLine());
                        double desc3 = 0.15;

                        zapato.precio = p3 - (p3 * desc3);

                        Console.WriteLine("\n-------factura-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.Size);
                        Console.WriteLine("Descuento: " + desc3);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break; 
                    default:
                        Console.WriteLine("La opcion no esta definida");
                        break;
                }
            }

             


        }
        
    }
}

class Menu
{
    public void Estilo()
    {
        Console.WriteLine("Estilos");
        Console.WriteLine("1-Deportivo");
        Console.WriteLine("2-Casual");
        Console.WriteLine("3-Sandalias");
    }
    public void Marca()
    {
        Console.WriteLine("Marcas");
        Console.WriteLine("1-Adidas");
        Console.WriteLine("2-JH");
        Console.WriteLine("3-Puma");
    }
    public void Size()
    {
        Console.WriteLine("Size");
        Console.WriteLine("1-36");
        Console.WriteLine("2-37");
        Console.WriteLine("3-38");
    }
}


