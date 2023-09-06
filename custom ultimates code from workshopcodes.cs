settings
{
   




	main
	{
		Description: "Overpowered custom-made ultimates for each hero. Currently only supports team-based modes and 1 of each hero per team."

		Mode Name: "Goofy OP ultimates"
		
	}


	lobby
	{
		Max Team 1 Players: 4
		Max Team 2 Players: 4
	}

	
	

	modes
	{
		General
		{
		
			Respawn Time Scalar: 50%
		}

		

		Skirmish
		{
			enabled maps
			{
				Colosseo 0
			
			
			
			}
		}

		disabled Team Deathmatch
		{
			Game Length In Minutes: 5
			Score To Win: 1
		}

		
	}

	heroes
	{
		Team 1
		{
			Ultimate Generation: 500%
			Ultimate Generation - Combat: 500%
			Ultimate Generation - Passive: 500%
           
		
            Spawn With Ultimate Ready: On
           
		
		}

		Team 2
		{
			Ultimate Generation: 500%
			Ultimate Generation - Combat: 500%
			Ultimate Generation - Passive: 500%
           

		
           
		
		}

		General
		{
			Ashe
			{
				Infinite Ultimate Duration: On
				Ultimate Duration: 500%
			}

			Bastion
			{
			
				Ultimate Duration: 300%
			}

			Doomfist
			{
				Ultimate Duration: 500%
			}
			
			

			Soldier: 76
			{
				Ultimate Duration: 200%

			}

			

            Widowmaker
            {
                Ultimate Duration: 200%
            }

			Winston
			{
				Primal Rage Melee Knockback Scalar: 150%
			}

			disabled heroes
			{
			
				Ashe
			
				Bastion
			
				Illari
				Kiriko
				Lifeweaver
				Ramattra
				
			}
		}
	}

	extensions
	{
		Spawn More Dummy Bots
		Buff Status Effects
	
		Explosion Sounds
		Kinetic Explosion Effects
		Projectiles
		Buff and Debuff Sounds
	}
}
variables {
  global:
    0: JunkerArenaTimer
    1: JunkerArenaSphere
    2: JunkerArenaPositions
    3: JunkerArenaTimerText
    4: T
    5: TimeStopHealMod
    6: TimeStopTimer
    7: S
    8: UltingSigmas
    9: NukingPlayer
    10: NukeTimer
    11: NukeText
    12: ForLoopIndexGlobal
    13: NukePosition
    14: NukeRadius
    15: R
    16: P
    17: Q
    18: GreenPortal
    19: W
    20: YellowPortalRaycast
    21: GreenPortalRaycast
    22: SymmetraBluePNormal
    23: SymmetraRedPNormal
    24: SymmetraYellowPNormal
    25: SymmetraGreenPNormal

  player:
    0: B
    1: EquippedEmotes
    2: CustomUltReadyToUse
    3: UltReadyText
    4: UsingCustomUlt
    5: UltEffect
    6: G
    7: UltDescriptionTextObject
    8: UltDescription
    9: CurrentGravities
    10: CurrentSpeeds
    11: TeleportBackInBounds
    12: MenuHUDOptions
    13: MenuOptions
    14: ForLoopIndexPlayer
    15: MenuHUDChooseSort
    16: MenuOpen
    17: MenuChosenOption
    18: Nanoboosted
    19: AnaHealMod
    20: BaptisteShieldAimSphere
    21: BaptisteShieldPos
    22: BaptisteShieldReadyToPlant
    23: BaptisteShieldBot
    24: D
    25: BrigitteUltActive
    26: BrigitteKnockedBack
    27: S
    28: Y
    29: M
    30: DVAVariables
    31: EchoAimRayCast
    32: EchoDummyBots
    33: EchoEffects
    34: V
    35: HanzoDragonPos
    36: UltTimer
    37: UltTimerText
    38: HanzoUltimateAmmo
    39: HanzoDragonTargetPos
    40: JunkerQueenInArena
    41: JunkerQueenEnemyArray
    42: JunkerQueenEnemyPositions
    43: JunkerTeleportPos
    44: JunkerReadyToTeleport
    45: JunkerQueenPositions
    46: JunkerDamageCounter
    47: JunkerHealthBonus
    48: JunkerHealthPool
    49: JunkerScale
    50: JunkerCDReduction
    51: JunkerRageEffects
    52: JunkerWinCounterText
    53: JunkerWinCounter
    54: JunkerArenaSphere
    55: ExtraLife
    56: JunkerKnifeThrowCD
    57: JunkratBombPosition
    58: JunkratBombOrb
    59: JunkratExplosionRadius
    60: JunkratRadiusRing
    61: UltTimerAboveHead
    62: UltTimerHUD
    63: MeiZaWarudoSphere
    64: MeiIcicleEffects
    65: MeiIciclePositions
    66: MeiIcicleDirections
    67: TimeStopStunned
    68: O
    69: N
    70: MercyExtraLifeText
    71: ExtraLifeInWorldText
    72: R
    73: P
    74: Q
    75: U
    76: ReaperVariables
    77: ReaperTPPos
    78: ReinhardtHudText
    79: RoadhogHUD
    80: SigmaMaleValues
    81: SigmaZeroGravBuff
    82: SigmaHighGravDebuff
    83: SojournLastRay
    84: SojournRayArray
    85: SojournBeamArray
    86: SojournEyePosArray
    87: SojournLastEyePos
    88: SojournDamageRay
    89: Soldier76Variables
    90: SoldierAllKillStreaks
    91: Soldier76KillStreaksEquipped
    92: SoldierKillStreakTexts
    93: Soldier76KillStreaksActive
    94: LocalVariable
    95: Soldier76CarepackLocation
    96: SoldierCarePackAmmoIndex
    97: EnemySombra
    98: Virus
    99: VirusText
    100: VirusEffects
    101: HasDiedWithVirus
    102: K
    103: L
    104: InPortalSpeed
    105: TorbTurret
    106: TorbTurretLevel
    107: TorbTurretLevelText
    108: TorbCurrentTarget
    109: WidowZoomedIn
    110: WidowPlayersInViewAngleSorted
    111: WidowRayCastForward
    112: WidowRayCastStartPos
    113: WidowRayCastEndPos
    114: WidowRayCastBackward
    115: WidowRayCastHeadForward
    116: WidowRayCastHeadBackward
    117: WidowFireBeam
    118: WidowDamage
    119: WidowAimBeam
    120: WidowLastFacingDirection
    121: WinstonGrabbing
    122: J
    123: I
    124: H
    125: WinstonRayCast1
    126: WinstonRayCast2
    127: ZaryaGravPos
}


subroutines {
    0: UseCustomUlt
    1: StopUsingCustomUlt
    2: CreateMenu
    3: ResetBaptiste
    4: ResetBrigitte
    5: ResetDoomfist
    6: ResetDVa
    7: ResetEcho
    8: ResetGenji
    9: ResetHanzo
    10: ResetJQ
    11: ResetJunkrat
    12: ResetCassidy
    13: ResetMei
    14: ResetMoira
    15: ResetPharah
    16: ResetReaper
    17: ResetReinhardt
    18: ResetRoadhog
    19: ResetSigma
    20: ResetSojourn
    21: ResetSoldier
    22: ResetSombra
    23: ResetSymmetraTeam1
    24: ResetSymmetraTeam2
    25: ResetTorb
    26: ResetTracer
    27: ResetWidow
    28: ResetWinston
    29: ResetWB
    30: ResetZarya
    31: ResetZenyatta
    32: StopPossessing
}





rule("RESET STUFF WHEN SWITCHING HERO")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.B != Null;
		Event Player.B != Hero Of(Event Player);
	
	
		
	}

	actions
	{

		
	

	

	
	
	

	

	

	
	
	
	
		
		
		If(Event Player.B == Hero(Baptiste));
		Call Subroutine(ResetBaptiste);
		Else If(Event Player.B == Hero(Cassidy));
		Call Subroutine(ResetCassidy);
		Else If(Event Player.B == Hero(D.Va));
		Call Subroutine(ResetDVa);
		Else If(Event Player.B == Hero(Doomfist));
		Call Subroutine(ResetDoomfist);
		Else If(Event Player.B == Hero(Echo));
		Call Subroutine(ResetEcho);
		Else If(Event Player.B == Hero(Genji));
		Call Subroutine(ResetGenji);
		Else If(Event Player.B == Hero(Hanzo));
		Call Subroutine(ResetHanzo);
		Else If(Event Player.B == Hero(Junker Queen));
		Call Subroutine(ResetJQ);
		Else If(Event Player.B == Hero(Junkrat));
		Call Subroutine(ResetJunkrat);
		Else If(Event Player.B == Hero(Mei));
		Call Subroutine(ResetMei);
		Else If(Event Player.B == Hero(Moira));
		Call Subroutine(ResetMoira);
		Else If(Event Player.B == Hero(Pharah));
		Call Subroutine(ResetPharah);
		Else If(Event Player.B == Hero(Reaper));
		Call Subroutine(ResetReaper);
		Else If(Event Player.B == Hero(Reinhardt));
		Call Subroutine(ResetReinhardt);
		Else If(Event Player.B == Hero(Roadhog));
		Call Subroutine(ResetRoadhog);
		Else If(Event Player.B == Hero(Sigma));
		Call Subroutine(ResetSigma);
		Else If(Event Player.B == Hero(Sojourn));
		Call Subroutine(ResetSojourn);
		Else If(Event Player.B == Hero(Soldier: 76));
		Call Subroutine(ResetSoldier);
		Else If(Event Player.B == Hero(Sombra));
		Call Subroutine(ResetSombra);
		Else If(Event Player.B == Hero(Symmetra));
		If(Team Of(Event Player) == Team 1);
		Call Subroutine(ResetSymmetraTeam1);
		Else;
		Call Subroutine(ResetSymmetraTeam2);
		End;
		Else If(Event Player.B == Hero(Torbjörn));
		Call Subroutine(ResetTorb);
		Else If(Event Player.B == Hero(Tracer));
		Call Subroutine(ResetTracer);
		Else If(Event Player.B == Hero(Widowmaker));
		Call Subroutine(ResetWidow);
		Else If(Event Player.B == Hero(Winston));
		Call Subroutine(ResetWinston);
		Else If(Event Player.B == Hero(Wrecking Ball));
		Call Subroutine(ResetWB);
		Else If(Event Player.B == Hero(Zarya));
		Call Subroutine(ResetZarya);
		Else If(Event Player.B == Hero(Zenyatta));
		Call Subroutine(ResetZenyatta);
		End;

		
		Event Player.B = Hero Of(Event Player);
		
		
		Event Player.EquippedEmotes = Null;
	
		

	}
}




rule("Disable vanilla ultimate when charge is full")
{
    event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		(Hero Of(Event Player) == Hero(Mei) || Hero Of(Event Player) == Hero(Zenyatta) || Hero Of(Event Player) == Hero(Zarya) || Hero Of(Event Player) == Hero(Baptiste) || Hero Of(Event Player) == Hero(Pharah) || Hero Of(Event Player) == Hero(Roadhog) || Hero Of(Event Player) == Hero(Sombra) || Hero Of(Event Player) == Hero(Symmetra) || Hero Of(Event Player) == Hero(Tracer) || Hero Of(Event Player) == Hero(Bastion) || Hero Of(Event Player) == Hero(Wrecking Ball) || Hero Of(Event Player) == Hero(Junkrat) || Hero Of(Event Player) == Hero(Torbjörn) || Hero Of(Event Player) == Hero(Sigma) || Hero Of(Event Player) == Hero(Reaper)) == true;
		Ultimate Charge Percent(Event Player) > 99.800;
		Event Player.CustomUltReadyToUse != True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Event Player.CustomUltReadyToUse = True;
		Set Ultimate Ability Enabled(Event Player, False);
		Create HUD Text(Event Player, Custom String("ULT READY PRESS Q TO USE ULTIMATE"), Null, Null, Top, 1, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.UltReadyText = Last Text ID;
	
	}
}



rule("Use custom ult")
{
    event
    {
        Subroutine;
        UseCustomUlt;
    }

    actions
    {
        Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
        Event Player.UsingCustomUlt = True;
        Event Player.CustomUltReadyToUse = null;
    }
}



rule("Stop Using custom ult")
{
    event
    {
        Subroutine;
        StopUsingCustomUlt;
    }

    actions
    {
		If(Event Player.UltEffect != Null);
        Destroy Effect(Event Player.UltEffect);
		Event Player.UltEffect = Null;
		End;
		
		Event Player.CustomUltReadyToUse = Null;
        Event Player.UsingCustomUlt = null;
		If(Event Player.UltReadyText != Null);
        Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		End;
		
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
	
		If(Event Player.G != Null);
		Stop Chasing Player Variable(Event Player, G);
		Event Player.G = 0;
		End;
		
		Destroy HUD Text(Last Text ID);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
	
	
	
	
	
        
    }
}




rule("Spawn ultimate description")
{
    event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Interact)) == True;
		Is Button Held(Event Player, Button(Crouch)) == True;

	}

	actions
	{
		If(Event Player.UltDescriptionTextObject == Null);
		Create HUD Text(Event Player, Event Player.UltDescription, Null, Null, Top, 1, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.UltDescriptionTextObject = Last Text ID;
		Else;
		Destroy HUD Text(Event Player.UltDescriptionTextObject);
		Event Player.UltDescriptionTextObject = Null;
		End;
		
	}
}



rule("Set default gravities and speeds for player")
{
   
   

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
	
	
	}

	actions
	{
	
		
	
		Event Player.CurrentGravities = Array(100, 100);
	
		Event Player.CurrentSpeeds = Array(100, 100, 100);
	
	

	}
}







rule("Set current hero to B variable")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
	

	}

	actions
	{
		Event Player.B = Hero Of(Event Player);
	
	}
}



rule("Teleport back in bounds if standing out of bounds")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.TeleportBackInBounds == True;
		
		(Is On Ground(Event Player) == True || Vertical Speed Of(Event Player) == 0) == True;
	
	
	}

	actions
	{
		Teleport(Event Player, Nearest Walkable Position(Position Of(Event Player)));
		Event Player.TeleportBackInBounds = False;
	}
}






rule("Test dummy")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Interact)) == True;
	
	}

	actions
	{
	
		Create Dummy Bot(All Heroes, Opposite Team Of(Team Of(Event Player)), -1, Event Player, Vector(0, 0, 0));
	
	
		
	
	
		
	
		
	
	
	
		
	}
}



rule("ServerLoad")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{

	}

	actions
	{
		Create HUD Text(All Players(All Teams), Custom String("Server load: "), Server Load, Null, Right, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
	}
}



rule("CreateMenu")
{
    event
    {
        Subroutine;
        CreateMenu;
    }

    actions
    {
		Event Player.MenuHUDOptions = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count of(Event Player.MenuOptions), 1);

		Create HUD Text(Event Player, Value In Array(Event Player.MenuOptions, Event Player.ForLoopIndexPlayer), Null, Null, Top, Event Player.ForLoopIndexPlayer + 1, Color(Blue), Color(White), Color(White), None, Default Visibility);
		Modify Player Variable(Event Player, MenuHUDOptions, Append To Array, Last Text Id);
		
		End;

        
		Create HUD Text(Event Player, Custom String("Choose option: "), Null, Null, Top, Event Player.MenuHUDChooseSort, Color(Green), Color(White), Color(White), Sort Order and String, Default Visibility);
		Modify Player Variable(Event Player, MenuHUDOptions, Append To Array, Last Text Id);

	

		Event Player.MenuOpen = True;

		Set Status(Event Player, Event Player, Frozen, 9999);

		Set Status(Event Player, Event Player, Phased Out, 9999);

		Set Knockback Received(Event Player, 0); 
    }
}



rule("ChooseMenuForward")
{
    event
    {
        Ongoing - Each Player;
        All;
		All;
    }

	conditions
	{
		Event Player.MenuOpen == True;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	}

    actions
    {
	

	
		
	

		If(Event Player.MenuHUDChooseSort < Count Of(Event Player.MenuHUDOptions) - 2);
		Modify Player Variable(Event Player, MenuHUDChooseSort, Add, 1);
		Else;
		Event Player.MenuHUDChooseSort = 0;
		End;
    }
}



rule("ChooseMenuBackward")
{
    event
    {
        Ongoing - Each Player;
        All;
		All;
    }

	conditions
	{
		Event Player.MenuOpen == True;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
	}

    actions
    {
		If(Event Player.MenuHUDChooseSort > 0);
		Modify Player Variable(Event Player, MenuHUDChooseSort, Subtract, 1);
		Else;
		Event Player.MenuHUDChooseSort = Count Of(Event Player.MenuHUDOptions) - 2;
		End;
        
    }
}



rule("ChooseMenuFinalizeChoice")
{
    event
    {
        Ongoing - Each Player;
        All;
		All;
    }

	conditions
	{
		Event Player.MenuOpen == True;
		Is Button Held(Event Player, Button(Jump)) == True;
	}

    actions
    {
		Event Player.MenuChosenOption = Value In Array(Event Player.MenuOptions, Event Player.MenuHUDChooseSort);
        Clear Status(Event Player, Phased Out);
        Clear Status(Event Player, Frozen);
		Set Knockback Received(Event Player, 100); 

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count of(Event Player.MenuHUDOptions), 1);
		Destroy Hud Text(Value In Array(Event Player.MenuHUDOptions, Event Player.ForLoopIndexPlayer));
		End;

		Event Player.ForLoopIndexPlayer = Null;

		Event Player.MenuOpen = Null;
    }
}



rule("If dead disable all damage over time")
{

	event
	{
		Player Died;
		All;
		All;
	}

	actions
	{
		Stop All Damage Over Time(Event Player);
	}
}





rule("ana: set variables for player boosted by ana")
{
	event
	{
		Player Dealt Healing;
		All;
		Ana;
	}

	conditions
	{
		Event Ability() == Button(Ultimate);
		Is Dummy Bot(Event Player) == false;
	
	
	}

	actions
	{
		

		Healee.Nanoboosted = True;
	
		
		Value In Array(Healee.CurrentSpeeds, 0) += 200;
		Value In Array(Healee.CurrentSpeeds, 1) += 200;
		Set Move Speed(Healee, Value In Array(Healee.CurrentSpeeds, 0));
		Set Jump Vertical Speed(Healee, Value In Array(Healee.CurrentSpeeds, 1));
		
	
		
		Stop Healing Modification(Event Player.AnaHealMod);
		Event Player.AnaHealMod = Null;

		
	}
}



rule("ana: damage all team mates by a very small amount so that they can be healed by Ana's ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		Ana;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
	
	
	}

	actions
	{
		
		Damage(All Players(Team Of(Event Player)), Null, 0.016);
		Start Healing Modification(All Players(Team Of(Event Player)), Remove From Array(All Players(Team Of(Event Player)), Event Player), 0, Receivers Healers And Healing Percent);
		Event Player.AnaHealMod = Last Healing Modification ID;
	}
}



rule("Ana: Disable nanoboost effects after some time or when dead")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Nanoboosted == True;
		

	}

	actions
	{
		Wait Until(Is Dead(Event Player) == True, 8);
		Event Player.Nanoboosted = Null;
		Value In Array(Event Player.CurrentSpeeds, 0) -= 200;
		Value In Array(Event Player.CurrentSpeeds, 1) -= 200;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Set Jump Vertical Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 1));
	}
}



rule("Set cooldowns to 0 for nanoboosted player on a loop for when checking ability cooldown doesn't work")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Nanoboosted == True;
	
		

	}

	actions
	{
	

		Wait(0.1, Abort When False);
		Set Ability Cooldown(Event Player, Button(Ability 1), 0);
		Set Ability Cooldown(Event Player, Button(Ability 2), 0);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), 0);
		Set Ability Cooldown(Event Player, Button(Primary Fire), 0);
		Set Ultimate Charge(Event Player, Ultimate Charge Percent(Event Player) + 1);
		Loop If Condition Is True;
		
	}
}







rule("Ana description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Ana;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Nanoboosted player gains a speed boost, increased jump height, 0 cooldowns and ultimate charge generation.", Null, Null, Null);

	}
}







rule("Start aiming baptiste ult")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
		Is Dummy Bot(Event Player) == False;
		Event Player.BaptisteShieldAimSphere == Null;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
	
		
	
		
		Create Effect(Event Player, Sphere, Color(Blue), Event Player.BaptisteShieldPos, 5, Position and Radius);
		
		Event Player.BaptisteShieldAimSphere = Last Created Entity;
		
		Wait Until(Is Button Held(Event Player, Button(Ultimate)) == False || Is Dead(Event Player) == True, 10);
		If(Is Alive(Event Player) == True);
		Event Player.BaptisteShieldReadyToPlant = True;
		Else;
		Call Subroutine(ResetBaptiste);
		End;
		
		
	}
}

rule("Baptiste plant down shield")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Has Status(Event Player, Hacked) == False;
	
		Is Dummy Bot(Event Player) == False;
	
		
		Event Player.BaptisteShieldReadyToPlant == True;
	}

	actions
	{
		
		
		Call Subroutine(UseCustomUlt);
		
		
	
		
		Destroy Effect(Event Player.BaptisteShieldAimSphere);
		
		
		If(Number of Players(Team Of(Event Player)) >= Number of Slots(Team Of(Event Player)));
		Create Dummy Bot(Hero(Winston), Team Of(Event Player), -1, Event Player.BaptisteShieldPos, Facing Direction Of(Event Player));
		
		Else If(Number of Players(Team Of(Event Player)) < Number of Slots(Team Of(Event Player)));
		For Player Variable(Event Player, ForLoopIndexPlayer, Number of Slots(Team Of(Event Player)), 11, 1);
		If(Players In Slot(Event Player.ForLoopIndexPlayer, Team Of(Event Player)) == Null);
		Create Dummy Bot(Hero(Winston), Team Of(Event Player), Event Player.ForLoopIndexPlayer, Event Player.BaptisteShieldPos, Facing Direction Of(Event Player));
		
		Break;
		End;
		End;
		End;
		
		
		
		Event Player.BaptisteShieldBot = Last Created Entity;
		
		
		
		Set Invisible(Event Player.BaptisteShieldBot, All);
		Set Max Health(Event Player.BaptisteShieldBot, 500);
		Disable Movement Collision With Players(Event Player.BaptisteShieldBot);
		
		Wait(0.1, Ignore Condition);
		
	
		
	
		
		Set Status(Event Player.BaptisteShieldBot, Null, Stunned, 0.016);
		Set Status(Event Player.BaptisteShieldBot, Null, Phased Out, 9999);
		
	
		
		Wait(0.016, Ignore Condition);
		
		Press Button(Event Player.BaptisteShieldBot, Button(Ability 2));
		
		
		
		Wait(8, Ignore Condition);
		
		Call Subroutine(ResetBaptiste);
	}
}

rule("Set baptiste's shield aim position to where player is looking")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		Event Player.BaptisteShieldAimSphere != Null;
	
	
		Event Player.BaptisteShieldBot == Null;
	}

	actions
	{
		Wait(0.016, Abort When False);
		
		Event Player.BaptisteShieldPos = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) *50, Empty Array, All Players(All Teams), True);
		
		
		
		Loop If Condition Is True;
	}
}

rule("Reset everything with baptiste.")
{
    event
    {
        Subroutine;
        ResetBaptiste;
    }

    actions
    {
		Call Subroutine(StopUsingCustomUlt);
		
		If(Event Player.BaptisteShieldBot != Null);
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Event Player.BaptisteShieldBot));
		Event Player.BaptisteShieldBot = Null;
		End;
		
		Event Player.BaptisteShieldPos = Null;
		Event Player.BaptisteShieldAimSphere = Null;
		Event Player.BaptisteShieldReadyToPlant = Null;
		
    }
}



rule("Baptiste knock people outside of shield")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Is True For Any(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) < 6) == True;
		
	}

	actions
	{
		Wait(0.016, Abort When False);
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) < 6)), 1);
		
		Apply Impulse(Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) < 6), Event Player.ForLoopIndexPlayer), Direction Towards(Event Player.BaptisteShieldPos, Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) < 6), Event Player.ForLoopIndexPlayer)), 10, To World, Cancel Contrary Motion);
	
		End;
		
		
		Loop If Condition Is True;
	}
}

