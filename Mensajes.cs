namespace Personajes;
using Chistes;
public class Mensajes{
    public void VS(Personaje luchador1, Personaje luchador2){
        Console.WriteLine (@"╔═══════════════════════════════╗");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@$"║   {luchador1.Nombre.PadLeft(10)} VS {luchador2.Nombre.PadRight(14)}║");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@"╚═══════════════════════════════╝");
        
    }
    public void ganador(Personaje Ganador){
        Console.WriteLine (@"╔═══════════════════════════════╗");
        Console.WriteLine (@$"║ Ganador: {Ganador.Nombre.PadRight(20)} ║");
        Console.WriteLine (@"╚═══════════════════════════════╝");
    }

    public void suerte(int numeroDelJugador, int numeroDelMago, int numeroDelEnemigo){
        Console.WriteLine (@"╔═══════════════════════════════╗");
        Console.WriteLine (@"║            Numeros            ║");
        Console.WriteLine (@"║   Tuyo      Mago     Enemigo  ║");
        Console.WriteLine (@"║  ┌─────┐   ┌─────┐   ┌─────┐  ║");
        Console.WriteLine (@$"║  │  {numeroDelJugador}  │   │  {numeroDelMago}  │   │  {numeroDelEnemigo}  │  ║");
        Console.WriteLine (@"║  └─────┘   └─────┘   └─────┘  ║");
        Console.WriteLine (@"╠═══════════════════════════════╣");
    }
    public void tuPierdes(){
        Console.WriteLine (@"╠══════════╦═════════╦══════════╣");
        Console.WriteLine (@"║          ║PERDISTE!║          ║");
        Console.WriteLine (@"╚══════════╩═════════╩══════════╝");
    }
    public void tuGanas(){
        Console.WriteLine (@"╠══════════╦═════════╦══════════╣");
        Console.WriteLine (@"║          ║TU GANAS!║          ║");
        Console.WriteLine (@"╚══════════╩═════════╩══════════╝");
    }
    public void Empate(){
        Console.WriteLine (@"╠═══════════╦═══════╦═══════════╣");
        Console.WriteLine (@"║           ║EMPATE!║           ║");
        Console.WriteLine (@"╚═══════════╩═══════╩═══════════╝");
    }
    public void reglasDelMinijuegoSuerte(){
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║  Antes de la pelea una pequeña regla  ║");
        Console.WriteLine("║  Debes ingresar un número del 0 al 9  ║");
        Console.WriteLine("║      Tu conticante hará lo mismo      ║");
        Console.WriteLine("║   Y el que se acerque más al número   ║");
        Console.WriteLine("║   pensado por el mago. Se le dara     ║");
        Console.WriteLine("║       +5 de fuerza momentanea«        ║");
        Console.WriteLine("║    Muchas suerte... La necesitaras    ║");
        Console.WriteLine("║ »PD:El mago además de hechizos lanza  ║");
        Console.WriteLine("║  chistes bastante malos. Solo riete « ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        presionaEnter();
    }
    public void malIngresoEnSuerte(){
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║ »Creo que no me has entendido bien  « ║");
        Console.WriteLine("║ »Debes ingresar un número del 0 al 9« ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.Write("Intentelo de vuelta » ");

    }
        public void mostrarSalud(Personaje luchador1, Personaje luchador2){
        Console.WriteLine("");
        Console.WriteLine (@"╔═══════════════════════════════╗");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@$"║ Tu salud: {luchador1.Salud.ToString().PadRight(19)} ║");
        Console.WriteLine (@$"║ Salud del Contricante: {luchador2.Salud.ToString().PadRight(6)} ║");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@"╚═══════════════════════════════╝");

        }
        public void mostrarDanio(int danioProvocado, int danioRecibido){
        Console.WriteLine("");
        Console.WriteLine (@"╔═══════════════════════════════╗");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@$"║ Daño Provocado: {danioProvocado.ToString().PadRight(13)} ║");
        Console.WriteLine (@$"║ Recibiste daño: {danioRecibido.ToString().PadRight(13)} ║");
        Console.WriteLine (@"║                               ║");
        Console.WriteLine (@"╚═══════════════════════════════╝");

        }
    public void mostrarLista(List<Personaje> listaDePersonajes){
        foreach (var personaje in listaDePersonajes)
        {
            mostrarDatos(personaje);
        }
    }
    public void mostrarDatos(Personaje personaje){
        Console.WriteLine("     ╔══════════════════════════════════════╗");
        Console.WriteLine("     ║ Nombre: "+personaje.Nombre.PadRight(29)+"║");
        Console.WriteLine("     ║ Apodo: "+personaje.Apodo.PadRight(30)+"║");
        Console.WriteLine("     ║ Tipo: "+personaje.Tipo.ToString().PadRight(31)+"║");
        Console.WriteLine("     ║ Fecha_nac: "+personaje.Fecha_nac.ToShortDateString().PadRight(26)+"║");
        Console.WriteLine("     ║ Edad: "+personaje.Edad.ToString().PadRight(31)+"║");
        Console.WriteLine("     ║ Velocidad: "+personaje.Velocidad.ToString().PadRight(26) +"║");
        Console.WriteLine("     ║ Destreza: "+personaje.Destreza.ToString().PadRight(27)+"║");
        Console.WriteLine("     ║ Fuerza: "+personaje.Fuerza.ToString().PadRight(29)+"║");
        Console.WriteLine("     ║ Poder: "+personaje.Poder.ToString().PadRight(30)+"║");
        Console.WriteLine("     ║ Defensa: "+personaje.Defensa.ToString().PadRight(28)+"║");
        Console.WriteLine("     ║ Salud: "+personaje.Salud.ToString().PadRight(30)+"║");
        Console.WriteLine("     ╚══════════════════════════════════════╝");
    

    }
    public void gameOver(){
    tipeo(@" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
   █████████   ████████    ██    ██    █████████  
  ██      ██  ██      ██  ████  ████  ██          
  ██          ██      ██  ██  ██  ██  ██          
  ██    ████  ██████████  ██      ██  ████████    
  ██      ██  ██      ██  ██      ██  ██          
   █████████  ██      ██  ██      ██   █████████  
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",1);
    Console.WriteLine("");
    tipeo(@" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
   ████████   ██      ██   █████████  ██████████  
  ██      ██  ██      ██  ██          ██      ██  
  ██      ██  ██      ██  ██          ██      ██  
  ██      ██   ██    ██   ████████    ████████    
  ██      ██    ██  ██    ██          ██     ██   
   ████████       ██       █████████  ██      ██  
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",1);
    Console.WriteLine("");
    tipeo("»»» ¿Desea volver a jugar? »»» 1:Si Cualquier tecla: No",20);
    ingrese();

    }
    public void preguntarMismosPersonajes(){
        tipeo("»»» ¿Mismos contricantes?",20);
        tipeo("1 = Si , 0 = No",20);
    }
    public void presionaEnter(){
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
    public void mensajeFinal(Personaje ganador){
        string empty= "";
        Console.WriteLine("╔────────────────────────────────────────────────╗");
        Console.WriteLine("│EL CAMINO FUE ARDUO Y DESPUÉS DE ARDUAS BATALLAS│");
        Console.WriteLine("│      FINALMENTE TENEMOS UN GANADOR Y ES:       │");  
        Console.WriteLine("╚────────────────────────────────────────────────╝");
        presionaEnter();  
        Console.WriteLine(empty.PadRight(22)+"WINNER");
        // 48 24 y 24.... 
        string? nombre = ganador.Nombre;
        int longitudNombre = nombre.Length ;
        string? Apodo = ganador.Apodo;
        int longitudApodo = Apodo.Length ;
        int longitudEspacioderechaNombre = 24;
        int longitudEspacioderechaApodo = 24;
        if (longitudNombre % 2 != 0)
        {
            longitudEspacioderechaNombre = 23;
        }
        if (longitudApodo%2 == 1)
        {
            longitudEspacioderechaApodo = 23;
        }
        
        Console.WriteLine("╔════════════════════════════════════════════════╗");
        Console.WriteLine("│"+empty.PadRight(24 - longitudNombre/2)+""+ganador.Nombre+""+empty.PadRight(longitudEspacioderechaNombre- longitudNombre/2)+"│");
        Console.WriteLine("│"+empty.PadRight(24 - longitudApodo/2)+""+ganador.Apodo+""+empty.PadRight(longitudEspacioderechaApodo - longitudApodo/2)+"│");  
        Console.WriteLine("╚════════════════════════════════════════════════╝");       
        presionaEnter();
        Console.WriteLine("╔────────────────────────────────────────────────╗");
        Console.WriteLine("│ HAS LOGRADO LA GLORIA ETERNA OH GRAN LUCHADOR! │");
        Console.WriteLine("│     AHORA REGOCIJATE CAMPEÓN DE CAMPEONES      │");  
        Console.WriteLine("├────────────────────────────────────────────────┤");  
        Console.WriteLine("╚────────────────────────────────────────────────╝");  
        Console.WriteLine(" ══════════════ Y AQUÍ SUS STATS ══════════════");  
        mostrarDatos(ganador);
        presionaEnter();
    }
    public void finalUsuarioGanador(){
        Console.WriteLine("╔────────────────────────────────────────────────╗");
        Console.WriteLine("│   Y FELICIDADES A TI PERSONA REAL QUE MANEJA   │");
        Console.WriteLine("│   A ESTE PERSONAJE, TU TAMBIEN TIENES GLORIA   │");
        Console.WriteLine("│       GRACIAS POR JUGAR CON NICOPcompany       │");
        Console.WriteLine("╚────────────────────────────────────────────────╝");  

    }
    public void contarChisteMalo(){
        var nuevoChiste = new unChiste();
        nuevoChiste = obtenerChiste.Chiste();
        string chiste = nuevoChiste.joke;
        string cantlineas = "──";
        if (nuevoChiste.type == "single")
        {
            for (int i = 0; i < chiste.Count(); i++)
            {
                cantlineas+= "─";
            }
            Console.WriteLine(">»»» El mago dice");
            Console.WriteLine("╔"+cantlineas+"╗");
            Console.WriteLine($"│»{chiste}«│");
            Console.WriteLine("╚"+cantlineas+"╝");
        }else
        {
            if (nuevoChiste.type == "twopart")
            {
            int cantidad = 0;
            int diferenciaEntreAmbos = 0;
            cantidad = nuevoChiste.setup.Count();
            diferenciaEntreAmbos = nuevoChiste.delivery.Count() - cantidad; 
            if (diferenciaEntreAmbos > 0 )
            {
                cantidad += diferenciaEntreAmbos;
            }
            for (int i = 0; i < cantidad ; i++)
            {
                cantlineas+= "─";
            }
            Console.WriteLine("\n");
            Console.WriteLine("»»» El mago dice:");
            Console.WriteLine("╔"+cantlineas+"╗");
            Console.WriteLine($"│»{nuevoChiste.setup.PadRight(cantidad)} │");
            Console.WriteLine($"│{nuevoChiste.delivery.PadRight(cantidad + 1)}«│");
            Console.WriteLine("╚"+cantlineas+"╝");
                
            }
        }
    }

    public void preguntarPorBeneficio(){
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║ ¡Has ganado! Ahora elije un beneficio ║");
            Console.WriteLine("║ » Opción 1: +3 Velocidad              ║");
            Console.WriteLine("║ » Opción 2: +3 Fuerza                 ║");
            Console.WriteLine("║ » Opción 3: +3 Poder                  ║");
            Console.WriteLine("║ » Opción 4: +3 Defensa                ║");
            Console.WriteLine("║ » Opción 5: +1 Destreza               ║");
            Console.WriteLine("║ » Opción 6: +20 Salud                 ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
    }
    public void elegirCantidadDePersonajes(){
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║ Elija la cantidad de personajes a jugar ║");
            Console.WriteLine("║ » Opción 1: 4 Personajes                ║");
            Console.WriteLine("║ » Opción 2: 8 Personajes                ║");
            Console.WriteLine("║ » Opción 3: 16 Personajes               ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
    }
    public void ingreseNombre(){
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese su nombre por favor(10)« ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
    }
    public void ingreseApodo(){
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese un apodo por favor(30) « ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
    }
    public void ingreseFecha(){
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »Ingrese su fecha de Nacimiento « ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
    }
    public void ingreseDia(){
            Console.Write(" » Día: ");
    }
    public void ingreseMes(){
            Console.Write(" » Mes: ");
    }
    public void ingreseAnio(){
            Console.Write(" » Año: ");
    }
    public void CrearOGenerarPersonaje(){
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║ »Hola nuevo jugador, desea:  « ║");
            Console.WriteLine("║ »0. Crear su personaje       « ║");
            Console.WriteLine("║ »1. Generarlo aleatoriamente « ║");
            Console.WriteLine("╚════════════════════════════════╝");
    }
    public void ErrorCrearOGenerarPersonaje(){
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ »No ingreso una opción correcta « ║");
            Console.WriteLine("║ »0. Crear su personaje          « ║");
            Console.WriteLine("║ »1. Generarlo aleatoriamente    « ║");
            Console.WriteLine("╚═══════════════════════════════════╝"); 
    }
    public void ingrese(){
            Console.Write(" » Ingrese: ");
    }
    public void IngreseUnaOpcionCorrecta(){
        Console.WriteLine("»»» Ingrese una opción correcta por favor");
    }
    public void errorAlIngresarLasCaracteristicas(){
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("║ »La suma de sus habilidades es mayor que 25 « ║");
            Console.WriteLine("║ »Intentelo de vuelta. «                       ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");  
    }
    public void ingresarCaracteristicas(){
        Console.WriteLine("╔═══════════════════════════════════════════════╗");
        Console.WriteLine("║ »Ingrese las caracteristicas de su personaje« ║");
        Console.WriteLine("║ »Recordando que la suma entre todas las habi- ║");
        Console.WriteLine("║  lidades debe ser menor a 25. Otra condición, ║");
        Console.WriteLine("║  es que la destreza debe ser menor a 5, y las ║");
        Console.WriteLine("║  demás habilidades deben de ser menor a 10. « ║");
        Console.WriteLine("╚═══════════════════════════════════════════════╝");
    }
    public void ingresarDestreza(int puntos, int suma){
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
        Console.WriteLine("║ »Ingrese la Destreza:  «          ║");
        Console.WriteLine("╚═══════════════════════════════════╝"); 

    }
    public void ingresarVelocidad(int puntos, int suma){
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
        Console.WriteLine("║ »Ingrese la Velocidad:  «         ║");
        Console.WriteLine("╚═══════════════════════════════════╝");
    }
    public void ingresarDefensa(int puntos, int suma){
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
        Console.WriteLine("║ »Ingrese la Defensa:  «           ║");
        Console.WriteLine("╚═══════════════════════════════════╝"); 
    }
    public void ingresarPoder(int puntos, int suma){
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
        Console.WriteLine("║ »Ingrese el Poder:  «             ║");
        Console.WriteLine("╚═══════════════════════════════════╝"); 
    }
    public void ingresarFuerza(int puntos, int suma){
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine($"║ »Le quedan {(puntos-suma).ToString().PadRight(2)} puntos a repartir«  ║");
        Console.WriteLine("║ »Ingrese la Fuerza:  «            ║");
        Console.WriteLine("╚═══════════════════════════════════╝"); 
    }    
    public string tipeo(string linea,int rapidez){
            var tipeo = "";
            foreach (var caracteres in linea)
            {
                Console.Write(caracteres);
                Thread.Sleep(rapidez);
            }
            Console.WriteLine();
        return tipeo;
    }
}