using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;

namespace Weedwacker.GameServer.Systems.World
{
    internal class CustomGadgetTreeEntity : ScriptGadgetEntity
    {
        internal CustomGadgetTreeEntity(Scene? scene, Gadget spawnInfo) : base(scene, spawnInfo)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            CustomGadgetTreeInfo treeInfo = new();
            //treeInfo.NodeList.AddRange();

            info.Gadget.CustomGadgetTreeInfo = treeInfo;

            return info;
        }
    }
}