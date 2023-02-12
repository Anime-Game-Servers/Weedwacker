using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

namespace Weedwacker.GameServer.Data;

public class ConfigMonster : ConfigCharacter
{
	public Dictionary<string, ConfigMonsterInitialPose> initialPoses;
	public ConfigAIBeta aibeta;
	public ConfigKeyInput[] inputKeys;
	public ConfigMove move;
	public ConfigMonsterAudio audio;
	public ConfigEmojiBubble emojiBubble;
	public ConfigCharacterRendering characterRendering;
	public ConfigAnimal animal;
	public ConfigTrigger field;
	public ConfigCaptureGroup captureGroup;
	public Dictionary<string, ConfigSpecialCamera> cameraAdjustMap;

	public class ConfigKeyInput
	{
		public int keyID;
		public int inputKeyCode;
		public string abilityName;
		public float abilityCD;
	}
	public class ConfigAnimal
	{
		public bool hasAbility;
		public bool tickAbilityElement;
		public bool simpleCombat;
		public bool hasCharacterRenderering;
	}
	public class ConfigCaptureGroup
	{
		public ConfigCapture defaultConfig;

		public class ConfigCapture
		{
			public string captureEffect;
		}
	}
	public class ConfigCharacterRendering
	{
		public bool overrideLightDir;
		public Vector overrideLightEulerAngle;
	}
	public class ConfigMonsterInitialPose
	{
		public int initialPoseID;
		public bool released;
		public ConfigPoseInitialParam initialPoseParams;

		public class ConfigPoseInitialParam
		{
			public Dictionary<string, string> intParams;
			public Dictionary<string, string> floatParams;
			public Dictionary<string, string> boolParams;
		}
	}
	public class ConfigMonsterAudio : ConfigCharacterAudio
	{
		public ConfigWwiseString randomVariantSwitchGroup;
		public ConfigWwiseString[] randomVariantSwitchValues;
	}
}