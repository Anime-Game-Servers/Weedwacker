﻿using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class ScriptGadgetEntity : BaseGadgetEntity, IScriptEntity
    {
        public GadgetState State { get; protected set; }
        public uint BlockId { get; set; }
        public uint GroupId { get; set; }
        public uint ConfigId { get; set; }

        protected ScriptGadgetEntity(Scene? scene, SceneGroup.Gadget spawnInfo) : base(scene, spawnInfo)
        {
            BlockId = spawnInfo.BlockId;
            GroupId = spawnInfo.GroupId;
            ConfigId = spawnInfo.config_id;
        }

        public async void SetGadgetState(int state)
        {
            State = (GadgetState)state;
            //await Scene.BroadcastPacketAsync(new PacketGadgetStateNotify(this, state));
            //await Scene.ScriptManager.CallEvent(EventType.EVENT_GADGET_STATE_CHANGE, new ScriptArgs(state, (int)ConfigId));
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            info.Gadget.ConfigId = ConfigId;
            info.Gadget.GroupId = GroupId;

            return info;
        }
    }
}
