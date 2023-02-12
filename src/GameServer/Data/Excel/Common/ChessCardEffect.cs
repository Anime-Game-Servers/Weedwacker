using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ChessCardEffect
{
	public ChessCardTargetType targetType;
	public uint[] targetParamList;
	public ChessCardEffectType effectType;
	public string effectStrParam;
	public int effectParam1;
	public int effectParam2;
	public int effectParam3;
	public uint beginRound;
	public uint activeRounds;
	public uint effectIndex;
}