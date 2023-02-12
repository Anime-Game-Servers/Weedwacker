using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class LoseHP : ConfigAbilityAction
{
	public object amount;
	public object amountByCasterMaxHPRatio;
	public object amountByTargetMaxHPRatio;
	public object amountByTargetCurrentHPRatio;
	public object amountByCasterAttackRatio;
	public object limboByTargetMaxHPRatio;
	public bool lethal;
	public bool enableInvincible;
	public bool enableLockHP;
	public bool disableWhenLoading;
	public bool useMeta;

	public override async Task Invoke(string abilityName, BaseEntity avatarr, SceneEntity? enemyTarget = null)
	{
		if (!(avatarr is AvatarEntity avatar)) return;
		if (!doOffStage && avatar.Avatar.Owner.TeamManager.CurrentAvatarEntity != avatar) return;

		float curHP;
		float maxHP;
		float newHP;
		switch (target)
		{
			case AbilityTargetting.Self:
				curHP = avatar.FightProps[FightPropType.FIGHT_PROP_CUR_HP];
				maxHP = avatar.FightProps[FightPropType.FIGHT_PROP_MAX_HP];
				newHP = curHP - DynamicFloatHelper.ResolveDynamicFloat(amountByTargetCurrentHPRatio, avatar, abilityName) * curHP;
				if (limboByTargetMaxHPRatio != null)
				{
					newHP = Math.Max(newHP, (float)limboByTargetMaxHPRatio);
				}
				else if (newHP < 1f)
				{
					if (lethal)
					{
						await avatar.DamageAsync(curHP);
						return;
					}
					else
						newHP = 1;
				}
				await avatar.SetHealthAsync(newHP);
				return;
		}
	}
}
