// Namespace: 
public class QuantumStaticPolygonCollider2D : MonoBehaviour // TypeDefIndex: 2446
{
	// Fields
	public PolygonCollider2D SourceCollider; // 0x20
	public bool BakeAsStaticEdges2D; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2[] Vertices; // 0x30
	[DrawIf("SourceCollider", 0, 0, 2)]
	[Tooltip("Additional translation applied to transform position when baking")]
	public FPVector2 PositionOffset; // 0x38
	[Tooltip("Additional rotation (in degrees) applied to transform rotation when baking")]
	public FP RotationOffset; // 0x48
	public FP Height; // 0x50
	public QuantumStaticColliderSettings Settings; // 0x58

	// Properties
	protected virtual bool UpdateVerticesFromSourceOnBake { get; }

	// Methods

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 4
	protected virtual bool get_UpdateVerticesFromSourceOnBake() { }

	// RVA: 0x5349E0 Offset: 0x532FE0 VA: 0x1805349E0
	public void UpdateFromSourceCollider(bool updateVertices = True) { }

	// RVA: 0x534390 Offset: 0x532990 VA: 0x180534390 Slot: 5
	public virtual void BeforeBake() { }

	// RVA: 0x534970 Offset: 0x532F70 VA: 0x180534970
	private void OnDrawGizmos() { }

	// RVA: 0x534900 Offset: 0x532F00 VA: 0x180534900
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5343C0 Offset: 0x5329C0 VA: 0x1805343C0
	private void DrawGizmo(bool selected) { }

	// RVA: 0x534B90 Offset: 0x533190 VA: 0x180534B90
	public void .ctor() { }
}
