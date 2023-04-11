public class Boxeador
{
    public string Nombre {get;set;}
    public string Pais {get;set;}
    public int Peso {get;set;}
    public int PotenciaGolpes {get;set;}
    public int VelocidadPiernas {get;set;}
    public double Inteligencia {get;set;}


    public Boxeador()
    {

    }

    public Boxeador (string nom,string pais,int peso, double inteligencia)
    {
        Nombre = nom;
        Pais= pais;
        Peso = peso;
        Inteligencia = inteligencia;
        
    }

    public void ValorAleatorioAtributos()
    {
        PotenciaGolpes = Funciones.numRandom();
        VelocidadPiernas = Funciones.numRandom();
    }

    public double ObtenerSkills()
    {   
        double sk = PotenciaGolpes + VelocidadPiernas + (Inteligencia * 0.25);
        return sk;
    }
}