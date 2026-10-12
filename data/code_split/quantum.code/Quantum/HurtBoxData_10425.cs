// Namespace: Quantum
[Serializable]
public struct HurtBoxData // TypeDefIndex: 10425
{
	// Fields
	public HashString ID; // 0x0
	public FP Radius; // 0x10
	public HashString JointAIdentifier; // 0x18
	public HashString JointBIdentifier; // 0x28
	public CombatCapsulePositionKeyFrame[] PointAPositions; // 0x38
	public CombatCapsulePositionKeyFrame[] PointBPositions; // 0x40
	public CombatCapsuleOffsetKeyFrame[] PointAOffsets; // 0x48
	public CombatCapsuleOffsetKeyFrame[] PointBOffsets; // 0x50

	// Methods

	// RVA: 0x21B8790 Offset: 0x21B6D90 VA: 0x1821B8790
	public FPVector2 GetAPositionForFrame(int currentFrame) { }

	// RVA: 0x21B87F0 Offset: 0x21B6DF0 VA: 0x1821B87F0
	public FPVector2 GetBPositionForFrame(int currentFrame) { }

	// RVA: 0x21B8910 Offset: 0x21B6F10 VA: 0x1821B8910
	private FPVector2 PositionForFrame(int currentFrame, ref CombatCapsulePositionKeyFrame[] positions) { }

	// RVA: 0x21B8760 Offset: 0x21B6D60 VA: 0x1821B8760
	public void GetAOffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset) { }

	// RVA: 0x21B87C0 Offset: 0x21B6DC0 VA: 0x1821B87C0
	public void GetBOffsetForFrame(int currentFrame, out FPVector3 localOffset, out FPVector2 globalOffset) { }

	// RVA: 0x21B8820 Offset: 0x21B6E20 VA: 0x1821B8820
	public void OffsetForFrame(int currentFrame, ref CombatCapsuleOffsetKeyFrame[] offsets, out FPVector3 localOffset, out FPVector2 globalOffset) { }
}
