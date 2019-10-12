using System;

namespace Tiendita
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------Bienvendio a abarrotes Charly------------------------");            
            int ClientesMAX = 2;
            int clienteE;            
            double DINEROCAJA=0;
            bool aux = false;            
            for(int i=1; i <= ClientesMAX; i++)
            {
                double DINEROCLIENTE = 0;
                int contadorP = 0;
                aux = true;              
                while (aux)
                {
                    //Comienza la venta de productos
                    
                    Console.ForegroundColor = ConsoleColor.Black;                
                    clienteE = i;
                    Console.Write("¿Bienvenido Cliente: {0} \n", clienteE +
                        "\n ¿-------- ¿Que producto/s llevará hoy? -------- \n \n"
                        + "1) Kilo Karne de Puerko\n" +
                        "2) Sabritas 'Sheetos'\n" +
                        "3) 12 pack de Juguitos\n" +
                        "4) Chocolate Fino 'Morfino'\n" +
                        "5) Huevos 'CarteritaFeliz' \n" +
                        "6) Kilo Carne de Venado \n \n"+
                         "  --------- PRESIONA 7 PARA SALIR ---------");
                    int continuar;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    continuar = Convert.ToInt32(Console.ReadLine());
                    switch (continuar)
                    {
                        
                        case 1:Console.WriteLine("Gracias, este producto tuvo un costo de $85.50");
                            DINEROCLIENTE += 85.50;
                            DINEROCAJA += 85.50;
                            contadorP += 1;
                            break;
                        case 2:
                            Console.WriteLine("Gracias, este producto tuvo un costo de $25.10");
                            DINEROCLIENTE += 25.10;
                            DINEROCAJA = DINEROCAJA + 25.10;
                            contadorP = contadorP + 1;
                            break;
                        case 3:
                            Console.WriteLine("Gracias, este producto tuvo un costo de $192.20");
                            DINEROCLIENTE += 192.20;
                            DINEROCAJA += 192.20;
                            contadorP = contadorP + 1;
                            break;
                        case 4:
                            Console.WriteLine("Gracias, este producto tuvo un costo de $157.80");
                            DINEROCLIENTE += 157.80;
                            DINEROCAJA = DINEROCAJA + 150;
                            contadorP = contadorP + 1;
                            break;
                        case 5:
                            Console.WriteLine("Gracias, este producto tuvo un costo de $78.90");
                            DINEROCLIENTE += 78.90;
                            DINEROCAJA = DINEROCAJA + 78.90;
                            contadorP = contadorP + 1;
                            break;
                        case 6:
                            Console.WriteLine("Gracias, este producto tuvo un costo de $349.90");
                            DINEROCLIENTE += 349.90;
                            DINEROCAJA = DINEROCAJA + 349.90;
                            contadorP = contadorP + 1;
                            break;
                        case 7:
                            Console.WriteLine("  Gracias por su compra, Buen dia \n ");
                            aux = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ERROR Porfavor proporciona un numero dentro del 1 al 7:\n");
                            break;
                            
                    }                                                                            
                }
                Console.WriteLine("  Usted ha comprado {0} Productos: ", contadorP);
                Console.Write("  Con un costo TOTAL de $ {0}\n ", DINEROCLIENTE);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("--------CIERRE DE CAJA--------\n");
            Console.Write("El dinero total en caja es igual a: $ {0} ", DINEROCAJA);

        }
    }
}