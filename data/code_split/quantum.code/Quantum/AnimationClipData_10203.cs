// Namespace: Quantum
[Serializable]
public class AnimationClipData : AssetObject // TypeDefIndex: 10203
{
	// Fields
	public int ClipIndex; // 0x20
	public HashString ClipName; // 0x28
	public FP Duration; // 0x38
	public VisibilityFrame[] BakedVisibilityData; // 0x40
	public BlendShapeFrame[] BakedBlendShapeData; // 0x48

	// Methods

	// RVA: 0x214E880 Offset: 0x214CE80 VA: 0x18214E880
	public int GetClosestBakedVisibilityFrame(int animationFrame) { }

	// RVA: 0x214E820 Offset: 0x214CE20 VA: 0x18214E820
	public int GetClosestBakedBlendShapeFrame(int animationFrame) { }

	// RVA: 0x214E8E0 Offset: 0x214CEE0 VA: 0x18214E8E0
	public void .ctor() { }
}
