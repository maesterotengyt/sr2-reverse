// Namespace: Quantum
[Serializable]
public struct ColorRGBA : IEquatable<ColorRGBA> // TypeDefIndex: 11785
{
	// Fields
	public byte R; // 0x0
	public byte G; // 0x1
	public byte B; // 0x2
	public byte A; // 0x3
	public const int SIZE = 4;

	// Properties
	public static ColorRGBA Red { get; }
	public static ColorRGBA Blue { get; }
	public static ColorRGBA Gray { get; }
	public static ColorRGBA Cyan { get; }
	public static ColorRGBA White { get; }
	public static ColorRGBA Yellow { get; }
	public static ColorRGBA ColliderGreen { get; }
	public static ColorRGBA ColliderBlue { get; }

	// Methods

	// RVA: 0x2223390 Offset: 0x2221990 VA: 0x182223390
	public static ColorRGBA get_Red() { }

	// RVA: 0x2223340 Offset: 0x2221940 VA: 0x182223340
	public static ColorRGBA get_Blue() { }

	// RVA: 0x2223380 Offset: 0x2221980 VA: 0x182223380
	public static ColorRGBA get_Gray() { }

	// RVA: 0x2223370 Offset: 0x2221970 VA: 0x182223370
	public static ColorRGBA get_Cyan() { }

	// RVA: 0x22233A0 Offset: 0x22219A0 VA: 0x1822233A0
	public static ColorRGBA get_White() { }

	// RVA: 0x22233B0 Offset: 0x22219B0 VA: 0x1822233B0
	public static ColorRGBA get_Yellow() { }

	// RVA: 0x2223360 Offset: 0x2221960 VA: 0x182223360
	public static ColorRGBA get_ColliderGreen() { }

	// RVA: 0x2223350 Offset: 0x2221950 VA: 0x182223350
	public static ColorRGBA get_ColliderBlue() { }

	// RVA: 0x2223330 Offset: 0x2221930 VA: 0x182223330
	public void .ctor(byte r, byte g, byte b) { }

	// RVA: 0x15E6920 Offset: 0x15E4F20 VA: 0x1815E6920
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x2223100 Offset: 0x2221700 VA: 0x182223100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2223060 Offset: 0x2221660 VA: 0x182223060 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2223130 Offset: 0x2221730 VA: 0x182223130 Slot: 3
	public override string ToString() { }

	// RVA: 0x2223030 Offset: 0x2221630 VA: 0x182223030 Slot: 4
	public bool Equals(ColorRGBA other) { }
}
