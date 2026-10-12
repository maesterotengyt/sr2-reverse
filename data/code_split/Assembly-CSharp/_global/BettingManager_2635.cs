// Namespace: 
public class BettingManager : SRMonoBehaviour // TypeDefIndex: 2635
{
	// Fields
	[CompilerGenerated]
	private BettingManager.MatchBetResult MatchBetResponse; // 0x20
	[CompilerGenerated]
	private BettingManager.RoundBetResult RoundBetResponse; // 0x28
	public BettingData MatchBettingData; // 0x30
	public PlayerBetData MatchSendBet; // 0x48
	public BettingData RoundBettingData; // 0x58
	private int currency; // 0x70

	// Methods

	[CompilerGenerated]
	// RVA: 0x70E6A0 Offset: 0x70CCA0 VA: 0x18070E6A0
	public void add_MatchBetResponse(BettingManager.MatchBetResult value) { }

	[CompilerGenerated]
	// RVA: 0x70E7E0 Offset: 0x70CDE0 VA: 0x18070E7E0
	public void remove_MatchBetResponse(BettingManager.MatchBetResult value) { }

	[CompilerGenerated]
	// RVA: 0x70E740 Offset: 0x70CD40 VA: 0x18070E740
	public void add_RoundBetResponse(BettingManager.RoundBetResult value) { }

	[CompilerGenerated]
	// RVA: 0x70E880 Offset: 0x70CE80 VA: 0x18070E880
	public void remove_RoundBetResponse(BettingManager.RoundBetResult value) { }

	// RVA: 0x70CE30 Offset: 0x70B430 VA: 0x18070CE30
	public void Initialize() { }

	// RVA: 0x70DD90 Offset: 0x70C390 VA: 0x18070DD90
	public void SetData() { }

	// RVA: 0x70E400 Offset: 0x70CA00 VA: 0x18070E400
	public void SetMatchBet(string playerId, int amount) { }

	// RVA: 0x70E550 Offset: 0x70CB50 VA: 0x18070E550
	public void SetRoundBet(string playerId, int amount) { }

	// RVA: 0x70CE10 Offset: 0x70B410 VA: 0x18070CE10
	public int GetCurrencyAmount() { }

	// RVA: 0x70D250 Offset: 0x70B850 VA: 0x18070D250
	public void PlaceMatchBet() { }

	// RVA: 0x70D4E0 Offset: 0x70BAE0 VA: 0x18070D4E0
	public void PlaceRoundBet() { }

	// RVA: 0x70D0D0 Offset: 0x70B6D0 VA: 0x18070D0D0
	public void MatchBetEnd(string playerId) { }

	// RVA: 0x70D6C0 Offset: 0x70BCC0 VA: 0x18070D6C0
	public void RoundBetEnd(string playerId) { }

	// RVA: 0x70D220 Offset: 0x70B820 VA: 0x18070D220
	public void PlaceMatchBetResult(bool sucess, string betEntityId) { }

	// RVA: 0x70CE20 Offset: 0x70B420 VA: 0x18070CE20
	public void GetCurrencyResult(bool sucess, int amount) { }

	// RVA: 0x70D670 Offset: 0x70BC70 VA: 0x18070D670
	public void PlaceRoundResult(bool sucess, string betEntityId) { }

	// RVA: 0x70D6A0 Offset: 0x70BCA0 VA: 0x18070D6A0
	public void RoundBetEndResult(bool sucess, int amountAwarded) { }

	// RVA: 0x70D0B0 Offset: 0x70B6B0 VA: 0x18070D0B0
	public void MatchBetEndResult(bool sucess, int amountAwarded) { }

	// RVA: 0x53BEF0 Offset: 0x53A4F0 VA: 0x18053BEF0
	public void .ctor() { }
}
