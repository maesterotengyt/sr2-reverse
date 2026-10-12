// Namespace: 
[Extension]
public static class EntityPrototypeUtils // TypeDefIndex: 2402
{
	// Methods

	// RVA: 0x51E530 Offset: 0x51CB30 VA: 0x18051E530
	public static bool TrySetShapeConfigFromSourceCollider2D(Shape2DConfig config, Transform reference, Component collider) { }

	// RVA: 0x51E8F0 Offset: 0x51CEF0 VA: 0x18051E8F0
	public static bool TrySetShapeConfigFromSourceCollider3D(Shape3DConfig config, Transform reference, Component collider) { }

	[Obsolete("Use TrySetShapeConfigFromSourceCollider2D instead.")]
	// RVA: 0x51DBC0 Offset: 0x51C1C0 VA: 0x18051DBC0
	public static Shape2DConfig ColliderToShape2D(Transform reference, Component collider, out bool isTrigger) { }

	[Obsolete("Use TrySetShapeConfigFromSourceCollider3D instead.")]
	// RVA: 0x51E010 Offset: 0x51C610 VA: 0x18051E010
	public static Shape3DConfig ColliderToShape3D(Transform reference, Component collider, out bool isTrigger) { }

	[Extension]
	// RVA: 0x51E2E0 Offset: 0x51C8E0 VA: 0x18051E2E0
	public static bool IsColliderTrigger(Component component) { }

	// RVA: 0x51E120 Offset: 0x51C720 VA: 0x18051E120
	private static string CreateTypeNotSupportedMessage(Type colliderType, Type[] supportedTypes) { }

	// RVA: 0x51E360 Offset: 0x51C960 VA: 0x18051E360
	private static void ThrowIfDifferentWorldPosition(Transform reference, Bounds bounds) { }

	// RVA: 0x51E430 Offset: 0x51CA30 VA: 0x18051E430
	private static void ThrowIfDifferentWorldRotation(Transform reference, Component collider) { }
}
