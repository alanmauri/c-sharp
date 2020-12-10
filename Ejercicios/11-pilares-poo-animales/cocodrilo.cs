using System;
public class Cocodrilo: Reptil 
{
    public bool EsDomestico { get; set; }

    public Cocodrilo() 
    {
        EsDomestico = false;
    }

    public Cocodrilo(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Gruñir() 
    {
        Console.WriteLine("roar roa roar");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Casi del tamano de un humano de largo");
    }

    private void OtroMetodo() 
    {

    }
}
using System;
public class Cocodrilo: Reptil 
{
    public bool EsDomestico { get; set; }

    public Cocodrilo() 
    {
        EsDomestico = false;
    }

    public Cocodrilo(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Gruñir() 
    {
        Console.WriteLine("roar roa roar");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Casi del tamano de un humano de largo");
    }

    private void OtroMetodo() 
    {

    }
}