rule("Baptiste Knock people inside of shield")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Is True For Any(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) <= 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 4) == True;
		
	}

	actions
	{
		Wait(0.016, Abort When False);
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) <= 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 4)), 1);
		
		Apply Impulse(Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) <= 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 4), Event Player.ForLoopIndexPlayer), Direction Towards(Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player.BaptisteShieldPos) <= 5 && Distance Between(Current Array Element, Event Player.BaptisteShieldPos) > 4), Event Player.ForLoopIndexPlayer), Event Player.BaptisteShieldPos), 10, To World, Cancel Contrary Motion);
	
		End;
		
		
		Loop If Condition Is True;
	}
}

rule("Baptiste description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Baptiste;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Spawn a highly durable shield bubble that enemy players can't walk through. {0}", Custom String("
		Can be used to trap enemies or protect your team. {0}", Custom String("
		Press ultimate button to aim and press again to plant shield.", Null, Null, Null), Null, Null));

	}
}





rule("Brigitte: Increase shield size when using ultimate")
{


	event
	{
	
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Brigitte);
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
	
		All Players(Opposite Team Of(Team Of(Event Player))).D = Event Player;
		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player) - Facing Direction Of(Event Player)*10), Update Every Frame(Eye Position(Event Player)), 0);
		
		Set Ability 1 Enabled(Event Player, False);
		Set Ability 2 Enabled(Event Player, False);
	
	
		
	
	
	
	
	
	
		Event Player.BrigitteUltActive = true;
	
		Set Max Health(Event Player, Max Health(Event Player) * 5);
	


	

		Start Forcing Player To Be Hero(Event Player, Hero(Ana));
		Start Forcing Player To Be Hero(Event Player, Hero(Brigitte));
		Stop Forcing Player To Be Hero(Event Player);
		
		

		Wait(0.016, Ignore Condition);
		

		Start Holding Button(Event Player, Button(Secondary Fire));
		
		Set Ultimate Charge(Event Player, 100);

		Press Button(Event Player, Button(Ultimate));




		Start Scaling Barriers(Event Player, 15, False);

	

	
		

	
		Wait Until((Is Dead(Event Player) == true || Hero Of(Event Player) != Hero(Brigitte)) == true, 10);
	
		Call Subroutine(ResetBrigitte);
		
		




	}
}



rule("Reset everything with brigitte.")
{
    event
    {
        Subroutine;
        ResetBrigitte;
    }

    actions
    {
	
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);
		Event Player.BrigitteUltActive = Null;
	
	
		Stop Scaling Barriers(Event Player);
		Stop Camera(Event Player);
		Set Max Health(Event Player, 100);
		Stop Holding Button(Event Player, Button(Secondary Fire));
		All Players(Opposite Team Of(Team Of(Event Player))).D = Null;
	
    }
}



rule("Brigitte: Force holding shield.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Brigitte;
	}

	conditions
	{
		Event Player.BrigitteUltActive == True;
		Hero Of(Event Player) == Hero(Brigitte);
		Is Button Held(Event Player, Button(Secondary Fire)) != True;
	}

	actions
	{
		Start Holding Button(Event Player, Button(Secondary Fire));
	}
}



rule("Brigitte: Big shield bash knockback.")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.D.BrigitteUltActive == True;
		Is Button Held(Event Player.D, Button(Secondary Fire)) == True;
		Is Firing Primary(Event Player.D) == True;
		Event Player.D != Null;
		Event Player.BrigitteKnockedBack == null;
		((Horizontal Angle Towards(Event Player.D, Event Player) >= 75 && Horizontal Angle Towards(Event Player.D, Event Player) <= 105) || (Horizontal Angle Towards(Event Player.D, Event Player) <= -75 && Horizontal Angle Towards(Event Player.D, Event Player) >= -105)) == true;
		Distance Between(Event Player, Event Player.D) < 12;
	}

	actions
	{

		Apply Impulse(Event Player, Direction From Angles(Horizontal Facing Angle Of(Event Player.D), -20), 30, To World, Cancel Contrary Motion);
		Damage(Event Player, Event Player.D, 150);
		Event Player.BrigitteKnockedBack = True;
		Wait(2, Restart When True);
		Event Player.BrigitteKnockedBack = null;
	}
}



rule("Brigitte: Apply shield knockback and damage to players in front of the shield")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.D.BrigitteUltActive == True;
		Is Button Held(Event Player.D, Button(Secondary Fire)) == True;
		Is Firing Primary(Event Player.D) == True;
		Event Player.D != Null;
		(Horizontal Angle Towards(Event Player.D, Event Player) <= 35 && Horizontal Angle Towards(Event Player.D, Event Player) >= -35) == true;
		Distance Between(Event Player, Event Player.D) < 6;
		Event Player.BrigitteKnockedBack == Null;

	}

	actions
	{

		Apply Impulse(Event Player, Direction From Angles(Horizontal Facing Angle Of(Event Player.D), -20), 30, To World, Cancel Contrary Motion);
		Damage(Event Player, Event Player.D, 150);
		Event Player.BrigitteKnockedBack = True;
		Wait(2, Restart When True);
		Event Player.BrigitteKnockedBack = null;
	}
}









rule("Brigitte description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Brigitte;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("When using Brigitte's regular ult, gain a massive shield with a lot of health. {0}", Custom String("
		When shield bashing, the edges of the shield can also damage and knockback enemies. {0}", Custom String("
		Hitting enemies with the center of the shield does double damage.", Null, Null, Null), Null, Null));

	}
}





rule("Doomfist use ult")
{
	event
	{
		Ongoing - Each Player;
		All;
		Doomfist;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
	
		Set Ultimate Ability Enabled(Event Player, False);
		Event Player.UsingCustomUlt = True;
		Wait Until(Is Dead(Event Player), 20);
	
		Call Subroutine(ResetDoomfist);
	}
}



rule("Doomfist loop meteor strikes")
{
	event
	{
		Ongoing - Each Player;
		All;
		Doomfist;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S = 8;
		Event Player.G = Nearest Walkable Position(Random Value In Array(All Living Players(Opposite Team Of(Team Of(Event Player))))
			+ Vector(Random Real(-15, 15), 0, Random Real(-15, 15)));
		Create Effect(All Players(All Teams), Ring, Team Of(Event Player), Event Player.G, 7.500, Visible To Position and Radius);
		Event Player.Y = Last Created Entity;
		Create Effect(All Players(All Teams), Ring, Team Of(Event Player), Event Player.G, Event Player.S, Visible To Position and Radius);
		Event Player.M = Last Created Entity;
	
		Chase Player Variable Over Time(Event Player, S, 0, 1, None);
	
		
		Wait(1, Ignore Condition);
		Destroy Effect(Event Player.M);
		Destroy Effect(Event Player.Y);
		Play Effect(All Players(All Teams), Doomfist Meteor Strike Impact Effect, Team Of(Event Player), Event Player.G, 10);
		Play Effect(All Players(All Teams), Doomfist Meteor Strike Impact Sound, Team Of(Event Player), Event Player.G, 100);

		


		Damage(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 20);
		Damage(Players Within Radius(Event Player.G, 6, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 100);
		Damage(Players Within Radius(Event Player.G, 2, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 180);

			
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers)), 1);
		
		Apply Impulse(Value In Array(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player.ForLoopIndexPlayer),  Direction Towards(Position Of(Event Player.G), Value In Array(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player.ForLoopIndexPlayer) + Up), 10, To World, Cancel Contrary Motion);
		
		End;
		Loop If Condition Is True;
	}
}



rule("Reset Doomfist stuff")
{
	event
	{
		Subroutine;
		ResetDoomfist;
	}

	actions
	{
		Destroy Effect(Event Player.M);
		Destroy Effect(Event Player.Y);
		disabled Destroy Effect(Event Player.UsingCustomUlt);
		Event Player.M = Null;
		Event Player.Y = Null;
		Event Player.S = Null;
		Event Player.G = Null;
		disabled Event Player.UsingCustomUlt = Null;
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
	
		Set Ultimate Ability Enabled(Event Player, True);
		Event Player.UsingCustomUlt = Null;
		
	}
}



rule("Doomfist description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Doomfist;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Create additional meteor strikes at random spots near enemy players for 20 seconds after starting the ultimate.", Null, Null, Null);

	}
}





rule("D.Va increase upgrade counter when using ult as baby D.VA, just used so that first spawn won't trigger an upgrade.")
{
   
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Is In Alternate Form(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
	
		Is Using Ultimate(Event Player) == True;
	
		Event Player.DVAVariables != Null;
	

	}

	actions
	{
	
		Wait Until(Is In Alternate Form(Event Player) != True || Is Dead(Event Player) == True || Hero Of(Event Player) != Hero(D.Va), 9999);
	
		If(Is Alive(Event Player) == True && Hero Of(Event Player) == Hero(D.Va));
		Value In Array(Event Player.DVAVariables, 1) += 1;
	
		End;

	}
}



rule("D.VA Has spawned with no upgrades, set hud and initial damage+max health")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Event Player.DVAVariables == Null; 
	
	

	}

	actions
	{
		Create HUD Text(Event Player, String("{0} {1}", String("Damage"), String("{0}: {1}", String("Dealt"), String("{0}%",
			Event Player.G))), Null, Null, Right, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.DVAVariables = Array(Last Text Id);

	
		Modify Player Variable(Event Player, DVAVariables, Append To Array, 0);
	
		Event Player.G = Array(100, 0, 1, false);
	
		
	


	
	
		
	
	}
}



rule("Remove D.Va stuff when switching hero.")
{
	event
	{
		Subroutine;
		ResetDVa;
	}

	actions
	{
		Set Damage Dealt(Event Player, 100);
		Remove Health Pool From Player(Value In Array(Event Player.DVAVariables, 2));
		Destroy Hud Text(Value In Array(Event Player.DVAVariables, 0));
		Event Player.DVAVariables = Null;
	
	
		Event Player.G = Null;
	
		
	
		
		
	}
}



rule("D.VA has spawned a new mech, choose upgrade")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
	
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.DVAVariables, 1) > 0;
		Is In Alternate Form(Event Player) != True;


	}

	actions
	{
	

		Event Player.MenuOptions = Array(Custom String("Halved cooldowns"), Custom String("+50% damage"), Custom String("+50% shield health"), Custom String("Infinite defense matrix"));
		
		Set Status(Event Player, Event Player, Phased Out, 1);
		

		Wait(1, Ignore Condition);

		Call Subroutine(CreateMenu);
	}
}



rule("D.VA has chosen a new upgrade")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
	
		Event Player.MenuChosenOption != Null;
		Event Player.DVAVariables != Null;

	}

	actions
	{
		If(Event Player.MenuChosenOption == Custom String("Halved cooldowns"));
		Value In Array(Event Player.G, 2) += 1;
		Big Message(Event Player, Custom String("Cooldowns halved."));
		else if(Event Player.MenuChosenOption == Custom String("+50% damage"));
		Value In Array(Event Player.G, 0) += 50;
		Big Message(Event Player, Custom String("Damage increased."));
		else if(Event Player.MenuChosenOption == Custom String("+50% shield health"));
		Value In Array(Event Player.G, 1) += 325;
	
		Big Message(Event Player, Custom String("Added shields"));
	
	
		else if(Event Player.MenuChosenOption == Custom String("Infinite defense matrix"));
		Value In Array(Event Player.G, 3) = true;
		Big Message(Event Player, Custom String("Infinite defense matrix added"));

		End;

		Set Damage Dealt(Event Player, Value In Array(Event Player.G, 0));
	
		
		Add Health Pool To Player(Event Player, Shields, Value In Array(Event Player.G, 1), true, true);

		Modify Player Variable(Event Player, DVAVariables, Append To Array, Last Created Health Pool);



	
	
	
	

		Event Player.MenuChosenOption = Null;

	

	}
}



rule("D.VA reduce ability 1 and secondary fire cooldown after obtaining cooldown upgrade")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
	
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.G, 2) >= 2;
		(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Ability Cooldown(Event Player, Button(Ability 2)) > 0 || Ability Cooldown(Event Player, Button(Secondary Fire)) > 0) == True;
	
	

	}

	actions
	{
	

	
		If(Ability Cooldown(Event Player, Button(Ability 1)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 1), Ability Cooldown(Event Player, Button(Ability 1)) / Value In Array(Event Player.G, 2));
		End;

	
		If(Ability Cooldown(Event Player, Button(Ability 2)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 2), Ability Cooldown(Event Player, Button(Ability 2)) / Value In Array(Event Player.G, 2));
		End;

		If(Ability Cooldown(Event Player, Button(Secondary Fire)) > 0);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), Ability Cooldown(Event Player, Button(Secondary Fire)) / Value In Array(Event Player.G, 2));
		End;

		

	


	}
}





rule("D.VA regen defense matrix when it's upgraded")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Has Spawned(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
	
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.G, 3) == True;
	
		Is Firing Secondary(Event Player) == True;
	}

	actions
	{
		Wait(1, Abort When False);
		Set Ability Resource(Event Player, Button(Secondary Fire), 100);
		Loop If Condition Is True;
	}
}



rule("D.VA reset health and damage when dying and remove upgrades")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
	
		Is Dead(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Event Player.DVAVariables != Null;
	
	
	
	}

	actions
	{
		Set Damage Dealt(Event Player, 100);
	
		Event Player.G = Array(100, 0, 1, false);

	
	
	
		Remove Health Pool From Player(Value In Array(Event Player.DVAVariables, 2));

		Value In Array(Event Player.DVAVariables, 1) = 0;


		Event Player.DVAVariables = Remove From Array(Event Player.DVAVariables, Value In Array(Event Player.DVAVariables, 2));

	

	

	
	}
}



rule("D.Va reset damage and health when in baby form.")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
		Is In Alternate Form(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.DVAVariables, 1) > 0;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Set Damage Dealt(Event Player, 100);
	
	
	
	
		
	
		Remove Health Pool From Player(Value In Array(Event Player.DVAVariables, 2));
		

		Event Player.DVAVariables = Remove From Array(Event Player.DVAVariables, Value In Array(Event Player.DVAVariables, 2));

	
	

	

	}
}




rule("D.Va description")
{
	event
	{
		Ongoing - Each Player;
		All;
		D.Va;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("After spawning a new mech, you get a choice between 4 different upgrades for your mech. {0}", Custom String("
		Upgrades will stack and persist for as long as you stay alive. {0}", Custom String("
		The upgrades will only apply to D.Vas mech and not to her baby form. {0}", Custom String("
		Use primary fire and secondary fire to move between options in the menu and jump to confirm."))));

	}
}





rule("Echo activate ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
	
	
		Is Duplicating(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		
	}

	actions
	{
	
		Wait(0.1, Ignore Condition);
		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player) - Facing Direction Of(Event Player) * 2 + Up*0.5), Update Every Frame(Eye Position(Event Player) + Facing Direction Of(Event Player) * 2 + Up*0.5), 0);

	
	
		If(Number of Players(Team Of(Event Player)) >= Number of Slots(Team Of(Event Player)));
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), -1, Event Player + Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player + Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Event Player.EchoDummyBots = Array(Last Created Entity);
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), -1, Event Player - Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player - Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Modify Player Variable(Event Player, EchoDummyBots, Append To Array, Last Created Entity);
		Else If(Number of Players(Team Of(Event Player)) < Number of Slots(Team Of(Event Player)));
		For Player Variable(Event Player, ForLoopIndexPlayer, Number of Slots(Team Of(Event Player)), 11, 1);
		
		If(Players In Slot(Event Player.ForLoopIndexPlayer, Team Of(Event Player)) == Null);
		
		If(Event Player.EchoDummyBots == Null);
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), Event Player.ForLoopIndexPlayer, Event Player + Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player + Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Event Player.EchoDummyBots = Array(Last Created Entity);
		Else;
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), Event Player.ForLoopIndexPlayer, Event Player - Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player - Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		
		Modify Player Variable(Event Player, EchoDummyBots, Append To Array, Last Created Entity);
		Break;
		End;
		
		End;
		End;
		End;
	
		
	
	
		

		Start Facing(Value In Array(Event Player.EchoDummyBots, 0), Direction Towards(Eye Position(Value In Array(Event Player.EchoDummyBots, 0)), Event Player.EchoAimRayCast), 1000, To World, Direction and Turn Rate);
		Start Facing(Value In Array(Event Player.EchoDummyBots, 1), Direction Towards(Eye Position(Value In Array(Event Player.EchoDummyBots, 1)), Event Player.EchoAimRayCast), 1000, To World, Direction and Turn Rate);
		Start Throttle In Direction(Value In Array(Event Player.EchoDummyBots, 0), Throttle Of(Event Player), 1, To Player, Replace Existing Throttle, Direction and Magnitude);
		Start Throttle In Direction(Value In Array(Event Player.EchoDummyBots, 1), Throttle Of(Event Player), 1, To Player, Replace Existing Throttle, Direction and Magnitude);

		Disable Movement Collision With Environment(Event Player.EchoDummyBots, false);
		Disable Movement Collision With Players(Event Player.EchoDummyBots);


		Create Effect(All Players(All Teams), Echo Cloning Effect, Team Of(Event Player), Value In Array(Event Player.EchoDummyBots, 0), 100, VISIBLE TO POSITION AND RADIUS);

		Event Player.EchoEffects = Array(Last Created Entity);

		Create Effect(All Players(All Teams), Echo Cloning Effect, Team Of(Event Player), Value In Array(Event Player.EchoDummyBots, 1), 100, VISIBLE TO POSITION AND RADIUS);

		Modify Player Variable(Event Player, EchoEffects, Append To Array, Last Created Entity);

	
	

	

		Wait Until((Is Dead(Event Player) == true || Is Duplicating(Event Player) == false) == true, 9999);
		Call Subroutine(ResetEcho);
		
	}
}



rule("Resets everything with Echo after Ult is over or when changing hero.")
{
	event
	{
		Subroutine;
		ResetEcho;
	}

	actions
	{
	
	
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.EchoDummyBots, 0)));
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.EchoDummyBots, 1)));
		Destroy Effect(Event Player.EchoEffects);
		Event Player.EchoEffects = Null;
		Event Player.EchoDummyBots = Null;
		Event Player.EchoAimRayCast = Null;
		Stop Camera(Event Player);
	
	}
}



rule("Echo update aim raycast, reset dummy bot position if too far from player.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Wait(0.02, Abort When False);

		Event Player.EchoAimRayCast = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, All Players(Opposite Team Of(Team Of(Event Player))), Event Player, True);

		If(Distance Between(Value In Array(Event Player.EchoDummyBots, 0), Event Player) > 6);
		Teleport(Value In Array(Event Player.EchoDummyBots, 0), Event Player + Cross Product(Facing Direction Of(Event Player), Up));
		End;

		If(Distance Between(Value In Array(Event Player.EchoDummyBots, 1), Event Player) > 6);
		Teleport(Value In Array(Event Player.EchoDummyBots, 1), Event Player - Cross Product(Facing Direction Of(Event Player), Up));
		End;

		Loop If Condition Is True;
	}
}





rule("Echo Secondary Fire")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Secondary Fire)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Secondary Fire)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Secondary Fire));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Secondary Fire));
	}
}



rule("Echo primary fire")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Primary Fire)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Primary Fire)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Primary Fire));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Primary Fire));
	}
}



rule("Echo Ability 1")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Ability 1)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Ability 1)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Ability 1));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Ability 1));
	}
}



rule("Echo Ability 2")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Ability 2)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Ability 2)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Ability 2));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Ability 2));
	}
}



rule("Echo melee")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(melee)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(melee)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(melee));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(melee));
	}
}



rule("Echo Ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
	
		Is Using Ultimate(Event Player) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
	
		Set Ultimate Charge(Event Player.EchoDummyBots, 100);
	

		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Ultimate)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Ultimate));

		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Ultimate));
	}
}



rule("Echo jump")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Jump)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Jump)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Jump));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Jump));
	}
}



rule("Echo Crouch")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Crouch)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Crouch)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Crouch));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Crouch));
	}
}



rule("Echo Reload")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Reload)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Reload)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Reload));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Reload));
	}
}



rule("Echo interact")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Button Held(Event Player, Button(Interact)) == true;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Skip If(Is Button Held(Event Player.EchoDummyBots, Button(Interact)) == True, 1);
		Start Holding Button(Event Player.EchoDummyBots, Button(Interact));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.EchoDummyBots, Button(Interact));
	}
}



rule("Echo say hello")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
		Is Duplicating(Event Player) == True;
		Is Communicating(Event Player, Hello) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
	
		Skip If(Is Communicating(Event Player.EchoDummyBots, Hello) == True, 1);
		Communicate(Event Player.EchoDummyBots, Hello);
		Loop If Condition Is True;
		
	}
}





rule("Echo description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Echo;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("When duplicating, spawn 2 copies of the duplicated hero beside you that replicate all your moves.", Null, Null, Null);

	}
}





rule("Genji Omae wa mou shindeiru")
{
    
	event
	{
		Ongoing - Each Player;
		All;
		Genji;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Set Damage Dealt(Event Player, 1);
		Event Player.Y = True;
	
	}
}



rule("Genji deals damage")
{
	event
	{
		Player Dealt Damage;
		All;
		Genji;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
	

		Skip If(Victim.V != null, 1);
		Big Message(Victim, String("{0}: {1}", Hero Icon String(Hero(Genji)), Custom String("Omae wa mou shindeiru")));

		Victim.V = Event Player;

		

	}
}



rule("Start damage over time on players that were hit during Genji's ult after his ult is over.")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player.V) != True;
		Event Player.V != Null;
		Is Dummy Bot(Event Player.V) == false;

	}

	actions
	{
		Start Damage Over Time(Event Player, Event Player.V, 9999, 100);
		Big Message(Event Player, String("{0}: {1}", Hero Icon String(Hero Of(Event Player)), Custom String("Nani???")));

	
		Set Status(Event Player, Event Player.V, Stunned, 9999);
		Create Effect(All Players(All Teams), Bad Aura Sound, Color(White), Event Player, 1000, Visible To Position and Radius);
		disabled Wait(3, Ignore Condition);
		disabled Event Player.V = Null;
	}
}



rule("Genji disable modifications after ult is over.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Genji;
	}

	conditions
	{
		Is Using Ultimate(Event Player) != True;
		Event Player.Y == True;
	}

	actions
	{
		Call Subroutine(ResetGenji);
	}
}



rule("Reset Genji stuff")
{
	event
	{
		Subroutine;
		ResetGenji;
	}

	actions
	{
		Set Damage Dealt(Event Player, 100);
		Event Player.Y = 0;
	
	}
}



rule("Stop damage over time on death on players hit by Genji")
{
	event
	{
		Player Died;
		All;
		All;
	}

	conditions
	{
		Event Player.V != Null;
	}

	actions
	{
		Destroy Effect(Last Created Entity);
		Play Effect(All Players(All Teams), Bad Explosion, Color(Red), Event Player, 3);
		Stop All Damage Over Time(Event Player);
		Clear Status(Event Player, Stunned);
		Event Player.V = Null;
		Play Effect(All Players(All Teams), Explosion Sound, Color(White), Event Player, 100);
	}
}



rule("Genji description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Genji;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Genji cuts his enemies with such precision that they don't even notice they've been cut until the ultimate is over. {0}", Custom String("
		Only a single strike is enough. Also gain extra movement speed.", Null, Null, Null));

	}
}





rule("Hanzo activate ult for the first time")
{

	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Event Player.HanzoDragonPos == Null;
	
		Is Dummy Bot(Event Player) == false;
		
	}

	actions
	{
	
	
	
		Event Player.UltTimer = 60;
		Chase Player Variable At Rate(Event Player, UltTimer, 0, 1, Destination And Rate);
		
		Create HUD Text(Event Player, Event Player.UltTimer, Null, Null, Top, 0, Color(white), Color(white), Color(white), Visible To And String, Default Visibility);
		Event Player.UltTimerText = Last Text ID;
		Event Player.HanzoUltimateAmmo = 3;
		Wait Until((Event Player.HanzoUltimateAmmo == Null && Event Player.HanzoDragonTargetPos ==Null) || Is Dead(Event Player), Event Player.UltTimer);
		Call Subroutine(ResetHanzo);
	
	}
}



