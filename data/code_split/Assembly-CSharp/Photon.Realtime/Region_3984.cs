// Namespace: Photon.Realtime
public class Region // TypeDefIndex: 3984
{
	// Fields
	[CompilerGenerated]
	private string <Code>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Cluster>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <HostAndPort>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Ping>k__BackingField; // 0x28

	// Properties
	public string Code { get; set; }
	public string Cluster { get; set; }
	public string HostAndPort { get; set; }
	public int Ping { get; set; }
	public bool WasPinged { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_Code() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	private void set_Code(string value) { }

	[CompilerGenerated]
	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public string get_Cluster() { }

	[CompilerGenerated]
	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	private void set_Cluster(string value) { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_HostAndPort() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	protected internal void set_HostAndPort(string value) { }

	[CompilerGenerated]
	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_Ping() { }

	[CompilerGenerated]
	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_Ping(int value) { }

	// RVA: 0x680D80 Offset: 0x67F380 VA: 0x180680D80
	public bool get_WasPinged() { }

	// RVA: 0x680D20 Offset: 0x67F320 VA: 0x180680D20
	public void .ctor(string code, string address) { }

	// RVA: 0x680CE0 Offset: 0x67F2E0 VA: 0x180680CE0
	public void .ctor(string code, int ping) { }

	// RVA: 0x680AE0 Offset: 0x67F0E0 VA: 0x180680AE0
	private void SetCodeAndCluster(string codeAsString) { }

	// RVA: 0x680CD0 Offset: 0x67F2D0 VA: 0x180680CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x680BF0 Offset: 0x67F1F0 VA: 0x180680BF0
	public string ToString(bool compact = False) { }
}
