// Namespace: 
[Serializable]
public class SubAnimationsPoolData // TypeDefIndex: 3495
{
	// Fields
	public HashString SubAnimationID; // 0x10
	public string ClipDataPrefix; // 0x20
	[ReadOnlyField]
	public string ClipsInputPath; // 0x28
	[ReadOnlyField]
	public string OptimizedClipsOutputPath; // 0x30
	[ReadOnlyField]
	public string BakedClipsOutputPath; // 0x38
	[ReadOnlyField]
	public AnimationClipDataAsset[] ClipsData; // 0x40
	public AssetRefAnimationClipData[] ClipsDataRefs; // 0x48

	// Methods

	// RVA: 0x5F8680 Offset: 0x5F6C80 VA: 0x1805F8680
	public bool TryGetClipFromIndex(Frame frame, int clipIndex, out AnimationClipData clipData) { }

	// RVA: 0x503650 Offset: 0x501C50 VA: 0x180503650
	public bool FindClipDataForEditor(int clipIndex, out AnimationClipDataAsset clipData) { }

	// RVA: 0x503700 Offset: 0x501D00 VA: 0x180503700
	public int FindClipIndexForEditor(string clipName) { }

	// RVA: 0x5F8740 Offset: 0x5F6D40 VA: 0x1805F8740
	public void .ctor() { }
}
