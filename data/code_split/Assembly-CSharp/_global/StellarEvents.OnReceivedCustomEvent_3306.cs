// Namespace: 
public sealed class StellarEvents.OnReceivedCustomEvent : MulticastDelegate // TypeDefIndex: 3306
{
	// Methods

	// RVA: 0x5A0D30 Offset: 0x59F330 VA: 0x1805A0D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(byte eventCode, object customMessage) { }

	// RVA: 0x5BB750 Offset: 0x5B9D50 VA: 0x1805BB750 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte eventCode, object customMessage, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
