using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

internal class EnterSceneLookMixin : ConfigAbilityMixin
{
	//guessed types
	public string lookAtTag;
	public Vector followOffset;
	public float fov;
	public float deadZoneWidth;
	public float deadZoneHeight;
	public float softZoneWidth;
	public float softZoneHeight;
}
