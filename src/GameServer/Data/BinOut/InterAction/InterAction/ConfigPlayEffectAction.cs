using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPlayEffectAction : ConfigBaseInterAction
{
	public string effectIndex;
	public string patternName;
	public Vector pos;
	public Vector euler;
	public Vector scale;
	public bool isLoop;
	public bool attachToEntity;
	public bool isRemove;
	public uint attachGadgetId;
	public uint attachGadgetSubKey;
}