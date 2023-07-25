// See https://aka.ms/new-console-template for more information
using Personajes;
internal class Program
{
    private static void Main(string[] args)
    {
        var mensaje = new Mensajes();
        int CANTIDAD_DE_PERSONAJES = 1; 
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
            CANTIDAD_DE_PERSONAJES = ElegirCantidadPersonajes();
            var nuevaFabrica = new fabricaDePersonaje();
            listaDePersonajes.Clear();
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
            listaDePersonajes = AyudaJson.LeerPersonajes(archivoJson);
        }
        personajePrincipal = ingresoUsuario();
        mensaje.mostrarDatos(personajePrincipal);
        mensaje.presionaEnter();
        listaDePersonajes.Add(personajePrincipal);
        if (listaDePersonajes.Count > 0)
        {
            // Puedo Crear un nuevo campo que me diga si es o no el personaje principal
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
        int respMismosPersonajes = 0;
        if (opcionFinal == 1)
        {
            respMismosPersonajes = preguntarMismosPersonajes();
        }
        if (respMismosPersonajes == 0)
        {
            AyudaJson.eliminarPersonajes(archivoJson);
        }
    } while (opcionFinal != 0);
    }
    private static int ElegirCantidadPersonajes(){
    int opcion = 1;
    var mensaje = new Mensajes();
    string? buffer = "";
    bool condicion;
    do
        {
            mensaje.elegirCantidadDePersonajes();
            mensaje.ingrese();
            buffer = Console.ReadLine();
            condicion = (!int.TryParse(buffer,out opcion) || opcion < 1 || opcion > 3 );
            if (condicion)
            {
                mensaje.IngreseUnaOpcionCorrecta();
            }
        } while (condicion);
    switch (opcion)
    {
        case 1:
        return 3; // 3 ya que el personaje principal despues se añade llegando a los 4 personajes
        case 2: 
            return 7;
        case 3: 
            return 15;
        default:
        return 1;
    }   
}
    private static Personaje ingresoUsuario(){
        var usuario = new Personaje ();
        int opcion = 0;
        string? nombre = " ";
        string? apodo = "";
        string? bufferfechaDeNac = "";
        string? stringFechaDeNac = "";
        var mensaje = new Mensajes();

        DateTime fecha_nac;
        do
        {
            mensaje.ingreseNombre();
            mensaje.ingrese();
            nombre = Console.ReadLine();
        } while ( string.IsNullOrEmpty(nombre) || nombre.Length >10 || nombre.Any(c => !char.IsLetterOrDigit(c)) ); // nombre.any se fija si en todo el arreglo todos son caracteres
        do
        {
            mensaje.ingreseApodo();
            mensaje.ingrese();
            apodo = Console.ReadLine();
        } while ( string.IsNullOrEmpty(apodo) || apodo.Length >30 || apodo.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)) ); // apodo.any se fija si en todo el arreglo todos son caracteres
         do
        {
            stringFechaDeNac = "";
            mensaje.ingreseFecha();
            mensaje.ingreseDia();
            bufferfechaDeNac = Console.ReadLine();
            stringFechaDeNac = string.Concat(stringFechaDeNac,bufferfechaDeNac);
            mensaje.ingreseMes();
            bufferfechaDeNac = Console.ReadLine();
            stringFechaDeNac = string.Concat(stringFechaDeNac,"/",bufferfechaDeNac);
            mensaje.ingreseAnio();
            bufferfechaDeNac = Console.ReadLine();
            stringFechaDeNac = string.Concat(stringFechaDeNac,"/",bufferfechaDeNac);
        } while (!DateTime.TryParse(stringFechaDeNac, out fecha_nac) || fecha_nac > DateTime.Today); // nombre.any se fija si en todo el arreglo todos son caracteres
       
        string? buffer;
            mensaje.CrearOGenerarPersonaje();
        do
        {
            mensaje.ingrese();
            buffer = Console.ReadLine();
            if (!int.TryParse(buffer, out opcion))
            {
                opcion = 9999;
                mensaje.ErrorCrearOGenerarPersonaje();
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
        var mensaje = new Mensajes();
        string? buffer;
            do
            {
                if (suma > puntos)
                {
                    mensaje.errorAlIngresarLasCaracteristicas();
                }
                suma = 0;
                mensaje.ingresarCaracteristicas();                
                do
                {
                    mensaje.ingresarDestreza(puntos,suma);
                    mensaje.ingrese();
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out destreza) || destreza > 5);
                    suma += destreza; 
                do
                {
                    mensaje.ingresarVelocidad(puntos,suma); 
                    mensaje.ingrese();
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out velocidad) || velocidad > 10);
                    suma += velocidad;
                do
                {
                    mensaje.ingresarDefensa(puntos,suma); 
                    mensaje.ingrese();
                    buffer = Console.ReadLine();
                } while ( !int.TryParse(buffer,out defensa) || defensa > 10);
                    suma += defensa;
                if (suma <= puntos)
                {    
                    do
                    {
                        mensaje.ingresarPoder(puntos,suma); 
                        mensaje.ingrese();                         
                        buffer = Console.ReadLine();
                    } while ( !int.TryParse(buffer,out poder) || poder > 10);
                        suma += poder;
                    if (suma <= puntos)
                    {
                        do
                        {
                            mensaje.ingresarFuerza(puntos,suma); 
                            mensaje.ingrese();
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
        int cantidadDePersonajes = listaDePersonajes.Count;
        while (cantidadDePersonajes > 1)
        {
            switch (cantidadDePersonajes)
            {
                
                case 16:
                    mensaje.Octavos();
                break;
                case 8:
                    mensaje.Cuartos();
                break;
                case 4:
                    mensaje.Semis();
                break;
                case 2:
                    mensaje.Final();
                break;
            }
            for (int i = 0; i < listaDePersonajes.Count; i+=2)
            {                
                mensaje.VS(listaDePersonajes[i],listaDePersonajes[i+1]);
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
                    if (ganador == personajePrincipal )
                    {
                        beneficio = 0;
                        beneficio = preguntarBeneficio();
                        ganador = recibirBeneficio(ganador,beneficio);           
                    }else
                    {
                        ganador = recibirBeneficio(ganador,random.Next(1,6)); 
                        mensaje.ganador(ganador);
                        mensaje.presionaEnter();
                    }

                }else
                {
                    int decision = preguntarVerOSaltarPelea();
                    ganador = combateSimulado(listaDePersonajes[i],listaDePersonajes[i+1],decision);
                    ganador = recibirBeneficio(ganador,random.Next(1,6));
                    mensaje.ganador(ganador);
                    mensaje.presionaEnter();
                }
                // si logras entender como borrar en una misma lista sin romperla queda mejor
                listaGanadores.Add(ganador);
            }
            listaDePersonajes.Clear();
            listaDePersonajes.AddRange(listaGanadores);
            listaGanadores.Clear();
            cantidadDePersonajes = listaDePersonajes.Count;
        }
        return listaDePersonajes[0]; 
    }
    private static Personaje combateSimulado(Personaje luchador1, Personaje luchador2, int verOSaltar){
        int golpeP1;
        int golpeP2;
        int moneda;
        int auxSaludLuch1 = luchador1.Salud;
        int auxSaludLuch2 = luchador2.Salud;
        var mensajes = new Mensajes();
        var random = new Random(DateTime.Now.Millisecond);
        if (verOSaltar == 0)
        {   
            mensajes.mostrarSalud(luchador1,luchador2);
        }
        while (luchador1.Salud >0 && luchador2.Salud >0)
        {
            moneda = random.Next(1,3);
            if (moneda == 1)
            {
                golpeP1 = calcularGolpe(luchador1,luchador2,5);
                golpeP2 = calcularGolpe(luchador2,luchador1,0);
            }else
            {
                golpeP1 = calcularGolpe(luchador1,luchador2,0);
                golpeP2 = calcularGolpe(luchador2,luchador1,5);              
            }
            luchador2.Salud -= golpeP1;
            if (luchador2.Salud > 0)
            {
                luchador1.Salud -= golpeP2;
            }
            if (verOSaltar == 0)
            {
                mensajes.mostrarDanio(luchador1,luchador2,golpeP1,golpeP2);
                mensajes.mostrarSalud(luchador1,luchador2);
                mensajes.presionaEnter();
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
            mensaje.mostrarSalud(PersonajePrincipal,Contrincante);
            Resultado = elMasCercano();
            if (Resultado == 3)
            {
                mensaje.Empate();
                golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,Contrincante,0);
                golpeContrincante = calcularGolpe(Contrincante,PersonajePrincipal,0); 
            }else
            {    
                if (Resultado == 1)
                {
                    mensaje.tuGanas();
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,Contrincante,5);
                    golpeContrincante = calcularGolpe(Contrincante,PersonajePrincipal,0);
                }else
                {
                    mensaje.tuPierdes();
                    golpePersonajePrincipal = calcularGolpe(PersonajePrincipal,Contrincante,0);
                    golpeContrincante = calcularGolpe(Contrincante,PersonajePrincipal,5);              
                }
            }
            mensaje.presionaEnter();
            Contrincante.Salud -= golpePersonajePrincipal;
            if (Contrincante.Salud > 0)
            {
                PersonajePrincipal.Salud -= golpeContrincante;
            }
            mensaje.mostrarDanio(PersonajePrincipal,Contrincante,golpePersonajePrincipal,golpeContrincante);
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
    private static int calcularGolpe(Personaje luchadorQueGolpea, Personaje luchadorQueDefiende,int fuerzaExtra){
        var random = new Random(DateTime.Now.Millisecond);
        int danioProvocado = 0;
        int Ataque = luchadorQueGolpea.Destreza * (luchadorQueGolpea.Fuerza + fuerzaExtra) * luchadorQueGolpea.Poder;
        int Efectividad = random.Next(0,101);
        int Defensa = luchadorQueDefiende.Defensa * luchadorQueDefiende.Velocidad;  
        int ConstanteDeAjuste = 500; 
        danioProvocado = ((Ataque * Efectividad)- Defensa)/ConstanteDeAjuste;
        return danioProvocado;
    } 
    private static int elMasCercano(){
        var random = new Random(DateTime.Now.Millisecond);
        int numeroContrincante;
        int numeroDelMago;
        int numeroIngresado;
        string? buffer;
        var mensaje = new Mensajes();
        mensaje.ingrese();
        buffer = Console.ReadLine();
        while ( !(int.TryParse(buffer, out numeroIngresado)) || (numeroIngresado < 0 || numeroIngresado > 9) )
        {
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
     private static int preguntarBeneficio(){
        int opcion = 0;
        var mensaje = new Mensajes();
        bool condicion;
        string? buffer = "";
        do
        {
            mensaje.preguntarPorBeneficio();
            mensaje.ingrese();
            buffer = Console.ReadLine();
            condicion = (!int.TryParse(buffer,out opcion) || opcion < 1 || opcion > 6);
            if (condicion)
            {
                mensaje.IngreseUnaOpcionCorrecta();
            }
        } while (condicion );
        return opcion;
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
    private static int preguntarVerOSaltarPelea(){
        var mensaje = new Mensajes();
        string? buffer;
        int decision = 0; 
        bool condicion;
        do
        {
            mensaje.VerOSaltarPelea();
            mensaje.ingrese();
            buffer = Console.ReadLine();
            condicion = (!int.TryParse(buffer,out decision) || (decision != 1 && decision != 0));
            if (condicion)
            {
                mensaje.IngreseUnaOpcionCorrecta();
            }
        } while (condicion);
        return decision;
    }
    private static int preguntarMismosPersonajes(){
        var mensaje = new Mensajes();
        string? buffer;
        int respMismosPersonajes = 0; 
        bool condicion;
        do
        {
            mensaje.preguntarMismosPersonajes();
            mensaje.ingrese();
            buffer = Console.ReadLine();
            condicion = (!int.TryParse(buffer,out respMismosPersonajes) || (respMismosPersonajes != 1 && respMismosPersonajes != 0));
            if (condicion)
            {
                mensaje.IngreseUnaOpcionCorrecta();
            }
        } while (condicion);
        return respMismosPersonajes;
    }
}