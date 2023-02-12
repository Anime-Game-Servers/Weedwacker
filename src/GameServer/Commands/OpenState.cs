using System.CommandLine;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        static void InitOpenState()
        {
            var OpenStateArgument = new Argument<int>(name: "OpenState");

            Command OpenStateCommand = new("openstate", "Set openstate for player");
            OpenStateCommand.AddArgument(guidArgument);

            OpenStateCommand.AddArgument(OpenStateArgument);

            OpenStateCommand.SetHandler(OnOpenState, UserRank.Player, OpenStateArgument, guidArgument);

            ConsoleHandler.AddCommand(OpenStateCommand);
        }

        internal static async Task OnOpenState(IConsole console, int openState, int guid) // OpenState, GameUid
        {
            if (!Enum.IsDefined(typeof(OpenStateType), openState))
            {
                console.WriteLine("invalid openstate id");
                return;
            }
            if (!GameServer.OnlinePlayers.ContainsKey((uint)guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            await GameServer.OnlinePlayers[(uint)guid].Player.OpenStateManager.SetOpenStateAsync((uint)openState, 1);
            console.WriteLine($"Set openstate {openState} for player {guid}");
        }
    }
}
