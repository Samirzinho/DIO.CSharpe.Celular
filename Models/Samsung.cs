
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
							  $"N�mero: {celular.Numero} - Marca: {celular.Marca} - Modelo: {celular.Modelo}.");
		}

        // TODO: Sobrescrever o m�todo "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Instalando aplicativo {nomeApp} para:\n N�mero: {Numero} - Marca: {Marca} - Modelo: {Modelo}.");
		}  
		
    }
}