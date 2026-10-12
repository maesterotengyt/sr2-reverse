// Namespace: 
public class QuantumMemoryStats : MonoBehaviour // TypeDefIndex: 2478
{
	// Fields
	public Text TotalMemory; // 0x20
	public Text TotalPages; // 0x28
	public Text TotalUsage; // 0x30
	public Text PagesFree; // 0x38
	public Text PagesFull; // 0x40
	public Text PagesUsed; // 0x48
	public Text BytesAllocated; // 0x50
	public Text BytesReserved; // 0x58
	public Text BytesCommited; // 0x60
	public Text EntityCount; // 0x68
	public Text EntityMemory; // 0x70
	private static string[] suf; // 0x0

	// Methods

	// RVA: 0x631740 Offset: 0x62FD40 VA: 0x180631740
	private void Update() { }

	// RVA: 0x6311A0 Offset: 0x62F7A0 VA: 0x1806311A0
	private void UpdateStats(Frame f) { }

	// RVA: 0x6310F0 Offset: 0x62F6F0 VA: 0x1806310F0
	private void UpdateStatsValue(Text text, int value, bool isBytes = True) { }

	// RVA: 0x630EE0 Offset: 0x62F4E0 VA: 0x180630EE0
	private static string BytesToString(long byteCount) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	// RVA: 0x631830 Offset: 0x62FE30 VA: 0x180631830
	private static void .cctor() { }
}
