using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigFlycloakFashion
{
	public ConfigFlycloakFashionEffect effects;
	public ConfigFlycloakFashionScale scale;

	public class ConfigFlycloakFashionEffect
	{
		public string Tail;
		public string FlyStart;
		public string FlyEnd;
	}
	public class ConfigFlycloakFashionScale
	{
		public float Male;
		public float Lady;
		public float Boy;
		public float Girl;
		public float Loli;
	}
}