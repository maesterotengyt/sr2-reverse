// Namespace: Quantum
[Serializable]
public struct SubAnimationPlayableInfo // TypeDefIndex: 10413
{
	// Fields
	public HashString SubanimatorName; // 0x0
	public HashString Animation; // 0x10
	[DrawWithLabel]
	public EntityVariable Speed; // 0x20
	[DrawWithLabel]
	public EntityVariable Weight; // 0x28
	public bool Loop; // 0x30
	public int StartFrame; // 0x34
	public int EndFrame; // 0x38
	[Space(5)]
	public ExecuteGroupEvent AnimationFinishedGroupEvent; // 0x40
}
