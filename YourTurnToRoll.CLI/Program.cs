using System.Security.Authentication.ExtendedProtection;
using YourTurnToRoll.Core;
using YourTurnToRoll.Services;
using Microsoft.Extensions.DependencyInjection;
using YourTurnToRoll.Core.Services;
using IDiceService = YourTurnToRoll.Core.IDiceService;

class Program
{
    static void Main()
    {
        // Setup Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<YourTurnToRoll.Core.Services.IDiceService, DiceService>()
            .BuildServiceProvider();

        Console.WriteLine("Enter character name:");
        string name = Console.ReadLine() ?? "Hero";
    }
}