// Namespace: 
public class Navigation.ThreadLocal // TypeDefIndex: 11649
{
	// Fields
	public Navigation.PathFinder PathFinder; // 0x10
	internal Navigation.VelocityCandidate[] VelocityCandidates; // 0x18
	internal MailboxSet8 Mailbox; // 0x20
	internal FPVector2 LineOfSightHit; // 0x28
	[CompilerGenerated]
	private Native.Allocator <Allocator>k__BackingField; // 0x38

	// Properties
	internal Native.Allocator Allocator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	internal Native.Allocator get_Allocator() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	private void set_Allocator(Native.Allocator value) { }

	// RVA: 0x2220A60 Offset: 0x221F060 VA: 0x182220A60
	public void .ctor(Native.Allocator allocator, int rawPathSize, Navigation.RawPathAllocationStrategy rawPathAllocationStrategy) { }

	// RVA: 0x2220880 Offset: 0x221EE80 VA: 0x182220880
	public void AllocateMailboxBuffer(NavMesh navmesh) { }

	// RVA: 0x22209D0 Offset: 0x221EFD0 VA: 0x1822209D0
	public void Dispose() { }
}
