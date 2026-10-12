// Namespace: Quantum
public struct CharacterController3D : IComponent // TypeDefIndex: 11666
{
	// Fields
	public const int SIZE = 48;
	private byte _grounded; // 0x0
	private byte _jumped; // 0x1
	private short _padding; // 0x2
	private int _broadphaseQueryIndexPlusOne; // 0x4
	private AssetRefCharacterController3DConfig _config; // 0x8
	public FP MaxSpeed; // 0x10
	public FPVector3 Velocity; // 0x18

	// Properties
	public AssetRefCharacterController3DConfig Config { get; }
	public bool Grounded { set; }
	public bool Jumped { get; set; }
	public int BroadPhaseQueryIndex { get; set; }

	// Methods

	// RVA: 0x22186B0 Offset: 0x2216CB0 VA: 0x1822186B0
	public static CharacterController3DMovement ComputeRawMovement(FrameThreadSafe frame, EntityRef entity, Transform3D* transform, CharacterController3D* kcc, FPVector3 direction, IKCCCallbacks3D callback, Nullable<int> layerMask, Nullable<bool> useManifoldNormal) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public AssetRefCharacterController3DConfig get_Config() { }

	// RVA: 0x22186A0 Offset: 0x2216CA0 VA: 0x1822186A0
	public void set_Grounded(bool value) { }

	// RVA: 0x221A2B0 Offset: 0x22188B0 VA: 0x18221A2B0
	public bool get_Jumped() { }

	// RVA: 0x221A2E0 Offset: 0x22188E0 VA: 0x18221A2E0
	public void set_Jumped(bool value) { }

	// RVA: 0x1CFA480 Offset: 0x1CF8A80 VA: 0x181CFA480
	public int get_BroadPhaseQueryIndex() { }

	// RVA: 0x221A2C0 Offset: 0x22188C0 VA: 0x18221A2C0
	public void set_BroadPhaseQueryIndex(int value) { }

	// RVA: 0x2219C00 Offset: 0x2218200 VA: 0x182219C00
	public void Init(FrameBase frame, CharacterController3DConfig config) { }

	// RVA: 0x2219CE0 Offset: 0x22182E0 VA: 0x182219CE0
	public void Init(FrameThreadSafe frame, CharacterController3DConfig config) { }

	// RVA: 0x221A1E0 Offset: 0x22187E0 VA: 0x18221A1E0
	public void SetConfig(FrameThreadSafe frame, CharacterController3DConfig config) { }

	// RVA: 0x2219DC0 Offset: 0x22183C0 VA: 0x182219DC0
	public void Move(FrameThreadSafe frame, EntityRef entity, FPVector3 direction, IKCCCallbacks3D callback, Nullable<int> layerMask, Nullable<bool> useManifoldNormal, Nullable<FP> deltaTime) { }

	// RVA: 0x2219640 Offset: 0x2217C40 VA: 0x182219640
	private void ComputeRawSteer(FrameThreadSafe f, ref CharacterController3DMovement movementPack, FP dt) { }

	// RVA: 0x221A0E0 Offset: 0x22186E0 VA: 0x18221A0E0
	public static void Serialize(void* p, FrameSerializer serializer) { }
}
