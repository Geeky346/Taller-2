using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
public delegate int OperacionX(int n, int a);
public class Program
{
    //Suma
    static void Main(string[] args)
    {
       OperacionX Operacion = Suma;
       OperacionX Operacion1 = Resta;
       OperacionX Operacion2 = Multi;
       OperacionX Operacion3 = Divi;
       OperacionX Operacion4 = Residuo;
        
            int opcion = 0;

            Console.WriteLine("Hola, por favor escribe 2 numeros");
            int num1 =int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba 1 si va hacer una suma, 2 si va hacer una resta, 3 si va hacer una multipliación, " +
                "\n4 si va hacer una divsión, 5 si va hacer el residuo de una división");
                opcion =int.Parse(Console.ReadLine());
            switch (opcion){
                case 1:
                    //SUMA
                    int resultado = Operacion(num1, num2);
                    Console.WriteLine("La suma de los numeros "+ num1+" y "+num2+" es:"+resultado);
                    break;
    case 2:
     //RESTA
        int resultado1 = Operacion1(num1, num2);
        Console.WriteLine("La resta de los numeros " + num1 + " y " + num2 + " es: " + resultado1);
        break;
     case 3:
        //MULTIPLICACIÓN
        int resultado2 = Operacion2(num1, num2);
        Console.WriteLine("La multiplicación de los numeros " + num1 +" y " + num2 + " es: " + resultado2);
        break;
    case 4:
        //DIVISIÓN
        int resultado3 = Operacion3(num1, num2);
        Console.WriteLine("La división de los numeros " + num1 + " y " + num2 + " es: " + resultado3);
        break;
    case 5:
        //RESIDUO
        int resultado4 = Operacion4(num1, num2);
        Console.WriteLine("El residuo de la división de los números " + num1 + " y " + num2 + " es: ss" + resultado4);
        break;
    }
}
