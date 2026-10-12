// Namespace: Photon.Deterministic
public class NetworkInputProvider : IDeterministicInputProvider // TypeDefIndex: 17478
{
	// Fields
	private IDeterministicGame _game; // 0x10

	// Methods

	// RVA: 0x670A70 Offset: 0x66F070 VA: 0x180670A70
	public void .ctor(IDeterministicGame game) { }

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 4
	public bool CanSimulate(int frame) { }

	// RVA: 0x20BF160 Offset: 0x20BD760 VA: 0x1820BF160 Slot: 5
	public DeterministicFrameInputTemp GetInput(int frame, int player) { }
}
