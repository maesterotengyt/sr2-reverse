// Namespace: Quantum.Inspector
[Usage(256, AllowMultiple = True)]
public class DrawIfAttribute : PropertyAttribute // TypeDefIndex: 11992
{
	// Fields
	public readonly string FieldName; // 0x10
	public readonly long Value; // 0x18
	public readonly DrawIfHideType Hide; // 0x20
	public readonly DrawIfCompareOperator Compare; // 0x24

	// Methods

	// RVA: 0x2208C80 Offset: 0x2207280 VA: 0x182208C80
	public void .ctor(string fieldName, long value, DrawIfCompareOperator compare = 0, DrawIfHideType hide = 2) { }
}
