# Weedwacker
Private Server reimplementation of a certain anime game.
Join us on our [discord](https://discord.gg/XJgJcf6nPf)!

### Features:
- Ability Framework (Hu Tao's health reduction works correctly, and as intended!)
- Native Lua 5.3 integration
- Independent and highly customizable WebServer powered by microsoft's kestrel with the necessary json data structures properly represented in the code
- Authentication framework
- Organized Avatar framework faithfully reflecting the data and the game design
- A very organized inventory system with type safety
- Use of the Official c# driver for mongodb, the ability to update, save, delete documents as needed
- Resource loading with support for polymorphic types
- Extensive debug logging and the option to save to disk (only in the DEBUG build)
- Microsoft's System.CommandLine library to handle both shell and ingame commands (via the chat)

### Contributing:
View our [contributing guidelines](https://github.com/WeedwackerPS/Weedwacker/blob/main/README.md).

### Requirements:
* .NET 7
* [MongoDB](https://www.mongodb.com/try/download/community)

* Proxy Daemon: [Fiddler Classic](https://telerik-fiddler.s3.amazonaws.com/fiddler/FiddlerSetup.exe) (recommended), [mitmproxy](https://mitmproxy.org/) (mitmdump),  etc.

* [mhypbase patch](https://github.com/Jx2f/mhypbase) _(Optional)_: if you want to enable **Server.Account.UsePassword**, you need to patch yor cilent according to mhypbase project.
### Building:
any .NET 7 compatible compiler

### Running:
Weedwacker has 2 different executables. one for the HTTP web server, one for the UDP game server
- 1) Download resource files, rename folders appropriately, and put in the resources folder. Currently we will not provide any links to compatible server resource files. For more information visit our discord.
- 2) Run both the WebServer and the GameServer executables (also generates the configuration jsons if not present).
- 2b) If you plan to host multiple game server instances, or run over a network, make the appropriate changes/additions to the  config jsons (each server should have its own MongoDB Database).

### Connecting:
½. Make sure you've set up/modified your client correctly to connect to private servers.
1. Create an account on the web server (NOT the game server) using the `account create <username>` command from the console, or set AutoCreate to true in WebConfig.json.
2. Use your preferred method to proxy web traffic from official servers to the webserver.
3. Launch the game and play!

### FiddlerScript:
Go to Tools->Options->HTTPS enable Decrypt HTTPS traffic.
use the following script with fiddler to proxy the traffic to your webserver:
```
import System;
import System.Windows.Forms;
import Fiddler;
import System.Text.RegularExpressions;

class Handlers
{
	static function OnBeforeRequest(oS: Session) {
		if(oS.host.EndsWith(".yuanshen.com") || oS.host.EndsWith(".hoyoverse.com") || oS.host.EndsWith(".mihoyo.com")) {
			oS.host = "localhost"; // This can also be replaced with another IP address.
            oS.port = 443; // Change to the port of the WebServer
		}
		
		if (oS.host.Equals("overseauspider.yuanshen.com:8888")) {
            oS.oRequest.FailSession(404, "Blocked", "Not Found");
        }
        
	}
};
```
