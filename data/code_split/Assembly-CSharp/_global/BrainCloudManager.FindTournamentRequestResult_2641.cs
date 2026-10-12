// Namespace: 
public sealed class BrainCloudManager.FindTournamentRequestResult : MulticastDelegate // TypeDefIndex: 2641
{
	// Methods

	// RVA: 0x7163C0 Offset: 0x7149C0 VA: 0x1807163C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7163A0 Offset: 0x7149A0 VA: 0x1807163A0 Slot: 13
	public virtual void Invoke(bool success, string tournamentId, int startingIn = 0, string region = "") { }

	// RVA: 0x716300 Offset: 0x714900 VA: 0x180716300 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, string tournamentId, int startingIn, string region, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
