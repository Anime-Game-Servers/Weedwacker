using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRecordEntity : ConfigRecordActorBase
{
	public ConfigRecordAnimatorInfo animatorInfo;
	public ConfigRecordRendererParameters rendererParams;
	public ConfigRecordMaterialParameters materialParams;
	public ConfigRecordRagdollParameters ragdollParams;
	public ConfigRecordEmoParameters emoParams;
}