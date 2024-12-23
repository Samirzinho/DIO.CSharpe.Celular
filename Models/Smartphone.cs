namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; protected set; }
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string marca, string modelo, string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void FazerLigacao(Smartphone celular);

        public abstract void InstalarAplicativo(string nomeApp);


        public void ReceberLigacao(Smartphone celular)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{Marca} {Modelo} Recebendo Ligação de:\n" +
                              $"Número: {celular.Numero} - Marca: {celular.Marca} - Modelo: {celular.Modelo}.");
        }         

        public void EnviarMensagem(Smartphone celular, string mensagem)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{Marca} {Modelo} Enviando Mensagem para:\n " +
                              $"Número: {celular.Numero} - Marca: {celular.Marca} - Modelo: {celular.Modelo}.\n" +
                              $"Mensagem: {mensagem}");

        }
    }
}