using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ExpeditionDataExcelConfig
{
	public uint ID;
	public uint nameTextMapHash;
	public uint city_id;
	public ExpeditionOpenCondition[] open_condition_vec;
	public ExpeditionReward[] time_reward_vec;
	public uint descriptionTextMapHash;
	public string picture;
	public float posX;
	public float posY;

	public class ExpeditionOpenCondition
	{
		public ExpeditionOpenCondType type;
		public uint para;
		public uint para2;
	}
	public class ExpeditionReward
	{
		public uint htime;
		public uint reward_drop_id;
		public uint rewardPreview;
	}
}