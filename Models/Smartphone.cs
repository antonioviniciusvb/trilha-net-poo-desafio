namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // Implementação: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
        }

        private string _imei;
        public string Imei
        {
            get { return _imei; }
        }

        private int _memoria;
        public int Memoria
        {
            get { return _memoria; }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Implementação: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}