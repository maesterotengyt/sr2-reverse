// Namespace: 
public sealed class CharacterSelector.OnSelectorActivated : MulticastDelegate // TypeDefIndex: 3011
{
	// Methods

	// RVA: 0x79F240 Offset: 0x79D840 VA: 0x18079F240
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(CharacterSelector updatedSelector, ReserveSelectorContext context) { }

	// RVA: 0x79F1B0 Offset: 0x79D7B0 VA: 0x18079F1B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(CharacterSelector updatedSelector, ReserveSelectorContext context, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
