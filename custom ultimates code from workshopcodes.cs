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
			
			
			
				Workshop Chamber 0
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
                Ultimate Duration: 150%
            }

			Winston
			{
				Primal Rage Melee Knockback Scalar: 150%
			}

			disabled heroes
			{
			
				Ashe
				Baptiste
				Bastion
				Hanzo
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
	}
}
variables {
  global:
    0: S
    1: UltingSigmas
    2: NukingPlayer
    3: NukeTimer
    4: NukeText
    5: ForLoopIndexGlobal
    6: NukePosition
    7: NukeRadius
    8: T
    9: TimeStopTimer
    10: R
    11: P
    12: Q
    13: GreenPortal
    14: YellowPortalRaycast
    15: GreenPortalRaycast
    16: SymmetraBluePNormal
    17: SymmetraRedPNormal
    18: SymmetraYellowPNormal
    19: SymmetraGreenPNormal

  player:
    0: B
    1: CustomUltReadyToUse
    2: UltReadyText
    3: UsingCustomUlt
    4: UltEffect
    5: G
    6: Y
    7: UltDescriptionTextObject
    8: MenuHUDOptions
    9: MenuOptions
    10: ForLoopIndexPlayer
    11: MenuHUDChooseSort
    12: MenuOpen
    13: MenuChosenOption
    14: A
    15: D
    16: BrigitteUltActive
    17: BrigitteKnockedBack
    18: S
    19: M
    20: DVAVariables
    21: EchoAimRayCast
    22: EchoDummyBots
    23: EchoEffects
    24: V
    25: JunkerQueenEnemyArray
    26: JunkerQueenEnemyPositions
    27: JunkerReadyToTeleport
    28: JunkerQueenInArena
    29: JunkerQueenPositions
    30: JunkerRageEffects
    31: JunkerDamageCounter
    32: JunkerDamageMods
    33: JunkerQueenHealthPools
    34: JunkerArenaSphere
    35: JunkerWinCounterText
    36: JunkerWinCounter
    37: ExtraLife
    38: JunkratBombPosition
    39: JunkratBombOrb
    40: JunkratExplosionRadius
    41: JunkratRadiusRing
    42: JunkratTimer
    43: JunkratTimerHUD
    44: JunkratTimerAboveHead
    45: UltingEnemyMcCree
    46: UltDescription
    47: EnemyMei
    48: P
    49: Coronavirus
    50: CoronavirusDamageDebuff
    51: CoronavirusText
    52: CoronavirusEffect
    53: HasDiedWithCoronaVirus
    54: MercyExtraLifeText
    55: ExtraLifeInWorldText
    56: R
    57: Q
    58: U
    59: ReaperVariables
    60: ReaperTPPos
    61: ReinhardtHudText
    62: RoadhogHUD
    63: SigmaMaleTimer
    64: SigmaMaleValues
    65: SigmaZeroGravBuff
    66: SigmaHighGravDebuff
    67: SigmaDebuffGravityScale
    68: SojournLastRay
    69: SojournRayArray
    70: SojournBeamArray
    71: SojournEyePosArray
    72: SojournLastEyePos
    73: SojournDamageRay
    74: Soldier76Variables
    75: SoldierAllKillStreaks
    76: Soldier76KillStreaksEquipped
    77: SoldierKillStreakTexts
    78: Soldier76KillStreaksActive
    79: LocalVariable
    80: Soldier76CarepackLocation
    81: SoldierCarePackAmmoIndex
    82: O
    83: N
    84: K
    85: L
    86: InPortalSpeed
    87: TorbTurret
    88: TorbTurretLevel
    89: TorbTurretLevelText
    90: TorbCurrentTarget
    91: WidowZoomedIn
    92: WidowPlayersInViewAngleSorted
    93: WidowRayCastForward
    94: WidowRayCastStartPos
    95: WidowRayCastEndPos
    96: WidowRayCastBackward
    97: WidowRayCastHeadForward
    98: WidowRayCastHeadBackward
    99: WidowFireBeam
    100: WidowDamage
    101: WidowAimBeam
    102: WidowLastFacingDirection
    103: WinstonGrabbing
    104: J
    105: I
    106: H
    107: WinstonRayCast1
    108: WinstonRayCast2
    109: ZaryaGravPos
}


subroutines {
    0: UseCustomUlt
    1: StopUsingCustomUlt
    2: CreateMenu
    3: ResetBrigitte
    4: ResetDoomfist
    5: ResetDVa
    6: ResetEcho
    7: ResetGenji
    8: ResetJQ
    9: ResetJunkrat
    10: ResetCassidy
    11: ResetMei
    12: ResetMoira
    13: ResetPharah
    14: ResetReaper
    15: ResetReinhardt
    16: ResetRoadhog
    17: ResetSigma
    18: ResetSojourn
    19: ResetSoldier
    20: ResetSombra
    21: ResetSymmetra
    22: ResetTorb
    23: ResetTracer
    24: ResetWidow
    25: ResetWinston
    26: ResetWB
    27: ResetZarya
    28: ResetZenyatta
    29: StopPossessing
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

		
	

	

	
	
	

	

	

	
	
	
	
		If(Event Player.B == Hero(Cassidy));
		Call Subroutine(ResetCassidy);
		Else If(Event Player.B == Hero(D.Va));
		Call Subroutine(ResetDVa);
		Else If(Event Player.B == Hero(Doomfist));
		Call Subroutine(ResetDoomfist);
		Else If(Event Player.B == Hero(Echo));
		Call Subroutine(ResetEcho);
		Else If(Event Player.B == Hero(Genji));
		Call Subroutine(ResetGenji);
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
		Call Subroutine(ResetSymmetra);
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

		Event Player.B = Null;


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
		Event Player.B = Hero Of(Event Player);
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
        Destroy Effect(Event Player.UltEffect);
        Event Player.UsingCustomUlt = null;
        Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Set Ultimate Ability Enabled(Event Player, True);
		Event Player.B = Null;
		Stop Chasing Player Variable(Event Player, G);
		Event Player.G = 0;
		Destroy HUD Text(Last Text ID);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Damage Dealt(Event Player, 100);
		Set Max Health(Event Player, 100);
		Destroy Effect(Event Player.Y);
		Event Player.Y = 0;
		Stop Camera(Event Player);
        
    }
}




