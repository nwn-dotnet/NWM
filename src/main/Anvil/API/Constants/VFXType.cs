using NWN.Core;

namespace Anvil.API
{
  public enum VfxType
  {
    None = NWScript.VFX_NONE,
    DurBlur = NWScript.VFX_DUR_BLUR,
    DurDarkness = NWScript.VFX_DUR_DARKNESS,
    DurEntangle = NWScript.VFX_DUR_ENTANGLE,
    DurFreedomOfMovement = NWScript.VFX_DUR_FREEDOM_OF_MOVEMENT,
    DurGlobeInvulnerability = NWScript.VFX_DUR_GLOBE_INVULNERABILITY,
    DurBlackout = NWScript.VFX_DUR_BLACKOUT,
    DurInvisibility = NWScript.VFX_DUR_INVISIBILITY,
    DurMindAffectingNegative = NWScript.VFX_DUR_MIND_AFFECTING_NEGATIVE,
    DurMindAffectingPositive = NWScript.VFX_DUR_MIND_AFFECTING_POSITIVE,
    DurGhostlyVisage = NWScript.VFX_DUR_GHOSTLY_VISAGE,
    DurEtherealVisage = NWScript.VFX_DUR_ETHEREAL_VISAGE,
    DurProtBarkskin = NWScript.VFX_DUR_PROT_BARKSKIN,
    DurProtGreaterStoneskin = NWScript.VFX_DUR_PROT_GREATER_STONESKIN,
    DurProtPremonition = NWScript.VFX_DUR_PROT_PREMONITION,
    DurProtShadowArmor = NWScript.VFX_DUR_PROT_SHADOW_ARMOR,
    DurProtStoneskin = NWScript.VFX_DUR_PROT_STONESKIN,
    DurSanctuary = NWScript.VFX_DUR_SANCTUARY,
    DurWeb = NWScript.VFX_DUR_WEB,
    FnfBlinddeaf = NWScript.VFX_FNF_BLINDDEAF,
    FnfDispel = NWScript.VFX_FNF_DISPEL,
    FnfDispelDisjunction = NWScript.VFX_FNF_DISPEL_DISJUNCTION,
    FnfDispelGreater = NWScript.VFX_FNF_DISPEL_GREATER,
    FnfFireball = NWScript.VFX_FNF_FIREBALL,
    FnfFirestorm = NWScript.VFX_FNF_FIRESTORM,
    FnfImplosion = NWScript.VFX_FNF_IMPLOSION,
    FnfMassHeal = NWScript.VFX_FNF_MASS_HEAL,
    FnfMassMindAffecting = NWScript.VFX_FNF_MASS_MIND_AFFECTING,
    FnfMeteorSwarm = NWScript.VFX_FNF_METEOR_SWARM,
    FnfNaturesBalance = NWScript.VFX_FNF_NATURES_BALANCE,
    FnfPwkill = NWScript.VFX_FNF_PWKILL,
    FnfPwstun = NWScript.VFX_FNF_PWSTUN,
    FnfSummonGate = NWScript.VFX_FNF_SUMMON_GATE,
    FnfSummonMonster1 = NWScript.VFX_FNF_SUMMON_MONSTER_1,
    FnfSummonMonster2 = NWScript.VFX_FNF_SUMMON_MONSTER_2,
    FnfSummonMonster3 = NWScript.VFX_FNF_SUMMON_MONSTER_3,
    FnfSummonUndead = NWScript.VFX_FNF_SUMMON_UNDEAD,
    FnfSunbeam = NWScript.VFX_FNF_SUNBEAM,
    FnfTimeStop = NWScript.VFX_FNF_TIME_STOP,
    FnfWailOBanshees = NWScript.VFX_FNF_WAIL_O_BANSHEES,
    FnfWeird = NWScript.VFX_FNF_WEIRD,
    FnfWord = NWScript.VFX_FNF_WORD,
    ImpAcBonus = NWScript.VFX_IMP_AC_BONUS,
    ImpAcidL = NWScript.VFX_IMP_ACID_L,
    ImpAcidS = NWScript.VFX_IMP_ACID_S,
    ImpBlindDeafM = NWScript.VFX_IMP_BLIND_DEAF_M,
    ImpBreach = NWScript.VFX_IMP_BREACH,
    ImpConfusionS = NWScript.VFX_IMP_CONFUSION_S,
    ImpDazedS = NWScript.VFX_IMP_DAZED_S,
    ImpDeath = NWScript.VFX_IMP_DEATH,
    ImpDiseaseS = NWScript.VFX_IMP_DISEASE_S,
    ImpDispel = NWScript.VFX_IMP_DISPEL,
    ImpDispelDisjunction = NWScript.VFX_IMP_DISPEL_DISJUNCTION,
    ImpDivineStrikeFire = NWScript.VFX_IMP_DIVINE_STRIKE_FIRE,
    ImpDivineStrikeHoly = NWScript.VFX_IMP_DIVINE_STRIKE_HOLY,
    ImpDominateS = NWScript.VFX_IMP_DOMINATE_S,
    ImpDoom = NWScript.VFX_IMP_DOOM,
    ImpFearS = NWScript.VFX_IMP_FEAR_S,
    ImpFlameM = NWScript.VFX_IMP_FLAME_M,
    ImpFlameS = NWScript.VFX_IMP_FLAME_S,
    ImpFrostL = NWScript.VFX_IMP_FROST_L,
    ImpFrostS = NWScript.VFX_IMP_FROST_S,
    ImpGrease = NWScript.VFX_IMP_GREASE,
    ImpHaste = NWScript.VFX_IMP_HASTE,
    ImpHealingG = NWScript.VFX_IMP_HEALING_G,
    ImpHealingL = NWScript.VFX_IMP_HEALING_L,
    ImpHealingM = NWScript.VFX_IMP_HEALING_M,
    ImpHealingS = NWScript.VFX_IMP_HEALING_S,
    ImpHealingX = NWScript.VFX_IMP_HEALING_X,
    ImpHolyAid = NWScript.VFX_IMP_HOLY_AID,
    ImpKnock = NWScript.VFX_IMP_KNOCK,
    BeamLightning = NWScript.VFX_BEAM_LIGHTNING,
    ImpLightningM = NWScript.VFX_IMP_LIGHTNING_M,
    ImpLightningS = NWScript.VFX_IMP_LIGHTNING_S,
    ImpMagblue = NWScript.VFX_IMP_MAGBLUE,
    ImpNegativeEnergy = NWScript.VFX_IMP_NEGATIVE_ENERGY,
    DurParalyzeHold = NWScript.VFX_DUR_PARALYZE_HOLD,
    ImpPoisonL = NWScript.VFX_IMP_POISON_L,
    ImpPoisonS = NWScript.VFX_IMP_POISON_S,
    ImpPolymorph = NWScript.VFX_IMP_POLYMORPH,
    ImpPulseCold = NWScript.VFX_IMP_PULSE_COLD,
    ImpPulseFire = NWScript.VFX_IMP_PULSE_FIRE,
    ImpPulseHoly = NWScript.VFX_IMP_PULSE_HOLY,
    ImpPulseNegative = NWScript.VFX_IMP_PULSE_NEGATIVE,
    ImpRaiseDead = NWScript.VFX_IMP_RAISE_DEAD,
    ImpReduceAbilityScore = NWScript.VFX_IMP_REDUCE_ABILITY_SCORE,
    ImpRemoveCondition = NWScript.VFX_IMP_REMOVE_CONDITION,
    ImpSilence = NWScript.VFX_IMP_SILENCE,
    ImpSleep = NWScript.VFX_IMP_SLEEP,
    ImpSlow = NWScript.VFX_IMP_SLOW,
    ImpSonic = NWScript.VFX_IMP_SONIC,
    ImpStun = NWScript.VFX_IMP_STUN,
    ImpSunstrike = NWScript.VFX_IMP_SUNSTRIKE,
    ImpUnsummon = NWScript.VFX_IMP_UNSUMMON,
    ComSpecialBlueRed = NWScript.VFX_COM_SPECIAL_BLUE_RED,
    ComSpecialPinkOrange = NWScript.VFX_COM_SPECIAL_PINK_ORANGE,
    ComSpecialRedWhite = NWScript.VFX_COM_SPECIAL_RED_WHITE,
    ComSpecialRedOrange = NWScript.VFX_COM_SPECIAL_RED_ORANGE,
    ComSpecialWhiteBlue = NWScript.VFX_COM_SPECIAL_WHITE_BLUE,
    ComSpecialWhiteOrange = NWScript.VFX_COM_SPECIAL_WHITE_ORANGE,
    ComBloodRegWimp = NWScript.VFX_COM_BLOOD_REG_WIMP,
    ComBloodLrgWimp = NWScript.VFX_COM_BLOOD_LRG_WIMP,
    ComBloodCrtWimp = NWScript.VFX_COM_BLOOD_CRT_WIMP,
    ComBloodRegRed = NWScript.VFX_COM_BLOOD_REG_RED,
    ComBloodRegGreen = NWScript.VFX_COM_BLOOD_REG_GREEN,
    ComBloodRegYellow = NWScript.VFX_COM_BLOOD_REG_YELLOW,
    ComBloodLrgRed = NWScript.VFX_COM_BLOOD_LRG_RED,
    ComBloodLrgGreen = NWScript.VFX_COM_BLOOD_LRG_GREEN,
    ComBloodLrgYellow = NWScript.VFX_COM_BLOOD_LRG_YELLOW,
    ComBloodCrtRed = NWScript.VFX_COM_BLOOD_CRT_RED,
    ComBloodCrtGreen = NWScript.VFX_COM_BLOOD_CRT_GREEN,
    ComBloodCrtYellow = NWScript.VFX_COM_BLOOD_CRT_YELLOW,
    ComSparksParry = NWScript.VFX_COM_SPARKS_PARRY,
    ComUnloadModel = NWScript.VFX_COM_UNLOAD_MODEL,
    ComChunkRedSmall = NWScript.VFX_COM_CHUNK_RED_SMALL,
    ComChunkRedMedium = NWScript.VFX_COM_CHUNK_RED_MEDIUM,
    ComChunkGreenSmall = NWScript.VFX_COM_CHUNK_GREEN_SMALL,
    ComChunkGreenMedium = NWScript.VFX_COM_CHUNK_GREEN_MEDIUM,
    ComChunkYellowSmall = NWScript.VFX_COM_CHUNK_YELLOW_SMALL,
    ComChunkYellowMedium = NWScript.VFX_COM_CHUNK_YELLOW_MEDIUM,
    DurSpellturning = NWScript.VFX_DUR_SPELLTURNING,
    ImpImproveAbilityScore = NWScript.VFX_IMP_IMPROVE_ABILITY_SCORE,
    ImpCharm = NWScript.VFX_IMP_CHARM,
    ImpMagicalVision = NWScript.VFX_IMP_MAGICAL_VISION,
    ImpEvilHelp = NWScript.VFX_IMP_EVIL_HELP,
    ImpGoodHelp = NWScript.VFX_IMP_GOOD_HELP,
    ImpDeathWard = NWScript.VFX_IMP_DEATH_WARD,
    DurElementalShield = NWScript.VFX_DUR_ELEMENTAL_SHIELD,
    DurLight = NWScript.VFX_DUR_LIGHT,
    ImpMagicProtection = NWScript.VFX_IMP_MAGIC_PROTECTION,
    ImpSuperHeroism = NWScript.VFX_IMP_SUPER_HEROISM,
    FnfStorm = NWScript.VFX_FNF_STORM,
    ImpElementalProtection = NWScript.VFX_IMP_ELEMENTAL_PROTECTION,
    DurLightBlue5 = NWScript.VFX_DUR_LIGHT_BLUE_5,
    DurLightBlue10 = NWScript.VFX_DUR_LIGHT_BLUE_10,
    DurLightBlue15 = NWScript.VFX_DUR_LIGHT_BLUE_15,
    DurLightBlue20 = NWScript.VFX_DUR_LIGHT_BLUE_20,
    DurLightYellow5 = NWScript.VFX_DUR_LIGHT_YELLOW_5,
    DurLightYellow10 = NWScript.VFX_DUR_LIGHT_YELLOW_10,
    DurLightYellow15 = NWScript.VFX_DUR_LIGHT_YELLOW_15,
    DurLightYellow20 = NWScript.VFX_DUR_LIGHT_YELLOW_20,
    DurLightPurple5 = NWScript.VFX_DUR_LIGHT_PURPLE_5,
    DurLightPurple10 = NWScript.VFX_DUR_LIGHT_PURPLE_10,
    DurLightPurple15 = NWScript.VFX_DUR_LIGHT_PURPLE_15,
    DurLightPurple20 = NWScript.VFX_DUR_LIGHT_PURPLE_20,
    DurLightRed5 = NWScript.VFX_DUR_LIGHT_RED_5,
    DurLightRed10 = NWScript.VFX_DUR_LIGHT_RED_10,
    DurLightRed15 = NWScript.VFX_DUR_LIGHT_RED_15,
    DurLightRed20 = NWScript.VFX_DUR_LIGHT_RED_20,
    DurLightOrange5 = NWScript.VFX_DUR_LIGHT_ORANGE_5,
    DurLightOrange10 = NWScript.VFX_DUR_LIGHT_ORANGE_10,
    DurLightOrange15 = NWScript.VFX_DUR_LIGHT_ORANGE_15,
    DurLightOrange20 = NWScript.VFX_DUR_LIGHT_ORANGE_20,
    DurLightWhite5 = NWScript.VFX_DUR_LIGHT_WHITE_5,
    DurLightWhite10 = NWScript.VFX_DUR_LIGHT_WHITE_10,
    DurLightWhite15 = NWScript.VFX_DUR_LIGHT_WHITE_15,
    DurLightWhite20 = NWScript.VFX_DUR_LIGHT_WHITE_20,
    DurLightGrey5 = NWScript.VFX_DUR_LIGHT_GREY_5,
    DurLightGrey10 = NWScript.VFX_DUR_LIGHT_GREY_10,
    DurLightGrey15 = NWScript.VFX_DUR_LIGHT_GREY_15,
    DurLightGrey20 = NWScript.VFX_DUR_LIGHT_GREY_20,
    ImpMirv = NWScript.VFX_IMP_MIRV,
    DurDarkvision = NWScript.VFX_DUR_DARKVISION,
    FnfSoundBurst = NWScript.VFX_FNF_SOUND_BURST,
    FnfStrikeHoly = NWScript.VFX_FNF_STRIKE_HOLY,
    FnfLosEvil10 = NWScript.VFX_FNF_LOS_EVIL_10,
    FnfLosEvil20 = NWScript.VFX_FNF_LOS_EVIL_20,
    FnfLosEvil30 = NWScript.VFX_FNF_LOS_EVIL_30,
    FnfLosHoly10 = NWScript.VFX_FNF_LOS_HOLY_10,
    FnfLosHoly20 = NWScript.VFX_FNF_LOS_HOLY_20,
    FnfLosHoly30 = NWScript.VFX_FNF_LOS_HOLY_30,
    FnfLosNormal10 = NWScript.VFX_FNF_LOS_NORMAL_10,
    FnfLosNormal20 = NWScript.VFX_FNF_LOS_NORMAL_20,
    FnfLosNormal30 = NWScript.VFX_FNF_LOS_NORMAL_30,
    ImpHeadAcid = NWScript.VFX_IMP_HEAD_ACID,
    ImpHeadFire = NWScript.VFX_IMP_HEAD_FIRE,
    ImpHeadSonic = NWScript.VFX_IMP_HEAD_SONIC,
    ImpHeadElectricity = NWScript.VFX_IMP_HEAD_ELECTRICITY,
    ImpHeadCold = NWScript.VFX_IMP_HEAD_COLD,
    ImpHeadHoly = NWScript.VFX_IMP_HEAD_HOLY,
    ImpHeadNature = NWScript.VFX_IMP_HEAD_NATURE,
    ImpHeadHeal = NWScript.VFX_IMP_HEAD_HEAL,
    ImpHeadMind = NWScript.VFX_IMP_HEAD_MIND,
    ImpHeadEvil = NWScript.VFX_IMP_HEAD_EVIL,
    ImpHeadOdd = NWScript.VFX_IMP_HEAD_ODD,
    DurCessateNeutral = NWScript.VFX_DUR_CESSATE_NEUTRAL,
    DurCessatePositive = NWScript.VFX_DUR_CESSATE_POSITIVE,
    DurCessateNegative = NWScript.VFX_DUR_CESSATE_NEGATIVE,
    DurMindAffectingDisabled = NWScript.VFX_DUR_MIND_AFFECTING_DISABLED,
    DurMindAffectingDominated = NWScript.VFX_DUR_MIND_AFFECTING_DOMINATED,
    BeamFire = NWScript.VFX_BEAM_FIRE,
    BeamCold = NWScript.VFX_BEAM_COLD,
    BeamHoly = NWScript.VFX_BEAM_HOLY,
    BeamMind = NWScript.VFX_BEAM_MIND,
    BeamEvil = NWScript.VFX_BEAM_EVIL,
    BeamOdd = NWScript.VFX_BEAM_ODD,
    BeamFireLash = NWScript.VFX_BEAM_FIRE_LASH,
    ImpDeathL = NWScript.VFX_IMP_DEATH_L,
    DurMindAffectingFear = NWScript.VFX_DUR_MIND_AFFECTING_FEAR,
    FnfSummonCelestial = NWScript.VFX_FNF_SUMMON_CELESTIAL,
    DurGlobeMinor = NWScript.VFX_DUR_GLOBE_MINOR,
    ImpRestorationLesser = NWScript.VFX_IMP_RESTORATION_LESSER,
    ImpRestoration = NWScript.VFX_IMP_RESTORATION,
    ImpRestorationGreater = NWScript.VFX_IMP_RESTORATION_GREATER,
    DurProtectionElements = NWScript.VFX_DUR_PROTECTION_ELEMENTS,
    DurProtectionGoodMinor = NWScript.VFX_DUR_PROTECTION_GOOD_MINOR,
    DurProtectionGoodMajor = NWScript.VFX_DUR_PROTECTION_GOOD_MAJOR,
    DurProtectionEvilMinor = NWScript.VFX_DUR_PROTECTION_EVIL_MINOR,
    DurProtectionEvilMajor = NWScript.VFX_DUR_PROTECTION_EVIL_MAJOR,
    DurMagicalSight = NWScript.VFX_DUR_MAGICAL_SIGHT,
    DurWebMass = NWScript.VFX_DUR_WEB_MASS,
    FnfIcestorm = NWScript.VFX_FNF_ICESTORM,
    DurParalyzed = NWScript.VFX_DUR_PARALYZED,
    ImpMirvFlame = NWScript.VFX_IMP_MIRV_FLAME,
    ImpDestruction = NWScript.VFX_IMP_DESTRUCTION,
    ComChunkRedLarge = NWScript.VFX_COM_CHUNK_RED_LARGE,
    ComChunkBoneMedium = NWScript.VFX_COM_CHUNK_BONE_MEDIUM,
    ComBloodSparkSmall = NWScript.VFX_COM_BLOOD_SPARK_SMALL,
    ComBloodSparkMedium = NWScript.VFX_COM_BLOOD_SPARK_MEDIUM,
    ComBloodSparkLarge = NWScript.VFX_COM_BLOOD_SPARK_LARGE,
    DurGhostlyPulse = NWScript.VFX_DUR_GHOSTLY_PULSE,
    FnfHorridWilting = NWScript.VFX_FNF_HORRID_WILTING,
    DurBlindvision = NWScript.VFX_DUR_BLINDVISION,
    DurLowlightvision = NWScript.VFX_DUR_LOWLIGHTVISION,
    DurUltravision = NWScript.VFX_DUR_ULTRAVISION,
    DurMirvAcid = NWScript.VFX_DUR_MIRV_ACID,
    ImpHarm = NWScript.VFX_IMP_HARM,
    DurBlind = NWScript.VFX_DUR_BLIND,
    DurAntiLight10 = NWScript.VFX_DUR_ANTI_LIGHT_10,
    DurMagicResistance = NWScript.VFX_DUR_MAGIC_RESISTANCE,
    ImpMagicResistanceUse = NWScript.VFX_IMP_MAGIC_RESISTANCE_USE,
    ImpGlobeUse = NWScript.VFX_IMP_GLOBE_USE,
    ImpWillSavingThrowUse = NWScript.VFX_IMP_WILL_SAVING_THROW_USE,
    ImpSpikeTrap = NWScript.VFX_IMP_SPIKE_TRAP,
    ImpSpellMantleUse = NWScript.VFX_IMP_SPELL_MANTLE_USE,
    ImpFortitudeSavingThrowUse = NWScript.VFX_IMP_FORTITUDE_SAVING_THROW_USE,
    ImpReflexSaveThrowUse = NWScript.VFX_IMP_REFLEX_SAVE_THROW_USE,
    FnfGasExplosionAcid = NWScript.VFX_FNF_GAS_EXPLOSION_ACID,
    FnfGasExplosionEvil = NWScript.VFX_FNF_GAS_EXPLOSION_EVIL,
    FnfGasExplosionNature = NWScript.VFX_FNF_GAS_EXPLOSION_NATURE,
    FnfGasExplosionFire = NWScript.VFX_FNF_GAS_EXPLOSION_FIRE,
    FnfGasExplosionGrease = NWScript.VFX_FNF_GAS_EXPLOSION_GREASE,
    FnfGasExplosionMind = NWScript.VFX_FNF_GAS_EXPLOSION_MIND,
    FnfSmokePuff = NWScript.VFX_FNF_SMOKE_PUFF,
    ImpPulseWater = NWScript.VFX_IMP_PULSE_WATER,
    ImpPulseWind = NWScript.VFX_IMP_PULSE_WIND,
    ImpPulseNature = NWScript.VFX_IMP_PULSE_NATURE,
    DurAuraCold = NWScript.VFX_DUR_AURA_COLD,
    DurAuraFire = NWScript.VFX_DUR_AURA_FIRE,
    DurAuraPoison = NWScript.VFX_DUR_AURA_POISON,
    DurAuraDisease = NWScript.VFX_DUR_AURA_DISEASE,
    DurAuraOdd = NWScript.VFX_DUR_AURA_ODD,
    DurAuraSilence = NWScript.VFX_DUR_AURA_SILENCE,
    ImpAuraHoly = NWScript.VFX_IMP_AURA_HOLY,
    ImpAuraUnearthly = NWScript.VFX_IMP_AURA_UNEARTHLY,
    ImpAuraFear = NWScript.VFX_IMP_AURA_FEAR,
    ImpAuraNegativeEnergy = NWScript.VFX_IMP_AURA_NEGATIVE_ENERGY,
    DurBardSong = NWScript.VFX_DUR_BARD_SONG,
    FnfHowlMind = NWScript.VFX_FNF_HOWL_MIND,
    FnfHowlOdd = NWScript.VFX_FNF_HOWL_ODD,
    ComHitFire = NWScript.VFX_COM_HIT_FIRE,
    ComHitFrost = NWScript.VFX_COM_HIT_FROST,
    ComHitElectrical = NWScript.VFX_COM_HIT_ELECTRICAL,
    ComHitAcid = NWScript.VFX_COM_HIT_ACID,
    ComHitSonic = NWScript.VFX_COM_HIT_SONIC,
    FnfHowlWarCry = NWScript.VFX_FNF_HOWL_WAR_CRY,
    FnfScreenShake = NWScript.VFX_FNF_SCREEN_SHAKE,
    FnfScreenBump = NWScript.VFX_FNF_SCREEN_BUMP,
    ComHitNegative = NWScript.VFX_COM_HIT_NEGATIVE,
    ComHitDivine = NWScript.VFX_COM_HIT_DIVINE,
    FnfHowlWarCryFemale = NWScript.VFX_FNF_HOWL_WAR_CRY_FEMALE,
    DurAuraDragonFear = NWScript.VFX_DUR_AURA_DRAGON_FEAR,
    DurFlagRed = NWScript.VFX_DUR_FLAG_RED,
    DurFlagBlue = NWScript.VFX_DUR_FLAG_BLUE,
    DurFlagGold = NWScript.VFX_DUR_FLAG_GOLD,
    DurFlagPurple = NWScript.VFX_DUR_FLAG_PURPLE,
    DurFlagGoldFixed = NWScript.VFX_DUR_FLAG_GOLD_FIXED,
    DurFlagPurpleFixed = NWScript.VFX_DUR_FLAG_PURPLE_FIXED,
    DurTentacle = NWScript.VFX_DUR_TENTACLE,
    DurPetrify = NWScript.VFX_DUR_PETRIFY,
    DurFreezeAnimation = NWScript.VFX_DUR_FREEZE_ANIMATION,
    ComChunkStoneSmall = NWScript.VFX_COM_CHUNK_STONE_SMALL,
    ComChunkStoneMedium = NWScript.VFX_COM_CHUNK_STONE_MEDIUM,
    BeamSilentLightning = NWScript.VFX_BEAM_SILENT_LIGHTNING,
    BeamSilentFire = NWScript.VFX_BEAM_SILENT_FIRE,
    BeamSilentCold = NWScript.VFX_BEAM_SILENT_COLD,
    BeamSilentHoly = NWScript.VFX_BEAM_SILENT_HOLY,
    BeamSilentMind = NWScript.VFX_BEAM_SILENT_MIND,
    BeamSilentEvil = NWScript.VFX_BEAM_SILENT_EVIL,
    BeamSilentOdd = NWScript.VFX_BEAM_SILENT_ODD,
    DurBigbysInterposingHand = NWScript.VFX_DUR_BIGBYS_INTERPOSING_HAND,
    ImpBigbysForcefulHand = NWScript.VFX_IMP_BIGBYS_FORCEFUL_HAND,
    DurBigbysClenchedFist = NWScript.VFX_DUR_BIGBYS_CLENCHED_FIST,
    DurBigbysCrushingHand = NWScript.VFX_DUR_BIGBYS_CRUSHING_HAND,
    DurBigbysGraspingHand = NWScript.VFX_DUR_BIGBYS_GRASPING_HAND,
    DurCaltrops = NWScript.VFX_DUR_CALTROPS,
    DurSmoke = NWScript.VFX_DUR_SMOKE,
    DurPixiedust = NWScript.VFX_DUR_PIXIEDUST,
    FnfDeck = NWScript.VFX_FNF_DECK,
    DurCutsceneInvisibility = NWScript.VFX_DUR_CUTSCENE_INVISIBILITY,
    EyesRedFlameHumanMale = NWScript.VFX_EYES_RED_FLAME_HUMAN_MALE,
    EyesRedFlameHumanFemale = NWScript.VFX_EYES_RED_FLAME_HUMAN_FEMALE,
    EyesRedFlameHalfelfMale = NWScript.VFX_EYES_RED_FLAME_HALFELF_MALE,
    EyesRedFlameHalfelfFemale = NWScript.VFX_EYES_RED_FLAME_HALFELF_FEMALE,
    EyesRedFlameDwarfMale = NWScript.VFX_EYES_RED_FLAME_DWARF_MALE,
    EyesRedFlameDwarfFemale = NWScript.VFX_EYES_RED_FLAME_DWARF_FEMALE,
    EyesRedFlameElfMale = NWScript.VFX_EYES_RED_FLAME_ELF_MALE,
    EyesRedFlameElfFemale = NWScript.VFX_EYES_RED_FLAME_ELF_FEMALE,
    EyesRedFlameGnomeMale = NWScript.VFX_EYES_RED_FLAME_GNOME_MALE,
    EyesRedFlameGnomeFemale = NWScript.VFX_EYES_RED_FLAME_GNOME_FEMALE,
    EyesRedFlameHalflingMale = NWScript.VFX_EYES_RED_FLAME_HALFLING_MALE,
    EyesRedFlameHalflingFemale = NWScript.VFX_EYES_RED_FLAME_HALFLING_FEMALE,
    EyesRedFlameHalforcMale = NWScript.VFX_EYES_RED_FLAME_HALFORC_MALE,
    EyesRedFlameHalforcFemale = NWScript.VFX_EYES_RED_FLAME_HALFORC_FEMALE,
    EyesRedFlameTroglodyte = NWScript.VFX_EYES_RED_FLAME_TROGLODYTE,
    EyesYelHumanMale = NWScript.VFX_EYES_YEL_HUMAN_MALE,
    EyesYelHumanFemale = NWScript.VFX_EYES_YEL_HUMAN_FEMALE,
    EyesYelDwarfMale = NWScript.VFX_EYES_YEL_DWARF_MALE,
    EyesYelDwarfFemale = NWScript.VFX_EYES_YEL_DWARF_FEMALE,
    EyesYelElfMale = NWScript.VFX_EYES_YEL_ELF_MALE,
    EyesYelElfFemale = NWScript.VFX_EYES_YEL_ELF_FEMALE,
    EyesYelGnomeMale = NWScript.VFX_EYES_YEL_GNOME_MALE,
    EyesYelGnomeFemale = NWScript.VFX_EYES_YEL_GNOME_FEMALE,
    EyesYelHalflingMale = NWScript.VFX_EYES_YEL_HALFLING_MALE,
    EyesYelHalflingFemale = NWScript.VFX_EYES_YEL_HALFLING_FEMALE,
    EyesYelHalforcMale = NWScript.VFX_EYES_YEL_HALFORC_MALE,
    EyesYelHalforcFemale = NWScript.VFX_EYES_YEL_HALFORC_FEMALE,
    EyesYelTroglodyte = NWScript.VFX_EYES_YEL_TROGLODYTE,
    EyesOrgHumanMale = NWScript.VFX_EYES_ORG_HUMAN_MALE,
    EyesOrgHumanFemale = NWScript.VFX_EYES_ORG_HUMAN_FEMALE,
    EyesOrgDwarfMale = NWScript.VFX_EYES_ORG_DWARF_MALE,
    EyesOrgDwarfFemale = NWScript.VFX_EYES_ORG_DWARF_FEMALE,
    EyesOrgElfMale = NWScript.VFX_EYES_ORG_ELF_MALE,
    EyesOrgElfFemale = NWScript.VFX_EYES_ORG_ELF_FEMALE,
    EyesOrgGnomeMale = NWScript.VFX_EYES_ORG_GNOME_MALE,
    EyesOrgGnomeFemale = NWScript.VFX_EYES_ORG_GNOME_FEMALE,
    EyesOrgHalflingMale = NWScript.VFX_EYES_ORG_HALFLING_MALE,
    EyesOrgHalflingFemale = NWScript.VFX_EYES_ORG_HALFLING_FEMALE,
    EyesOrgHalforcMale = NWScript.VFX_EYES_ORG_HALFORC_MALE,
    EyesOrgHalforcFemale = NWScript.VFX_EYES_ORG_HALFORC_FEMALE,
    EyesOrgTroglodyte = NWScript.VFX_EYES_ORG_TROGLODYTE,
    DurIounstone = NWScript.VFX_DUR_IOUNSTONE,
    ImpTornado = NWScript.VFX_IMP_TORNADO,
    DurGlowLightBlue = NWScript.VFX_DUR_GLOW_LIGHT_BLUE,
    DurGlowPurple = NWScript.VFX_DUR_GLOW_PURPLE,
    DurGlowBlue = NWScript.VFX_DUR_GLOW_BLUE,
    DurGlowRed = NWScript.VFX_DUR_GLOW_RED,
    DurGlowLightRed = NWScript.VFX_DUR_GLOW_LIGHT_RED,
    DurGlowYellow = NWScript.VFX_DUR_GLOW_YELLOW,
    DurGlowLightYellow = NWScript.VFX_DUR_GLOW_LIGHT_YELLOW,
    DurGlowGreen = NWScript.VFX_DUR_GLOW_GREEN,
    DurGlowLightGreen = NWScript.VFX_DUR_GLOW_LIGHT_GREEN,
    DurGlowOrange = NWScript.VFX_DUR_GLOW_ORANGE,
    DurGlowLightOrange = NWScript.VFX_DUR_GLOW_LIGHT_ORANGE,
    DurGlowBrown = NWScript.VFX_DUR_GLOW_BROWN,
    DurGlowLightBrown = NWScript.VFX_DUR_GLOW_LIGHT_BROWN,
    DurGlowGrey = NWScript.VFX_DUR_GLOW_GREY,
    DurGlowWhite = NWScript.VFX_DUR_GLOW_WHITE,
    DurGlowLightPurple = NWScript.VFX_DUR_GLOW_LIGHT_PURPLE,
    DurGhostTransparent = NWScript.VFX_DUR_GHOST_TRANSPARENT,
    DurGhostSmoke = NWScript.VFX_DUR_GHOST_SMOKE,
    DurGlyphOfWarding = NWScript.VFX_DUR_GLYPH_OF_WARDING,
    FnfSoundBurstSilent = NWScript.VFX_FNF_SOUND_BURST_SILENT,
    BeamDisintegrate = NWScript.VFX_BEAM_DISINTEGRATE,
    FnfElectricExplosion = NWScript.VFX_FNF_ELECTRIC_EXPLOSION,
    ImpDustExplosion = NWScript.VFX_IMP_DUST_EXPLOSION,
    ImpPulseHolySilent = NWScript.VFX_IMP_PULSE_HOLY_SILENT,
    DurDeathArmor = NWScript.VFX_DUR_DEATH_ARMOR,
    DurIceskin = NWScript.VFX_DUR_ICESKIN,
    FnfSwingingBlade = NWScript.VFX_FNF_SWINGING_BLADE,
    DurInferno = NWScript.VFX_DUR_INFERNO,
    FnfDemonHand = NWScript.VFX_FNF_DEMON_HAND,
    DurStonehold = NWScript.VFX_DUR_STONEHOLD,
    FnfMysticalExplosion = NWScript.VFX_FNF_MYSTICAL_EXPLOSION,
    DurGhostlyVisageNoSound = NWScript.VFX_DUR_GHOSTLY_VISAGE_NO_SOUND,
    DurGhostSmoke2 = NWScript.VFX_DUR_GHOST_SMOKE_2,
    DurFlies = NWScript.VFX_DUR_FLIES,
    FnfSummondragon = NWScript.VFX_FNF_SUMMONDRAGON,
    BeamFireW = NWScript.VFX_BEAM_FIRE_W,
    BeamFireWSilent = NWScript.VFX_BEAM_FIRE_W_SILENT,
    BeamChain = NWScript.VFX_BEAM_CHAIN,
    BeamBlack = NWScript.VFX_BEAM_BLACK,
    ImpWallspike = NWScript.VFX_IMP_WALLSPIKE,
    FnfGreaterRuin = NWScript.VFX_FNF_GREATER_RUIN,
    FnfUndeadDragon = NWScript.VFX_FNF_UNDEAD_DRAGON,
    DurProtEpicArmor = NWScript.VFX_DUR_PROT_EPIC_ARMOR,
    FnfSummonEpicUndead = NWScript.VFX_FNF_SUMMON_EPIC_UNDEAD,
    DurProtEpicArmor2 = NWScript.VFX_DUR_PROT_EPIC_ARMOR_2,
    DurInfernoChest = NWScript.VFX_DUR_INFERNO_CHEST,
    DurIounstoneRed = NWScript.VFX_DUR_IOUNSTONE_RED,
    DurIounstoneBlue = NWScript.VFX_DUR_IOUNSTONE_BLUE,
    DurIounstoneYellow = NWScript.VFX_DUR_IOUNSTONE_YELLOW,
    DurIounstoneGreen = NWScript.VFX_DUR_IOUNSTONE_GREEN,
    ImpMirvElectric = NWScript.VFX_IMP_MIRV_ELECTRIC,
    ComChunkRedBallista = NWScript.VFX_COM_CHUNK_RED_BALLISTA,
    DurInfernoNoSound = NWScript.VFX_DUR_INFERNO_NO_SOUND,
    DurAuraPulseRedWhite = NWScript.VFX_DUR_AURA_PULSE_RED_WHITE,
    DurAuraPulseBlueWhite = NWScript.VFX_DUR_AURA_PULSE_BLUE_WHITE,
    DurAuraPulseGreenWhite = NWScript.VFX_DUR_AURA_PULSE_GREEN_WHITE,
    DurAuraPulseYellowWhite = NWScript.VFX_DUR_AURA_PULSE_YELLOW_WHITE,
    DurAuraPulseMagentaWhite = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_WHITE,
    DurAuraPulseCyanWhite = NWScript.VFX_DUR_AURA_PULSE_CYAN_WHITE,
    DurAuraPulseOrangeWhite = NWScript.VFX_DUR_AURA_PULSE_ORANGE_WHITE,
    DurAuraPulseBrownWhite = NWScript.VFX_DUR_AURA_PULSE_BROWN_WHITE,
    DurAuraPulsePurpleWhite = NWScript.VFX_DUR_AURA_PULSE_PURPLE_WHITE,
    DurAuraPulseGreyWhite = NWScript.VFX_DUR_AURA_PULSE_GREY_WHITE,
    DurAuraPulseGreyBlack = NWScript.VFX_DUR_AURA_PULSE_GREY_BLACK,
    DurAuraPulseBlueGreen = NWScript.VFX_DUR_AURA_PULSE_BLUE_GREEN,
    DurAuraPulseRedBlue = NWScript.VFX_DUR_AURA_PULSE_RED_BLUE,
    DurAuraPulseRedYellow = NWScript.VFX_DUR_AURA_PULSE_RED_YELLOW,
    DurAuraPulseGreenYellow = NWScript.VFX_DUR_AURA_PULSE_GREEN_YELLOW,
    DurAuraPulseRedGreen = NWScript.VFX_DUR_AURA_PULSE_RED_GREEN,
    DurAuraPulseBlueYellow = NWScript.VFX_DUR_AURA_PULSE_BLUE_YELLOW,
    DurAuraPulseBlueBlack = NWScript.VFX_DUR_AURA_PULSE_BLUE_BLACK,
    DurAuraPulseRedBlack = NWScript.VFX_DUR_AURA_PULSE_RED_BLACK,
    DurAuraPulseGreenBlack = NWScript.VFX_DUR_AURA_PULSE_GREEN_BLACK,
    DurAuraPulseYellowBlack = NWScript.VFX_DUR_AURA_PULSE_YELLOW_BLACK,
    DurAuraPulseMagentaBlack = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_BLACK,
    DurAuraPulseCyanBlack = NWScript.VFX_DUR_AURA_PULSE_CYAN_BLACK,
    DurAuraPulseOrangeBlack = NWScript.VFX_DUR_AURA_PULSE_ORANGE_BLACK,
    DurAuraPulseBrownBlack = NWScript.VFX_DUR_AURA_PULSE_BROWN_BLACK,
    DurAuraPulsePurpleBlack = NWScript.VFX_DUR_AURA_PULSE_PURPLE_BLACK,
    DurAuraPulseCyanGreen = NWScript.VFX_DUR_AURA_PULSE_CYAN_GREEN,
    DurAuraPulseCyanBlue = NWScript.VFX_DUR_AURA_PULSE_CYAN_BLUE,
    DurAuraPulseCyanRed = NWScript.VFX_DUR_AURA_PULSE_CYAN_RED,
    DurAuraPulseCyanYellow = NWScript.VFX_DUR_AURA_PULSE_CYAN_YELLOW,
    DurAuraPulseMagentaBlue = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_BLUE,
    DurAuraPulseMagentaRed = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_RED,
    DurAuraPulseMagentaGreen = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_GREEN,
    DurAuraPulseMagentaYellow = NWScript.VFX_DUR_AURA_PULSE_MAGENTA_YELLOW,
    DurAuraPulseRedOrange = NWScript.VFX_DUR_AURA_PULSE_RED_ORANGE,
    DurAuraPulseYellowOrange = NWScript.VFX_DUR_AURA_PULSE_YELLOW_ORANGE,
    DurAuraRed = NWScript.VFX_DUR_AURA_RED,
    DurAuraGreen = NWScript.VFX_DUR_AURA_GREEN,
    DurAuraBlue = NWScript.VFX_DUR_AURA_BLUE,
    DurAuraMagenta = NWScript.VFX_DUR_AURA_MAGENTA,
    DurAuraYellow = NWScript.VFX_DUR_AURA_YELLOW,
    DurAuraWhite = NWScript.VFX_DUR_AURA_WHITE,
    DurAuraOrange = NWScript.VFX_DUR_AURA_ORANGE,
    DurAuraBrown = NWScript.VFX_DUR_AURA_BROWN,
    DurAuraPurple = NWScript.VFX_DUR_AURA_PURPLE,
    DurAuraCyan = NWScript.VFX_DUR_AURA_CYAN,
    DurAuraGreenDark = NWScript.VFX_DUR_AURA_GREEN_DARK,
    DurAuraGreenLight = NWScript.VFX_DUR_AURA_GREEN_LIGHT,
    DurAuraRedDark = NWScript.VFX_DUR_AURA_RED_DARK,
    DurAuraRedLight = NWScript.VFX_DUR_AURA_RED_LIGHT,
    DurAuraBlueDark = NWScript.VFX_DUR_AURA_BLUE_DARK,
    DurAuraBlueLight = NWScript.VFX_DUR_AURA_BLUE_LIGHT,
    DurAuraYellowDark = NWScript.VFX_DUR_AURA_YELLOW_DARK,
    DurAuraYellowLight = NWScript.VFX_DUR_AURA_YELLOW_LIGHT,
    DurBubbles = NWScript.VFX_DUR_BUBBLES,
    EyesGreenHumanMale = NWScript.VFX_EYES_GREEN_HUMAN_MALE,
    EyesGreenHumanFemale = NWScript.VFX_EYES_GREEN_HUMAN_FEMALE,
    EyesGreenHalfelfMale = NWScript.VFX_EYES_GREEN_HALFELF_MALE,
    EyesGreenHalfelfFemale = NWScript.VFX_EYES_GREEN_HALFELF_FEMALE,
    EyesGreenDwarfMale = NWScript.VFX_EYES_GREEN_DWARF_MALE,
    EyesGreenDwarfFemale = NWScript.VFX_EYES_GREEN_DWARF_FEMALE,
    EyesGreenElfMale = NWScript.VFX_EYES_GREEN_ELF_MALE,
    EyesGreenElfFemale = NWScript.VFX_EYES_GREEN_ELF_FEMALE,
    EyesGreenGnomeMale = NWScript.VFX_EYES_GREEN_GNOME_MALE,
    EyesGreenGnomeFemale = NWScript.VFX_EYES_GREEN_GNOME_FEMALE,
    EyesGreenHalflingMale = NWScript.VFX_EYES_GREEN_HALFLING_MALE,
    EyesGreenHalflingFemale = NWScript.VFX_EYES_GREEN_HALFLING_FEMALE,
    EyesGreenHalforcMale = NWScript.VFX_EYES_GREEN_HALFORC_MALE,
    EyesGreenHalforcFemale = NWScript.VFX_EYES_GREEN_HALFORC_FEMALE,
    EyesGreenTroglodyte = NWScript.VFX_EYES_GREEN_TROGLODYTE,
    EyesPurHumanMale = NWScript.VFX_EYES_PUR_HUMAN_MALE,
    EyesPurHumanFemale = NWScript.VFX_EYES_PUR_HUMAN_FEMALE,
    EyesPurDwarfMale = NWScript.VFX_EYES_PUR_DWARF_MALE,
    EyesPurDwarfFemale = NWScript.VFX_EYES_PUR_DWARF_FEMALE,
    EyesPurElfMale = NWScript.VFX_EYES_PUR_ELF_MALE,
    EyesPurElfFemale = NWScript.VFX_EYES_PUR_ELF_FEMALE,
    EyesPurGnomeMale = NWScript.VFX_EYES_PUR_GNOME_MALE,
    EyesPurGnomeFemale = NWScript.VFX_EYES_PUR_GNOME_FEMALE,
    EyesPurHalflingMale = NWScript.VFX_EYES_PUR_HALFLING_MALE,
    EyesPurHalflingFemale = NWScript.VFX_EYES_PUR_HALFLING_FEMALE,
    EyesPurHalforcMale = NWScript.VFX_EYES_PUR_HALFORC_MALE,
    EyesPurHalforcFemale = NWScript.VFX_EYES_PUR_HALFORC_FEMALE,
    EyesPurTroglodyte = NWScript.VFX_EYES_PUR_TROGLODYTE,
    EyesCynHumanMale = NWScript.VFX_EYES_CYN_HUMAN_MALE,
    EyesCynHumanFemale = NWScript.VFX_EYES_CYN_HUMAN_FEMALE,
    EyesCynDwarfMale = NWScript.VFX_EYES_CYN_DWARF_MALE,
    EyesCynDwarfFemale = NWScript.VFX_EYES_CYN_DWARF_FEMALE,
    EyesCynElfMale = NWScript.VFX_EYES_CYN_ELF_MALE,
    EyesCynElfFemale = NWScript.VFX_EYES_CYN_ELF_FEMALE,
    EyesCynGnomeMale = NWScript.VFX_EYES_CYN_GNOME_MALE,
    EyesCynGnomeFemale = NWScript.VFX_EYES_CYN_GNOME_FEMALE,
    EyesCynHalflingMale = NWScript.VFX_EYES_CYN_HALFLING_MALE,
    EyesCynHalflingFemale = NWScript.VFX_EYES_CYN_HALFLING_FEMALE,
    EyesCynHalforcMale = NWScript.VFX_EYES_CYN_HALFORC_MALE,
    EyesCynHalforcFemale = NWScript.VFX_EYES_CYN_HALFORC_FEMALE,
    EyesCynTroglodyte = NWScript.VFX_EYES_CYN_TROGLODYTE,
    EyesWhtHumanMale = NWScript.VFX_EYES_WHT_HUMAN_MALE,
    EyesWhtHumanFemale = NWScript.VFX_EYES_WHT_HUMAN_FEMALE,
    EyesWhtDwarfMale = NWScript.VFX_EYES_WHT_DWARF_MALE,
    EyesWhtDwarfFemale = NWScript.VFX_EYES_WHT_DWARF_FEMALE,
    EyesWhtElfMale = NWScript.VFX_EYES_WHT_ELF_MALE,
    EyesWhtElfFemale = NWScript.VFX_EYES_WHT_ELF_FEMALE,
    EyesWhtGnomeMale = NWScript.VFX_EYES_WHT_GNOME_MALE,
    EyesWhtGnomeFemale = NWScript.VFX_EYES_WHT_GNOME_FEMALE,
    EyesWhtHalflingMale = NWScript.VFX_EYES_WHT_HALFLING_MALE,
    EyesWhtHalflingFemale = NWScript.VFX_EYES_WHT_HALFLING_FEMALE,
    EyesWhtHalforcMale = NWScript.VFX_EYES_WHT_HALFORC_MALE,
    EyesWhtHalforcFemale = NWScript.VFX_EYES_WHT_HALFORC_FEMALE,
    EyesWhtTroglodyte = NWScript.VFX_EYES_WHT_TROGLODYTE,
    ImpPdkGenericPulse = NWScript.VFX_IMP_PDK_GENERIC_PULSE,
    ImpPdkGenericHeadHit = NWScript.VFX_IMP_PDK_GENERIC_HEAD_HIT,
    ImpPdkRallyingCry = NWScript.VFX_IMP_PDK_RALLYING_CRY,
    ImpPdkHeroicShield = NWScript.VFX_IMP_PDK_HEROIC_SHIELD,
    ImpPdkInspireCourage = NWScript.VFX_IMP_PDK_INSPIRE_COURAGE,
    DurPdkFear = NWScript.VFX_DUR_PDK_FEAR,
    ImpPdkWrath = NWScript.VFX_IMP_PDK_WRATH,
    ImpPdkOath = NWScript.VFX_IMP_PDK_OATH,
    ImpPdkFinalStand = NWScript.VFX_IMP_PDK_FINAL_STAND,
    DurArrowInSternum = NWScript.VFX_DUR_ARROW_IN_STERNUM,
    DurArrowInChestLeft = NWScript.VFX_DUR_ARROW_IN_CHEST_LEFT,
    DurArrowInChestRight = NWScript.VFX_DUR_ARROW_IN_CHEST_RIGHT,
    DurArrowInBack = NWScript.VFX_DUR_ARROW_IN_BACK,
    DurArrowInTemples = NWScript.VFX_DUR_ARROW_IN_TEMPLES,
    DurArrowInFace = NWScript.VFX_DUR_ARROW_IN_FACE,
    DurArrowInHead = NWScript.VFX_DUR_ARROW_IN_HEAD,
    DurQuillInChest = NWScript.VFX_DUR_QUILL_IN_CHEST,
    ImpStarburstGreen = NWScript.VFX_IMP_STARBURST_GREEN,
    ImpStarburstRed = NWScript.VFX_IMP_STARBURST_RED,
    ImpNightmareHeadHit = NWScript.VFX_IMP_NIGHTMARE_HEAD_HIT,
  }
}
