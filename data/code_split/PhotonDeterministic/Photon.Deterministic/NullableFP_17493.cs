// Namespace: Photon.Deterministic
[Serializable]
public struct NullableFP // TypeDefIndex: 17493
{
	// Fields
	public const int SIZE = 16;
	public long _hasValue; // 0x0
	public FP _value; // 0x8

	// Properties
	public bool HasValue { get; }
	public FP Value { get; }

	// Methods

	// RVA: 0x20AAF70 Offset: 0x20A9570 VA: 0x1820AAF70
	public bool get_HasValue() { }

	// RVA: 0x20BF220 Offset: 0x20BD820 VA: 0x1820BF220
	public FP get_Value() { }

	// RVA: 0x20BF210 Offset: 0x20BD810 VA: 0x1820BF210
	public FP ValueOrDefault(FP v) { }

	// RVA: 0x20BF280 Offset: 0x20BD880 VA: 0x1820BF280
	public static NullableFP op_Implicit(FP v) { }

	// RVA: 0x20BF1F0 Offset: 0x20BD7F0 VA: 0x1820BF1F0 Slot: 2
	public override int GetHashCode() { }
}