rule("Ult description")
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
		If(Hero Of(Event Player) == Ana);
		
		
		Create HUD Text(Event Player, Custom String("Some string"), Null, Null, Left, 0, Color(white), Color(white), Color(white), Visible To And String, Default Visibility);
		Event Player.UltDescriptionTextObject = Last Text ID;
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
	
		Create Dummy Bot(Hero(Lúcio), Opposite Team Of(Team Of(Event Player)), -1, Event Player, Vector(0, 0, 0));
		Set Ultimate Charge(Last Created Entity, 99);
		
		Wait(1, Ignore Condition);
	
		Press Button(Last Created Entity, Button(Ultimate));
		
	
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
	

       

	

		Healee.A = True;

	
		
	}
}



rule("Disable nanoboost effects after some time or when dead")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.A == True;
		

	}

	actions
	{
		Wait Until(Is Dead(Event Player) == True, 8);
		Event Player.A = Null;

	}
}



rule("Set cooldowns to 0 for nanoboosted player")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.A == True;
		(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Ability Cooldown(Event Player, Button(Ability 2)) > 0 || Ability Cooldown(Event Player, Button(Secondary Fire)) > 0) == True;
		

	}

	actions
	{
	

		If(Ability Cooldown(Event Player, Button(Ability 1)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 1), 0);
		End;

		If(Ability Cooldown(Event Player, Button(Ability 2)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 2), 0);
		End;

		If(Ability Cooldown(Event Player, Button(Secondary Fire)) > 0);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), 0);
		End;


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
		
		

		Start Holding Button(Event Player, Button(Secondary Fire));

		Press Button(Event Player, Button(Ultimate));

	

		Wait(0.016, Ignore Condition);


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

	
		Apply Impulse(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Direction Towards(Event Player.G, Position Of(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)),
			Surfaces And Enemy Barriers))) + Up, 10, To World, Cancel Contrary Motion);
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
		Event Player.B = Null;
	}
}



rule("Doomfist not using ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		Doomfist;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == False;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Call Subroutine(ResetDoomfist);
	}
}



rule("Doomfist using ultimate create HUD description")
{
	event
	{
		Ongoing - Each Player;
		All;
		Doomfist;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Doomfist);
		Ultimate Charge Percent(Event Player) > 99.900;
	}

	actions
	{
		Create HUD Text(Event Player, Custom String(
			"While in the air, creates additional meteor strikes at random spots near enemy players. Longer duration."), Null, Null, Top,
			1, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.UltReadyText = Last Text ID;
		Event Player.B = Hero Of(Event Player);
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
		Event Player.B = Hero Of(Event Player);
		
	


	
	
		
	
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

	
	
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), -1, Event Player + Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player + Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Event Player.EchoDummyBots = Array(Last Created Entity);
	
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), -1, Event Player - Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player - Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Modify Player Variable(Event Player, EchoDummyBots, Append To Array, Last Created Entity);

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

	
	

		Event Player.B = Hero Of(Event Player);

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
		Event Player.B = Null;
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
		Set Move Speed(Event Player, 150);
		Event Player.Y = True;
		Event Player.B = Hero Of(Event Player);
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
		Set Move Speed(Event Player, 100);
		Set Damage Dealt(Event Player, 100);
		Event Player.Y = 0;
		Event Player.B = Null;
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
		Is Using Ultimate(Event Player) == True;
	
		Is Dummy Bot(Event Player) == false;
		Event Ability() == (Button(Ultimate));
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
	}

	actions
	{
		Event Player.B = Hero Of(Event Player);
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



rule("Junker queen Teleport JQ and chosen enemies.")
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


	
		Wait(0.01, Abort When False);

		Event Player.JunkerReadyToTeleport = Null;


		Teleport(Event Player.JunkerQueenEnemyArray, Position Of(Event Player) + Facing Direction Of(Event Player) * 10 + Up * 150);
		Teleport(Event Player, Position Of(Event Player) + Up * 150);
		Set Gravity(Event Player, 0);
		Set Gravity(Event Player.JunkerQueenEnemyArray, 0);
		Set Ultimate Ability Enabled(Event Player, False);
		Event Player.JunkerQueenInArena = true;
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = True;

	

		Create Effect(All Players(All Teams), Winston Primal Rage Effect, Team Of(Event Player), Event Player, 100, None);

		If(Event Player.JunkerRageEffects == Null);
		Event Player.JunkerRageEffects = Array(Last Created Entity);
		Else;
		Modify Player Variable(Event Player, JunkerRageEffects, Append To Array, Last Created Entity);
		End;
		
	
		If(Event Player.JunkerDamageCounter == Null);
		Event Player.JunkerDamageCounter = 100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects);
		Else;
		Modify Player Variable(Event Player, JunkerDamageCounter, Multiply, (100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects)) / 100);
		End;

		Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects), None);

		If(Event Player.JunkerDamageMods == Null);
	
		Event Player.JunkerDamageMods = Array(Last Damage Modification ID);
	
		Else;
		Modify Player Variable(Event Player, JunkerDamageMods, Append To Array, Last Damage Modification ID);
	
	
	
		End;

		Add Health Pool To Player(Event Player, Health, (50*Count Of(Event Player.JunkerQueenEnemyArray)) /Count of(Event Player.JunkerRageEffects), true, false);


		If(Event Player.JunkerQueenHealthPools == Null);

		Event Player.JunkerQueenHealthPools = Array(Last Created Health Pool);
		Else;

		Modify Player Variable(Event Player, JunkerQueenHealthPools, Append To Array, Last Created Health Pool);
		End;


		Modify Player Variable(Event Player, JunkerQueenPositions, Append To Array, Position Of(Event Player));

		Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Value In Array(Event Player.JunkerQueenPositions, 1), 20, None);
		Event Player.JunkerArenaSphere = Last Created Entity;

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

		Press Button(Event Player, Button(Ability 1));

		Start Scaling Player(Event Player, (1 + Count Of(Event Player.JunkerRageEffects) / 10), false);
		
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
		((Is True For Any(Event Player.JunkerQueenEnemyArray, Distance Between(Current Array Element, Value In Array(Event Player.JunkerQueenPositions, 1)) > 20 && Is Alive(Current Array Element) == true) == True) || (Distance Between(Value In Array(Event Player.JunkerQueenPositions, 1), Event Player) > 20 && Is Alive(Event Player) == true)  == True) == True;
	}

	actions
	{
		Wait(0.1, Abort When False);

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True)), 1);
		If(Distance Between(Value In Array(Event Player.JunkerQueenPositions, 1), Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer)) > 20);
		Apply Impulse( Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Direction Towards(Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Value In Array(Event Player.JunkerQueenPositions, 1)), 20, To World, Cancel Contrary Motion);
		End;
		If(Distance Between(Value In Array(Event Player.JunkerQueenPositions, 1), Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer)) > 30);
		Teleport( Value In Array(Filtered Array(Event Player.JunkerQueenEnemyArray, Current Array Element.JunkerQueenInArena == True), Event Player.ForLoopIndexPlayer), Value In Array(Event Player.JunkerQueenPositions, 1));
		End;
		End;

		If(Distance Between(Value In Array(Event Player.JunkerQueenPositions, 1), Event Player) > 20);
		Apply Impulse( Event Player, Direction Towards(Event Player, Value In Array(Event Player.JunkerQueenPositions, 1)), 20, To World, Cancel Contrary Motion);
		End;

		If(Distance Between(Value In Array(Event Player.JunkerQueenPositions, 1), Event Player) > 30);
		Teleport( Event Player, Value In Array(Event Player.JunkerQueenPositions, 1));
		End;

		Loop If Condition Is True;

	}
}



