using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigMoveSmoothedSpeed : ConfigMove
    {
        public float maxSpeed;
        public float accelerationXz;
        public float accelerationY;
        public float zeroingSpeedXz;
        public float zeroingSpeedY;
    }
}
