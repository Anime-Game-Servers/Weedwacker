using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigRecordAnimatorInfo
{
	public AnimatorParameters animatorParameter;
	public AnimatorRecordState currentState;
	public AnimatorRecordState nextState;
	public AnimatorRecordTransitionInfo transitionInfo;
}