namespace Personaje;
enum tipoDePersonaje{
    demonio,
    cazador
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
    private int nivel;
    private int armadura;
    private int salud;

}