using System;
public class Perro: Mamifero 
{
    public bool EsDomestico { get; set; }

    public Perro() 
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() 
    {
        Console.WriteLine("Gua gua gua");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Es muy peludo");
    }

    private void OtroMetodo() 
    {

    }
}