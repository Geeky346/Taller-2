using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public delegate int OperacionX(int n, int a);
    public delegate string ObtenerNombreDelegate(Persona persona);

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

    public class Program
    {
        //Suma
        static void Main(string[] args)
        {
            // Delegados para operaciones matemáticas
            OperacionX Operacion = Suma;
            OperacionX Operacion1 = Resta;
            OperacionX Operacion2 = Multi;
            OperacionX Operacion3 = Divi;
            OperacionX Operacion4 = Residuo;

            // Delegados para obtener información del nombre
            ObtenerNombreDelegate obtenerNombreCompleto = ObtenerNombreCompleto;
            ObtenerNombreDelegate obtenerNombrePila = ObtenerNombrePila;
            ObtenerNombreDelegate obtenerApellido = ObtenerApellido;
            ObtenerNombreDelegate obtenerNombreEnMayusculas = ObtenerNombreEnMayusculas;
            ObtenerNombreDelegate obtenerNombreEnMinusculas = ObtenerNombreEnMinusculas;

            // Obtener la información del nombre utilizando los delegados
            Persona persona = new Persona()
            {
                Nombre = "Juan Pérez",
                Apellido = "Gómez"
            };

            string nombreCompleto = obtenerNombreCompleto(persona);
            string nombrePila = obtenerNombrePila(persona);
            string apellido = obtenerApellido(persona);
            string nombreEnMayusculas = obtenerNombreEnMayusculas(persona);
            string nombreEnMinusculas = obtenerNombreEnMinusculas(persona);

            // Obtener información adicional del nombre utilizando los delegados
            int longitudNombre = ObtenerLongitudNombre(persona);
            char primeraLetraNombre = ObtenerPrimeraLetraNombre(persona);
            char ultimaLetraNombre = ObtenerUltimaLetraNombre(persona);
            bool nombreContieneEspacio = ValidarNombreContieneEspacio(persona);
            string nombreConPrimeraLetraMayuscula = ReemplazarPrimeraLetraNombrePorMayuscula(persona);

            // Mostrar la información obtenida
            Console.WriteLine("Nombre completo: " + nombreCompleto);
            Console.WriteLine("Nombre de pila: " + nombrePila);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Nombre en mayúsculas: " + nombreEnMayusculas);
            Console.WriteLine("Nombre en minúsculas: " + nombreEnMinusculas);

            Console.WriteLine("Longitud del nombre: " + longitudNombre);
            Console.WriteLine("Primera letra del nombre: " + primeraLetraNombre);
            Console.WriteLine("Última letra del nombre: " + ultimaLetraNombre);
            Console.WriteLine("¿El nombre contiene un espacio?: " + nombreContieneEspacio);
            Console.WriteLine("Nombre con primera letra mayúscula: " + nombreConPrimeraLetraMayuscula);

            // Pedir los dos números al usuario
            Console.WriteLine("Hola, por favor escribe 2 numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            // Pedir la operación al usuario
            Console.WriteLine("Escriba 1 si va hacer una suma, 2 si va hacer una resta, 3 si va hacer una multipliación, " +
                "\n4 si va hacer una divsión, 5 si va hacer el residuo de una división");
            int opcion = int.Parse(Console.ReadLine());

            // Realizar la operación seleccionada
            int resultado = 0;
            switch (opcion)
            {
                case 1:
                    //SUMA
                    resultado = Operacion(num1, num2);
                    Console.WriteLine("La suma de los numeros " + num1 + " y " + num2 + " es:" + resultado);
                    break;
                case 2:
                    //RESTA
                    resultado = Operacion1(num1, num2);
                    Console.WriteLine("La resta de los numeros " + num1 + " y " + num2 + " es: " + resultado);
                    break;
                case 3:
                    //MULTIPLICACIÓN
                    resultado = Operacion2(num1, num2);
                    Console.WriteLine("La multiplicación de los numeros " + num1 + " y " + num2 + " es: " + resultado);
                    break;
                case 4:
                //DIVISIÓN