rule("Hanzo ride dragon")
{

	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		
	}

	actions
	{
		Wait(0.91, Abort When False);
	
	
		Disable Movement Collision With Environment(Event Player, True);
		Disable Movement Collision With Players(Event Player);
		Event Player.HanzoDragonPos = Eye Position(Event Player) + Facing Direction Of(Event Player) * 5;
		Event Player.HanzoDragonTargetPos = Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000;
		
		Start Forcing Player Position(Event Player, Event Player.HanzoDragonPos, True);
		
		Chase Player Variable At Rate(Event Player, HanzoDragonPos, Event Player.HanzoDragonTargetPos, 12, Destination And Rate);
		Event Player.HanzoUltimateAmmo -= 1;
		
		Disallow Button(Event Player, Button(Jump));
		
	
		
		Wait(0.1, Ignore Condition);
		If(Event Player.HanzoUltimateAmmo >0);
		Set Ultimate Charge(Event Player, 100);
		End;
		
		
	}
}



rule("Hanzo ride dragon")
{

	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Event Player.HanzoDragonTargetPos != Null;
	}

	actions
	{
		
		Wait Until(Event Player.HanzoDragonTargetPos == Null, 20);
		Abort If(Event Player.HanzoDragonTargetPos == Null);
		Stop Chasing Player Variable(Event Player, HanzoDragonPos);
		Stop Forcing Player Position(Event Player);
	
	
		Event Player.HanzoDragonTargetPos = Null;
		
		Enable Movement Collision With Environment(Event Player);
		Enable Movement Collision With Players(Event Player);
		Allow Button(Event Player, Button(Jump));
		
		
		
	}
}



rule("Hanzo")
{

	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
		Event Player.HanzoDragonTargetPos != Null;
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Jump)) == True;
	}

	actions
	{
		Apply Impulse(Event Player, Up, 20, To World, Cancel Contrary Motion);
		Stop Chasing Player Variable(Event Player, HanzoDragonPos);
		Stop Forcing Player Position(Event Player);
	
	
		Event Player.HanzoDragonTargetPos = Null;
		
		Enable Movement Collision With Environment(Event Player);
		Enable Movement Collision With Players(Event Player);
		Allow Button(Event Player, Button(Jump));
		
	}
}



rule("Reset Hanzo.")
{
    event
	{
		Subroutine;
		ResetHanzo;
	}

	actions
	{
		Stop Chasing Player Variable(Event Player, HanzoDragonPos);
		Stop Forcing Player Position(Event Player);
		
		Event Player.HanzoDragonTargetPos = Null;
		Event Player.HanzoDragonPos = Null;
		
	
	
		Event Player.HanzoUltimateAmmo = Null;	
		Allow Button(Event Player, Button(Jump));
		Set Ultimate Charge(Event Player, 0);
		Enable Movement Collision With Environment(Event Player);
		Enable Movement Collision With Players(Event Player);
		
		Stop Chasing Player Variable(Event Player, UltTimer);
		Event Player.UltTimer = Null;
		
		Destroy HUD Text(Event Player.UltTimerText);
		Event Player.UltTimerText = Null;
		
		Event Player.TeleportBackInBounds = True;
	}
}



rule("Hanzo description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
	
		

	}

	actions
	{
		
		Event Player.UltDescription = Custom String("Ride your dragons after firing them. You can use the ultimate 3 times in a row and change direction.{0}", Custom String("
		You pass through walls while riding the dragon. Press jump to hop off the dragon."));

	}
}





rule("Junker queen choose enemies for the arena fight.")
{
    event
	{
		Player Dealt Damage;
		All;
		Junker Queen;
	}

	conditions
	{
	
		Event Player.JunkerQueenInArena == Null;
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Event Ability == (Button(Ultimate));
		Array Contains(Event Player.JunkerQueenEnemyArray, Victim) == false;
	}

	actions
	{
	
		If(Event Player.JunkerQueenEnemyArray == Null);
		Event Player.JunkerQueenEnemyArray = Array(Victim);
		Event Player.JunkerQueenEnemyPositions = Array(Position Of(Victim));
		Else If(Array Contains(Event Player.JunkerQueenEnemyArray, Victim) == false);
		Modify Player Variable(Event Player, JunkerQueenEnemyArray, Append To Array, Victim);
		Modify Player Variable(Event Player, JunkerQueenEnemyPositions, Append To Array, Position Of(Victim));
		End;

		Heal(Victim, Null, Event Damage);
		
		If(Victim.JunkerTeleportPos == Null);
		Victim.JunkerTeleportPos = Position Of(Victim);
		End;
	

	}
}



rule("Junker queen timer for teleporting to arena after ultimate starts.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Is Alive(Event Player) == True;
	}

	actions
	{
	
		Wait(1.60, Abort When False);
		Event Player.JunkerReadyToTeleport = True;
		
	}
}



rule("Junker queen stop damage from ultimate ability.")
{

    event
	{
		Player Dealt Damage;
		All;
		Junker Queen;
	}

	conditions
	{
		
	
		Is Dummy Bot(Event Player) == false;
		Event Ability() == (Button(Ultimate));
	}

	actions
	{

		Set Player Health(Victim, Health(Victim) + Event Damage);

	}
}



rule("Junker queen Teleport JQ and chosen enemies and set buffs.")
{

    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerReadyToTeleport == True;
	
	
		Is Dummy Bot(Event Player) == false;
		Event Player.JunkerQueenEnemyArray != Null;
		Event Player.JunkerQueenInArena != true;
		Is Alive(Event Player) == True;
		Is True For All(Event Player.JunkerQueenEnemyArray, Is Dead(Current Array Element) == True) == false;
	}

	actions
	{

		Event Player.JunkerQueenPositions = Array(Position Of(Event Player));

	
		Global.JunkerArenaTimer = 30;
		
		
	
		Wait(0.01, Abort When False);


		Event Player.JunkerReadyToTeleport = Null;
		
		If(Event Player.JunkerDamageCounter == Null);
		Event Player.JunkerDamageCounter = 100 + Count Of(Event Player.JunkerQueenEnemyArray) * 50;
		Else;
		Event Player.JunkerDamageCounter += Count Of(Event Player.JunkerQueenEnemyArray) * 50;
		End;

	
		

		Set Damage Dealt(Event Player, Event Player.JunkerDamageCounter);
		
		
		
		Event Player.JunkerHealthBonus += Count Of(Event Player.JunkerQueenEnemyArray) * 150;
		
		If(Event Player.JunkerHealthPool == Null);
		Add Health Pool To Player(Event Player, Health, Event Player.JunkerHealthBonus, True, True);
		Event Player.JunkerHealthPool =  Last Created Health Pool;
		End;
		
		If(Event Player.JunkerScale == Null);
		Event Player.JunkerScale = 1 + Count Of(Event Player.JunkerQueenEnemyArray) * 0.2;
		Start Scaling Player(Event Player, Event Player.JunkerScale, True);
		Else;
		Event Player.JunkerScale += Count Of(Event Player.JunkerQueenEnemyArray) * 0.2;
		End;
		
		
		If(Event Player.JunkerCDReduction == Null);
		Event Player.JunkerCDReduction = 1 + Count Of(Event Player.JunkerQueenEnemyArray) * 0.5;
		Else;
		Event Player.JunkerCDReduction += Count Of(Event Player.JunkerQueenEnemyArray) * 0.5;
		End;
		
		
		If(Event Player.JunkerRageEffects == Null);
		Event Player.JunkerRageEffects = Empty Array;
	
	
		End;
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.JunkerQueenEnemyArray), 1);
		Create Effect(All Players(All Teams), Winston Primal Rage Effect, Team Of(Event Player), Event Player, 100, None);
		Modify Player Variable(Event Player, JunkerRageEffects, Append To Array, Last Created Entity);
		End;
		
		Set Gravity(Event Player, 0);
		Set Gravity(Event Player.JunkerQueenEnemyArray, 0);
		Set Ultimate Ability Enabled(Event Player, False);
		
		If(Event Player.JunkerWinCounterText == null);
		Create HUD Text(Event Player, String("{0} {1} {2}", Custom String("Win streak: "), Event Player.JunkerWinCounter, String("{0} {1}", Custom String("Damage bonus: "), String("{0}%", Event Player.JunkerDamageCounter))), Null, Null, Left, 1, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.JunkerWinCounterText = Last Text Id;
		End;		
		
		Set Player Health(Event Player, 10000);
		Set Player Health(Event Player.JunkerQueenEnemyArray, 10000);
		Set Ability Cooldown(Event Player, Button(Ability 1), 0);
		Set Ability Cooldown(Event Player, Button(Ability 2), 0);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), 0);
		Set Projectile Speed(Event Player, 200);

		If(Global.JunkerArenaSphere == Null);
		
		Teleport(Event Player.JunkerQueenEnemyArray, Position Of(Event Player) + Facing Direction Of(Event Player) * 10 + Up * 150);
		Teleport(Event Player, Position Of(Event Player) + Up * 150);

		Modify Player Variable(Event Player, JunkerQueenPositions, Append To Array, Position Of(Event Player));

		Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Value In Array(Event Player.JunkerQueenPositions, 1), 20, None);
		Event Player.JunkerArenaSphere = Last Created Entity;

		
	
		Global.JunkerArenaSphere = Event Player.JunkerArenaSphere;
		
		Global.JunkerArenaPositions = Event Player.JunkerQueenPositions;
		Else;
		
	
		Event Player.JunkerArenaSphere = Global.JunkerArenaSphere;
		
		Teleport(Event Player.JunkerQueenEnemyArray, Value In Array(Global.JunkerArenaPositions, 0) + Facing Direction Of(Event Player) * 10 + Up * 150);
		Teleport(Event Player, Value In Array(Global.JunkerArenaPositions, 0) + Up * 150);
		
		End;
		
		Event Player.JunkerQueenInArena = true;
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = True;
		
		Press Button(Event Player, Button(Ability 1));
		
		
		Wait Until((Is Dead(Event Player) && Event Player.ExtraLife != True) || Event Player.JunkerQueenInArena != True, Global.JunkerArenaTimer);
		
	
		
	
	
		
		If(Is Alive(Event Player) && Event Player.JunkerQueenInArena == True);
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Ultimate Ability Enabled(Event Player, True);
		
		Teleport(Event Player, Value In Array(Event Player.JunkerQueenPositions, 0));
		Event Player.JunkerQueenInArena = Null;
		
		Call Subroutine(ResetJQ);
		End;
		
	
		
	}
}



rule("Junker Decay buffs over time")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerDamageCounter > Null;
		Event Player.JunkerHealthBonus > Null;
		Event Player.JunkerQueenInArena != true;
	}

	actions
	{
		Wait(3, Abort When False);
		Event Player.JunkerDamageCounter -= 0.1 * (Event Player.JunkerDamageCounter - 100);
		
		If(Event Player.JunkerDamageCounter < 100.1);
		Event Player.JunkerDamageCounter = 0;
		Set Damage Dealt(Event Player, 100);
		Event Player.JunkerHealthBonus = Null;
		Remove Health Pool From Player(Event Player.JunkerHealthPool);
		Event Player.JunkerHealthPool = Null;
		Stop Scaling Player(Event Player);
		Event Player.JunkerScale = Null;
		Destroy Effect(Event Player.JunkerRageEffects);
		Event Player.JunkerRageEffects = Null;
		Event Player.JunkerCDReduction = Null;
		Else;
		
		Set Damage Dealt(Event Player, Event Player.JunkerDamageCounter);
		Event Player.JunkerHealthBonus -= 0.1 * Event Player.JunkerHealthBonus;
		Event Player.JunkerScale -= 0.1 * (Event Player.JunkerScale - 1);
		Event Player.JunkerCDReduction -=  0.1 * (Event Player.JunkerCDReduction - 1);
		
		If(Event Player.JunkerDamageCounter-50 <= Count Of(Event Player.JunkerRageEffects) * 50);
		Destroy Effect(Last Of(Event Player.JunkerRageEffects));
		Event Player.JunkerRageEffects = Remove From Array(Event Player.JunkerRageEffects, Last Of(Event Player.JunkerRageEffects));
	
		End;
		
		End;
		
		Loop If Condition Is True;
	}
}



rule("Junker queen don't teleport players who died before the ult finished.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{

	
		Is Dummy Bot(Event Player) == false;
		Event Player.JunkerQueenEnemyArray != Null;
		Event Player.JunkerQueenInArena != true;
		Is True For Any(Event Player.JunkerQueenEnemyArray, Is Dead(Current Array Element) == True) == true;
		Is Alive(Event Player) == True;
	}

	actions
	{
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Filtered Array(Count Of(Event Player.JunkerQueenEnemyArray), Is Dead(Current Array Element) == True), 1);
		Event Player.JunkerQueenEnemyArray = Remove From Array(Event Player.JunkerQueenEnemyArray, Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Is Dead(Current Array Element) == True), Event Player.ForLoopIndexPlayer));
		End;
		
		If(Is True For All(Event Player.JunkerQueenEnemyArray, Is Dead(Current Array Element) == True) == True);
		Event Player.JunkerQueenEnemyArray = Null;
		Event Player.JunkerReadyToTeleport = Null;
		End;
		
	}
}



rule("Push players back to arena if they flew too far. Teleport if too far away like if tracer uses recall.")
{

    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == true;
		Event Player.JunkerQueenEnemyArray != Null;
		((Is True For Any(Event Player.JunkerQueenEnemyArray, Distance Between(Current Array Element, Value In Array(Global.JunkerArenaPositions, 1)) > 20 && Is Alive(Current Array Element) == true) == True) || (Distance Between(Value In Array(Global.JunkerArenaPositions, 1), Event Player) > 20 && Is Alive(Event Player) == true)  == True) == True;
	}

	actions
	{
		Wait(0.1, Abort When False);

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True)), 1);
		If(Distance Between(Value In Array(Global.JunkerArenaPositions, 1), Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer)) > 20);
		Apply Impulse( Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Direction Towards(Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Value In Array(Global.JunkerArenaPositions, 1)), 20, To World, Cancel Contrary Motion);
		End;
		If(Distance Between(Value In Array(Global.JunkerArenaPositions, 1), Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer)) > 30);
		Teleport( Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Value In Array(Global.JunkerArenaPositions, 1));
		End;
		End;

		If(Distance Between(Value In Array(Global.JunkerArenaPositions, 1), Event Player) > 20);
		Apply Impulse( Event Player, Direction Towards(Event Player, Value In Array(Global.JunkerArenaPositions, 1)), 20, To World, Cancel Contrary Motion);
		End;

		If(Distance Between(Value In Array(Global.JunkerArenaPositions, 1), Event Player) > 30);
		Teleport( Event Player, Value In Array(Global.JunkerArenaPositions, 1));
		End;

		Loop If Condition Is True;

	}
}



rule("Reduce ability 1 cooldown after use for buffed Junker queen.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerRageEffects != Null;
        Event Player.JunkerDamageCounter > Null;
		Event Player.JunkerHealthBonus > Null;
	
	
	
	
		Ability Cooldown(Event Player, Button(Ability 1)) > 0;
	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Ability 1), 14 / Event Player.JunkerCDReduction);

	}
}



rule("Reduce ability 2 cooldown after use for buffed Junker queen.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;

	}

	conditions
	{
		Event Player.JunkerRageEffects != Null;
		Event Player.JunkerDamageCounter > Null;
		Event Player.JunkerHealthBonus > Null;
	
	
	
	
		Ability Cooldown(Event Player, Button(Ability 2)) > 0;

	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Ability 2), 8 / Event Player.JunkerCDReduction);

	}
}



rule("Reduce secondary fire cooldown after use for buffed Junker queen.")
{

    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;

	}

	conditions
	{
		Event Player.JunkerRageEffects != Null;
		Event Player.JunkerDamageCounter > Null;
		Event Player.JunkerHealthBonus > Null;
	
	
		Is Firing Secondary(Event Player) == True;
	
	
	

	}

	actions
	{
	
		Event Player.JunkerKnifeThrowCD = 6 / Event Player.JunkerCDReduction;
		Chase Player Variable At Rate(Event Player, JunkerKnifeThrowCD, 0, 1, Destination And Rate);
	
		
		Wait(0.37, Ignore Condition);
		
		Wait Until(Is Button Held(Event Player, Button(Secondary Fire)) == True, 2.63);
	
		Stop Chasing Player Variable(Event Player, JunkerKnifeThrowCD);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), Event Player.JunkerKnifeThrowCD);
	
		
		
		
	

	}
}



rule("If Junker queen lost, teleport enemies back to map and remove her buff.")
{

    event
	{
		Player Died;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == true;
		Event Player.JunkerQueenEnemyArray != Null;
		Event Player.ExtraLife != True;
	}

	actions
	{
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.JunkerQueenEnemyArray), 1);
		Teleport(Value In Array(Event Player.JunkerQueenEnemyArray, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.JunkerQueenEnemyPositions, Event Player.ForLoopIndexPlayer));
		Set Gravity(Value In Array(Event Player.JunkerQueenEnemyArray, Event Player.ForLoopIndexPlayer), Value In Array(Value In Array(Event Player.JunkerQueenEnemyArray, Event Player.ForLoopIndexPlayer).CurrentGravities, 0));	
		End;
	
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
	

		Set Ultimate Ability Enabled(Event Player, True);
		
		
		
	
		Set Knockback Dealt(Filtered Array(Event Player.JunkerQueenEnemyArray, Hero Of(Current Array Element) == Hero(Junker Queen)), 100);
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = Null;
		Event Player.JunkerQueenEnemyArray.JunkerTeleportPos = Null;
		Event Player.JunkerQueenInArena = Null;
		Event Player.JunkerQueenEnemyArray = Null;

	
		Event Player.JunkerArenaSphere = Null;
		
	
	
	
	

		Call Subroutine(ResetJQ);

	}
}




rule("If Junker queen dies after being buffed and not in arena, remove buffs.")
{
   
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerDamageCounter != Null;
		Event Player.JunkerHealthBonus != Null;
	
	
		Event Player.JunkerQueenInArena != true;
	
		(Is Dead(Event Player) == True && Event Player.ExtraLife != True) == True;
		
	}

	actions
	{
		Call Subroutine(ResetJQ);
	}
}




rule("Reset Junker Queen effects and buffs.")
{
   
    event
	{
		Subroutine;
		ResetJQ;
	}

	actions
	{

		Destroy Effect(Event Player.JunkerRageEffects);
		Event Player.JunkerRageEffects = Null;
		
		
		Set Damage Dealt(Event Player, 100);

		Remove Health Pool From Player(Event Player.JunkerHealthPool);
		
		Event Player.JunkerHealthBonus = Null;
		Event Player.JunkerHealthPool = Null;
		
		Event Player.JunkerTeleportPos = Null;
		Event Player.JunkerScale = Null;
		Event Player.JunkerCDReduction = Null;
		
		Set Ultimate Ability Enabled(Event Player, True);

		

		Destroy Hud Text(Event Player.JunkerWinCounterText);
		Event Player.JunkerWinCounterText = Null;

		Set Knockback Dealt(Event Player, 100);

		If(Event Player.JunkerQueenEnemyArray != Null);
		Event Player.JunkerQueenEnemyArray = Null;
		End;

		Event Player.JunkerDamageCounter = Null;
		Event Player.JunkerWinCounter = Null;

		Stop Scaling Player(Event Player);

		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));

		Event Player.JunkerReadyToTeleport = Null;
		

	
	

	}
}



rule("If enemies lost/JQ won, teleport Junker Queen back to map and keep her buffs and rage effect.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == true;
		Event Player.JunkerQueenEnemyArray != Null;
		Is True For All(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena != true) == True;
	}

	actions
	{
	
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		
	
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.JunkerQueenEnemyArray), 1);
		Set Gravity(Value In Array(Event Player.JunkerQueenEnemyArray, Event Player.ForLoopIndexPlayer), Value In Array(Value In Array(Event Player.JunkerQueenEnemyArray, Event Player.ForLoopIndexPlayer).CurrentGravities, 0));
		End;
		
		Teleport(Event Player, Value In Array(Event Player.JunkerQueenPositions, 0));
	
		Set Knockback Dealt(Filtered Array(Event Player.JunkerQueenEnemyArray, Hero Of(Current Array Element) == Hero(Junker Queen)), 100);
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = Null;
		Event Player.JunkerQueenInArena = Null;
		Event Player.JunkerQueenEnemyArray = Null;
		Set Ultimate Ability Enabled(Event Player, True);

		Event Player.JunkerArenaSphere = Null;
		Set Knockback Dealt(Event Player, 100);
		
		Modify Player Variable(Event Player, JunkerWinCounter, Add, 1);

		Set Knockback Dealt(Event Player, 100);
		
		Event Player.JunkerReadyToTeleport = Null;
		
		Event Player.JunkerTeleportPos = Null;
		
		
		Set Player Health(Event Player, 10000);
		
	
	
	

		
	}
}



rule("Teleport players out of the arena after timer runs out.")
{
    event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == True;
		Event Player.JunkerQueenEnemyArray == Null;
		Global.JunkerArenaTimer == Null;
	}

	actions
	{
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		
	
		If(Hero Of(Event Player) == Hero(Junker Queen));
		Set Knockback Dealt(Event Player, 100);
		End;
		
		Teleport(Event Player, Event Player.JunkerTeleportPos);
		
	
		
		
		Event Player.JunkerTeleportPos = Null;
		Event Player.JunkerQueenInArena = Null;
	
		

	}
}


rule("Destroy arena after some time.")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.JunkerArenaSphere != Null;
	}

	actions
	{
	
		Create HUD Text(Filtered Array(All Players(All Teams), Current Array Element.JunkerQueenInArena != Null), Global.JunkerArenaTimer, Null, Null, Top, 0, Color(Orange), Color(white), Color(white), Visible To And String, Default Visibility);
		Global.JunkerArenaTimerText = Last Text ID;
		Chase Global Variable At Rate(JunkerArenaTimer, 0, 1, None);
		Wait(Global.JunkerArenaTimer, Abort When False);
		
	
		
		
		Stop Chasing Global Variable(JunkerArenaTimer);
		
		Global.JunkerArenaTimer = Null;
		Destroy HUD Text(Global.JunkerArenaTimerText);
		Global.JunkerArenaTimerText = Null;
		Destroy Effect(Global.JunkerArenaSphere);
		Global.JunkerArenaSphere = Null;
	}
}


rule("If enemy died in arena, take them out of the fight.")
{
    event
	{
		Player Died;
		All;
		All;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == true;
		Event Player.JunkerQueenEnemyArray == Null;
	
		Event Player.ExtraLife != True;
	}

	actions
	{
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		
		Event Player.JunkerQueenInArena = Null;
	
		If(Hero Of(Event Player) == Hero(Junker Queen));
		Set Knockback Dealt(Event Player, 100);
		End;

		Event Player.JunkerTeleportPos = Null;
	}
}



rule("Pull enemy towards JQ with knife.")
{
    event
	{
		Player Dealt Knockback;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerQueenInArena == true;
	
		Hero Of(Event Player) == Hero(Junker Queen);
	}

	actions
	{
		Set Knockback Dealt(Event Player, 1);
		Apply Impulse(Victim, Direction Towards(Victim, Event Player), 30, To World, Cancel Contrary Motion);
	
	}
}



