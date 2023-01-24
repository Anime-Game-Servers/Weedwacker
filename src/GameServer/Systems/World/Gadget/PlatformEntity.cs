using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class PlatformEntity : ScriptGadgetEntity
    {
        bool IsActive;
        bool IsStarted;
        uint RouteId;
        uint AreaId;
        MovingPlatformType MovingType;

        internal PlatformEntity(Scene? scene, SceneGroup.Gadget spawnInfo) : base(scene, spawnInfo)
        {
            RouteId = spawnInfo.route_id;
            AreaId = spawnInfo.area_id;
            IsActive = true;
            IsStarted = false;
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();
            PlatformInfo platform = new()
            {
                IsActive = IsActive,
                IsStarted = IsStarted,
                //PointId = ,
                //MovingPlatformType = MovingType,
                //PosOffset = ,
                //StartPos =,
                //StartIndex =,
                //StartRot =,
                //StartRouteTime =,
                //StartSceneTime =,
                //StopSceneTime =,
                //RotOffset = ,
                //Route =,
                //RouteId =,
            };

            info.Gadget.Platform = platform;
            return info;
        }
    }
}
