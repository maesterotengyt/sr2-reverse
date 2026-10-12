// Namespace: Quantum
[Serializable]
public struct EdgeGrabBoxDataObject // TypeDefIndex: 10546
{
	// Fields
	public int Frame; // 0x0
	public EdgeGrabCondition EdgeGrabCondition; // 0x4
	[Space(10)]
	public bool OverrideRect; // 0x8
	[DrawIf("OverrideRect", 1, 0, 3)]
	public SimpleAABB Rect; // 0x10
	public FP GrabVelocityThreshold; // 0x30
}
