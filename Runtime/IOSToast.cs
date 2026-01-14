#if UNITY_IOS
using System.Runtime.InteropServices;

namespace CleverTap.NativeToast
{
    public class IOSToast : IToastPlatform
    {
        [DllImport("__Internal")]
        private static extern void ShowToast(string message);

        public void Show(string message)
        {
            ShowToast(message);
        }
    }
}
#endif
