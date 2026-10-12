// Namespace: 
public class QuantumStaticEdgeCollider2D : MonoBehaviour // TypeDefIndex: 2444
{
	// Fields
	public EdgeCollider2D SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 VertexA; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 VertexB; // 0x38
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x48
	public FP RotationOffset; // 0x58
	public FP Height; // 0x60
	public QuantumStaticColliderSettings Settings; // 0x68

	// Methods

	// RVA: 0x534180 Offset: 0x532780 VA: 0x180534180
	public void UpdateFromSourceCollider() { }

	// RVA: 0x533B40 Offset: 0x532140 VA: 0x180533B40 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x534110 Offset: 0x532710 VA: 0x180534110
	private void OnDrawGizmos() { }

	// RVA: 0x5340A0 Offset: 0x5326A0 VA: 0x1805340A0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x533B50 Offset: 0x532150 VA: 0x180533B50
	private void DrawGizmos(bool selected) { }

	// RVA: 0x533CE0 Offset: 0x5322E0 VA: 0x180533CE0
	public static void GetEdgeGizmosSettings(Transform t, FPVector2 posOffset, FP rotOffset, FPVector2 localStart, FPVector2 localEnd, FP localHeight, out Vector3 start, out Vector3 end, out float height) { }

	// RVA: 0x5342D0 Offset: 0x5328D0 VA: 0x1805342D0
	public void .ctor() { }
}
