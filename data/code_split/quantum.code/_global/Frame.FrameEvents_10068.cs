// Namespace: 
public struct Frame.FrameEvents // TypeDefIndex: 10068
{
	// Fields
	public const int EVENT_TYPE_COUNT = 101;
	private Frame _f; // 0x0

	// Methods

	// RVA: 0x1E629D0 Offset: 0x1E60FD0 VA: 0x181E629D0
	public static int GetParentEventID(int eventID) { }

	// RVA: 0x213BFA0 Offset: 0x213A5A0 VA: 0x18213BFA0
	public static Type GetEventType(int eventID) { }

	// RVA: 0x213B260 Offset: 0x2139860 VA: 0x18213B260
	public EventCharacterBoostUpdated CharacterBoostUpdated(EntityRef Entity, FP Boost) { }

	// RVA: 0x213D410 Offset: 0x213BA10 VA: 0x18213D410
	public EventNotifyVOCharacterEvent NotifyVOCharacterEvent(EntityRef Entity, GameplayCharacterVOEvent VOEvent) { }

	// RVA: 0x213D2B0 Offset: 0x213B8B0 VA: 0x18213D2B0
	public EventNotifyVOAnnouncerEvent NotifyVOAnnouncerEvent(GameplayAnnouncerVOEvent VOEvent) { }

	// RVA: 0x213E2B0 Offset: 0x213C8B0 VA: 0x18213E2B0
	public EventOnPickupItem OnPickupItem(EntityRef Entity, int ItemID, QBoolean IsNewItem, int CurrentUse) { }

	// RVA: 0x213E6E0 Offset: 0x213CCE0 VA: 0x18213E6E0
	public EventOnUseItem OnUseItem(EntityRef Entity, int ItemID, int CurrentUse) { }

	// RVA: 0x213DC40 Offset: 0x213C240 VA: 0x18213DC40
	public EventOnDropItem OnDropItem(EntityRef Entity) { }

	// RVA: 0x21402B0 Offset: 0x213E8B0 VA: 0x1821402B0
	public EventShowTutorialStagePrompts ShowTutorialStagePrompts() { }

	// RVA: 0x2140070 Offset: 0x213E670 VA: 0x182140070
	public EventShowDialogue ShowDialogue(QString64 DialogueID) { }

	// RVA: 0x213F360 Offset: 0x213D960 VA: 0x18213F360
	public EventRaceTutorialLoadedAndReady RaceTutorialLoadedAndReady() { }

	// RVA: 0x213FBA0 Offset: 0x213E1A0 VA: 0x18213FBA0
	public EventSaveChapterBestTime SaveChapterBestTime(FP ChapterTime) { }

	// RVA: 0x213B1C0 Offset: 0x21397C0 VA: 0x18213B1C0
	public EventCampaignMatchLoadedAndReady CampaignMatchLoadedAndReady() { }

	// RVA: 0x213E9C0 Offset: 0x213CFC0 VA: 0x18213E9C0
	public EventPlayCampaignDialogue PlayCampaignDialogue() { }

	// RVA: 0x213F680 Offset: 0x213DC80 VA: 0x18213F680
	public EventRestartCampaignMatch RestartCampaignMatch() { }

	// RVA: 0x213B120 Offset: 0x2139720 VA: 0x18213B120
	public EventCampaignChapterCompleted CampaignChapterCompleted() { }

	// RVA: 0x213F2A0 Offset: 0x213D8A0 VA: 0x18213F2A0
	public EventPlayerWrongDirection PlayerWrongDirection(EntityRef CharacterEntity) { }

	// RVA: 0x213F1E0 Offset: 0x213D7E0 VA: 0x18213F1E0
	public EventPlayerNearDeath PlayerNearDeath(EntityRef CharacterEntity) { }

	// RVA: 0x213BDA0 Offset: 0x213A3A0 VA: 0x18213BDA0
	public EventEscapeRoomStarted EscapeRoomStarted() { }

	// RVA: 0x213BD00 Offset: 0x213A300 VA: 0x18213BD00
	public EventEscapeRoomCompleted EscapeRoomCompleted() { }

	// RVA: 0x213F720 Offset: 0x213DD20 VA: 0x18213F720
	public EventRestartEscapeRoomCourse RestartEscapeRoomCourse() { }

	// RVA: 0x213B080 Offset: 0x2139680 VA: 0x18213B080
	public EventBossFightStarted BossFightStarted() { }

	// RVA: 0x213AFE0 Offset: 0x21395E0 VA: 0x18213AFE0
	public EventBossFightCompleted BossFightCompleted() { }

	// RVA: 0x213F5E0 Offset: 0x213DBE0 VA: 0x18213F5E0
	public EventRestartBossFight RestartBossFight() { }

