// Namespace: 
public sealed class MainMenuHeader.TabOptionSelected : MulticastDelegate // TypeDefIndex: 3037
{
	// Methods

	// RVA: 0x54D680 Offset: 0x54BC80 VA: 0x18054D680
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4FA990 Offset: 0x4F8F90 VA: 0x1804FA990 Slot: 13
	public virtual void Invoke(int optionIndex) { }

	// RVA: 0x54D620 Offset: 0x54BC20 VA: 0x18054D620 Slot: 14
	public virtual IAsyncResult BeginInvoke(int optionIndex, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
