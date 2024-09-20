namespace codeabbittest.Componenets
{
    using codeabbittest.Enums;
    using System.Collections.Generic;

    public interface IFeatureManager
    {
        bool IsFeatureEnabled(List<string> ids, FeatureFlag flag);
        bool IsFeatureEnabledForAll(FeatureFlag flag);
    }
}
