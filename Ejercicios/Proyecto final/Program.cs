using System;

namespace SistemaPos
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcion = "";
            ProyectoFinal pos = new ProyectoFinal();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("     POS-Dispositivo de uso comercial    ");
                Console.WriteLine("");
                Console.WriteLine("            Repostería Nahyeli           ");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
                Console.WriteLine("A continuación, elija una opción:");                
                Console.WriteLine("");
                Console.WriteLine("         1 - Lista de Usuarios");
                Console.WriteLine("         2 - Lista de Productos");
                Console.WriteLine("         3 - Lista de Clientes");
                Console.WriteLine("         4 - Ingreso de Entradas");
                Console.WriteLine("         5 - Reporte de Entradas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();


                switch (opcion)
                {

                    case "1": 
                        pos.ListarUsuarios();
                        break;
                    
                    case "2": 
                        pos.ListarPostres();
                        break;
                    
                    case "3": 
                        pos.ListarClientes();
                        break;
                    
                    case "4": 
                        pos.CrearEntrada();
                        break;

                    case "5": 
                        pos.ListarEntrada();
                        break;
                                
                    default:
                    break;

                }


                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}