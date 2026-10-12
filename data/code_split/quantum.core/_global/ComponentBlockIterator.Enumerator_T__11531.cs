// Namespace: 
public struct ComponentBlockIterator.Enumerator<T> // TypeDefIndex: 11531
{
	// Fields
	private FrameBase _f; // 0x0
	private int _blockIndex; // 0x0
	private int _blockCount; // 0x0
	private EntityRef* _blockEntities; // 0x0
	private T* _blockComponents; // 0x0
	private ComponentBlockIterator<T> _iterator; // 0x0

	// Properties
	public EntityComponentPointerPair<T> Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FrameBase f, ComponentBlockIterator<T> iterator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E45F0 Offset: 0x19E2BF0 VA: 0x1819E45F0
	|-ComponentBlockIterator.Enumerator<NavMeshAvoidanceObstacle>..ctor
	|-ComponentBlockIterator.Enumerator<NavMeshPathfinder>..ctor
	|-ComponentBlockIterator.Enumerator<PhysicsCollider2D>..ctor
	|-ComponentBlockIterator.Enumerator<PhysicsCollider3D>..ctor
	|-ComponentBlockIterator.Enumerator<SpeedRunnersCharacter>..ctor
	|-ComponentBlockIterator.Enumerator<Transform2D>..ctor
	|-ComponentBlockIterator.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public EntityComponentPointerPair<T> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E51D0 Offset: 0x19E37D0 VA: 0x1819E51D0
	|-ComponentBlockIterator.Enumerator<NavMeshAvoidanceObstacle>.get_Current
	|
	|-RVA: 0x19E5750 Offset: 0x19E3D50 VA: 0x1819E5750
	|-ComponentBlockIterator.Enumerator<NavMeshPathfinder>.get_Current
	|
	|-RVA: 0x19E5610 Offset: 0x19E3C10 VA: 0x1819E5610
	|-ComponentBlockIterator.Enumerator<PhysicsCollider2D>.get_Current
	|
	|-RVA: 0x19E5250 Offset: 0x19E3850 VA: 0x1819E5250
	|-ComponentBlockIterator.Enumerator<PhysicsCollider3D>.get_Current
	|
	|-RVA: 0x19F7B60 Offset: 0x19F6160 VA: 0x1819F7B60
	|-ComponentBlockIterator.Enumerator<SpeedRunnersCharacter>.get_Current
	|
	|-RVA: 0x1A03EB0 Offset: 0x1A024B0 VA: 0x181A03EB0
	|-ComponentBlockIterator.Enumerator<Transform2D>.get_Current
	|
	|-RVA: 0x1A047D0 Offset: 0x1A02DD0 VA: 0x181A047D0
	|-ComponentBlockIterator.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0A90 Offset: 0x19DF090 VA: 0x1819E0A90
	|-ComponentBlockIterator.Enumerator<NavMeshAvoidanceObstacle>.MoveNext
	|-ComponentBlockIterator.Enumerator<NavMeshPathfinder>.MoveNext
	|-ComponentBlockIterator.Enumerator<PhysicsCollider2D>.MoveNext
	|-ComponentBlockIterator.Enumerator<PhysicsCollider3D>.MoveNext
	|-ComponentBlockIterator.Enumerator<SpeedRunnersCharacter>.MoveNext
	|-ComponentBlockIterator.Enumerator<Transform2D>.MoveNext
	|
	|-RVA: 0x19FAA30 Offset: 0x19F9030 VA: 0x1819FAA30
	|-ComponentBlockIterator.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/
}
