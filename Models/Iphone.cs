namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        { 

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" 
        //IMPLEMENTADO!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        } 

    }
}