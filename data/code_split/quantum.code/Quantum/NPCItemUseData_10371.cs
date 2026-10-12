// Namespace: Quantum
[Serializable]
public class NPCItemUseData // TypeDefIndex: 10371
{
	// Fields
	[Tooltip("The ID of the difficulty")]
	public HashString ID; // 0x10
	[Tooltip("Minimun use time between activations")]
	public FP UseCooldownFrame; // 0x20
	[Tooltip("The min distance from the target to that you can use the item , -1 for disable")]
	[Header("Distance Variables")]
	public int MinGeneralDistance; // 0x28
	[Tooltip("The min distance from the target to that you can use the item, -1 for disable")]
	public int MaxGeneralDistance; // 0x2C
	[Tooltip("The max distance from the target to that you can use the items on the X axis, -1 for disable")]
	public int MaxXUseDistance; // 0x30
	[Tooltip("The min distance from the target to that you can use the item on the X axis, -1 for disable")]
	public int MinXUseDistance; // 0x34
	[Tooltip("The max distance from the target to that you can use the item on the Y axis, -1 for disable")]
	public int MaxYUseDistance; // 0x38
	[Tooltip("The min distance from the target to that you can use the item on the Y axis, -1 for disable")]
	public int MinYUseDistance; // 0x3C
	[Tooltip("If the line of sight its needed")]
	public bool NeedsLineOfSight; // 0x40
	[Tooltip("For items that can't be use close to a wall")]
	public bool NeedsSpaceToFire; // 0x41
	[DrawIf("NeedsSpaceToFire", 1, 0, 3)]
	public int SpaceAmount; // 0x44
	[Tooltip("The required direction for the target")]
	public TargetDirection TargetDirectionUse; // 0x48

	// Methods

	// RVA: 0x21909B0 Offset: 0x218EFB0 VA: 0x1821909B0
	public void .ctor() { }
}
