public static class Mission2_LogicalConcurrency
{
    public static async Task Run()
    {
        Console.WriteLine("Mission 2 – Logical Concurrency");

        Task t1 = OperacionAsync("SolicitudRemota", 1500);
        Task t2 = OperacionAsync("AccesoCache", 700);

        await t1;
        await t2;
    }

    private static async Task OperacionAsync(string nombre, int delay)
    {
        Console.WriteLine($"Inicio {nombre} ({Environment.CurrentManagedThreadId})");
        await Task.Delay(delay);
        Console.WriteLine($"Fin {nombre} ({Environment.CurrentManagedThreadId})");
    }
}
