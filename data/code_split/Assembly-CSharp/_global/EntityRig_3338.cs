// Namespace: 
[Serializable]
public class EntityRig // TypeDefIndex: 3338
{
	// Fields
	public const string ExtraHandsSlotObjectID = "e_hands_slot";
	public const string LeftHandSlotObjectID = "l_hand_slot";
	public const string RightHandSlotObjectID = "r_hand_slot";
	public const string RigRootObjectID = "rigvis";
	public HashString ID; // 0x10
	public GameObject RigRoot; // 0x20
	public EntityObject[] Objects; // 0x28
	public ObjectIDRetarget[] ObjectsIDRetarget; // 0x30
	public string[] ObjectsToIgnore; // 0x38
	public Transform ExtraHandsSlot; // 0x40
	public Transform LeftHandSlot; // 0x48
	public Transform RightHandSlot; // 0x50
	[CompilerGenerated]
	private Dictionary<string, EntityObject> <RigObjectsDict>k__BackingField; // 0x58
	[CompilerGenerated]
	private Dictionary<int, EntityObject> <RigObjectIndexDict>k__BackingField; // 0x60

	// Properties
	public Dictionary<string, EntityObject> RigObjectsDict { get; set; }
	public Dictionary<int, EntityObject> RigObjectIndexDict { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public Dictionary<string, EntityObject> get_RigObjectsDict() { }

	[CompilerGenerated]
	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void set_RigObjectsDict(Dictionary<string, EntityObject> value) { }

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public Dictionary<int, EntityObject> get_RigObjectIndexDict() { }

	[CompilerGenerated]
	// RVA: 0x5B45C0 Offset: 0x5B2BC0 VA: 0x1805B45C0
	public void set_RigObjectIndexDict(Dictionary<int, EntityObject> value) { }

	// RVA: 0x5B4010 Offset: 0x5B2610 VA: 0x1805B4010
	public void SetObjectVisibility(int objectID, bool visibility, int facingDirection) { }

	// RVA: 0x5B3FA0 Offset: 0x5B25A0 VA: 0x1805B3FA0
	public void SetBlendShapeValue(int objectID, int blendShapeHash, float blendShapeValue, int facingDirection) { }

	// RVA: 0x5B3EA0 Offset: 0x5B24A0 VA: 0x1805B3EA0
	public void RestoreDefaultVisibility(int facingDirection) { }

	// RVA: 0x5B3DF0 Offset: 0x5B23F0 VA: 0x1805B3DF0
	public string GetObjectRetargetID(string originalObjectID) { }

	// RVA: 0x5B4070 Offset: 0x5B2670 VA: 0x1805B4070
	private bool TryGetObject(int objectID, out EntityObject entityObject) { }

	// RVA: 0x5B4500 Offset: 0x5B2B00 VA: 0x1805B4500
	public void .ctor() { }
}
