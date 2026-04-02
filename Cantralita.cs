using System.Collections;

public class Centralita
{
    private int totalLlamadas;
    private double totalFacturado;
    private ArrayList listaLlamadas;

    public Centralita()
    {
        totalLlamadas = 0;
        totalFacturado = 0.0;
        listaLlamadas = new ArrayList();
    }

    public void registrarLlamada(Llamada llamada)
    {
        totalLlamadas++;
        totalFacturado += llamada.CalcularPrecio();
        listaLlamadas.Add(llamada);
        Console.WriteLine(llamada.ToString());
    }

    public int getTotalLlamadas()
    {
        return totalLlamadas;
    }

    public double getTotalFacturado()
    {
        return totalFacturado;
    }
}
