using System;

namespace Presentacion
{
    public class VistaPrincipal
    {
        private VistaEstudiantesPostgrado vistaEstudiantesPostgrado = new VistaEstudiantesPostgrado();
        private VistaEstudiantesPregrado vistaEstudiantesPregrado = new VistaEstudiantesPregrado();
        private VistaEstudiantes vistaEstudiantes = new VistaEstudiantes();

        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("|---------- [M E N U] ----------|");
                Console.WriteLine("1. Estudiantes de Pregrado");
                Console.WriteLine("2. Estudiantes de Postgrado");
                Console.WriteLine("3. Promedio Por Programa");
                Console.WriteLine("4. Estudiantes Destacados");
                Console.WriteLine("5. Salir");
                
                Console.Write("\nDigite Su Opción... ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        vistaEstudiantesPregrado.Lista();
                        break;
                    case 2:
                        vistaEstudiantesPostgrado.Lista();
                        break;
                    case 3:
                        vistaEstudiantes.PresentarPromedio();
                        break;
                    case 4:
                        vistaEstudiantes.PresentarDestacado();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nGracias por usar el programa");
                        Console.WriteLine("Presione ENTER para salir");
                        break;
                }
            } while (op != 5);
        }
    }
}