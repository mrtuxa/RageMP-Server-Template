using GTANetworkAPI;

namespace Rage.Blips
{
    public class MdBlip : Script
    {
        public Blip CreateMarker(uint sprite, Vector3 position, float scale, byte color, string name = "",
            byte alpha = 255, float drawDistance = 0, bool shortRange = true, short rotation = 0,
            uint dimension = uint.MaxValue)
        {
            var blip = NAPI.Blip.CreateBlip(sprite, position, scale, color, name, alpha, drawDistance, shortRange,
                rotation, dimension);
            return blip;
        }

        public MdBlip()
        {
            CreateMarker(61, new Vector3(1152.221, -1527.989, 34.8434), 0.8f, 1, "Los Santos Medical Department");
        }
    }
}