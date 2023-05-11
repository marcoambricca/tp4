using System.Collections.Generic;

public static class Equipos{
    public static List<string>ListaEquipos {get; private set;} = new List<string>(){
        "river", "boca", "racing", "aldosivi", "patronato", "banfield", "atlanta", "chacarita", "independiente", "colon"
    };
    public static List<string>ListaMedias {get; private set;} = new List<string>(){
        "mediasrojas.jpg", "mediasamarillas.jpg", "mediasnaranjas.jpg", "mediasverdes.jpg", "mediasverdeclaro.jpg", "mediasazules.jpg", "mediascelestes.jpg", "mediasvioletas.jpg", "mediasblancas.jpg", "mediasnegras.jpg"
    };
    public static List<string>ListaPantalones {get; private set;} = new List<string>(){
        "shortrojo.jpg", "shortamarillo.jpg", "shortnaranja.jpg", "shortverde.jpg", "shortverdeclaro.jpg", "shortazul.jpg", "shortceleste.jpg", "shortvioleta.jpg", "shortblanco.jpg", "shortnegro.jpg"
    };
    public static List<string>ListaRemeras {get; private set;} = new List<string>(){
        "camisetaroja.jpg", "camisetaamarilla.jpg", "camisetanaranja.jpg", "camisetaverde.jpg", "camisetaverdeclaro.jpg", "camisetaazul.jfif", "camisetaceleste.jpg", "camisetamarron.jpg", "camisetablanca.jfif", "camisetanegra.jpg"
    };
    public static List<string>ListaColores {get; private set;} = new List<string>(){ 
        "rojo", "amarillo", "naranja", "verde", "verde claro", "azul", "celeste", "marron", "blanco", "negro"
    };
    public static Dictionary<string, Indumentaria>EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        bool sePuedeIngresar = false;
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado)){
            EquiposIndumentaria.Add(EquipoSeleccionado, item);
            sePuedeIngresar = true;
        }
        return sePuedeIngresar;
    }
}