using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class FixedMonsterRushMove : ConfigAbilityAction
{
	public ConfigBornType toPos;
	public object timeRange;
	public float maxRange;
	public string[] animatorStateIDs;
	public string overrideMoveCollider;
	public bool isInAir;
	public bool checkAnimatorStateOnExitOnly;
	public bool ignoreDetectForward;
	public bool exactArrive;
}