	// RVA: 0x2140D00 Offset: 0x213F300 VA: 0x182140D00
	public EventUpdateBossHealthPointsHUD UpdateBossHealthPointsHUD(QBoolean ReduceHealth, FP NewStamina) { }

	// RVA: 0x2140DC0 Offset: 0x213F3C0 VA: 0x182140DC0
	public EventUpdatePlayerHealthPointsHUD UpdatePlayerHealthPointsHUD(QBoolean ReduceHealth, FP NewStamina) { }

	// RVA: 0x213F4A0 Offset: 0x213DAA0 VA: 0x18213F4A0
	public EventResetPlayerHealthPointsHUD ResetPlayerHealthPointsHUD() { }

	// RVA: 0x213F400 Offset: 0x213DA00 VA: 0x18213F400
	public EventResetBossHealthPointsHUD ResetBossHealthPointsHUD() { }

	// RVA: 0x213B820 Offset: 0x2139E20 VA: 0x18213B820
	public EventDisableBossHealthHUD DisableBossHealthHUD() { }

	// RVA: 0x213FC60 Offset: 0x213E260 VA: 0x18213FC60
	public EventSetInitialBossHUDInfo SetInitialBossHUDInfo(FP InitialHealthPoints, QString64 BossID) { }

	// RVA: 0x213F860 Offset: 0x213DE60 VA: 0x18213F860
	public EventRestartLapsRace RestartLapsRace() { }

	// RVA: 0x213F7C0 Offset: 0x213DDC0 VA: 0x18213F7C0
	public EventRestartHazardsRace RestartHazardsRace() { }

	// RVA: 0x213CEA0 Offset: 0x213B4A0 VA: 0x18213CEA0
	public EventMechanicTutorialGoalsUpdated MechanicTutorialGoalsUpdated() { }

	// RVA: 0x213CF40 Offset: 0x213B540 VA: 0x18213CF40
	public EventMechanicTutorialStarted MechanicTutorialStarted() { }

	// RVA: 0x213CE00 Offset: 0x213B400 VA: 0x18213CE00
	public EventMechanicTutorialCompleted MechanicTutorialCompleted() { }

	// RVA: 0x2140A40 Offset: 0x213F040 VA: 0x182140A40
	public EventTutorialSectionFinished TutorialSectionFinished() { }

	// RVA: 0x213F9A0 Offset: 0x213DFA0 VA: 0x18213F9A0
	public EventRestartTutorialSection RestartTutorialSection() { }

	// RVA: 0x213F900 Offset: 0x213DF00 VA: 0x18213F900
	public EventRestartTrainingMatch RestartTrainingMatch() { }

	// RVA: 0x213CB30 Offset: 0x213B130 VA: 0x18213CB30
	public EventHazardsIncoming HazardsIncoming(HashString HazardType, int Direction) { }

	// RVA: 0x213CC00 Offset: 0x213B200 VA: 0x18213CC00
	public EventHideHazardsIndicators HideHazardsIndicators() { }

	// RVA: 0x213DB80 Offset: 0x213C180 VA: 0x18213DB80
	public EventOnCollectorScoreUpdate OnCollectorScoreUpdate(EntityRef Entity, int Score) { }

	// RVA: 0x213E120 Offset: 0x213C720 VA: 0x18213E120
	public EventOnLapFinished OnLapFinished(FP LapTime, EntityRef CharacterEntity) { }

	// RVA: 0x213CCA0 Offset: 0x213B2A0 VA: 0x18213CCA0
	public EventMatchStarted MatchStarted() { }

	// RVA: 0x2140150 Offset: 0x213E750 VA: 0x182140150
	public EventShowIntroAnimation ShowIntroAnimation() { }

	// RVA: 0x213FFD0 Offset: 0x213E5D0 VA: 0x18213FFD0
	public EventShowCountdownBannerAnimation ShowCountdownBannerAnimation() { }

	// RVA: 0x213EF50 Offset: 0x213D550 VA: 0x18213EF50
	public EventPlayStageMusicPart2 PlayStageMusicPart2() { }

	// RVA: 0x213B5E0 Offset: 0x2139BE0 VA: 0x18213B5E0
	public EventCountdownFinished CountdownFinished() { }

	// RVA: 0x2140BA0 Offset: 0x213F1A0 VA: 0x182140BA0
	public EventUpdateBlastzone UpdateBlastzone(SimpleAABB BlastzoneRect, QBoolean Reset) { }

	// RVA: 0x213B3C0 Offset: 0x21399C0 VA: 0x18213B3C0
	public EventCharacterKnockout CharacterKnockout(FPVector2 KnockedCharacterPosition, QBoolean ScreenExplosion) { }

