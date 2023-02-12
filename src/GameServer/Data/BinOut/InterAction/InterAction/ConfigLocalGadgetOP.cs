using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLocalGadgetOP : ConfigBaseInterAction
{
	public uint gadgetId;
	public uint subKey;
	public int oprCode;
	public Vector position;
	public Vector euler;
	public string gvKey;
	public float gvValue;
	public ConfigLocalGadgetMoveOp[] moveDatas;
	public ConfigLocalGadgetCmd[] cmdList;

	public class ConfigLocalGadgetMoveOp
	{
		public Vector targetPos;
		public float time;
		public TweenEaseType blendType;
	}
	public class ConfigLocalGadgetCmd
	{
		public LocalGadgetCmdExeType cmdExeType;
	}
	public class ConfigLocalGadgetSetMaterialCmd : ConfigLocalGadgetCmd
	{
		public string rendererName;
		public string propName;
		public string propValue;
		public int propType;
	}
}