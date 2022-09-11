using System;
using System.Text;
using GTANetworkAPI;
using PasswordGenerator;
using Rage.Utils;

namespace Rage.Commands.Spawner
{
    internal class VehicleSpawner : Script
    {
        [Command("car")]
        public void OnCommand(Player player, string name, int color1, int color2)
        {
            var hash = NAPI.Util.GetHashKey(name);
            if (hash <= 0)
            {
                player.SendNotification("~r~Invalid spawn Name");
                return;
            }

            if (player.IsInVehicle)
            {
                NAPI.Player.GetPlayerVehicle(player).Delete();
                var vehicle = NAPI.Vehicle.CreateVehicle(hash, player.Position, player.Heading, color1, color2);
                // vehicle.NumberPlate = "OVN";
                vehicle.NumberPlate = "OVN";
                vehicle.Locked = false;
                vehicle.EngineStatus = true;
                player.SetIntoVehicle(vehicle, (int)VehicleSeat.Driver);
            }
            else
            {
                var vehicle = NAPI.Vehicle.CreateVehicle(hash, player.Position, player.Heading, color1, color2);
                vehicle.NumberPlate = "OVN";
                vehicle.Locked = false;
                vehicle.EngineStatus = true;
                player.SetIntoVehicle(vehicle, (int)VehicleSeat.Driver);
            }
        }

        [Command("deletecar")]
        public void OnCommand(Player player)
        {
            if (player.IsInVehicle)
            {
                Message.Notification(player, "Vehicle will be deleted");
                NAPI.Player.GetPlayerVehicle(player).Delete();
            }
            else
            {
                Message.Notification(player, "You are not in an vehicle");
            }
        }

        [Command("repair")]
        public void OnRepair(Player player)
        {
            PlayerUtil.Vehicle.Repair(player);
        }
    }
}