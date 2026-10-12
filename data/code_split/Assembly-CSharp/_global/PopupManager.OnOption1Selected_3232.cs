// Namespace: 
public sealed class PopupManager.OnOption1Selected : MulticastDelegate // TypeDefIndex: 3232
{
	// Methods

	// RVA: 0x582830 Offset: 0x580E30 VA: 0x180582830
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(string popUpID, int optionIndex) { }

	// RVA: 0x5827C0 Offset: 0x580DC0 VA: 0x1805827C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string popUpID, int optionIndex, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
