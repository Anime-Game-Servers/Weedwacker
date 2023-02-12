using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class RoguelikeShikigamiExcelConfig
{
	public uint sequenceId;
	public uint groupId;
	public uint level;
	public RoguelikeShikigamiUnlockConfig[] unlockCond;
	public uint costItemId;
	public uint costItemCount;
	public uint shikiSkillNameTextMapHash;
	public uint shikiSkillDescTextMapHash;

	public class RoguelikeShikigamiUnlockConfig
	{
		public RoguelikeShikigamiUnlockType type;
		public string param;
	}
}