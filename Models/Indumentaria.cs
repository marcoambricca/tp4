public class Indumentaria{
    public string Medias {get; private set;}
    public string Pantalon {get; private set;}
    public string Camiseta {get; private set;}

    public Indumentaria(){}

    public Indumentaria(string c, string p, string m){
        Camiseta = c;
        Pantalon = p;
        Medias = m;
    }
}