// Namespace: Quantum
[Flags]
public enum CallbackFlags // TypeDefIndex: 11745
{
	// Fields
	public int value__; // 0x0
	public const CallbackFlags None = 0;
	public const CallbackFlags OnDynamicCollision = 1;
	public const CallbackFlags OnDynamicCollisionEnter = 2;
	public const CallbackFlags OnDynamicCollisionExit = 4;
	public const CallbackFlags OnStaticCollision = 8;
	public const CallbackFlags OnStaticCollisionEnter = 16;
	public const CallbackFlags OnStaticCollisionExit = 32;
	public const CallbackFlags OnDynamicTrigger = 64;
	public const CallbackFlags OnDynamicTriggerEnter = 128;
	public const CallbackFlags OnDynamicTriggerExit = 256;
	public const CallbackFlags OnStaticTrigger = 512;
	public const CallbackFlags OnStaticTriggerEnter = 1024;
	public const CallbackFlags OnStaticTriggerExit = 2048;
}
