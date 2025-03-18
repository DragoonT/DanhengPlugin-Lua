using EggLink.DanhengServer.Command;
using EggLink.DanhengServer.Command.Command;
using EggLink.DanhengServer.Enums.Item;
using EggLink.DanhengServer.Kcp;
using EggLink.DanhengServer.Internationalization;

namespace DanhengPlugin.Lua.Commands;

[CommandInfo("lua", "Kinda lua today! for DanhengServer console", "Usage: /lua <your_name_file.lua> @uid")]
public class CommandLua : ICommand
{
    [CommandDefault]
    public async ValueTask lua(CommandArg arg)
    {
        if (arg.Target == null)
        {
            await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
            return;
        }

        var scriptName = arg.Raw.Split(' ')[0];
        var filePath = Path.Combine(Environment.CurrentDirectory, "Lua", scriptName);

        if (File.Exists(filePath))
        {
            var fileBytes = await File.ReadAllBytesAsync(filePath);
            await arg.Target.SendPacket(new HandshakePacket(fileBytes));
            await arg.SendMsg("Read BYTECODE from Lua script: " + filePath.Replace("\\", "/"));
        }
        else
        {
            await arg.SendMsg("Error reading Lua script: " + scriptName.Replace("\\", "/"));
        }
    }
}