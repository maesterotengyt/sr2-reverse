// Namespace: Photon.Deterministic
public class DeterministicCommandSerializer // TypeDefIndex: 17444
{
	// Fields
	private Dictionary<Type, ushort> _typeToId; // 0x10
	private Dictionary<ushort, IDeterministicCommandFactory> _idToFactory; // 0x18
	public BitStream CommandSerializerStreamRead; // 0x20
	public BitStream CommandSerializerStreamWrite; // 0x28

	// Methods

	// RVA: 0x20B01D0 Offset: 0x20AE7D0 VA: 0x1820B01D0
	public void .ctor() { }

	// RVA: 0x20B0040 Offset: 0x20AE640 VA: 0x1820B0040
	public void RegisterFactory(IDeterministicCommandFactory factory) { }

	// RVA: 0x20AFE80 Offset: 0x20AE480 VA: 0x1820AFE80
	public void RegisterFactories(IDeterministicCommandFactory[] factories) { }

	// RVA: 0x20AFBE0 Offset: 0x20AE1E0 VA: 0x1820AFBE0
	public bool PackNext(BitStream s, DeterministicCommand cmd) { }

	// RVA: 0x20AFD40 Offset: 0x20AE340 VA: 0x1820AFD40
	public bool ReadNext(BitStream s, out DeterministicCommand cmd) { }
}
