// Namespace: 
public class BreakableGlassManager : MonoBehaviour // TypeDefIndex: 2624
{
	// Fields
	public float Size; // 0x20
	public float Rotation; // 0x24
	[Space(10)]
	public float VelocityToBreak; // 0x28
	public bool IsRestorable; // 0x2C
	public int FramesToRestore; // 0x30
	[Space(10)]
	public GameObject GlassObject; // 0x38
	private EntityPrototype entityPrototype; // 0x40
	private EntityComponentTriggerPolygonShape triggerPolygonShape; // 0x48
	private EntityComponentBreakableGlass breakableGlass; // 0x50

	// Methods

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
