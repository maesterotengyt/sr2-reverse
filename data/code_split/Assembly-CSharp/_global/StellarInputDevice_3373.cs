// Namespace: 
public abstract class StellarInputDevice // TypeDefIndex: 3373
{
	// Fields
	public int DeviceIndex; // 0x10
	public InputDeviceType DeviceType; // 0x14
	public bool Active; // 0x18
	private float timeLeftReleased; // 0x1C
	private float timeRightReleased; // 0x20
	private float timeUpReleased; // 0x24
	private float timeDownReleased; // 0x28
	private float stickLeftValue; // 0x2C
	private float stickRightValue; // 0x30
	private float stickUpValue; // 0x34
	private float stickDownValue; // 0x38
	private bool leftStickValueSet; // 0x3C
	private bool rightStickValueSet; // 0x3D
	private bool upStickValueSet; // 0x3E
	private bool downStickValueSet; // 0x3F
	private float stickTimeDetectDoubleTap; // 0x40

	// Properties
	protected StellarInputSystem inputSystem { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PollGameplayInputs(ref Input input);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PollInputs();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetUIInputDown(UIKey key);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetUIInputUp(UIKey key);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetUIInputHold(UIKey key);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool GetGameplayInputHold(InputFlag key);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool GetMovementInputHold(InputDirection direction);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool AnyInput();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void CleanInputs();

	// RVA: 0x5C0430 Offset: 0x5BEA30 VA: 0x1805C0430
	protected StellarInputSystem get_inputSystem() { }

	// RVA: 0x5BFBC0 Offset: 0x5BE1C0 VA: 0x1805BFBC0
	public void .ctor() { }

	// RVA: 0x5C0270 Offset: 0x5BE870 VA: 0x1805C0270
	public sbyte GetAnalogInput(float value) { }

	// RVA: 0x5C0280 Offset: 0x5BE880 VA: 0x1805C0280
	public float LeftDigitalStickPress() { }

	// RVA: 0x5C02D0 Offset: 0x5BE8D0 VA: 0x1805C02D0
	public void LeftDigitalStickUp() { }

	// RVA: 0x5C0310 Offset: 0x5BE910 VA: 0x1805C0310
	public float RightDigitalStickPress() { }

	// RVA: 0x5C0360 Offset: 0x5BE960 VA: 0x1805C0360
	public void RightDigitalStickUp() { }

	// RVA: 0x5C03A0 Offset: 0x5BE9A0 VA: 0x1805C03A0
	public float UpDigitalStickPress() { }

	// RVA: 0x5C03F0 Offset: 0x5BE9F0 VA: 0x1805C03F0
	public void UpDigitalStickUp() { }

	// RVA: 0x5C01E0 Offset: 0x5BE7E0 VA: 0x1805C01E0
	public float DownDigitalStickPress() { }

	// RVA: 0x5C0230 Offset: 0x5BE830 VA: 0x1805C0230
	public void DownDigitalStickUp() { }

	// RVA: 0x5BFF50 Offset: 0x5BE550 VA: 0x1805BFF50
	public Vector2 DigitalMovement() { }
}
