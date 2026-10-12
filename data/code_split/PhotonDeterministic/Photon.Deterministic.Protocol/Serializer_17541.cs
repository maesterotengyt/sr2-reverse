// Namespace: Photon.Deterministic.Protocol
public class Serializer // TypeDefIndex: 17541
{
	// Fields
	private Dictionary<Type, byte> _typeToId; // 0x10
	private Dictionary<byte, Message> _idToType; // 0x18
	public string ProtocolVersion; // 0x20

	// Methods

	// RVA: 0x20C4180 Offset: 0x20C2780 VA: 0x1820C4180
	public void .ctor() { }

	// RVA: 0x20C40E0 Offset: 0x20C26E0 VA: 0x1820C40E0
	private void RegisterPrototype(byte id, Message message) { }

	// RVA: 0x20C3E90 Offset: 0x20C2490 VA: 0x1820C3E90
	public bool PackNext(BitStream s, Message msg) { }

	// RVA: 0x20C3F80 Offset: 0x20C2580 VA: 0x1820C3F80
	public bool ReadNext(BitStream s, out Message msg) { }

	// RVA: 0x20C3C70 Offset: 0x20C2270 VA: 0x1820C3C70
	public bool PackMessages(BitStream stream, Queue<Message> queue) { }
}