rule("Set ability 1 cooldown to 50% after use for buffed Junker queen.")
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
		Event Player.JunkerQueenHealthPools != Null;
	
	
	
		Ability Cooldown(Event Player, Button(Ability 1)) > 0;
	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Ability 1), 7.5);

	}
}



rule("Set ability 2 cooldown to 50% after use for buffed Junker queen.")
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
		Event Player.JunkerQueenHealthPools != Null;
	
	
	
		Ability Cooldown(Event Player, Button(Ability 2)) > 0;

	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Ability 2), 4);

	}
}



rule("Set Secondary Fire cooldown to 50% after use for buffed Junker queen.")
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
		Event Player.JunkerQueenHealthPools != Null;
	
	
	
		Ability Cooldown(Event Player, Button(Secondary Fire)) > 0;

	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Secondary Fire), 3);

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
		End;
		Set Gravity(Event Player, 100);
		Set Gravity(Event Player.JunkerQueenEnemyArray, 100);
		
	
		Set Knockback Dealt(Filtered Array(Event Player.JunkerQueenEnemyArray, Hero Of(Current Array Element) == Hero(Junker Queen)), 100);
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = Null;
		Event Player.JunkerQueenInArena = Null;
		Event Player.JunkerQueenEnemyArray = Null;
		Set Ultimate Ability Enabled(Event Player, True);

		Destroy Effect(Event Player.JunkerArenaSphere);
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
		Event Player.JunkerRageEffects != Null;
		Event Player.JunkerQueenHealthPools != Null;
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

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.JunkerQueenHealthPools), 1);
		Remove Health Pool From Player(Value In Array(Event Player.JunkerQueenHealthPools, Event Player.ForLoopIndexPlayer));
		End;
		
		Event Player.JunkerQueenHealthPools = Null;


		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.JunkerDamageMods), 1);
		Stop Damage Modification(Value In Array(Event Player.JunkerDamageMods, Event Player.ForLoopIndexPlayer));
		End;

		Event Player.JunkerDamageMods = Null;

		Destroy Hud Text(Event Player.JunkerWinCounterText);
		Event Player.JunkerWinCounterText = Null;

		Set Knockback Dealt(Event Player, 100);

		If(Event Player.JunkerQueenEnemyArray != Null);
		Event Player.JunkerQueenEnemyArray = Null;
		End;

		Event Player.JunkerDamageCounter = Null;
		Event Player.JunkerWinCounter = Null;

		Stop Scaling Player(Event Player);

		Set Projectile Speed(Event Player, 100);

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
		Set Gravity(Event Player, 100);
		Set Gravity(Event Player.JunkerQueenEnemyArray, 100);
		Teleport(Event Player, Value In Array(Event Player.JunkerQueenPositions, 0));
	
		Set Knockback Dealt(Filtered Array(Event Player.JunkerQueenEnemyArray, Hero Of(Current Array Element) == Hero(Junker Queen)), 100);
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = Null;
		Event Player.JunkerQueenInArena = Null;
		Event Player.JunkerQueenEnemyArray = Null;
		Set Ultimate Ability Enabled(Event Player, True);
		Destroy Effect(Event Player.JunkerArenaSphere);

		Event Player.JunkerArenaSphere = Null;
		Set Knockback Dealt(Event Player, 100);
		
		Modify Player Variable(Event Player, JunkerWinCounter, Add, 1);

		Set Knockback Dealt(Event Player, 100);
		
		Event Player.JunkerReadyToTeleport = Null;

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
		Set Gravity(Event Player, 100);
		
		Event Player.JunkerQueenInArena = Null;
	
		If(Hero Of(Event Player) == Hero(Junker Queen));
		Set Knockback Dealt(Event Player, 100);
		End;


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
		Event Player.JunkratTimer = 20;
		Create Hud Text(Event Player, Event Player.JunkratTimer, null, null, Top, 0, Color(Orange), Color(Orange), Color(Orange), String, Default Visibility);
		Event Player.JunkratTimerHUD = Last Text Id;
		Create In-World Text(All Players(All Teams), Event Player.JunkratTimer, Event Player.JunkratBombPosition + Up * 2, 10, Clip Against Surfaces, Visible To Position and String, Team Of(Event Player), Default Visibility);
		Event Player.JunkratTimerAboveHead = Last Text Id;
		Chase Player Variable At Rate(Event Player, JunkratTimer, 0, 1, None);
		Wait(Event Player.JunkratTimer, Ignore Condition);
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
		Destroy Hud Text(Event Player.JunkratTimerHUD);
		Event Player.JunkratTimerHUD = Null;
		Destroy In-World Text(Event Player.JunkratTimerAboveHead);
		Event Player.JunkratTimerAboveHead = Null;
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
		Play Effect(All Players(All Teams), Debuff Impact Sound, Team Of(Event Player), Eye Position(Event Player), 200);
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
		(Is Alive(Event Player) != true || Is Button Held(Event Player, Button(Interact)) == True) == True;
		Is Dummy Bot(Event Player) == False;
		
	}

	actions
	{
		Event Player.JunkratBombPosition = Position Of(Event Player);
	
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
		All Players(Opposite Team Of(Team Of(Event Player))).UltingEnemyMcCree = Event Player;
	
		Create HUD Text(Event Player, Custom String("It's High Noon! Nearby enemies and enemies who stare directly at you get burned."),
			Null, Null, Top, 0, Color(Yellow), Color(White), Color(Yellow), Visible To and String, Default Visibility);
		Event Player.UltDescription = Last Text ID;
		Event Player.B = Hero Of(Event Player);
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
		All;
	}

	conditions
	{
		Event Player.UltingEnemyMcCree != Null;
		Is In View Angle(Event Player, Event Player.UltingEnemyMcCree, 20) == True;
		Is In Line of Sight(Event Player, Event Player.UltingEnemyMcCree, Barriers Do Not Block LOS) == True;
	}

	actions
	{
		Wait(0.1, Ignore Condition);
		Set Status(Event Player, Event Player.UltingEnemyMcCree, Burning, 0.1);
	
		Damage(Event Player, Event Player.UltingEnemyMcCree, 5);
	
	
		Loop If Condition Is True;
	}
}



