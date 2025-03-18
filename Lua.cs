using DanhengPlugin.Lua.Commands;
using EggLink.DanhengServer.Command.Command;
using EggLink.DanhengServer.GameServer.Plugin.Constructor;
using EggLink.DanhengServer.Internationalization;
using EggLink.DanhengServer.Util;
using EggLink.DanhengServer.Enums.Language;

namespace DanhengPlugin.Lua;

[PluginInfo("Lua", "Modify lua file", "1.0")]
public class Lua : IPlugin
{
    private readonly Logger _logger = new("Lua");

    public void OnLoad()
    {
        I18NManager.SetLanguage(ProgramLanguageTypeEnum.EN); // Set to English

        CommandManager.Instance?.RegisterCommand(typeof(CommandLua));
        _logger.Info(I18NManager.Translate("Lua.LoadedTest"));
    }

    public void OnUnload()
    {
        _logger.Info(I18NManager.Translate("Lua.UnloadedTest"));
    }
}