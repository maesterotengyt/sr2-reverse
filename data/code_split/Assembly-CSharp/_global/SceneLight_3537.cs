// Namespace: 
[Serializable]
public class SceneLight // TypeDefIndex: 3537
{
	// Fields
	public HashString ID; // 0x10
	public Light LightReference; // 0x20
	[HideInInspector]
	public Color startColor; // 0x28
	[HideInInspector]
	public Color TargetColor; // 0x38
	[HideInInspector]
	public float startIntensity; // 0x48
	[HideInInspector]
	public float TargetIntensity; // 0x4C
	[HideInInspector]
	public Quaternion startRotation; // 0x50
	[HideInInspector]
	public Quaternion targetRotation; // 0x60
	[HideInInspector]
	public float transitionTimer; // 0x70
	[HideInInspector]
	public bool transitioning; // 0x74

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
