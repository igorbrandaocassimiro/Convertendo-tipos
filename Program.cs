using System;
class Program
{
    static void Main(string[] arge)
    {
        decimal pesoContainer = 18.75m; 
        int veiculosNecessarios = (int)pesoContainer; 

        Console.WriteLine("Veículos necessários: " + veiculosNecessarios); 
    }
}