// Namespace: Quantum
public struct InputBuffer : IComponent // TypeDefIndex: 10001
{
	// Fields
	public QBoolean Active; // 0x10
	[FixedBuffer(typeof(byte), 1920)]
	[HideInInspector]
	[FixedArray(typeof(InputValue), 60)]
	private InputBuffer.<_BufferHistory_>e__FixedBuffer _BufferHistory_; // 0x48
	[HideInInspector]
	public int BufferHistorySize; // 0x8
	[HideInInspector]
	public ButtonTimersContainer ButtonTimersContainer; // 0x7C8
	[HideInInspector]
	public InputFlag CurrentInput; // 0x0
	[HideInInspector]
	public AssetRefInputCheck_Behaviour CurrentInputCheckbehaviour; // 0x18
	[HideInInspector]
	public FP CurrentLeftStickX; // 0x28
	[HideInInspector]
	public FP CurrentLeftStickY; // 0x30
	public EntityRef Entity; // 0x20
	[HideInInspector]
	public int LastHistoryElementIndex; // 0xC
	[HideInInspector]
	public InputFlag PreviousInput; // 0x4
	[HideInInspector]
	public FP PreviousLeftStickX; // 0x38
	[HideInInspector]
	public FP PreviousLeftStickY; // 0x40

	// Properties
	public FixedArray<InputValue> BufferHistory { get; }

	// Methods

	// RVA: 0x211EFB0 Offset: 0x211D5B0 VA: 0x18211EFB0
	public FixedArray<InputValue> get_BufferHistory() { }

	// RVA: 0x211CE20 Offset: 0x211B420 VA: 0x18211CE20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211D840 Offset: 0x211BE40 VA: 0x18211D840
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211CA20 Offset: 0x211B020 VA: 0x18211CA20
	internal void Enable() { }

	// RVA: 0x211C9E0 Offset: 0x211AFE0 VA: 0x18211C9E0
	internal void Disable() { }

	// RVA: 0x211D530 Offset: 0x211BB30 VA: 0x18211D530
	internal FP NormalizedLeftStickX(Frame frame) { }

	// RVA: 0x211D5F0 Offset: 0x211BBF0 VA: 0x18211D5F0
	internal FP NormalizedLeftStickY(Frame frame) { }

	// RVA: 0x211D410 Offset: 0x211BA10 VA: 0x18211D410
	internal FP NormalizedLeftStickForward(Frame frame) { }

	// RVA: 0x211D2F0 Offset: 0x211B8F0 VA: 0x18211D2F0
	internal FP NormalizedLeftStickBack(Frame frame) { }

	// RVA: 0x211D0F0 Offset: 0x211B6F0 VA: 0x18211D0F0
	internal FP LeftStickBack(Frame frame) { }

	// RVA: 0x211C7C0 Offset: 0x211ADC0 VA: 0x18211C7C0
	internal FP CalculateReferenceStickValue(ImpulseStickInfluence influenceType, FP referenceValue) { }

	// RVA: 0x211D010 Offset: 0x211B610 VA: 0x18211D010
	internal bool IsButtonJustPressed(InputFlag inputFlag) { }

	// RVA: 0x211D050 Offset: 0x211B650 VA: 0x18211D050
	internal bool IsButtonJustReleased(InputFlag inputFlag) { }

	// RVA: 0x211CFD0 Offset: 0x211B5D0 VA: 0x18211CFD0
	internal bool IsButtonHold(InputFlag inputFlag) { }

	// RVA: 0x211D090 Offset: 0x211B690 VA: 0x18211D090
	internal bool IsDirectionJustPressed(InputDirection direction, bool invertX) { }

	// RVA: 0x211E4D0 Offset: 0x211CAD0 VA: 0x18211E4D0
	internal bool WasButtonJustPressed(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1, bool spendAction = True) { }

	// RVA: 0x211E630 Offset: 0x211CC30 VA: 0x18211E630
	internal bool WasButtonJustReleased(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1, bool spendAction = True) { }

	// RVA: 0x211E410 Offset: 0x211CA10 VA: 0x18211E410
	internal bool WasButtonHeld(InputFlag inputFlag, out int outEventIndex, int startFrame = -1, int framesToCheck = 1) { }

	// RVA: 0x211E950 Offset: 0x211CF50 VA: 0x18211E950
	internal bool WasDirectionJustPressed(InputDirection direction, out int outEventIndex, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1, bool spendAction = True) { }

	// RVA: 0x211ECE0 Offset: 0x211D2E0 VA: 0x18211ECE0
	internal bool WasDirectionJustReleased(InputDirection direction, out int outEventIndex, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1, bool spendAction = True) { }

	// RVA: 0x211E790 Offset: 0x211CD90 VA: 0x18211E790
	internal bool WasDirectionHold(InputDirection direction, FP deadzone, FP detectionThreshold, FP minAngle, FP maxAngle, bool invertX, int startFrame = -1, int framesToCheck = 1) { }

	// RVA: 0x211DE10 Offset: 0x211C410 VA: 0x18211DE10
	internal void UpdateCurrentInput(InputFlag inputFlag, FP leftStickX, FP leftStickY, FPVector2 stickMinValues, FPVector2 stickMaxValues) { }

	// RVA: 0x211D700 Offset: 0x211BD00 VA: 0x18211D700
	internal void SaveCurrentInputInBuffer() { }

	// RVA: 0x211DB70 Offset: 0x211C170 VA: 0x18211DB70
	internal void SpendAction(InputFlag inputFlag, int index) { }

	// RVA: 0x211DBF0 Offset: 0x211C1F0 VA: 0x18211DBF0
	internal void SpendDirection(InputDirection direction, int index) { }

	// RVA: 0x211DD20 Offset: 0x211C320 VA: 0x18211DD20
	internal bool TryGetFromBuffer(int elementIndex, out InputValue* inputValue) { }

	// RVA: 0x211DA90 Offset: 0x211C090 VA: 0x18211DA90
	internal void SetInBuffer(int elementIndex, InputValue inputValue) { }

	// RVA: 0x211C7F0 Offset: 0x211ADF0 VA: 0x18211C7F0
	internal void ClearBuffer() { }

	// RVA: 0x211D180 Offset: 0x211B780 VA: 0x18211D180
	private int NormalizedIndex(int elementIndex) { }

	// RVA: 0x211DCA0 Offset: 0x211C2A0 VA: 0x18211DCA0
	private FP StickFromByteToFloat(FP stickValue, FP stickMinValue, FP stickMaxValue) { }

	// RVA: 0x211D6B0 Offset: 0x211BCB0 VA: 0x18211D6B0
	private FP NormalizedStick(FP stickValue, FP stickMinValue, FP stickMaxValue) { }

	// RVA: 0x211CA40 Offset: 0x211B040 VA: 0x18211CA40
	private int GetFramesSinceButtonPress(InputFlag input) { }

	// RVA: 0x211CAF0 Offset: 0x211B0F0 VA: 0x18211CAF0
	private int GetFramesSinceButtonRelease(InputFlag input) { }

	// RVA: 0x211CBA0 Offset: 0x211B1A0 VA: 0x18211CBA0
	private int GetFramesSinceDirectionPress(InputDirection direction, bool invertX) { }

	// RVA: 0x211CCE0 Offset: 0x211B2E0 VA: 0x18211CCE0
	private int GetFramesSinceDirectionRelease(InputDirection direction, bool invertX) { }
}
