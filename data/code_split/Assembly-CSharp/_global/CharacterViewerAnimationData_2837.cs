// Namespace: 
[Serializable]
public struct CharacterViewerAnimationData // TypeDefIndex: 2837
{
	// Fields
	public List<CharacterViewerExtraSetting> GeneralExtraSettings; // 0x0
	public List<CharacterViewerExtraSetting> CPUExtraSettings; // 0x8
	public HashString Animation; // 0x10
	public HashString State; // 0x20
	public int StateStartFrame; // 0x30
	public int PlayAllDelay; // 0x34
	public int TimesPlayed; // 0x38
	public int Duration; // 0x3C
	public HashString Attack; // 0x40
	public float Damage; // 0x50
	public float FallSpeed; // 0x54
	public int InstigatorOrientation; // 0x58
	public Vector2 CharacterPosition; // 0x5C
	public int FacingDirection; // 0x64
	public bool SpawnCPU; // 0x68
	public HashString CPUInitialState; // 0x70
	public float CPUInitialDamage; // 0x80
	public int CPUFacingDirection; // 0x84
	public Vector2 CPUPosition; // 0x88
	public List<CharacterViewerCPUAction> CPUActions; // 0x90
	public List<CharacterViewerInputFrames> InputFrames; // 0x98
	public List<CharacterViewerInputFrames> CPUInputFrames; // 0xA0

	// Properties
	public int AnimationHash { get; }
	public string AnimationValue { get; }
	public int StateHash { get; }
	public string StateValue { get; }
	public int TotalDuration { get; }

	// Methods

	[IsReadOnly]
	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_AnimationHash() { }

	[IsReadOnly]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_AnimationValue() { }

	[IsReadOnly]
	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_StateHash() { }

	[IsReadOnly]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public string get_StateValue() { }

	[IsReadOnly]
	// RVA: 0x7274F0 Offset: 0x725AF0 VA: 0x1807274F0
	public int get_TotalDuration() { }

	// RVA: 0x7273F0 Offset: 0x7259F0 VA: 0x1807273F0
	public void Initialize() { }

	// RVA: 0x727350 Offset: 0x725950 VA: 0x180727350
	private void InitializeExtended() { }
}
