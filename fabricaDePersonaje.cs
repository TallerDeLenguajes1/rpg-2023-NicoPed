namespace Personajes;

public class fabricaDePersonaje{
private string [ , ] nombresDemonios = {{"Creciente 1","xd"},{"Tanjiro","Kamado"}};
private string [ , ] nombresCrecientes = {{"Creciente 1","xd"},{"Tanjiro","Kamado"}};
private string [ , ] nombresCazadores = {{"Creciente 1","xd"},{"Tanjiro","Kamado"}};
private string [ , ] nombresHashiras = {{"Creciente 1","xd"},{"Tanjiro","Kamado"}};

    public Personaje crearPersonaje(){
        var nuevoPersonaje = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        tipoDePersonaje tipoPersonaje;
        tipoPersonaje = (tipoDePersonaje)numeroRandom;

        switch (tipoPersonaje)
        {
            case tipoDePersonaje.demonio:
                nuevoPersonaje = crearDemonio();
            break;
            case tipoDePersonaje.creciente:
            break;
            case tipoDePersonaje.cazador:
            break;
            case tipoDePersonaje.hashira:

            break;
        }
        return nuevoPersonaje;
    }
    private Personaje crearDemonio(){
        var nuevoDemonio = new Personaje();

        return nuevoDemonio;
    }   
}
// 
// switch (numeroRandom)
// {
    // case 0:
        // tipoPersonaje = tipoDePersonaje.demonio;
        // break;
    // case 1:
        // tipoPersonaje = tipoDePersonaje.creciente;
    //    break;
    // case 2:
        // tipoPersonaje = tipoDePersonaje.cazador;
    //    break;
    // case 3:
        // tipoPersonaje = tipoDePersonaje.hashira;
    //    break;
    // default: Console.WriteLine("Error");
    //  break;
//}