rule("Junker Queen description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
	
		

	}

	actions
	{
		
		
		Event Player.UltDescription = Custom String("After using her ultimate, every enemy that was hit is teleported alongside Junker Queen into a zero gravity {0}", Custom String("
		arena above the map. Junker Queen gains a buff for each enemy she has to face. If JQ defeats all of her enemies {0}", Custom String("
		in the arena, she will be teleported back to the map and keep all her buffs. If she loses then the other players {0}", Custom String(" 
		will be teleported and she loses the buffs. The buffs will passively decay over time outside the arena,{0}", Custom String("
		but she can stack buffs from winning consecutively. To become as strong as possible, {0}", Custom String("
		it's best to hit as many enemies as you can each time you use the ultimate."))))));

	}
}





rule("Junkrat activate ultimate ability. Set up suicide bomb.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Junkrat;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
	
		Event Player.CustomUltReadyToUse == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
		Is Dummy Bot(Event Player) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
		Event Player.JunkratBombPosition = Event Player;
	
		Create Projectile Effect(All Players(All Teams), Bastion A-36 Tactical Grenade, All PLayers(Team Of(Event Player)), Event Player.JunkratBombPosition, Null, 0.5, Visible To Position Direction and Size);
		Event Player.JunkratBombOrb = Last Created Entity;
		Event Player.JunkratExplosionRadius = 30;
		Create Effect(All Players(All Teams), Ring, Team Of(Event Player), Event Player.JunkratBombPosition, Event Player.JunkratExplosionRadius, Position And Radius);
		Event Player.JunkratRadiusRing = Last Created Entity;
		Event Player.UltTimer = 20;
		Create Hud Text(Event Player, Event Player.UltTimer, null, null, Top, 0, Color(Orange), Color(Orange), Color(Orange), String, Default Visibility);
		Event Player.UltTimerText = Last Text Id;
		Create In-World Text(All Players(All Teams), Event Player.UltTimer, Event Player.JunkratBombPosition + Up * 2, 10, Clip Against Surfaces, Visible To Position and String, Team Of(Event Player), Default Visibility);
		Event Player.UltTimerAboveHead = Last Text Id;
		Chase Player Variable At Rate(Event Player, UltTimer, 0, 1, None);
		Wait(Event Player.UltTimer, Ignore Condition);
		Create Projectile(Bastion A-36 Tactical Grenade, Event Player, Event Player.JunkratBombPosition, Down, To World, Damage, Opposite Team Of(Team Of(Event Player)), 800, 0.5, Event Player.JunkratExplosionRadius, Junkrat RIP Tire Explosion Effect, Junkrat RIP Tire Explosion Sound, 1, 100, 1, 30, 0, 100);
		
		If(Distance Between(Event Player, Event Player.JunkratBombPosition) < Event Player.JunkratExplosionRadius && Is In Line of Sight(Event Player, Event Player.JunkratBombPosition, All Barriers Block LOS));
		Damage(Event Player, Event Player, 800);
		End;
		
	
	
	
	
		Call Subroutine(ResetJunkrat);
	}
}



rule("Junkrat reset")
{
	event
	{
		Subroutine;
		ResetJunkrat;
	}

	actions
	{
		Destroy Effect(Event Player.JunkratBombOrb);
		Event Player.JunkratBombOrb = null;
		Destroy Hud Text(Event Player.UltTimerText);
		Event Player.UltTimerHUD = Null;
		Destroy In-World Text(Event Player.UltTimerAboveHead);
		Event Player.UltTimerAboveHead = Null;
		Destroy Effect(Event Player.JunkratRadiusRing);
		Event Player.JunkratRadiusRing = Null;
	
		Wait(0.01, Ignore Condition);
		Skip if(Event Player.UsingCustomUlt != true, 1);
		Call Subroutine(StopUsingCustomUlt);
	}
}



rule("Junkrat timer sound effect")
{

	event
	{
		Ongoing - Each Player;
		All;
		Junkrat;
	}

	conditions
	{
		Event Player.UsingCustomUlt == true;
		Is Dummy Bot(Event Player) == False;
		
	}

	actions
	{
		Wait(1, Ignore Condition);
		Play Effect(All Players(All Teams), Debuff Impact Sound, Team Of(Event Player), Event Player.JunkratBombPosition, 200);
		Loop If Condition Is True;
	}
}



rule("Junkrat drop bomb on death.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Junkrat;
	}

	conditions
	{
	
		Event Player.UsingCustomUlt == true;
		(Is Alive(Event Player) != true || ((Is Button Held(Event Player, Button(Interact)) == True) && Is Button Held(Event Player, Button(Crouch)) == False)) == True;
		Is Dummy Bot(Event Player) == False;
		
	}

	actions
	{
		Event Player.JunkratBombPosition = Position Of(Event Player);
	
	}
}







rule("Junkrat description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Junkrat;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Spawn and carry a timed bomb that does 800 damage in a 30 meter radius. {0}", Custom String(" 
		If you die with the bomb or press the interact button the bomb will be dropped on the ground. {0}", Custom String(" 
		The bomb will kill you if you are in its radius while it explodes.", Null, Null, Null), Null));

	}
}





rule("Lucio activate ult")
{
	event
	{
		Ongoing - Each Player;
		All;
		Lúcio;
	}

	conditions
	{
	
		Is Using Ultimate(Event Player) == True;
		
	
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
		Wait(0.5, Abort When False);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
		Play Effect(All Players(All Teams), Lúcio Sound Barrier Cast Sound, Color(white), Update Every Frame(Eye Position(Event Player)), 200);
	
		
		Damage(Players Within Radius(Event Player, 12, Opposite Team Of(Team Of(Event Player)), Off), Event Player, 50);
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Players Within Radius(Event Player, 12, Opposite Team Of(Team Of(Event Player)), Off)), 1);
		
		Apply Impulse(Value In Array(Players Within Radius(Event Player, 12, Opposite Team Of(Team Of(Event Player)), Off), Event Player.ForLoopIndexPlayer),  Direction Towards(Position Of(Event Player), Value In Array(Players Within Radius(Event Player, 12, Opposite Team Of(Team Of(Event Player)), Off), Event Player.ForLoopIndexPlayer) + Up*2), 20, To World, Cancel Contrary Motion);
		
		End;
		
		
		
		
	
		
		Loop If Condition Is True;

	}
}

rule("Lucio description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Lúcio;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("While using his regular ultimate, Lúcio drops the bass so hard that it creates damaging shockwaves around him.", Null);

	}
}





rule("McCree enable ult")
{

	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
	
	
	
		Set Status(Event Player, Event Player, Burning, 7);
		Wait Until(Is Dead(Event Player) == True || Is Using Ultimate(Event Player) == false, 7);
		Call Subroutine(ResetCassidy);
	}
}



rule("McCree loop visual effect that enemies see")
{
	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
	
		Wait(0.023, Ignore Condition);
	
	
		Play Effect(Remove From Array(All Players(All Teams), Event Player), Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player), 7.500);
	
		
		Loop If Condition Is True;
	}
}



rule("McCree loop visual effect that mccree sees")
{
	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
		Wait(0.1, Ignore Condition);
	
	
		Play Effect(Event Player, Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player) - Facing Direction Of(Event Player), 7.500);
	
		
		Loop If Condition Is True;
	}
}



rule("If sees McCree get damaged")
{
	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == False;
		Is True For Any(All Players(Opposite Team Of(Team Of(Event Player))), Is In Line of Sight(Current Array Element, Event Player, Barriers Do Not Block LOS)) == True;
		
	}

	actions
	{
		Wait(0.1, Ignore Condition);
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Is In View Angle(Current Array Element, Event Player, 20))), 1);
		
		Set Status(Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Is In View Angle(Current Array Element, Event Player, 20)), Event Player.ForLoopIndexPlayer), Event Player, Burning, 0.1);
		
		Damage(Value In Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))),Is In View Angle(Current Array Element, Event Player, 20)), Event Player.ForLoopIndexPlayer), Event Player, 10);
		
		
		End;
		Loop If Condition Is True;
	}
}



rule("If close to McCree get damaged")
{
	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Players Within Radius(Event Player, 5, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers) != Empty Array;
	}

	actions
	{
		Wait(0.1, Ignore Condition);
		
		Set Status(Players Within Radius(Event Player, 5, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player, Burning, 0.1);
		
		Damage(Players Within Radius(Event Player, 5, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player, 20);
		
		Loop If Condition Is True;
	}
}



rule("Reset McCree.")
{
	event
	{
		Subroutine;
		ResetCassidy;
	}

	actions
	{
	
	
	
		Clear Status(Event Player, Burning);
	}
}



rule("McCree description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Cassidy;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("It's literally high noon. While high nooning, {0}", Custom String("
		 Cassidy turns into a ball of fire that damages and burns enemies that look upon him directly or get too close.", Null));

	}
}





rule("Mei: za warudo")
{
		
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Has Status(Event Player, Hacked) == False;
		Global.T == Null;
		Is Alive(Event Player) == True;
		Is Dummy Bot(Event Player) == False;
		
	}

	actions
	{
	
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
	
		Create Effect(All Players(All Teams), Sphere, Color(Aqua), Event Player, Event Player.S, Visible To Position and Radius);
		Event Player.MeiZaWarudoSphere = Last Created Entity;
		
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
	
		Start Healing Modification(All Players(All Teams), Remove From Array(All Players(All Teams), Players On Hero(Hero(Mei), All Teams)), 0, Receivers Healers And Healing Percent);
		Global.TimeStopHealMod = Last Healing Modification ID;
		Pause Match Time;
		Global.T = Event Player;
		Global.TimeStopTimer = 5;
		Big Message(All Players(All Teams), Custom String("Mei has frozen time!"));
		Event Player.S = 1;
		Event Player.CustomUltReadyToUse = False;
		Create HUD Text(All Players(All Teams), Global.TimeStopTimer, Null, Null, Top, 0, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
	
		Event Player.MeiIcicleEffects = Empty Array;
		Event Player.MeiIciclePositions = Empty Array;
		Event Player.MeiIcicleDirections = Empty Array;
		
	
		Wait Until(Global.T == Null, Global.TimeStopTimer);
		Call Subroutine(ResetMei);
	}
}



rule("Mei: create icicle effects in the air")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Is Firing Secondary(Event Player) == True;
	
		Global.T != Null;
	}

	actions
	{
		Wait(0.321, Ignore Condition);
		Abort If(Global.T == Null);
		Cancel Primary Action(Event Player);
	
		Create Projectile Effect(All Players(All Teams), Mei Icicle, All Players(Team Of(Event Player)), Eye Position(Event Player), Facing Direction Of(Event Player), 0, None);
	
		Modify Player Variable(Event Player, MeiIcicleEffects, Append To Array, Last Created Entity);
		Modify Player Variable(Event Player, MeiIciclePositions, Append To Array, Eye Position(Event Player));
		Modify Player Variable(Event Player, MeiIcicleDirections, Append To Array, Facing Direction Of(Event Player));
		Wait(0.4, Ignore Condition);
		Cancel Primary Action(Event Player);
		
	}
}



rule("Mei reset")
{
	event
	{
		Subroutine;
		ResetMei;
	}

	actions
	{
		If(Global.T != Null);
		Global.T = Null;
		End;
		Event Player.S = 0;
		Event Player.Y = False;
		Unpause Match Time;
		Set Ultimate Ability Enabled(Event Player, True);
		
		Destroy Effect(Event Player.MeiZaWarudoSphere);
		
		Event Player.MeiZaWarudoSphere = Null;
		
	
		Play Effect(All Players(All Teams), Debuff Impact Sound, Color(White), Event Player, 200);
		Destroy HUD Text(Last Text ID);
		Set Ultimate Charge(Event Player, 0);
	
		
	
		
		If(Event Player.MeiIcicleEffects != Empty Array);
		Destroy Effect(Event Player.MeiIcicleEffects);
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.MeiIciclePositions), 1);
		Create Projectile(Mei Icicle, Event Player, Value In Array(Event Player.MeiIciclePositions, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.MeiIcicleDirections, Event Player.ForLoopIndexPlayer), To World, Damage, Opposite Team Of(Team Of(Event Player)), 75, 2, 0, Bad Explosion, Explosion Sound, 0, 115, 5, 0, 0, 0);
		
		End;
		End;
		
		
		Event Player.MeiIcicleEffects = Null;
		Event Player.MeiIciclePositions = Null;
		Event Player.MeiIcicleDirections = Null;
		
		
	}
}






rule("Mei: freeze players and stop horizontal movement")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Global.T != Null;
		Hero Of(Event Player) != Hero(Mei);
		Is Alive(Event Player) == True;
	}

	actions
	{
		Set Gravity(Event Player, 10);
		Set Status(Event Player, Null, Frozen, 9999);
		disabled Set Status(Event Player, Null, Rooted, 9999);
		disabled Set Status(Event Player, Null, Hacked, 9999);
		disabled Disallow Button(Event Player, Button(Primary Fire));
		disabled Disallow Button(Event Player, Button(Secondary Fire));
		disabled Start Facing(Event Player, Facing Direction Of(Event Player), 10000, To World, None);
		disabled Disallow Button(Event Player, Button(Interact));
		disabled Disallow Button(Event Player, Button(Crouch));
		Apply Impulse(Event Player, Backward, 0.001, To World, Cancel Contrary Motion);
		Apply Impulse(Event Player, Right, 0.001, To World, Cancel Contrary Motion);
		Apply Impulse(Event Player, Left, 0.001, To World, Cancel Contrary Motion);
		Apply Impulse(Event Player, Forward, 0.001, To World, Cancel Contrary Motion);
		Set Status(Event Player, Null, Unkillable, 9999);
		Event Player.M = Health(Event Player);
		Disallow Button(Event Player, Button(Ultimate));
		Event Player.TimeStopStunned = True;
	}
}



rule("Mei: stop players from falling")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Global.T != Null;
		Hero Of(Event Player) != Hero(Mei);
		Is In Air(Event Player) == True;
		Speed Of(Event Player) > 0;
	}

	actions
	{
		Wait(0.001, Ignore Condition);
		Apply Impulse(Event Player, Up, 0.001, To Player, Cancel Contrary Motion);
		Loop If Condition Is True;
	}
}



rule("Mei: clear frozen status after time stop is over and damage players")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
	
		Is True For All(All Players(All Teams), Current Array Element != Global.T) == True;
		Hero Of(Event Player) != Hero(Mei);
		Event Player.TimeStopStunned == True;
	}

	actions
	{
		Allow Button(Event Player, Button(Ultimate));
		Clear Status(Event Player, Frozen);
		Clear Status(Event Player, Unkillable);
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));
		Event Player.TimeStopStunned = False;
		Stop Healing Modification(Global.TimeStopHealMod);
		Global.TimeStopHealMod = Null;
		Wait(0.016, Ignore Condition);
		Skip If(Event Player.O == Null, 4);
		Damage(Event Player, Event Player.O, Event Player.N);
		Set Ultimate Charge(Event Player.O, 0);
		Event Player.N = Null;
		Event Player.O = Null;
	}
}



rule("Mei: global time stop timer")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.T != Null;
	}

	actions
	{
		Wait(1, Ignore Condition);
		Global.TimeStopTimer -= 1;
		If(Global.TimeStopTimer <= 0);
		Global.T = Null;
		End;
		Loop If Condition Is True;
	}
}



rule("Mei: store damage dealt during time stop")
{
	event
	{
		Player Dealt Damage;
		All;
		Mei;
	}

	conditions
	{
	
		Global.T != Null;
	}

	actions
	{
		Victim.N += Event Damage;
		Heal(Victim, Null, Event Damage);
		Victim.O = Event Player;
	}
}



rule("Mei: za warudo effect")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Event Player.S > 0;
		Event Player.S < 100;
		Event Player.Y != True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S += 2;
		Loop If Condition Is True;
	}
}



rule("Mei: za warudo effect 2")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Event Player.S > 100;
	}

	actions
	{
		Event Player.Y = True;
		Wait(0.016, Ignore Condition);
		Event Player.S -= 2;
		Loop If(Event Player.S > 0);
		Destroy Effect(Event Player.MeiZaWarudoSphere);
		Event Player.MeiZaWarudoSphere = Null;
		
	}
}






rule("Mei description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Mei freezes time to a still. Attacks during time stop will cause damage after time resumes.{0}", Custom String("
		Icicles will be frozen in air until the time stop ends. Enemy Meis are immune."));

	}
}





rule("Mercy give extra life to herself during Ultimate")
{
   
	event
	{
		Ongoing - Each Player;
		All;
		Mercy;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Event Player.ExtraLife != True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Event Player.ExtraLife = True;
		Create HUD Text(Event Player, Custom String("You just gained an extra life."), Null, Null, Top, 0, Color( Yellow), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.MercyExtraLifeText = Last Text ID;
		Create In-World Text(All Players(All Teams), Custom String("Extra life"), Event Player, 1, Clip Against Surfaces,
			Visible To Position and String, Color(Yellow), Default Visibility);
		Event Player.ExtraLifeInWorldText = Last Text ID;

	}
}



rule("Mercy give extra life if mercy healed them")
{
	event
	{
		Player Dealt Healing;
		All;
		Mercy;
	}

	conditions
	{
		Is Using Ultimate(Healer) == True;
		Healee.ExtraLife != True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Healee.ExtraLife = True;
		Create HUD Text(Healee, Custom String("Mercy gave you an extra life. Resurrect upon death."), Null, Null, Top, 0, Color(
			Yellow), Color(White), Color(White), Visible To and String, Default Visibility);
		Healee.MercyExtraLifeText = Last Text ID;
		Create In-World Text(All Players(All Teams), Custom String("Extra life"), Healee, 1, Clip Against Surfaces,
			Visible To Position and String, Color(Yellow), Default Visibility);
		Healee.ExtraLifeInWorldText = Last Text ID;

	}
}



rule("Mercy: Resurrect player upon death if they have an extra life.")
{
	event
	{
		Player Died;
		All;
		All;
	}

	conditions
	{
		Event Player.ExtraLife == True;
	}

	actions
	{
		Wait(2, Ignore Condition);
		Teleport(Event Player, Nearest Walkable Position(Event Player));
		Resurrect(Event Player);
		Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Event Player, 1);
		Play Effect(All Players(All Teams), Buff Impact Sound, Color(White), Event Player, 10);
		Destroy HUD Text(Event Player.MercyExtraLifeText);
		Event Player.MercyExtraLifeText = Null;
		Destroy In-World Text(Event Player.ExtraLifeInWorldText);
		Event Player.ExtraLifeInWorldText = Null;
		Wait(0.1, Ignore Condition);
		Event Player.ExtraLife = Null;

	}
}



rule("Mercy description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mercy;
	}

	conditions
	{
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Grant a bonus life to every hero you heal during Mercy's ult.");

	}
}





rule("moira: coalescence X 100 set initial modifications")
{
	event
	{
		Ongoing - Each Player;
		All;
		Moira;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Wait(0.5, Ignore Condition);
	
		Event Player.UsingCustomUlt = True;
	}
}



rule("moira: coalescence X 100 loop effects")
{
	event
	{
		Ongoing - Each Player;
		All;
		Moira;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Event Player.UsingCustomUlt == True;
	
	
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Wait(0.100, Ignore Condition);
		
	
		Set Aim Speed(Event Player, 10);
		Set Status(Event Player, Null, Rooted, 0.100);
		Start Accelerating(Event Player, Backward, 50, 2, To Player, Direction Rate and Max Speed);


		Event Player.M = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(
			Event Player)) * 30, Y Component Of(Facing Direction Of(Event Player)) * 30 + 2, Z Component Of(Facing Direction Of(
			Event Player)) * 30), All Players(All Teams), Event Player, True);
		Play Effect(All Players(All Teams), Bad Explosion, Color(Purple), Event Player.M, 20);
		Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Event Player.M, 20);
		Play Effect(All Players(All Teams), Explosion Sound, Color(Purple), Event Player.M, 2000);
		
	
		
			
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers)), 1);
		
		Apply Impulse(Value In Array(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player.ForLoopIndexPlayer),  Direction Towards(Position Of(Event Player.M), Value In Array(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Event Player.ForLoopIndexPlayer) + Up), 10, To World, Cancel Contrary Motion);
		
		End;	
		
		Damage(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 50);
		Heal(Players Within Radius(Event Player.M, 10, Team Of(Event Player), Surfaces),
			Event Player, 50);	
		Loop If Condition Is True;
		Call Subroutine(ResetMoira);
	}
}



rule("Reset Moira")
{
	event
	{
		Subroutine;
		ResetMoira;
	}

	actions
	{
		Clear Status(Event Player, Rooted);
		Stop Accelerating(Event Player);
		Set Aim Speed(Event Player, 100);
		Event Player.M = Null;
		Event Player.UsingCustomUlt = Null;
	
	}
}





rule("Moira description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Moira;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Coalescencex100. Coalescence creates massive explosions that damage enemies and heal allies. {0}", Custom String("
		The power is so great that it pushes her back and she can't move freely.", Null));

	}
}





rule("Orisa: leap in facing direction")
{
	event
	{
		Ongoing - Each Player;
		All;
		Orisa;
	}

	conditions
	{
	
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Jump)) == True;
		Is On Ground(Event Player) == True;

	}

	actions
	{

		Apply Impulse(Event Player, Facing Direction Of(Event Player), 20, To World, Cancel Contrary Motion);

		Wait(0.1, Ignore Condition);
	
	

	
	}
}






rule("Orisa description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Orisa;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Press jump to jump around during Orisa's ultimate.", Null, Null, Null);

	}
}





rule("Pharah activate ultimate when button is pressed")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
	
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		Is Dummy Bot(Event Player) == False;
		
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Apply Impulse(Event Player, Up, 10, To World, Cancel Contrary Motion);
	
		Set Primary Fire Enabled(Event Player, False);
		Event Player.R = 20;
		Chase Player Variable At Rate(Event Player, R, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("{0} {1}", Custom String("Crouch to drop bombs."), Custom String("Ability 1 to activate top-down camera.")), String("{0}: {1}", Custom String("Bomb Cooldown: "), Event Player.S), String("{0}: {1}", Custom String("Ultimate Duration: "), Event Player.R), Right, 1, Color(Blue), Color(Blue), Color( White), Visible To and String, Default Visibility);
	
	
		Set Ability 1 Enabled(Event Player, False);
		Disallow Button(Event Player, Button(Jump));
		Disallow Button(Event Player, Button(Secondary Fire));
		
		Value In Array(Event Player.CurrentGravities, 0) -= 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
	
	
		Event Player.UsingCustomUlt = True;
		Wait Until(Is Dead(Event Player) == True, Event Player.R);
		Call Subroutine(ResetPharah);
	}
}



rule("Reset Pharah stuff.")
{
	event
	{
		Subroutine;
		ResetPharah;
	}

	actions
	{
		Event Player.UsingCustomUlt = 0;
		Event Player.CustomUltReadyToUse = 0;
	
		Value In Array(Event Player.CurrentGravities, 0) += 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Ultimate Ability Enabled(Event Player, True);
	
		Set Ability 1 Enabled(Event Player, True);
		Allow Button(Event Player, Button(Jump));
		Allow Button(Event Player, Button(Secondary Fire));
	
	
		Destroy HUD Text(Last Text ID);
		Destroy Effect(Event Player.P);
		Event Player.M = Null;
		Event Player.G = Null;
		Event Player.P = Null;
	
		Event Player.Q = Null;
		Event Player.R = Null;
		Stop Camera(Event Player);
		Set Primary Fire Enabled(Event Player, True);
	
		Event Player.U = 0;
		Stop Damage Over Time(Last Damage Over Time ID);
		Clear Status(Event Player, Burning);
		
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
	}
}



rule("Pharah drop bomb")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Crouch)) == True;
	
	}

	actions
	{
		Create Projectile(Bastion A-36 Tactical Grenade, Event Player, Position Of(Event Player), Down, To World, Damage, Opposite Team Of(Team Of(Event Player)), 300, 0.5, 5, Bastion Tank Cannon Explosion Effect, Ashe Dynamite Explosion Sound, 0, 0, 10, 10, 0, 100);
		
	
		Wait(3, Ignore Condition);
	}
}



rule("Pharah damage player when hitting ground during ult")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	
	
		Distance Between(Event Player, Ray Cast Hit Position(Event Player, Event Player + Down*0.8, Null, Event Player, False)) < Distance Between(Event Player, Event Player + Down*0.8);
	}

	actions
	{
		Wait(0.2, Abort When False);
	
		Damage(Event Player, Event Player, 10);
	
	

		Set Status(Event Player, Event Player, Burning, 0.2);
		Loop If Condition Is True;
	}
}



rule("Pharah tacticool camera on")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ability 1)) == True;
		Event Player.UsingCustomUlt == True;
		Event Player.Q != True;
	}

	actions
	{
		Wait(0.200, Ignore Condition);
		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player)) + Up * 5, Update Every Frame(Eye Position(Event Player)) + Down * 30, 100);
		Event Player.Q = True;
	}
}



rule("Pharah tacticool camera off")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ability 1)) == True;
		Event Player.UsingCustomUlt == True;
		Event Player.Q == True;
	}

	actions
	{
		Wait(0.200, Ignore Condition);
		Stop Camera(Event Player);
		Event Player.Q = Null;
	}
}



