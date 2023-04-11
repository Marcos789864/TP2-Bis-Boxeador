int opcion = 0;
double sk1 = 0,sk2 = 0;
Boxeador box1 = new Boxeador();
Boxeador box2 = new Boxeador();
opcion = Funciones.IngresarEnteroEnRango("Ingrese la opcion que desea ejecutar: (1)Cargar datos boxeador 1, (2) Cargar datos boxeador 2, (3) Pelear ,(4)CambiarAtributos y (5) Salir",1,5);
while(opcion != 5)
{
    switch(opcion)
    {
        case 1:
            box1 =Funciones.IngresarBoxeador();
            sk1 = box1.ObtenerSkills();
          
        break;
        case 2:
            box2 =Funciones.IngresarBoxeador();
            sk2 = box2.ObtenerSkills();
        break;
        case 3:
        if(sk1 == 0 || sk2 == 0)
        {
            Console.WriteLine("Nose cargaron todos los boxeadores");
        }
        else
        {
            Funciones.pelear(sk1,sk2,box1,box2);
        }
        break;
        case 4:
        if(sk1 == 0 || sk2 == 0)
        {
            Console.WriteLine("Nose cargaron todos los boxeadores");
        }
        else Funciones.CambiarAtributos(box1,box2,ref sk1,ref sk2);  Funciones.pelear(sk1,sk2,box1,box2);
        break;
        
    }
    opcion = Funciones.IngresarEnteroEnRango("Ingrese la opcion que desea ejecutar: (1)Cargar datos boxeador 1, (2) Cargar datos boxeador 2, (3) Pelear ,(4)CambiarAtributos y (5) Salir",1,5);
}
