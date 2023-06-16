namespace Personajes;

public class fabricaDePersonaje{
private string [ , ] nombresDemonios = {{"Enmu","Luna Inferior Uno"},{"Rokuro","Luna Inferior Dos"},{"Wakuraba","Luna Inferior Tres"},{"Mukago","Luna Inferior Cuatro"},{"Rui","Luna Inferior Tres"}};
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
                nuevoPersonaje =crearCazador();
            break;
            case tipoDePersonaje.hashira:

            break;
        }
        return nuevoPersonaje;
    }
    private Personaje crearDemonio(){
        var nuevoDemonio = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        string stringFecha = random.Next(1,28)+"/"+random.Next(1,12)+"/"+random.Next(1000,2000);
        DateTime fechaDeNacimiento;
        
        nuevoDemonio.Tipo = tipoDePersonaje.demonio;
        nuevoDemonio.Nombre = nombresDemonios[numeroRandom,0];
        nuevoDemonio.Apodo = nombresDemonios[numeroRandom,1];
        if (DateTime.TryParse(stringFecha,out fechaDeNacimiento))
        {
            nuevoDemonio.Fecha_nac = fechaDeNacimiento;
        }else
        {
            nuevoDemonio.Fecha_nac = new DateTime(1000,12,5);
        }
        nuevoDemonio.Edad = nuevoDemonio.SacarEdad();
        nuevoDemonio.Velocidad = random.Next(2,6);
        nuevoDemonio.Destreza = random.Next(1,3);
        nuevoDemonio.Fuerza = random.Next(2,6);
        nuevoDemonio.Nivel = random.Next(2,6);
        nuevoDemonio.Defensa = random.Next(2,6);
        nuevoDemonio.Salud = 100;
        return nuevoDemonio;
    }
    private Personaje crearCazador(){
        var nuevoCazador = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        string stringFecha = random.Next(1,28)+"/"+random.Next(1,12)+"/"+random.Next(1980,2010);
        DateTime fechaDeNacimiento;
        
        nuevoCazador.Tipo = tipoDePersonaje.cazador;
        nuevoCazador.Nombre = nombresCazadores[numeroRandom,0];
        nuevoCazador.Apodo = nombresCazadores[numeroRandom,1];
        if (DateTime.TryParse(stringFecha,out fechaDeNacimiento))
        {
            nuevoCazador.Fecha_nac = fechaDeNacimiento;
        }else
        {
            nuevoCazador.Fecha_nac = new DateTime(1980,12,5);
        }
        nuevoCazador.Edad = nuevoCazador.SacarEdad();
        nuevoCazador.Velocidad = random.Next(1,5);
        nuevoCazador.Destreza = random.Next(1,3);
        nuevoCazador.Fuerza = random.Next(1,5);
        nuevoCazador.Nivel = random.Next(1,5);
        nuevoCazador.Defensa = random.Next(1,5);
        nuevoCazador.Salud = 100;
        return nuevoCazador;
    }
    private Personaje crearHashira(){
        var nuevoCazador = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        string stringFecha = random.Next(1,28)+"/"+random.Next(1,12)+"/"+random.Next(1980,2010);
        DateTime fechaDeNacimiento;
        
        nuevoCazador.Tipo = tipoDePersonaje.cazador;
        nuevoCazador.Nombre = nombresCazadores[numeroRandom,0];
        nuevoCazador.Apodo = nombresCazadores[numeroRandom,1];
        if (DateTime.TryParse(stringFecha,out fechaDeNacimiento))
        {
            nuevoCazador.Fecha_nac = fechaDeNacimiento;
        }else
        {
            nuevoCazador.Fecha_nac = new DateTime(1980,12,5);
        }
        nuevoCazador.Edad = nuevoCazador.SacarEdad();
        nuevoCazador.Velocidad = random.Next(1,5);
        nuevoCazador.Destreza = random.Next(1,3);
        nuevoCazador.Fuerza = random.Next(1,5);
        nuevoCazador.Nivel = random.Next(1,5);
        nuevoCazador.Defensa = random.Next(1,5);
        nuevoCazador.Salud = 100;
        return nuevoCazador;
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