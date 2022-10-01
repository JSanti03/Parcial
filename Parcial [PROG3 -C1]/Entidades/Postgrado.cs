namespace Entidades
{
    public class Postgrado: Estudiante
    {
        public Postgrado()
        {
            
        }
        
        public Postgrado(int documento, string nombre, string apellido, string programa, int semestre, double promedioSemestre): base(documento, nombre, apellido, programa, semestre)
        {
            PromedioSemestre = promedioSemestre;
        }
        
        public override string ToString()
        {
            return $"POST;{Documento};{Nombre};{Apellido};{Programa};{Semestre};{PromedioSemestre}";
        }

        public override void CargarDatos(string[] data)
        {
            base.CargarDatos(data);
            PromedioSemestre = double.Parse(data[6]);
        }

        public double PromedioSemestre { get; set; }
    }
}