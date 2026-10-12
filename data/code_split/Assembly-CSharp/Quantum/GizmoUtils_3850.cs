// Namespace: Quantum
[Extension]
public static class GizmoUtils // TypeDefIndex: 3850
{
	// Fields
	public const float DefaultArrowHeadLength = 0.25;
	public const float DefaultArrowHeadAngle = 25;

	// Methods

	[Extension]
	// RVA: 0x65A740 Offset: 0x658D40 VA: 0x18065A740
	public static Color Alpha(Color color, float a) { }

	[Extension]
	// RVA: 0x65B680 Offset: 0x659C80 VA: 0x18065B680
	public static Color Brightness(Color color, float brightness) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosBox(Transform transform, Vector3 size, Color color, Vector3 offset, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosBox(Vector3 center, Vector3 size, Color color, bool selected = False, Nullable<Quaternion> rotation, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosBox(Matrix4x4 matrix, Vector3 size, Color color, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosCircle(Vector3 position, float radius, Color color, float height = 0, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosSphere(Vector3 position, float radius, Color color, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosTriangle(Vector3 A, Vector3 B, Vector3 C, bool selected, Color color) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoGrid(FPVector2 bottomLeft, int width, int height, int nodeSize, Color color) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoGrid(Vector3 bottomLeft, int width, int height, int nodeSize, Color color) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoGrid(Vector3 bottomLeft, int width, int height, float nodeWidth, float nodeHeight, Color color) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoPolygon2D(Vector3 position, Quaternion rotation, FPVector2[] vertices, float height, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoPolygon2D(Vector3 position, Quaternion rotation, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoPolygon2D(Transform transform, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoPolygon2D(Matrix4x4 matrix, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void DrawGizmoPolygon2DInternal(Vector3[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoDiamond(Vector3 center, Vector2 size) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoVector3D(Vector3 start, Vector3 end, float arrowHeadLength = 0.25, float arrowHeadAngle = 25) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoVector(Vector3 start, Vector3 end, float arrowHeadLength = 0.25, float arrowHeadAngle = 25) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoArc(Vector3 position, Vector3 normal, Vector3 from, float angle, float radius, Color color, float alphaRatio = 1, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmoDisc(Vector3 position, Vector3 normal, float radius, Color color, float alphaRatio = 1, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosEdge(Vector3 start, Vector3 end, float height, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosJoint2D(Joint2D_Prototype prototype, Transform jointTransform, Transform connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosJoint2D(Joint* joint, Transform2D* jointTransform, Transform2D* connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosJoint3D(Joint3D_Prototype prototype, Transform jointTransform, Transform connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void DrawGizmosJoint3D(Joint3D* joint, Transform3D* jointTransform, Transform3D* connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void DrawGizmosJointInternal(ref GizmoUtils.GizmosJointParams p, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x65B730 Offset: 0x659D30 VA: 0x18065B730
	private static float ComputeRelativeAngleHingeJoint(Vector3 hingeAxis, Quaternion rotJoint, Quaternion rotConnectedAnchor, Quaternion relRotRef) { }
}
