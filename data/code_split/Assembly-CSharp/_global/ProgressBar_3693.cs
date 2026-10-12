// Namespace: 
public class ProgressBar : MonoBehaviour // TypeDefIndex: 3693
{
	// Fields
	public Image FillBar; // 0x20
	public float BarFillSpeed; // 0x28
	public float MinValue; // 0x2C
	public float MaxValue; // 0x30
	private float targetValue; // 0x34
	private float currentValue; // 0x38

	// Methods

	// RVA: 0x64D0B0 Offset: 0x64B6B0 VA: 0x18064D0B0
	public void SetRange(float minValue, float maxValue) { }

	// RVA: 0x64D0C0 Offset: 0x64B6C0 VA: 0x18064D0C0
	public void SetValue(float value, bool immediate = False) { }

	// RVA: 0x64D0A0 Offset: 0x64B6A0 VA: 0x18064D0A0
	public float GetCurrentTargetValue() { }

	// RVA: 0x64D150 Offset: 0x64B750 VA: 0x18064D150
	private void Update() { }

	// RVA: 0x64D240 Offset: 0x64B840 VA: 0x18064D240
	public void .ctor() { }
}
