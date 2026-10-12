// Namespace: Photon.Realtime
public class SystemConnectionSummary // TypeDefIndex: 3997
{
	// Fields
	public readonly byte Version; // 0x10
	public byte UsedProtocol; // 0x11
	public bool AppQuits; // 0x12
	public bool AppPause; // 0x13
	public bool AppPauseRecent; // 0x14
	public bool AppOutOfFocus; // 0x15
	public bool AppOutOfFocusRecent; // 0x16
	public bool NetworkReachable; // 0x17
	public bool ErrorCodeFits; // 0x18
	public bool ErrorCodeWinSock; // 0x19
	public int SocketErrorCode; // 0x1C
	private static readonly string[] ProtocolIdToName; // 0x0

	// Methods

	// RVA: 0x696B10 Offset: 0x695110 VA: 0x180696B10
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x696C10 Offset: 0x695210 VA: 0x180696C10
	public void .ctor(int summary) { }

	// RVA: 0x6965D0 Offset: 0x694BD0 VA: 0x1806965D0
	public int ToInt() { }

	// RVA: 0x6966C0 Offset: 0x694CC0 VA: 0x1806966C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x696570 Offset: 0x694B70 VA: 0x180696570
	public static bool GetBit(ref int value, int bitpos) { }

	// RVA: 0x696580 Offset: 0x694B80 VA: 0x180696580
	public static byte GetBits(ref int value, int bitpos, byte mask) { }

	// RVA: 0x696590 Offset: 0x694B90 VA: 0x180696590
	public static void SetBit(ref int value, bool bitval, int bitpos) { }

	// RVA: 0x6965B0 Offset: 0x694BB0 VA: 0x1806965B0
	public static void SetBits(ref int value, byte bitvals, int bitpos) { }

	// RVA: 0x696940 Offset: 0x694F40 VA: 0x180696940
	private static void .cctor() { }
}
