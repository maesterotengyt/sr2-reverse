// Namespace: Quantum
[Serializable]
public class AnimationsPoolData : AssetObject // TypeDefIndex: 10202
{
	// Fields
	public AssetRefAnimationClipData[] ClipsDataRefs; // 0x20
	public SubAnimatorClipsInfo[] ClipsDataRefsSubAnimFullSync; // 0x28
	public SubAnimatorClipsInfo[] ClipsDataRefsSubAnimNoFullSync; // 0x30
	[CompilerGenerated]
	private Dictionary<int, AnimationClipData> <ClipsDict>k__BackingField; // 0x38
	[CompilerGenerated]
	private Dictionary<int, Dictionary<int, AnimationClipData>> <ClipsDictSubAnimFullSync>k__BackingField; // 0x40
	[CompilerGenerated]
	private Dictionary<int, Dictionary<int, AnimationClipData>> <ClipsDictSubAnimNoFullSync>k__BackingField; // 0x48

	// Properties
	public Dictionary<int, AnimationClipData> ClipsDict { get; set; }
	public Dictionary<int, Dictionary<int, AnimationClipData>> ClipsDictSubAnimFullSync { get; set; }
	public Dictionary<int, Dictionary<int, AnimationClipData>> ClipsDictSubAnimNoFullSync { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public Dictionary<int, AnimationClipData> get_ClipsDict() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	public void set_ClipsDict(Dictionary<int, AnimationClipData> value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public Dictionary<int, Dictionary<int, AnimationClipData>> get_ClipsDictSubAnimFullSync() { }

	[CompilerGenerated]
	// RVA: 0x5C5B80 Offset: 0x5C4180 VA: 0x1805C5B80
	public void set_ClipsDictSubAnimFullSync(Dictionary<int, Dictionary<int, AnimationClipData>> value) { }

	[CompilerGenerated]
	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0
	public Dictionary<int, Dictionary<int, AnimationClipData>> get_ClipsDictSubAnimNoFullSync() { }

	[CompilerGenerated]
	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	public void set_ClipsDictSubAnimNoFullSync(Dictionary<int, Dictionary<int, AnimationClipData>> value) { }

	// RVA: 0x214E960 Offset: 0x214CF60 VA: 0x18214E960
	public bool TryGetClipFromHash(Frame frame, int clipHash, out AnimationClipData clipData) { }

	// RVA: 0x214EB10 Offset: 0x214D110 VA: 0x18214EB10
	public bool TryGetClipFromIndex(Frame frame, int clipIndex, out AnimationClipData clipData) { }

	// RVA: 0x214EBD0 Offset: 0x214D1D0 VA: 0x18214EBD0
	public bool TryGetSubAnimClipFromHash(Frame frame, int subAnimatorHash, int clipHash, out AnimationClipData clipData, bool fullSync) { }

	// RVA: 0x214F050 Offset: 0x214D650 VA: 0x18214F050
	public bool TryGetSubAnimationsClipDatas(Frame frame, int subAnimatorHash, bool fullSync, out AssetRefAnimationClipData[] animationAnimClipData) { }

	// RVA: 0x214F190 Offset: 0x214D790 VA: 0x18214F190
	public void .ctor() { }
}
