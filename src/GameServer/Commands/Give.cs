using System.CommandLine;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        private static void InitGive()
        {
            Option<int> countOption = new(name: "-c", description: "count", getDefaultValue: () => 1);
            Option<int> levelOption = new(name: "-l", description: "level", getDefaultValue: () => 1);
            Option<int> refinementOption = new(name: "-r", description: "refinement", getDefaultValue: () => 1);

            Command giveCommand = new Command("give", "Added item to player");

            giveCommand.SetHandler(OnGive, UserRank.Player,
                guidArgument, idArgument, countOption, levelOption, refinementOption);

            giveCommand.AddArgument(guidArgument);
            giveCommand.AddArgument(idArgument);
            giveCommand.AddOption(countOption);
            giveCommand.AddOption(levelOption);
            giveCommand.AddOption(refinementOption);
            ConsoleHandler.AddCommand(giveCommand);
        }
        internal static async Task OnGive(IConsole console,
            int guid, int itemId, int count, int lvl, int refinement) // GameUid, itemID, count, level, refinement
        {
            if (!GameServer.OnlinePlayers.ContainsKey((uint)guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            if (!GameData.ItemDataMap.ContainsKey((uint)itemId))
            {
                console.WriteLine("invalid item id");
                return;
            }

            if (count<1)
            {
                count = 1;
            }

            if (lvl < 1 || lvl > 90)
            {
                console.WriteLine("invalid level");
                return;
            }
            if ( refinement < 1 || refinement > 5)
            {
                console.WriteLine("invalid refinement");
                return;
            }
            if (GameData.ItemDataMap[(uint)itemId].itemType == ItemType.ITEM_RELIQUARY || GameData.ItemDataMap[(uint)itemId].itemType == ItemType.ITEM_WEAPON)
            {
                for (int i = 0; i < count; i++)
                {
                    await GameServer.OnlinePlayers[(uint)guid].Player.Inventory.AddItemByIdAsync((uint)itemId, 1, ActionReason.None, true, (uint)lvl, (uint)refinement - 1); //convert refinement to code value
                }   
            }
            else
            {
                await GameServer.OnlinePlayers[(uint)guid].Player.Inventory.AddItemByIdAsync((uint)itemId, (uint)count, ActionReason.None, true);
            }
            console.WriteLine($"Added {count} item {itemId} to player {guid} at level {lvl} and refinement {refinement}");
            return;
        }
    }
}
