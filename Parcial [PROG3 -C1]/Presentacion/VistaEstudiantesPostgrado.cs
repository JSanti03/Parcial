using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class VistaEstudiantesPostgrado : VistaEstudiantes
    {
        int i = 1;
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("|---------------[ L I S T A   D E   P O S T G R A D O ]---------------|");

            foreach (var es in servicioEstudiante.Listar().Where(estudiante => estudiante.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>())
            {
                Console.WriteLine($"Estudiante N°{i}");
                Console.WriteLine($"Documento: {es.Documento}");
                Console.WriteLine($"Nombres: {es.Nombre}");
                Console.WriteLine($"Apellidos: {es.Apellido}");
                Console.WriteLine($"Programa: {es.Programa}");
                Console.WriteLine($"Semestre: {es.Semestre}");
                Console.WriteLine($"Promedio: {es.PromedioSemestre}");                
                Console.WriteLine();
                i++;
            }
            Console.Write("Presione ENTER Para Continuar... "); Console.ReadKey();
        }
    }
}