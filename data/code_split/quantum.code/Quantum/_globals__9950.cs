// Namespace: Quantum
public struct _globals_ // TypeDefIndex: 9950
{
	// Fields
	public const int SIZE = 656;
	public const int ALIGNMENT = 8;
	public FP DeltaTime; // 0x20
	public QBoolean FrameByFrameActive; // 0x0
	public FrameMetaData FrameMetaData; // 0xC0
	public QBoolean LoadingFinished; // 0x4
	public EntityRef ManagersEntity; // 0x18
	public AssetRefMap Map; // 0x8
	public NavMeshRegionMask NavMeshRegions; // 0x88
	public PhysicsSceneSettings PhysicsSettings; // 0x168
	public PhysicsEngineState PhysicsState2D; // 0x90
	public PhysicsEngineState PhysicsState3D; // 0xA0
	public BitSet12 PlayerLastConnectionState; // 0x10
	public RNGSession RngSession; // 0xB0
	public BitSet1024 Systems; // 0xE8
	[FixedBuffer(typeof(byte), 96)]
	[FixedArray(typeof(Input), 12)]
	private _globals_.<_input_>e__FixedBuffer _input_; // 0x28

	// Properties
	public FixedArray<Input> input { get; }

	// Methods

	// RVA: 0x20D3930 Offset: 0x20D1F30 VA: 0x1820D3930
	public FixedArray<Input> get_input() { }

	// RVA: 0x20D3300 Offset: 0x20D1900 VA: 0x1820D3300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D3690 Offset: 0x20D1C90 VA: 0x1820D3690
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
