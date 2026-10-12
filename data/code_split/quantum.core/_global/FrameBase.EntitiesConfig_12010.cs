// Namespace: 
[Serializable]
public class FrameBase.EntitiesConfig // TypeDefIndex: 12010
{
	// Fields
	[Tooltip("When remove-component and destroy-entity commands should be committed, effectively cleaning and freeing the data from components buffers.
Both commands still take immediate effect from a semantic perspective, e.g.: checking if the entity exists will return false as soon as the destroy-entity method is called.
Commiting commands on OnFrameSimulationBegin will ensure that performing Physics Queries is safe, even after the frame simulation ends (from Unity), but might result in a larger total amount of memory reserved in case many entities are destroyed AND created in the same frame (analogous for component-removal).")]
	public CommitCommandsModes CommitCommandsMode; // 0x10
	[Tooltip("The starting capacity of internal entity and component buffers.
Default is 1024.")]
	public int DefaultEntityCapacity; // 0x14
	[Tooltip("Default value for how many components are stored together in a continuous block of memory.
Default is 128.")]
	public int DefaultComponentBlockCapacity; // 0x18
	[Tooltip("Allows overriding config values on a per-component level.")]
	public FrameBase.EntitiesConfig.ComponentBufferConfig[] ComponentTypeConfiguration; // 0x20

	// Methods

	// RVA: 0x2208CD0 Offset: 0x22072D0 VA: 0x182208CD0
	public int GetComponentBlockCapacity(Type type) { }

	// RVA: 0x2208E20 Offset: 0x2207420 VA: 0x182208E20
	public void .ctor() { }
}
