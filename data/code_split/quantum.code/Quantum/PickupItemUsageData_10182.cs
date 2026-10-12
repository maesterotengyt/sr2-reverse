// Namespace: Quantum
[Serializable]
public class PickupItemUsageData : AssetObject // TypeDefIndex: 10182
{
	// Fields
	public PickupItemUsage[] Usages; // 0x20
	public ItemButtonUseMode ButtonUseMode; // 0x28
	public FP ChargePowerIncreaseSpeed; // 0x30
	public bool AutoUseOnFullCharge; // 0x38
	public bool HasInfiniteUses; // 0x39

	// Methods

	// RVA: 0x2148190 Offset: 0x2146790 VA: 0x182148190
	public void Use(Frame frame, EntityRef fromEntity) { }

	// RVA: 0x2148250 Offset: 0x2146850 VA: 0x182148250
	public void .ctor() { }
}
