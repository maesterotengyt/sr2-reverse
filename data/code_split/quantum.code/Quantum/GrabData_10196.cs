// Namespace: Quantum
[Serializable]
public class GrabData : AssetObject // TypeDefIndex: 10196
{
	// Fields
	[Header("Grabber Properties")]
	public GrabJoint InPlaceGrabJoint; // 0x20
	[DrawIf("InPlaceGrabJoint", 3, 0, 3)]
	public HashString InPlaceGrabJointID; // 0x28
	[DrawIf("InPlaceGrabJoint", 4, 0, 3)]
	public FPVector3 InPlaceGrabPosition; // 0x38
	[DrawIf("InPlaceGrabJoint", 4, 0, 3)]
	public FPVector3 InPlaceGrabRotation; // 0x50
	public GrabJoint CarryGrabJoint; // 0x68
	public bool GrabberIsOwner; // 0x6C
	[DrawIf("CarryGrabJoint", 3, 0, 3)]
	public HashString CarryGrabJointID; // 0x70
	[DrawIf("CarryGrabJoint", 4, 0, 3)]
	public FPVector3 CarryGrabPosition; // 0x80
	[DrawIf("CarryGrabJoint", 4, 0, 3)]
	public FPVector3 CarryGrabRotation; // 0x98
	[Header("Grabbed Properties")]
	public GrabDirection GrabDirection; // 0xB0
	public GrabMode GrabMode; // 0xB4
	[DrawIf("GrabMode", 2, 0, 3)]
	public GrabbedAction GrabbedAction; // 0xB8
	public bool CanBeGrabbed; // 0xBC
	public bool GrabbableOnlyByOwner; // 0xBD
	public bool BlockGrabberFromBeingGrabbed; // 0xBE
	public int HitStopGrabProbability; // 0xC0
	[Header("Offsets")]
	public FPVector3 GrabPositionOffset; // 0xC8
	public FPVector3 GrabJointPositionOffset; // 0xE0
	public FPVector3 GrabJointRotationOffset; // 0xF8
	public bool UseGrabFixedRotation; // 0x110
	public EntityGrabOffsetInfo[] EntitySpecificGrabOffsets; // 0x118
	[Header("Grab State Events")]
	public StateNotificationMode GrabReleaseNotificationMode; // 0x120
	[DrawIf("GrabReleaseNotificationMode", 0, 1, 3)]
	public HashString GrabReleaseState; // 0x128
	public StateNotificationMode GrabbedNotificationMode; // 0x138
	[DrawIf("GrabbedNotificationMode", 0, 1, 3)]
	public HashString GrabbedState; // 0x140
	public StateNotificationMode GrabbedHurtNotificationMode; // 0x150
	[DrawIf("GrabbedHurtNotificationMode", 0, 1, 3)]
	public HashString GrabbedHurtState; // 0x158
	[Header("Carriable Specific")]
	[DrawIf("GrabMode", 2, 0, 3)]
	public StateNotificationMode DroppedNotificationMode; // 0x168
	[DrawIf("DroppedNotificationMode", 0, 1, 3)]
	[DrawIf("GrabMode", 2, 0, 3)]
	public HashString DroppedState; // 0x170
	[DrawIf("GrabMode", 2, 0, 3)]
	public StateNotificationMode DroppedOnHurtNotificationMode; // 0x180
	[DrawIf("DroppedOnHurtNotificationMode", 0, 1, 3)]
	[DrawIf("GrabMode", 2, 0, 3)]
	public HashString DroppedOnHurtState; // 0x188
	[DrawIf("GrabMode", 2, 0, 3)]
	public StateNotificationMode ThrownNotificationMode; // 0x198
	[DrawIf("ThrownNotificationMode", 0, 1, 3)]
	[DrawIf("GrabMode", 2, 0, 3)]
	public HashString ThrownState; // 0x1A0
	[DrawIf("GrabMode", 2, 0, 3)]
	public StateNotificationMode UsedNotificationMode; // 0x1B0
	[DrawIf("UsedNotificationMode", 0, 1, 3)]
	[DrawIf("GrabMode", 2, 0, 3)]
	public HashString UsedState; // 0x1B8

	// Methods

	// RVA: 0x2153A10 Offset: 0x2152010 VA: 0x182153A10
	public void GetGrabOffset(int entityID, out FPVector3 globalOffset, out FPVector3 localOffset, out FPVector3 rotationOffset, out bool useFixedRotation) { }

	// RVA: 0x2153B60 Offset: 0x2152160 VA: 0x182153B60
	public void .ctor() { }
}
