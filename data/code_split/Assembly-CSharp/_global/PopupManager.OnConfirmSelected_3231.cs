// Namespace: 
public sealed class PopupManager.OnConfirmSelected : MulticastDelegate // TypeDefIndex: 3231
{
	// Methods

	// RVA: 0x4FA9A0 Offset: 0x4F8FA0 VA: 0x1804FA9A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4FA990 Offset: 0x4F8F90 VA: 0x1804FA990 Slot: 13
	public virtual void Invoke(string popUpID) { }

	// RVA: 0x4FA950 Offset: 0x4F8F50 VA: 0x1804FA950 Slot: 14
	public virtual IAsyncResult BeginInvoke(string popUpID, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
