using GTANetworkAPI;

namespace Rage.Utils
{
    public class PlayerUtil
    {
        public class Vehicle
        {
            public static void Delete(Player player)
            {
                player.Vehicle.Delete();
            }

            public static void Driver(Player player, NetHandle vehicle)
            {
                player.SetIntoVehicle(vehicle, (int)VehicleSeat.Driver);
            }

            public static void Repair(Player player)
            {
                player.Vehicle.Repair();
            }
        }

        public class AdminUtil
        {
            public static void Freeze(Player target)
            {
                NAPI.ClientEvent.TriggerClientEvent(target, "PlayerFreeze", true);
            }

            public static void UnFreeze(Player target)
            {
                NAPI.ClientEvent.TriggerClientEvent(target, "PlayerFreeze", false);
            }
        }
    }
}