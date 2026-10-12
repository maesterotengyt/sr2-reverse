// Namespace: 
public sealed class OnlineManager.OnMessageSent : MulticastDelegate // TypeDefIndex: 2699
{
	// Methods

	// RVA: 0x718BB0 Offset: 0x7171B0 VA: 0x180718BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x718B80 Offset: 0x717180 VA: 0x180718B80 Slot: 13
	public virtual void Invoke(PlayerChatMessage playerMessage) { }

	// RVA: 0x718C40 Offset: 0x717240 VA: 0x180718C40 Slot: 14
	public virtual IAsyncResult BeginInvoke(PlayerChatMessage playerMessage, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
