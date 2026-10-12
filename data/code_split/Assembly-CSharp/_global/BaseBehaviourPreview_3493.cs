// Namespace: 
public abstract class BaseBehaviourPreview // TypeDefIndex: 3493
{
	// Fields
	public const float FrameToSecond = 0.016666668;
	public const float SecondToFrame = 60;

	// Methods

	// RVA: 0x5E30C0 Offset: 0x5E16C0 VA: 0x1805E30C0
	public void Evaluate(GameEntityStatePreviewManager statePreviewManager, int currentFrame) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Execute(GameEntityStatePreviewManager statePreviewManager, int currentFrame);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear(GameEntityStatePreviewManager statePreviewManager);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int GetStartFrame();

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 7
	public virtual bool UpdatedOutsideOfStartFrame() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
