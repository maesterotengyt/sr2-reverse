// Namespace: 
public sealed class BrainCloudManager.RequestAllPlayerInfoResult : MulticastDelegate // TypeDefIndex: 2654
{
	// Methods

	// RVA: 0x7220A0 Offset: 0x7206A0 VA: 0x1807220A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x721E10 Offset: 0x720410 VA: 0x180721E10 Slot: 13
	public virtual void Invoke(bool success, List<RankData> rankedLeagues, int rankedRating, int rankedIndex, string activePlaygroundGameMode) { }

	// RVA: 0x721FF0 Offset: 0x7205F0 VA: 0x180721FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, List<RankData> rankedLeagues, int rankedRating, int rankedIndex, string activePlaygroundGameMode, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
