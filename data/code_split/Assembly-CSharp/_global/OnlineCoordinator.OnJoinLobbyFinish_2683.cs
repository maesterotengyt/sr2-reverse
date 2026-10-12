// Namespace: 
public sealed class OnlineCoordinator.OnJoinLobbyFinish : MulticastDelegate // TypeDefIndex: 2683
{
	// Methods

	// RVA: 0x5A0D30 Offset: 0x59F330 VA: 0x1805A0D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x582820 Offset: 0x580E20 VA: 0x180582820 Slot: 13
	public virtual void Invoke(bool success, string errorCode) { }

	// RVA: 0x5A0CC0 Offset: 0x59F2C0 VA: 0x1805A0CC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, string errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
