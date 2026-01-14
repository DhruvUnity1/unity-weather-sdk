namespace CleverTap.NativeToast
{
    public static class NativeToast
    {
        private static IToastPlatform platform;

        static NativeToast()
        {
#if UNITY_ANDROID
            platform = new AndroidToast();
#elif UNITY_IOS
            platform = new IOSToast();
#else
            platform = new DummyToast();
#endif
        }

        public static void Show(string message)
        {
            platform.Show(message);
        }
    }
}
