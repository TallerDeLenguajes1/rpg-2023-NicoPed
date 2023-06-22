namespace Personajes;

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
        Console.WriteLine("║ »Antes de la pelea una pequeña regla« ║");
        Console.WriteLine("║ »Debes ingresar un número del 0 al 9« ║");
        Console.WriteLine("║ »Tu conticante hará lo mismo        « ║");
        Console.WriteLine("║ »Y el que se acerque más al número    ║");
        Console.WriteLine("║ pensado por el mago. Se le dara +10   ║");
        Console.WriteLine("║ de fuerza momentanea                « ║");
        Console.WriteLine("║ »Muchas suerte... La necesitaras    « ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
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
}