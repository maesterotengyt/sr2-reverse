// Namespace: Quantum
[Serializable]
public struct HashString // TypeDefIndex: 10448
{
	// Fields
	public string Value; // 0x0
	public int Hash; // 0x8

	// Methods

	// RVA: 0x21B7F10 Offset: 0x21B6510 VA: 0x1821B7F10
	public void .ctor(string value) { }

	// RVA: 0x21B79B0 Offset: 0x21B5FB0 VA: 0x1821B79B0
	public void GenerateHash() { }

	// RVA: 0x6AB600 Offset: 0x6A9C00 VA: 0x1806AB600 Slot: 3
	public override string ToString() { }

	// RVA: 0x21B7F40 Offset: 0x21B6540 VA: 0x1821B7F40
	public static bool op_Equality(HashString hashString1, HashString hashString2) { }

	// RVA: 0x21B7F80 Offset: 0x21B6580 VA: 0x1821B7F80
	public static bool op_Equality(int intValue, HashString hashString) { }

	// RVA: 0x21B7F90 Offset: 0x21B6590 VA: 0x1821B7F90
	public static bool op_Equality(HashString hashString, int intValue) { }

	// RVA: 0x21B7F50 Offset: 0x21B6550 VA: 0x1821B7F50
	public static bool op_Equality(string stringtValue, HashString hashString) { }

	// RVA: 0x21B7F60 Offset: 0x21B6560 VA: 0x1821B7F60
	public static bool op_Equality(HashString hashString, string stringtValue) { }

	// RVA: 0x21B8000 Offset: 0x21B6600 VA: 0x1821B8000
	public static bool op_Inequality(HashString hashString1, HashString hashString2) { }

	// RVA: 0x21B7FF0 Offset: 0x21B65F0 VA: 0x1821B7FF0
	public static bool op_Inequality(int intValue, HashString hashString) { }

	// RVA: 0x21B7FA0 Offset: 0x21B65A0 VA: 0x1821B7FA0
	public static bool op_Inequality(HashString hashString, int intValue) { }

	// RVA: 0x21B7FB0 Offset: 0x21B65B0 VA: 0x1821B7FB0
	public static bool op_Inequality(string stringtValue, HashString hashString) { }

	// RVA: 0x21B7FD0 Offset: 0x21B65D0 VA: 0x1821B7FD0
	public static bool op_Inequality(HashString hashString, string stringtValue) { }

	// RVA: 0x21B7920 Offset: 0x21B5F20 VA: 0x1821B7920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21B7AC0 Offset: 0x21B60C0 VA: 0x1821B7AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1349850 Offset: 0x1347E50 VA: 0x181349850
	public bool IsEmpty() { }

	// RVA: 0x21B7AD0 Offset: 0x21B60D0 VA: 0x1821B7AD0
	public static HashString GetHashStringFromList(List<HashString> list, int hash) { }

	// RVA: 0x21B7CB0 Offset: 0x21B62B0 VA: 0x1821B7CB0
	public static string GetValueFromList(List<HashString> list, int hash) { }

	// RVA: 0x21B7E60 Offset: 0x21B6460 VA: 0x1821B7E60
	public static int StringToHash(string key, uint seed = 0) { }
}
