// Namespace: 
public sealed class OnlineManager.OnEmoteSent : MulticastDelegate // TypeDefIndex: 2698
{
	// Methods

	// RVA: 0x718BB0 Offset: 0x7171B0 VA: 0x180718BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x718B80 Offset: 0x717180 VA: 0x180718B80 Slot: 13
	public virtual void Invoke(PlayerEmoteMessage emoteMessage) { }

	// RVA: 0x718B10 Offset: 0x717110 VA: 0x180718B10 Slot: 14
	public virtual IAsyncResult BeginInvoke(PlayerEmoteMessage emoteMessage, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
