// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Binary Data", order = -491)]
public class BinaryDataAsset : AssetBase, ISerializationCallbackReceiver // TypeDefIndex: 2312
{
	// Fields
	public BinaryData Settings; // 0x18
	public TextAsset SourceTextAsset; // 0x20

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x503DA0 Offset: 0x5023A0 VA: 0x180503DA0 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x503E40 Offset: 0x502440 VA: 0x180503E40 Slot: 9
	public override void Reset() { }

	// RVA: 0x503EB0 Offset: 0x5024B0 VA: 0x180503EB0
	public void SetData(byte[] data, bool compressed) { }

	// RVA: 0x503F40 Offset: 0x502540 VA: 0x180503F40
	public void Store(Stream stream) { }

	// RVA: 0x503FB0 Offset: 0x5025B0 VA: 0x180503FB0 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
