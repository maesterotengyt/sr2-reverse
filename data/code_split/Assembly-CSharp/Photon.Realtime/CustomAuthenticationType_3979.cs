// Namespace: Photon.Realtime
public enum CustomAuthenticationType // TypeDefIndex: 3979
{
	// Fields
	public byte value__; // 0x0
	public const CustomAuthenticationType Custom = 0;
	public const CustomAuthenticationType Steam = 1;
	public const CustomAuthenticationType Facebook = 2;
	public const CustomAuthenticationType Oculus = 3;
	public const CustomAuthenticationType PlayStation4 = 4;
	[Obsolete("Use PlayStation4 or PlayStation5 as needed")]
	public const CustomAuthenticationType PlayStation = 4;
	public const CustomAuthenticationType Xbox = 5;
	public const CustomAuthenticationType Viveport = 10;
	public const CustomAuthenticationType NintendoSwitch = 11;
	public const CustomAuthenticationType PlayStation5 = 12;
	[Obsolete("Use PlayStation4 or PlayStation5 as needed")]
	public const CustomAuthenticationType Playstation5 = 12;
	public const CustomAuthenticationType Epic = 13;
	public const CustomAuthenticationType FacebookGaming = 15;
	public const CustomAuthenticationType None = 255;
}