rule("Pharah fly when ultimate is active")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		disabled Skip If(Is Button Held(Event Player, Button(Jump)) == True, 1);
		disabled Apply Impulse(Event Player, Facing Direction Of(Event Player), 0.300, To World, Incorporate Contrary Motion);
		disabled Skip If(Is Button Held(Event Player, Button(Primary Fire)) != True, 1);
		Apply Impulse(Event Player, Facing Direction Of(Event Player), 0.500, To World, Incorporate Contrary Motion);
		Loop If Condition Is True;
	}
}



rule("Pharah shoot machine gun")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	}

	actions
	{
		Wait(0.050, Ignore Condition);
		Create Projectile(Mercy Caduceus Blaster, Event Player, Eye Position(Event Player) + Left*0.5, Null, To World, Damage, Opposite Team Of(Team Of(Event Player)), 10, 2, 0, Bad Explosion, Explosion Sound, 0, 50, 5, 0, 0, 0);
		Create Projectile(Mercy Caduceus Blaster, Event Player, Eye Position(Event Player) + Right*0.5, Null, To World, Damage, Opposite Team Of(Team Of(Event Player)), 10, 2, 0, Bad Explosion, Explosion Sound, 0, 50, 5, 0, 0, 0);
		Play Effect(All Players(All Teams), Debuff Impact Sound, Color(White), Event Player, 10000);
		Loop If Condition Is True;
	}

}





rule("Pharah description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Pharah;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Fly around like a jet. Press primary fire to shoot machine gun and crouch to drop bombs. {0}", Custom String("
		Press ability 1 to switch to top-down camera for bomb aiming. Flying too close to ground causes damage."));

	}
}





rule("Reaper activate ultimate.")
{
    
    event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

    conditions{
        Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == Null;
	
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		Is Dummy Bot(Event Player) == False;
		
    }

    actions
    {
        Call Subroutine(UseCustomUlt);
		Set Primary Fire Enabled(Event Player, False);
	
	
		Value In Array(Event Player.CurrentSpeeds, 0) += 50;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));

		Create Effect(All Players(All Teams), Bad Aura, Color(Black), Event Player, 1, POSITION AND RADIUS);
		Event Player.ReaperVariables = Array(Last Created Entity);

	
		Modify Player Variable(Event Player, ReaperVariables, Append To Array, 15);

		Create Hud Text(Event Player, Value In Array(Event Player.ReaperVariables, 1), Null, null, Top, 1, Color(Purple), Color(Purple), Color(Purple), Visible to and string, default Visibility);
		Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Text ID);
	

		
	
	
		
		Create Effect(All Players(All Teams), Bad Aura, Color(Purple), Event Player, 1, POSITION AND RADIUS);
	
		Value In Array(Event Player.ReaperVariables, 4) = Last Created Entity;



		Wait Until(Is Dead(Event Player) == True, Value In Array(Event Player.ReaperVariables, 1));

		

        
        Call Subroutine(ResetReaper);


    }
}



rule("Reaper reset stuff.")
{
    event
	{
		Subroutine;
		ResetReaper;
	}

    actions
    {   
		Set Primary Fire Enabled(Event Player, True);
		Destroy Effect(Value In Array(Event Player.ReaperVariables, 0));
		Destroy Hud Text(Value In Array(Event Player.ReaperVariables, 2));
		Value In Array(Event Player.CurrentSpeeds, 0) -= 50;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));


		Destroy Effect(Value In Array(Event Player.ReaperVariables, 3));
		Destroy Effect(Value In Array(Event Player.ReaperVariables, 4));


		Event Player.ReaperTPPos = Null;

		Event Player.ReaperVariables = Null;
		
		Event Player.TeleportBackInBounds = True;
		
        Call Subroutine(StopUsingCustomUlt);


    }
}



rule("Reaper countdown timer.")
{

    event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

    conditions{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
		Hero Of(Event Player) == Hero(Reaper);
		Event Player.ReaperVariables != Null;
		Value In Array(Event Player.ReaperVariables, 1) != Null;
    }

    actions
    {
		Wait(1, Abort When False);

		Value In Array(Event Player.ReaperVariables, 1) -= 1;

		


	
	

	
	


		

		

		Loop If Condition Is True;



    }
}



rule("Reaper pass through walls in wraith form and set gravity to 0.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

    conditions{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Is Using Ability 1(Event Player) == True;
    }

    actions
    {
	
	
        Disable Movement Collision With Environment(Event Player, false);
		Value In Array(Event Player.CurrentGravities, 0) -= 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
	
	
		Wait Until(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Hero Of(Event Player) != Hero(Reaper) || Is Dead(Event Player) == True, 3);
        Enable Movement Collision With Environment(Event Player);
		Value In Array(Event Player.CurrentGravities, 0) += 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
	
	
	
	




    }
}



rule("Reaper reduce cooldown for wraith form.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

    conditions{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Ability Cooldown(Event Player, Button(Ability 1)) > 0;
    }

    actions
    {
		Set Ability Cooldown(Event Player, Button(Ability 1), 4);
		




    }
}



rule("Reaper reduce cooldown for teleport.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

    conditions{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Ability Cooldown(Event Player, Button(Ability 2)) > 0;
    }

    actions
    {
		Set Ability Cooldown(Event Player, Button(Ability 2), 2);
		




    }
}



rule("Reaper cause extra damage with melee strikes.")
{
    event
	{
		Player Dealt Damage;
		All;
		Reaper;
	}

    conditions{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Event Ability() == Button(Melee);
    }

    actions
    {
		Damage(Victim, Event Player, 350);
		




    }
}



rule("Reaper fly when in wraith form and ultimate is active")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Is Using Ability 1(Event Player) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Apply Impulse(Event Player, Facing Direction Of(Event Player), 0.100, To World, Incorporate Contrary Motion);
		Loop If (Ability Cooldown(Event Player, Button(Ability 1)) == 0 && Hero Of(Event Player) == Hero(Reaper) && Is Alive(Event Player) == True);
	}
}



rule("Reaper disable teleport ability when it's on cooldown")
{

	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
		Ability Cooldown(Event Player, Button(Ability 2)) > 0;
	}

	actions
	{
		Set Ability 2 Enabled(Event Player, False);
	}
}



rule("Reaper enable teleport ability when it's not on cooldown")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
	
	
		Has Status(Event Player, Hacked) == False;
		Ability Cooldown(Event Player, Button(Ability 2)) == 0;
	}

	actions
	{
		Set Ability 2 Enabled(Event Player, True);
	}
}



rule("Reaper instant teleport activate aim")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
	
		Has Status(Event Player, Hacked) == False;
	
		Is Button Held(Event Player, Button(Ability 2)) == True;
		Ability Cooldown(Event Player, Button(Ability 2)) == 0;
	
	
	}

	actions
	{

		Cancel Primary Action(Event Player);

		Create Effect(Event Player, Bad Aura, Color(Purple), Event Player.ReaperTPPos, 1, POSITION AND RADIUS);
	

		Value In Array(Event Player.ReaperVariables, 3) = Last Created Entity;


		



		
		

		

		
		

	}
}



rule("Reaper instant teleport update aim position")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
		Hero Of(Event Player) == Hero(Reaper);
		Has Status(Event Player, Hacked) == False;
		Ability Cooldown(Event Player, Button(Ability 2)) == 0;
		Value In Array(Event Player.ReaperVariables, 3) != Null;
	
	
	}

	actions
	{

		Wait(0.01, Abort When False);

		Event Player.ReaperTPPos = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False) - Facing Direction Of(Event Player);

		
	
	
		
		Loop If Condition Is True;

	}
}



rule("Reaper execute teleport")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Event Player.CustomUltReadyToUse != True;
		Event Player.UsingCustomUlt != Null;
		Hero Of(Event Player) == Hero(Reaper);
		Has Status(Event Player, Hacked) == False;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
		Ability Cooldown(Event Player, Button(Ability 2)) == 0;
		Value In Array(Event Player.ReaperVariables, 3) != Null;
	}

	actions
	{

		Event Player.ReaperTPPos = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False) - Facing Direction Of(Event Player);
		

		Teleport(Event Player, Event Player.ReaperTPPos);

	
		Set Ability Cooldown(Event Player, Button(Ability 2), 2);


		Wait(0.01, Ignore Condition);

		Destroy Effect(Value In Array(Event Player.ReaperVariables, 3));

		Value In Array(Event Player.ReaperVariables, 3) = Null;


		Event Player.ReaperTPPos = Null;

		Play Effect(All Players(All Teams), Moira Fade Reappear Sound, null, Event Player, 200);


	}
}



rule("Reaper description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Guns disabled, but melee kills in one hit. Instant teleportation ability. Wraith form flies through walls.");

	}
}





rule("Rein: ult ready")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
	
		Ultimate Charge Percent(Event Player) > 99.900;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Event Player.U = True;
	
	
	
	}
}



rule("reinhardt: set variables when using ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
	
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.U == True;
		disabled Global.S != Event Player;
		Is Dummy Bot(Event Player) == false;
		Event Player.S != True;


	}

	actions
	{
	
	
		disabled Global.S = Event Player;
		Event Player.Q = 0;
		Create Effect(All Players(All Teams), Bad Aura, Color(Orange), Event Player, Event Player.Q, Visible To Position and Radius);
		Event Player.UsingCustomUlt = Last Created Entity;
		Create Effect(All Players(All Teams), Bad Aura Sound, Team Of(Event Player), Event Player, Event Player.Q, Visible To Position and Radius);
		Event Player.G = Last Created Entity;
		Event Player.R = 100;
		Event Player.Y = 10;
	
		Create HUD Text(Event Player, Custom String("Power-up duration: "), Event Player.Y, String("{0} {1}", String("{0} {1} {2}", String("Damage"), String("Dealt"), String("{0}%", Event Player.R)), String("{0} {1} {2}", String("Damage"), Custom String("received: "), String("{0}%", Event Player.P))), Right, 0, Color(Yellow), Color(Yellow), Color(White), Visible To and String, Default Visibility);
		
		
		
		Event Player.ReinhardtHudText = Last Text ID;
		Event Player.S = True;
		Event Player.P = 100;
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Event Player.U = false;

	}
}



rule("reinhardt: increase buffs in the air")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
	
		Is In Air(Event Player) == True;
		Event Player.S == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Wait(0.200, Ignore Condition);
		
	
	
		
	
	
		Event Player.R += 30;
		Event Player.Q += 0.300;
		Set Damage Dealt(Event Player, Event Player.R);
		
	
	
		Event Player.P -= 12;
		If(Event Player.P < 0);
		Event Player.P = 0;
		End;
		Set Damage Received(Event Player, Event Player.P);
		Loop If Condition Is True;
		Wait(1, Ignore Condition);
	
		Skip If(Event Player.M == True, 1);
		Call Subroutine(ResetReinhardt);
	}
}



rule("reinhardt: reset stuff")
{
	event
	{
		Subroutine;
		ResetReinhardt;
	}

	actions
	{
		Stop Chasing Player Variable(Event Player, Y);
		Event Player.R = 0;
		Event Player.Q = 0;
		Destroy Effect(Event Player.UsingCustomUlt);
		Event Player.UsingCustomUlt = Null;
		Destroy Effect(Event Player.G);
		Event Player.G = Null;
		Set Damage Dealt(Event Player, 100);
		Event Player.Y = 0;
		Destroy HUD Text(Event Player.ReinhardtHudText);
		Event Player.ReinhardtHudText = Null;
		Clear Status(Event Player, Burning);
		Set Damage Received(Event Player, 100);
	
		Event Player.P = 0;
		Event Player.S = 0;
		Set Ultimate Ability Enabled(Event Player, True);
		Event Player.M = Null;
	
	}
}



rule("reinhardt: do stuff when earthshatter has landed")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Event Player.S = 0;
		Event Player.M = True;
		Chase Player Variable At Rate(Event Player, Y, 0, 1, Destination and Rate);
		Set Ultimate Ability Enabled(Event Player, False);
	
	
		Wait Until(Is Dead(Event Player) == True, Event Player.Y);
		Call Subroutine(ResetReinhardt);
	}
}



rule("Reinhardt: Start burning when power up is over 8 secs")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
		Event Player.S == True;
		Event Player.Y == 8;
	}

	actions
	{
		Set Status(Event Player, Null, Burning, 9999);
	}
}

		


rule("Reinhardt disable power up if ult hasn't been used and player is on ground")
{

	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
		Is On Ground(Event Player) == True;
		Event Player.M != True;
		Event Player.S == True;
	}

	actions
	{
		Wait(0.250, Abort When False);

		Call Subroutine(ResetReinhardt);
	}
}



rule("Reinhardt description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Reinhardt;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Jump down from high while using earthshatter to get increased damage and damage resistance for 10 seconds.{0}", Custom String(" 
		Buff effectiveness increased by air time."));

	}
}





rule("Roadhog activate and deactivate ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		Roadhog;
	}

	conditions
	{
	
		Event Player.CustomUltReadyToUse == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Event Player.P = Remove From Array(All Players(All Teams), Event Player);
		Event Player.Y = 20;
		Chase Player Variable At Rate(Event Player, Y, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("{0} {1}", Custom String("Reflect damage and healing.
		Ultimate Duration: "), Event Player.Y), Null, Null, Top, 5, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.RoadhogHUD = Last Text Id;
		Event Player.UsingCustomUlt = True;
		Create Effect(Event Player.P, Sphere, Color(White), Event Player, 2, Visible To Position and Radius);
	
		Wait Until(Is Dead(Event Player) == True, Event Player.Y);
	
		Skip If(Event Player.CustomUltReadyToUse == Null, 1);
		Call Subroutine(ResetRoadhog);
	}
}



rule("Roadhog reset")
{
	event
	{
		Subroutine;
		ResetRoadhog;
	}

	actions
	{
		Destroy Effect(Last Created Entity);
		Event Player.UsingCustomUlt = Null;
		Event Player.CustomUltReadyToUse = Null;
	
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Destroy HUD Text(Event Player.RoadhogHUD);
		Event Player.RoadhogHUD = Null;
		Event Player.Y = Null;
		Event Player.P = Null;
		
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
	}
}



rule("Roadhog reflect damage")
{
	event
	{
		Player Took Damage;
		All;
		Roadhog;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Damage(Attacker, Event Player, Event Damage);
	}
}



rule("Roadhog reflect healing")
{
	event
	{
		Player Received Healing;
		All;
		Roadhog;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Heal(Healer, Event Player, Event Healing);
	}
}



rule("Roadhog description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Roadhog;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Reflect all damage and healing back to sender.");

	}
}





rule("Sigma zero/high gravity")
{

	event
	{
		Ongoing - Each Player;
		All;
		Sigma;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Is Alive(Event Player) == True;
	
	}

	actions
	{
		Call Subroutine(UseCustomUlt);

	
	

		If(Global.UltingSigmas == Null);
		Global.UltingSigmas = Array(Event Player);
	
		Else;
		Modify Global Variable(UltingSigmas, Append To Array, Event Player);
		End;


		Event Player.UltTimer = 15;
		Big Message(All Players(All Teams), Hero Icon String(Hero(Sigma)));
		Set Gravity(Event Player, 0);
		Create HUD Text(Event Player, Event Player.UltTimer, Null, Null, Right, 0, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.SigmaMaleValues = Array(Last Text ID);

		Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Event Player, 20, Position and Radius);
		Modify Player Variable(Event Player, SigmaMaleValues, Append To Array, Last Created Entity);

		Chase Player Variable At Rate(Event Player, UltTimer, 0, 1, Destination and Rate);
		Wait Until(Is Dead(Event Player) == true, Event Player.UltTimer);
		Call Subroutine(ResetSigma);
	}
}



rule("Reset Sigma")
{
	event
	{
		Subroutine;
		ResetSigma;
	}

	actions
	{
		Destroy HUD Text(Value In Array(Event Player.SigmaMaleValues, 0));
		Destroy Effect(Value In Array(Event Player.SigmaMaleValues, 1));

		Modify Global Variable(UltingSigmas, Remove From Array By Value, Event Player);

		Stop Chasing Player Variable(Event Player, UltTimer);
		Event Player.UltTimer = Null;

		Call Subroutine(StopUsingCustomUlt);
	}
}



rule("Sigma set zero grav buff to true")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff == Null;
		(Remove From Array(Global.UltingSigmas, All Players(Opposite Team Of(Team Of(Event Player)))) != Empty Array && Remove From Array(Global.UltingSigmas, Opposite Team Of(Team Of(Event Player))) != Null) == True;
		Is True For Any(Remove From Array(Global.UltingSigmas, All Players(Opposite Team Of(Team Of(Event Player)))), Distance Between(Current Array Element, Event Player) <= 20) == true;

	
	}

	actions
	{
	
	
		Event Player.SigmaZeroGravBuff = True;
		
		Value In Array(Event Player.CurrentGravities, 0) -= 100;
		Value In Array(Event Player.CurrentGravities, 1) -= 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
	
	
		

	
	}
}



rule("Sigma set zero grav buff to false and stop acceleration")
{
   

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff == True;
		Is True For Any(Remove From Array(Global.UltingSigmas, Opposite Team Of(Team Of(Event Player))), Distance Between(Current Array Element, Event Player) <= 20) == false;

		(Hero Of(Event Player) != Hero(Sigma) || Event Player.UsingCustomUlt != True) == True;
	}

	actions
	{
	
	
		Event Player.SigmaZeroGravBuff = false;
		Stop Accelerating(Event Player);
		Value In Array(Event Player.CurrentGravities, 0) += 100;
		Value In Array(Event Player.CurrentGravities, 1) += 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
	
	
		

	
	}
}



rule("Sigma set high grav debuff to true and increase gravity and speed values when close to enemy sigma")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaHighGravDebuff == null;
		(Remove From Array(Global.UltingSigmas, All Players(Team Of(Event Player))) != Empty Array && Remove From Array(Global.UltingSigmas, Team Of(Event Player)) != Null) == True; 
		Is True For Any(Remove From Array(Global.UltingSigmas, All Players(Team Of(Event Player))), Distance Between(Current Array Element, Event Player) <= 20) == True;
	}

	actions
	{
	
		Event Player.SigmaHighGravDebuff = True;

		Value In Array(Event Player.CurrentGravities, 0) += 400;
		Value In Array(Event Player.CurrentGravities, 1) += 400;
		Value In Array(Event Player.CurrentSpeeds, 0) -= 80;
		Value In Array(Event Player.CurrentSpeeds, 2) -= 80;

		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));

	
	
	
	

	

	
	}
}



rule("Sigma set high grav debuff to null and reduce gravity and speed values when away from enemy sigma")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaHighGravDebuff != null;
		Is True For Any(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20) == false;
	}

	actions
	{
	
		Event Player.SigmaHighGravDebuff = null;

		Value In Array(Event Player.CurrentGravities, 0) -= 400;
		Value In Array(Event Player.CurrentGravities, 1) -= 400;
		Value In Array(Event Player.CurrentSpeeds, 0) += 80;
		Value In Array(Event Player.CurrentSpeeds, 2) += 80;

		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));

	
	
	
	

	

	
	}
}



rule("Sigma zero grav buff fly up")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff == True;
		Is Button Held(Event Player, Button(Jump)) == True; 
	}

	actions
	{
		
		Start Accelerating(Event Player, Up, 10, 10, To Player, Direction Rate And Max Speed);
		
	}
}



rule("Sigma zero grav buff fly down")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff == True;
		Is Button Held(Event Player, Button(Crouch)) == True; 
	}

	actions
	{
		
		Start Accelerating(Event Player, Down, 10, 10, To Player, Direction Rate And Max Speed);
	
		
	}
}



rule("Sigma zero grav stop accelerating when not pressing jump or crouch")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff == True;
		Is Button Held(Event Player, Button(Jump)) == False;
		Is Button Held(Event Player, Button(Crouch)) == False; 
	}

	actions
	{
		
		Stop Accelerating(Event Player);
		
	}
}




rule("Sigma description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sigma;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Create a zone around you that lets you and your allies fly in zero gravity. {0}", Custom String("
		Press crouch to fly down and jump to fly up. Enemies within the zone are slowed down and gain increased gravity."));

	}
}





rule("Sojourn when using ultimate and firing railgun leave behind damaging beams.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Sojourn;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
        Is Firing Secondary(Event Player) == true;
	
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
	
	

		Create Beam Effect(All Players(All Teams), Bad Beam, Eye Position(Event Player), Event Player.SojournLastRay, Team Of(Event Player), none);

        Skip if(Event Player.SojournRayArray != null, 1);
        Event Player.SojournRayArray = Array(Event Player.SojournLastRay);

        Skip if(Array Contains(Event Player.SojournRayArray, Event Player.SojournLastRay), 1);
        Modify Player Variable(Event Player, SojournRayArray, Append To Array, Event Player.SojournLastRay);

        Skip if(Event Player.SojournBeamArray != null, 1);
        Event Player.SojournBeamArray = Array(Last Created Entity);

        Skip if(Array Contains(Event Player.SojournBeamArray, Last Created Entity), 1);
        Modify Player Variable(Event Player, SojournBeamArray, Append To Array, Last Created Entity);

        Skip if(Event Player.SojournEyePosArray != null, 1);
        Event Player.SojournEyePosArray = Array(Event Player.SojournLastEyePos);

        Skip if(Array Contains(Event Player.SojournEyePosArray, Event Player.SojournLastEyePos), 1);
        Modify Player Variable(Event Player, SojournEyePosArray, Append To Array, Event Player.SojournLastEyePos);

	}
}




rule("Sojourn update aim raycast")
{
   
    event
	{
		Ongoing - Each Player;
		All;
		Sojourn;
	}

    conditions
	{
        Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

    actions
    {
        Wait(0.016, Ignore Condition);

       
        Event Player.SojournLastRay = Update Every Frame(Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, null, null, false));
        Event Player.SojournLastEyePos = Update Every Frame(Eye Position(Event Player));

        Loop If Condition Is True;
        

    }
}



rule("Sojourn cause damage to enemies when they hit beams.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Sojourn;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
        Event Player.SojournBeamArray != null;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
        Wait(0.1, Abort When False);

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.SojournEyePosArray), 1);

       
       

        Event Player.SojournDamageRay = Ray Cast Hit Player(Value In Array(Event Player.SojournEyePosArray, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.SojournRayArray, Event Player.ForLoopIndexPlayer), All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

       
        Skip if(Event Player.SojournDamageRay != null, 1);
        Event Player.SojournDamageRay = Ray Cast Hit Player(Value In Array(Event Player.SojournRayArray, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.SojournEyePosArray, Event Player.ForLoopIndexPlayer), All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        Damage(Event Player.SojournDamageRay, Event Player, 50);

	

       

		End;

        Loop If Condition Is True;
	}
}



rule("Sojourn remove beams when not using ultimate.")
{
    event
	{
		Ongoing - Each Player;
		All;
		Sojourn;
	}

    conditions
	{
        Is Using Ultimate(Event Player) != True;
	}

    actions
    {
        Call Subroutine(ResetSojourn);
        

    }
}



rule("Sojourn reset values and destroy beams.")
{
    event
	{
		Subroutine;
		ResetSojourn;
	}

    actions
    {
        Skip if(Event Player.SojournBeamArray == null, 1);
        Destroy Effect(Event Player.SojournBeamArray);

        Event Player.SojournBeamArray = 0;
        Event Player.SojournDamageRay = 0;
        Event Player.SojournEyePosArray = 0;
        Event Player.SojournLastEyePos = 0;
        Event Player.SojournLastRay = 0;
        Event Player.SojournRayArray = 0;
        
	
    }
}





rule("Sojourn description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sojourn;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Firing the rail gun during her ultimate leaves behind trails that damage enemies.");

	}
}





