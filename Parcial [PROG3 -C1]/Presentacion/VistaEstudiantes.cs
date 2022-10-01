using System;
using Logica;

namespace Presentacion
{
    public class VistaEstudiantes
    {
        protected ServicioEstudiante servicioEstudiante = new ServicioEstudiante();
        
        public void PresentarPromedio()
        {
            Console.Clear();
            Console.WriteLine("-[PROMEDIO DE ESTUDIANTE POR PROGRAMA]-");
            Console.WriteLine("Programas De PreGrado" +
                            "\n1. Sistemas." +
                            "\n2. Derecho." +
                            "\n3. Enfermeria." +
                            "\n4. Licenciatura." +
                            "\n5. Musica.");

            Console.WriteLine("\nProgramas De PostGrado" +
                            "\n1. Desarrollo Software." +
                            "\n2. Derecho Administrativo." +
                            "\n3. Auditoria En Salud.");
            Console.Write("\nDigite El Nombre Del Programa: ");
            var programa = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicioEstudiante.Promedio(programa));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }

        public void PresentarDestacado()
        {
            Console.Clear();
            Console.WriteLine("-[ESTUDIANTES DESTACADOS POR PROGRAMA]-");
            Console.WriteLine("Programas De PreGrado" +
                            "\n1. Sistemas." +
                            "\n2. Derecho." +
                            "\n3. Enfermeria." +
                            "\n4. Licenciatura." +
                            "\n5. Musica.");

            Console.WriteLine("\nProgramas De PostGrado" +
                            "\n1. Desarrollo Software." +
                            "\n2. Derecho Administrativo." +
                            "\n3. Auditoria En Salud.");
            Console.Write("\nDigite El Nombre Del Programa: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicioEstudiante.Destacado(materia));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }
    }
}