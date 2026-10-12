// Namespace: Quantum
public struct ComponentBlockIterator<T> // TypeDefIndex: 11532
{
	// Fields
	private FrameBase _f; // 0x0
	private ComponentBlockIterator _iterator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FrameBase f, ComponentDataBuffer* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0FB0 Offset: 0x17AF5B0 VA: 0x1817B0FB0
	|-ComponentBlockIterator<NavMeshAvoidanceObstacle>..ctor
	|-ComponentBlockIterator<NavMeshPathfinder>..ctor
	|-ComponentBlockIterator<PhysicsCollider2D>..ctor
	|-ComponentBlockIterator<PhysicsCollider3D>..ctor
	|-ComponentBlockIterator<SpeedRunnersCharacter>..ctor
	|-ComponentBlockIterator<Transform2D>..ctor
	|-ComponentBlockIterator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ComponentBlockIterator.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0ED0 Offset: 0x17AF4D0 VA: 0x1817B0ED0
	|-ComponentBlockIterator<NavMeshAvoidanceObstacle>.GetEnumerator
	|-ComponentBlockIterator<NavMeshPathfinder>.GetEnumerator
	|-ComponentBlockIterator<PhysicsCollider2D>.GetEnumerator
	|-ComponentBlockIterator<PhysicsCollider3D>.GetEnumerator
	|-ComponentBlockIterator<SpeedRunnersCharacter>.GetEnumerator
	|-ComponentBlockIterator<Transform2D>.GetEnumerator
	|-ComponentBlockIterator<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal bool NextBlock(out EntityRef* entities, out T* components, out int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0F60 Offset: 0x17AF560 VA: 0x1817B0F60
	|-ComponentBlockIterator<NavMeshAvoidanceObstacle>.NextBlock
	|-ComponentBlockIterator<NavMeshPathfinder>.NextBlock
	|-ComponentBlockIterator<PhysicsCollider2D>.NextBlock
	|-ComponentBlockIterator<PhysicsCollider3D>.NextBlock
	|-ComponentBlockIterator<SpeedRunnersCharacter>.NextBlock
	|-ComponentBlockIterator<Transform2D>.NextBlock
	|-ComponentBlockIterator<__Il2CppFullySharedGenericStructType>.NextBlock
	*/
}
