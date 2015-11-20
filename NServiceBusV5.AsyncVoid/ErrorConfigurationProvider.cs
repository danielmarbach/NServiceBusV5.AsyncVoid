using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace NServiceBusV5.AsyncVoid
{
    public class ErrorConfigurationProvider : IProvideConfiguration<MessageForwardingInCaseOfFaultConfig>
    {
        public MessageForwardingInCaseOfFaultConfig GetConfiguration()
        {
            return new MessageForwardingInCaseOfFaultConfig { ErrorQueue = "error" };
        }
    }
}