// See https://aka.ms/new-console-template for more information

using listaToDo;
Random rand = new Random();
int numeroTareas = rand.Next(4);
string[] descTareas = {"Arreglar", "Limpiar", "Cobrar", "Llamar"};
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

for (int i = 0; i < numeroTareas; i++)
{
    int indiceDescrip = rand.Next(0, 3);
    int durac = rand.Next(0, 100);
    int id = i + 100;
    Tarea pendiente = new Tarea(id, descTareas[indiceDescrip], durac);
    tareasPendientes.Add(pendiente);
}

Console.WriteLine("Ingrese el ID de la tarea realizada(desde 100)");
string? realizado = Console.ReadLine();
int idRealizado;
int.TryParse(realizado, out idRealizado);

for (int j = 0; j < tareasPendientes.Count; j++)
{
    if (tareasPendientes[j].TareaID == idRealizado)
    {
        tareasRealizadas.Add(tareasPendientes[j]);
        tareasPendientes.RemoveAt(j);
        break;
    }
}

