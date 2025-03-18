using EggLink.DanhengServer.Enums.Language;
using System.Collections.Generic;
using DanhengPlugin.Lua.Language;

public static class I18NManager
{
    private static PluginLanguage _currentLanguage = LanguageEN.Instance; // Default to English

    public static void SetLanguage(ProgramLanguageTypeEnum language)
    {
        _currentLanguage = language switch
        {
            ProgramLanguageTypeEnum.CHS => LanguageCHS.Instance,
            ProgramLanguageTypeEnum.EN => LanguageEN.Instance,
            _ => LanguageEN.Instance
        };
    }

    public static string Translate(string key)
    {
        return _currentLanguage.Translate(key);
    }
}
