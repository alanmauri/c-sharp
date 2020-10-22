using System;

namespace notas_escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Alumno1 = new Alumno();
            Alumno1.codigo = 1;
            Alumno1.nombre = "Alan";
            Alumno1.ingresarNota();

            Alumno Alumno2 = new Alumno();
            Alumno2.codigo = 2;
            Alumno2.nombre = "Cornejo";
            Alumno2.ingresarNota();

            Console.WriteLine("Alumno: " + Alumno1.nombre);
            Console.WriteLine("Alumno: " + Alumno2.nombre);
        }
    }
}
