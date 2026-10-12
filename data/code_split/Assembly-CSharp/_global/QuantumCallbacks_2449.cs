// Namespace: 
public abstract class QuantumCallbacks : MonoBehaviour // TypeDefIndex: 2449
{
	// Fields
	public static readonly List<QuantumCallbacks> Instances; // 0x0

	// Methods

	// RVA: 0x528DA0 Offset: 0x5273A0 VA: 0x180528DA0 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x528D20 Offset: 0x527320 VA: 0x180528D20 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 6
	public virtual void OnGameStart(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void OnGameResync(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void OnGameDestroyed(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void OnUpdateView(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void OnSimulateFinished(QuantumGame game, Frame frame) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public virtual void OnUnitySceneLoadBegin(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 12
	public virtual void OnUnitySceneLoadDone(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 13
	public virtual void OnUnitySceneUnloadBegin(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 14
	public virtual void OnUnitySceneUnloadDone(QuantumGame game) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 15
	public virtual void OnChecksumError(QuantumGame game, DeterministicTickChecksumError error, Frame[] frames) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	protected void .ctor() { }

	// RVA: 0x528E70 Offset: 0x527470 VA: 0x180528E70
	private static void .cctor() { }
}
