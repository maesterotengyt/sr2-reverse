// Namespace: Photon.Realtime
public class RaiseEventOptions // TypeDefIndex: 3974
{
	// Fields
	public static readonly RaiseEventOptions Default; // 0x0
	public EventCaching CachingOption; // 0x10
	public byte InterestGroup; // 0x11
	public int[] TargetActors; // 0x18
	public ReceiverGroup Receivers; // 0x20
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte SequenceChannel; // 0x21
	public WebFlags Flags; // 0x28

	// Methods

	// RVA: 0x67E4F0 Offset: 0x67CAF0 VA: 0x18067E4F0
	public void .ctor() { }

	// RVA: 0x67E430 Offset: 0x67CA30 VA: 0x18067E430
	private static void .cctor() { }
}
