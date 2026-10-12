// Namespace: 
public interface MemoryLayoutVerifier.IPlatform // TypeDefIndex: 11788
{
	// Properties
	public abstract bool CanResolveEnumSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_CanResolveEnumSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int FieldOffset(FieldInfo field);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int SizeOf(Type type);
}
