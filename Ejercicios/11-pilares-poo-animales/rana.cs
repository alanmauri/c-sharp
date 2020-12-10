
using System;
public class Rana: Anfibio 
{
    public bool EsDomestico { get; set; }

    public Rana() 
    {
        EsDomestico = false;
    }

    public Rana(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Croac() 
    {
        Console.WriteLine("croac croac croa");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Diferentes tamanos");
    }

    private void OtroMetodo() 
    {

    }
}