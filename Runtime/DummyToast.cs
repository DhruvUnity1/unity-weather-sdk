using UnityEngine;

namespace CleverTap.NativeToast
{
    public class DummyToast : IToastPlatform
    {
        public void Show(string message)
        {
            Debug.Log($"Toast: {message}");
        }
    }
}
