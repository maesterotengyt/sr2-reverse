// Namespace: Quantum
public enum StateGroupEvent // TypeDefIndex: 10667
{
	// Fields
	public int value__; // 0x0
	public const StateGroupEvent None = 0;
	public const StateGroupEvent OnEnterState = 1;
	public const StateGroupEvent OnExitState = 2;
	public const StateGroupEvent OnUpdateState = 3;
	public const StateGroupEvent OnHit = 10;
	public const StateGroupEvent OnHurt = 11;
	public const StateGroupEvent OnBlocked = 12;
	public const StateGroupEvent OnBlock = 13;
	public const StateGroupEvent OnGrabInPlace = 14;
	public const StateGroupEvent OnGrabbed = 15;
	public const StateGroupEvent OnGrabCarriable = 16;
	public const StateGroupEvent OnTouchFloor = 20;
	public const StateGroupEvent OnTouchCeiling = 21;
	public const StateGroupEvent OnTouchLeftWall = 22;
	public const StateGroupEvent OnTouchRightWall = 23;
	public const StateGroupEvent OnLeaveFloor = 24;
	public const StateGroupEvent OnReachLedge = 25;
	public const StateGroupEvent OnBounce = 26;
	public const StateGroupEvent OnFloorBounceFailed = 27;
	public const StateGroupEvent OnEntityEnter = 28;
	public const StateGroupEvent OnEntityExit = 29;
	public const StateGroupEvent OnLeaveCeiling = 30;
	public const StateGroupEvent OnLeaveLeftWall = 31;
	public const StateGroupEvent OnLeaveRightWall = 32;
	public const StateGroupEvent OnStartUpSlope = 33;
	public const StateGroupEvent OnEndUpSlope = 34;
	public const StateGroupEvent OnStartDownSlope = 35;
	public const StateGroupEvent OnEndDownSlope = 36;
}
