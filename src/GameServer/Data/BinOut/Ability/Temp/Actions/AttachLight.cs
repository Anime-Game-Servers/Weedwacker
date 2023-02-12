
namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class AttachLight : ConfigAbilityAction
{
	public ConfigLightAttach attach;
	public ConfigLightComponent light;

	public class ConfigLightAttach
	{
		public string attachPoint;
		public float localPosX;
		public float localPosY;
		public float localPosZ;
		public float localRotX;
		public float localRotY;
		public float localRotZ;
		public float localRotW;
	}
	public class ConfigLightComponent
	{
		public string lightType;
		public float range;
		public float colorR;
		public float colorG;
		public float colorB;
		public float angle;
		public float intensity;
		public float indirectMult;
	}
}