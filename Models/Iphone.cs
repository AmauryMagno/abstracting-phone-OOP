namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }
        
        public override void InstallAplication(string appName)
        {
            Console.WriteLine($"Instalando o aplicativo {appName} no Iphone.");
        }

    }
}