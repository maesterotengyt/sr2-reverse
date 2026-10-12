// Namespace: Photon.Realtime
public class WebFlags // TypeDefIndex: 3999
{
	// Fields
	public static readonly WebFlags Default; // 0x0
	public byte WebhookFlags; // 0x10
	public const byte HttpForwardConst = 1;
	public const byte SendAuthCookieConst = 2;
	public const byte SendSyncConst = 4;
	public const byte SendStateConst = 8;

	// Properties
	public bool HttpForward { get; set; }
	public bool SendAuthCookie { get; set; }
	public bool SendSync { get; set; }
	public bool SendState { get; set; }

	// Methods

	// RVA: 0x6A4870 Offset: 0x6A2E70 VA: 0x1806A4870
	public bool get_HttpForward() { }

	// RVA: 0x6A48B0 Offset: 0x6A2EB0 VA: 0x1806A48B0
	public void set_HttpForward(bool value) { }

	// RVA: 0x6A4880 Offset: 0x6A2E80 VA: 0x1806A4880
	public bool get_SendAuthCookie() { }

	// RVA: 0x6A48E0 Offset: 0x6A2EE0 VA: 0x1806A48E0
	public void set_SendAuthCookie(bool value) { }

	// RVA: 0x6A48A0 Offset: 0x6A2EA0 VA: 0x1806A48A0
	public bool get_SendSync() { }

	// RVA: 0x6A4940 Offset: 0x6A2F40 VA: 0x1806A4940
	public void set_SendSync(bool value) { }

	// RVA: 0x6A4890 Offset: 0x6A2E90 VA: 0x1806A4890
	public bool get_SendState() { }

	// RVA: 0x6A4910 Offset: 0x6A2F10 VA: 0x1806A4910
	public void set_SendState(bool value) { }

	// RVA: 0x6A4840 Offset: 0x6A2E40 VA: 0x1806A4840
	public void .ctor(byte webhookFlags) { }

	// RVA: 0x6A47D0 Offset: 0x6A2DD0 VA: 0x1806A47D0
	private static void .cctor() { }
}
