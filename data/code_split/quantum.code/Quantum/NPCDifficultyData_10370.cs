// Namespace: Quantum
[Serializable]
public class NPCDifficultyData // TypeDefIndex: 10370
{
	// Fields
	[Tooltip("The ID of the difficulty")]
	public int ID; // 0x10
	[Tooltip("The chance for the a npc on the difficulty to dodge an item")]
	public int DodgeChance; // 0x14
	[Tooltip("Unfreeze spam speed, frames btween inputs")]
	public int UnfreezeSpeed; // 0x18
	[Tooltip("The chance of a npc doing a tackle")]
	public int TackleChance; // 0x1C
	[Tooltip("Cooldown after doing a tackle")]
	public int TackleCooldown; // 0x20
	[Tooltip("MaxSpeed if 0 will be unlmited")]
	public int MaxSpeed; // 0x24

	// Methods

	// RVA: 0x2190990 Offset: 0x218EF90 VA: 0x182190990
	public void .ctor() { }
}
