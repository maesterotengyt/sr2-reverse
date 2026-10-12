// Namespace: Photon.Realtime
public abstract class PhotonPing : IDisposable // TypeDefIndex: 3981
{
	// Fields
	public string DebugString; // 0x10
	public bool Successful; // 0x18
	protected internal bool GotResult; // 0x19
	protected internal int PingLength; // 0x1C
	protected internal byte[] PingBytes; // 0x20
	protected internal byte PingId; // 0x28
	private static readonly Random RandomIdProvider; // 0x0

	// Methods

	// RVA: 0x67BF80 Offset: 0x67A580 VA: 0x18067BF80 Slot: 5
	public virtual bool StartPing(string ip) { }

	// RVA: 0x67BEC0 Offset: 0x67A4C0 VA: 0x18067BEC0 Slot: 6
	public virtual bool Done() { }

	// RVA: 0x67BE80 Offset: 0x67A480 VA: 0x18067BE80 Slot: 7
	public virtual void Dispose() { }

	// RVA: 0x67BF00 Offset: 0x67A500 VA: 0x18067BF00
	protected internal void Init() { }

	// RVA: 0x67C040 Offset: 0x67A640 VA: 0x18067C040
	protected void .ctor() { }

	// RVA: 0x67BFC0 Offset: 0x67A5C0 VA: 0x18067BFC0
	private static void .cctor() { }
}
