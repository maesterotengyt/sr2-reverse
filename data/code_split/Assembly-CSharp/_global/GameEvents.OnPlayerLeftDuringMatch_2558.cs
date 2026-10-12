// Namespace: 
public sealed class GameEvents.OnPlayerLeftDuringMatch : MulticastDelegate // TypeDefIndex: 2558
{
	// Methods

	// RVA: 0x4FB4B0 Offset: 0x4F9AB0 VA: 0x1804FB4B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4FA990 Offset: 0x4F8F90 VA: 0x1804FA990 Slot: 13
	public virtual void Invoke(List<StellarCharacterData> characters) { }

	// RVA: 0x4FA950 Offset: 0x4F8F50 VA: 0x1804FA950 Slot: 14
	public virtual IAsyncResult BeginInvoke(List<StellarCharacterData> characters, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
