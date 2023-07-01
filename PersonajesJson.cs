namespace Personajes;
using System.Text.Json;
public class PersonajesJson{
    public void GuardarPersonajes(List<Personaje> listaDePersonajes, string nombreDelArchivo){
        if(!Existe(nombreDelArchivo)){
            File.Create(nombreDelArchivo).Close();
        }
        string json = JsonSerializer.Serialize(listaDePersonajes);
        File.WriteAllText(nombreDelArchivo,json);
    }
    public List<Personaje> LeerPersonajes(string nombreDelArchivo){
        if (Existe(nombreDelArchivo))
        {
            string jsonString = File.ReadAllText(nombreDelArchivo);
            var personajesDesearilizados = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
            return personajesDesearilizados;
        }
        var Vacio = new List<Personaje>();
        return Vacio;
    }
    public bool Existe(string rutaDelArchivo){
        if (File.Exists(rutaDelArchivo)){
            var infoDelArchivo = new FileInfo(rutaDelArchivo);
            return (infoDelArchivo.Length > 0); 
        }
        return false;
    }
    public void eliminarPersonajes(string rutaDelArchivo){

        if (File.Exists(rutaDelArchivo))
        {
            File.Delete(rutaDelArchivo);
        }
    }
}