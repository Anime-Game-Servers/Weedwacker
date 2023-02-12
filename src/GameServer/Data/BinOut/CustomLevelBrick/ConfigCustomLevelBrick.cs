using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCustomLevelBrick
{
	public Vector brickSize;
	public PileTag[] pileTags;
	public float cameraFocusDis;
	public bool isCreater;
	public CreaterDir createrDir;
	public CreaterBornTag bornTag;
	public uint serverGadgetId;
	public uint configLevel;
}