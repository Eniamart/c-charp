﻿using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(); 
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno a = new Alumno(); 
            Console.WriteLine("Hola Mundo!");
        }
    }
}
