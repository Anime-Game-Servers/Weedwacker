using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigEntity
{
	public ConfigEntityCommon common;
	public ConfigHeadControl headControl;
	public ConfigEntityPoint specialPoint;
	public ConfigCustomAttackShape customAttackShape;
	public ConfigModel model;
	public ConfigDither dither;
	public ConfigGlobalValue globalValue;
	public ConfigEntityTags entityTags;

	public class ConfigEntityTags
	{
		public string[] initTags;
	}
	public class ConfigGlobalValue
	{
		public string[] serverGlobalValues;
		public Dictionary<string, float> initServerGlobalValues;
	}
	public class ConfigEntityPoint
	{
		public string elementAbsorb;
		public string elementPendant;
		public string elementDrop;
		public string bulletAim;
		public string[] hitPoints;
		public string[] selectedPoints;
		public bool ignoreTransform;
		public float selectedPointRadius;
	}

	public class ConfigModel
	{
		public ConfigMatLinearChangedByDistance[] matLinearChangedByDistance;
		public string bornEffect;
		public string attachEffect;
		public bool ignoreDistCheckWhenAttachEffect;
		public bool canBakeMesh;
		public bool setPerObjectShadowGroupID;
		public bool hasCharacterRenderering;
	}

	public class ConfigMatLinearChangedByDistance
	{
		public string transformName;
		public string[] textureProperty;
		public string[] floatProperty;
		public float minRatio;
		public float maxRatio;
		public float minDistance;
		public float maxDistance;
	}
}
