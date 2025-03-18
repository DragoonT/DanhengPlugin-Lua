using EggLink.DanhengServer.Enums.Language;
using EggLink.DanhengServer.Internationalization;

namespace DanhengPlugin.Lua.Language;

[PluginLanguage(ProgramLanguageTypeEnum.EN)]
public class LanguageEN
{
    public static PluginLanguage Instance { get; } = new()
    {
        Translations = new()
        {
            ["Lua.LoadedTest"] = "Loaded Lua plugin by DragoonT",
            ["Lua.UnloadedTest"] = "Lua plugin has been uninstalled!",
            ["Lua.NoRecommend"] = "No recommended plugin exists in Excel",
            ["Lua.BuildSuccess"] = "Build successful!"
        }
    };
}
