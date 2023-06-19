// See https://aka.ms/new-console-template for more information
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        const int CANTIDAD_DE_PERSONAJES = 10;
        string archivoJson = "personajes.json";
        var AyudaJson = new PersonajesJson();
        var listaDePersonajes = new List<Personaje>();
        if (!AyudaJson.Existe(archivoJson))
        {
            var nuevaFabrica = new fabricaDePersonaje();
            for (int i = 0; i < CANTIDAD_DE_PERSONAJES; i++)
            {
                var nuevoPersonaje = new Personaje();
                nuevoPersonaje = nuevaFabrica.crearPersonaje();
                listaDePersonajes.Add(nuevoPersonaje);
            }
            AyudaJson.GuardarPersonajes(listaDePersonajes,archivoJson);
        }
        else
        {
            listaDePersonajes =AyudaJson.LeerPersonajes(archivoJson);
        }    
            mostrarLista(listaDePersonajes);

    }

    private static void mostrarLista(List<Personaje> listaDePersonajes){
        foreach (var personaje in listaDePersonajes)
        {
            mostrarDatos(personaje);
            Console.WriteLine("------------------");
        }
    }
    private static void mostrarDatos(Personaje personaje){
        Console.WriteLine("Nombre: "+personaje.Nombre);
        Console.WriteLine("Apodo: "+personaje.Apodo);
        Console.WriteLine("Tipo: "+personaje.Tipo);
        Console.WriteLine("Fecha_nac: "+personaje.Fecha_nac.ToShortDateString());
        Console.WriteLine("Edad: "+personaje.Edad);
        Console.WriteLine("Velocidad: "+personaje.Velocidad);
        Console.WriteLine("Destreza: "+personaje.Destreza);
        Console.WriteLine("Fuerza: "+personaje.Fuerza);
        Console.WriteLine("Nivel: "+personaje.Nivel);
        Console.WriteLine("Defensa: "+personaje.Defensa);
        Console.WriteLine("Salud: "+personaje.Salud);
    }
}