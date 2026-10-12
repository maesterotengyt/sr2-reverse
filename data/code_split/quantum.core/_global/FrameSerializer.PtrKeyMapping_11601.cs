// Namespace: 
private class FrameSerializer.PtrKeyMapping // TypeDefIndex: 11601
{
	// Fields
	private int _keyCounter; // 0x10
	private readonly Dictionary<Ptr, FrameSerializer.PtrKey> _ptrToKey; // 0x18
	private readonly Dictionary<FrameSerializer.PtrKey, Ptr> _keyToPtr; // 0x20
	private readonly HashSet<FrameSerializer.PtrKey> _keysResolved; // 0x28
	private readonly Dictionary<FrameSerializer.PtrKey, List<FrameSerializer.PtrLocation>> _keysUnresolved; // 0x30

	// Methods

	// RVA: 0x21D7F50 Offset: 0x21D6550 VA: 0x1821D7F50
	public void .ctor() { }

	// RVA: 0x21D7C20 Offset: 0x21D6220 VA: 0x1821D7C20
	public void VerifyAllKeysResolved() { }

	// RVA: 0x21D7520 Offset: 0x21D5B20 VA: 0x1821D7520
	public FrameSerializer.PtrKey NextKey() { }

	// RVA: 0x21D72E0 Offset: 0x21D58E0 VA: 0x1821D72E0
	public void AddMapping(FrameSerializer.PtrKey key, Ptr ptr) { }

	// RVA: 0x21D7BB0 Offset: 0x21D61B0 VA: 0x1821D7BB0
	public bool TryGetPtr(FrameSerializer.PtrKey key, out Ptr ptr) { }

	// RVA: 0x21D7B40 Offset: 0x21D6140 VA: 0x1821D7B40
	public bool TryGetKey(Ptr ptr, out FrameSerializer.PtrKey key) { }

	// RVA: 0x21D7530 Offset: 0x21D5B30 VA: 0x1821D7530
	public void Reset() { }

	// RVA: 0x21D7E70 Offset: 0x21D6470 VA: 0x1821D7E70
	public void VerifyKeyResolved(FrameSerializer.PtrKey key) { }

	// RVA: 0x21D7610 Offset: 0x21D5C10 VA: 0x1821D7610
	public Ptr ResolveKey(FrameSerializer.PtrKey key) { }

	// RVA: 0x21D74C0 Offset: 0x21D5AC0 VA: 0x1821D74C0
	public bool IsKeyResolved(FrameSerializer.PtrKey key) { }

	// RVA: 0x21D7370 Offset: 0x21D5970 VA: 0x1821D7370
	public void AddUnresolved(FrameSerializer.PtrKey key, Ptr* location) { }
}
