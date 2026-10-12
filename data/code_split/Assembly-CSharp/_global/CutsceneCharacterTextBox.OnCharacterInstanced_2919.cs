// Namespace: 
public sealed class CutsceneCharacterTextBox.OnCharacterInstanced : MulticastDelegate // TypeDefIndex: 2919
{
	// Methods

	// RVA: 0x6FF530 Offset: 0x6FDB30 VA: 0x1806FF530
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6FF510 Offset: 0x6FDB10 VA: 0x1806FF510 Slot: 13
	public virtual void Invoke(string operationID, GameObject gameObject, Animator characterAnimator) { }

	// RVA: 0x6FF4D0 Offset: 0x6FDAD0 VA: 0x1806FF4D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string operationID, GameObject gameObject, Animator characterAnimator, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
