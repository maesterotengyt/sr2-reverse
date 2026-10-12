// Namespace: Quantum
[Serializable]
public struct NavMeshLink // TypeDefIndex: 11662
{
	// Fields
	public FPVector3 Start; // 0x0
	public FPVector3 End; // 0x18
	public int Triangle; // 0x30
	public FP CostOverride; // 0x38
	public NavMeshRegionMask Region; // 0x40
	public string Name; // 0x48

	// Methods

	// RVA: 0x221BD30 Offset: 0x221A330 VA: 0x18221BD30
	public void Serialize(ByteStream stream, bool write) { }
}
