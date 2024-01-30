namespace DesafioPOO.Models;

public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
{
    public string Numero { get; set; } = numero;
    private readonly string _modelo = modelo;
    private readonly string _imei = imei;
    private readonly int _memoria = memoria;

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public override string ToString()
    {
        return $"Marca: {this.GetType().Name} / Número: {Numero} / Modelo: {_modelo} / IMEI: {_imei} / Memória: {_memoria}";
    }

    public abstract void InstalarAplicativo(string nomeApp);
}
