using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityChessLevelExcelConfig
{
	public uint level;
	public uint descTextMapHash;
	public uint expToNext;
	public uint homeHP;
	public uint initialBuild;
	public uint cardCount;
	public uint cardCost;
	public CardFortuneType cardFortune;
	public uint[] fortuneList;
	public uint freeCardCount;
	public bool isNewGearUnlocked;
	public bool isNewCardUnlocked;
}