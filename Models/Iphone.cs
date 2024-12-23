namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class CelularApple : Smartphone
    {
        
        public CelularApple(string numero) 
            : base("Apple", "iPhone", numero) // Chamada ao construtor da base
        {            
        }

        public override void FazerLigacao(Smartphone celular)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Ligando de {Numero} - {Marca} {Modelo} para:\n" +
                              $"Número: {celular.Numero} - Marca: {celular.Marca} - Modelo: {celular.Modelo}.");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Instalando aplicativo {nomeApp} para:\n Número: {Numero} - Marca: {Marca} - Modelo: {Modelo}.");
        }

    }
}