	// RVA: 0x21401F0 Offset: 0x213E7F0 VA: 0x1821401F0
	public EventShowRaceRoundEndMessage ShowRaceRoundEndMessage(EntityRef WinnerEntity, int RoundsWon) { }

	// RVA: 0x213FB00 Offset: 0x213E100 VA: 0x18213FB00
	public EventRoundStart RoundStart() { }

	// RVA: 0x21408C0 Offset: 0x213EEC0 VA: 0x1821408C0
	public EventTimeRaceTimer TimeRaceTimer(FP Time) { }

	// RVA: 0x213F540 Offset: 0x213DB40 VA: 0x18213F540
	public EventResetRaceTimer ResetRaceTimer() { }

	// RVA: 0x213D1E0 Offset: 0x213B7E0 VA: 0x18213D1E0
	public EventNotifyRaceEnd NotifyRaceEnd(Frame Frame) { }

	// RVA: 0x213E4C0 Offset: 0x213CAC0 VA: 0x18213E4C0
	public EventOnResetRaceRound OnResetRaceRound() { }

	// RVA: 0x2140AE0 Offset: 0x213F0E0 VA: 0x182140AE0
	public EventUpdateBlastzoneTimer UpdateBlastzoneTimer(FP Countdown) { }

	// RVA: 0x213FA40 Offset: 0x213E040 VA: 0x18213FA40
	public EventRocketsIncoming RocketsIncoming(FP Time) { }

	// RVA: 0x2140350 Offset: 0x213E950 VA: 0x182140350
	public EventStayInTheAir StayInTheAir(PlayerRef PlayerRef) { }

	// RVA: 0x213E560 Offset: 0x213CB60 VA: 0x18213E560
	public EventOnSecretRoomDiscovered OnSecretRoomDiscovered(EntityRef TriggerEntity) { }

	// RVA: 0x2140980 Offset: 0x213EF80 VA: 0x182140980
	public EventTreasurePickedUp TreasurePickedUp(PlayerRef PlayerRef) { }

	// RVA: 0x213CFE0 Offset: 0x213B5E0 VA: 0x18213CFE0
	public EventNotifyBlockState NotifyBlockState(EntityRef Entity, QBoolean Blocking, FP BlockStamina) { }

	// RVA: 0x213BB90 Offset: 0x213A190 VA: 0x18213BB90
	public EventDrawDebugLine DrawDebugLine(FPVector2 Start, FPVector2 End, ColorRGBA Color) { }

	// RVA: 0x213BA20 Offset: 0x213A020 VA: 0x18213BA20
	public EventDrawDebugCircle DrawDebugCircle(FPVector2 Position, FP Radius, ColorRGBA Color) { }

	// RVA: 0x213B8C0 Offset: 0x2139EC0 VA: 0x18213B8C0
	public EventDrawDebugAABB DrawDebugAABB(SimpleAABB AABB, ColorRGBA Color) { }

	// RVA: 0x213B750 Offset: 0x2139D50 VA: 0x18213B750
	public EventDebugAlert DebugAlert(string Message) { }

	// RVA: 0x213B680 Offset: 0x2139C80 VA: 0x18213B680
	public EventCustomLogMessage CustomLogMessage(string Message) { }

	// RVA: 0x213D640 Offset: 0x213BC40 VA: 0x18213D640
	public EventOnCharacterActivation OnCharacterActivation(EntityRef Entity, CharacterActivationType ActivationType) { }

	// RVA: 0x213D7C0 Offset: 0x213BDC0 VA: 0x18213D7C0
	public EventOnCharacterDeactivation OnCharacterDeactivation(EntityRef Entity) { }

	// RVA: 0x213D940 Offset: 0x213BF40 VA: 0x18213D940
	public EventOnCharacterLoaded OnCharacterLoaded(EntityRef Entity) { }

	// RVA: 0x213EA60 Offset: 0x213D060 VA: 0x18213EA60
	public EventPlayCharacterFootstepSFX PlayCharacterFootstepSFX(EntityRef Entity, int EventID, SurfaceType SurfaceType) { }

	// RVA: 0x213D880 Offset: 0x213BE80 VA: 0x18213D880
	public EventOnCharacterKnockOut OnCharacterKnockOut(EntityRef Entity) { }

	// RVA: 0x213D700 Offset: 0x213BD00 VA: 0x18213D700
	public EventOnCharacterDamageUpdate OnCharacterDamageUpdate(EntityRef CharacterEntity, FP Damage) { }

	// RVA: 0x213DAC0 Offset: 0x213C0C0 VA: 0x18213DAC0
	public EventOnCharacterStocksUpdate OnCharacterStocksUpdate(EntityRef CharacterEntity, int Stocks) { }

