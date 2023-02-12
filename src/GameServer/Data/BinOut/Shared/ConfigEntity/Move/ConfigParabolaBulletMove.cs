using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigMoveCorrectionType;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigParabolaBulletMove : ConfigBulletMove
    {
        public float angleOffHor;
        public float gravityOfAcceleration;
        public ConfigMoveCorrection correction;
    }
}
