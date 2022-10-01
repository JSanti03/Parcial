using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class VistaEstudiantesPregrado: VistaEstudiantes
    {
        int i = 1;
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("|---------------[ L I S T A   D E   P R E G R A D O ]---------------|");

            foreach (var es in servicioEstudiante.Listar().Where(estudiante => estudiante.GetType() == typeof(Pregrado)).Cast<Pregrado>())
            {
                Console.WriteLine($"Estudiante N°{i}");
                Console.WriteLine($"Documento: {es.Documento}");
                Console.WriteLine($"Nombres: {es.Nombre}");
                Console.WriteLine($"Apellidos: {es.Apellido}");
                Console.WriteLine($"Programa: {es.Programa}");
                Console.WriteLine($"Semestre: {es.Semestre}");
                Console.WriteLine($"Nota 1: {es.PromedioCorte1}");
                Console.WriteLine($"Nota 2: {es.PromedioCorte2}");
                Console.WriteLine($"Nota 3: {es.PromedioCorte3}");                
                Console.WriteLine();
                i++;
            }

            Console.Write("Presione ENTER Para Continuar... ");Console.ReadKey();
        }
    }
}