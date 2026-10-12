// Namespace: BrainFailProductions.PolyFew
[Serializable]
public class ToleranceSphereJson // TypeDefIndex: 4051
{
	// Fields
	public Vector3 worldPosition; // 0x10
	public float diameter; // 0x1C
	public Color color; // 0x20
	public float preservationStrength; // 0x30
	public bool isHidden; // 0x34

	// Methods

	// RVA: 0x6B31B0 Offset: 0x6B17B0 VA: 0x1806B31B0
	public void .ctor(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = False) { }

	// RVA: 0x6B3220 Offset: 0x6B1820 VA: 0x1806B3220
	public void .ctor(ToleranceSphere toleranceSphere) { }

	// RVA: 0x6B3180 Offset: 0x6B1780 VA: 0x1806B3180
	public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = False) { }

	// RVA: 0x6B3020 Offset: 0x6B1620 VA: 0x1806B3020
	public void DumpFromToleranceSphere(ToleranceSphere toleranceSphere) { }

	// RVA: 0x6B30C0 Offset: 0x6B16C0 VA: 0x1806B30C0
	public void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere) { }
}
