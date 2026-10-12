// Namespace: 
public class GameCubeController : StellarController // TypeDefIndex: 3437
{
	// Fields
	public int StateIndex; // 0x80
	private GameCubeAdapterState previousState; // 0x88
	private float stickDeadzone; // 0x90
	private float triggersDeadzone; // 0x94

	// Methods

	// RVA: 0x5E5F40 Offset: 0x5E4540 VA: 0x1805E5F40
	public void .ctor() { }

	// RVA: 0x5E5460 Offset: 0x5E3A60 VA: 0x1805E5460 Slot: 6
	public override void PollInputs() { }

	// RVA: 0x5E5370 Offset: 0x5E3970 VA: 0x1805E5370
	private GameCubeAdapterState CopyState(GameCubeAdapterState state) { }
}
