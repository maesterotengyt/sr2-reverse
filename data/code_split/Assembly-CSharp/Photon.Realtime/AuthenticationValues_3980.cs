// Namespace: Photon.Realtime
public class AuthenticationValues // TypeDefIndex: 3980
{
	// Fields
	private CustomAuthenticationType authType; // 0x10
	[CompilerGenerated]
	private string <AuthGetParameters>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <AuthPostData>k__BackingField; // 0x20
	[CompilerGenerated]
	private object <Token>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x30

	// Properties
	public CustomAuthenticationType AuthType { get; set; }
	public string AuthGetParameters { get; set; }
	public object AuthPostData { get; set; }
	public object Token { get; set; }
	public string UserId { get; set; }

	// Methods

	// RVA: 0x537B50 Offset: 0x536150 VA: 0x180537B50
	public CustomAuthenticationType get_AuthType() { }

	// RVA: 0x667A30 Offset: 0x666030 VA: 0x180667A30
	public void set_AuthType(CustomAuthenticationType value) { }

	[CompilerGenerated]
	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public string get_AuthGetParameters() { }

	[CompilerGenerated]
	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	public void set_AuthGetParameters(string value) { }

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public object get_AuthPostData() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	private void set_AuthPostData(object value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public object get_Token() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	protected internal void set_Token(object value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_UserId(string value) { }

	// RVA: 0x672150 Offset: 0x670750 VA: 0x180672150
	public void .ctor() { }

	// RVA: 0x672160 Offset: 0x670760 VA: 0x180672160
	public void .ctor(string userId) { }

	// RVA: 0x671E60 Offset: 0x670460 VA: 0x180671E60 Slot: 4
	public virtual void SetAuthPostData(string stringData) { }

	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00 Slot: 5
	public virtual void SetAuthPostData(byte[] byteData) { }

	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00 Slot: 6
	public virtual void SetAuthPostData(Dictionary<string, object> dictData) { }

	// RVA: 0x671BB0 Offset: 0x6701B0 VA: 0x180671BB0 Slot: 7
	public virtual void AddAuthParameter(string key, string value) { }

	// RVA: 0x671EB0 Offset: 0x6704B0 VA: 0x180671EB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x671DF0 Offset: 0x6703F0 VA: 0x180671DF0
	public AuthenticationValues CopyTo(AuthenticationValues copy) { }
}
