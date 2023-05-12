using Volo.Abp.Settings;

namespace LQ.Map.Settings;

public class MapSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MapSettings.MySetting1));
    }
}
