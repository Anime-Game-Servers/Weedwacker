using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class BargainExcelConfig
{
	public uint quest_id;
	public uint id;
	public uint[] dialog_id;
	public uint[] expected_value;
	public uint space;
	public uint[] success_talk_id;
	public uint fail_talk_id;
	public uint mood_npc_id;
	public uint mood_upper_limit;
	public uint[] random_mood;
	public uint mood_alert_limit;
	public int mood_low_limit;
	public uint mood_low_limit_textTextMapHash;
	public uint single_fail_mood_deduction;
	public uint[] single_fail_talk_id;
	public bool delete_item;
	public uint item_id;
	public uint title_textTextMapHash;
	public uint afford_textTextMapHash;
	public uint storage_textTextMapHash;
	public uint mood_hint_textTextMapHash;
	public uint mood_desc_textTextMapHash;
}