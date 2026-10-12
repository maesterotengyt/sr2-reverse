// Namespace: 
public interface IStellarCollisionsVisualizer // TypeDefIndex: 3352
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(StellarCollisionsVisualizerData visualizerData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SaveHitBoxVisualInstance(HitBoxVisualInstance hitBoxVisuals);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SaveHurtBoxVisualInstance(HurtBoxVisualInstance hurtBoxVisuals);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SaveECBVisualInstance(ECBVisualInstance ecbVisuals);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool GetECBsVisible();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetECBsVisible(bool value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetHurtBoxesVisible();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetHurtBoxesVisible(bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetHitBoxesVisible();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetHitBoxesVisible(bool value);
}
