// Namespace: 
public sealed class BrainCloudManager.PostRankedMatchResultsResult : MulticastDelegate // TypeDefIndex: 2655
{
	// Methods

	// RVA: 0x721E30 Offset: 0x720430 VA: 0x180721E30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x721E10 Offset: 0x720410 VA: 0x180721E10 Slot: 13
	public virtual void Invoke(bool success, int newRankedRating, int newRankedLeague, int previousRankedRating, int previousRankedLeague) { }

	// RVA: 0x721D50 Offset: 0x720350 VA: 0x180721D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, int newRankedRating, int newRankedLeague, int previousRankedRating, int previousRankedLeague, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
