using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ReminderExcelConfig
{
	public uint id;
	public uint speakerTextMapHash;
	public uint contentTextMapHash;
	public float delay;
	public float showTime;
	public uint nextReminderId;
	public string soundEffect;
	public ReminderStyleType style;
	public bool hasAudio;
}