rule("If close to McCree get damaged")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.UltingEnemyMcCree != Null;
		Is In Line of Sight(Event Player, Event Player.UltingEnemyMcCree, Barriers Do Not Block LOS) == True;
		Distance Between(Event Player, Event Player.UltingEnemyMcCree) < 5;
	}

	actions
	{
		Wait(0.1, Ignore Condition);
		Set Status(Event Player, Event Player.UltingEnemyMcCree, Burning, 0.1);
	
		Damage(Event Player, Event Player.UltingEnemyMcCree, 10);
	
	
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
		All Players(Opposite Team Of(Team Of(Event Player))).UltingEnemyMcCree = Null;
		Destroy HUD Text(Event Player.UltDescription);
		Event Player.B = Null;
		Clear Status(Event Player, Burning);
	}
}





rule("Mei activate ultimate")
{

	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Mei);
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		All Players(Opposite Team Of(Team Of(Event Player))).EnemyMei = Event Player;
		Event Player.UsingCustomUlt = True;
		Create HUD Text(Event Player, Event Player.P, Null, Null, Top, 1, Color(Green), Color(White), Color(White), Visible To and String,
			Default Visibility);
		Event Player.UltDescription = Last Text ID;
		Create Effect(All Players(All Teams), Bad Aura, Color(Green), Event Player, 1, Visible To Position and Radius);
		Event Player.UltEffect = Last Created Entity;
		Event Player.P = 20;
		Chase Player Variable At Rate(Event Player, P, 0, 1, Destination and Rate);
	
	
	
		Wait(Event Player.P, Ignore Condition);
		Call Subroutine(ResetMei);
	}
}



rule("Reset Ult modifications on Mei.")
{
    event
    {
        Subroutine;
        ResetMei;
    }

    actions
    {
        Destroy Effect(Event Player.UltEffect);
		Event Player.UltEffect = Null;
		Event Player.P = Null;
		Event Player.UsingCustomUlt = Null;
		Event Player.CustomUltReadyToUse = Null;
		Event Player.B = Null;
		Destroy HUD Text(Event Player.UltDescription);
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
        
    }
}



rule("Mei: If player has virus, create virus effect, text and set variables, disable after 10 seconds")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Coronavirus == True;
	}

	actions
	{
		Set Healing Received(Event Player, 0);
		disabled Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 70,
			Receivers Damagers and Damage Percent);
		disabled Event Player.CoronavirusDamageDebuff = Last Damage Modification ID;
		disabled Set Max Health(Event Player, Max Health(Event Player) - 50);
		Create HUD Text(Event Player, Custom String(
			"You have coronavirus. You cannot be healed and take damage over time. Spreads to nearby teammates."), Null, Null, Right, 0,
			Color(Green), Color(Green), Color(White), Visible To and String, Default Visibility);
		Event Player.CoronavirusText = Last Text ID;
		Start Damage Over Time(Event Player, Null, 10, 20);
		Create Effect(All Players(All Teams), Cloud, Color(Green), Event Player, 1, Visible To Position and Radius);
		Event Player.CoronavirusEffect = Last Created Entity;
		disabled Set Status(Event Player, Null, Hacked, 10);
		Wait(10, Abort When False);
		Destroy Effect(Event Player.CoronavirusEffect);
		Event Player.CoronavirusEffect = Null;
		Destroy HUD Text(Event Player.CoronavirusText);
		Event Player.CoronavirusText = Null;
		disabled Set Max Health(Event Player, 100);
		disabled Skip If(Hero Of(Event Player) != Hero(D.Va), 2);
		disabled Skip If(Event Player.G == Null, 1);
		disabled Set Max Health(Event Player, Event Player.G);
		disabled Stop Damage Modification(Event Player.CoronavirusDamageDebuff);
		disabled Event Player.CoronavirusDamageDebuff = Null;
		Set Healing Received(Event Player, 100);
		Event Player.Coronavirus = Null;
	}
}



