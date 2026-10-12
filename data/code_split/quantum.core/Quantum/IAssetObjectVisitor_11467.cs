// Namespace: Quantum
public interface IAssetObjectVisitor // TypeDefIndex: 11467
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit(BinaryData asset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Visit(CharacterController2DConfig asset);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Visit(CharacterController3DConfig asset);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Visit(EntityPrototype asset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Visit(EntityView asset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Visit(Map asset);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Visit(NavMesh asset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Visit(NavMeshAgentConfig asset);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Visit(PhysicsMaterial asset);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Visit(PolygonCollider asset);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Visit(TerrainCollider asset);
}
