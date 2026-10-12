// Namespace: 
public sealed class StellarEvents.OnCharacterCreated : MulticastDelegate // TypeDefIndex: 3286
{
	// Methods

	// RVA: 0x5A0B50 Offset: 0x59F150 VA: 0x1805A0B50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5A0AC0 Offset: 0x59F0C0 VA: 0x1805A0AC0 Slot: 13
	public virtual void Invoke(StellarCharacterData characterData) { }

	// RVA: 0x5A0BE0 Offset: 0x59F1E0 VA: 0x1805A0BE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(StellarCharacterData characterData, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
