class LlamadaLocal : Llamada
{
    private double Precio;

    public LlamadaLocal(string NumOrigen, string NumDestino, double Duracion, double Precio) : base(NumOrigen, NumDestino, Duracion)
    {
        this.Precio = Precio;
    }

    public override double CalcularPrecio()
    {
        return Precio = Duracion * 0.15;
    }
    public string toString()
    {
        return $"Llamada Local: {NumOrigen} - {NumDestino} - {Duracion} - {Precio}";
    }


}
