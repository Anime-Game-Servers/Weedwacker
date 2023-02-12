using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class FireworksLauncherMixin : ConfigAbilityMixin
{
	public string startCountDownModifier;
	public ConfigAbilityAction[] OnEvtStartCountDown;
	public ConfigAbilityAction[] OnAllBulletsFired;
	public string GV_FW_BulletItemID;
	public string GV_FW_ColorH;
	public string GV_FW_Scale;
	public string GV_FW_Angle;
	public string GV_FW_MaxParticleCount;
	public string GV_FW_FaceToCamera;
	public string GV_FW_BulletLifeTime;
}
