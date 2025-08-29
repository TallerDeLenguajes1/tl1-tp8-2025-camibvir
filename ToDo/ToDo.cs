namespace listaToDo
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; } // Validar que esté entre 10 y 100

        public Tarea(int tareaID, string descripcion, int durac)
        {
            TareaID = tareaID;
            Descripcion = descripcion;
            Duracion = durac;

        }

        public void mostrarTarea()
        {
            Console.WriteLine($"ID de la tarea: {TareaID}");
            Console.WriteLine($"Descripción de la tarea: {Descripcion}");
            Console.WriteLine($"Duración de la tarea: {Duracion}");
        }

        }

}