rule("soldier 76 initialize kill streaks and streak counting")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables == Null;
	}

	actions
	{
		Event Player.Soldier76Variables = Array(0);
		Set Ultimate Ability Enabled(Event Player, False);

		Create Hud Text(Event Player, String("{0} {1}", Custom String("Kill Streak: "), First Of(Event Player.Soldier76Variables)), null, null, Left, 0, Color(Blue), Color(Blue), Color(Blue), Visible To and String, Default Visibility);
		Value In Array(Event Player.Soldier76Variables, 1) = Last Text Id;

	



		Event Player.SoldierAllKillStreaks = Array(Array(3, Custom String("UAV Recon")), Array(5, Custom String("Care Package")), Array(8, Custom String("Tactical Visor")), Array(20, Custom String("Tactical Nuke")), Array(13, Custom String("AC-130")));

	
		Event Player.Soldier76KillStreaksEquipped = Array(Value In Array(Event Player.SoldierAllKillStreaks, 0), Value In Array(Event Player.SoldierAllKillStreaks, 1), Value In Array(Event Player.SoldierAllKillStreaks, 2), Value In Array(Event Player.SoldierAllKillStreaks, 4), Value In Array(Event Player.SoldierAllKillStreaks, 3));

		Event Player.SoldierKillStreakTexts = Empty Array;

	
		Event Player.Soldier76KillStreaksActive = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksEquipped), 1);
		Modify Player Variable(Event Player, Soldier76KillStreaksActive, Append To Array, false);

		End;

	


	

		

	}
}



rule("soldier 76 increase streak from kills and create hud texts for streak abilities")
{
	event
	{
		Player Earned Elimination;
		All;
		Soldier: 76;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Alive(Event Player) == True;
	}

	actions
	{
		Value In Array(Event Player.Soldier76Variables, 0) += 1;


		If(Is True For Any(Event Player.Soldier76KillStreaksEquipped, Value In Array(Current Array Element, 0) == Value In Array(Event Player.Soldier76Variables, 0)));


	
		Event Player.LocalVariable = Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, First Of(Filtered Array(Event Player.Soldier76KillStreaksEquipped, Value In Array(Current Array Element, 0) == Value In Array(Event Player.Soldier76Variables, 0)))) / 2;

		Value In Array(Event Player.Soldier76KillStreaksActive, Event Player.LocalVariable) = True;

		Big Message(Event Player, String("{0} {1}", Last Of(Value In Array(Event Player.Soldier76KillStreaksEquipped, Event Player.LocalVariable)), Custom String(" ready to deploy!")));
	

		Create Hud Text(Event Player, String("{0} {1}", Last Of(Value In Array(Event Player.Soldier76KillStreaksEquipped, Event Player.LocalVariable)), Custom String(" ready to deploy!")), null, null, Left, 0, Color(Blue), Color(Blue), Color(Blue), Visible To, Default Visibility);

	
		
		Value In Array(Event Player.SoldierKillStreakTexts, Event Player.LocalVariable) = Last Text Id;

		Wait(0.1, Ignore Condition);

		Event Player.LocalVariable = Null;
		End;

	}
}



rule("soldier 76 reset streak and abilities when dead")
{
	event
	{
		Player Died;
		All;
		Soldier: 76;
	}

	conditions
	{
		Event Player.Soldier76Variables != Null;
	
		Is Dummy Bot(Event Player) == false;
		Event Player.ExtraLife != True;
	}

	actions
	{
		Value In Array(Event Player.Soldier76Variables, 0) = 0;

		Event Player.Soldier76KillStreaksActive = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksEquipped), 1);
		Modify Player Variable(Event Player, Soldier76KillStreaksActive, Append To Array, false);
		End;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.SoldierKillStreakTexts), 1);
		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Event Player.ForLoopIndexPlayer));
		End;

		Event Player.SoldierKillStreakTexts = Empty Array;

	

	
	
	}
}



rule("soldier 76 reset everything with soldier. Really only used when Soldier switches character.")
{
	event
	{
		Subroutine;
		ResetSoldier;
	}

	actions
	{
	

		

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.SoldierKillStreakTexts), 1);
		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Event Player.ForLoopIndexPlayer));
		End;


		Destroy Hud Text(Value In Array(Event Player.Soldier76Variables, 1));

	

		If(Value In Array(Event Player.Soldier76Variables, 2) != Null);
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Value In Array(Event Player.Soldier76Variables, 2)), 1);
		Destroy Icon(Value In Array(Value In Array(Event Player.Soldier76Variables, 2), Event Player.ForLoopIndexPlayer));
		End;
		
		Value In Array(Event Player.Soldier76Variables, 2) = Null;

		End;

	
		If(Value In Array(Event Player.Soldier76Variables, 5) != Null);
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 5));
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 4));
		Event Player.Soldier76CarepackLocation = null;
		End;

	
		If(Value In Array(Event Player.Soldier76Variables, 6) != Null);

		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.Soldier76Variables, 7)));
		

		Stop Camera(Event Player);

	
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);

	
		Clear Status(Event Player, rooted);

		Value In Array(Event Player.Soldier76Variables, 6) = Null;
		Value In Array(Event Player.Soldier76Variables, 7) = Null;

		End;

		Set Ultimate Ability Enabled(Event Player, True);
		

	
		Event Player.Soldier76Variables = Null;
		Event Player.SoldierAllKillStreaks = Null;
		Event Player.Soldier76KillStreaksActive = Null;
		Event Player.SoldierKillStreakTexts = Null;
		Event Player.Soldier76KillStreaksEquipped = Null;
		
		
	}
}



rule("soldier 76 UAV")
{

    
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Event Player.Soldier76Variables != Null;
	
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2) == True;
		Is Alive(Event Player) == True;
		
	
	
	}

	actions
	{


		Value In Array(Event Player.Soldier76Variables, 2) = Empty Array;

	
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(All Players(Opposite Team Of(Team Of(Event Player)))), 1);
		Create Icon(All Players(Team Of(Event Player)), Value In Array(All Players(Opposite Team Of(Team Of(Event Player))), Event Player.ForLoopIndexPlayer), Skull, Visible To, Color(Red), false);
		Value In Array(Event Player.Soldier76Variables, 2) = Append To Array(Value In Array(Event Player.Soldier76Variables, 2), Last Created Entity);
		End;

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2) = False;
		
		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2));

	

	

	

		Wait(30, Ignore Condition);

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Value In Array(Event Player.Soldier76Variables, 2)), 1);
		Destroy Icon(Value In Array(Value In Array(Event Player.Soldier76Variables, 2), Event Player.ForLoopIndexPlayer));
		End;
		
		Value In Array(Event Player.Soldier76Variables, 2) = Null;


	}
}



rule("soldier 76 care package")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;	
		Is Alive(Event Player) == True;
		
	
	
		

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2) == True;


	}

	actions
	{
	
	

		Create Effect(All Players(All Teams), Light Shaft, Color(White), Position Of(Event Player), 2, None);
		Value In Array(Event Player.Soldier76Variables, 3) = Last Created Entity;
		Event Player.Soldier76CarepackLocation = Event Player + Up*30;

		Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Event Player.Soldier76CarepackLocation, 1, Position And Radius);
		Value In Array(Event Player.Soldier76Variables, 4) = Last Created Entity;

		Value In Array(Event Player.Soldier76Variables, 5) = Position Of(Event Player);

		Chase Player Variable Over Time(Event Player, Soldier76CarepackLocation, Value In Array(Event Player.Soldier76Variables, 5), 15, None);

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2) = False;

		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2));


		Wait(15, Ignore Condition);
		Stop Chasing Player Variable(Event Player, Soldier76CarepackLocation);

	

		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 3));
		Value In Array(Event Player.Soldier76Variables, 3) = True;

		Create Effect(All Players(All Teams), Ring, Team Of(Event Player), Event Player.Soldier76CarepackLocation, 7, None);
		Value In Array(Event Player.Soldier76Variables, 5) = Last Created Entity;

		Wait(30, Ignore Condition);
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 5));
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 4));
		Value In Array(Event Player.Soldier76Variables, 3) = null;
		Value In Array(Event Player.Soldier76Variables, 5) = Null;
		Value In Array(Event Player.Soldier76Variables, 4) = null;
		Event Player.Soldier76CarepackLocation = null;

		

	
		
		

	}
}



rule("soldier 76 care package set cooldowns to 0")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Value In Array(Event Player.Soldier76Variables, 3) == True;
	

	



	}


	actions
	{
		Wait(0.5, Abort When False);

		Set Ability Cooldown(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Button(Ability 1), 0);
		Set Ability Cooldown(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Button(Ability 2), 0);
		Set Ability Cooldown(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Button(Secondary Fire), 0);
		Set Ability Cooldown(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Button(Primary Fire), 0);

		For Player Variable(Event Player, SoldierCarePackAmmoIndex, 0, Count Of(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces)), 1);
		
		If(Ammo(Value In Array(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Event Player.SoldierCarePackAmmoIndex), 0) == 0);
		Set Ammo(Value In Array(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Event Player.SoldierCarePackAmmoIndex), 0, Max Ammo(Value In Array(Players Within Radius(Event Player.Soldier76CarepackLocation, 7, Team Of(Event Player), Surfaces), Event Player.SoldierCarePackAmmoIndex), 0));

		End;
		End;

		Loop If Condition Is True;
		

	}
}



rule("soldier 76 tactical visor")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;	
		Is Alive(Event Player) == True;
		
	
	
		

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 2)) / 2) == True;


	}

	actions
	{
		Set Ultimate Ability Enabled(Event Player, True);

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 2)) / 2) = False;

		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 2)) / 2));

		Set Ultimate Charge(Event Player, 100);

		Press Button(Event Player, Button(Ultimate));

		Wait(0.1, Ignore Condition);

		Set Ultimate Ability Enabled(Event Player, False);


	}
}



rule("soldier 76 nuke")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Global.NukingPlayer == Null;
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Is Alive(Event Player) == True;
		
	
	


		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 3)) / 2) == True;

	



	}

	actions
	{
		Wait(0.1, Ignore Condition);

		Global.NukeTimer = 10;

		Create Hud Text(All Players(All Teams), String("{0} {1}", Icon String(Radioactive), Global.NukeTimer), null, null, Left, 0, Color(Yellow), Color(Yellow), Color(Yellow), Visible To And String, Default Visibility);

		Global.NukeText = Last Text Id;

		Global.NukingPlayer = Event Player;

		Value In Array(Global.NukingPlayer.Soldier76KillStreaksActive, Index Of Array Value(Global.NukingPlayer.Soldier76KillStreaksEquipped, Value In Array(Global.NukingPlayer.SoldierAllKillStreaks, 2))) = False;

		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2));

	}
}



rule("soldier 76 nuke timer with sound effect")
{

	event
	{
		Ongoing - Global;
		
	}

	conditions
	{
		
		Global.NukeText != Null;
		Global.NukeTimer >= 1;


	}

	actions
	{
		Wait(1, Abort When False);

		Global.NukeTimer -= 1;

		For Global Variable(ForLoopIndexGlobal, 0, Count Of(All Players(All Teams)), 1);

		Play Effect(Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), Debuff Impact Sound, Color(Blue), Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), 1000000);
		End;

		Loop If Condition Is True;

		Wait(1, Ignore Condition);

		For Global Variable(ForLoopIndexGlobal, 0, Count Of(All Players(All Teams)), 1);

		Play Effect(Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), Debuff Impact Sound, Color(Blue), Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), 1000000);
		End;

		Global.NukePosition = Position Of(Global.NukingPlayer) + Vector(X Component Of(Facing Direction Of(Global.NukingPlayer)) * 100, 0, Z Component Of(Facing Direction Of(Global.NukingPlayer)) * 100);

		Global.NukeRadius = 1;

		Set Slow Motion(50);

	
	

		Chase Global Variable Over Time(NukeRadius, 200, 4.5, None);

	


		

		Wait(4.5, Ignore Condition);



		

		Stop Chasing Global Variable(NukeRadius);

		Global.NukePosition = null;

		Global.NukeRadius = Null;

		Global.NukeTimer = null;

		Destroy Hud Text(Global.NukeText);

		Global.NukeText = Null;

		Global.NukingPlayer = Null;

		Set Slow Motion(100);


	

	}
}



rule("soldier 76 nuke play explosions")
{
	event
	{
		Ongoing - Global;
		
	}

	conditions
	{
		
		Global.NukeText != Null;
		Global.NukeRadius != Null;


	}

	actions
	{
		Wait(0.032, Abort When False);

		Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Global.NukePosition, Global.NukeRadius);


		For Global Variable(ForLoopIndexGlobal, 0, Count Of(All Players(All Teams)), 1);

		Play Effect(Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), Explosion Sound, Color(Blue), Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), 1000000);
		End;


		Loop If Condition Is True;


	}
}



rule("soldier 76 nuke kill players in radius of the explosion")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		
		Global.NukeText != Null;
		Global.NukeRadius != Null;
		Distance Between(Event Player, Global.NukePosition) < Global.NukeRadius;

	}

	actions
	{
		Set Respawn Max Time(Event Player, 100);

		Kill(Event Player, Global.NukingPlayer);


	}
}



rule("soldier 76 blind players in radius of the explosion")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		
		Global.NukeText != Null;
		Global.NukeRadius != Null;
		Distance Between(Event Player, Global.NukePosition) < Global.NukeRadius + 20;

	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Play Effect(Event Player, Good Explosion, Color(Yellow), EyePosition(Event Player), 10);
		

		Loop If Condition Is True;

		
	}
}




rule("soldier 76 AC-130")
{
   

	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Is Alive(Event Player) == True;
		
	
	


		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 4)) / 2) == True;

	



	}

	actions
	{
		

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 4)) / 2) = False;

		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 4)) / 2));

		Set Status(Event Player, null, Rooted, 30);
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Set Ability 1 Enabled(Event Player, False);
		Set Ability 2 Enabled(Event Player, False);

		Value In Array(Event Player.Soldier76Variables, 6) = Position Of(Event Player + Up * 80);


	
		
		
		If(Number of Players(Team Of(Event Player)) >= Number of Slots(Team Of(Event Player)));
		Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), -1, Value In Array(Event Player.Soldier76Variables, 6), Forward);
		Else If(Number of Players(Team Of(Event Player)) < Number of Slots(Team Of(Event Player)));
		For Player Variable(Event Player, ForLoopIndexPlayer, Number of Slots(Team Of(Event Player)), 11, 1);
		If(Players In Slot(Event Player.ForLoopIndexPlayer, Team Of(Event Player)) == Null);
		Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), Event Player.ForLoopIndexPlayer, Value In Array(Event Player.Soldier76Variables, 6), Forward);
		Break;
		End;
		End;
		End;
		
		Value In Array(Event Player.Soldier76Variables, 7) = Last Created Entity;

	
		Disable Movement Collision With Environment(Value In Array(Event Player.Soldier76Variables, 7), True);


		Start Camera(Event Player, Value In Array(Event Player.Soldier76Variables, 7) + Down, Value In Array(Event Player.Soldier76Variables, 7) + Down + Facing Direction Of(Event Player), 0);


		Wait(0.1, Ignore Condition);
		Set Gravity(Value In Array(Event Player.Soldier76Variables, 7), 0);
		Set Knockback Received(Value In Array(Event Player.Soldier76Variables, 7), 0);

		Start Scaling Player(Value In Array(Event Player.Soldier76Variables, 7), 5, false);

		Start Holding Button(Value In Array(Event Player.Soldier76Variables, 7), Button(Ability 1));

		Start Accelerating(Value In Array(Event Player.Soldier76Variables, 7), Facing Direction Of(Value In Array(Event Player.Soldier76Variables, 7)), 10, 10, To Player, DIRECTION RATE AND MAX SPEED);

		Wait Until(Is Dead(Value In Array(Event Player.Soldier76Variables, 7)) || Is Dead(Event Player), 30);
	
	
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.Soldier76Variables, 7)));
		

		Stop Camera(Event Player);

	
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);

	
		Clear Status(Event Player, rooted);

		Value In Array(Event Player.Soldier76Variables, 6) = Null;
		Value In Array(Event Player.Soldier76Variables, 7) = Null;
		


	}
}



rule("soldier 76 AC-130 move in a circle and stop falling")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;

		Is Alive(Event Player) == True;

		Value In Array(Event Player.Soldier76Variables, 6) != Null;

		

	

	



	}

	actions
	{
		Wait(0.1, Abort When False);

		If(Speed Of In Direction(Value In Array(Event Player.Soldier76Variables, 7), Down) > 0);

		Apply Impulse(Value In Array(Event Player.Soldier76Variables, 7), Up, 0.001, To Player, Cancel Contrary Motion);
		
		End;

	

		Set Facing(Value In Array(Event Player.Soldier76Variables, 7), Direction From Angles(Horizontal Facing Angle Of(Value In Array(Event Player.Soldier76Variables, 7)) + 1, Vertical Facing Angle Of(Value In Array(Event Player.Soldier76Variables, 7))), To World);


		Loop If Condition Is True;
		


	}
}



rule("soldier 76 AC-130 shoot bombs")
{

	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
	
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;

		Is Alive(Event Player) == True;

		Value In Array(Event Player.Soldier76Variables, 6) != Null;

		Is Button Held(Event Player, Button(Primary Fire)) == True;


	}

	actions
	{
		Play Effect(All Players(All Teams), Bad Explosion, Team Of(Event Player), Value In Array(Event Player.Soldier76Variables, 7) + Facing Direction Of(Event Player), 5);
		Play Effect(All Players(All Teams), Bastion Tank Cannon Explosion Sound, Team Of(Event Player), Value In Array(Event Player.Soldier76Variables, 7) + Facing Direction Of(Event Player), 100);

		Value In Array(Event Player.Soldier76Variables, 8) = Position Of(Value In Array(Event Player.Soldier76Variables, 7)) + Down + Facing Direction Of(Event Player);

		Create Projectile(Pharah Rocket, Event Player, Value In Array(Event Player.Soldier76Variables, 8), Value In Array(Event Player.Soldier76Variables, 7) + Down + Facing Direction Of(Event Player)*1000, To World, Damage, Opposite Team Of(Team Of(Event Player)), 500, 0.5, 5, Junkrat RIP Tire Explosion Effect, Ashe Dynamite Explosion Sound, 0.1, 100, 10, 10, 0, 0);

	
		


	


		Value In Array(Event Player.Soldier76Variables, 11) = 5;

		Wait(Value In Array(Event Player.Soldier76Variables, 11), Ignore Condition);
	}
}




rule("Soldier description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("You get killstreaks instead of an ultimate. 3 eliminations for UAV. 5 for care package. {0}", Custom String("
		8 for tactical visor. 13 for Ac-130. 20 for nuke. {0}", Custom String("
		UAV reveals enemies. Care package resets cooldowns and reloads ammo. {0}", Custom String("
		Tactical visor is just his regular ult. AC-130 lets you shoot shit from the sky. Nuke is a nuke."))));

	}
}





rule("Sombra activate ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		Sombra;
	}

	conditions
	{
	
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
		Is Dummy Bot(Event Player) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
	
	
		All Players(Opposite Team Of(Team Of(Event Player))).EnemySombra = Event Player;
	
		Create HUD Text(Event Player, Event Player.P, Null, Null, Top, 1, Color(Purple), Color(White), Color(White), Visible To and String,
			Default Visibility);
		Event Player.UltDescription = Last Text ID;
		Create Effect(All Players(All Teams), Bad Aura, Color(Purple), Event Player, 1, Visible To Position and Radius);
		Event Player.UltEffect = Last Created Entity;
		Event Player.P = 20;
		Chase Player Variable At Rate(Event Player, P, 0, 1, Destination and Rate);
	
	
		Wait(Event Player.P, Ignore Condition);
		Call Subroutine(ResetSombra);
	}
}



rule("Reset Ult modifications on Sombra.")
{
    event
    {
        Subroutine;
        ResetSombra;
    }

    actions
    {
        
		Event Player.P = Null;
	
		Destroy HUD Text(Event Player.UltDescription);
        
		
		Call Subroutine(StopUsingCustomUlt);
    }
}



rule("Sombra: If player has virus, create virus effect, text and set variables, disable after 10 seconds")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Virus == True;
	}

	actions
	{
	
		
		Create HUD Text(Event Player, Custom String(
			"You've been infected by a computer virus. You take damage over time. Spreads to nearby teammates."), Null, Null, Right, 0,
			Color(Purple), Color(Purple), Color(White), Visible To and String, Default Visibility);
		Event Player.VirusText = Last Text ID;
		Start Damage Over Time(Event Player, Null, 10, 30);
	
		Event Player.VirusEffects = Empty Array;
		Create Effect(All Players(All Teams), Sombra Hacked Sound, Team Of(Event Player), Event Player, 100, Visible To Position and Radius);
		Modify Player Variable(Event Player, VirusEffects, Append To Array, Last Created Entity);
	
		Create Effect(All Players(All Teams), Cloud, Color(Purple), Event Player, 1, Visible To Position and Radius);
		Modify Player Variable(Event Player, VirusEffects, Append To Array, Last Created Entity);
		Wait(10, Abort When False);
		Destroy Effect(Event Player.VirusEffects);
		Event Player.VirusEffects = Null;
		Destroy HUD Text(Event Player.VirusText);
		Event Player.VirusText = Null;
		
	
		Event Player.Virus = Null;
	}
}



rule("Sombra: If player has virus, spread to nearby players")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Virus == True;
		Is In Spawn Room(Event Player) == False;
	}

	actions
	{
		Wait(1, Ignore Condition);
		Remove From Array(Players Within Radius(Event Player, 7, Team Of(Event Player), Surfaces), Event Player).Virus = True;
		Loop If Condition Is True;
	}
}



rule("Sombra spread virus to nearby enemies")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sombra;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Is Using Ability 1(Event Player) == False;
		disabled Distance Between(Event Player, Closest Player To(Event Player, Opposite Team Of(Team Of(Event Player)))) <= 5;
	}

	actions
	{
		Wait(1, Ignore Condition);
	
	
		Players Within Radius(Event Player, 10, Opposite Team Of(Team Of(Event Player)), Surfaces).Virus = True;
		Loop If Condition Is True;
	}
}



rule("Sombra: Disable virus if player has spawned and had virus before death")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Virus == True;
		Event Player.HasDiedWithVirus == True;
		Is Alive(Event Player) == True;
	}

	actions
	{
		Destroy Effect(Event Player.VirusEffects);
		Event Player.VirusEffects = Null;
		Stop All Damage Over Time(Event Player);
		Destroy HUD Text(Event Player.VirusText);
		Event Player.VirusText = Null;
		Event Player.HasDiedWithVirus = Null;
		Set Healing Received(Event Player, 100);
		Event Player.Virus = Null;
	}
}



rule("Sombra: Check if player died with virus")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Virus == True;
		Is Dead(Event Player) == True;
	}

	actions
	{
		
		Event Player.HasDiedWithVirus = True;
	}
}





rule("Sombra description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sombra;
	}

	conditions
	{
	
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Sombra spreads a computer virus to nearby enemies that does damage over time. {0}", Custom String("
		The virus will spread from infected enemies to other enemies and also will stay in corpses until they respawn. {0}",
		Custom String("Virus can't be spread while you are cloaked."))
		);

	}
}





rule("Symmetra ultimate activate and deactivate")
{
   
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == Null;
		Hero Of(Event Player) == Hero(Symmetra);
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
	
	
		Event Player.UltTimer = 20;
		Chase Player Variable At Rate(Event Player, UltTimer, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("Use Ultimate Ability"), Event Player.UltTimer, Null, Top, 3, Color(Blue), Color(White), Color(
			White), Visible To and String, Default Visibility);
		Event Player.UltTimerText = Last Text ID;
	
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Wait(Event Player.UltTimer, Ignore Condition);
		If(Team Of(Event Player) == Team 1);
		Call Subroutine(ResetSymmetraTeam1);
		Else;
		Call Subroutine(ResetSymmetraTeam2);
		End;
		
	}
}



rule("Symmetra reset")
{
    
	event
	{
		Subroutine;
		ResetSymmetraTeam1;
	}

	actions
	{
		
		Destroy Effect(Global.R);
		Destroy Effect(Global.S);
		Global.P = Null;
		Global.Q = Null;
		
		Set Ultimate Charge(Event Player, 0);
		Stop Chasing Player Variable(Event Player, UltTimer);
		Event Player.UltTimer = Null;
		Destroy HUD Text(Event Player.UltTimerText);
		Event Player.UltTimerText = Null;
		
		
		Call Subroutine(StopUsingCustomUlt);
	}
}



