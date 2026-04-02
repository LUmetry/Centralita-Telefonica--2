public class LlamadaProvincial : Llamada
{
    public int Franja { get; set; }
    public double Precio { get; set; }

    public LlamadaProvincial(string NumOrigen, string NumDestino, double Duracion, int Franja) : base(NumOrigen, NumDestino, Duracion)
    {
        this.Franja = Franja;
    }



    public override double CalcularPrecio()
    {
        if (Franja == 1)
        {
            return Precio = Duracion * 0.20;
        }
        else if (Franja == 2)
        {
            return Precio = Duracion * 0.25;
        }
        else if (Franja == 3)
        {
            return Precio = Duracion * 0.30;
        }
        else
        {
            return 0;
        }
    }

    public string toString()
    {
        return $"Llamada Provincial: {NumOrigen} - {NumDestino} - {Duracion} - {Franja}";
    }
}