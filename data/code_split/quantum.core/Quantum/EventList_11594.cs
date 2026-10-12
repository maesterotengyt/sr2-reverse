// Namespace: Quantum
public class EventList // TypeDefIndex: 11594
{
	// Fields
	private int _count; // 0x10
	private int _version; // 0x14
	private EventBase _head; // 0x18

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_Count() { }

	// RVA: 0x21CDA90 Offset: 0x21CC090 VA: 0x1821CDA90
	public EventBase PopHead() { }

	// RVA: 0x21CD980 Offset: 0x21CBF80 VA: 0x1821CD980
	public void AddLast(EventBase item) { }

	// RVA: 0x21CDB70 Offset: 0x21CC170 VA: 0x1821CDB70
	public void Remove(EventBase item) { }

	// RVA: 0x21CD910 Offset: 0x21CBF10 VA: 0x1821CD910
	private void AddEmpty(EventBase item) { }

	// RVA: 0x21CD860 Offset: 0x21CBE60 VA: 0x1821CD860
	private void AddBefore(EventBase item, EventBase before) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
