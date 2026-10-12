// Namespace: Quantum
[Serializable]
public struct SimpleAABB : IEquatable<SimpleAABB> // TypeDefIndex: 9942
{
	// Fields
	public const int SIZE = 32;
	public const int ALIGNMENT = 8;
	public FPVector2 BottomRight; // 0x0
	public FPVector2 TopLeft; // 0x10
	public static readonly SimpleAABB Default; // 0x0

	// Properties
	public FPVector2 TopRight { get; }
	public FPVector2 BottomLeft { get; }
	public FP Width { get; }
	public FP Height { get; }
	public FPVector2 Center { get; }
	public FPVector2 Top { get; }
	public FPVector2 Right { get; }
	public FPVector2 Left { get; }

	// Methods

	// RVA: 0x20D2800 Offset: 0x20D0E00 VA: 0x1820D2800 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CD180 Offset: 0x20CB780 VA: 0x1820CD180
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D2C70 Offset: 0x20D1270 VA: 0x1820D2C70
	public FPVector2 get_TopRight() { }

	// RVA: 0x20D2A90 Offset: 0x20D1090 VA: 0x1820D2A90
	public FPVector2 get_BottomLeft() { }

	// RVA: 0x20D2D50 Offset: 0x20D1350 VA: 0x1820D2D50
	public FP get_Width() { }

	// RVA: 0x20D2B00 Offset: 0x20D1100 VA: 0x1820D2B00
	public FP get_Height() { }

	// RVA: 0x20D2AC0 Offset: 0x20D10C0 VA: 0x1820D2AC0
	public FPVector2 get_Center() { }

	// RVA: 0x20D2CA0 Offset: 0x20D12A0 VA: 0x1820D2CA0
	public FPVector2 get_Top() { }

	// RVA: 0x20D2BC0 Offset: 0x20D11C0 VA: 0x1820D2BC0
	public FPVector2 get_Right() { }

	// RVA: 0x20D2B10 Offset: 0x20D1110 VA: 0x1820D2B10
	public FPVector2 get_Left() { }

	// RVA: 0x20D2970 Offset: 0x20D0F70 VA: 0x1820D2970 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D25F0 Offset: 0x20D0BF0 VA: 0x1820D25F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20D2780 Offset: 0x20D0D80 VA: 0x1820D2780 Slot: 4
	public bool Equals(SimpleAABB other) { }

	// RVA: 0x20D2D60 Offset: 0x20D1360 VA: 0x1820D2D60
	public static bool op_Equality(SimpleAABB lhs, SimpleAABB rhs) { }

	// RVA: 0x20D2A60 Offset: 0x20D1060 VA: 0x1820D2A60
	public void .ctor(FP toply, FP botry, FP toplx, FP botrx) { }

	// RVA: 0x20D2A80 Offset: 0x20D1080 VA: 0x1820D2A80
	public void .ctor(FPVector2 toplv, FPVector2 botrv) { }

	// RVA: 0x20D2840 Offset: 0x20D0E40 VA: 0x1820D2840
	public void Include(FPVector2 pt) { }

	// RVA: 0x20D28C0 Offset: 0x20D0EC0 VA: 0x1820D28C0
	public bool Intersects(SimpleAABB other) { }

	// RVA: 0x20D2890 Offset: 0x20D0E90 VA: 0x1820D2890
	public bool Inside(FPVector2 pt) { }

	// RVA: 0x20D2A00 Offset: 0x20D1000 VA: 0x1820D2A00
	private static void .cctor() { }
}
