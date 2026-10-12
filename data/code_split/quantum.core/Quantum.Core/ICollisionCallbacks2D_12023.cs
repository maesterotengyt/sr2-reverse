// Namespace: Quantum.Core
public interface ICollisionCallbacks2D // TypeDefIndex: 12023
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision2D(FrameBase f, CollisionInfo2D info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCollisionEnter2D(FrameBase f, CollisionInfo2D info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCollisionExit2D(FrameBase f, ExitInfo2D info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnTrigger2D(FrameBase f, TriggerInfo2D info);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnTriggerEnter2D(FrameBase f, TriggerInfo2D info);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnTriggerExit2D(FrameBase f, ExitInfo2D info);
}
