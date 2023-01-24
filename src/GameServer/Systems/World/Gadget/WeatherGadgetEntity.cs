using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class WeatherGadgetEntity : ScriptGadgetEntity
    {
        private uint WeatherAreaId;

        internal WeatherGadgetEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();
            WeatherInfo weather = new()
            {
                WeatherAreaId = WeatherAreaId
            };
            info.Gadget.Weather = weather;

            return info;
        }
    }
}
