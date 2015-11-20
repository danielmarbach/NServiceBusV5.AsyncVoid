using System;
using System.Threading.Tasks;

namespace NServiceBusV5.AsyncVoid
{
    public class WebService
    {
        public async Task<Vanilla> AcquireVanilla()
        {
            Console.WriteLine("Acquiring vanilla");
            await Task.Delay(2000).ConfigureAwait(false);
            Console.WriteLine("Almost acquired vanilla.");
            throw new TimeoutException("Something happened");
        }
    }
}