using System;


Log("Application started.");

try
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World et bienvenue! Tapez un nombre pour calculer son carré :");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        var result = await CalculateSquareAsync(number);

        Log($"Le carré de {number} est {result}");

        Console.WriteLine($"Le carre de {number} est {result}");
    }
    else
    {
        Log($"Entrée invalide: {input}", isError: true);

        Console.WriteLine("Veuillez entrer un nomber valide !");
    }  
}
catch (System.Exception)
{

    throw;
}
finally
{
    Log("Application terminée.");
}

  async Task<int> CalculateSquareAsync(int n)
    {
        await Task.Delay(300); //to simulate un traitement async

        return n * n;
    }


void Log(string message, bool isError = false)
{
    var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    var prefix = isError ? "[ERREUR]" : "[INFO]";
    Console.WriteLine($"{timestamp} {prefix} {message}");
}
