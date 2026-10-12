// Namespace: 
public abstract class StellarCamera : StellarMonoBehaviour // TypeDefIndex: 3279
{
	// Fields
	public HashString ID; // 0x20
	public CinemachineVirtualCamera VirtualCamera; // 0x30
	public GlobalCameraSettingsDataAsset GlobalData; // 0x38
	public CinemachineImpulseSource ImpulseSource; // 0x40
	[CompilerGenerated]
	private SimpleAABB <CameraView>k__BackingField; // 0x48
	[CompilerGenerated]
	private CameraManagerData <CameraData>k__BackingField; // 0x68

	// Properties
	public SimpleAABB CameraView { get; set; }
	public CameraManagerData CameraData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5A5160 Offset: 0x5A3760 VA: 0x1805A5160
	public SimpleAABB get_CameraView() { }

	[CompilerGenerated]
	// RVA: 0x5A5180 Offset: 0x5A3780 VA: 0x1805A5180
	public void set_CameraView(SimpleAABB value) { }

	[CompilerGenerated]
	// RVA: 0x5A5150 Offset: 0x5A3750 VA: 0x1805A5150
	public CameraManagerData get_CameraData() { }

	[CompilerGenerated]
	// RVA: 0x54C4A0 Offset: 0x54AAA0 VA: 0x18054C4A0
	public void set_CameraData(CameraManagerData value) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void Init() { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 5
	public virtual bool HandleCameraViewLocally() { }

	// RVA: 0x5A4910 Offset: 0x5A2F10 VA: 0x1805A4910 Slot: 6
	public virtual void AdjustToCameraView() { }

	// RVA: 0x5A4F10 Offset: 0x5A3510 VA: 0x1805A4F10 Slot: 7
	protected virtual void OnCameraUpdateForced(EventOnCameraUpdateForced callback) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	protected void .ctor() { }
}
