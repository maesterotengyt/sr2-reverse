// Namespace: 
public class QuantumStaticCircleCollider2D : MonoBehaviour // TypeDefIndex: 2442
{
	// Fields
	public Component SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FP Radius; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x30
	public FP Height; // 0x40
	public QuantumStaticColliderSettings Settings; // 0x48

	// Methods

	// RVA: 0x5339D0 Offset: 0x531FD0 VA: 0x1805339D0
	public void UpdateFromSourceCollider() { }

	// RVA: 0x5336B0 Offset: 0x531CB0 VA: 0x1805336B0 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x533960 Offset: 0x531F60 VA: 0x180533960
	private void OnDrawGizmos() { }

	// RVA: 0x5338F0 Offset: 0x531EF0 VA: 0x1805338F0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5336C0 Offset: 0x531CC0 VA: 0x1805336C0
	private void DrawGizmo(bool selected) { }

	// RVA: 0x533AD0 Offset: 0x5320D0 VA: 0x180533AD0
	public void .ctor() { }
}
