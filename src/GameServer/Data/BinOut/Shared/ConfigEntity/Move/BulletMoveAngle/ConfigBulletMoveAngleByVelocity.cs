using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigBulletMoveAngleType
{
    internal class ConfigBulletMoveAngleByVelocity : ConfigBulletMoveAngle
    {
        public float traceLerpCoef;
        public bool isSmoothRotation;
    }
}
