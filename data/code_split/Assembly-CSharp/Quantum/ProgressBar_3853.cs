// Namespace: Quantum
public class ProgressBar : IDisposable // TypeDefIndex: 3853
{
	// Fields
	private float _progress; // 0x10
	private string _info; // 0x18
	private string _title; // 0x20
	private bool _isCancelable; // 0x28
	private Stopwatch _sw; // 0x30

	// Properties
	public string Info { set; }
	public float Progress { get; set; }

	// Methods

	// RVA: 0x6664A0 Offset: 0x664AA0 VA: 0x1806664A0
	public void .ctor(string title, bool isCancelable = False, bool logStopwatch = False) { }

	// RVA: 0x666540 Offset: 0x664B40 VA: 0x180666540
	public void set_Info(string value) { }

	// RVA: 0x666710 Offset: 0x664D10 VA: 0x180666710
	public void set_Progress(float value) { }

	// RVA: 0x666530 Offset: 0x664B30 VA: 0x180666530
	public float get_Progress() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public void Dispose() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void Display() { }

	// RVA: 0x6662F0 Offset: 0x6648F0 VA: 0x1806662F0
	private void DisplayStopwatch() { }
}