rule("Symmetra reset")
{
    
	event
	{
		Subroutine;
		ResetSymmetraTeam2;
	}

	actions
	{
		
		
		Destroy Effect(Global.GreenPortal);
		Destroy Effect(Global.W);
		Global.YellowPortalRaycast = Null;
		Global.GreenPortalRaycast = Null;
		Set Ultimate Charge(Event Player, 0);
		Stop Chasing Player Variable(Event Player, UltTimer);
		Event Player.UltTimer = Null;
		Destroy HUD Text(Event Player.UltTimerText);
		Event Player.UltTimerText = Null;
		
		Call Subroutine(StopUsingCustomUlt);
	}
}



rule("Symmetra team 1 create blue portal")
{

	event
	{
		Ongoing - Each Player;
		Team 1;
		Symmetra;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.R == Null, 2);
		Destroy Effect(Global.R);
		Global.R = 0;
	
		Global.P = Ray Cast Hit Position(Event Player, Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, All Players(All Teams), Event Player, True);
	
		Global.SymmetraBluePNormal = Ray Cast Hit Normal(Event Player, Global.P, All Players(All Teams), Event Player, True);
	
		Log To Inspector(Global.SymmetraBluePNormal);
		Log To Inspector(Direction Towards(Global.P, Eye Position(Event Player)));
		If(Angle Between Vectors(Global.SymmetraBluePNormal,Direction Towards(Global.P, Eye Position(Event Player))) >= 0.5);
		
	
	
		Play Effect(All Players(All Teams), Good Explosion, Color(Blue), Global.P, 3);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Global.P, 20);
		Wait(0.200, Ignore Condition);
		Create Effect(All Players(All Teams), Ring, Color(Blue), Global.P, 2, Visible To Position and Radius);
		disabled Event Player.UsingCustomUlt += 1;
		Global.R = Last Created Entity;
		Wait(0.500, Ignore Condition);
		
		Else;
		Global.P = Null;
		Global.SymmetraBluePNormal = Null;
		End;
	}
}



rule("Symmetra team 1 create red portal")
{
	event
	{
		Ongoing - Each Player;
		Team 1;
		Symmetra;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
	
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.S == Null, 2);
		Destroy Effect(Global.S);
		Global.S = 0;
	
		
		
	
		Global.Q = Ray Cast Hit Position(Event Player, Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, All Players(All Teams), Event Player, True);
		
		
		Global.SymmetraRedPNormal = Ray Cast Hit Normal(Event Player, Global.Q, All Players(All Teams), Event Player, True);
		Log To Inspector(Global.SymmetraRedPNormal);
		Log To Inspector(Direction Towards(Global.Q, Eye Position(Event Player)));
		
		Abort If(Angle Between Vectors(Global.SymmetraRedPNormal,Direction Towards(Global.Q, Eye Position(Event Player))) < 0.5);
		
	
	
		Play Effect(All Players(All Teams), Good Explosion, Color(Red), Global.Q, 3);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Global.Q, 20);
		Wait(0.200, Ignore Condition);
		Create Effect(All Players(All Teams), Ring, Color(Red), Global.Q, 2, Visible To Position and Radius);
		disabled Event Player.UsingCustomUlt += 1;
		Global.S = Last Created Entity;
		Wait(0.500, Ignore Condition);
	}
}



rule("Symmetra team 2 create yellow portal")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		Symmetra;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.W == Null, 2);
		Destroy Effect(Global.W);
		Global.W = 0;
		Global.YellowPortalRaycast = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + -17, Z Component Of(Facing Direction Of(Event Player))
			* 1000), All Players(All Teams), Event Player, True);
		Global.YellowPortalRaycast -= Facing Direction Of(Event Player);
		Global.SymmetraYellowPNormal = Ray Cast Hit Normal(Event Player, Global.YellowPortalRaycast, All Players(All Teams), Event Player, True);
		Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Global.YellowPortalRaycast, 3);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Global.YellowPortalRaycast, 20);
		Wait(0.200, Ignore Condition);
		Create Effect(All Players(All Teams), Ring, Color(Yellow), Global.YellowPortalRaycast, 2, Visible To Position and Radius);
		disabled Event Player.UsingCustomUlt += 1;
		Global.W = Last Created Entity;
		Wait(0.500, Ignore Condition);
	}
}



rule("Symmetra team 2 create green portal")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		Symmetra;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
	
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.GreenPortal == Null, 2);
		Destroy Effect(Global.GreenPortal);
		Global.GreenPortal = 0;
		Global.GreenPortalRaycast = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + -17, Z Component Of(Facing Direction Of(Event Player))
			* 1000), All Players(All Teams), Event Player, True);
		Global.GreenPortalRaycast -= Facing Direction Of(Event Player);
		Global.SymmetraGreenPNormal = Ray Cast Hit Normal(Event Player, Global.GreenPortalRaycast, All Players(All Teams), Event Player, True);
		Play Effect(All Players(All Teams), Good Explosion, Color(Green), Global.GreenPortalRaycast, 3);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Global.GreenPortalRaycast, 20);
		Wait(0.200, Ignore Condition);
		Create Effect(All Players(All Teams), Ring, Color(Green), Global.GreenPortalRaycast, 2, Visible To Position and Radius);
		disabled Event Player.UsingCustomUlt += 1;
		Global.GreenPortal = Last Created Entity;
		Wait(0.500, Ignore Condition);
	}
}



rule("Symmetra teleport player when near team 1 blue portal")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Distance Between(Global.P, Event Player) < 2.2;
		Event Player.K != True;
		Global.P != Null;
		Global.Q != Null;
		disabled Is Button Held(Event Player, Button(Interact)) == True;
		Global.R != Null;
		Global.S != Null;
	}

	actions
	{
		Event Player.L = True;
	
	
	
	
		Event Player.InPortalSpeed = Speed Of(Event Player);
		Teleport(Event Player, Global.Q);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(0.01, Ignore Condition);

	
	
	

	
	
	
		Apply Impulse(Event Player, Global.SymmetraRedPNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		Wait(1, Restart When True);
		Event Player.L = Null;
	}
}



rule("Symmetra teleport player when near team 1 red portal")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Distance Between(Global.Q, Event Player) < 2.2;
		Event Player.L != True;
		Global.Q != Null;
		Global.P != Null;
		disabled Is Button Held(Event Player, Button(Interact)) == True;
		Global.R != Null;
		Global.S != Null;
	}

	actions
	{
		Event Player.K = True;
	
	
		Event Player.InPortalSpeed = Speed Of(Event Player);
		Teleport(Event Player, Global.P);
		Wait(0.01, Ignore Condition);

	
	
		
	
		Apply Impulse(Event Player, Global.SymmetraBluePNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(1, Restart When True);
		Event Player.K = Null;
	}
}





rule("Symmetra teleport player when near team 2 yellow portal")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Distance Between(Global.YellowPortalRaycast, Event Player) < 2.2;
		Event Player.K != True;
		Global.GreenPortalRaycast != Null;
		Global.YellowPortalRaycast != Null;
		disabled Is Button Held(Event Player, Button(Interact)) == True;
		Global.GreenPortal != Null;
		Global.W != Null;
	}

	actions
	{
		Event Player.L = True;
	
	
		Event Player.InPortalSpeed = Speed Of(Event Player);

		Teleport(Event Player, Global.GreenPortalRaycast);
	
		Wait(0.01, Ignore Condition);
	
	
		Apply Impulse(Event Player, Global.SymmetraGreenPNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(1, Restart When True);
		Event Player.L = Null;
	}
}



rule("Symmetra teleport player when near team 2 green portal")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Distance Between(Global.GreenPortalRaycast, Event Player) < 2.2;
		Event Player.L != True;
		disabled Is Button Held(Event Player, Button(Interact)) == True;
		Global.GreenPortalRaycast != Null;
		Global.YellowPortalRaycast != Null;
		Global.GreenPortal != Null;
		Global.W != Null;
	}

	actions
	{
		Event Player.K = True;
		Event Player.InPortalSpeed = Speed Of(Event Player);
		Teleport(Event Player, Global.YellowPortalRaycast);
		Wait(0.01, Ignore Condition);
	
	
		Apply Impulse(Event Player, Global.SymmetraYellowPNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(1, Restart When True);
		Event Player.K = Null;
	}
}





rule("Symmetra description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Symmetra;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Portal gun. Use primary fire and secondary fire to spawn portals.");

	}
}





rule("torb: spawn torb turret")
{

	event
	{
		Ongoing - Each Player;
		All;
		TorbjöRn;
	}

	conditions
	{
	
		Event Player.CustomUltReadyToUse == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
		Is Dummy Bot(Event Player) == false;
		(Event Player.TorbTurret == null || Is Button Held(Event Player, Button(Crouch)) == True) == true;
		Is Alive(Event Player) == True;
		
	}

	actions
	{

		Call Subroutine(UseCustomUlt);
	
	
		
		If(Number of Players(Team Of(Event Player)) >= Number of Slots(Team Of(Event Player)));
		Create Dummy Bot(Hero(Torbjörn), Team Of(Event Player), -1, Event Player + Facing Direction Of(Event Player), Facing Direction Of(Event Player));
		
		Else If(Number of Players(Team Of(Event Player)) < Number of Slots(Team Of(Event Player)));
		For Player Variable(Event Player, ForLoopIndexPlayer, Number of Slots(Team Of(Event Player)), 11, 1);
		If(Players In Slot(Event Player.ForLoopIndexPlayer, Team Of(Event Player)) == Null);
		Create Dummy Bot(Hero(Torbjörn), Team Of(Event Player), Event Player.ForLoopIndexPlayer, Event Player + Facing Direction Of(Event Player), Facing Direction Of(Event Player));
		Break;
		End;
		End;
		End;
		Event Player.TorbTurret = Last Created Entity;
		
	
	
		
	
		Wait(0.016, Ignore Condition);
		
		
		Event Player.TorbTurret.CurrentGravities = Array(1000, 0);
		Event Player.TorbTurret.CurrentSpeeds = Array(100, 100, 1000);
		
		
		Set Projectile Gravity(Event Player.TorbTurret, Value In Array(Event Player.TorbTurret.CurrentGravities, 1));
		Set Projectile Speed(Event Player.TorbTurret, Value In Array(Event Player.TorbTurret.CurrentSpeeds, 2));
	
		Set Max Health(Event Player.TorbTurret, 500);
		Set Gravity(Event Player.TorbTurret, Value In Array(Event Player.TorbTurret.CurrentGravities, 0));
		Set Knockback Received(Event Player.TorbTurret, 0);
		Event Player.TorbTurret.TorbTurretLevel = 1;
		Wait(0.5, Ignore Condition);
		
		Create In-World Text(All Players(All Teams), Custom String("Turretbjörn Lvl 1"), Event Player.TorbTurret + Up*2, 1, Clip Against Surfaces, Visible to and String, Team Of(Event Player), Default Visibility);
		Event Player.TorbTurret.TorbTurretLevelText = Last Text Id;
	
		Call Subroutine(StopUsingCustomUlt);
	
		
	
		Wait Until(Is Dead(Event Player.TorbTurret) == true || (Event Player.CustomUltReadyToUse == True && Is Button Held(Event Player, Button(Ultimate)) == True && Event Player.UsingCustomUlt == Null && Has Status(Event Player, Hacked) == False && Hero Of(Event Player) == Hero(Torbjörn) && (Event Player.TorbTurret == null || Is Button Held(Event Player, Button(Crouch)) == True) == true), 10000);
		Call Subroutine(ResetTorb);
		
	
		Loop If Condition Is True;
	}
}




rule("torb: reset torb")
{
	event
	{
		Subroutine;
		ResetTorb;
	}

	actions
	{
		Destroy In-World Text(Event Player.TorbTurret.TorbTurretLevelText);
		Event Player.TorbTurret.TorbTurretLevelText = Null;
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Event Player.TorbTurret));

		Event Player.TorbTurret = Null;
		
	}
}




rule("torb: overload turret to level 2")
{

   
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Torbjörn);
		Event Player.CustomUltReadyToUse == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
		Event Player.TorbTurret != Null;
	
		Is Dummy Bot(Event Player) == false;
		Event Player.TorbTurret.TorbTurretLevel == 1;
		Is Button Held(Event Player, Button(Crouch)) != True;
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
		Event Player.TorbTurret.TorbTurretLevel = 2;
		Press Button(Event Player.TorbTurret, Button(Ability 2));
		Set Ability Cooldown(Event Player.TorbTurret, Button(Ability 2), 0);
		Destroy In-World Text(Event Player.TorbTurret.TorbTurretLevelText);
		Create In-World Text(All Players(All Teams), Custom String("Turretbjörn Lvl 2"), Event Player.TorbTurret + Up*2, 1, Clip Against Surfaces, Visible to and String, Team Of(Event Player), Default Visibility);
		Event Player.TorbTurret.TorbTurretLevelText = Last Text Id;
		Wait(1, Ignore Condition);
		Call Subroutine(StopUsingCustomUlt);

	}
}



rule("torb: level 3 turret")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Torbjörn);
		Event Player.CustomUltReadyToUse == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
		Event Player.TorbTurret != Null;
	
		Event Player.TorbTurret.TorbTurretLevel == 2;
		Is Button Held(Event Player, Button(Crouch)) != True;

	}

	actions
	{
		Call Subroutine(UseCustomUlt);
		Event Player.TorbTurret.TorbTurretLevel = 3;
		Set Ultimate Charge(Event Player.TorbTurret, 100);
		Press Button(Event Player.TorbTurret, Button(Ultimate));
		Destroy In-World Text(Event Player.TorbTurret.TorbTurretLevelText);
		Create In-World Text(All Players(All Teams), Custom String("Turretbjörn Lvl 3"), Event Player.TorbTurret + Up*2, 1, Clip Against Surfaces, Visible to and String, Team Of(Event Player), Default Visibility);
		Event Player.TorbTurret.TorbTurretLevelText = Last Text Id;
		Wait(1, Ignore Condition);
		Call Subroutine(StopUsingCustomUlt);

	}
}



rule("torb: repeat abilities while at level 2 or 3 and reload gun automatically")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Torbjörn);
	
		Event Player.TorbTurret != Null;
		Event Player.TorbTurret.TorbTurretLevel >= 2;
	}

	actions
	{
		Wait(1, Abort When False);
		Press Button(Event Player.TorbTurret, Button(Ability 2));
		Set Ability Cooldown(Event Player.TorbTurret, Button(Ability 2), 0);
		Set Ammo(Event Player.TorbTurret, 0, 45);

		If(Event Player.TorbTurret.TorbTurretLevel >= 3);
		Set Ultimate Charge(Event Player.TorbTurret, 100);
		Press Button(Event Player.TorbTurret, Button(Ultimate));
		End;

		Loop If Condition Is True;

	}
}



rule("torb: torb turret, fire at enemies")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.TorbTurret != Null;
		Filtered Array(All Living Players(Opposite Team Of(Team Of(Event Player.TorbTurret))), Is In Line Of Sight(Event Player.TorbTurret, Current Array Element, BARRIERS DO NOT BLOCK LOS) == true && Distance Between(Event Player.TorbTurret, Current Array Element) < 40) != Empty Array;
	}

	actions
	{
		Wait(0.1, Abort When False);

		Event Player.TorbCurrentTarget = Value In Array(Sorted Array(Filtered Array(All Living Players(Opposite Team Of(Team Of(Event Player.TorbTurret))), Is In Line Of Sight(Event Player.TorbTurret, Current Array Element, BARRIERS DO NOT BLOCK LOS) == true && Distance Between(Event Player.TorbTurret, Current Array Element) < 40 && Is Alive(Current Array Element) == true && Has Spawned(Current Array Element) == true), Distance Between(Event Player, Current Array Element)), 0);

		Start Facing(Event Player.TorbTurret, Update Every Frame(Direction Towards(Eye Position(Event Player.TorbTurret), Event Player.TorbCurrentTarget + Up*0.7)), 1000, To World, DIRECTION AND TURN RATE);
		
		If(Distance Between(Event Player.TorbCurrentTarget, Event Player.TorbTurret) > 7);
		Press Button(Event Player.TorbTurret, Button(Primary Fire));
		Else If(Distance Between(Event Player.TorbCurrentTarget, Event Player.TorbTurret) < 7 && Distance Between(Event Player.TorbCurrentTarget, Event Player.TorbTurret) != 0 && Is Using Ultimate(Event Player.TorbTurret) == false);
		Press Button(Event Player.TorbTurret, Button(Secondary Fire));
		End;
		Loop If Condition Is True;
	}
}



rule("torb: torb turret, heal from hammer")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.TorbTurret != Null;
		Weapon(Event Player) == 2;
		Is Firing Primary(Event Player) == True;
		Is In View Angle(Event Player, Event Player.TorbTurret, 30) == True;
		Distance Between(Event Player, Event Player.TorbTurret) < 2.5;
	}

	actions
	{
		Heal(Event Player.TorbTurret, Event Player, 50);
		Play Effect(Event Player, Buff Impact Sound, Color(Yellow), Eye Position(Event Player), 100);
	}
}





rule("Torb description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Torbjörn;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Spawn a 'turret'. Heal turret with hammer and ult again to upgrade up to level 3. {0}", Custom String("
		Press crouch while ulting to place the turret into a new spot, this resets the turret back to level 1.", Null, Null, Null));

	}
}





rule("Activate Tracer's super speed ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		Tracer;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Create Effect(All Players(All Teams), Energy Sound, Color(White), Event Player, 200, Visible To Position and Radius);
		Event Player.UsingCustomUlt = True;
		Start Forcing Throttle(Event Player, 1, 1, 0, 0, 0, 1);
		Set Slow Motion(1);
	
		
		Wait(0.15,Ignore Condition);
		
		Value In Array(Event Player.CurrentSpeeds, 0) += 4900;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Wait Until(Is Dead(Event Player), 0.5);
		Call Subroutine(ResetTracer);
	}
}



rule("Tracer reset")
{
	event
	{
		Subroutine;
		ResetTracer;
	}

	actions
	{
		Value In Array(Event Player.CurrentSpeeds, 0) -= 4900;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Forcing Throttle(Event Player);
		Event Player.UsingCustomUlt = False;
		Destroy Effect(Last Created Entity);
		Set Slow Motion(100);
		
	}
}



rule("Tracer play effects while ult is active")
{
	event
	{
		Ongoing - Each Player;
		All;
		Tracer;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Tracer);
		Event Player.UsingCustomUlt == True;
		Event Player.CustomUltReadyToUse == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
	
	
		Play Effect(All Players(All Teams), Good Explosion, Team Of(Event Player), Position Of(Event Player) + Backward, 1);
		Loop If Condition Is True;
	}
}



rule("Tracer damage players when running at them")
{
	event
	{
		Ongoing - Each Player;
		All;
		Tracer;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Tracer);
		Event Player.UsingCustomUlt == True;
		Event Player.CustomUltReadyToUse == True;
		Filtered Array(Players Within Radius(Update Every Frame(Eye Position(Event Player)), 1.8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Is Alive(Current Array Element) == True)  != Empty Array;
	
	}

	actions
	{
		Damage(Filtered Array(Players Within Radius(Update Every Frame(Eye Position(Event Player)), 1.8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Is Alive(Current Array Element) == True), Event Player, 500);
		
	}
}



rule("Tracer description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Tracer;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Set slow motion and briefly move forward at super speed. Enemies you collide with take 500 damage.");

	}
}





rule("Widowmaker fire through wall")
{
   
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
	
		Is Using Ultimate(Event Player) == True;
       
       
        Is Firing Primary(Event Player) == true;
       
        Event Player.WidowZoomedIn == true;
       
       
        Is In Line Of Sight(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted), Barriers Do Not Block LOS) != true;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{

       
       

        

        Event Player.WidowRayCastForward = Ray Cast Hit Player(Event Player.WidowRayCastStartPos, Event Player.WidowRayCastEndPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);
        Event Player.WidowRayCastBackward = Ray Cast Hit Player(Event Player.WidowRayCastEndPos, Event Player.WidowRayCastStartPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        Event Player.WidowRayCastHeadForward = Ray Cast Hit Position(Event Player.WidowRayCastStartPos, Event Player.WidowRayCastEndPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);
        Event Player.WidowRayCastHeadBackward = Ray Cast Hit Position(Event Player.WidowRayCastEndPos, Event Player.WidowRayCastStartPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        
        

        Stop Chasing Player Variable(Event Player, WidowDamage);

       
       

       
       

       
        Create Beam Effect(Remove From Array(All Players(All Teams), Event Player), Good Beam, Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, Team Of(Event Player), None);
        Event Player.WidowFireBeam = Last Created Entity;

       

       

        

       
       

        Skip If(Distance Between(Event Player.WidowRayCastHeadForward, Update Every Frame(Eye Position(Event Player.WidowRayCastForward))) > 0.3 && Distance Between(Event Player.WidowRayCastHeadBackward, Update Every Frame(Eye Position(Event Player.WidowRayCastBackward))) > 0.3, 4);
       
        Skip If(Event Player.WidowRayCastForward == null && Event Player.WidowRayCastBackward == null, 3);
       
        Skip If((Event Player.WidowRayCastForward == null && Distance Between(Event Player.WidowRayCastHeadBackward, Update Every Frame(Eye Position(Event Player.WidowRayCastBackward))) > 0.3) || (Event Player.WidowRayCastBackward == null && Distance Between(Event Player.WidowRayCastHeadForward, Update Every Frame(Eye Position(Event Player.WidowRayCastForward))) > 0.3), 2);
       
        Event Player.WidowDamage *= 2.5;
        Play Effect(Event Player, Buff Impact Sound, Color(White), Event Player, 100);

        Skip If(Event Player.WidowRayCastForward == null, 1);
        Damage(Event Player.WidowRayCastForward, Event Player, Event Player.WidowDamage); 
       

        Skip If(Event Player.WidowRayCastBackward == null || Event Player.WidowRayCastForward != null, 1);
        Damage(Event Player.WidowRayCastBackward, Event Player, Event Player.WidowDamage); 
       

        Event Player.WidowDamage = 12;

        Stop Chasing Player Variable(Event Player, WidowDamage);

       
       

        Wait(0.2, Ignore Condition);
        Destroy Effect(Event Player.WidowFireBeam);

	}
}



rule("Widowmaker fired, start recharging gun.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
       
		Is Using Ultimate(Event Player) == True;
       
        Is Firing Primary(Event Player) == true;
       
       
        Event Player.WidowZoomedIn == true;
        Is Reloading(Event Player) != true;
        Is In Line Of Sight(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted), Barriers Do Not Block LOS) != true;
		Is Dummy Bot(Event Player) == false;

	
	}

    actions
    {
        
        

       
        Wait(0.496, Restart When True);

        Event Player.WidowDamage = 12;

        Skip If(Is Using Ultimate(Event Player) != True || Event Player.WidowZoomedIn != true || Is Reloading(Event Player) == true, 1);
        Chase Player Variable Over Time(Event Player, WidowDamage, 120, 1, None);
    }

}



rule("Widowmaker aim through wall and create beam.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
		Update Every Frame(Is Using Ultimate(Event Player)) == True;
        Update Every Frame(Is Button Held(Event Player, Button(Secondary Fire))) == True;
       
        Update Every Frame(Is Reloading(Event Player)) != true;
        Is In Spawn Room(Event Player) == false;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
        Event Player.WidowDamage = 12;

       
        Wait(0.32, Abort When False);

        Event Player.WidowZoomedIn = true;

        Create Beam Effect(Remove From Array(All Players(All Teams), Event Player), Bad Beam, Eye Position(Event Player), Event Player + Facing Direction Of (Event Player) * 1000, Team Of(Event Player), Visible To Position and Radius);
        
        Event Player.WidowAimBeam = Last Created Entity;

       

       

        Stop Chasing Player Variable(Event Player, WidowDamage);

        Event Player.WidowDamage = 12;

        Chase Player Variable Over Time(Event Player, WidowDamage, 120, 1, None);
        
        
	}
}



