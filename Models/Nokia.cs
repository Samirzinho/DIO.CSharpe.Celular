namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class CelularNokia : Smartphone
    {
        // TODO: Herdar da classe "Smartphone"
        public CelularNokia(string numero)
            : base ("Nokia", "3110", numero) 
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