// Namespace: 
public class PlayerHealthBar : MonoBehaviour // TypeDefIndex: 2873
{
	// Fields
	public List<Animator> HealthPoints; // 0x20
	private int currentHealthPointIndex; // 0x28
	private int currentStamina; // 0x2C
	private bool isHalfPoint; // 0x30

	// Methods

	// RVA: 0x7505B0 Offset: 0x74EBB0 VA: 0x1807505B0
	public void Initialize() { }

	// RVA: 0x7508A0 Offset: 0x74EEA0 VA: 0x1807508A0
	public void ResetHealthPoints() { }

	// RVA: 0x750450 Offset: 0x74EA50 VA: 0x180750450
	public void DecreaseHealth() { }

	// RVA: 0x750510 Offset: 0x74EB10 VA: 0x180750510
	public void IncreaseHealth() { }

	// RVA: 0x750700 Offset: 0x74ED00 VA: 0x180750700
	private void OnUpdatePlayerHealthBarPoints(EventUpdatePlayerHealthPointsHUD callback) { }

	// RVA: 0x7506F0 Offset: 0x74ECF0 VA: 0x1807506F0
	private void OnResetPlayerHealthBarPoints(EventResetPlayerHealthPointsHUD callback) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
