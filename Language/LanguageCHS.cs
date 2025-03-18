using EggLink.DanhengServer.Enums.Language;
using EggLink.DanhengServer.Internationalization;

namespace DanhengPlugin.Lua.Language;

[PluginLanguage(ProgramLanguageTypeEnum.CHS)]
public class LanguageCHS
{
    public static PluginLanguage Instance { get; } = new()
    {
        Translations = new()
        {
            ["Lua.LoadedTest"] = "已加载Lua插件by DragoonT",
            ["Lua.UnloadedTest"] = "Lua插件已卸载！",
            ["Lua.NoRecommend"] = "Excel中不存在推荐遗器",
            ["Lua.BuildSuccess"] = "构建成功！"
        }
    };
}
