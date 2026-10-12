// Namespace: Photon.Deterministic
[Serializable]
public struct NullableNonNegativeFP // TypeDefIndex: 17434
{
	// Fields
	public const int SIZE = 8;
	public ulong _value; // 0x0
	private const ulong HasValueBit = 9223372036854775808;
	private const ulong ValueMask = 9223372036854775807;

	// Properties
	public bool HasValue { get; }
	public FP Value { get; }

	// Methods

	// RVA: 0x20AB230 Offset: 0x20A9830 VA: 0x1820AB230
	public bool get_HasValue() { }

	// RVA: 0x20A08E0 Offset: 0x209EEE0 VA: 0x1820A08E0
	public FP get_Value() { }

	// RVA: 0x20AB210 Offset: 0x20A9810 VA: 0x1820AB210
	public FP ValueOrDefault() { }

	// RVA: 0x20AB250 Offset: 0x20A9850 VA: 0x1820AB250
	public static NullableNonNegativeFP op_Implicit(FP v) { }

	// RVA: 0x20AB050 Offset: 0x20A9650 VA: 0x1820AB050
	public static void Serialize(NullableNonNegativeFP* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x20AB150 Offset: 0x20A9750 VA: 0x1820AB150 Slot: 3
	public override string ToString() { }

	// RVA: 0x20AB010 Offset: 0x20A9610 VA: 0x1820AB010 Slot: 2
	public override int GetHashCode() { }
}
