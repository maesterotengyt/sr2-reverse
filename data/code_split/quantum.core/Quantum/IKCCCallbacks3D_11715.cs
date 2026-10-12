// Namespace: Quantum
public interface IKCCCallbacks3D // TypeDefIndex: 11715
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool OnCharacterCollision3D(FrameBase f, EntityRef character, Hit3D hit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCharacterTrigger3D(FrameBase f, EntityRef character, Hit3D hit);
}
