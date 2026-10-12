// Namespace: Quantum
[Serializable]
public class RuntimeConfig // TypeDefIndex: 10241
{
	// Fields
	public int Seed; // 0x10
	public AssetRefMap Map; // 0x18
	public AssetRefSimulationConfig SimulationConfig; // 0x20
	public FP IntroAnimationDuration; // 0x28
	[Header("Core")]
	public bool IsEditor; // 0x30
	public bool OnlineActive; // 0x31
	public string StageID; // 0x38
	public string DefaultSpawnPointID; // 0x40
	public MatchRules MatchRules; // 0x48

	// Methods

	// RVA: 0x215A130 Offset: 0x2158730 VA: 0x18215A130
	public void Serialize(BitStream stream) { }

	// RVA: 0x215A020 Offset: 0x2158620 VA: 0x18215A020
	private void SerializeUserData(BitStream stream) { }

	// RVA: 0x215A260 Offset: 0x2158860 VA: 0x18215A260
	public static byte[] ToByteArray(RuntimeConfig config, int arrayCapacity = 8192) { }

	// RVA: 0x2159F40 Offset: 0x2158540 VA: 0x182159F40
	public static RuntimeConfig FromByteArray(byte[] data) { }

	// RVA: 0x2159FF0 Offset: 0x21585F0 VA: 0x182159FF0
	private void OnSerializeUserData(BitStream stream) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
