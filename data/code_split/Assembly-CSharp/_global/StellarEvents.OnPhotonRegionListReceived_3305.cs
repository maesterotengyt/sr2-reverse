// Namespace: 
public sealed class StellarEvents.OnPhotonRegionListReceived : MulticastDelegate // TypeDefIndex: 3305
{
	// Methods

	// RVA: 0x5BB660 Offset: 0x5B9C60 VA: 0x1805BB660
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4FA990 Offset: 0x4F8F90 VA: 0x1804FA990 Slot: 13
	public virtual void Invoke(RegionHandler regionHandler) { }

	// RVA: 0x4FA950 Offset: 0x4F8F50 VA: 0x1804FA950 Slot: 14
	public virtual IAsyncResult BeginInvoke(RegionHandler regionHandler, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
