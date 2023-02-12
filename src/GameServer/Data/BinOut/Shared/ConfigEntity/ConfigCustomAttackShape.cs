using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigCustomAttackShape
{
	public ConfigCustomAttackSphere sphere;
	public ConfigCustomAttackBox box;
	public ConfigCustomAttackCircle circle;

	public class ConfigCustomAttackSphere
	{
		public float customAttackSphere_Radius;
	}

	public class ConfigCustomAttackBox
	{
		public float customAttackBox_Size_X;
		public float customAttackBox_Size_Y;
		public float customAttackBox_Size_Z;
	}

	public class ConfigCustomAttackCircle
	{
		public float customAttackCircle_Radius;
		public float customAttackCircle_InnerRadius;
	}
}
