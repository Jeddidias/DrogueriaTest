using System;

namespace Drogueria_Mi_salud
{
    class Program
    {
        /// <summary>
        /// Jorge Esteban Dawson Castillo
        /// Programacion Etapa 3 ejercicio 2
        /// La Droguería Mi Salud presta sus servicios en la localidad de Suba y requiere una aplicación para poder facturar los productos que vende a sus clientes 
        /// y para ello, los productos tienen unas características que deben indicársele al cliente para que pueda escoger el producto a comprar.
        /// Para cada cliente, se tienen las opciones de compra de producto, consulta de precios por producto y devoluciones en caso de que se presenten.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int opcion1;
            //creo una variable que se llame opcion1 donde voy a guardar la opcion que ingrese el usuario
            
            Console.WriteLine("------Drogueria MI SALUD--------");
            Console.WriteLine("Menú principal");
            Console.WriteLine("1 - compra de prodcuto");
            Console.WriteLine("2 - Consulta de precios");
            Console.WriteLine("3 - Devoluciones");
            // es un problema simple, por lo que las opciones de inventario de la drogueria son limitadas
            opcion1 = int.Parse(Console.ReadLine());           
            
            if (opcion1 <= 3 || opcion1 >= 1)
                //para prevenir que el usuario seleccione una opcion invalida
            {
                
                if (opcion1 == 1)
                {
                    //Consideré que la mejor opción era crear un submenu, no queria que entrara en conflicto con la variable "opcion" por lo que la bautice opcion2 y a la primera opción1
                    Console.WriteLine("Nombre del cliente");
                    string Cliente = Console.ReadLine(); //voy en cada menu a crear una variable que pueda guardar el nombre del cliente
                    Console.Clear();
                    int opcion2;
                    Console.WriteLine("------Compra de medicamentos--------");
                    Console.WriteLine("Menú");
                    Console.WriteLine("1 - amoxacilina - precio: 5000");
                    Console.WriteLine("2 - acetaminofen - precio: 3000");
                    Console.WriteLine("3 - mieltertos - precio: 400");
                    Console.WriteLine("4- salir");
                    opcion2 = int.Parse(Console.ReadLine());
                    if (opcion2 == 1) //entonces puedo utilizar la misma formula que he venido utilizando para hacer las opciones del submenu
                    {
                        Console.WriteLine("El cliente " + Cliente + " a comprado el Medicamento:");
                        Console.WriteLine("Amoxacilina, reucerde que es antibiotico para tratar con infecciones bacterianas");
                        Console.WriteLine("Precio: 5000 pesos");
                    }
                    if (opcion2 == 2)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a comprado el Medicamento:");
                        Console.WriteLine("Acetaminofen, reucerde que es un analgesico para el dolor y la fiebre moderada");
                        Console.WriteLine("Precio: 3000 pesos");
                    }
                    if (opcion2 == 3)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a comprado el Medicamento:") ;
                        Console.WriteLine("Mieltertos, alivia el dolor de garganta de manera natural con miel y propoleo");
                        Console.WriteLine("Precio: 400 pesos");
                    }
                    if (opcion2 == 4)
                    {
                        Console.WriteLine("Vuelva pronto"); //para finalizar el programa
                    }
                }
                if (opcion1 == 2) //puedo utilizar el mismo formato para todos los submenus
                {
                    Console.WriteLine("Nombre del cliente");
                    string Cliente = Console.ReadLine();
                    Console.Clear();
                    int opcion2;
                    Console.WriteLine("------Consulta de precios--------");
                    Console.WriteLine("Menú");
                    Console.WriteLine("1 - amoxacilina");
                    Console.WriteLine("2 - acetaminofen");
                    Console.WriteLine("3 - mieltertos");
                    Console.WriteLine("4- salir");
                    opcion2 = int.Parse(Console.ReadLine());
                    if (opcion2 == 1)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a consultado el Medicamento:");
                        Console.WriteLine("Amoxacilina, reucerde que es antibiotico para tratar con infecciones bacterianas");
                        Console.WriteLine("Precio: 5000 pesos");
                    }
                    if (opcion2 == 2)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a consultado el Medicamento:");
                        Console.WriteLine("Acetaminofen, reucerde que es un analgesico para el dolor y la fiebre moderada");
                        Console.WriteLine("Precio: 3000 pesos");
                    }
                    if (opcion2 == 3)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a consultado el Medicamento:");
                        Console.WriteLine("Mieltertos, alivia el dolor de garganta de manera natural con miel y propoleo");
                        Console.WriteLine("Precio: 400 pesos");
                    }
                    if (opcion2 == 4)
                    {
                        Console.WriteLine("Vuelva pronto"); //para finalizar el programa
                    }
                }
                if (opcion1 == 3)
                {
                    Console.WriteLine("Nombre del cliente");
                    string Cliente = Console.ReadLine();
                    Console.Clear();
                    int opcion2;
                    Console.WriteLine("------Devoluciones--------");
                    Console.WriteLine("Qué mediacamento desea devolver?");
                    Console.WriteLine("1 - amoxacilina");
                    Console.WriteLine("2 - acetaminofen");
                    Console.WriteLine("3 - mieltertos");
                    Console.WriteLine("4- salir");
                    opcion2 = int.Parse(Console.ReadLine());
                    if (opcion2 == 1)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a devuelto el Medicamento:");
                        Console.WriteLine("Amoxacilina, reucerde que es antibiotico para tratar con infecciones bacterianas");
                        Console.WriteLine("Reembolsar: 5000 pesos");
                    }
                    if (opcion2 == 2)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a devuelto el Medicamento:");
                        Console.WriteLine("Acetaminofen, reucerde que es un analgesico para el dolor y la fiebre moderada");
                        Console.WriteLine("Reembolsar: 3000 pesos");
                    }
                    if (opcion2 == 3)
                    {
                        Console.WriteLine("El cliente " + Cliente + " a devuelto el Medicamento:");
                        Console.WriteLine("Mieltertos, alivia el dolor de garganta de manera natural con miel y propoleo");
                        Console.WriteLine("Reembolsar: 400 pesos");
                    }
                    if (opcion2 == 4)
                    {
                        Console.WriteLine("Vuelva pronto"); //para finalizar el programa
                    }
                }
                else
                {
                    Console.WriteLine("Cerrando programa"); // en caso de que el usuario ingrese una opción invalida
                }
            }       

                
            
        }
    }
}
