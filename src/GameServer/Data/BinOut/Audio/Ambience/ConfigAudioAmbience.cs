using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioAmbience
{
	public uint[] effectiveSceneIds;
	public Vector[] relativePositions;
	public AudioAmbiencePositionedEvent[] positionedEvents;
	public ConfigAudioTreeInfo treeInfo;
	public ConfigAudioDynamicRayInfo dynamicRayInfo;
	public ConfigAudioArea2DInfo area2DInfo;
	public ConfigWwiseString heightRTPCKey;
	public bool usingAdaptiveOpennessDetection;
	public ConfigAudioAdaptiveDynamicRayInfo adaptiveDynamicRayInfo;

	public class AudioAmbiencePositionedEvent
	{
		public ConfigWwiseString eventName;
		public float minInitDelay;
		public float maxInitDelay;
		public float minInterval;
		public float maxInterval;
	}
	public class ConfigAudioTreeInfo
	{
		public float detectRadius;
		public string dataAssetFolder;
		public ConfigWwiseString treeSoundEventName;
		public ConfigWwiseString treeNumRtpcName;
		public MultiPositionType multiPositionType;
		public AudioTreeDataAssetNamePattern[] dataAssetNamePatterns;
	}
	public class ConfigAudioDynamicRayInfo
	{
		public int rayPerFrame;
		public float movingLerpRatio;
		public float standLerpRatio;
		public float rayMaxDistance;
		public bool isDebug;
		public ConfigWwiseString rtpcParam;
		public ConfigWwiseString grassCountRTPC;
		public float coneAngle;
		public ConfigWwiseString leftSpaceOpennessRtpcKey;
		public ConfigWwiseString rightSpaceOpennessRtpcKey;
	}
	public class ConfigAudioArea2DInfo
	{
		public float leaveReverbDelay;
		public AudioStateOp[] enterReverbStates;
		public AudioStateOp[] leaveReverbStates;
	}
	public class ConfigAudioAdaptiveDynamicRayInfo
	{
		public int rayCastPerFrame;
		public float maxRayLen;
		public bool debug;
		public uint defaultSamplingLevel;
		public OpennessFuncType opennessFuncType;
		public Dictionary<string, ConfigWwiseString> labelMap;
		public Dictionary<uint, AdaptiveParam> adaptiveParamMap;
		public SamplingData samplingData;

		public class AdaptiveParam
		{
			public float min;
			public float max;
			public uint convincement;
		}
		public class SamplingData
		{
			public DirectionMask[] maskTable;
			public LayeredSamplingData[] data;

			public class DirectionMask
			{
				public string name;
				public uint mask;
			}
			public class LayeredSamplingData
			{
				public uint level;
				public float[] vertices;
				public uint[] masks;
			}
		}
	}
}