using System;
using System.Threading.Tasks;

public static class Mission1_SequentialMixed
{
    public static async Task Run()
    {
        Console.WriteLine(""Mission 1 – Sequential Mixed"");

        Console.WriteLine($""Before await: Thread {Environment.CurrentManagedThreadId}"");
        await TrabajoAsync(""LecturaArchivo"", 1000);
        Console.WriteLine($""After await: Thread {Environment.CurrentManagedThreadId}"");

        await TrabajoAsync(""ConsultaBD"", 500);
    }

    private static async Task TrabajoAsync(string nombre, int delay)
    {
        Console.WriteLine($""Inicio {nombre} ({Environment.CurrentManagedThreadId})"");
        await Task.Delay(delay);
        Console.WriteLine($""Fin {nombre} ({Environment.CurrentManagedThreadId})"");
    }
}
