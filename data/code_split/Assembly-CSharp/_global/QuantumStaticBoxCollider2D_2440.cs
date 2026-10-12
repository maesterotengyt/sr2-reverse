// Namespace: 
public class QuantumStaticBoxCollider2D : MonoBehaviour // TypeDefIndex: 2440
{
	// Fields
	public Component SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 Size; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x38
	public FP RotationOffset; // 0x48
	public FP Height; // 0x50
	public QuantumStaticColliderSettings Settings; // 0x58

	// Methods

	// RVA: 0x533530 Offset: 0x531B30 VA: 0x180533530
	public void UpdateFromSourceCollider() { }

	// RVA: 0x532FA0 Offset: 0x5315A0 VA: 0x180532FA0 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x5334C0 Offset: 0x531AC0 VA: 0x1805334C0
	private void OnDrawGizmos() { }

	// RVA: 0x533450 Offset: 0x531A50 VA: 0x180533450
	private void OnDrawGizmosSelected() { }

	// RVA: 0x532FB0 Offset: 0x5315B0 VA: 0x180532FB0
	private void DrawGizmo(bool selected) { }

	// RVA: 0x533640 Offset: 0x531C40 VA: 0x180533640
	public void .ctor() { }
}
