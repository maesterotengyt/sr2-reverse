// Namespace: Quantum
public struct NavMeshAvoidanceAgent : IComponent // TypeDefIndex: 11629
{
	// Fields
	public const int SIZE = 40;
	internal byte _priority; // 0x0
	internal byte _avoidanceLayer; // 0x1
	internal byte _membersInitialized; // 0x2
	internal int _avoidanceMask; // 0x4
	internal FPVector2 _desiredDirection; // 0x10
	internal FP _desiredSpeed; // 0x20

	// Properties
	public int AvoidanceMask { set; }
	public byte AvoidanceLayer { set; }
	public byte Priority { set; }

	// Methods

	// RVA: 0x21DCAB0 Offset: 0x21DB0B0 VA: 0x1821DCAB0
	public void set_AvoidanceMask(int value) { }

	// RVA: 0x21DCAA0 Offset: 0x21DB0A0 VA: 0x1821DCAA0
	public void set_AvoidanceLayer(byte value) { }

	// RVA: 0x21DCAC0 Offset: 0x21DB0C0 VA: 0x1821DCAC0
	public void set_Priority(byte value) { }

	// RVA: 0x21DC990 Offset: 0x21DAF90 VA: 0x1821DC990
	internal void SetConfig(FrameBase f, NavMeshAgentConfig config, bool overwrite) { }

	// RVA: 0x21DC8E0 Offset: 0x21DAEE0 VA: 0x1821DC8E0
	public static void Serialize(void* p, FrameSerializer serializer) { }

	// RVA: 0x21DC780 Offset: 0x21DAD80 VA: 0x1821DC780
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
