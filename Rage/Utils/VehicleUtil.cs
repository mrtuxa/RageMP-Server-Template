using GTANetworkAPI;

namespace Rage.Utils
{
    public class VehicleUtil
    {
        public static uint GetHashKey(string vehicle)
        {
            return NAPI.Util.GetHashKey(vehicle);
        }

        public static Vehicle Spawn(uint hash, Player player, int primary, int secondary)
        {
            return NAPI.Vehicle.CreateVehicle(hash, player.Position, player.Heading, primary, secondary);
        }
    }
}