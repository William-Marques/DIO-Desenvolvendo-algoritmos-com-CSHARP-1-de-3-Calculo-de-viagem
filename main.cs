using System;
namespace Desafio_1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] entrada;
          var velocidade = 0;
          var horas = 0;
          var viagem = 0;
          decimal gasolina = 0;
          
          entrada = (Console.ReadLine().Split(' '));
          /*Aqui vai ser colocado o tempo gasto na viagem e a velocidade
          media separado por espaco. O Split vai armazenar cada dado em
          um espaco do array*/
          horas = Convert.ToInt32(entrada[0]); //vai receber do array 0 e converter para inteiro
          velocidade = Convert.ToInt32(entrada[1]);  //vai receber do array 1 e converter para inteiro          
          viagem = (horas * velocidade);// vai receber a multiplicaçao do tempo gasto na viagem pela velocidade média
          gasolina = ((decimal)viagem / 12);// vai receber o valor do total de km percorrido dividido pela autonomia do automovel
          Console.WriteLine(gasolina.ToString("N3"));
        }
    }
}