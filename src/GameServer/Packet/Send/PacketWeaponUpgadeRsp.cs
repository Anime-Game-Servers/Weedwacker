﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.GameServer.Enums;
using Google.Protobuf;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWeaponUpgradeRsp : BasePacket
    {
        public PacketWeaponUpgradeRsp(WeaponItem item, uint oldLevel, IEnumerable<ItemParam> leftoverOres) : base(OpCode.WeaponUpgradeRsp)
        {
            WeaponUpgradeRsp proto = new()
            {
                CurLevel = item.Level,
                OldLevel = oldLevel,
                TargetWeaponGuid = item.Guid
            };
            proto.ItemParamList.Add(leftoverOres);
            Data = proto.ToByteArray();
        }

    }

}
