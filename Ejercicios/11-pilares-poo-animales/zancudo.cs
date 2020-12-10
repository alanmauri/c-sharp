using System;
public class Zancudo: Insecto 
{
    public bool EsDomestico { get; set; }

    public Zancudo() 
    {
        EsDomestico = false;
    }

    public Zancudo(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Zumbido() 
    {
        Console.WriteLine("Zumbido");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Casi microscopico");
    }

    private void OtroMetodo() 
    {

    }
}