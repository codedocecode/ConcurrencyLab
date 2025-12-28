using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("ConcurrencyLab – Level 1");

        await Mission1_SequentialAwait.Run();
        // await Mission2_LogicalConcurrency.Run();
        // await Mission3_DelayedAwait.Run();
        // await Mission4_WhenAll.Run();
    }
}
