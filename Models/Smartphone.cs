namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama 
        //IMPLEMENTADO! 
        private string Modelo; 
        private string IMEI; 
        private int Memória; 

        public Smartphone(string numero, string modelo, string imei, int memória)
        {
            Numero = numero;
            Modelo = modelo; 
            IMEI = imei; 
            Memória = memória;        
        } 
        
        

        public string GetModelo()
        {
            return Modelo;
        }

        public string GetIMEI()
        {
            return IMEI;
        }

        public int GetMemoria()
        {
            return Memória;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao() 
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}