// Namespace: Quantum
public struct ItemAutoTrigger : IComponent // TypeDefIndex: 10002
{
	// Fields
	[HideInInspector]
	public EntityRef Entity; // 0x8
	public QString64 ItemToUse; // 0x18
	[HideInInspector]
	public FP RemainingFramesToUseItem; // 0x10
	public int UseFramesInterval; // 0x0

	// Methods

	// RVA: 0x211F020 Offset: 0x211D620 VA: 0x18211F020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211F100 Offset: 0x211D700 VA: 0x18211F100
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211F080 Offset: 0x211D680 VA: 0x18211F080
	public void Init(Frame frame, EntityRef entity) { }

	// RVA: 0x211F190 Offset: 0x211D790 VA: 0x18211F190
	public void Update(Frame frame) { }
}
