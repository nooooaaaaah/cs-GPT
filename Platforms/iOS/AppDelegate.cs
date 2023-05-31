using Android.Runtime;
using Foundation;

namespace Clippy
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MauiUIApplicationDelegate
    {
        protected MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
