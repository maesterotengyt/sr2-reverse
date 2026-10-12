// Namespace: 
[Serializable]
public class QuantumFrameDifferGUI.FrameDifferState : ISerializationCallbackReceiver // TypeDefIndex: 2454
{
	// Fields
	[SerializeField]
	private List<QuantumFrameDifferGUI.StateEntry> Entries; // 0x10
	private Dictionary<string, Dictionary<int, Dictionary<int, QuantumFrameDifferGUI.FrameData>>> _byRunner; // 0x18

	// Properties
	public IEnumerable<string> RunnerIds { get; }

	// Methods

	// RVA: 0x51FBD0 Offset: 0x51E1D0 VA: 0x18051FBD0
	public void Clear() { }

	// RVA: 0x51FAA0 Offset: 0x51E0A0 VA: 0x18051FAA0
	public void AddEntry(string runnerId, int actorId, int frameNumber, string frameDump, string actorName) { }

	// RVA: 0x51FD40 Offset: 0x51E340 VA: 0x18051FD40 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x51FED0 Offset: 0x51E4D0 VA: 0x18051FED0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x520040 Offset: 0x51E640 VA: 0x180520040
	private void OnEntryAdded(QuantumFrameDifferGUI.StateEntry entry) { }

	// RVA: 0x5203A0 Offset: 0x51E9A0 VA: 0x1805203A0
	public IEnumerable<string> get_RunnerIds() { }

	// RVA: 0x51FC50 Offset: 0x51E250 VA: 0x18051FC50
	internal Dictionary<int, QuantumFrameDifferGUI.FrameData> GetFirstFrameDiff(string runnerId, out int frameNumber) { }

	// RVA: 0x5202E0 Offset: 0x51E8E0 VA: 0x1805202E0
	public void .ctor() { }
}
