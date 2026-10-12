// Namespace: Photon.Realtime
public class WebRpcResponse // TypeDefIndex: 3998
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ResultCode>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<string, object> <Parameters>k__BackingField; // 0x28

	// Properties
	public string Name { get; set; }
	public int ResultCode { get; set; }
	[Obsolete("Use ResultCode instead")]
	public int ReturnCode { get; }
	public string Message { get; set; }
	[Obsolete("Use Message instead")]
	public string DebugMessage { get; }
	public Dictionary<string, object> Parameters { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x6A4F50 Offset: 0x6A3550 VA: 0x1806A4F50
	private void set_ResultCode(int value) { }

	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	private void set_Message(string value) { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_DebugMessage() { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public Dictionary<string, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	private void set_Parameters(Dictionary<string, object> value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3390 VA: 0x1806A4D90
	public void .ctor(OperationResponse response) { }

	// RVA: 0x6A4B90 Offset: 0x6A3190 VA: 0x1806A4B90
	public string ToStringFull() { }
}
