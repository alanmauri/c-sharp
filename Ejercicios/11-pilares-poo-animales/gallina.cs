using System;
public class Gallina: Ave 
{
    public bool EsDomestico { get; set; }

    public Gallina() 
    {
        EsDomestico = true;
    }

    public Gallina(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Kikikear() 
    {
        Console.WriteLine("Kikiriki");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Es un ave de corral mediana");
    }

    private void OtroMetodo() 
    {

    }
}