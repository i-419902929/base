using Volo.Abp.Settings;

namespace LQ.Basic.Settings;

public class BasicSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BasicSettings.MySetting1));
    }
}
