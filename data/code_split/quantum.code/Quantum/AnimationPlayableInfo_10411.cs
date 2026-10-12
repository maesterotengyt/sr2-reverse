// Namespace: Quantum
[Serializable]
public struct AnimationPlayableInfo // TypeDefIndex: 10411
{
	// Fields
	public AnimationChannel TargetChannel; // 0x0
	public HashString Animation; // 0x8
	[DrawWithLabel]
	public EntityVariable Speed; // 0x18
	[DrawWithLabel]
	public EntityVariable Weight; // 0x20
	public bool Loop; // 0x28
	public int StartFrame; // 0x2C
	public int EndFrame; // 0x30
	public AnimationSpeedElement[] AnimationSpeedData; // 0x38
	[Space(5)]
	public ExecuteGroupEvent AnimationFinishedGroupEvent; // 0x40
}
