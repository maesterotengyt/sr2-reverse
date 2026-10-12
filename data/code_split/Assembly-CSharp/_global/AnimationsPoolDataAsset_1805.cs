// Namespace: 
[CreateAssetMenu(menuName = "Quantum/AnimationsPoolData", order = -900)]
public class AnimationsPoolDataAsset : AssetBase // TypeDefIndex: 1805
{
	// Fields
	public AnimationsPoolData Settings; // 0x18
	public string ClipDataPrefix; // 0x20
	[ReadOnlyField]
	public string ClipsInputPath; // 0x28
	[ReadOnlyField]
	public string OptimizedClipsOutputPath; // 0x30
	[ReadOnlyField]
	public string BakedClipsOutputPath; // 0x38
	[ReadOnlyField]
	public AnimationClipDataAsset[] ClipsData; // 0x40
	public SubAnimationsPoolData[] SubAnimationsDataFullSync; // 0x48
	public SubAnimationsPoolData[] SubAnimationsDataNoFullSync; // 0x50

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x5037E0 Offset: 0x501DE0 VA: 0x1805037E0 Slot: 9
	public override void Reset() { }

	// RVA: 0x503650 Offset: 0x501C50 VA: 0x180503650
	public bool FindClipDataForEditor(int clipIndex, out AnimationClipDataAsset clipData) { }

	// RVA: 0x503700 Offset: 0x501D00 VA: 0x180503700
	public int FindClipIndexForEditor(string clipName) { }

	// RVA: 0x503850 Offset: 0x501E50 VA: 0x180503850
	public void .ctor() { }
}
