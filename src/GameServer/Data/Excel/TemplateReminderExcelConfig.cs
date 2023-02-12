using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class TemplateReminderExcelConfig
{
	public uint id;
	public TemplateReminderStyleType style;
	public string icon;
	public uint titleTextMapHash;
	public uint contentTextMapHash;
	public NewActivityType activityType;
	public float showTime;
	public string param;
}