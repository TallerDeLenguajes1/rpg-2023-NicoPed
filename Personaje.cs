namespace Personajes;
enum tipoDePersonaje{
    Demonio = 0,
    Creciente = 1,
    Cazador = 2,
    Hashira = 3
}
public class Personaje
{
    private tipoDePersonaje tipo;
    private string? nombre;
    private string? apodo;
    private DateTime fecha_nac;
    private int edad;
    
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int poder;
    private int defensa;
    private int salud;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apodo { get => apodo; set => apodo = value; }
    public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
    public int Edad { get => edad; set => edad = value; }
    internal tipoDePersonaje Tipo { get => tipo; set => tipo = value; }
    
    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Poder { get => poder; set => poder = value; }
    public int Defensa { get => defensa; set => defensa = value; }
    public int Salud { get => salud; set => salud = value; }

    public Personaje(){
        
    }
    public int SacarEdad(){
        DateTime Today = DateTime.Today;
        return(Today.Subtract(fecha_nac).Days / 365);
    }   
}