	// RVA: 0x213DA00 Offset: 0x213C000 VA: 0x18213DA00
	public EventOnCharacterStaminaUpdate OnCharacterStaminaUpdate(EntityRef CharacterEntity, FP Stamina) { }

	// RVA: 0x213EFF0 Offset: 0x213D5F0 VA: 0x18213EFF0
	public EventPlayStageMusic PlayStageMusic() { }

	// RVA: 0x213ED70 Offset: 0x213D370 VA: 0x18213ED70
	public EventPlaySFX PlaySFX(QString256 EventID, FPVector2 Location, FP Delay, QBoolean UpdateSoundPosition, EntityRef EntityRef) { }

	// RVA: 0x213FD40 Offset: 0x213E340 VA: 0x18213FD40
	public EventSetSFXParameter SetSFXParameter(QString128 EventID, QString128 ParameterID, QString128 ParameterStringValue, FP ParameterFloatValue, EntityRef EntityRef, QBoolean StringParameter, QBoolean GlobalParameters) { }

	// RVA: 0x21404D0 Offset: 0x213EAD0 VA: 0x1821404D0
	public EventStopSFX StopSFX(QString256 EventID, EntityRef EntityRef) { }

	// RVA: 0x213EBC0 Offset: 0x213D1C0 VA: 0x18213EBC0
	public EventPlayNonDeterministicAnimation PlayNonDeterministicAnimation(QString128 TriggerID, EntityRef EntityRef) { }

	// RVA: 0x2140760 Offset: 0x213ED60 VA: 0x182140760
	public EventSyncTimeline SyncTimeline(FP SyncValue) { }

	// RVA: 0x213BE40 Offset: 0x213A440 VA: 0x18213BE40
	public EventGameEntityVisibilityChanged GameEntityVisibilityChanged(EntityRef GameEntity, QBoolean Visible) { }

	// RVA: 0x213B480 Offset: 0x2139A80 VA: 0x18213B480
	public EventClearSlots ClearSlots(int EntityIndex) { }

	// RVA: 0x213F090 Offset: 0x213D690 VA: 0x18213F090
	public EventPlayVFX PlayVFX(int VFXID, EntityRef Entity, VFXPlayAttributes PlayAttributes) { }

	// RVA: 0x2140690 Offset: 0x213EC90 VA: 0x182140690
	public EventStopVFX StopVFX(int VFXID, int EntityIndex, VFXStopAttributes StopAttributes) { }

	// RVA: 0x2140410 Offset: 0x213EA10 VA: 0x182140410
	public EventStopAllVFX StopAllVFX(int EntityIndex) { }

	// RVA: 0x213E1E0 Offset: 0x213C7E0 VA: 0x18213E1E0
	public EventOnLoadingFinished OnLoadingFinished(Frame Frame) { }

	// RVA: 0x213E420 Offset: 0x213CA20 VA: 0x18213E420
	public EventOnPlayersInputEnabled OnPlayersInputEnabled() { }

	// RVA: 0x213D140 Offset: 0x213B740 VA: 0x18213D140
	public EventNotifyMatchFinished NotifyMatchFinished() { }

	// RVA: 0x213E620 Offset: 0x213CC20 VA: 0x18213E620
	public EventOnUpdateTimeScale OnUpdateTimeScale(FP TimeScale) { }

	// RVA: 0x213E840 Offset: 0x213CE40 VA: 0x18213E840
	public EventPlayCameraShake PlayCameraShake(int PresetID, QBoolean OverrideForce, FP Force, QBoolean OverrideVelocity, FPVector3 Velocity) { }

	// RVA: 0x213D570 Offset: 0x213BB70 VA: 0x18213D570
	public EventOnCameraUpdateForced OnCameraUpdateForced(SimpleAABB CameraRect) { }

	// RVA: 0x213DE60 Offset: 0x213C460 VA: 0x18213DE60
	public EventOnEntityStartGrab OnEntityStartGrab(EntityRef Entity) { }

	// RVA: 0x213DFC0 Offset: 0x213C5C0 VA: 0x18213DFC0
	public EventOnEntityStopGrab OnEntityStopGrab(EntityRef Entity) { }

	// RVA: 0x213DDA0 Offset: 0x213C3A0 VA: 0x18213DDA0
	public EventOnEnergyBarUpdate OnEnergyBarUpdate(EntityRef Entity, FP EnergyAmount) { }

	// RVA: 0x213CD40 Offset: 0x213B340 VA: 0x18213CD40
	public EventMatchTimerUpdate MatchTimerUpdate(FP CurrentTime) { }

	// RVA: 0x6AB620 Offset: 0x6A9C20 VA: 0x1806AB620
	public void .ctor(Frame f) { }
}
