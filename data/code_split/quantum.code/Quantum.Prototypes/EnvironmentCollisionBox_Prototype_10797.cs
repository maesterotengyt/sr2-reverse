// Namespace: Quantum.Prototypes
[Prototype(typeof(EnvironmentCollisionBox))]
[Serializable]
public sealed class EnvironmentCollisionBox_Prototype : StructPrototype // TypeDefIndex: 10797
{
	// Fields
	public int PresetID; // 0x10
	public QBoolean RootAsBottom; // 0x14
	public FPVector2 CacheTop; // 0x18
	public FPVector2 CacheBottom; // 0x28
	public FPVector2 CacheLeft; // 0x38
	public FPVector2 CacheRight; // 0x48
	public FPVector2 Top; // 0x58
	public FPVector2 Bottom; // 0x68
	public FPVector2 Left; // 0x78
	public FPVector2 Right; // 0x88
	public RuntimeECBOffset_Prototype TopOffset; // 0x98
	public RuntimeECBOffset_Prototype BottomOffset; // 0xA0
	public RuntimeECBOffset_Prototype LeftOffset; // 0xA8
	public RuntimeECBOffset_Prototype RightOffset; // 0xB0
	public FPVector2 PreviousGlobalCenter; // 0xB8

	// Methods

	// RVA: 0x2104A80 Offset: 0x2103080 VA: 0x182104A80
	public void Materialize(Frame frame, ref EnvironmentCollisionBox result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
