using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BartenderFormulaExcelConfig
{
	public uint id;
	public BartenderMaterial[] BaseMaterial;
	public BartenderMaterial[] ExtraMaterial;
	public uint[] AvailableAffixList;
	public BartenderMixingState mixingState;
	public uint descTextMapHash;
	public uint nameTextMapHash;
	public uint type;
	public uint lockType;
	public uint blurredDescTextMapHash;
}