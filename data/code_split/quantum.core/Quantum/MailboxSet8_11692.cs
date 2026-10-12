// Namespace: Quantum
public class MailboxSet8 // TypeDefIndex: 11692
{
	// Fields
	private byte _key; // 0x10
	private byte* _set; // 0x18
	private int _capacity; // 0x20

	// Properties
	public int Capacity { get; }

	// Methods

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_Capacity() { }

	// RVA: 0x221BB50 Offset: 0x221A150 VA: 0x18221BB50
	public void .ctor(int capacity, Native.Allocator allocator) { }

	// RVA: 0x221B9E0 Offset: 0x2219FE0 VA: 0x18221B9E0
	public void Dispose(Native.Allocator allocator) { }

	// RVA: 0x221BA30 Offset: 0x221A030 VA: 0x18221BA30
	public void SetCapactiy(int capacity, Native.Allocator allocator) { }

	// RVA: 0x221BAD0 Offset: 0x221A0D0 VA: 0x18221BAD0
	public void StartSearch() { }

	// RVA: 0x221B9C0 Offset: 0x2219FC0 VA: 0x18221B9C0
	public bool AlreadyChecked(int index) { }

	// RVA: 0x221BAB0 Offset: 0x221A0B0 VA: 0x18221BAB0
	public bool ShouldCheck(int index) { }
}
