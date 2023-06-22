﻿// See https://aka.ms/new-console-template for more information
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        const int CANTIDAD_DE_PERSONAJES = 8;
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
        var random = new Random(DateTime.Now.Microsecond);
        var Mensajes = new Mensajes();
        int num1 = random.Next(0,8);
        int num2 = random.Next(0,8);
        int num3 = random.Next(0,8);
        Mensajes.VS(listaDePersonajes[num1],listaDePersonajes[num2]);
        var ganador = new Personaje();
        ganador = combateSimulado(listaDePersonajes[num1],listaDePersonajes[num2]);
        Mensajes.ganador(ganador);
        Mensajes.suerte(num1,num2,num3);
        Mensajes.tuPierdes();
        Mensajes.reglasDelMinijuegoSuerte();
        Mensajes.malIngresoEnSuerte();
        Mensajes.mostrarSalud(listaDePersonajes[num1],listaDePersonajes[num2]);

       /* if (listaDePersonajes.Count > 0)
        {
            mostrarLista(listaDePersonajes);
            var ganador = new Personaje();
            ganador = Juego(listaDePersonajes);
            Console.WriteLine("=================================================");
            Console.WriteLine("EL CAMINO FUE ARDUO, DESPUÉS DE ARDUAS BATALLAS");
            Console.WriteLine("FINALMENTE TENEMOS UN GANADOR Y ES: ");  
            Console.WriteLine("||||||||||||||"+ganador.Nombre+"||||||||||||||");  
            Console.WriteLine("HAS LOGRADO LA GLORIA ETERNA OH GRAN LUCHADOR");
            Console.WriteLine("AHORA REGOCIJATE CAMPEÓN DE CAMPEONES");  
            Console.WriteLine("AQUÍ VAN TUS STATS");  
            Console.WriteLine("=================================================");  
            mostrarDatos(ganador);
            Console.WriteLine("================================================="); 
            // if (ganador == personajePrincipal)
            // {
            //     Console.WriteLine("Y FELICIDADES A TI PERSONA REAL QUE MANEJA");
            //     Console.WriteLine("A ESTE PERSONAJE, TU TAMBIEN TIENES GLORIA");
            //     Console.WriteLine("GRACIAS POR JUGAR CON NICOPcompany");
            // } 
            Console.WriteLine("=================================================");  
        }
/*/
        // mostrarLista(listaDePersonajes);
        // Personaje perdedor;
        // perdedor = combateJugador(listaDePersonajes[1],listaDePersonajes[1]);
        // Console.WriteLine("============================");
        // Console.WriteLine("============================");
        // Console.WriteLine("Perdedor: ");
        // mostrarDatos(perdedor);
        // Console.WriteLine("============================");
        // Console.WriteLine("============================");
        // listaDePersonajes.Remove(perdedor);
    }
    private static Personaje Juego(List<Personaje> listaDePersonajes){
        var listaGanadores = new List<Personaje>();
        var ganador = new Personaje();
        var random = new Random(DateTime.Now.Microsecond);
        while (listaDePersonajes.Count > 1)
        {
            for (int i = 0; i < listaDePersonajes.Count; i+=2)
            {
                Console.WriteLine($"\n{listaDePersonajes[i].Nombre} VS {listaDePersonajes[i+1].Nombre}");
                if (i == 999) // despues se cambiara por si es personaje Principal
                {
                    ganador = combateJugador(listaDePersonajes[i],listaDePersonajes[i+1]);
                    //debo pedirle al usuario que beneficio quiere tener, debo preguntar si es que el que gano es el PerPrin
                    //Pero eso es tarea para otro momento
                    // ganador = recibirBeneficio(ganador,opcion);
                }else
                {
                    ganador = combateSimulado(listaDePersonajes[i],listaDePersonajes[i+1]);
                    //doy las mejoras
                    ganador = recibirBeneficio(ganador,random.Next(1,6));

                }
                Console.WriteLine ("Ganador: "+ganador.Nombre);
                listaGanadores.Add(ganador);
            }
            listaDePersonajes.Clear();
            listaDePersonajes.AddRange(listaGanadores);
            listaGanadores.Clear();
        }
        return listaDePersonajes[0]; 
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
        var Mensaje = new Mensajes();

        while (PersonajePrincipal.Salud >0 && Contrincante.Salud >0)
        {
        int golpePersonajePrincipal;
        int golpeContrincante;
        int Resultado;
        while (PersonajePrincipal.Salud >0 && Contrincante.Salud >0)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Tu salud:" + PersonajePrincipal.Salud);
            Console.WriteLine("Contrincante:" + Contrincante.Salud);
            Console.WriteLine("============================");
            Resultado = elMasCercano();
            if (Resultado == 3)
            {
                Console.WriteLine("===Empate!!==");
                golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,0);
                golpeContrincante = calcularGolpe(Contrincante,0); 
            }else
            {    
                if (Resultado == 1)
                {
                    Console.WriteLine("==Tu ganas==");
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,10);
                    golpeContrincante = calcularGolpe(Contrincante,0);
                }else
                {
                    Console.WriteLine("==Pierdes==");
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,0);
                    golpeContrincante = calcularGolpe(Contrincante,10);              
                }
            }
            Contrincante.Salud -= golpePersonajePrincipal;
            if (Contrincante.Salud > 0)
            {
                PersonajePrincipal.Salud -= golpeContrincante;
            }
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
        return PersonajePrincipal;
    }
    private static int elMasCercano(){
        var random = new Random(DateTime.Now.Millisecond);
        int numeroContrincante;
        int numeroDelMago;
        int numeroIngresado;
        string? buffer;
        Console.Write("Ingresa » ");
        buffer = Console.ReadLine();
        while ( !(int.TryParse(buffer, out numeroIngresado)) || (numeroIngresado < 0 || numeroIngresado > 9) )
        {
            Console.WriteLine("================================");
            Console.WriteLine("Creo que no me has entendido bien");
            Console.WriteLine("== Ingrese un número del 0 al 9 ==");
            Console.Write("Intentelo de vuelta: ");
            buffer = Console.ReadLine();
        }
        numeroContrincante = random.Next(0,10);
        numeroDelMago = random.Next(0,10);
        if (distanciaEntreNumeros(numeroDelMago, numeroContrincante) ==  distanciaEntreNumeros(numeroDelMago,numeroIngresado))
        {
            return 3;           
        }else
        {
            if (distanciaEntreNumeros(numeroDelMago, numeroContrincante) <  distanciaEntreNumeros(numeroDelMago,numeroIngresado))
            {
                return 1;
            }else
            {
                return 2;
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