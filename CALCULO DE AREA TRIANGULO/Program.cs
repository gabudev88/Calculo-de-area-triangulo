using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULO_DE_AREA_TRIANGULO
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // SE INGRESA EL VALOR DE LA BASE DE UN TRIANGULO
            Console.WriteLine("Ingrese el valor en número de la base: ");
            string valorDeBase = Console.ReadLine();
            int valorDeBaseDeTriangulo = 0;
            
            // SE VEFICA QUE EL VALOR SEA UN NUMERO
            try
            {
                
                valorDeBaseDeTriangulo = int.Parse(valorDeBase);

            }
            catch (Exception)
            {
                Console.WriteLine("El numero ingresado no es un valor " +
                    "numerico");
            }

            // SE INGRESA EL VALOR DE LA ALTURA DE UN TRIANGULO
            Console.WriteLine("Ingrese el valor en número de la altura: ");
            string valorDealtura = Console.ReadLine();
            int valorDeAlturaDeTriangulo = 0;

            
            // SE VEFICA QUE EL VALOR SEA UN NUMERO
            try
            {
                valorDeAlturaDeTriangulo = int.Parse(valorDealtura);

            }
            catch (Exception)
            {
                Console.WriteLine("El numero ingresado no es un valor " +
                    "numerico");
            }

            
            // EL RESULTADO DEPENDE DEL INGRESO DE VALORES
            // LLAMAMOS A LA FUNCION QUE REALIZA EL CALCULO DE AREA
            if (CalculoDeArea(valorDeBaseDeTriangulo, valorDeAlturaDeTriangulo) == 0)
            {
                Console.WriteLine("Valores ingresados no correctos. " +
                    "No se puede calcular area de triangulo.");
            }
            else
            {
                Console.WriteLine("El valor del area de un triangulo es: " +
                CalculoDeArea(valorDeBaseDeTriangulo,
                valorDeAlturaDeTriangulo));
            }

            Console.Read();

        }

        // FUNCION QUE REALIZA EL CALCULO DE AREA

        public static int CalculoDeArea(int valorDeBaseDeTriangulo, 
                int valorDeAlturaDeTriangulo)
            {

            int area = 0;
            area = (valorDeBaseDeTriangulo * valorDeAlturaDeTriangulo) 
                / 2;
            
            return area;
            }
    }
}
