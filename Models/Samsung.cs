
namespace DesafioPOO.Models
{
	// TODO: Herdar da classe "Smartphone"
	public class CelularSamsung : Smartphone
	{

		public CelularSamsung(string numero)
			: base ("Samsung", "Galaxy S24", numero)
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