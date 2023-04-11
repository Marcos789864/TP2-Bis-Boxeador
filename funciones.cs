public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {   
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }

    public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(msj);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("ERROR! " + msj);
        }
        return entero;
    }

    public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = IngresarTexto(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }

    public  static int numRandom()
    {
        int num;
        Random r = new Random();
        num = r.Next(1,101);
        return num;

    }

    public static Boxeador IngresarBoxeador()
    {
        string nombre = IngresarTexto("Ingrese el nombre del boxeador ");
        string  pais = IngresarTexto("Ingrese el pais del boxeador ");
        int peso = numRandom();    
        double inteligencia = numRandom();
        Boxeador box = new Boxeador(nombre,pais,peso,inteligencia);
        Console.WriteLine("Se ha creado el boxeador" + nombre);
        return box;
    }

    public static void pelear(double sk1,double sk2,Boxeador box1,Boxeador box2)
    {
        
        if(sk1 > sk2 && sk1 - sk2 >= 30)
        {
            Console.WriteLine("Gano " + box1.Nombre + " por KO");
        }
        else if(sk2 > sk1 && sk2 - sk1 >= 30)
        {
            Console.WriteLine("Gano " + box2.Nombre + " por KO");
        }
        else if(sk1 > sk2 && sk1-sk2 >= 15 && sk1 - sk2 < 30)
        {
            Console.WriteLine("Gano " + box1.Nombre + " por puntos en fallo unanime");
        }
        else if(sk2 > sk1 && sk2-sk1 >= 15 && sk2 - sk1 < 30)
        {
            Console.WriteLine("Gano " + box2.Nombre + " por puntos en fallo unanime");
        }
        else if(sk1 > sk2 && sk1-sk2 <= 10)
        {
            Console.WriteLine("Gano " + box1.Nombre + " por puntos en fallo divido"); 
        }
        else if(sk2 > sk1 && sk2 - sk1 <= 10)
        {
            Console.WriteLine("Gano " + box2.Nombre + " por puntos en fallo divido");
        }
        Console.ReadLine();
    }

    public static void CambiarAtributos(Boxeador box1, Boxeador box2,ref double sk1, ref double  sk2)
    {   
        int box = 0;
        box = IngresarEnteroEnRango("Que boxeador desea modificar la informacion: (1) boxeador 1 o (2) boxeador 2",1,2);
        if(box == 1)
        {
           box1.VelocidadPiernas = IngresarEntero("Ingrese la velocidad de piernas del Boxeador 1 ");
           box1.PotenciaGolpes = IngresarEntero("Ingrese la potencia de golpe del boxeador 1 "); 
            sk1 = box1.ObtenerSkills();

        }
        else
        {
            box2.VelocidadPiernas = IngresarEntero("Ingrese la velocidad de piernas del Boxeador 2 ");
            box2.PotenciaGolpes = IngresarEntero("Ingrese la potencia de golpe del boxeador 2 ");
             sk2 = box2.ObtenerSkills();
        }
    }

}