namespace Personajes;
// asociarle un número para lograr distinguirlos valor random 001 a 999
public class fabricaDePersonaje{
private string [ , ] nombresDemonios = {{"Enmu","Luna Inferior Uno"},{"Rokuro","Luna Inferior Dos"},{"Wakuraba","Luna Inferior Tres"},{"Mukago","Luna Inferior Cuatro"},{"Rui","Luna Inferior cinco"}};
private string [ , ] nombresCrecientes = {{"Gyokko","Luna Superior Cinco"},{"Nakime","Luna Superior Cuatro"},{"Akaza","Luna Superior Tres"},{"Doma","Luna Superior Dos"},{"Kokushibo","Luna Superior Uno"}};
private string [ , ] nombresCazadores = {{"Zenitsu","Respiración del Rayo"},{"Tanjiro","Respiración Solar"},{"Inosuke","Respiración de la Bestia"},{"Kanao","Respiración De La Mariposa"},{"Genya","Come Demonios"}};
private string [ , ] nombresHashira = {{"Tomioka","Respiración del Agua"},{"Uzui","Respiración del Sonido"},{"Shinobu","Respiración de la Mariposa"},{"Muichiro","Respiración De La neblina"},{"Mitsuri","Respiración Del Amor"}};
    public Personaje crearPersonaje(){
        var nuevoPersonaje = new Personaje();
        var random = new Random(DateTime.Now.Microsecond);
        var numeroRandom = random.Next(0,4);
        tipoDePersonaje tipoPersonaje;
        tipoPersonaje = (tipoDePersonaje)numeroRandom;
        string numeroAsociado = random.Next(0,99).ToString();

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
        nuevoPersonaje.Nombre = string.Concat(nuevoPersonaje.Nombre," ",numeroAsociado);
        return nuevoPersonaje;
    }
    private Personaje crearDemonio(){
        var nuevoDemonio = new Personaje();
        var random = new Random(DateTime.Now.Millisecond);
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
        nuevoDemonio.Velocidad = random.Next(3,7);
        nuevoDemonio.Destreza = random.Next(1,3);
        nuevoDemonio.Fuerza = random.Next(3,6);
        nuevoDemonio.Poder = random.Next(4,6);
        nuevoDemonio.Defensa = random.Next(2,7);
        nuevoDemonio.Salud = 100;
        return nuevoDemonio;
    }
    private Personaje crearCazador(){
        var nuevoCazador = new Personaje();
        var random = new Random(DateTime.Now.Millisecond);
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
        nuevoCazador.Velocidad = random.Next(4,7);
        nuevoCazador.Destreza = random.Next(1,3);
        nuevoCazador.Fuerza = random.Next(2,7);
        nuevoCazador.Poder = random.Next(2,6);
        nuevoCazador.Defensa = random.Next(3,6);
        nuevoCazador.Salud = 100;
        return nuevoCazador;
    }
    private Personaje crearHashira(){
        var nuevoHashira = new Personaje();
        var random = new Random(DateTime.Now.Millisecond);
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
        nuevoHashira.Velocidad = random.Next(4,7);
        nuevoHashira.Destreza = random.Next(1,4);
        nuevoHashira.Fuerza = random.Next(4,7);
        nuevoHashira.Poder = random.Next(2,7);
        nuevoHashira.Defensa = random.Next(4,6);
        nuevoHashira.Salud = 100;
        return nuevoHashira;
    }
    private Personaje crearCreciente(){
        var nuevoCreciente = new Personaje();
        var random = new Random(DateTime.Now.Millisecond);
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
        nuevoCreciente.Velocidad = random.Next(2,8);
        nuevoCreciente.Destreza = random.Next(1,4);
        nuevoCreciente.Fuerza = random.Next(2,8);
        nuevoCreciente.Poder = random.Next(3,8);
        nuevoCreciente.Defensa = random.Next(2,8);
        nuevoCreciente.Salud = 100;
        return nuevoCreciente;
    }
    public Personaje aleatorio(string nombre, string apodo, DateTime fechaDeNac){
        var random = new Random();
        int restar = random.Next(0,3);
        var aleatorio = new Personaje();
        aleatorio.Nombre = nombre;
        aleatorio.Apodo = apodo;
        aleatorio.Fecha_nac = fechaDeNac;
        aleatorio.Edad = aleatorio.SacarEdad();
        if (random.Next(0,2) == 0)
        {
            aleatorio.Defensa = 6 - restar;
            aleatorio.Fuerza = 6 + restar;
            aleatorio.Destreza = 3 - restar;
            aleatorio.Velocidad = 5 + restar;
            aleatorio.Poder = 5;

        }else
        {
            aleatorio.Defensa = 6 + restar;
            aleatorio.Fuerza = 6 - restar;
            aleatorio.Destreza = 3 + restar;
            aleatorio.Velocidad = 6 - restar;
            aleatorio.Poder = 4;
        }
            aleatorio.Salud = 100;
            aleatorio.Tipo = tipoDePersonaje.Cazador;
        return aleatorio;

    }
}
