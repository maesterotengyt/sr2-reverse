// Namespace: Quantum
public struct PhysicsCollider2D : IComponent // TypeDefIndex: 11701
{
	// Fields
	public const int SIZE = 80;
	private byte _isTrigger; // 0x0
	private byte _disabled; // 0x1
	private short _padding; // 0x2
	private int _layer; // 0x4
	private AssetRefPhysicsMaterial _material; // 0x8
	public Shape2D Shape; // 0x10

	// Properties
	public int Layer { get; set; }
	public bool IsTrigger { get; set; }
	public AssetRefPhysicsMaterial Material { get; }
	public bool Enabled { get; set; }

	// Methods

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_Layer() { }

	// RVA: 0x221E410 Offset: 0x221CA10 VA: 0x18221E410
	public void set_Layer(int value) { }

	// RVA: 0x221E3F0 Offset: 0x221C9F0 VA: 0x18221E3F0
	public bool get_IsTrigger() { }

	// RVA: 0x22186A0 Offset: 0x2216CA0 VA: 0x1822186A0
	public void set_IsTrigger(bool value) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public AssetRefPhysicsMaterial get_Material() { }

	// RVA: 0x221E3E0 Offset: 0x221C9E0 VA: 0x18221E3E0
	public bool get_Enabled() { }

	// RVA: 0x221E400 Offset: 0x221CA00 VA: 0x18221E400
	public void set_Enabled(bool value) { }

	// RVA: 0x221E150 Offset: 0x221C750 VA: 0x18221E150
	public static PhysicsCollider2D Create(FrameBase f, Shape2D shape, PhysicsMaterial material, bool isTrigger = False, int layer = 0) { }

	// RVA: 0x221E2F0 Offset: 0x221C8F0 VA: 0x18221E2F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x221E2B0 Offset: 0x221C8B0 VA: 0x18221E2B0
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
