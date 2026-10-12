// Namespace: Quantum
public class MemoryLayoutVerifier // TypeDefIndex: 11792
{
	// Fields
	public static MemoryLayoutVerifier.IPlatform Platform; // 0x0
	private Dictionary<Type, int> _validPrimitives; // 0x10
	private ReadOnlyDictionary<Type, int> _typeRegistryTypes; // 0x18
	private MemoryLayoutVerifier.IPlatform _platform; // 0x20

	// Methods

	// RVA: 0x2226A80 Offset: 0x2225080 VA: 0x182226A80
	public void .ctor(MemoryLayoutVerifier.IPlatform platform) { }

	// RVA: 0x22265E0 Offset: 0x2224BE0 VA: 0x1822265E0
	public List<string> Verify(ReadOnlyDictionary<Type, int> types) { }

	// RVA: 0x2226320 Offset: 0x2224920 VA: 0x182226320
	private void VerifyTypeSize(Type type, int expected) { }

	// RVA: 0x2225E00 Offset: 0x2224400 VA: 0x182225E00
	private void VerifyTypeLayout(Type type) { }

	// RVA: 0x2225630 Offset: 0x2223C30 VA: 0x182225630
	private int GetFieldSize(FieldInfo field) { }

	// RVA: 0x2225850 Offset: 0x2223E50 VA: 0x182225850
	private int GetPrimitiveSize(Type type) { }

	// RVA: 0x22258D0 Offset: 0x2223ED0 VA: 0x1822258D0
	public static bool IsFixedBuffer(FieldInfo field) { }

	// RVA: 0x2225370 Offset: 0x2223970 VA: 0x182225370
	public static int GetFieldOffset(FieldInfo field) { }

	// RVA: 0x2225520 Offset: 0x2223B20 VA: 0x182225520
	public static Nullable<int> GetFieldOverlap(FieldInfo field) { }

	// RVA: 0x2225960 Offset: 0x2223F60 VA: 0x182225960
	private static void ThrowNonSupportedPrimitive(Type type) { }

	[CompilerGenerated]
	// RVA: 0x22259D0 Offset: 0x2223FD0 VA: 0x1822259D0
	private MemoryLayoutVerifier.FieldData <VerifyTypeLayout>b__10_0(FieldInfo x) { }
}
