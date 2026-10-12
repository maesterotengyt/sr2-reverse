// Namespace: 
public sealed class BrainCloudManager.TournamentStatusRequestResult : MulticastDelegate // TypeDefIndex: 2642
{
	// Methods

	// RVA: 0x722780 Offset: 0x720D80 VA: 0x180722780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x722750 Offset: 0x720D50 VA: 0x180722750 Slot: 13
	public virtual void Invoke(bool success, TournamentState state = 0, List<TournamentPlayer> tournamentPlayers, List<RoomData> roomDatas, int playerIndex = -1, int phase = -1, bool readyStart = False, bool finalRound = False) { }

	// RVA: 0x722620 Offset: 0x720C20 VA: 0x180722620 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, TournamentState state, List<TournamentPlayer> tournamentPlayers, List<RoomData> roomDatas, int playerIndex, int phase, bool readyStart, bool finalRound, AsyncCallback callback, object object) { }

	// RVA: 0x4FA980 Offset: 0x4F8F80 VA: 0x1804FA980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
