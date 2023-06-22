// See https://aka.ms/new-console-template for more information
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        var mensaje = new Mensajes();
        const int CANTIDAD_DE_PERSONAJES = 8;
        string archivoJson = "personajes.json";
        int opcionFinal = 0;
        string? buffer;
        var AyudaJson = new PersonajesJson();
        var listaDePersonajes = new List<Personaje>();
    do
    {
            
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

        if (listaDePersonajes.Count > 0)
        {
            // mensaje.mostrarLista(listaDePersonajes);
            var ganador = new Personaje();
            ganador = Juego(listaDePersonajes);
            mensaje.mensajeFinal(ganador);

            // if (ganador == personajePrincipal)
            // {
                // mensaje.finalUsuarioGanador()
            // } 
            mensaje.gameOver();
        }

        buffer = Console.ReadLine();
        if (! int.TryParse(buffer,out opcionFinal) || opcionFinal != 1)
        {
            opcionFinal = 0;
        }
    } while (opcionFinal != 0);
    
    }
    private static Personaje Juego(List<Personaje> listaDePersonajes){
        var listaGanadores = new List<Personaje>();
        var ganador = new Personaje();
        var random = new Random(DateTime.Now.Microsecond);
        var mensaje = new Mensajes();
        while (listaDePersonajes.Count > 1)
        {
            for (int i = 0; i < listaDePersonajes.Count; i+=2)
            {
                mensaje.VS(listaDePersonajes[i],listaDePersonajes[i+1]);
                // Console.WriteLine($"\n{listaDePersonajes[i].Nombre} VS {listaDePersonajes[i+1].Nombre}");
                if (i == 0) // despues se cambiara por si es personaje Principal
                {
                    mensaje.reglasDelMinijuegoSuerte();
                    ganador = combateJugador(listaDePersonajes[i],listaDePersonajes[i+1]);
                    //debo pedirle al usuario que beneficio quiere tener, debo preguntar si es que el que gano es el PerPrin
                    //Pero eso es tarea para otro momento
                    // ganador = recibirBeneficio(ganador,opcion);
                    ganador = recibirBeneficio(ganador,random.Next(1,6)); // por el momento

                }else
                {
                    ganador = combateSimulado(listaDePersonajes[i],listaDePersonajes[i+1]);
                    //doy las mejoras
                    ganador = recibirBeneficio(ganador,random.Next(1,6));

                }
                mensaje.ganador(ganador);
                // Console.WriteLine ("Ganador: "+ganador.Nombre);
                mensaje.presionaEnter();
                listaGanadores.Add(ganador);
            }
            listaDePersonajes.Clear();
            listaDePersonajes.AddRange(listaGanadores);
            listaGanadores.Clear();
        }
        return listaDePersonajes[0]; 
    }
    private static Personaje combateSimulado(Personaje luchador1, Personaje luchador2){
        int golpeP1;
        int golpeP2;
        int moneda;
        int auxSaludLuch1 = luchador1.Salud;
        int auxSaludLuch2 = luchador2.Salud;
        var random = new Random(DateTime.Now.Millisecond);
        while (luchador1.Salud >0 && luchador2.Salud >0)
        {
            // Console.WriteLine("============================");
            // Console.WriteLine("Salud P1:" + luchador1.Salud);
            // Console.WriteLine("Salud P2:" + luchador2.Salud);
            // Console.WriteLine("============================");
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
            luchador2.Salud = auxSaludLuch2;
            return luchador2;
        }
        else
        {
            luchador1.Salud = auxSaludLuch1;
            return luchador1;
        }

    }
    private static int calcularGolpe(Personaje luchador, int fuerzaExtra){
        var random = new Random(DateTime.Now.Millisecond);
        int danioProvocado = 0;
        int Ataque = luchador.Destreza * (luchador.Fuerza + fuerzaExtra) * luchador.Nivel;
        int Efectividad = random.Next(0,101);
        int Defensa = luchador.Defensa * luchador.Velocidad;
        int ConstanteDeAjuste = 500; 
        danioProvocado = ((Ataque * Efectividad)- Defensa)/ConstanteDeAjuste;
        return danioProvocado;
    }
    private static Personaje combateJugador(Personaje PersonajePrincipal, Personaje Contrincante){
        int auxSaludPersPrinc = PersonajePrincipal.Salud;
        int auxSaludContricante = Contrincante.Salud;
        var mensaje = new Mensajes();
        int golpePersonajePrincipal = 0;
        int golpeContrincante = 0;
        int Resultado;
  
        while (PersonajePrincipal.Salud >0 && Contrincante.Salud >0)
        {
            golpePersonajePrincipal = 0;
            golpeContrincante = 0;
            // Console.WriteLine("============================");
            // Console.WriteLine("Tu salud:" + PersonajePrincipal.Salud);
            // Console.WriteLine("Contrincante:" + Contrincante.Salud);
            // Console.WriteLine("============================");
            mensaje.mostrarSalud(PersonajePrincipal,Contrincante);
            Resultado = elMasCercano();
            if (Resultado == 3)
            {
                // Console.WriteLine("===Empate!!==");
                mensaje.Empate();
                golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,0);
                golpeContrincante = calcularGolpe(Contrincante,0); 
            }else
            {    
                if (Resultado == 1)
                {
                    // Console.WriteLine("==Tu ganas==");
                    mensaje.tuGanas();
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,10);
                    golpeContrincante = calcularGolpe(Contrincante,0);
                }else
                {
                    // Console.WriteLine("==Pierdes==");
                    mensaje.tuPierdes();
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,0);
                    golpeContrincante = calcularGolpe(Contrincante,10);              
                }
            }
            mensaje.presionaEnter();
            Contrincante.Salud -= golpePersonajePrincipal;
            if (Contrincante.Salud > 0)
            {
                PersonajePrincipal.Salud -= golpeContrincante;
            }
            mensaje.mostrarDanio(golpePersonajePrincipal,golpeContrincante);
        }
        if (PersonajePrincipal.Salud <= 0 ){
            Contrincante.Salud = auxSaludContricante;
            return Contrincante;
        }
        else
        {
            PersonajePrincipal.Salud = auxSaludPersPrinc;
            return PersonajePrincipal;
        }
    }
    private static int elMasCercano(){
        var random = new Random(DateTime.Now.Millisecond);
        int numeroContrincante;
        int numeroDelMago;
        int numeroIngresado;
        string? buffer;
        var mensaje = new Mensajes();

        Console.Write("Ingresa » ");
        buffer = Console.ReadLine();
        while ( !(int.TryParse(buffer, out numeroIngresado)) || (numeroIngresado < 0 || numeroIngresado > 9) )
        {
            // Console.WriteLine("================================");
            // Console.WriteLine("Creo que no me has entendido bien");
            // Console.WriteLine("== Ingrese un número del 0 al 9 ==");
            // Console.Write("Intentelo de vuelta: ");
            mensaje.malIngresoEnSuerte();
            buffer = Console.ReadLine();
        }
        numeroContrincante = random.Next(0,10);
        numeroDelMago = random.Next(0,10);
        mensaje.suerte(numeroIngresado,numeroDelMago,numeroContrincante);
        if (distanciaEntreNumeros(numeroDelMago, numeroContrincante) ==  distanciaEntreNumeros(numeroDelMago,numeroIngresado))
        {
            return 3;           
        }else
        {
            if (distanciaEntreNumeros(numeroDelMago, numeroContrincante) <  distanciaEntreNumeros(numeroDelMago,numeroIngresado))
            {
                return 2;
            }else
            {
                return 1;
            }
        }
    }
    private static int distanciaEntreNumeros(int numero1, int numero2){
        int distancia = numero1 - numero2;
        if (distancia < 0)
        {
            distancia *= (-1);
        }
        return distancia;
    }
    private static Personaje recibirBeneficio(Personaje Vencedor, int opcion){
        switch (opcion)
        {
            case 1:
            Vencedor.Velocidad += 5;
            break;
            case 2:
            Vencedor.Destreza += 2;
            break;
            case 3:
            Vencedor.Fuerza += 5;
            break;
            case 4:
            Vencedor.Nivel += 5;
            break;
            case 5:
            Vencedor.Defensa += 5;
            break;
            case 6:
            Vencedor.Salud += 20;
            break;
            default:
            Vencedor.Salud += 20;
            break;
        }
        return Vencedor;
    }

}// juego (secuencia simulada , secuencia jugador)
// for coutn paso i+=2 p1 = i p2 = i+1
// devolver los ganadores, crear una nueva lista llamada lista de ganadores, i
//igualar la lista de personajes a esta(de esta forma se eliminarian los otros)
//así hasta que tenga uno solo
//debo cambiar los combates para que me den los ganadores en vez de los perdedores
//debo ver una forma de mostrar los combates haciendo como 4tos semis etc
// la funcion juego me retornara el ganador de todos
// mostrar sus datos y la leyenda de ganador