// Namespace: 
public static class QuantumGameGizmos // TypeDefIndex: 2460
{
	// Methods

	// RVA: 0x52D4B0 Offset: 0x52BAB0 VA: 0x18052D4B0
	private static Color Desaturate(Color c, float t) { }

	// RVA: 0x52F4B0 Offset: 0x52DAB0 VA: 0x18052F4B0
	public static bool ShouldDraw(QuantumEditorSettings.GizmosMode mode, bool selected, bool hasStateDrawer = True) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void OnDrawGizmos(QuantumGame game, QuantumEditorSettings editorSettings) { }

	// RVA: 0x52D5E0 Offset: 0x52BBE0 VA: 0x18052D5E0
	public static void DrawCharacterController2DGizmo(Vector3 position, CharacterController2DConfig config, bool selected, QuantumGizmoStyle style) { }

	// RVA: 0x52D750 Offset: 0x52BD50 VA: 0x18052D750
	public static void DrawCharacterController3DGizmo(Vector3 position, CharacterController3DConfig config, bool selected, QuantumGizmoStyle style) { }

	// RVA: 0x52E090 Offset: 0x52C690 VA: 0x18052E090
	public static void DrawCollider3DGizmo(Frame frame, EntityRef handle, PhysicsCollider3D* collider, QuantumGizmoStyle style) { }

	// RVA: 0x52D8D0 Offset: 0x52BED0 VA: 0x18052D8D0
	public static void DrawCollider2DGizmo(Frame frame, EntityRef handle, PhysicsCollider2D* collider, QuantumGizmoStyle style) { }

	// RVA: 0x52F120 Offset: 0x52D720 VA: 0x18052F120
	public static void DrawShape3DGizmo(Shape3D s, Vector3 position, Quaternion rotation, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x52EB00 Offset: 0x52D100 VA: 0x18052EB00
	public static void DrawShape2DGizmo(Shape2D s, Vector3 pos, Quaternion rot, Color color, float height, Frame currentFrame, QuantumGizmoStyle style) { }

	// RVA: 0x52E6F0 Offset: 0x52CCF0 VA: 0x18052E6F0
	private static void DrawCompoundShape2D(Frame f, Shape2D* compoundShape, Transform2D* transform, Transform2DVertical* transformVertical, Color color, float height, QuantumGizmoStyle style) { }

	// RVA: 0x52E8F0 Offset: 0x52CEF0 VA: 0x18052E8F0
	private static void DrawCompoundShape3D(Frame f, Shape3D* compoundShape, Transform3D* transform, Color color, QuantumGizmoStyle style) { }
}
