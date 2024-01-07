namespace DesafioPOO.Models
{
    // Implementação: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero,string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Implementação: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone.");
        }
    }
}