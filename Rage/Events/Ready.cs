using GTANetworkAPI;
using Rage.Utils;

namespace Rage.Events
{
    public class Ready : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnReady()
        {
            Message.Console("Started without Errors");
        }
    }
}