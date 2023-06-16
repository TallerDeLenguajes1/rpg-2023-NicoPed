namespace Personajes;

public class PersonajesJson{
    public int GuardarPersonajes(List<Personaje> listaDePersonajes){
        string fileName = "personajes.json";
        if(!Existe(fileName)){
            File.Create(fileName);
        }
        string json ;
        return 1;
    }
    public int LeerPersonajes(List<Personaje> listaDePersonajes){
        
        return 1;
    }
    public bool Existe(string rutaDelArchivo){
        
        
        if (File.Exists(rutaDelArchivo)){
            var infoDelArchivo = new FileInfo(rutaDelArchivo);
            return (infoDelArchivo.Length > 0); 
        }
        return false;
    }
}