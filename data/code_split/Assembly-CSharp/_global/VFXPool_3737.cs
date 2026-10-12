// Namespace: 
public class VFXPool : MonoBehaviour // TypeDefIndex: 3737
{
	// Fields
	[ReadOnlyField]
	public HashString ID; // 0x20
	[ReadOnlyField]
	public VFXObject[] VFXObjects; // 0x30
	private int currentVFXIndex; // 0x38

	// Methods

	// RVA: 0x655820 Offset: 0x653E20 VA: 0x180655820
	public void Play(EntityRef entity, VFXPlayAttributes playAttributes) { }

	// RVA: 0x655900 Offset: 0x653F00 VA: 0x180655900
	public void Stop(int entityIndex, VFXStopAttributes stopAttributes) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
