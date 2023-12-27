namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" 
    //IMPLEMENTADO!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" 
        //IMPLEMENTADO!
        public Nokia(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        { 

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" 
        //IMPLEMENTADO!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        } 

    }
}