// Namespace: 
public struct Shape2D.PolygonShape // TypeDefIndex: 11707
{
	// Fields
	public const int SIZE = 32;
	internal FP _broadRadius; // 0x0
	internal AssetRefPolygonCollider _assetRef; // 0x8
	internal FPVector2 _centroid; // 0x10

	// Properties
	public AssetRefPolygonCollider AssetRef { get; }

	// Methods

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public AssetRefPolygonCollider get_AssetRef() { }

	// RVA: 0x221EF50 Offset: 0x221D550 VA: 0x18221EF50
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x221EF00 Offset: 0x221D500 VA: 0x18221EF00 Slot: 2
	public override int GetHashCode() { }
}
