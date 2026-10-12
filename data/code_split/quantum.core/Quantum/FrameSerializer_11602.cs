// Namespace: Quantum
public class FrameSerializer : IDeterministicFrameSerializer // TypeDefIndex: 11602
{
	// Fields
	private const int NULL_PTR_KEY = -1;
	private const int NULL_PTR_OFFSET = 0;
	private bool _inputMode; // 0x10
	private bool _checksum; // 0x11
	private FrameBase _frame; // 0x18
	private readonly FrameSerializer.PtrKeyMapping _mapping; // 0x20
	public readonly IBitStream Stream; // 0x28
	public readonly DeterministicFrameSerializeMode Mode; // 0x30

	// Properties
	public FrameBase Frame { get; set; }
	public bool Writing { get; set; }
	public bool Reading { get; set; }
	public bool InputMode { get; set; }
	private bool Photon.Deterministic.IDeterministicFrameSerializer.Writing { get; }
	private bool Photon.Deterministic.IDeterministicFrameSerializer.Reading { get; }
	private IBitStream Photon.Deterministic.IDeterministicFrameSerializer.Stream { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public FrameBase get_Frame() { }

	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	public void set_Frame(FrameBase value) { }

	// RVA: 0x21D2040 Offset: 0x21D0640 VA: 0x1821D2040
	public bool get_Writing() { }

	// RVA: 0x21D3010 Offset: 0x21D1610 VA: 0x1821D3010
	public void set_Writing(bool value) { }

	// RVA: 0x21D1FF0 Offset: 0x21D05F0 VA: 0x1821D1FF0
	public bool get_Reading() { }

	// RVA: 0x21D2FB0 Offset: 0x21D15B0 VA: 0x1821D2FB0
	public void set_Reading(bool value) { }

	// RVA: 0x537B50 Offset: 0x536150 VA: 0x180537B50
	public bool get_InputMode() { }

	// RVA: 0x667A30 Offset: 0x666030 VA: 0x180667A30
	public void set_InputMode(bool value) { }

	// RVA: 0x21D2C10 Offset: 0x21D1210 VA: 0x1821D2C10
	public void VerifyNoUnresolvedPointers() { }

	// RVA: 0x21D2D50 Offset: 0x21D1350 VA: 0x1821D2D50
	private void .ctor() { }

	// RVA: 0x21D2CC0 Offset: 0x21D12C0 VA: 0x1821D2CC0
	public void .ctor(DeterministicFrameSerializeMode mode, FrameBase frame, byte[] data) { }

	// RVA: 0x21D2C30 Offset: 0x21D1230 VA: 0x1821D2C30
	public void .ctor(DeterministicFrameSerializeMode mode, FrameBase frame, int size) { }

	// RVA: 0x21D2F00 Offset: 0x21D1500 VA: 0x1821D2F00
	public void .ctor(DeterministicFrameSerializeMode mode, FrameBase frame, IBitStream stream) { }

	// RVA: 0x21D1F20 Offset: 0x21D0520 VA: 0x1821D1F20
	public void CopyFromArray(byte[] data) { }

	// RVA: 0x21D2B50 Offset: 0x21D1150 VA: 0x1821D2B50
	public byte[] ToArray() { }

	// RVA: 0x21D2AF0 Offset: 0x21D10F0 VA: 0x1821D2AF0
	public void Reset() { }

	// RVA: 0x21D2090 Offset: 0x21D0690 VA: 0x1821D2090
	public void* PointerResolve(FrameSerializer.PtrKey key, int size) { }

	// RVA: 0x21D2370 Offset: 0x21D0970 VA: 0x1821D2370
	public void* PointerResolve(FrameSerializer.PtrKey key, Ptr ptr) { }

	// RVA: 0x21D26B0 Offset: 0x21D0CB0 VA: 0x1821D26B0
	public bool PointerSerialize(Ptr* p, out FrameSerializer.PtrKey key) { }

	// RVA: 0x21D2AC0 Offset: 0x21D10C0 VA: 0x1821D2AC0
	public FrameSerializer.PtrKey PointerSerialize(Ptr* p) { }

	// RVA: 0x21D2610 Offset: 0x21D0C10 VA: 0x1821D2610
	public bool PointerSerializeVoid(void* ptr) { }

	// RVA: 0x21D2040 Offset: 0x21D0640 VA: 0x1821D2040 Slot: 4
	private bool Photon.Deterministic.IDeterministicFrameSerializer.get_Writing() { }

	// RVA: 0x21D1FF0 Offset: 0x21D05F0 VA: 0x1821D1FF0 Slot: 5
	private bool Photon.Deterministic.IDeterministicFrameSerializer.get_Reading() { }

	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0 Slot: 6
	private IBitStream Photon.Deterministic.IDeterministicFrameSerializer.get_Stream() { }
}
