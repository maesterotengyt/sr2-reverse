// Namespace: Quantum
public struct EntityComponentPointerPair<T> // TypeDefIndex: 11555
{
	// Fields
	public EntityRef Entity; // 0x0
	public T* Component; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Deconstruct(out EntityRef entity, out T* component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F0C0 Offset: 0x125D6C0 VA: 0x18125F0C0
	|-EntityComponentPointerPair<NavMeshAvoidanceObstacle>.Deconstruct
	|-EntityComponentPointerPair<NavMeshPathfinder>.Deconstruct
	|-EntityComponentPointerPair<PhysicsCollider2D>.Deconstruct
	|-EntityComponentPointerPair<PhysicsCollider3D>.Deconstruct
	|-EntityComponentPointerPair<SpeedRunnersCharacter>.Deconstruct
	|-EntityComponentPointerPair<Transform2D>.Deconstruct
	|-EntityComponentPointerPair<__Il2CppFullySharedGenericStructType>.Deconstruct
	*/
}
