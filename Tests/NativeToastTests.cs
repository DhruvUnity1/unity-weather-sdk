using NUnit.Framework;
using CleverTap.NativeToast;

public class NativeToastTests
{
    [Test]
    public void Toast_DoesNotThrow()
    {
        Assert.DoesNotThrow(() => NativeToast.Show("Test"));
    }
}
