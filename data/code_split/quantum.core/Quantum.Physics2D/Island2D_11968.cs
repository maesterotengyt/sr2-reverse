// Namespace: Quantum.Physics2D
internal struct Island2D // TypeDefIndex: 11968
{
	// Fields
	public bool Ignore; // 0x0
	public bool VelocityConstraintsSolved; // 0x1
	public bool PositionConstraintsSolved; // 0x2
	public PhysicsCommon.UnsafeBuffer CollisionManifolds; // 0x8
	public PhysicsCommon.UnsafeBuffer Entries; // 0x20
	public long JointConstraintHeadAdr; // 0x38

	// Methods

	// RVA: 0x22118C0 Offset: 0x220FEC0 VA: 0x1822118C0
	public void Init(Native.Allocator allocator, int initialManifoldCapacity = 1024, int initialEntriesCapacity = 2048) { }

	// RVA: 0x2211990 Offset: 0x220FF90 VA: 0x182211990
	public void Reset() { }

	// RVA: 0x2211880 Offset: 0x220FE80 VA: 0x182211880
	public void Dispose(Native.Allocator allocator) { }

	// RVA: 0x2211810 Offset: 0x220FE10 VA: 0x182211810
	public void AddManifold(Native.Allocator allocator, CollisionManifold2D* manifold) { }

	// RVA: 0x22117F0 Offset: 0x220FDF0 VA: 0x1822117F0
	public void AddJointConstraint(ConstraintData* constraint) { }

	// RVA: 0x2211780 Offset: 0x220FD80 VA: 0x182211780
	public void AddEntry(Native.Allocator allocator, Entry2D* entry) { }
}
