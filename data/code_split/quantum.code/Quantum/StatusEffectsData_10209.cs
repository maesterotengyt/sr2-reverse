// Namespace: Quantum
[Serializable]
public class StatusEffectsData : AssetObject // TypeDefIndex: 10209
{
	// Fields
	public AssetRefStatusEffectBase[] StatusEffectsAvailable; // 0x20
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<HashString, StatusEffectBase> <StatusEffectsDict>k__BackingField; // 0x30

	// Properties
	public bool Initialized { get; set; }
	public Dictionary<HashString, StatusEffectBase> StatusEffectsDict { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5BA5A0 Offset: 0x5B8BA0 VA: 0x1805BA5A0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x5BA5B0 Offset: 0x5B8BB0 VA: 0x1805BA5B0
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public Dictionary<HashString, StatusEffectBase> get_StatusEffectsDict() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_StatusEffectsDict(Dictionary<HashString, StatusEffectBase> value) { }

	// RVA: 0x2160410 Offset: 0x215EA10 VA: 0x182160410
	public void Init(Frame frame) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
