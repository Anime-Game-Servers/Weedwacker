using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("PhotographPosenameExcelConfigData.json")]
public class PhotographPosenameData : FetterConfig
{
	public string poseFile;
	public uint animatorstate_id;
	public string poseIcon;
	public uint poseNameTextMapHash;
	public uint unlockDescTextMapHash;
}
