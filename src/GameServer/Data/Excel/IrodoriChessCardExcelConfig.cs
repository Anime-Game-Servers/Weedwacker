using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class IrodoriChessCardExcelConfig
{
	public uint ID;
	public uint costPoints;
	public IrodoriChessCardEffect effect;
	public IrodoriChessCardEffect[] extraEffectList;
	public IrodoriChessCardType cardType;
	public IrodoriChessCardQualityType cardQualityType;
	public IrodoriChessCardTag tag;
	public uint cardNameTextMapHash;
	public uint descTextMapHash;
	public float[] descParam;
	public IrodoriCardNumerical[] cardNumericalList;

	public class IrodoriChessCardEffect
	{
		public IrodoriChessCardTargetType targetType;
		public uint[] targetParamList;
		public IrodoriChessCardEffectType effectType;
		public string effectStrParam;
		public int effectParam1;
		public int effectParam2;
		public int effectParam3;
		public uint effectIndex;
	}
	public class IrodoriCardNumerical
	{
		public IrodoriChessCardNumericalModificationType cardNumericalModificationType;
		public IrodoriChessCardNumericalModificationMode cardNumericalModificationMode;
		public float cardNumericalModificationValue;
	}
}