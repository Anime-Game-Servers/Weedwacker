using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class WidgetCDSyncMixin : ConfigAbilityMixin
{
	public bool syncOnTick;
	public bool syncOnChangeAvatar;
	public bool syncOnCDChange;
	public bool syncOnlyGreater;
	public uint itemId;
	public uint skillId;
	public float skillCDOffset;
}
