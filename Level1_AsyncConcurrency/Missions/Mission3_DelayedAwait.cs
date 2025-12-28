public static class Mission3_DelayedAwait
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 3 – Delayed Await");

        Task t1 = OperacionAsync("OperacionLenta", 2000);

        await OperacionAsync("OperacionRapida", 500);
        await t1;
    }

    private static async Task OperacionAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