rule("Mei: If player has virus, spread to nearby players")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Coronavirus == True;
		Is In Spawn Room(Event Player) == False;
	}

	actions
	{
		Wait(1, Ignore Condition);
		Remove From Array(Players Within Radius(Event Player, 7, Team Of(Event Player), Surfaces), Event Player).Coronavirus = True;
		disabled Skip If(Max Health(Event Player) == 10, 1);
		disabled Set Max Health(Event Player, Max Health(Event Player) - 10);
		Loop If Condition Is True;
	}
}



rule("Mei spread virus to nearby enemies")
{
	event
	{
		Ongoing - Each Player;
		All;
		Mei;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		disabled Distance Between(Event Player, Closest Player To(Event Player, Opposite Team Of(Team Of(Event Player)))) <= 5;
	}

	actions
	{
		Wait(1, Ignore Condition);
		Players Within Radius(Event Player, 10, Opposite Team Of(Team Of(Event Player)), Surfaces).Coronavirus = True;
		Loop If Condition Is True;
	}
}



rule("Mei: Disable virus if player has spawned and had coronavirus before death")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Coronavirus == True;
		Event Player.HasDiedWithCoronaVirus == True;
		Is Alive(Event Player) == True;
	}

	actions
	{
		Destroy Effect(Event Player.CoronavirusEffect);
		Event Player.CoronavirusEffect = Null;
		Stop All Damage Over Time(Event Player);
		Destroy HUD Text(Event Player.CoronavirusText);
		Event Player.CoronavirusText = Null;
		Event Player.HasDiedWithCoronaVirus = Null;
		Set Healing Received(Event Player, 100);
		Event Player.Coronavirus = Null;
	}
}



