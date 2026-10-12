// Namespace: Quantum
[Usage(256)]
public class InspectorButtonAttribute : PropertyAttribute // TypeDefIndex: 3822
{
	// Fields
	public string Method; // 0x18
	public string Label; // 0x20
	public bool IsToggleable; // 0x28

	// Methods

	// RVA: 0x65BA60 Offset: 0x65A060 VA: 0x18065BA60
	public void .ctor(string method) { }

	// RVA: 0x64D4A0 Offset: 0x64BAA0 VA: 0x18064D4A0
	public void .ctor(string method, string label) { }

	// RVA: 0x65BAB0 Offset: 0x65A0B0 VA: 0x18065BAB0
	public void .ctor(string method, bool isToggleable) { }

	// RVA: 0x65BB00 Offset: 0x65A100 VA: 0x18065BB00
	public void .ctor(string method, string label, bool isToggleable) { }
}
