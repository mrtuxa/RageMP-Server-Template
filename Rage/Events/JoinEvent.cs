using GTANetworkAPI;
using Rage.Utils;

namespace Rage.Events
{
    public class JoinEvent : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnJoinEvent(Player player)
        {
            Message.Notification(player, "~g~Welcome on my Dev Space");
        }
    }
}