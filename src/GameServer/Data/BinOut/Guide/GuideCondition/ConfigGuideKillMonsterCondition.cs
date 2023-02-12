using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigGuideKillMonsterCondition : ConfigGuideCondition
{
	public bool spawnNew;
	public uint monsterID;
	public uint monsterLevel;
	public Vector monsterPos;
	public float monsterYaw;
}