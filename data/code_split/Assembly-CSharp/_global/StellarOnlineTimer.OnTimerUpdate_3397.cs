// Namespace: 
public sealed class StellarOnlineTimer.OnTimerUpdate : MulticastDelegate // TypeDefIndex: 3397
{
	// Methods

	// RVA: 0x5CEC30 Offset: 0x5CD230 VA: 0x1805CEC30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(bool active, float currentTime) { }

	// RVA: 0x5CEBB0 Offset: 0x5CD1B0 VA: 0x1805CEBB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool active, float currentTime, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
