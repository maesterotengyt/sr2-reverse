// Namespace: 
public sealed class BrainCloudManager.GetCurrencyResult : MulticastDelegate // TypeDefIndex: 2650
{
	// Methods

	// RVA: 0x7164D0 Offset: 0x714AD0 VA: 0x1807164D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(bool success, int currencyAmount) { }

	// RVA: 0x716450 Offset: 0x714A50 VA: 0x180716450 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, int currencyAmount, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
