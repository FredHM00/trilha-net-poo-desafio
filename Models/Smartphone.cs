namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException("Número não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(modelo)) throw new ArgumentException("Modelo não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(imei)) throw new ArgumentException("IMEI não pode ser vazio.");
            if (memoria <= 0) throw new ArgumentOutOfRangeException(nameof(memoria), "Memória deve ser maior que zero.");

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar() => Console.WriteLine("Ligando...");
        public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