rule("Mei: Check if player died with virus")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.Coronavirus == True;
		Is Dead(Event Player) == True;
	}

	actions
	{
		disabled Event Player.Coronavirus = Null;
		disabled Destroy Effect(Event Player.CoronavirusEffect);
		disabled Event Player.CoronavirusEffect = Null;
		disabled Stop All Damage Over Time(Event Player);
		disabled Clear Status(Event Player, Hacked);
		disabled Destroy HUD Text(Event Player.CoronavirusText);
		disabled Event Player.CoronavirusText = Null;
		Event Player.HasDiedWithCoronaVirus = True;
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
		Event Player.B = Hero Of(Event Player);
		
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
		Event Player.B == Hero Of(Event Player);
	
	
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
		Apply Impulse(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Direction Towards(Event Player.M, Position Of(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(
			Event Player)), Surfaces And Enemy Barriers))), 10, To World, Cancel Contrary Motion);
		Apply Impulse(Players Within Radius(Event Player.M, 10, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers), Up,
			2, To World, Cancel Contrary Motion);
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
		Event Player.B = Null;
	
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
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Apply Impulse(Event Player, Up, 10, To World, Cancel Contrary Motion);
	
		Set Primary Fire Enabled(Event Player, False);
		Event Player.R = 20;
		Chase Player Variable At Rate(Event Player, R, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("{0} {1}", Custom String("Crouch to drop bombs."), Custom String("Ability 1 to activate tacticool camera.")), String("{0}: {1}", Custom String("Bomb Cooldown: "), Event Player.S), String("{0}: {1}", Custom String("Ultimate Duration: "), Event Player.R), Right, 1, Color(Blue), Color(Blue), Color( White), Visible To and String, Default Visibility);
		Set Damage Dealt(Event Player, 300);
		Set Projectile Speed(Event Player, 300);
		Set Ability 1 Enabled(Event Player, False);
		Disallow Button(Event Player, Button(Jump));
		Disallow Button(Event Player, Button(Secondary Fire));
		Set Gravity(Event Player, 0);
	
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
		Set Gravity(Event Player, 100);
		Set Ultimate Ability Enabled(Event Player, True);
		Event Player.B = 0;
		Set Ability 1 Enabled(Event Player, True);
		Allow Button(Event Player, Button(Jump));
		Allow Button(Event Player, Button(Secondary Fire));
		Set Projectile Speed(Event Player, 100);
		Set Damage Dealt(Event Player, 100);
		Destroy HUD Text(Last Text ID);
		Destroy Effect(Event Player.P);
		Event Player.M = Null;
		Event Player.G = Null;
		Event Player.P = Null;
		Event Player.Y = Null;
		Event Player.Q = Null;
		Event Player.R = Null;
		Stop Camera(Event Player);
		Set Primary Fire Enabled(Event Player, True);
	
		Event Player.U = 0;
		Stop Damage Over Time(Last Damage Over Time ID);
		Clear Status(Event Player, Burning);
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
		Event Player.Y != True;
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
		Create Projectile(Mercy Caduceus Blaster, Event Player, Eye Position(Event Player) + Left*0.5, Null, To World, Damage, Opposite Team Of(Team Of(Event Player)), 10, 1, 0, Bad Explosion, Explosion Sound, 0, 50, 5, 0, 0, 0);
		Create Projectile(Mercy Caduceus Blaster, Event Player, Eye Position(Event Player) + Right*0.5, Null, To World, Damage, Opposite Team Of(Team Of(Event Player)), 10, 1, 0, Bad Explosion, Explosion Sound, 0, 50, 5, 0, 0, 0);
		Play Effect(All Players(All Teams), Debuff Impact Sound, Color(White), Event Player, 10000);
		Loop If Condition Is True;
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
    }

    actions
    {
        Call Subroutine(UseCustomUlt);
		Set Primary Fire Enabled(Event Player, False);
	
	
		Set Move Speed(Event Player, 150);

		Create Effect(All Players(All Teams), Bad Aura, Color(Black), Event Player, 1, POSITION AND RADIUS);
		Event Player.ReaperVariables = Array(Last Created Entity);

	
		Modify Player Variable(Event Player, ReaperVariables, Append To Array, 30);

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
		Set Move Speed(Event Player, 100);


		Destroy Effect(Value In Array(Event Player.ReaperVariables, 3));
		Destroy Effect(Value In Array(Event Player.ReaperVariables, 4));


		Event Player.ReaperTPPos = Null;

		Event Player.ReaperVariables = Null;
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
		Set Gravity(Event Player, 0);
	
		Wait Until(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Hero Of(Event Player) != Hero(Reaper) || Is Dead(Event Player) == True, 3);
        Enable Movement Collision With Environment(Event Player);
		Set Gravity(Event Player, 100);
	
	
	
	




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



rule("Reaper teleport back in bounds if standing out of bounds")
{

	event
	{
		Ongoing - Each Player;
		All;
		Reaper;
	}

	conditions
	{
		Is On Ground(Event Player) == True;
		Distance Between(Event Player, Nearest Walkable Position(Position Of(Event Player))) > 1.5;
	}

	actions
	{
		Teleport(Event Player, Nearest Walkable Position(Position Of(Event Player)));

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
		Create HUD Text(Event Player, Custom String("Jump down from high while using earthshatter to get a buff. Buff duration and effectiveness increased by air time."), Null, Null, Top, 1, Color(Orange), Color(White), Color(Orange), Visible To and String, Default Visibility);
		Event Player.UltReadyText = Last Text ID;
		Event Player.B = Hero Of(Event Player);
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
		Apply Impulse(Event Player, Up, 10, To World, Cancel Contrary Motion);
	
		disabled Global.S = Event Player;
		Event Player.Q = 0;
		Create Effect(All Players(All Teams), Bad Aura, Color(Orange), Event Player, Event Player.Q, Visible To Position and Radius);
		Event Player.UsingCustomUlt = Last Created Entity;
		Create Effect(All Players(All Teams), Bad Aura Sound, Team Of(Event Player), Event Player, Event Player.Q, Visible To Position and Radius);
		Event Player.G = Last Created Entity;
		Event Player.R = 100;
		Create HUD Text(Event Player, String("Power-up"), Event Player.Y, String("{0} {1}", String("{0} {1} {2}", String("Damage"), String("Dealt"), String("{0}%", Event Player.R)), String("{0} {1} {2}", String("Damage"), String("Defense"), String("{0}%", 100 - Event Player.P))), Right, 0, Color(Yellow), Color(Yellow), Color(White), Visible To and String, Default Visibility);
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
		Event Player.P -= 10;
		Event Player.Y += 1;
		Event Player.R += 30;
		Event Player.Q += 0.300;
		Set Damage Dealt(Event Player, Event Player.R);
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
		Event Player.B = Null;
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
		Event Player.B = Null;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Destroy HUD Text(Event Player.RoadhogHUD);
		Event Player.RoadhogHUD = Null;
		Event Player.Y = Null;
		Event Player.P = Null;
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
	
	}

	actions
	{
		Call Subroutine(UseCustomUlt);

		If(Global.UltingSigmas == Null);
		Global.UltingSigmas = Array(Event Player);
	
		Else;
		Modify Global Variable(UltingSigmas, Append To Array, Event Player);
		End;


		Event Player.SigmaMaleTimer = 15;
		Big Message(All Players(All Teams), Hero Icon String(Hero(Sigma)));
		Set Gravity(Event Player, 0);
		Create HUD Text(Event Player, Event Player.SigmaMaleTimer, Null, Null, Right, 0, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.SigmaMaleValues = Array(Last Text ID);

		Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Event Player, 20, Position and Radius);
		Modify Player Variable(Event Player, SigmaMaleValues, Append To Array, Last Created Entity);

		Chase Player Variable At Rate(Event Player, SigmaMaleTimer, 0, 1, Destination and Rate);
		Wait Until(Is Dead(Event Player) == true, Event Player.SigmaMaleTimer);
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

		Call Subroutine(StopUsingCustomUlt);
	}
}



rule("Sigma set zero grav buff and debuff to true and damage players who are really close")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sigma;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	
	}

	actions
	{
		Wait(0.1, Abort When False);
		Filtered Array(Players Within Radius(Event Player, 20, Opposite Team Of(Team Of(Event Player)), Off), (Current Array Element.SigmaZeroGravBuff != true) && (Current Array Element.SigmaHighGravDebuff == null)).SigmaHighGravDebuff = true;
		
		Players Within Radius(Event Player, 20, Team Of(Event Player), Off).SigmaZeroGravBuff = True;

		Damage(Filtered Array(Players Within Radius(Event Player, 5, Opposite Team Of(Team Of(Event Player)), Off), (Current Array Element.SigmaZeroGravBuff != true) && (Current Array Element.SigmaHighGravDebuff != null)), Event Player, 10);

		Loop If Condition Is True;
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
	
	
	
	
	
	
		

	
	}
}



rule("Sigma set zero grav debuff to null")
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

	
	
	
	

	
	
		Set Move Speed(Event Player, 100);
		Set Projectile Speed(Event Player, 100);

	

	
	}
}



