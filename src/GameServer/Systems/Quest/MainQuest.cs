using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Quest;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Quest
{
    internal class MainQuest
    {
        [BsonId] uint Id;
        [BsonIgnore] private ConfigMainQuestScheme MainData => GameData.MainQuestDataMap[Id];
        [BsonIgnore] private Dictionary<uint, QuestData> SubData;
    }
}
