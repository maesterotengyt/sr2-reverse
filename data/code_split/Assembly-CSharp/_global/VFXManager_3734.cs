// Namespace: 
public class VFXManager : MonoBehaviour // TypeDefIndex: 3734
{
	// Fields
	public VFXEntry[] VFXEntries; // 0x20
	[CompilerGenerated]
	private EntityView <Entity>k__BackingField; // 0x28
	private bool initialized; // 0x30

	// Properties
	public EntityView Entity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public EntityView get_Entity() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_Entity(EntityView value) { }

	// RVA: 0x654650 Offset: 0x652C50 VA: 0x180654650
	private void Awake() { }

	// RVA: 0x654650 Offset: 0x652C50 VA: 0x180654650
	public void Initialize() { }

	// RVA: 0x654800 Offset: 0x652E00 VA: 0x180654800
	private void OnPlayVFX(EventPlayVFX callback) { }

	// RVA: 0x654AE0 Offset: 0x6530E0 VA: 0x180654AE0
	private void OnStopVFX(EventStopVFX callback) { }

	// RVA: 0x6549D0 Offset: 0x652FD0 VA: 0x1806549D0
	private void OnStopAllVFX(EventStopAllVFX callback) { }

	// RVA: 0x654C20 Offset: 0x653220 VA: 0x180654C20
	public bool TryFindEntry(int vfxID, out VFXEntry vfxEntry) { }

	// RVA: 0x654CB0 Offset: 0x6532B0 VA: 0x180654CB0
	public void .ctor() { }
}
