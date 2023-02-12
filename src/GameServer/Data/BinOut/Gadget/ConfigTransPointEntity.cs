using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Gadget;

public class ConfigTransPointEntity : ConfigGadget
{
	public TransPointUpdateMaterial[] updateMaterialList;

	public class TransPointUpdateMaterial
	{
		public uint level;
		public string matPath;
		public string[] transforms;
	}
}
