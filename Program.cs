using System;
using System.Linq;

namespace Programa_Clases_C_SHARP
{
    class Programa_de_calculo_de_area
    {
        public static string opcion;
        public static double pi = 3.14;
        class bloque_de_calculo
        {
            public static int vradio;
            public static int vbase;
            public static int valtura;
            public static double resultado;

            public void area_triangulo()
            {
                Console.WriteLine("ACONTINUACION SE LE PEDIRAN CIERTOS DATOS PARA CALCULAR EL AREA DEL TRIANGULO\nIntroduzca la base del triangulo:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase;
                Console.WriteLine("Introduzca la altura del triangulo:");
                valtura = Int32.Parse(Console.ReadLine());
                Double y = (Double)valtura;
                resultado = (valtura * vbase) / 2;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void area_circulo()
            {
                Console.WriteLine("ACONTINUACION SE LE PEDIRAN CIERTOS DATOS PARA CALCULAR EL AREA DEL CIRCULO\nIntroduzca el radio del circulo:");
                vradio = Int32.Parse(Console.ReadLine());
                Double x = (Double)vradio;
                resultado = pi * (x * x);
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void area_rectangulo()
            {
                Console.WriteLine("ACONTINUACION SE LE PEDIRAN CIERTOS DATOS PARA CALCULAR EL AREA DEL RECTANGULO\nIntroduzca la base del rectangulo:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase; menu();
                Console.WriteLine("Introduzca la altura del rectangulo:");
                valtura = Int32.Parse(Console.ReadLine());
                Double y = (Double)valtura;
                resultado = vbase * valtura;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void menu()
            {
                Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");

            }

        }
        static void Main(string[] args)
        {
            bloque_de_calculo sub= new bloque_de_calculo();
            string marco = string.Concat(Enumerable.Repeat("*", 50));
            System.Console.WriteLine(marco + "\n\t PROGRAMA PARA GEOMETRIA \n" + marco);
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");
            while (opcion != "s")
            {
                System.Console.WriteLine("Ingrese su opcion: ");
                opcion = Console.ReadLine();
                System.Console.WriteLine();
                Console.Clear();
                if (opcion == "s")
                {
                    System.Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA DE CALCULO GEOMETRICO\n\n");
                    break;
                }
                else if (opcion == "c")
                {
                    sub.area_circulo();
                    string marco2 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco2);
                    sub.menu();
                }
                else if (opcion == "r")
                {
                    sub.area_rectangulo();
                    string marco3 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco3);
                    sub.menu();
                }
                else if (opcion == "t")
                {
                    sub.area_triangulo();
                    string marco4 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco4);
                    sub.menu();
                }
                else
                {
                    System.Console.WriteLine("OH! AL PARECER OCURRIO UN ERROR!\nPOR FAVOR INTRODUZCA UNA DE LA LETRAS QUE SE LE MUESTRA EN EL MENU!");
                    System.Console.WriteLine("PARA CONTINUAR PRESIONE UNA TECLA!!!");
                    Console.ReadKey();
                    Console.Clear();
                    sub.menu();
                }
            }
        }
    }
}
