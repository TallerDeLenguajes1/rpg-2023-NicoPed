// See https://aka.ms/new-console-template for more information
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        var mensaje = new Mensajes();
        const int CANTIDAD_DE_PERSONAJES = 1; //podes pedir que te muestren o directamente vos poner lo que vos quuieras
        string archivoJson = "personajes.json";
        int opcionFinal = 0;
        string? buffer;
        Personaje personajePrincipal;
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
        
        personajePrincipal = ingresoUsuario();
        mensaje.mostrarDatos(personajePrincipal);
        listaDePersonajes.Add(personajePrincipal);
        if (listaDePersonajes.Count > 0)
        {
            // mensaje.mostrarLista(listaDePersonajes);
            var ganador = new Personaje();
            ganador = Juego(listaDePersonajes,personajePrincipal);
            mensaje.mensajeFinal(ganador);

            if (ganador == personajePrincipal)
            {
                mensaje.finalUsuarioGanador();
            } 
            mensaje.gameOver();
        }

        buffer = Console.ReadLine();
        if (! int.TryParse(buffer,out opcionFinal) || opcionFinal != 1)
        {
            opcionFinal = 0;
        }
    } while (opcionFinal != 0);
    AyudaJson.eliminarPersonajes(archivoJson);
    }
    private static Personaje ingresoUsuario(){
        var usuario = new Personaje ();
        int opcion = 0;
        string? nombre = " ";
        string? apodo = "";
        string? bufferfechaDeNac = "";
        DateTime fecha_nac;
        do
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese su nombre por favor(10)« ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write(" » Ingrese: ");
            nombre = Console.ReadLine();
        } while ( string.IsNullOrEmpty(nombre) || nombre.Length >10 || nombre.Any(c => !char.IsLetterOrDigit(c)) ); // nombre.any se fija si en todo el arreglo todos son caracteres
        do
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese un apodo por favor(30) « ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write(" » Ingrese: ");
            apodo = Console.ReadLine();
        } while ( string.IsNullOrEmpty(apodo) || apodo.Length >30 || apodo.Any(c => !char.IsLetterOrDigit(c)) ); // apodo.any se fija si en todo el arreglo todos son caracteres
         do
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese su fecha de Nacimiento « ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write(" » Ingrese: ");
            bufferfechaDeNac = Console.ReadLine();
            bufferfechaDeNac = "12-11-2001";
        } while (!DateTime.TryParse(bufferfechaDeNac, out fecha_nac) || fecha_nac > DateTime.Today); // nombre.any se fija si en todo el arreglo todos son caracteres
       
        string? buffer;
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║ »Hola nuevo jugador, desea:  « ║");
            Console.WriteLine("║ »0. Crear su personaje       « ║");
            Console.WriteLine("║ »1. Generarlo aleatoriamente « ║");
            Console.WriteLine("╚════════════════════════════════╝");
        do
        {
            Console.Write(" » Ingrese: ");
            buffer = Console.ReadLine();
            if (!int.TryParse(buffer, out opcion))
            {
                opcion = 9999;
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║ »No ingreso una opción correcta « ║");
                Console.WriteLine("║ »0. Crear su personaje          « ║");
                Console.WriteLine("║ »1. Generarlo aleatoriamente    « ║");
                Console.WriteLine("╚═══════════════════════════════════╝");            
            }
        } while (opcion < 0 || opcion >1);

        if (opcion == 1)
        {
            usuario = new fabricaDePersonaje().aleatorio(nombre,apodo,fecha_nac);
        }else
        {
            usuario = creadoPorElUsuario(nombre,apodo,fecha_nac);
        }
        return usuario;
    }
    private static Personaje creadoPorElUsuario(string nombre, string apodo, DateTime fecha_nac){
        var usuario = new Personaje();
        int suma = 0;
        int defensa = 0;
        int fuerza = 0;
        int destreza = 0;
        int velocidad = 0;
        int poder = 0;
        int puntos = 25;
        string? buffer;
            do
            {
                if (suma > puntos)
                {
                Console.WriteLine("╔═══════════════════════════════════════════════╗");
                Console.WriteLine("║ »La suma de sus habilidades es mayor que 20 « ║");
                Console.WriteLine("║ »Intentelo de vuelta. «                       ║");
                Console.WriteLine("╚═══════════════════════════════════════════════╝");  
                }

                suma = 0;
                Console.WriteLine("╔═══════════════════════════════════════════════╗");
                Console.WriteLine("║ »Ingrese las caracteristicas de su personaje« ║");
                Console.WriteLine("║ »Recordando que la suma entre todas las habi- ║");
                Console.WriteLine("║  lidades debe ser menor a 25. Otra condición, ║");
                Console.WriteLine("║  es que la destreza debe ser menor a 5, y las ║");
                Console.WriteLine("║  demás habilidades deben de ser menor a 10. « ║");
                Console.WriteLine("╚═══════════════════════════════════════════════╝");
                
                do
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
                    Console.WriteLine("║ »Ingrese la Destreza:  «          ║");
                    Console.WriteLine("╚═══════════════════════════════════╝"); 

                    Console.Write(" » Ingrese: ");
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out destreza) || destreza > 5);
                    suma += destreza; 
                do
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
                    Console.WriteLine("║ »Ingrese la Velocidad:  «         ║");
                    Console.WriteLine("╚═══════════════════════════════════╝"); 
                    Console.Write(" » Ingrese: ");
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out velocidad) || velocidad > 10);
                    suma += velocidad;
                do
                {
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
                    Console.WriteLine("║ »Ingrese la Defensa:  «           ║");
                    Console.WriteLine("╚═══════════════════════════════════╝"); 
                    Console.Write(" » Ingrese: ");
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out defensa) || defensa > 10);
                    suma += defensa;
                if (suma <= puntos)
                {    
                    do
                    {
                        Console.WriteLine("╔═══════════════════════════════════╗");
                        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
                        Console.WriteLine("║ »Ingrese el Poder:  «             ║");
                        Console.WriteLine("╚═══════════════════════════════════╝"); 
                        Console.Write(" » Ingrese: ");
                        buffer = Console.ReadLine();
                    } while ( !int.TryParse(buffer,out poder) || poder > 10);
                        suma += poder;
                    if (suma <= puntos)
                    {
                        do
                        {
                            Console.WriteLine("╔═══════════════════════════════════╗");
                            Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
                            Console.WriteLine("║ »Ingrese la Fuerza:  «            ║");
                            Console.WriteLine("╚═══════════════════════════════════╝"); 
                            Console.Write(" » Ingrese: ");
                            buffer = Console.ReadLine();
                        } while ( !int.TryParse(buffer,out fuerza) || fuerza > 10);
                            suma += fuerza;
                    }
                }
            } while (suma > puntos);
             
            usuario.Nombre = nombre;
            usuario.Apodo = apodo;
            usuario.Fecha_nac = fecha_nac;
            usuario.Edad = usuario.SacarEdad();
            usuario.Fuerza = fuerza;
            usuario.Destreza =destreza;
            usuario.Defensa = defensa;
            usuario.Velocidad = velocidad;
            usuario.Poder = poder;
            usuario.Salud = 100;
            usuario.Tipo = tipoDePersonaje.Cazador;
            return usuario;
    }
    private static Personaje Juego(List<Personaje> listaDePersonajes, Personaje personajePrincipal){
        var listaGanadores = new List<Personaje>();
        var ganador = new Personaje();
        var random = new Random(DateTime.Now.Microsecond);
        var mensaje = new Mensajes();
        int beneficio = 0;
        while (listaDePersonajes.Count > 1)
        {
            for (int i = 0; i < listaDePersonajes.Count; i+=2)
            {
                mensaje.VS(listaDePersonajes[i],listaDePersonajes[i+1]);
                // Console.WriteLine($"\n{listaDePersonajes[i].Nombre} VS {listaDePersonajes[i+1].Nombre}");
                if (listaDePersonajes[i] == personajePrincipal || listaDePersonajes[i+1] == personajePrincipal) // despues se cambiara por si es personaje Principal
                {
                    mensaje.reglasDelMinijuegoSuerte();
                    if (listaDePersonajes[i] == personajePrincipal)
                    {
                        ganador = combateJugador(listaDePersonajes[i],listaDePersonajes[i+1]);
                    }else
                    {
                        ganador = combateJugador(listaDePersonajes[i+1],listaDePersonajes[i]);
                    }
                    //debo pedirle al usuario que beneficio quiere tener, debo preguntar si es que el que gano es el PerPrin
                    //Pero eso es tarea para otro momento
                    // ganador = recibirBeneficio(ganador,opcion);
                    if (ganador == personajePrincipal )
                    {
                        beneficio = 0;
                        beneficio = preguntarBeneficio();
                        ganador = recibirBeneficio(ganador,beneficio); // por el momento          
                    }else
                    {
                        ganador = recibirBeneficio(ganador,random.Next(1,6)); // por el momento
                    }

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
        int Ataque = luchador.Destreza * (luchador.Fuerza + fuerzaExtra) * luchador.Poder;
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
        if (random.Next(0,2) == 1)
        {
            mensaje.contarChisteMalo();
        }
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
            Vencedor.Velocidad += 3;
            break;
            case 2:
            Vencedor.Fuerza += 3;
            break;
            case 3:
            Vencedor.Poder += 3;
            break;
            case 4:
            Vencedor.Defensa += 3;
            break;
            case 5:
            Vencedor.Destreza += 1;
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
    private static int preguntarBeneficio(){
        int opcion = 0;
        string? buffer = "";
        do
        {
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║ ¡Has ganado! Ahora elije un beneficio ║");
            Console.WriteLine("║ » Opción 1: +3 Velocidad              ║");
            Console.WriteLine("║ » Opción 2: +3 Fuerza                 ║");
            Console.WriteLine("║ » Opción 3: +3 Poder                  ║");
            Console.WriteLine("║ » Opción 4: +3 Defensa                ║");
            Console.WriteLine("║ » Opción 5: +1 Destreza               ║");
            Console.WriteLine("║ » Opción 6: +20 Salud                 ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.Write(" » Ingrese: ");
            buffer = Console.ReadLine();
        } while (!int.TryParse(buffer,out opcion) || opcion < 1 || opcion > 6 );
        return opcion;
    }
}
