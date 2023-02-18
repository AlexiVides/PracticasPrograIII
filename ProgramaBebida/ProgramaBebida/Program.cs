using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBebida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("-----Bienvenidos-----");
                int x = 0;
                Console.Clear();
                Console.WriteLine("Datos de Empleado");
                Console.WriteLine("Nombre: ");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                string Apellido = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Genero: ");
                string Genero = Console.ReadLine();
                Console.WriteLine("Datos capturados");
                Empleado empleado = new Empleado(Nombre, Apellido, Edad, Genero);

                while (x == 0)
                {
                    Console.WriteLine("------------Datos de Cliente--------------");
                    Console.WriteLine("Datos de cliente");
                    Console.WriteLine("Nombre: ");
                    string NombreC = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    string ApellidoC = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    int EdadC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Genero: ");
                    string GeneroC = Console.ReadLine();
                    Console.WriteLine("Datos capturados");
                    Cliente cliente = new Cliente(NombreC, ApellidoC, EdadC, GeneroC);

                    Console.Clear();




                    Console.WriteLine("-------------------Menu---------------------");
                    Console.WriteLine("Escriba la bebida que desea\n" +
                      "1- Calientes \n" +
                      "2- Alcoholica \n" +
                      "3- Fria");
                    string opc = Console.ReadLine();
                    Console.Clear();
                    switch (opc)
                    {
                        case "Calientes":
                            Console.WriteLine("---Escribe el Cafe a Elegir--- \n" +
                            "1- Cafe Americano \n" +
                            "2- Capuchino \n" +
                            "3- Mocca");
                            string tipoBebida = Console.ReadLine();
                            string nombreCategoria = "Calientes";
                            string nombreBebida = "Cafe";

                            if (tipoBebida.Trim() == "Cafe Americano")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigo = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precio = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Escriba si Requiere Preparacion adicional??? \n" +
                                                     "1- Si \n" +
                                                     "2- No");

                                string opc2 = Console.ReadLine();

                                if (opc2.Trim() == "Si")
                                {

                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.WriteLine("Preparacion: ");
                                    bebida.Prepara = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                }
                                else
                                {
                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                }
                            }
                            else if (tipoBebida.Trim() == "Capuchino")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigo = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precio = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Escriba si Requiere Preparacion??? \n" +
                                                    "1- Si \n" +
                                                    "2- No");

                                string opc2 = Console.ReadLine();

                                if (opc2.Trim() == "Si")
                                {

                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.WriteLine("Preparacion: ");
                                    bebida.Prepara = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                }
                                else
                                {
                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                }
                            }
                            else if (tipoBebida.Trim() == "Mocca")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigo = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precio = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Escriba si Requiere Preparacion??? \n" +
                                                   "1- Si \n" +
                                                   "2- No");

                                string opc2 = Console.ReadLine();

                                if (opc2.Trim() == "Si")
                                {

                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.WriteLine("Preparacion: ");
                                    bebida.Prepara = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                }
                                else
                                {
                                    Bebida bebida = new Bebida(codigo, nombreBebida, precio, nombreCategoria, tipoBebida);
                                    Console.Clear();
                                    Console.WriteLine("---------------------Factura de Cliente---------------------");
                                    Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                    Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                    Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                    Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No existe");
                            }
                            break;

                        case "Alcoholica":

                            if (EdadC >= 18)
                            {
                                Console.WriteLine("---Escriba la Bebida Alcoholica que desea--- \n" +
                            "1- Sidra \n" +
                            "2- Cerveza \n" +
                            "3- Smirnoff");

                                string tipoBebidaH = Console.ReadLine();
                                string nombreCategoriaH = "Alcoholica";
                                string nombreBebidaH = "Alcohol 2% a 10% ";

                                if (tipoBebidaH.Trim() == "Sidra")
                                {
                                    Console.WriteLine("Codigo: ");
                                    string codigoH = Console.ReadLine();
                                    Console.WriteLine("Precio: ");
                                    decimal precioH = Convert.ToDecimal(Console.ReadLine());

                                    Console.WriteLine("Escriba si Requiere Preparacion adicional??? \n" +
                                                    "1- Si \n" +
                                                    "2- No");

                                    string opc2 = Console.ReadLine();
                                    if (opc2.Trim() == "Si")
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.WriteLine("Preparacion: ");
                                        bebida.Prepara = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                        Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                    }
                                    else
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    }

                                }
                                else if (tipoBebidaH.Trim() == "Cerveza")
                                {
                                    Console.WriteLine("Codigo: ");
                                    string codigoH = Console.ReadLine();
                                    Console.WriteLine("Precio: ");
                                    decimal precioH = Convert.ToDecimal(Console.ReadLine());

                                    Console.WriteLine("Escriba si Requiere Preparacion adicional??? \n" +
                                                      "1- Si \n" +
                                                      "2- No");

                                    string opc2 = Console.ReadLine();
                                    if (opc2.Trim() == "Si")
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.WriteLine("Preparacion: ");
                                        bebida.Prepara = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                        Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                    }
                                    else
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    }
                                }
                                else if (tipoBebidaH.Trim() == "Smirnoff")
                                {
                                    Console.WriteLine("Codigo: ");
                                    string codigoH = Console.ReadLine();
                                    Console.WriteLine("Precio: ");
                                    decimal precioH = Convert.ToDecimal(Console.ReadLine());

                                    Console.WriteLine("Escriba si Requiere Preparacion adicional??? \n" +
                                                   "1- Si \n" +
                                                   "2- No");

                                    string opc2 = Console.ReadLine();
                                    if (opc2.Trim() == "Si")
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.WriteLine("Preparacion :");
                                        bebida.Prepara = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                        Console.WriteLine(" Preparacion: " + bebida.Preparacion());
                                    }
                                    else
                                    {
                                        Bebida bebida = new Bebida(codigoH, nombreBebidaH, precioH, nombreCategoriaH, tipoBebidaH);
                                        Console.Clear();
                                        Console.WriteLine("---------------------Factura de Cliente---------------------");
                                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                        Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                        Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No existe");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El cliente es menor de edad, Prohibida la venta a menores de Edad");
                            }


                            break;

                        case "Fria":
                            Console.WriteLine("--Escriba el Tipo de Bebida que desea-- \n" +
                                "1- Coca-Cola \n" +
                                "2- Uva \n" +
                                "3- Fresa"
                                );
                            string tipoBebidaF = Console.ReadLine();
                            string nombreCategoriaF = "Fria";
                            string nombreBebidaF = "Sodas Carbonatadas";

                            if (tipoBebidaF.Trim() == "Coca-Cola")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigoF = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precioF = Convert.ToDecimal(Console.ReadLine());
                                Bebida bebida = new Bebida(codigoF, nombreBebidaF, precioF, nombreCategoriaF, tipoBebidaF);
                                Console.Clear();
                                Console.WriteLine("---------------------Factura de Cliente---------------------");
                                Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                            }
                            else if (tipoBebidaF.Trim() == "Uva")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigoF = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precioF = Convert.ToDecimal(Console.ReadLine());
                                Bebida bebida = new Bebida(codigoF, nombreBebidaF, precioF, nombreCategoriaF, tipoBebidaF);
                                Console.Clear();
                                Console.WriteLine("---------------------Factura de Cliente---------------------");
                                Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                            }
                            else if (tipoBebidaF.Trim() == "Fresa")
                            {
                                Console.WriteLine("Codigo: ");
                                string codigoF = Console.ReadLine();
                                Console.WriteLine("Precio: ");
                                decimal precioF = Convert.ToDecimal(Console.ReadLine());
                                Bebida bebida = new Bebida(codigoF, nombreBebidaF, precioF, nombreCategoriaF, tipoBebidaF);
                                Console.Clear();
                                Console.WriteLine("---------------------Factura de Cliente---------------------");
                                Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " | " + empleado.Apellido);
                                Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
                                Console.WriteLine("Nom. Producto: " + bebida.NombreBebida + " | Categoria: " + bebida.NombreCategoria);
                                Console.WriteLine(" Precio: $" + bebida.Precio + " | Tipo: " + bebida.NombreTipo);
                            }
                            else
                            {
                                Console.WriteLine("No existe");
                            }
                            break;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}

class TipoBebida
{
    public string NombreTipo;
}

class Categoria : TipoBebida
{
    public string NombreCategoria;
}

class Bebida: Categoria, IPreparacion
{
    public string Codigo;
    public string NombreBebida;
    public decimal Precio;
    public string Prepara;

    public Bebida(string codigo, string nombreBebida, decimal precio, string nombreCategoria, string nombreTipo)
    {
        this.Codigo = codigo;
        this.NombreBebida = nombreBebida;
        this.Precio = precio;
        this.NombreCategoria = nombreCategoria;
        this.NombreTipo = nombreTipo;       
    }

    public string Preparacion()
    {
        string pre = "Se le agrego " + Prepara;
        return pre;
    }
}

public interface IPreparacion
{
    string Preparacion();
}



abstract class Persona
{
    //Atributos
    private string nombre;
    private string apellido;
    private int edad;
    private string genero;


    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }


}

class Empleado : Persona
{
    //Constructor 
    public Empleado(string nombre, string apellido, int edad, string genero)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Genero = genero;
    }
}

class Cliente : Persona
{
    //Constructor
    public Cliente(string nombre, string apellido, int edad, string genero)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Genero = genero;
    }


}
