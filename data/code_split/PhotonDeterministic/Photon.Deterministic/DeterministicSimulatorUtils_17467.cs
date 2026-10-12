// Namespace: Photon.Deterministic
internal static class DeterministicSimulatorUtils // TypeDefIndex: 17467
{
	// Methods

	// RVA: 0x20BA030 Offset: 0x20B8630 VA: 0x1820BA030
	public static void CallChecksumError(IDeterministicGame game, DeterministicTickChecksumError error, DeterministicFrame[] frames) { }

	// RVA: 0x20BA180 Offset: 0x20B8780 VA: 0x1820BA180
	public static ulong CallChecksum(DeterministicFrame f) { }

	// RVA: 0x20BA290 Offset: 0x20B8890 VA: 0x1820BA290
	public static void CallSimulate(DeterministicFrame f, IDeterministicGame game) { }

	// RVA: 0x20BA1F0 Offset: 0x20B87F0 VA: 0x1820BA1F0
	public static void CallSimulateFinished(DeterministicFrame f, IDeterministicGame game) { }

	// RVA: 0x20B9F80 Offset: 0x20B8580 VA: 0x1820B9F80
	public static void CallChecksumComputed(IDeterministicGame game, int frame, ulong checksum) { }
}
