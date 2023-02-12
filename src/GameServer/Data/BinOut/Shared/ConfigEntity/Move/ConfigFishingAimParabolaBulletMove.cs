using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFishingAimParabolaBulletMove : ConfigBulletMove
    {
        public float gravity;
        public float initSpeed;
        public string globalValueKey;
    }
}
