using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFollowMove : ConfigMove
    {
		public FollowTarget target;
		public uint groupTargetInstanceId;
		public ConfigMoveFollowTarget followTargetEx;
		public string attachPoint;
		public bool followRotation;
		public Vector offset;
		public Vector forward;
		public bool followOwnerInvisible;
		public float fixedY;
		public ConfigIgnoreCollision ignoreCollision;
		public ConfigMoveDisableCollision moveDisableCollision;
		public ConfigMoveAudio moveAudio;
		public bool syncTransToServer;
		public float syncInterval;
		public bool handleInLateTick;
		public float followPositionSmoothedDampTime;
		public float followRotationSmoothedDampTime;
		public bool followInFixedUpdate;
		public float fixedFollowPosMaxSpeed;
		public float fixedFollowRotMaxSpeed;

		public class ConfigIgnoreCollision
        {
            public ConfigEntityCollider[] selfColliders;
            public ConfigEntityCollider[] targetCollides;
        }

        public class ConfigEntityCollider
        {
            public EntityColliderType type;
        }

        public class ConfigMoveDisableCollision
        {
            public ConfigEntityCollider[] selfColliders;
            public float delayEnableTime;
        }

        public class ConfigMoveAudio
        {
            public ConfigWwiseString startEvent;
            public ConfigWwiseString stopEvent;
            public ConfigWwiseString moveStateParam;
            public ConfigWwiseString fallOnGroundEvent;
        }
    }
}
