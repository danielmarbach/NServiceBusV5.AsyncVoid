using NServiceBus;

namespace NServiceBusV5.AsyncVoid
{
    public class DangerousVanillaHandler : IHandleMessages<AcquireVanilla>
    {
        private readonly WebService webservice;

        public DangerousVanillaHandler()
        {
            webservice = new WebService();
        }

        public async void Handle(AcquireVanilla message)
        {
            var vanilla = await webservice.AcquireVanilla();
        }
    }
}