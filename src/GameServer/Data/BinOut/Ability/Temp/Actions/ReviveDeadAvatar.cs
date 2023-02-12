using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class ReviveDeadAvatar : ReviveAvatar
{
	public bool isReviveOtherPlayerAvatar;
	public uint skillID;
	public object cdRatio;
	public float range;
}
