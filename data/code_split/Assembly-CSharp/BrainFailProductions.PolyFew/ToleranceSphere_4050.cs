// Namespace: BrainFailProductions.PolyFew
[Serializable]
public class ToleranceSphere : ScriptableObject // TypeDefIndex: 4050
{
	// Fields
	public Vector3 worldPosition; // 0x18
	public float diameter; // 0x24
	public Color color; // 0x28
	public float preservationStrength; // 0x38
	public bool isHidden; // 0x3C

	// Methods

	// RVA: 0x6B3370 Offset: 0x6B1970 VA: 0x1806B3370
	public void .ctor(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = False) { }

	// RVA: 0x6B3300 Offset: 0x6B1900 VA: 0x1806B3300
	public void SetProperties(ToleranceSphereJson tSphereJson) { }

	// RVA: 0x6B3340 Offset: 0x6B1940 VA: 0x1806B3340
	public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = False) { }
}
