// Namespace: Quantum
[Serializable]
public class RuntimePlayer // TypeDefIndex: 10243
{
	// Fields
	[HideInInspector]
	public int PlayerIndex; // 0x10
	public PlayerSettings PlayerSettings; // 0x18

	// Methods

	// RVA: 0x215A410 Offset: 0x2158A10 VA: 0x18215A410
	public void Serialize(BitStream stream) { }

	// RVA: 0x215A410 Offset: 0x2158A10 VA: 0x18215A410
	private void SerializeUserData(BitStream stream) { }

	// RVA: 0x215A4E0 Offset: 0x2158AE0 VA: 0x18215A4E0
	public static byte[] ToByteArray(RuntimePlayer player, int arrayCapacity = 8192) { }

	// RVA: 0x215A310 Offset: 0x2158910 VA: 0x18215A310
	public static RuntimePlayer FromByteArray(byte[] data) { }

	// RVA: 0x215A590 Offset: 0x2158B90 VA: 0x18215A590
	public void .ctor() { }
}
