public abstract class Llamada
{
    protected string NumOrigen { get; set; }
    protected string NumDestino { get; set; }
    protected double Duracion { get; set; }

    public Llamada(string NumOrigen, string NumDestino, double Duracion)
    {
        this.NumOrigen = NumOrigen;
        this.NumDestino = NumDestino;
        this.Duracion = Duracion;
    }

    public string getNumOrigen()
    {
        return this.NumOrigen;
    }
    public string getNumDestino()
    {
        return this.NumDestino;
    }
    public double getDuracion()
    {
        return this.Duracion;
    }
    public abstract double CalcularPrecio();

    public override string ToString()
    {
        return $"Origen: {NumOrigen} - Destino: {NumDestino} - Duración: {Duracion} - Precio: {CalcularPrecio()} $";
    }
}