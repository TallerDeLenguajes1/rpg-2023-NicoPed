namespace Personajes;

public class fabricaDePersonaje{
private string [ , ] nombresDemonios = {{"Enmu","Luna Inferior Uno"},{"Rokuro","Luna Inferior Dos"},{"Wakuraba","Luna Inferior Tres"},{"Mukago","Luna Inferior Cuatro"},{"Rui","Luna Inferior Tres"}};
private string [ , ] nombresCrecientes = {{"Gyokko","Luna Superior Cinco"},{"Nakime","Luna Superior Cuatro"},{"Akaza","Luna Superior Tres"},{"Doma","Luna Superior Dos"},{"Kokushibo","Luna Superior Uno"}};
private string [ , ] nombresCazadores = {{"Zenitsu","Respiración del Rayo"},{"Tanjiro","Respiración Solar"},{"Inosuke","Respiración de la Bestia"},{"Kanao","Respiración De La Mariposa"},{"Genya","Come Demonios"}};
private string [ , ] nombresHashira = {{"Tomioka","Respiración del Agua"},{"Uzui","Respiración del Sonido"},{"Shinobu","Respiración de la Mariposa"},{"Muichiro","Respiración De La neblina"},{"Mitsuri","Respiración Del Amor"}};

    public Personaje crearPersonaje(){
        var nuevoPersonaje = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,4);
        tipoDePersonaje tipoPersonaje;
        tipoPersonaje = (tipoDePersonaje)numeroRandom;

        switch (tipoPersonaje)
        {
            case tipoDePersonaje.Demonio:
                nuevoPersonaje = crearDemonio();
            break;
            case tipoDePersonaje.Creciente:
                nuevoPersonaje = crearCreciente();
            break;
            case tipoDePersonaje.Cazador:
                nuevoPersonaje = crearCazador();
            break;
            case tipoDePersonaje.Hashira:
                nuevoPersonaje = crearHashira();
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
        
        nuevoDemonio.Tipo = tipoDePersonaje.Demonio;
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
        
        nuevoCazador.Tipo = tipoDePersonaje.Cazador;
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
        var nuevoHashira = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        string stringFecha = random.Next(1,28)+"/"+random.Next(1,12)+"/"+random.Next(1980,2010);
        DateTime fechaDeNacimiento;
        
        nuevoHashira.Tipo = tipoDePersonaje.Hashira;
        nuevoHashira.Nombre = nombresHashira[numeroRandom,0];
        nuevoHashira.Apodo = nombresHashira[numeroRandom,1];
        if (DateTime.TryParse(stringFecha,out fechaDeNacimiento))
        {
            nuevoHashira.Fecha_nac = fechaDeNacimiento;
        }else
        {
            nuevoHashira.Fecha_nac = new DateTime(1980,12,5);
        }
        nuevoHashira.Edad = nuevoHashira.SacarEdad();
        nuevoHashira.Velocidad = random.Next(5,10);
        nuevoHashira.Destreza = random.Next(3,5);
        nuevoHashira.Fuerza = random.Next(5,10);
        nuevoHashira.Nivel = random.Next(5,10);
        nuevoHashira.Defensa = random.Next(5,10);
        nuevoHashira.Salud = 100;
        return nuevoHashira;
    }
        private Personaje crearCreciente(){
        var nuevoCreciente = new Personaje();
        var random = new Random();
        var numeroRandom = random.Next(0,5);
        string stringFecha = random.Next(1,28)+"/"+random.Next(1,12)+"/"+random.Next(1000,2000);
        DateTime fechaDeNacimiento;
        
        nuevoCreciente.Tipo = tipoDePersonaje.Creciente;
        nuevoCreciente.Nombre = nombresDemonios[numeroRandom,0];
        nuevoCreciente.Apodo = nombresDemonios[numeroRandom,1];
        if (DateTime.TryParse(stringFecha,out fechaDeNacimiento))
        {
            nuevoCreciente.Fecha_nac = fechaDeNacimiento;
        }else
        {
            nuevoCreciente.Fecha_nac = new DateTime(1000,12,5);
        }
        nuevoCreciente.Edad = nuevoCreciente.SacarEdad();
        nuevoCreciente.Velocidad = random.Next(6,11);
        nuevoCreciente.Destreza = random.Next(3,5);
        nuevoCreciente.Fuerza = random.Next(6,11);
        nuevoCreciente.Nivel = random.Next(6,11);
        nuevoCreciente.Defensa = random.Next(6,11);
        nuevoCreciente.Salud = 100;
        return nuevoCreciente;
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