using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAvatarStateIDInfo : ConfigNormalStateIDInfo
{
	public StateCameraType cameraType;
	public ConfigStateCameraParam cameraParam;
	public ConfigCanChangeAvatar[] canChangeAvatar;
	public bool canSupportChange;
	public ActionPanelState actionPanelState;
	public ConfigEquipReattach[] equipReattach;
	public float jumpCancelStart;
	public float jumpCancelEnd;
	public float sprintCancelStart;
	public float sprintCancelEnd;
	public float flyCancelStart;
	public float flyCancelEnd;
	public string animatorTriggerOnLanded;
	public bool battouOnStart;
	public bool sheatheOnStart;
	public bool sheatheOnEnd;
	public bool ignorePreSheath;
	public ConfigStateSubEquip subEquipConfig;

	public class ConfigCanChangeAvatar
	{
		public float normalizeStart;
		public float normalizeEnd;
	}
	public class ConfigStateSubEquip
	{
		public bool battouAllSubOnStart;
		public bool sheatheAllSubOnStart;
		public bool sheatheAllSubOnEnd;
		public string[] battouSubOnStart;
		public string[] sheatheSubOnStart;
		public string[] sheatheSubOnEnd;
		public ConfigEquipReattach[] subEquipReattach;
	}
	public class ConfigEquipReattach
	{
		public string equip;
		public string targetPoint;
		public float normalizeStart;
		public float normalizeEnd;
	}
}