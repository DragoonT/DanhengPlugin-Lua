using System.Collections.Generic;

namespace DanhengPlugin.Lua.Language;

public partial class PluginLanguage
{
    public Dictionary<string, string> Translations { get; set; } = new();

    public string Translate(string key)
    {
        return Translations.TryGetValue(key, out var value) ? value : key;
    }
}

