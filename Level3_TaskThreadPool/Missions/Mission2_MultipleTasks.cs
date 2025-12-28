using System;
using System.Threading.Tasks;

public static class Mission2_MultipleTasks
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 2 – Multiple Tasks");

        Task t1 = TrabajoAsync("OperacionA", 1200);
        Task t2 = TrabajoAsync("OperacionB", 800);
        Task t3 = TrabajoAsync("OperacionC", 500);

        await Task.WhenAll(t1, t2, t3);
    }

    private static async Task TrabajoAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
