// Namespace: Quantum.Core
public class PhysicsSystem2D : SystemBase, ICollisionCallbacks2D // TypeDefIndex: 10703
{
	// Methods

	// RVA: 0x210B700 Offset: 0x2109D00 VA: 0x18210B700 Slot: 7
	public override void OnInit(Frame f) { }

	// RVA: 0x210B970 Offset: 0x2109F70 VA: 0x18210B970 Slot: 9
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x210B500 Offset: 0x2109B00 VA: 0x18210B500 Slot: 10
	public void OnCollision2D(FrameBase f, CollisionInfo2D info) { }

	// RVA: 0x210B5B0 Offset: 0x2109BB0 VA: 0x18210B5B0 Slot: 11
	public void OnCollisionEnter2D(FrameBase f, CollisionInfo2D info) { }

	// RVA: 0x210B660 Offset: 0x2109C60 VA: 0x18210B660 Slot: 12
	public void OnCollisionExit2D(FrameBase f, ExitInfo2D info) { }

	// RVA: 0x210B770 Offset: 0x2109D70 VA: 0x18210B770 Slot: 13
	public void OnTrigger2D(FrameBase f, TriggerInfo2D info) { }

	// RVA: 0x210B820 Offset: 0x2109E20 VA: 0x18210B820 Slot: 14
	public void OnTriggerEnter2D(FrameBase f, TriggerInfo2D info) { }

	// RVA: 0x210B8D0 Offset: 0x2109ED0 VA: 0x18210B8D0 Slot: 15
	public void OnTriggerExit2D(FrameBase f, ExitInfo2D info) { }

	// RVA: 0x21012E0 Offset: 0x20FF8E0 VA: 0x1821012E0
	public void .ctor() { }
}
