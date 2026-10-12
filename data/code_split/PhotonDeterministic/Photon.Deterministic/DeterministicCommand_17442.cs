// Namespace: Photon.Deterministic
public abstract class DeterministicCommand : IDeterministicCommandFactory, IDisposable // TypeDefIndex: 17442
{
	// Fields
	internal byte[] Source; // 0x10
	public IDeterministicCommandPool Pool; // 0x18
	internal bool Pooled; // 0x20

	// Properties
	public Type CommandType { get; }

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }

	// RVA: 0x20B0470 Offset: 0x20AEA70 VA: 0x1820B0470 Slot: 7
	public virtual void Serialize(BitStream stream, DeterministicCommandSerializer cmdSerializer) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Serialize(BitStream stream);

	// RVA: 0x1F5C3C0 Offset: 0x1F5A9C0 VA: 0x181F5C3C0 Slot: 4
	public Type get_CommandType() { }

	// RVA: 0x20B03B0 Offset: 0x20AE9B0 VA: 0x1820B03B0 Slot: 9
	public virtual DeterministicCommand GetCommandInstance() { }

	// RVA: 0x20B0300 Offset: 0x20AE900 VA: 0x1820B0300 Slot: 10
	public virtual void Dispose() { }
}
