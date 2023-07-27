namespace Chistes;
using System.Net;
using System.Text.Json;

class obtenerChiste{
    
    public static unChiste Chiste(){
        var url= $"https://v2.jokeapi.dev/joke/Any?lang=es";
        var request = (HttpWebRequest) WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        unChiste obtChiste = null;
        try{
        using (WebResponse response = request.GetResponse())
        {
            using (Stream strReader = response.GetResponseStream())
            {
                if (strReader == null) return obtChiste;
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        obtChiste = JsonSerializer.Deserialize<unChiste>(responseBody);
                    }
            }
        }
        }
        catch(WebException ex){
            Console.WriteLine("Problemas con la API");
        }
        return obtChiste; 
    }
}