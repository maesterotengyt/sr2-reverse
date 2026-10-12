// Namespace: 
public class GameEntityObjectsManager : MonoBehaviour // TypeDefIndex: 3335
{
	// Fields
	public const int BakedFramesMaxOffset = 10;
	public EntityRig[] Rigs; // 0x20
	public EntityObject[] CustomObjects; // 0x28
	public EntityProp[] Props; // 0x30
	public EntityJoint[] Joints; // 0x38
	public Transform PropsParent; // 0x40
	public Transform SyncBone; // 0x48
	public Transform ItemSlot; // 0x50
	public Transform GrabSlot; // 0x58
	[CompilerGenerated]
	private Dictionary<int, EntityRig> <RigsIndexDict>k__BackingField; // 0x60
	private List<AttachedProp> activeProps; // 0x68

	// Properties
	public Dictionary<int, EntityRig> RigsIndexDict { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public Dictionary<int, EntityRig> get_RigsIndexDict() { }

	[CompilerGenerated]
	// RVA: 0x5B45C0 Offset: 0x5B2BC0 VA: 0x1805B45C0
	public void set_RigsIndexDict(Dictionary<int, EntityRig> value) { }

	// RVA: 0x5B8070 Offset: 0x5B6670 VA: 0x1805B8070
	private void OnValidate() { }

	// RVA: 0x5B8910 Offset: 0x5B6F10 VA: 0x1805B8910
	public void UpdateRigVisualsFromAnimation(int targetRigID, float time, int facingDirection, AnimationClipData clipData) { }

	// RVA: 0x5B83E0 Offset: 0x5B69E0 VA: 0x1805B83E0
	public void SetObjectVisibility(int rigID, int objectID, bool visibility, int facingDirection = 1) { }

	// RVA: 0x5B82D0 Offset: 0x5B68D0 VA: 0x1805B82D0
	public void SetObjectBlendShapeValue(int rigID, int objectID, int blendShapeHash, float blendShapeValue, int facingDirection = 1) { }

	// RVA: 0x5B84E0 Offset: 0x5B6AE0 VA: 0x1805B84E0
	public void SetRigVisibility(int rigID, bool visibility) { }

	// RVA: 0x5B7BE0 Offset: 0x5B61E0 VA: 0x1805B7BE0
	public void AttachPropToSlot(int rigID, int propID, TargetSlot slot, int facingDirection) { }

	// RVA: 0x5B8830 Offset: 0x5B6E30 VA: 0x1805B8830
	public void UpdateAttachedProps(int facingDirection = 1) { }

	// RVA: 0x5B7F00 Offset: 0x5B6500 VA: 0x1805B7F00
	public void ClearPropSlot(ref EntityProp prop) { }

	// RVA: 0x5B7F40 Offset: 0x5B6540 VA: 0x1805B7F40
	public void ClearPropSlots() { }

	// RVA: 0x5B8130 Offset: 0x5B6730 VA: 0x1805B8130
	public void RestoreObjectsDefaultVisibility(int facingDirection = 1) { }

	// RVA: 0x5B8690 Offset: 0x5B6C90 VA: 0x1805B8690
	private bool TryGetRig(int rigID, out EntityRig entityRig) { }

	// RVA: 0x5B85F0 Offset: 0x5B6BF0 VA: 0x1805B85F0
	private bool TryGetObject(int objectID, out EntityObject entityObject) { }

	// RVA: 0x5B8550 Offset: 0x5B6B50 VA: 0x1805B8550
	public bool TryGetJoint(int jointID, out EntityJoint joint) { }

	// RVA: 0x5B8070 Offset: 0x5B6670 VA: 0x1805B8070
	private void RefreshObjectsHash() { }

	// RVA: 0x5B8B80 Offset: 0x5B7180 VA: 0x1805B8B80
	public void .ctor() { }
}
