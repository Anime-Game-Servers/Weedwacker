using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ActivityPhotographPosExcelConfig
{
	public uint id;
	public uint groupLinkId;
	public uint posTitleTextMapHash;
	public uint requireTitleInActivityPageTextMapHash;
	public uint requireDescInActivityPageTextMapHash;
	public uint npcInviteDescTextMapHash;
	public uint npcCommentDescTextMapHash;
	public string picSmall;
	public string picBig;
	public uint photoCheckRootID;
	public uint rootNodeDescTextMapHash;
	public uint[] photoCheckSubNodeID;
	public uint[] photoCheckSubNodeDesc;
	public uint openDay;
	public uint watcherId;
	public uint galleryId;
	public uint redPointID;
}