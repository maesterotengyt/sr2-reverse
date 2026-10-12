// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CustomAnimator))]
[Serializable]
public class CustomAnimator_Prototype : PrototypeAdapter<CustomAnimator_Prototype> // TypeDefIndex: 3884
{
	// Fields
	public QBoolean Active; // 0x10
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	public AssetRefAnimationsPoolData AnimationsPool; // 0x20
	public AssetRefAnimationBakedJointsData BakedJointsData; // 0x28
	[HideInInspector]
	public int HighestWeightClipIndex; // 0x30
	[HideInInspector]
	public FP HighestWeightClipTime; // 0x38
	[HideInInspector]
	[ArrayLength(5)]
	public CustomAnimatorPlayableClipInfo_Prototype[] CurrentClips; // 0x40
	[HideInInspector]
	[ArrayLength(5)]
	public CustomAnimatorPlayableClipInfo_Prototype[] PreviousClips; // 0x48
	[HideInInspector]
	public FP TransitionDuration; // 0x50
	[HideInInspector]
	public FP TransitionTime; // 0x58
	[HideInInspector]
	public QBoolean Blend1DActive; // 0x60
	[HideInInspector]
	public QBoolean Blend2DActive; // 0x64
	[HideInInspector]
	public FP CurrentBlendX; // 0x68
	[HideInInspector]
	public FP CurrentBlendY; // 0x70
	[HideInInspector]
	public FP Speed; // 0x78
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData0; // 0x80
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData1; // 0x88
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData2; // 0x90
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData3; // 0x98
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] CurrentSpeedData4; // 0xA0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData0; // 0xA8
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData1; // 0xB0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData2; // 0xB8
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData3; // 0xC0
	[HideInInspector]
	[DynamicCollection]
	public AnimationSpeedElement_Prototype[] PreviousSpeedData4; // 0xC8
	[Dictionary]
	[DynamicCollection]
	public DictionaryEntry_Int32_CustomSubAnimatorPlayableClipInfo_Prototype[] SubAnimatorClip; // 0xD0

	// Methods

	// RVA: 0x673960 Offset: 0x671F60 VA: 0x180673960 Slot: 5
	public sealed override CustomAnimator_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x673B80 Offset: 0x672180 VA: 0x180673B80
	public void .ctor() { }
}
