namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

internal class CheckGrapplingHookMixin : ConfigAbilityMixin
{
	public string activateSkillKey;
	public CheckParams checkParams;
	public ConfigAbilityAction[] onEnterHookArea;
	public ConfigAbilityAction[] onExitHookArea;

	//custom
	public class CheckParams
	{
		public float hookAreaRadius;
		public float minDistToAvatar;
		public float screenEllipseRatioX;
		public float screenEllipseRatioY;
		public UI ui;
		public class UI
		{
			public string SelectableIcon;
			public string SelectedIcon;
			public string UnselectableIcon;
		}
	}
}
