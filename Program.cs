using DesafioPOO.Models;
using Microsoft.Win32.SafeHandles;
using System;

namespace CelularApp
{
    // TODO: Realizar os testes com as classes Nokia, Samsung Iphone
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de celulares
            Smartphone samsung = new CelularSamsung("1234Samsung");
            Smartphone apple = new CelularApple("1234Apple");
            Smartphone nokia = new CelularNokia("1234Nokia");

            samsung.FazerLigacao(apple);
            apple.FazerLigacao(nokia);
            nokia.FazerLigacao(samsung);

            samsung.ReceberLigacao(nokia);
            apple.ReceberLigacao(samsung);
            nokia.ReceberLigacao(apple);

            samsung.InstalarAplicativo("WhatsApp");
            apple.InstalarAplicativo("NetFlix");
            nokia.InstalarAplicativo("Amazon Prime");

            samsung.EnviarMensagem(nokia, "Olá! Este é um Samsung.");
            apple.EnviarMensagem(samsung, "Olá! Este é um iPhone.");
            nokia.EnviarMensagem(apple, "Olá! Este é um Nokia.");
        }
    }
}