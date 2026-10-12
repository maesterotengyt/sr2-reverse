// Namespace: 
public struct FrameContext.Args // TypeDefIndex: 12018
{
	// Fields
	public AssetDB AssetDatabase; // 0x0
	public DeterministicPlatformInfo PlatformInfo; // 0x8
	public Func<int, bool> IsLocalPlayer; // 0x10
	public bool IsServer; // 0x18
	public Navigation.Config NavigationConfig; // 0x20
	public PhysicsCommon.Config PhysicsConfig; // 0x28
	public DeterministicCommandSerializer CommandSerializer; // 0x30
	public IAssetSerializer AssetSerializer; // 0x38
	public DynamicAssetDB InitialDynamicAssets; // 0x40
	public Heap.Config HeapConfig; // 0x48
	public HeapTrackingMode HeapTrackingMode; // 0x68
	public bool UseCullingArea; // 0x69
	public bool UsePhysics2D; // 0x6A
	public bool UsePhysics3D; // 0x6B
	public bool UseNavigation; // 0x6C
	public bool UseSharedChecksumSerialized; // 0x6D
}
