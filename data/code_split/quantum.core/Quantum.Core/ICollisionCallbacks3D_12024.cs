// Namespace: Quantum.Core
public interface ICollisionCallbacks3D // TypeDefIndex: 12024
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision3D(FrameBase f, CollisionInfo3D info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCollisionEnter3D(FrameBase f, CollisionInfo3D info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCollisionExit3D(FrameBase f, ExitInfo3D info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnTrigger3D(FrameBase f, TriggerInfo3D info);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnTriggerEnter3D(FrameBase f, TriggerInfo3D info);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnTriggerExit3D(FrameBase f, ExitInfo3D info);
}
