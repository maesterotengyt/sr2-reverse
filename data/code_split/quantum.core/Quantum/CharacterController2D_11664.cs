// Namespace: Quantum
public struct CharacterController2D : IComponent // TypeDefIndex: 11664
{
	// Fields
	private byte _grounded; // 0x0
	private byte _jumped; // 0x1
	private short _padding; // 0x2
	private int _broadphaseQueryIndexPlusOne; // 0x4
	private AssetRefCharacterController2DConfig _config; // 0x8
	public FP MaxSpeed; // 0x10
	public FPVector2 Velocity; // 0x18

	// Properties
	public bool Grounded { set; }

	// Methods

	// RVA: 0x22186A0 Offset: 0x2216CA0 VA: 0x1822186A0
	public void set_Grounded(bool value) { }

	// RVA: 0x2218410 Offset: 0x2216A10 VA: 0x182218410
	public void Init(FrameBase frame, CharacterController2DConfig config) { }

	// RVA: 0x2218340 Offset: 0x2216940 VA: 0x182218340
	public void Init(FrameThreadSafe frame, CharacterController2DConfig config) { }

	// RVA: 0x22185E0 Offset: 0x2216BE0 VA: 0x1822185E0
	public void SetConfig(FrameThreadSafe frame, CharacterController2DConfig config) { }

	// RVA: 0x22184E0 Offset: 0x2216AE0 VA: 0x1822184E0
	public static void Serialize(void* p, FrameSerializer serializer) { }
}
