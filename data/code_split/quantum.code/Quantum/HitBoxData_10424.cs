// Namespace: Quantum
[Serializable]
public struct HitBoxData // TypeDefIndex: 10424
{
	// Fields
	public HashString ID; // 0x0
	public int StartFrame; // 0x10
	public int EndFrame; // 0x14
	public FP Radius; // 0x18
	public HitBoxType HitBoxType; // 0x20
	public HitBoxPriority Priority; // 0x24
	public CombatCapsulePointSetupType HitBoxPositionType; // 0x28
	public HashString JointID; // 0x30
	public HashString[] AttackDatas; // 0x40
	public CombatCapsulePositionKeyFrame[] PointPositions; // 0x48
	public CombatCapsuleOffsetKeyFrame[] PointOffsets; // 0x50

	// Methods

	// RVA: 0x21B8190 Offset: 0x21B6790 VA: 0x1821B8190
	public bool IsActive(int currentFrame) { }

	// RVA: 0x21B8010 Offset: 0x21B6610 VA: 0x1821B8010
	public FPVector2 GetPositionForFrame(int currentFrame) { }

	// RVA: 0x21B81B0 Offset: 0x21B67B0 VA: 0x1821B81B0
	public void OffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset) { }
}
