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
        Console.WriteLine("║      +10 de fuerza momentanea«        ║");
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
        Console.WriteLine("     ║ Nivel: "+personaje.Nivel.ToString().PadRight(30)+"║");
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
    tipeo("»»» Ingrese: ",20);

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
        Console.WriteLine("╔════════════════════════════════════════════════╗");
        Console.WriteLine("│"+empty.PadRight(18)+""+ganador.Nombre.PadRight(30)+"│");
        Console.WriteLine("│"+empty.PadRight(18)+""+ganador.Apodo.PadRight(30)+"│");  
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