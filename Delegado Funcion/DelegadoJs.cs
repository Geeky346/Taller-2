﻿namespace delegado
{

 
    internal class Program
    {  
        
        delegate double OperacionMatematica(double a, double b);

        // Funciones para realizar las operaciones matemáticas
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("No se puede dividir por cero.");
        }
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 5;

            // Creación de instancias del delegado y asignación de funciones
            OperacionMatematica operacion;

            operacion = Sumar;
            Console.WriteLine($"Suma: {num1} + {num2} = {operacion(num1, num2)}");

            operacion = Restar;
            Console.WriteLine($"Resta: {num1} - {num2} = {operacion(num1, num2)}");

            operacion = Multiplicar;
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {operacion(num1, num2)}");

            operacion = Dividir;
            Console.WriteLine($"División: {num1} / {num2} = {operacion(num1, num2)}");
        }
    



    }
}