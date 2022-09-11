using GTANetworkAPI;

namespace Rage.Utils
{
    public static class Message
    {
        public static void Notification(Player player, string message)
        {
            player.SendNotification(message);
        }

        public static void Default(Player player, string message)
        {
            player.SendChatMessage(message);
        }

        public static void Console(string message)
        {
            NAPI.Util.ConsoleOutput($"[OVN] {message}");
        }
    }
}