rule("Sigma disable grav effects if buff and debuff are false")
{
    
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Event Player.SigmaZeroGravBuff != True;
		Event Player.SigmaHighGravDebuff != True;
	}

	actions
	{
	
		Wait(0.1, Abort When False);

	
	
		Set Gravity(Event Player, 100);
		Set Projectile Gravity(Event Player, 100);
		Set Move Speed(Event Player, 100);
	
	}
}




rule("Sigma high grav debuff effects")
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
		Event Player.SigmaZeroGravBuff != True;
	}

	actions
	{
		Wait(0.1, Abort When False);
       

	
	
	

	

		Event Player.SigmaDebuffGravityScale = 0;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20)), 1);
		Event Player.SigmaDebuffGravityScale += (20/Distance Between(Event Player, Value In Array(Filtered Array(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20), Event Player.ForLoopIndexPlayer)));
		End;

	
	
	

	
		

	
		If(((100 * Event Player.SigmaDebuffGravityScale) > 100) && (Event Player.SigmaHighGravDebuff != null));
		Set Gravity(Event Player, 100 * Event Player.SigmaDebuffGravityScale);
		Set Projectile Gravity(Event Player, 100 * Event Player.SigmaDebuffGravityScale);
		Set Move Speed(Event Player, 100 / Event Player.SigmaDebuffGravityScale);
		Set Projectile Speed(Event Player, 100 / Event Player.SigmaDebuffGravityScale);

		Else;
		Set Gravity(Event Player, 100);
		Set Projectile Gravity(Event Player, 100);
		Set Move Speed(Event Player, 100);
		Set Projectile Speed(Event Player, 100);
		End;

		Loop If Condition Is True;
	}
}



rule("Sigma zero grav buff set gravity")
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
	}

	actions
	{
		
		

	
		Wait(0.5, Abort When False);

		Set Gravity(Event Player, 0);
		Set Projectile Gravity(Event Player, 0);

		Loop If Condition Is True;

	


	
	
	
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
		Skip If(Event Player.B == Hero Of(Event Player), 1);
		Event Player.B = Hero Of(Event Player);

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
        
		Event Player.B = Null;
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

	



		Event Player.SoldierAllKillStreaks = Array(Array(3, Custom String("UAV Recon")), Array(5, Custom String("Care Package")), Array(8, Custom String("Tactical Visor")), Array(20, Custom String("Tactical Nuke")), Array(1, Custom String("AC-130")));

	
		Event Player.Soldier76KillStreaksEquipped = Array(Value In Array(Event Player.SoldierAllKillStreaks, 0), Value In Array(Event Player.SoldierAllKillStreaks, 1), Value In Array(Event Player.SoldierAllKillStreaks, 2), Value In Array(Event Player.SoldierAllKillStreaks, 4), Value In Array(Event Player.SoldierAllKillStreaks, 3));

		Event Player.SoldierKillStreakTexts = Empty Array;

	
		Event Player.Soldier76KillStreaksActive = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksEquipped), 1);
		Modify Player Variable(Event Player, Soldier76KillStreaksActive, Append To Array, false);

		End;

		Event Player.B = Hero(Soldier: 76);


	

		

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


	
		Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), -1, Value In Array(Event Player.Soldier76Variables, 6), Forward);
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






rule("sombra: za warudo")
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
		Has Status(Event Player, Hacked) == False;
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Set Projectile Speed(All Players(All Teams), 0);
		Create Effect(All Players(All Teams), Sphere, Color(Purple), Event Player, Event Player.S, Visible To Position and Radius);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player, 200);
		Pause Match Time;
		Global.T = True;
		Global.TimeStopTimer = 5;
		Big Message(All Players(All Teams), Custom String("Sombra has hacked time to a still!"));
		Event Player.S = 1;
		Event Player.CustomUltReadyToUse = False;
		Create HUD Text(All Players(All Teams), Global.TimeStopTimer, Null, Null, Top, 0, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
	
		Wait(Global.TimeStopTimer, Ignore Condition);
		Call Subroutine(ResetSombra);
	}
}



rule("sombra: reset")
{
	event
	{
		Subroutine;
		ResetSombra;
	}

	actions
	{
	
		Global.T = False;
		Event Player.S = 0;
		Event Player.Y = False;
		Unpause Match Time;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Projectile Speed(All Players(All Teams), 100);
		Play Effect(All Players(All Teams), Debuff Impact Sound, Color(White), Event Player, 200);
		Set Gravity(All Players(All Teams), 100);
		Destroy HUD Text(Last Text ID);
		Set Ultimate Charge(Event Player, 0);
	}
}






rule("sombra: stun players and stop horizontal movement")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Global.T == True;
		Hero Of(Event Player) != Hero(Sombra);
	}

	actions
	{
		Set Gravity(Event Player, 10);
		Set Status(Event Player, Null, Stunned, 9999);
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
	}
}



rule("sombra: stop players from falling")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Global.T == True;
		Hero Of(Event Player) != Hero(Sombra);
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



rule("sombra: clear stun status after time stop is over and damage players")
{

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Global.T == False;
		Hero Of(Event Player) != Hero(Sombra);
	}

	actions
	{
		Allow Button(Event Player, Button(Ultimate));
		Clear Status(Event Player, Stunned);
		Clear Status(Event Player, Unkillable);
		disabled Clear Status(Event Player, Hacked);
		disabled Clear Status(Event Player, Rooted);
		disabled Allow Button(Event Player, Button(Primary Fire));
		disabled Allow Button(Event Player, Button(Secondary Fire));
		disabled Allow Button(Event Player, Button(Crouch));
		disabled Allow Button(Event Player, Button(Interact));
		disabled Stop Facing(Event Player);
		Wait(0.016, Ignore Condition);
		Skip If(Event Player.O == Null, 5);
		Damage(Event Player, Event Player.O, Event Player.N);
		disabled Set Ultimate Ability Enabled(Event Player.O, True);
		Set Ultimate Charge(Event Player.O, 0);
		Event Player.N = Null;
		Event Player.O = Null;
	}
}



