// Namespace: 
public sealed class StellarPlatformEvents.OnSaveDataExist : MulticastDelegate // TypeDefIndex: 3472
{
	// Methods

	// RVA: 0x5E99B0 Offset: 0x5E7FB0 VA: 0x1805E99B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(string fileName, bool exist) { }

	// RVA: 0x5E9950 Offset: 0x5E7F50 VA: 0x1805E9950 Slot: 14
	public virtual IAsyncResult BeginInvoke(string fileName, bool exist, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
