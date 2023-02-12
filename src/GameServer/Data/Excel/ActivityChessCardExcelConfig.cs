using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityChessCardExcelConfig
{
	public uint ID;
	public uint number;
	public ChessCardTag tag;
	public uint needChessLevel;
	public uint cardNameTextMapHash;
	public uint descTextMapHash;
	public uint extraDescTextMapHash;
	public uint extraDesc2TextMapHash;
	public float[][] descParamList;
	public bool[] descParamSuperpositionList;
	public bool isDisused;
	public ChessCardNumericalModificationType cardNumericalModificationType;
	public ChessCardNumericalModificationMode cardNumericalModificationMode;
	public float cardNumericalModificationValue;
	public uint costPoints;
	public ChessCardType cardType;
	public ChessCardQualityType cardQualityType;
	public uint cardCount;
	public ChessCardEffect effect;
	public uint curseWeight;
	public bool isCanAttachCurse;
	public bool isRemoveOnPick;
	public bool isShowOnPick;
	public ChessCardEffect[] extraEffectList;
}