rule("sombra: timer")
{
	event
	{
		Ongoing - Global;
	}

	conditions
	{
		Global.T == True;
	}

	actions
	{
		Wait(1, Ignore Condition);
		Global.TimeStopTimer -= 1;
		Loop If Condition Is True;
	}
}



rule("sombra: store damage dealt during time stop")
{
	event
	{
		Player Dealt Damage;
		All;
		Sombra;
	}

	conditions
	{
	
		Global.T == True;
	}

	actions
	{
		disabled Wait(0.016, Ignore Condition);
		Victim.N += Event Damage;
		Heal(Victim, Null, Event Damage);
		Victim.O = Event Player;
	}
}



rule("sombra: za warudo effect")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sombra;
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



rule("sombra: za warudo effect 2")
{
	event
	{
		Ongoing - Each Player;
		All;
		Sombra;
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
		Destroy Effect(Last Created Entity);
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
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Event Player.G = 20;
		Chase Player Variable At Rate(Event Player, G, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("Use Ultimate Ability"), Event Player.G, Null, Top, 3, Color(Blue), Color(White), Color(
			White), Visible To and String, Default Visibility);
		Event Player.UsingCustomUlt = True;
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Wait(Event Player.G, Ignore Condition);

		Call Subroutine(ResetSymmetra);
	}
}



rule("Symmetra reset")
{
    
	event
	{
		Subroutine;
		ResetSymmetra;
	}

	actions
	{
		
	
		Destroy HUD Text(Last Text ID);
		Destroy Effect(Global.R);
		Destroy Effect(Global.S);
		Global.P = Null;
		Global.Q = Null;
		Destroy Effect(Global.GreenPortal);
		Destroy Effect(Global.W);
		Global.YellowPortalRaycast = Null;
		Global.GreenPortalRaycast = Null;
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Event Player.UsingCustomUlt = Null;
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
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
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.R == Null, 2);
		Destroy Effect(Global.R);
		Global.R = 0;
		Global.P = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + -17, Z Component Of(Facing Direction Of(Event Player))
			* 1000), All Players(All Teams), Event Player, True);
		Global.P -= Facing Direction Of(Event Player);
		Global.SymmetraBluePNormal = Ray Cast Hit Normal(Event Player, Global.P + Facing Direction Of(Event Player), All Players(All Teams), Event Player, True);
	
	
		Play Effect(All Players(All Teams), Good Explosion, Color(Blue), Global.P, 3);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Global.P, 20);
		Wait(0.200, Ignore Condition);
		Create Effect(All Players(All Teams), Ring, Color(Blue), Global.P, 2, Visible To Position and Radius);
		disabled Event Player.UsingCustomUlt += 1;
		Global.R = Last Created Entity;
		Wait(0.500, Ignore Condition);
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
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Skip If(Global.S == Null, 2);
		Destroy Effect(Global.S);
		Global.S = 0;
		Global.Q = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + -17, Z Component Of(Facing Direction Of(Event Player))
			* 1000), All Players(All Teams), Event Player, True);
		Global.Q -= Facing Direction Of(Event Player);
		Global.SymmetraRedPNormal = Ray Cast Hit Normal(Event Player, Global.Q + Facing Direction Of(Event Player), All Players(All Teams), Event Player, True);
	
	
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
		Event Player.CustomUltReadyToUse == True;
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
		Event Player.CustomUltReadyToUse == True;
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
	}

	actions
	{

		Call Subroutine(UseCustomUlt);
	
		Create Dummy Bot(Hero(Torbjörn), Team Of(Event Player), -1, Event Player + Facing Direction Of(Event Player), Facing Direction Of(Event Player));
		Event Player.TorbTurret = Last Created Entity;

		Set Projectile Gravity(Event Player.TorbTurret, 0);
		Set Projectile Speed(Event Player.TorbTurret, 1000);
	
		Set Max Health(Event Player.TorbTurret, 500);
		Set Gravity(Event Player.TorbTurret, 1000);
		Set Knockback Received(Event Player.TorbTurret, 0);
		Event Player.TorbTurret.TorbTurretLevel = 1;
		Wait(0.5, Ignore Condition);
		Create In-World Text(All Players(All Teams), Custom String("Turretbjörn Lvl 1"), Event Player.TorbTurret + Up*2, 1, Clip Against Surfaces, Visible to and String, Team Of(Event Player), Default Visibility);
		Event Player.TorbTurret.TorbTurretLevelText = Last Text Id;
	
		Call Subroutine(StopUsingCustomUlt);
		Event Player.B = Hero(Torbjörn);
		
	
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
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Create Effect(All Players(All Teams), Energy Sound, Color(White), Event Player, 200, Visible To Position and Radius);
		Event Player.UsingCustomUlt = True;
		Start Forcing Throttle(Event Player, 1, 1, 0, 1, 0, 1);
		Set Move Speed(Event Player, 6000);
		Wait Until(Is Dead(Event Player), 5);
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
		Set Move Speed(Event Player, 100);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Forcing Throttle(Event Player);
		Event Player.UsingCustomUlt = False;
		Destroy Effect(Last Created Entity);
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
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Damage(Players Within Radius(Event Player, 1.500, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 500);
		Play Effect(All Players(All Teams), Good Explosion, Team Of(Event Player), Position Of(Event Player) + Backward, 1);
		Loop If Condition Is True;
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
	
	
		Event Player.B = Hero(Winston);
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
		Event Player.B = Null;

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
		Event Player.B = 0;
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
		Set Status(Event Player.P, Event Player, Asleep, 6);
		End;
		Stop Forcing Throttle(Event Player.P);
		Stop Camera(Event Player);
		Event Player.P = Null;
		Set Move Speed(Event Player, 100);
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