rule("Widowmaker update aim raycast")
{
    event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

    conditions
	{
        Update Every Frame(Is Using Ultimate(Event Player)) == True;
        Update Every Frame(Is Button Held(Event Player, Button(Secondary Fire))) == True;
       
        Update Every Frame(Is Reloading(Event Player)) != true;
        Is Firing Primary(Event Player) == false;
        Is In Spawn Room(Event Player) == false;
		Is Dummy Bot(Event Player) == false;

	}

    actions
    {
       
        Wait(0.016, Ignore Condition);
       
       
        Event Player.WidowRayCastStartPos = (Update Every Frame(Eye Position(Event Player)) + Update Every Frame(Facing Direction Of(Event Player)) * Update Every Frame(Distance Between(Update Every Frame(Event Player), Update Every Frame(First Of(Event Player.WidowPlayersInViewAngleSorted)))));

       
        Event Player.WidowRayCastStartPos -= Normalize((Event Player.WidowRayCastStartPos - Update Every Frame(Eye Position(Event Player))));

        Event Player.WidowRayCastEndPos = Event Player.WidowRayCastStartPos + Update Every Frame(Facing Direction Of(Event Player))  * 2; 

        Event Player.WidowLastFacingDirection = Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000;

        Loop If Condition Is True;
        

    }
}



rule("Widowmaker update player closest to reticle, detects only living players")
{
    event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

    conditions
	{
        Is Using Ultimate(Event Player) == True;
        Is Button Held(Event Player, Button(Secondary Fire)) == True;
        Is Reloading(Event Player) != true;
        Is Firing Primary(Event Player) == false;
        Is In Spawn Room(Event Player) == false;
		Is Dummy Bot(Event Player) == false;

	}

    actions
    {
        
        Wait(0.064, Ignore Condition);
        Event Player.WidowPlayersInViewAngleSorted = Sorted Array(All Living Players(Opposite Team Of(Team Of(Event Player))), Absolute Value(Angle Difference(Horizontal Facing Angle Of(Event Player) + Vertical Facing Angle Of(Event Player), Horizontal Angle From Direction(Direction Towards(Event Player, Current Array Element)) + Vertical Angle From Direction(Direction Towards(Event Player, Current Array Element)))));
	
	
	
	

        Loop If Condition Is True;
        

    }
}



rule("Widowmaker not aiming or using ultimate.")
{
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
        (Is Button Held(Event Player, Button(Secondary Fire)) != True || Is Using Ultimate(Event Player) == false) == True;
        Event Player.WidowZoomedIn == true;
	}

    actions
    {
        Call Subroutine(ResetWidow);
    }

}



rule("Widowmaker reset")
{
	event
	{
		Subroutine;
		ResetWidow;
	}

    actions
    {
        Event Player.WidowZoomedIn = false;
        Stop Chasing Player Variable(Event Player, WidowDamage);
        Destroy Effect(Event Player.WidowAimBeam);
        Event Player.WidowAimBeam = null;
		
		if(Event Player.WidowFireBeam != Null);
        Destroy Effect(Event Player.WidowFireBeam);
		End;
		
    }

}



rule("Widowmaker reloading.")
{
    
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
        Is Reloading(Event Player) == true;
		Is Dummy Bot(Event Player) == false;

	}

    actions
    {
        Stop Chasing Player Variable(Event Player, WidowDamage);
        Event Player.WidowDamage = 12;
       
       
       
        Destroy Effect(Event Player.WidowAimBeam);
        Event Player.WidowAimBeam = null;
    }

}



rule("Widowmaker in spawn room")
{
    event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
        Is In Spawn Room(Event Player) == true;
		Is Dummy Bot(Event Player) == false;
        Is Button Held(Event Player, Button(Secondary Fire)) == True;

	}


	actions
	{
        Big Message(Event Player, Custom String("Leave spawn room to use Widow's ultimate!"));
        Call Subroutine(ResetWidow);
        
	}
}



rule("Widow description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Fire at enemies through walls during her ultimate. Casts a laser that warns enemies if they're being aimed at.{0}", Custom String("
		Headshots cause a jingle sound. Hit detection might not always work properly.", Null, Null, Null));

	}
}





rule("winston: using ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		Winston;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
		Start Scaling Player(Event Player, 2, false);
		Wait Until(Is Using Ultimate(Event Player) != true || Is Dead(Event Player) == true, 50);
		Call Subroutine(ResetWinston);


	}
}



rule("winston: reset")
{
	event
	{
		Subroutine;
		ResetWinston;
	}

	actions
	{
	
		Stop Scaling Player(Event Player);
		Detach Players(Event Player.WinstonGrabbing);
		Event Player.WinstonGrabbing = Null;
	

	}
}



rule("winston: grab an enemy")
{

	event
	{
		Ongoing - Each Player;
		All;
		Winston;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
		Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Is In View Angle(Event Player, Current Array Element, 35) == true && Distance Between(Event Player, Current Array Element) < 5) != Empty Array;
	
	
		Event Player.WinstonGrabbing == Null;
	}

	actions
	{
		
	
		Event Player.WinstonGrabbing = Value In Array(Sorted Array(Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Angle Between Vectors(Direction Towards (Eye Position(Event Player), Current Array Element), Facing Direction Of (Event Player)) <= 30 && Distance Between(Event Player, Current Array Element) < 5), Absolute Value(Angle Difference(Horizontal Facing Angle Of(Event Player) + Vertical Facing Angle Of(Event Player), Horizontal Angle From Direction(Direction Towards(Event Player, Current Array Element)) + Vertical Angle From Direction(Direction Towards(Event Player, Current Array Element))))), 0);

		Attach Players(Event Player.WinstonGrabbing, Event Player, Vector(0, 1.5, 2));

	}
}



rule("winston: throw a grabbed enemy")
{
	event
	{
		Ongoing - Each Player;
		All;
		Winston;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
		Event Player.WinstonGrabbing != Null;
	}

	actions
	{
		Detach Players(Event Player.WinstonGrabbing);
		Apply Impulse(Event Player.WinstonGrabbing, Facing Direction Of(Event Player), 50, To World, Cancel Contrary Motion);
	
		Damage(Event Player.WinstonGrabbing, Event Player, 1);
		Event Player.WinstonGrabbing = Null;

	}
}



rule("winston: if grabbed enemy died, detach them")
{
	event
	{
		Ongoing - Each Player;
		All;
		Winston;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Event Player.WinstonGrabbing != Null;
		Is Dead(Event Player.WinstonGrabbing) == True;
	}

	actions
	{
		Detach Players(Event Player.WinstonGrabbing);
		Event Player.WinstonGrabbing = Null;
	


	}
}



rule("winston: when winston hits someone, set root status and get direction and set player winston in their J variable for reference.")
{
	event
	{
		Player Dealt Damage;
		All;
		Winston;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
	
		Victim.J == Null;
	}

	actions
	{

		Wait(0.1, Abort When False);
		
		Victim.J = Event Player;
		

		Victim.I = Direction Towards(Position Of(Event Player), Victim);
	
		
	
		
	
		
	
	
		
		Set Status(Victim, Event Player, Rooted, 1);
		Victim.H = Speed Of In Direction(Victim, Victim.I);

	}
}



rule("winston: check for wall with ray cast.")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.J != Null;
	
	}

	actions
	{
		Wait(0.1, Ignore Condition);
	
		Event Player.WinstonRayCast1 = Ray Cast Hit Normal(Eye Position(Event Player), Eye Position(Event Player) + Event Player.I, Null, Array(Event Player, Event Player.J), True);
	
		Event Player.WinstonRayCast2 = Ray Cast Hit Normal(Position Of(Event Player), Position Of(Event Player) + Event Player.I, Null, Array(Event Player, Event Player.J), True);
		Loop If((Event Player.J != null && Is Alive(Event Player)) && (Event Player.WinstonRayCast1 == Direction Towards(Eye Position(Event Player) + Event Player.I, Eye Position(Event Player) ) || Event Player.WinstonRayCast2 == Direction Towards(Position Of(Event Player) + Event Player.I, Position Of(Event Player) )) == True);
	
		
		If(Is On Ground(Event Player) == False);
		
		Set Status(Event Player, Null, Stunned, 1.5);

		Damage(Event Player, Event Player.J, 150);
		
		Wait(1.5, Ignore Condition);
		Event Player.J = null;
		Event Player.I = 0;
		Event Player.H = 0;
		
		Else;
	
		Event Player.J = null;
		Event Player.I = 0;
		Event Player.H = 0;
		End;
		
	}
}



rule("Winston description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Winston;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Turn into a giant gorilla. Knocking enemies into walls causes stun and damage.{0}", Custom String("
		Use secondary fire to grab enemies then throw them in the direction you aim at with primary fire."));

	}
}





rule("Wrecking ball activate ultimate.")
{
   
    event
	{
		Ongoing - Each Player;
		All;
		Wrecking Ball;
	}

    conditions
	{
        Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == Null;
	
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

    actions
    {
        Call Subroutine(UseCustomUlt);
        Start Scaling Player(Event Player, 3, false);
       
        Skip If(Is In Alternate Form(Event Player) == true, 1);
        Press Button(Event Player, Button(Ability 1));

	
	
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
        Disallow Button(Event Player, Button(Ability 1));
       
        Set Damage Received(Event Player, 33);
        Set Knockback Received(Event Player, 33);
        Wait Until(Is Dead(Event Player), 15);
        Skip If(Event Player.UsingCustomUlt == Null, 1);
        Call Subroutine(ResetWB);
        


    }
}



rule("Wrecking ball reset.")
{
    
    event
	{
		Subroutine;
		ResetWB;
	}


    actions
    {
        
       
        Call Subroutine(StopUsingCustomUlt);
        Start Scaling Player(Event Player, 1, false);
		Set Ability 1 Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
        Set Damage Received(Event Player, 100);
        Set Knockback Received(Event Player, 100);



    }
}



rule("Wrecking ball kill nearby enemies while using ultimate")
{
    event
	{
		Ongoing - Each Player;
		All;
		Wrecking Ball;
	}

    conditions
	{
		Event Player.UsingCustomUlt == true;
		Hero Of(Event Player) == Hero(Wrecking Ball);
        Players Within Radius(Event Player, 10, Opposite Team of(Team Of(Event Player)), Surfaces) != null;
        Is True For Any(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces), Is Alive(current array element)) == true;
        Is Moving(Event Player) == true;
       
       
	}

    actions
    {
       
       
       
        Damage(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces), Event Player, 400);
        Apply Impulse(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces), Position Of(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces)) - Event Player, 50, To World, Cancel Contrary Motion);
       
    }
}



rule("Auto-transform back to ball if form is reverted by enemy abilities")
{
    event
	{
		Ongoing - Each Player;
		All;
		Wrecking Ball;
	}

    conditions
	{
		Event Player.UsingCustomUlt == true;
		Hero Of(Event Player) == Hero(Wrecking Ball);
        Is In Alternate Form(Event Player) == false;
	}

    actions
    {
        Wait(1, Ignore Condition);
       
        Allow Button(Event Player, Button(Ability 1));
        Press Button(Event Player, Button(Ability 1));
        Disallow Button(Event Player, Button(Ability 1));
	
        Loop If Condition Is True;

    }
}



rule("Wrecking Ball description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Wrecking Ball;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Turn into a giant ball and roll over enemies.");

	}
}





rule("zarya: uses ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
	
		Event Player.CustomUltReadyToUse == True;
	
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Event Player.S = 15;
	
	
	
	
	
	
		Create Projectile Effect(All Players(All Teams), Zarya Graviton, All Players(Team Of(Event Player)), Event Player.ZaryaGravPos, Facing Direction Of(Event Player), 0.5, Visible To Position Direction and Size);
		Wait Until(Is Dead(Event Player), 15);
		Call Subroutine(ResetZarya);
	}
}



rule("zarya: reset")
{
	event
	{
		Subroutine;
		ResetZarya;
	}

	actions
	{
		Call Subroutine(StopUsingCustomUlt);
		Destroy Effect(Last Created Entity);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = Null;
	
		Event Player.ZaryaGravPos = Null;
	}
}



rule("Zarya set grav point position")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		
		Event Player.ZaryaGravPos = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* Event Player.S, Y Component Of(Facing Direction Of(Event Player)) * Event Player.S + 2, Z Component Of(Facing Direction Of(
			Event Player)) * Event Player.S), Null, All Players(All Teams), True);
		Loop If Condition Is True;
	}
}



rule("Zarya move gravity point forward")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
	
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S += 0.200;
		Loop If Condition Is True;
	}
}



rule("Zarya move gravity point backward")
{

	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
	
		disabled Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
		Distance Between(Event Player, Event Player.ZaryaGravPos) > 7;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S -= 0.200;
		Loop If Condition Is True;
	}
}



rule("zarya: pull enemies to grav")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Distance Between(Event Player.ZaryaGravPos, Closest Player To(Event Player.ZaryaGravPos, Opposite Team Of(Team Of(Event Player)))) <= 10;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
	
		
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Players Within Radius(Event Player.ZaryaGravPos, 10, Opposite Team Of(Team Of(Event Player)), Off)), 1);
		Apply Impulse(Value In Array(Players Within Radius(Event Player.ZaryaGravPos, 10, Opposite Team Of(Team Of(Event Player)), Off), Event Player.ForLoopIndexPlayer), Vector Towards(Value In Array(Players Within Radius(Event Player.ZaryaGravPos, 10, Opposite Team Of(Team Of(Event Player)), Off), Event Player.ForLoopIndexPlayer), Event Player.ZaryaGravPos), Distance Between(Value In Array(Players Within Radius(Event Player.ZaryaGravPos, 10, Opposite Team Of(Team Of(Event Player)), Off), Event Player.ForLoopIndexPlayer), Event Player.ZaryaGravPos), To World, Cancel Contrary Motion);
		End;
		Loop If Condition Is True;
	}
}



rule("Zarya description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zarya;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Like her regular ult, but the gravity zone moves where you're aiming.{0}", Custom String("
		Press Primary Fire to move the ball further and secondary to move closer.", Null, Null, Null));

	}
}





rule("Zenyatta activate ultimate")
{
   
	event
	{
		Ongoing - Each Player;
		All;
		Zenyatta;
	}

	conditions
	{
	
		Event Player.CustomUltReadyToUse == True;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
		Is Alive(Event Player) == True;
		
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
	
		Event Player.Y = 30;
		Chase Player Variable At Rate(Event Player, Y, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("{0} {1}", Custom String("Damage enemy player to possess them!"), Event Player.Y), Null, Null,
			Left, 3, Color(Purple), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.M = Last Text ID;
		Event Player.UsingCustomUlt = True;
		Wait(Event Player.Y, Ignore Condition);
	
	
		Call Subroutine(ResetZenyatta);
	}
}



rule("Zenyatta reset")
{
	event
	{
		Subroutine;
		ResetZenyatta;
	}

	actions
	{
		If(Event Player.P != Null);
		Call Subroutine(StopPossessing);
		End;
		Event Player.UsingCustomUlt = 0;
		Event Player.CustomUltReadyToUse = 0;
	
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Chasing Player Variable(Event Player, Y);
		Event Player.Y = Null;
		Destroy HUD Text(Event Player.M);
		Event Player.M = Null;
		
	}
}



rule("Zenyatta possess a player")
{
	event
	{
		Player Dealt Damage;
		All;
		Zenyatta;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	

	}

	actions
	{
		Wait(0.250, Ignore Condition);
		Abort If(Is Dead(Victim) == True);
		Event Player.P = Victim;
		Start Facing(Event Player.P, Update Every Frame(Facing Direction Of(Event Player)), 1000, To World, Direction and Turn Rate);
		
		Play Effect(All Players(All Teams), Bad Pickup Effect, Color(Purple), Event Player, 3);
		
		Create HUD Text(Event Player.P, Hero Icon String(Hero(Zenyatta)), Custom String("YOU HAVE BEEN POSSESSED BY ZENYATTA!"), Null, Top,
			0, Color(Purple), Color(Purple), Color(White), Visible To and String, Default Visibility);
		Event Player.G = Last Text ID;
		Disallow Button(Event Player.P, Button(Primary Fire));
		Disallow Button(Event Player.P, Button(Secondary Fire));
		Disallow Button(Event Player.P, Button(Jump));
		Disallow Button(Event Player.P, Button(Crouch));
		Disallow Button(Event Player.P, Button(Ultimate));
		Disallow Button(Event Player.P, Button(Ability 1));
		Disallow Button(Event Player.P, Button(Ability 2));
		Start Throttle In Direction(Event Player.P, Throttle Of(Event Player), 1, To Player, Replace existing throttle, Direction and Magnitude);

	
		

		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player.P)) + Update Every Frame(Facing Direction Of(Event Player.P)), Update Every Frame(Eye Position(Event Player.P)) + Update Every Frame(Facing Direction Of(Event Player.P)) * 2, 0);
		Set Invisible(Event Player, All);
		Set Status(Event Player, Null, Phased Out, 9999);
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
	
		Set Move Speed(Event Player, 1);



       
       
       

	}
}



rule("Zenyatta reset")
{
	event
	{
		Subroutine;
		StopPossessing;
	}

	actions
	{
		
		Stop Throttle In Direction(Event Player.P);
		Allow Button(Event Player.P, Button(Primary Fire));
		Allow Button(Event Player.P, Button(Secondary Fire));
		Allow Button(Event Player.P, Button(Ability 1));
		Allow Button(Event Player.P, Button(Ability 2));
		Allow Button(Event Player.P, Button(Ultimate));
		Allow Button(Event Player.P, Button(Jump));
		Allow Button(Event Player.P, Button(Crouch));
		Stop Facing(Event Player.P);
		Teleport(Event Player, Event Player.P + Facing Direction Of(Event Player.P) * -1);
		If(Is Alive(Event Player.P));
		Set Status(Event Player.P, Event Player, Asleep, 8);
		End;
		Stop Forcing Throttle(Event Player.P);
		Stop Camera(Event Player);
		Event Player.P = Null;
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Clear Status(Event Player, Phased Out);
		Set Invisible(Event Player, None);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Destroy HUD Text(Event Player.G);
		Event Player.G = Null;
	}
}



rule("Zenyatta leave possessed player when using interact or when possessed player dies")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zenyatta;
	}

	conditions
	{
		Event Player.P != Null;
		(Is Button Held(Event Player, Button(Interact)) || Is Dead(Event Player.P))== True;
		

	}

	actions
	{
		Call Subroutine(StopPossessing);
	}
}



rule("Zenyatta move possessed player forward")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Z Component Of(Throttle Of(Event Player)) > Null;
		
	}

	actions
	{
		Start Forcing Throttle(Event Player.P, 1, 1, 0, 0, 0, 0);
		
	}
}



rule("Zenyatta move possessed player sideways")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		(X Component Of(Throttle Of(Event Player)) < Null || X Component Of(Throttle Of(Event Player)) > Null) == True;
	}

	actions
	{
		
		Start Forcing Throttle(Event Player.P, 0, 0, 0, 0, 1, 1);
	}
}



rule("Zenyatta move possessed player backwards")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Z Component Of(Throttle Of(Event Player)) < Null;
	}

	actions
	{
		
		Start Forcing Throttle(Event Player.P, 0, 0, 1, 1, 0, 0);
		
	}
}



rule("Zenyatta primary fire")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Primary Fire));
		Skip If(Is Button Held(Event Player.P, Button(Primary Fire)) == True, 1);
		Start Holding Button(Event Player.P, Button(Primary Fire));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Primary Fire));
		Disallow Button(Event Player.P, Button(Primary Fire));
	}
}



rule("Zenyatta secondary fire")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Secondary Fire));
		Skip If(Is Button Held(Event Player.P, Button(Secondary Fire)) == True, 1);
		Start Holding Button(Event Player.P, Button(Secondary Fire));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Secondary Fire));
		Disallow Button(Event Player.P, Button(Secondary Fire));
	}
}





rule("Zenyatta stop moving when there's no throttle")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Z Component Of(Throttle Of(Event Player)) == Null;
		X Component Of(Throttle Of(Event Player)) == Null;
	}

	actions
	{
		Start Forcing Throttle(Event Player.P, 0, 0, 0, 0, 0, 0);
		disabled Stop Accelerating(Event Player.P);
	}
}



rule("Zenyatta enable moving when there's throttle")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		(Z Component Of(Throttle Of(Event Player)) != Null || X Component Of(Throttle Of(Event Player)) != 0) == True;
	}

	actions
	{
		Stop Forcing Throttle(Event Player.P);
		disabled Stop Accelerating(Event Player.P);
	}
}



rule("Zenyatta jump")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Jump)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Jump));
		Skip If(Is Button Held(Event Player.P, Button(Jump)) == True, 1);
		Start Holding Button(Event Player.P, Button(Jump));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Jump));
		Disallow Button(Event Player.P, Button(Jump));
	}
}



rule("Zenyatta crouch")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Crouch)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Crouch));
		Skip If(Is Button Held(Event Player.P, Button(Crouch)) == True, 1);
		Start Holding Button(Event Player.P, Button(Crouch));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Crouch));
		Disallow Button(Event Player.P, Button(Crouch));
	}
}



rule("Zenyatta ability 1")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Ability 1)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Ability 1));
		Skip If(Is Button Held(Event Player.P, Button(Ability 1)) == True, 1);
		Start Holding Button(Event Player.P, Button(Ability 1));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Ability 1));
		Disallow Button(Event Player.P, Button(Ability 1));
	}
}



rule("Zenyatta ability 2")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Ability 2)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Ability 2));
		Skip If(Is Button Held(Event Player.P, Button(Ability 2)) == True, 1);
		Start Holding Button(Event Player.P, Button(Ability 2));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Ability 2));
		Disallow Button(Event Player.P, Button(Ability 2));
	}
}



rule("Zenyatta ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Allow Button(Event Player.P, Button(Ultimate));
		Skip If(Is Button Held(Event Player.P, Button(Ultimate)) == True, 1);
		Start Holding Button(Event Player.P, Button(Ultimate));
		Loop If Condition Is True;
		Stop Holding Button(Event Player.P, Button(Ultimate));
		Disallow Button(Event Player.P, Button(Ultimate));
	}
}



rule("Zenyatta voice line up")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Voice Line Up) == True;
	}

	actions
	{
		Communicate(Event Player.P, Voice Line Up);
	}
}



rule("Zenyatta voice line right")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Voice Line Right) == True;
	}

	actions
	{
		Communicate(Event Player.P, Voice Line Right);
	}
}



rule("Zenyatta voice line left")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Voice Line Left) == True;
	}

	actions
	{
		Communicate(Event Player.P, Voice Line Left);
	}
}



rule("Zenyatta voice line down")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Voice Line Down) == True;
	}

	actions
	{
		Communicate(Event Player.P, Voice Line Down);
	}
}



rule("Zenyatta emote up")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Emote Up) == True;
	}

	actions
	{
		Communicate(Event Player.P, Emote Up);
	}
}



rule("Zenyatta emote right")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Emote Right) == True;
	}

	actions
	{
		Communicate(Event Player.P, Emote Right);
	}
}



rule("Zenyatta emote left")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Emote Left) == True;
	}

	actions
	{
		Communicate(Event Player.P, Emote Left);
	}
}



rule("Zenyatta emote down")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Emote Down) == True;
	}

	actions
	{
		Communicate(Event Player.P, Emote Down);
	}
}



rule("Zenyatta hello")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Hello) == True;
	}

	actions
	{
		Communicate(Event Player.P, Hello);
	}
}



rule("Zenyatta ultimate status")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Ultimate Status) == True;
	}

	actions
	{
		Communicate(Event Player.P, Ultimate Status);
	}
}



rule("Zenyatta need healing")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Need Healing) == True;
	}

	actions
	{
		Communicate(Event Player.P, Need Healing);
	}
}



rule("Zenyatta group up")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Group Up) == True;
	}

	actions
	{
		Communicate(Event Player.P, Group Up);
	}
}



rule("Zenyatta thanks")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Thanks) == True;
	}

	actions
	{
		Communicate(Event Player.P, Thanks);
	}
}



rule("Zenyatta acknowledge")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.P != Null;
		Is Communicating(Event Player, Acknowledge) == True;
	}

	actions
	{
		Communicate(Event Player.P, Acknowledge);
	}
}



rule("Zen description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Zenyatta;
	}

	conditions
	{
		
		

	}

	actions
	{
		Event Player.UltDescription = Custom String("Possess enemies you damage while the ultimate is active.{0}", Custom String("
		Press interact to leave their bodies and they will fall asleep.", Null, Null, Null));

	}
}

