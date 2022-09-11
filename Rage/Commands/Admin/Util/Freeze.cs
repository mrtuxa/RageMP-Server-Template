using GTANetworkAPI;
using Rage.Utils;

namespace Rage.Commands.Admin.Util
{
    public class Freeze : Script
    {
        [Command("freeze")]
        public void OnFreeze(Player target)
        {
            PlayerUtil.AdminUtil.Freeze(target);
            Message.Notification(target, "An admin has frozen you");
        }

        [Command("unfreeze")]
        public void OnUnFreeze(Player target)
        {
            PlayerUtil.AdminUtil.UnFreeze(target);
            Message.Notification(target, "An admin unfroze you");
        }
    }
}