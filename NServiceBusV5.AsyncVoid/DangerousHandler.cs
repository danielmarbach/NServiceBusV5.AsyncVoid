using System;
using System.Threading.Tasks;
using NServiceBus;

namespace NServiceBusV5.AsyncVoid
{
    public class DangerousHandler : IHandleMessages<DangerousMessage>
    {
        public async void Handle(DangerousMessage message)
        {
            Console.WriteLine("About to loose a message");
            await Task.Delay(2000).ConfigureAwait(false);
            Console.WriteLine("Almost there.");
            throw new InvalidOperationException("Something happened");
        }
    }
}