// Namespace: Quantum.Physics3D
internal struct Island3D // TypeDefIndex: 11875
{
	// Fields
	public bool Ignore; // 0x0
	public bool VelocityConstraintsSolved; // 0x1
	public bool PositionConstraintsSolved; // 0x2
	public PhysicsCommon.UnsafeBuffer CollisionManifolds; // 0x8
	public PhysicsCommon.UnsafeBuffer Entries; // 0x20
	public long JointConstraintHeadAdr; // 0x38

	// Methods

	// RVA: 0x2273830 Offset: 0x2271E30 VA: 0x182273830
	public void Init(Native.Allocator allocator, int initialManifoldCapacity = 1024, int initialEntriesCapacity = 2048) { }

	// RVA: 0x2211990 Offset: 0x220FF90 VA: 0x182211990
	public void Reset() { }

	// RVA: 0x2211880 Offset: 0x220FE80 VA: 0x182211880
	public void Dispose(Native.Allocator allocator) { }

	// RVA: 0x22737C0 Offset: 0x2271DC0 VA: 0x1822737C0
	public void AddManifold(Native.Allocator allocator, CollisionManifold3D* manifold) { }

	// RVA: 0x22117F0 Offset: 0x220FDF0 VA: 0x1822117F0
	public void AddJointConstraint(ConstraintData* constraint) { }

	// RVA: 0x2273750 Offset: 0x2271D50 VA: 0x182273750
	public void AddEntry(Native.Allocator allocator, Entry3D* entry) { }
}
