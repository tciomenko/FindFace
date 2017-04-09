using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace FindFace.Core.Bootstrap
{
    public class UserInteractionPluginBootstrap
        : MvxLoaderPluginBootstrapAction<Chance.MvvmCross.Plugins.UserInteraction.PluginLoader, Chance.MvvmCross.Plugins.UserInteraction.Touch.Plugin>
    {
    }
}