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
}
