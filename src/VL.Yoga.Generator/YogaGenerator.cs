// https://github.com/JoanComasFdz/dotnet-how-to-debug-source-generator-vs2022
// https://roslynquoter.azurewebsites.net/

using Microsoft.CodeAnalysis;

namespace VL.Yoga.Generator
{
    [Generator()]
    public partial class YogaGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // quick hack to make debugger work here
            // if (!Debugger.IsAttached) Debugger.Launch();
            context.RegisterPostInitializationOutput(PostInitializationCallback);
        }

        private static void PostInitializationCallback(IncrementalGeneratorPostInitializationContext context)
        {
            // Generates YogaStyle from config
            context.AddSource("FlexStyle.g.cs", Sources.StyleSource.YogaStyleSource());

            // Generates YogaConfig from config
            context.AddSource("FlexConfig.g.cs", Sources.ConfigSource.YogaConfigSource());
        }
    }
}
