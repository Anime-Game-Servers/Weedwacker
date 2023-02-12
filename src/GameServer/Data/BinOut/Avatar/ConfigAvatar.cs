using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Avatar;

public class ConfigAvatar : ConfigCharacter
{
	public ConfigAvatarShoot shootConfig;
	public ConfigAvatarAudio audio;
	public ConfigAvatarControllerAssembly controllerAssembly;
	public ConfigMoveStateEffect moveStateEffect;
	public ConfigAvatarPerform perform;

	public class ConfigAvatarShoot
	{
		public ConfigShoot normalShoot;
		public ConfigShoot aimingShoot;

		public class ConfigShoot
		{
			public string bulletBornAttachPoint;
			public float detectRangeFromViewport;
			public float detectRadiusFromViewport;
			public float autoFocusMinRange;
			public float autoFocusMaxRange;
		}
	}
	public class ConfigAvatarAudio : ConfigCharacterAudio
	{
		public ConfigMoveStateAudio moveStateAudio;
		public ConfigCombatSpeech combatSpeech;
		public ConfigWwiseString voiceSwitch;
		public ConfigWwiseString bodyTypeSwitch;
		public float listenerLiftup;
		public float surfaceProberLiftup;

		public class ConfigMoveStateAudio
		{
			public ConfigStateAudioEvent[] onStateBegin;
			public ConfigStateAudioEvent[] onStateEnd;
		}
		public class ConfigCombatSpeech
		{
			public ConfigWwiseString headShotSpeechEvent;
		}
	}
	public class ConfigAvatarControllerAssembly
	{
		public string controllerPath;
		public string normalMoveSubs;
		public string weaponMoveSubs;
		public ConfigAvatarControllerAssemblySkillSubs skillSubs;

		public class ConfigAvatarControllerAssemblySkillSubs
		{
			public string Skill01_SUBS;
			public string Skill02_SUBS;
			public string Skill03_SUBS;
			public string Skill04_SUBS;
		}
	}
	public class ConfigAvatarPerform
	{
		public ConfigStandbyPerform standby;

		public class ConfigStandbyPerform
		{
			public float minTime;
			public float maxTime;
			public int[] performIDs;
		}
	}
	public class ConfigMoveStateEffect
	{
		public ConfigFootprint footprint;
		public class ConfigFootprint
		{
			public string defaultEffectPatternName;
			public Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> specialSurfaces;

			public class ConfigFootprintEffect
			{
				public string effect;
				public string deformation;
			}
		}
	}
}
