using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCustomLevelDungeon
{
	public uint dungeonID;
	public uint startRoomId;
	public ConfigCustomLevelRoomSetting[] roomList;

	public class ConfigCustomLevelRoomSetting
	{
		public uint roomID;
		public uint componentLimitConfig;
		public Vector playerInitPos;
		public Vector playerInitRot;
		public ConfigCustomLevelRoomBasic basicData;
		public ConfigCustomLevelRoomExtraData[] extraData;

		public class ConfigCustomLevelRoomExtraData
		{
			public uint index;
			public Vector occupyPos;
			public Vector occupyBound;
			public PileTag[] pileTags;
			public bool isGadget;
			public uint configID;
			public Vector gadgetRot;
		}
		public class ConfigCustomLevelRoomBasic
		{
			public Vector deployStartPos;
			public Vector deployBound;
			public uint totalCost;
			public uint[] preRooms;
			public uint[] nextRooms;
			public Vector bornPos;
			public Vector bornRot;
		}
	}
}