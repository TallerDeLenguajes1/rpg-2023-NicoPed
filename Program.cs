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

    private static Personaje combateSimulado(Personaje luchador1, Personaje luchador2){
        int golpeP1;
        int golpeP2;
        int moneda;
        var random = new Random();
        while (luchador1.Salud >0 && luchador2.Salud >0)
        {
            moneda = random.Next(1,3);
            if (moneda == 1)
            {
                golpeP1 = calcularGolpe(luchador1,10);
                golpeP2 = calcularGolpe(luchador2,0);
            }else
            {
                golpeP1 = calcularGolpe(luchador1,0);
                golpeP2 = calcularGolpe(luchador2,10);              
            }
            luchador2.Salud -= golpeP1;
            if (luchador2.Salud > 0)
            {
                luchador1.Salud -= golpeP2;
            }
        }
        if (luchador1.Salud <= 0 ){
            return luchador1;
        }
        else
        {
            return luchador2;
        }

    }
    private static int calcularGolpe(Personaje luchador, int fuerzaExtra){
        var random = new Random();
        int danioProvocado = 0;
        int Ataque = luchador.Destreza * luchador.Fuerza + fuerzaExtra * luchador.Nivel;
        int Efectividad = random.Next(0,101);
        int Defensa = luchador.Defensa * luchador.Velocidad;
        int ConstanteDeAjuste = 500; 
        danioProvocado = ((Ataque * Efectividad)- Defensa)/ConstanteDeAjuste;
        return danioProvocado;
    }
    private static Personaje combateJugador(Personaje luchador1, Personaje luchador2){
        while (luchador1.Salud >0 && luchador2.Salud >0)
        {
            
        }
        return luchador1;
    }
}// juego (secuencia simulada , secuencia jugador)
// for coutn paso i+=2 p1 = i p2 = i+1