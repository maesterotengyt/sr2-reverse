// Namespace: Quantum
[Serializable]
public class BinaryData : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11468
{
	// Fields
	public byte[] Data; // 0x20
	public bool IsCompressed; // 0x28

	// Methods

	// RVA: 0x21C5690 Offset: 0x21C3C90 VA: 0x1821C5690 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21C55F0 Offset: 0x21C3BF0 VA: 0x1821C55F0
	public ByteStream CreateByteStream() { }

	// RVA: 0x21C5740 Offset: 0x21C3D40 VA: 0x1821C5740
	public void .ctor() { }
}
