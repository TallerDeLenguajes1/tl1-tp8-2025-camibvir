namespace listaToDo
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; } // Validar que esté entre 10 y 100
        // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario

        public Tarea(int tareaID, string descripcion, int durac)
        {
            TareaID = tareaID;
            Descripcion = descripcion;
            Duracion = durac;

        }



        }

}