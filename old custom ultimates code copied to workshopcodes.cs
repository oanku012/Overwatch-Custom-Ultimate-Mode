settings
{
    //MAYBE SET SOME OF THE ULTIMATES TO HAVE INFINITE TIMER, BUT END WHEN ULT ENDS WITH WAIT UNTIL
//SHOULD MAYBE ACCOUNT FOR THE FACT THAT PEOPLE JOIN MID-MATCH AND SOME OF THE VARIABLES MIGHT NOT BE SET FOR THEM IF AN ULT IS BEING USED
//Could maybe just manually set exceptions for gravity and other stat altering stuff that might conflict with other ultimates
//WHAT IF JUNKER QUEEN LEAVES MATCH WHILE USING ULT??? DO THE ENEMY PLAYERS STAY UP IN THE AIR???
//OPTIMIZE CODE AT SOME POINT, MAYBE MAKE LOOPS LESS FREQUENT WHEN IT'S NOT NECESSARY, Someone on reddit https://www.reddit.com/r/OverwatchCustomGames/comments/dtr1t2/how_do_i_get_my_custom_game_to_stop_crashing/ had some nice tips like putting less heavy condition checks first on a list

//PROBABLY SHOULD MAKE MOST OF THE EVENTS ONLY APPLY FOR THE HERO THAT USE THEM SO THEY WON'T BE CHECKED EVERY TICK, THE PROBLEM WITH THAT IS JUST THAT THE EVENT MAY STOP WHEN SWITCHING HERO SO MIGHT HAVE TO COME UP WITH SOME WAY TO WORK AROUND THAT

/*damn, F. what i can tell you right now at least is that one very common source of server load are effects, so if you're constantly creating and destroy a ton of effects, you may want to find more efficient methods for using effects such as using array tricks with the visibility, or simply opting for dummy bots to simulate projectile attacks or whatever.

another thing is to look out for conditions that are overly complicated in "ongoing - each player" rules, as those conditions are reevaluated for every single ingame tick to check when they become true/false. if u order the conditions in your list such that the less complicated conditions are at the top, the reevaluation "short circuits" faster when they hit a less load-heavy condition that returns false and that can help with server load.

one very big contributor to server load as well would be large arrays. now that the variable limit has been expanded to 128, i recommend not using arrays wherever its unnecessary and opt for single variable values instead. it might make your code look messier but the difference in server load can be pretty significant. if you have no choice but to use arrays, id recommend trying to cut down their sizes as much as you can before you have to sacrifice too much gameplay fluidity.

one very common trick lots of workshoppers use to reduce server load is to pepper your actions with a bunch of waits. they can be short like 0.03 or as long as 0.25, but having waits in rules that execute a butt ton of actions within a single tick will help you tremendously with server load, as it spreads the cpu burden accross more ingame ticks as opposed to having them all run at once. apparently wait(0.016) can be quite stressing on the server load still, so you cant make your waits too short. really, the longer the better, so u can just experiment around and find what works. this also applies to waits in loops.

finally, of course, nothing will beat cleaning up server load better than simply figuring out how to optimise your script in general. if you can find a way to rewrite a rule with less rules, or with less operation-heavy values, then do. it might sound tough but if you consult some people for help or just re-read old rules carefully you're bound to find new ways to more efficiently code for one thing or another.

good luck with your mode!*/


	main
	{
		Description: "Overpowered custom-made ultimates for each hero. Currently only supports team-based modes and 1 of each hero per team."

		Mode Name: "Wacky OP ultimates"
		
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
			//Game Mode Start: Immediately
			Respawn Time Scalar: 50%
		}

		/*Control
		{
			Score To Win: 1
			Scoring Speed Modifier: 10%
		}*/

		Skirmish
		{
			enabled maps
			{
				//Colosseo 0
				Workshop Island 0
				//Workshop Expanse 0
			}
		}

		disabled Team Deathmatch
		{
			Game Length In Minutes: 5
			Score To Win: 1
		}

		/*Push
		{

		}*/
	}

	heroes
	{
		Team 1
		{
			Ultimate Generation: 500%
			Ultimate Generation - Combat: 500%
			Ultimate Generation - Passive: 500%
            //Health: 500%
			//Movement Speed: 300%
            Spawn With Ultimate Ready: On
            //Ultimate Duration: 200%
			//Infinite Ultimate Duration: On
		}

		Team 2
		{
			Ultimate Generation: 500%
			Ultimate Generation - Combat: 500%
			Ultimate Generation - Passive: 500%
            Spawn With Ultimate Ready: On

			//Ultimate Ability: Off
            //Health: 500%
			//Damage Received: 10%
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
				//Configuration: Tank Weapon Knockback Scalar: 400%
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

			/*Torbjörn
			{
				Infinite Ultimate Duration: On
				Ultimate Duration: 500%
			}*/

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
				//Ana
				Ashe
				Baptiste
				Bastion
				//Echo
				//Junker Queen
				Hanzo
				Junkrat
				Kiriko
				Lifeweaver
				Lúcio
				Ramattra
				//Orisa
				//Sigma
				//Sombra
				//Torbjörn
				
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

variables
{
	global:
		2: Team1Soldier
		3: Team2Soldier
		26: Team1Bap
		27: Team2Bap
		28: Team1OrisaShield
		29: Team2OrisaShield
		30: Team1OrisaShieldPosition
		31: Team2OrisaShieldPosition
		32: Team1OrisaDamageModification
		33: Team2OrisaDamageModification
		34: SymmetraBluePNormal
		35: SymmetraRedPNormal
		36: SymmetraGreenPNormal
		37: SymmetraYellowPNormal
		38: UltingSigmas
		39: NukeTimer
		40: NukeText
		41: ForLoopIndexGlobal
		42: NukeRadius
		43: NukingPlayer
		44: NukePosition
		45: TimeStopTimer
		46: GreenPortal
		47: YellowPortalRaycast
		48: GreenPortalRaycast

	player:
		2: ExtraLife
		4: UsingCustomUlt
		25: CustomUltReadyToUse
		26: BapBeam
		27: UltEffect
		28: UltingEnemyMcCree
		//29: McCreeUltBlind
		//30:	McCreeDPS
		//31:	McCreeUltProxDMG
		32: UltDescription
		33: UltReadyText
		34: EnemyMei
		35: Coronavirus
		36: CoronavirusEffect
		37: CoronavirusText
		38: HasDiedWithCoronaVirus
		39: MercyExtraLifeText
		40: CoronavirusDamageDebuff
		41: ExtraLifeInWorldText
		42: OrisadamageModOutsideShield
        43: WidowRayCastForward
        44: WidowRayCastBackward
        45: WidowRayCastStartPos
        46: WidowRayCastEndPos
        47: WidowDamage
        48: WidowZoomedIn
        //Reload wait no longer in use so could probably remove these later if I'm running out of variables
        49: WidowReloadWait
        50: WidowReloadWaitTime
        51: WidowRayCastHeadForward
        52: WidowRayCastHeadBackward
        53: WidowAimBeam
        54: WidowFireBeam
        55: WidowLastFacingDirection
        56: BastionPos
        57: SojournLastRay
        58: SojournBeamArray
        59: SojournDamageRay
        60: SojournRayArray
        61: SojournEyePosArray
        62: SojournLastEyePos
        63: OrisaScale
		64: JunkratBombOrb
		65: JunkratTimer
		66: JunkratTimerAboveHead
		67: JunkratTimerHUD
		68: JunkratExplosionRadius
		69: JunkratBombPosition
		70: JunkratRadiusRing
		71: InPortalFacingDirection
		72: InPortalSpeed
		73: RoadhogHUD
		74: BrigitteUltActive
		75: BrigitteKnockedBack
		76: WidowPlayersInViewAngleSorted
		77: WidowViewAngleDebugText
		78: TorbTurret
		79: TorbTurretLevelText
		80: TorbTurretLevel
		81: TorbUltPositions
		82: TorbUltIndex
		83: EchoDummyBots
		84: EchoAimRayCast
		85: EchoEffects
		//86: LucioPlayersWithinRadius
		//Use this with for player variable loops, set to null after use
		86: ForLoopIndexPlayer
		87: LucioEmotesArray
		88: SigmaMaleValues
		89: SigmaMaleTimer
		90: SigmaHighGravDebuff
		91: SigmaZeroGravBuff
		92: CurrentGravities
		93: CurrentSpeeds
		94: SigmaDebuffGravityScale
		95: WinstonGrabbing
		96: TorbCurrentTarget
		97: JunkerQueenEnemyArray
		98: JunkerQueenInArena
		99: JunkerQueenHealthPools
		100: JunkerQueenPositions
		101: JunkerQueenEnemyPositions
		102: JunkerArenaSphere
		103: JunkerDamageMods
		104: JunkerRageEffects
		105: JunkerWinCounterText
		106: JunkerDamageCounter
		107: JunkerWinCounter
		108: DVAVariables
		109: MenuOptions
		110: MenuOpen
		111: MenuHUDOptions
		112: MenuHUDChooseSort
		113: MenuChosenOption
		114: JunkerPreviousHero
		115: ReaperVariables
		//Always set this shit to null after use
		116: LocalVariable
		117: Soldier76Variables
		118: Soldier76CarepackLocation
		119: Soldier76KillStreaksActive
		120: SoldierCarePackAmmoIndex
		121: ReaperTPPos
		122: Soldier76KillStreaksEquipped
		123: SoldierUAVPlayersAndIcons
		124: SoldierAllKillStreaks
		125: SoldierKillStreakTexts
		126: ReinhardtHudText
		127: JunkerReadyToTeleport
		//114: DVaCooldown
		//74: BrigitteHealthPoolCapacity
		//75: BrigitteHealthPool
		//73: PortalIntangible
		
}




subroutines
{
    0: UseCustomUlt
    1: StopUsingCustomUlt
	2: CreateMenu
	//3: 
	4: ResetBrigitte
	5: ResetCassidy
	6: ResetDVa
	//As of now Doomfist reset seems unnecessary when changing heroes, but should maybe have to make sure. Maybe the additional meteor strike type effects might break if the ult ends abruptly idk.
	7: ResetDoomfist
	8: ResetEcho
	9: ResetGenji
	10: ResetJQ
	11: ResetJunkrat
	12: ResetMei
	//13: ResetMercy
	14: ResetMoira
	//15: ResetOrisa
	16: ResetPharah
	17: ResetReaper
	18: ResetReinhardt
	19: ResetRoadhog
	20: ResetSigma
	21: ResetSojourn
	22: ResetSoldier
	23: ResetSombra
	24: ResetSymmetra
	25: ResetTorb
	26: ResetTracer
	27: ResetWidow
	28: ResetWinston
	29: ResetWB
	30: ResetZarya
	31: ResetZenyatta
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
		//(Event Player.CustomUltReadyToUse == True || Event Player.UsingCustomUlt == True) == True;
		//Event Player.CustomUltReadyToUse == True;
		
	}

	actions
	{

		/*Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Set Ultimate Ability Enabled(Event Player, True);
		//Event Player.B = Null;
		Event Player.CustomUltReadyToUse = False;
		Event Player.UsingCustomUlt = Null;
		Stop Chasing Player Variable(Event Player, G);
		Event Player.G = 0;
		Destroy HUD Text(Last Text ID);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Damage Dealt(Event Player, 100);
		Set Max Health(Event Player, 100);
		Destroy Effect(Event Player.Y);
		Event Player.Y = 0;
		Stop Camera(Event Player);*/
		Big Message(Event Player, Custom String("AAAA"));

		//Call Subroutine(StopUsingCustomUlt);

		//Brigitte didn't really need this, because she switches her hero during her ult so the event needs to happen on all players
		//if(Event Player.B == Hero(Brigitte));
		//Call Subroutine(ResetBrigitte);

		//Could maybe add some wait actions between checks so it's less stuff to check in one frame

		//Supposedly if else checks are "more expensive" than.. I guess checking stuff in conditions?? I'm not sure, but it was mentioned here: https://workshop.codes/wiki/articles/help-my-server-is-crashing-a-guide-on-how-to-improve-server-stability-for-your-codes#too-many-conditions

		//Event player.B is also set in the disable vanilla ult event so don't have to set it separately for every hero
		//The stopusingcustomult subroutine might do some unnecessary stuff for some heroes so could maybe cut out any fluff from it that isn't necessary for every hero with a custom ult.
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
		End;

		Event Player.B = Null;


	}
}


disabled rule("Player joined match.")
{
    //Check if this triggers at the start of the match. Maybe set some variables here for when characters are ulting. Could also just make this into ongoing without any conditions??? Does it only trigger once??
    //Sometimes adding and subtracting from the variables doesn't really work with sigma's ult so could maybe just set speeds and gravity to hard values

	event
	{
		Player Joined Match;
		All;
		All;
	}

	conditions
	{
		
	}

	actions
	{
		//All Players(All Teams), (Current Array Element.CurrentGravities != null)).CurrentGravities = Array(100, 100);
		Event Player.CurrentGravities = Array(100, 100);
		Event Player.CurrentSpeeds = Array(100, 100, 100);
		//Event Player.SigmaHighGravDebuff = Empty Array;
		Big Message(Event Player, Custom String("Player joined match."));

		//Set Projectile Gravity(Event Player, 500);
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
		//Is Using Ultimate(Event Player) == True;
		//Hero Of(Event Player) == Hero(Ana);
	}

	actions
	{
		//Player Closest To Reticle(Event Player, Team Of(Event Player)).A = True;

        //Event Player.B = Sorted Array(All Living Players(Team Of(Event Player)), Absolute Value(Angle Difference(Horizontal Facing Angle Of(Event Player) + Vertical Facing Angle Of(Event Player), Horizontal Angle From Direction(Direction Towards(Event Player, Current Array Element)) + Vertical Angle From Direction(Direction Towards(Event Player, Current Array Element)))));

		//Event Player.B = Healee;

		Healee.A = True;

		//Event Player.B = Player Closest To Reticle(Event Player, Team Of(Event Player));
		
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
		//Big Message(Event Player, Ability Cooldown(Event Player, Button(Ability 2)));

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
//Scaling barriers might be broken? https://us.forums.blizzard.com/en/overwatch/t/will-anyone-ever-notice-that-the-scale-barrier-function-is-broken/557983 Seemed to work for me though when playing against AI brigitte


	event
	{
		//This needs to be on all players, because Brigitte switches hero briefly to Ana during this event
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Brigitte);
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		//THIS SOLUTION MAY NOT WORK IF PLAYERS CHANGE MID-MATCH, SHOULD USE GLOBAL VARIABLES?? OR MAYBE LOOP THIS WHILE BRIGITTE ULTS, SHOULD CHECK THIS FOR OTHER ULTS AS WELL
		All Players(Opposite Team Of(Team Of(Event Player))).D = Event Player;
		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player) - Facing Direction Of(Event Player)*10), Update Every Frame(Eye Position(Event Player)), 0);
		 //+ Up*10 for camera from upwards
		Set Ability 1 Enabled(Event Player, False);
		Set Ability 2 Enabled(Event Player, False);
		//Set Status(Event Player, Event Player, Invincible, 1);
		//Set Status(Event Player, Event Player, Frozen, 1);
		
		//Heal(Event Player, Null, Max Health(Event Player));
		//This is just to work around a bug with brigitte's shield not scaling properly from health
		//Start Forcing Player To Be Hero(Event Player, Hero(Brigitte));
		//Stop Forcing Player To Be Hero(Event Player);
		//Set Max Health(Event Player, 100);
		//
		Event Player.BrigitteUltActive = true;
		//Set Ultimate Ability Enabled(Event Player, False);
		Set Max Health(Event Player, Max Health(Event Player) * 5);
		//Set Player Health(Event Player, Max Health(Event Player));


		//Set Max Health(Event Player, Max Health(Event Player) * 5);

		Start Forcing Player To Be Hero(Event Player, Hero(Ana));
		Start Forcing Player To Be Hero(Event Player, Hero(Brigitte));
		Stop Forcing Player To Be Hero(Event Player);

		Start Holding Button(Event Player, Button(Secondary Fire));

		Press Button(Event Player, Button(Ultimate));

		//Event Player.B = Hero Of(Event Player);

		Wait(0.016, Ignore Condition);


		Start Scaling Barriers(Event Player, 15, False);

		//

		//Start Forcing Player To Be Hero(Event Player, Hero(Brigitte));
		

		//Could use this wait until thing with other heroes too. Could be convenient
		Wait Until((Is Dead(Event Player) == true || Hero Of(Event Player) != Hero(Brigitte)) == true, 10);
		Call Subroutine(ResetBrigitte);
		/*Set Ultimate Ability Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);
		Event Player.BrigitteUltActive = Null;
		//Start Scaling Barriers(Event Player, 1, False);
		Stop Scaling Barriers(Event Player);
		Stop Camera(Event Player);
		Set Max Health(Event Player, 100);
		Stop Holding Button(Event Player, Button(Secondary Fire));
		//Start Forcing Player To Be Hero(Event Player, Hero(Ana));
		//Start Forcing Player To Be Hero(Event Player, Hero(Brigitte));
		//Stop Forcing Player To Be Hero(Event Player);
		All Players(Opposite Team Of(Team Of(Event Player))).D = Null;*/
		




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
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);
		Event Player.BrigitteUltActive = Null;
		//Stop scaling probably stops all other scaling as well if such a thing might exist at some point
		//Start Scaling Barriers(Event Player, 1, False);
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
		//Create Hud Text(Event Player.D, Hero Icon String(Hero Of(Event Player)), Vertical Facing Angle Of(Event Player.D) + 90, Null, Left, 0, Color(Yellow), Color(Yellow), Color(Yellow), Visible To And String, Default Visibility);

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
		//Create Hud Text(Event Player.D, Hero Icon String(Hero Of(Event Player)), Vertical Facing Angle Of(Event Player.D) + 90, Null, Left, 0, Color(Yellow), Color(Yellow), Color(Yellow), Visible To And String, Default Visibility);

		Apply Impulse(Event Player, Direction From Angles(Horizontal Facing Angle Of(Event Player.D), -20), 30, To World, Cancel Contrary Motion);
		Damage(Event Player, Event Player.D, 150);
		Event Player.BrigitteKnockedBack = True;
		Wait(2, Restart When True);
		Event Player.BrigitteKnockedBack = null;
	}
}







rule("torb: spawn torb turret")
{
//Could maybe try to give credit for torb turret's damage to the player. Just adding 1 damage would give hitmarks, but wouldn't be accurate for ult charge and such without the full damage.

	event
	{
		Ongoing - Each Player;
		All;
		TorbjöRn;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Torbjörn);
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
		//Create Dummy Bot(Hero(Torbjörn), Team Of(Event Player), 7, Event Player + Facing Direction Of(Event Player), Facing Direction Of(Event Player));
		Create Dummy Bot(Hero(Torbjörn), Team Of(Event Player), -1, Event Player + Facing Direction Of(Event Player), Facing Direction Of(Event Player));
		Event Player.TorbTurret = Last Created Entity;

		Set Projectile Gravity(Event Player.TorbTurret, 0);
		Set Projectile Speed(Event Player.TorbTurret, 1000);
		//Set Max Ammo(Event Player.TorbTurret, 0, 100000);
		Set Max Health(Event Player.TorbTurret, 500);
		Set Gravity(Event Player.TorbTurret, 1000);
		Set Knockback Received(Event Player.TorbTurret, 0);
		Event Player.TorbTurret.TorbTurretLevel = 1;
		Wait(0.5, Ignore Condition);
		Create In-World Text(All Players(All Teams), Custom String("Turretbjörn Lvl 1"), Event Player.TorbTurret + Up*2, 1, Clip Against Surfaces, Visible to and String, Team Of(Event Player), Default Visibility);
		Event Player.TorbTurret.TorbTurretLevelText = Last Text Id;
		Call Subroutine(StopUsingCustomUlt);
		//Set Damage Dealt(Event Player.TorbTurret, 200);
		Wait Until(Is Dead(Event Player.TorbTurret) == true || Hero Of(Event Player) != Hero(Torbjörn) || (Event Player.CustomUltReadyToUse == True && Is Button Held(Event Player, Button(Ultimate)) == True && Event Player.UsingCustomUlt == Null && Has Status(Event Player, Hacked) == False && Hero Of(Event Player) == Hero(Torbjörn) && (Event Player.TorbTurret == null || Is Button Held(Event Player, Button(Crouch)) == True) == true), 10000);
		Destroy In-World Text(Event Player.TorbTurret.TorbTurretLevelText);
		Event Player.TorbTurret.TorbTurretLevelText = Null;
		//Destroy Dummy Bot(Team Of(Event Player), 7);
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Event Player.TorbTurret));

		Event Player.TorbTurret = Null;
		
		Loop If Condition Is True;
	}
}


rule("torb: overload turret to level 2")
{

    //Maybe should just make this work by beating it with the hammer enough when it's at full health. Ult could be used to reposition turret. Maybe even add a whole scrap system for upgrading the turret.
//Currently works so that when you crouch and press ult it will reposition the turret, but if you just ult again it will upgrade
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
		//Is Button Held(Event Player, Button(Crouch)) == True;
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
		//Is Button Held(Event Player, Button(Crouch)) == True;
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
		//Event Player.UsingCustomUlt == Null;
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



rule("Echo activate ultimate")
{
//Needs to be set to all players apparently, because otherwise the effects persist after ult is over. The other events seem to work just fine when set to echo only though.

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		//Is Using Ultimate(Event Player) == True;
		//Hero Of(Event Player) == Hero(Echo);
		Is Duplicating(Event Player) == True;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		//Wait slightly before spawning so that we get the raycast aiming position first
		Wait(0.1, Ignore Condition);
		Start Camera(Event Player, Update Every Frame(Eye Position(Event Player) - Facing Direction Of(Event Player) * 2 + Up*0.5), Update Every Frame(Eye Position(Event Player) + Facing Direction Of(Event Player) * 2 + Up*0.5), 0);

		//Could maybe just spawn these to -1 slots as in the first available slot so that you can have multiple echo players in the same team
		//Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), 5, Event Player + Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player + Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), -1, Event Player + Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player + Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
		Event Player.EchoDummyBots = Array(Last Created Entity);
		//Create Dummy Bot(Hero Being Duplicated(Event Player), Team Of(Event Player), 6, Event Player - Cross Product(Facing Direction Of(Event Player), Up), Direction Towards(Event Player - Cross Product(Facing Direction Of(Event Player), Up), Event Player.EchoAimRayCast));
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

		//Create HUD Text(Event Player, Event Player.EchoAimRayCast, Null, Null, Top, 0, Color( Yellow), Color(White), Color(White), Visible To and String, Default Visibility);
		//Create Effect(Event Player, Sphere, Color(Blue), Event Player.EchoAimRayCast, 1, Position and Radius);

		Event Player.B = Hero Of(Event Player);

		Wait Until((Is Dead(Event Player) == true || Is Duplicating(Event Player) == false) == true, 9999);
		Call Subroutine(ResetEcho);
		/*Destroy Dummy Bot(Team Of(Event Player), 5);
		Destroy Dummy Bot(Team Of(Event Player), 6);
		Destroy Effect(Event Player.EchoEffects);
		Event Player.EchoEffects = Null;
		Event Player.EchoDummyBots = Null;
		Event Player.EchoAimRayCast = Null;
		Stop Camera(Event Player);*/
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
		//Destroy Dummy Bot(Team Of(Event Player), 5);
		//Destroy Dummy Bot(Team Of(Event Player), 6);
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
		//Is Button Held(Event Player, Button(Ultimate)) == true;
		Is Using Ultimate(Event Player) == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		//If(Ultimate Charge Percent(Event Player) == 100);
		Set Ultimate Charge(Event Player.EchoDummyBots, 100);
		//End;

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
//Is communicating returns false??
//May have been fixed now?
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
		//Big Message(Event Player, Custom String("AAAAAAAAAAA"));
		Skip If(Is Communicating(Event Player.EchoDummyBots, Hello) == True, 1);
		Communicate(Event Player.EchoDummyBots, Hello);
		Loop If Condition Is True;
		
	}
}



rule("winston: using ultimate")
{
//Could add an extra health pool to winston too

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Winston);
		Is Dummy Bot(Event Player) == false;
	}

	actions
	{
		Event Player.G = True;
		Start Scaling Player(Event Player, 2, false);
		Wait Until(Is Using Ultimate(Event Player) != true || Hero Of(Event Player) != Hero(Winston) || Is Dead(Event Player) == true, 50);
		Event Player.G = False;
		//Start Scaling Player(Event Player, 1, false);
		Stop Scaling Player(Event Player);
		Detach Players(Event Player.WinstonGrabbing);
		Event Player.WinstonGrabbing = Null;


	}
}

rule("winston: grab an enemy")
{
//Grab breaks from teleportation (like with reaper's ult). I wonder if the variable should be set for the grabbed player instead, because I'm not sure how the Winston player could detect the other player teleporting away. Maybe a distance and view angle check ??

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Winston);
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
		Filtered Array(All Players(Opposite Team Of(Team Of(Event Player))), Is In View Angle(Event Player, Current Array Element, 35) == true && Distance Between(Event Player, Current Array Element) < 5) != Empty Array;
		//Players Within Radius(Event Player, 5, All Teams, Surfaces) != null;
		//Players in View Angle(Event Player, All Teams, 40) != Null;
		Event Player.WinstonGrabbing == Null;
	}

	actions
	{
		
		//Attach Players(Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), Event Player, Vector(0, 1.5, 2));
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
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Winston);
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Primary Fire)) == True;
		Event Player.WinstonGrabbing != Null;
	}

	actions
	{
		Detach Players(Event Player.WinstonGrabbing);
		Apply Impulse(Event Player.WinstonGrabbing, Facing Direction Of(Event Player), 50, To World, Cancel Contrary Motion);
		//Just to make sure the wall hitting rule triggers when the enemy is thrown
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
		All;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Winston);
		Is Dummy Bot(Event Player) == false;
		Event Player.WinstonGrabbing != Null;
		Is Dead(Event Player.WinstonGrabbing) == True;
	}

	actions
	{
		Detach Players(Event Player.WinstonGrabbing);
		Event Player.WinstonGrabbing = Null;
		//Big Message(All Players(All Teams), Custom String("Victim died"));


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
		Event Player.G == True;
	}

	actions
	{
		Victim.J = Event Player;

		Victim.I = Direction Towards(Event Player, Victim);


		Wait(0.01, Ignore Condition);

		
		Set Status(Victim, Event Player, Rooted, 1);
		Victim.H = Speed Of In Direction(Victim, Victim.I);


		/*Wait(0.010, Ignore Condition);
		//Set Move Speed(Victim, 10);
		Set Status(Victim, Event Player, Rooted, 1);
		Victim.I = Direction Towards(Event Player, Victim);
		Victim.H = Speed Of In Direction(Victim, Victim.I);
		Victim.J = True;
		Wait(0.250, Ignore Condition);
		Victim.H = Speed Of In Direction(Victim, Victim.I);
		Wait(0.250, Ignore Condition);
		Victim.H = Speed Of In Direction(Victim, Victim.I);
		Wait(0.250, Ignore Condition);
		Victim.J = False;
		//Set Move Speed(Victim, 100);*/
	}
}

rule("winston: check player speed through the air after being knocked back.")
{
//The frequency of checking could still need some adjustment. The stun often doesn't applied when hitting enemy too close to a wall, since the wait timer has ignore condition, maybe it executes even if the enemy has already hit a wall?? Landing on ground without being stunned seems to work fairly well now.

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	//MAYBE SET EVENT PLAYER.J AS THE WINSTON THAT DAMAGED THEM?
	conditions
	{
		Event Player.J != Null;
	}

	actions
	{
		Wait(0.1, Ignore Condition);
		Event Player.H = Speed Of In Direction(Event Player, Event Player.I);
		Loop If(Event Player.J != null && Is Alive(Event Player));
		
		//Big Message(All Players(All Teams), Custom String("YEAAAHH"));
		Event Player.J = null;
		Event Player.I = 0;
		Event Player.H = 0;
	}
}

rule("winston: if speed slows down suddenly(ideally when THE player hits a wall), player will receive damage and a stun.")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	//MAYBE SET EVENT PLAYER.J AS THE WINSTON THAT DAMAGED THEM?
	conditions
	{
		Speed Of In Direction(Event Player, Event Player.I) < Event Player.H / 2;
		Event Player.J != Null;
		Event Player.H > 4;
	}

	actions
	{
		Set Status(Event Player, Null, Stunned, 3);

		//Could maybe try to set the winston as damager here
		Damage(Event Player, Null, 150);
		Event Player.I = 0;
		Event Player.H = 0;
		Event Player.J = Null;
	}
}

rule("winston: if victim is on ground, they won't receive stun or damage.")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is On Ground(Event Player) == True;
		Event Player.J != Null;
	}

	actions
	{
		Event Player.I = 0;
		Event Player.J = Null;
		Event Player.H = 0;

	}
}


rule("Mercy give extra life to herself during Ultimate")
{
    //Maybe add exceptions for certain ultimates when player has extra life. Her regular reviving could also maybe be used to bring players back to junker queen's arena and retain her buffs. Should maybe reset that stuff only when she respawns or switches character.
//Might not have to disable this upon switching hero since the extra life functionality works for other heroes too
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
		//Hero Of(Event Player) == Hero(Moira);
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
		//Has Status(Event Player, Rooted) == True;
		//Hero Of(Event Player) == Hero(Moira);
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Wait(0.100, Ignore Condition);
		
		//These are set multiple times in a loop so that they won't get canceled by other effects like Sigma's gravity. Although could also maybe check separately in those others if certain variables are active and such idk
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
		//Destroy Effect(Last Created Entity);
	}
}



rule("zarya: team 1 uses ultimate")
{
//Seems like it kinda breaks when using ult on a nearby enemy and couldn't move the position forward

	event
	{
		Ongoing - Each Player;
		Team 1;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		//Team Of(Event Player) == Team 1;
		Event Player.CustomUltReadyToUse == True;
		Hero Of(Event Player) == Hero(Zarya);
		Has Status(Event Player, Hacked) == False;
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Event Player.S = 15;
		Event Player.UsingCustomUlt = True;
		Big Message(All Players(All Teams), Hero Icon String(Hero(Zarya)));
		Event Player.CustomUltReadyToUse = False;
		//disabled Global.A = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
		//	* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + 2, Z Component Of(Facing Direction Of(Event Player))
		//	* 1000), All Players(All Teams), Event Player, True);
		//Create Effect(All Players(All Teams), Bad Aura, Color(Purple), Global.A, 4, Visible To Position and Radius);
		//Create Homing Projectile(Zarya Graviton, Event Player, Null, Null, To World, Damage, Remove From Array(All Teams, All Teams), 0, 0, 0, Bad Explosion, Zarya Particle Cannon Explosion Sound, 0, 100, Event Player.S, 0, Global.A, 1);
		Create Projectile Effect(All Players(All Teams), Zarya Graviton, All Players(Team Of(Event Player)), Global.A, Facing Direction Of(Event Player), 0.5, Visible To Position Direction and Size);
		Wait(15, Ignore Condition);
		Event Player.UsingCustomUlt = Null;
		Destroy Effect(Last Created Entity);
		//Destroy Effect(Last Created Entity);
		Set Ultimate Ability Enabled(Event Player, True);
		Clear Status(All Players(Opposite Team Of(Team Of(Event Player))), Rooted);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = Null;
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Wait(0.100, Ignore Condition);
		Stop Accelerating(All Players(Opposite Team Of(Team Of(Event Player))));
		Global.A = Null;
	}
}

rule("zarya: team 2 uses ultimate")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Team Of(Event Player) == Team 2;
		Event Player.CustomUltReadyToUse == True;
		Hero Of(Event Player) == Hero(Zarya);
		Has Status(Event Player, Hacked) == False;
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		Event Player.S = 15;
		Event Player.UsingCustomUlt = True;
		Big Message(All Players(All Teams), Hero Icon String(Hero(Zarya)));
		Event Player.UsingCustomUlt = Null;
		disabled Global.B = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* 1000, Y Component Of(Facing Direction Of(Event Player)) * 1000 + 2, Z Component Of(Facing Direction Of(Event Player))
			* 1000), All Players(All Teams), Event Player, True);
		//Create Effect(All Players(All Teams), Bad Aura, Color(Purple), Global.B, 4, Visible To Position and Radius);
		Create Projectile Effect(All Players(All Teams), Zarya Graviton, All Players(Team Of(Event Player)), Global.B, Facing Direction Of(Event Player), 1, Visible To Position Direction and Size);
		Wait(15, Ignore Condition);
		Destroy Effect(Last Created Entity);
		Destroy Effect(Last Created Entity);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Clear Status(All Players(Opposite Team Of(Team Of(Event Player))), Rooted);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = Null;
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Wait(0.100, Ignore Condition);
		Stop Accelerating(All Players(Opposite Team Of(Team Of(Event Player))));
		Global.B = Null;
	}
}

rule("Zarya move gravity point forward")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Zarya);
		disabled Event Player.CustomUltReadyToUse == True;
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

rule("Zarya move gravity point backward team 1")
{
//Added team 1 and team 2 to the event rules here, they weren't there before, hopefully it won't break anything

	event
	{
		Ongoing - Each Player;
		Team 1;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Zarya);
		disabled Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
		Distance Between(Event Player, Global.A) > 7;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S -= 0.200;
		Loop If Condition Is True;
	}
}

rule("Zarya move gravity point backward team 2")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Zarya);
		disabled Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
		Is Button Held(Event Player, Button(Secondary Fire)) == True;
		Distance Between(Event Player, Global.B) > 7;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Event Player.S -= 0.200;
		Loop If Condition Is True;
	}
}

rule("zarya: team 2 gets pulled into grav")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		All;
	}

	conditions
	{
		Global.A != Null;
		Team Of(Event Player) == Team 2;
		Distance Between(Event Player, Global.A) <= 7;
	}

	actions
	{
		disabled Start Accelerating(Event Player, Direction Towards(Position Of(Event Player), Global.A), 200, 200, To World,
			Direction Rate and Max Speed);
		//Set Status(Event Player, Null, Rooted, 1);
		Wait(0.016, Ignore Condition);
		Apply Impulse(Event Player, Vector Towards(Event Player, Global.A), 10, To World, Cancel Contrary Motion);
		Loop If Condition Is True;
	}
}

rule("zarya: team 1 gets pulled into grav")
{
	event
	{
		Ongoing - Each Player;
		Team 1;
		All;
	}

	conditions
	{
		Global.B != Null;
		Team Of(Event Player) == Team 1;
		Distance Between(Event Player, Global.B) <= 7;
	}

	actions
	{
		disabled Start Accelerating(Event Player, Direction Towards(Position Of(Event Player), Global.B), 200, 200, To World,
			Direction Rate and Max Speed);
		disabled Set Status(Event Player, Null, Rooted, 9999);
		//Set Status(Event Player, Null, Rooted, 1);
		Wait(0.016, Ignore Condition);
		Apply Impulse(Event Player, Vector Towards(Event Player, Global.B), 10, To World, Cancel Contrary Motion);
		Loop If Condition Is True;
	}
}

rule("Zarya team 1set grav point position")
{
	event
	{
		Ongoing - Each Player;
		Team 1;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Global.A = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* Event Player.S, Y Component Of(Facing Direction Of(Event Player)) * Event Player.S + 2, Z Component Of(Facing Direction Of(
			Event Player)) * Event Player.S), Null, All Players(All Teams), True);
		Loop If Condition Is True;
	}
}

rule("Zarya team 2 set grav point position")
{
	event
	{
		Ongoing - Each Player;
		Team 2;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Wait(0.016, Ignore Condition);
		Global.B = Ray Cast Hit Position(Event Player, Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player))
			* Event Player.S, Y Component Of(Facing Direction Of(Event Player)) * Event Player.S + 2, Z Component Of(Facing Direction Of(
			Event Player)) * Event Player.S), Null, All Players(All Teams), True);
		Loop If Condition Is True;
	}
}

rule("Zarya team 1 died")
{
	event
	{
		Player Died;
		Team 1;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Event Player.UsingCustomUlt = Null;
		Destroy Effect(Last Created Entity);
		Destroy Effect(Last Created Entity);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Clear Status(All Players(Opposite Team Of(Team Of(Event Player))), Rooted);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = Null;
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Wait(0.100, Ignore Condition);
		disabled Stop Accelerating(All Players(Opposite Team Of(Team Of(Event Player))));
		Global.A = Null;
	}
}

rule("Zarya team 2 died")
{
	event
	{
		Player Died;
		Team 2;
		Zarya;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		Event Player.UsingCustomUlt = Null;
		Destroy Effect(Last Created Entity);
		Destroy Effect(Last Created Entity);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Clear Status(All Players(Opposite Team Of(Team Of(Event Player))), Rooted);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = Null;
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Wait(0.100, Ignore Condition);
		disabled Stop Accelerating(All Players(Opposite Team Of(Team Of(Event Player))));
		Global.B = Null;
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

		//Could maybe later add other killstreak options and assing them to different numbers that could be "equipped" into this array. Should look into adding changeable settings for workshop mode. 



		Event Player.SoldierAllKillStreaks = Array(Array(3, Custom String("UAV Recon")), Array(5, Custom String("Care Package")), Array(8, Custom String("Tactical Visor")), Array(20, Custom String("Tactical Nuke")), Array(1, Custom String("AC-130")));

		//Could just set this to be the same as SoldierAllKillStreaks, but was thinking I could maybe add some kind of system that lets you unequip and equip different kill streaks. Maybe that would be too much feature creep for just one character
		Event Player.Soldier76KillStreaksEquipped = Array(Value In Array(Event Player.SoldierAllKillStreaks, 0), Value In Array(Event Player.SoldierAllKillStreaks, 1), Value In Array(Event Player.SoldierAllKillStreaks, 2), Value In Array(Event Player.SoldierAllKillStreaks, 4), Value In Array(Event Player.SoldierAllKillStreaks, 3));

		Event Player.SoldierKillStreakTexts = Empty Array;

		//Event Player.Soldier76KillStreaksActive = Array(Array(1, 2, 3), Array(3, 5, 6), Array(4, 6, 7), Array(8, 7, 9));
		Event Player.Soldier76KillStreaksActive = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksEquipped), 1);
		Modify Player Variable(Event Player, Soldier76KillStreaksActive, Append To Array, false);

		End;

		Event Player.B = Hero(Soldier: 76);


		//Wait Until((Is Dead(Event Player) == True && Event Player.ExtraLife != true) || Hero Of(Event Player) != Hero(Soldier: 76), 9999);

		

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
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Alive(Event Player) == True;
	}

	actions
	{
		Value In Array(Event Player.Soldier76Variables, 0) += 1;


		If(Is True For Any(Event Player.Soldier76KillStreaksEquipped, Value In Array(Current Array Element, 0) == Value In Array(Event Player.Soldier76Variables, 0)));


		//Index of array value with nested arrays seems to also count the indexes of the nested arrays so the second element in this array returned 2 and the third one returned 4. Dividing by 2 seems to work to get around it though if the way this works ever gets changed then would have to re-visit this
		Event Player.LocalVariable = Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, First Of(Filtered Array(Event Player.Soldier76KillStreaksEquipped, Value In Array(Current Array Element, 0) == Value In Array(Event Player.Soldier76Variables, 0)))) / 2;

		Value In Array(Event Player.Soldier76KillStreaksActive, Event Player.LocalVariable) = True;

		Big Message(Event Player, String("{0} {1}", Last Of(Value In Array(Event Player.Soldier76KillStreaksEquipped, Event Player.LocalVariable)), Custom String(" ready to deploy!")));
		//Big Message(Event Player, String("{0} {1}", Event Player.LocalVariable, Custom String(" ready to deploy!")));

		Create Hud Text(Event Player, String("{0} {1}", Last Of(Value In Array(Event Player.Soldier76KillStreaksEquipped, Event Player.LocalVariable)), Custom String(" ready to deploy!")), null, null, Left, 0, Color(Blue), Color(Blue), Color(Blue), Visible To, Default Visibility);

		//Modify Player Variable(Event Player, SoldierKillStreakTexts, Append To Array, Last Text Id);
		
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
		//Hero Of(Event Player) == Hero(Soldier: 76);
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

		//Event Player.Soldier76KillStreaksActive = Event Player.Soldier76KillStreaksEquipped;

		//For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksActive), 1);
		//Value In Array(Event Player.Soldier76KillStreaksActive, Event Player.ForLoopIndexPlayer) = 
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
		//Value In Array(Event Player.Soldier76Variables, 0) = 0;

		

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.SoldierKillStreakTexts), 1);
		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Event Player.ForLoopIndexPlayer));
		End;


		Destroy Hud Text(Value In Array(Event Player.Soldier76Variables, 1));

		//Reset UAV

		If(Value In Array(Event Player.Soldier76Variables, 2) != Null);
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Value In Array(Event Player.Soldier76Variables, 2)), 1);
		Destroy Icon(Value In Array(Value In Array(Event Player.Soldier76Variables, 2), Event Player.ForLoopIndexPlayer));
		End;
		
		Value In Array(Event Player.Soldier76Variables, 2) = Null;

		End;

		//Reset care package
		If(Value In Array(Event Player.Soldier76Variables, 5) != Null);
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 5));
		Destroy Effect(Value In Array(Event Player.Soldier76Variables, 4));
		Event Player.Soldier76CarepackLocation = null;
		End;

		//Reset AC-130 
		If(Value In Array(Event Player.Soldier76Variables, 6) != Null);

		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.Soldier76Variables, 7)));
		

		Stop Camera(Event Player);

		//Could maybe make a subroutine out of this
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);

		//This might interfere with some other abilities, but ehh whatever.
		Clear Status(Event Player, rooted);

		Value In Array(Event Player.Soldier76Variables, 6) = Null;
		Value In Array(Event Player.Soldier76Variables, 7) = Null;

		End;

		//I'm not sure if I actually need to set these to null, but gonna do it just in case.
		Event Player.Soldier76Variables = Null;
		Event Player.SoldierAllKillStreaks = Null;
		Event Player.Soldier76KillStreaksActive = Null;
		Event Player.SoldierKillStreakTexts = Null;
		Event Player.Soldier76KillStreaksEquipped = Null;
	}
}

rule("soldier 76 UAV")
{

    
//Could maybe later add some easier way to bind the streaks to different amounts of kills
//Maybe stuff like UAV and care package could persist after death as well since they're not directly tied to soldier himself.
	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		Event Player.Soldier76Variables != Null;
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2) == True;
		//Is True For Any(Event Player.Soldier76KillStreaksActive, Array Contains(Current Array Element, Custom String("UAV Recon")) && Array Contains(Current Array Element, True)) == True;
		//Value In Array(Event Player.Soldier76KillStreaksActive, 0) == Array(3, True);
	}

	actions
	{


		Value In Array(Event Player.Soldier76Variables, 2) = Empty Array;

		//Could remove icons from players when they die??
		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(All Players(Opposite Team Of(Team Of(Event Player)))), 1);
		Create Icon(All Players(Team Of(Event Player)), Value In Array(All Players(Opposite Team Of(Team Of(Event Player))), Event Player.ForLoopIndexPlayer), Skull, Visible To, Color(Red), false);
		Value In Array(Event Player.Soldier76Variables, 2) = Append To Array(Value In Array(Event Player.Soldier76Variables, 2), Last Created Entity);
		End;

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2) = False;
		
		Destroy Hud Text(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 0)) / 2));

		//Destroy Hud Text(First Of(Value In Array(Event Player.SoldierKillStreakTexts, Index Of Array Value(Event Player.SoldierKillStreakTexts, First Of(Filtered Array(Event Player.SoldierKillStreakTexts, Last Of(Current Array Element) == Custom String("UAV Recon")))) / 2)));

		//Destroy Hud Text(First Of(First Of(Filtered Array(Event Player.SoldierKillStreakTexts, Last Of(Current Array Element) == Custom String("UAV Recon")))));

		//Big Message(Event Player, First Of(Filtered Array(Event Player.SoldierKillStreakTexts, Last Of(Current Array Element) == Custom String("UAV Recon"))));

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
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;	

		//Tried to check if any of the previous killstreaks are also ready so they won't activate at the same time, but this shit doesn't work
		//Is True For Any(Array Slice(Event Player.Soldier76KillStreaksActive, 0, (Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2)), Current Array Element == true) == false;
		

		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2) == True;


	}

	actions
	{
		//This i
		//Wait(0.1, Ignore Condition);

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

		//Event Player.Soldier76CarepackLocation = true;

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

		/*For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.Soldier76KillStreaksActive), 1);
		If(Value In Array(Value In Array(Event Player.Soldier76KillStreaksActive, Event Player.ForLoopIndexPlayer), 0) == 6);
		Value In Array(Event Player.Soldier76KillStreaksActive, Event Player.ForLoopIndexPlayer) = Array(6, FALSE, Custom String("Care Package"));
		End;
		End;*/

		//Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1))) = False;
		
		

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
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Value In Array(Event Player.Soldier76Variables, 3) == True;
		//Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Event Player.SoldierCarePackageAttributes)) == True;

		//Is True For Any(Event Player.Soldier76KillStreaksActive, Array Contains(Current Array Element, Custom String("Care Package")) && Array Contains(Current Array Element, True)) == True;



	}

	//Could maybe set this to work for enemies too??
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
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;	

		//Tried to check if any of the previous killstreaks are also ready so they won't activate at the same time, but this shit doesn't work
		//Is True For Any(Array Slice(Event Player.Soldier76KillStreaksActive, 0, (Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 1)) / 2)), Current Array Element == true) == false;
		

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
		//Hero Of(Event Player) == Hero(Soldier: 76);
		Is Dummy Bot(Event Player) == false;
		Event Player.Soldier76Variables != Null;
		Is Button Held(Event Player, Button(Ultimate)) == True;

		//Tried to check if any of the previous killstreaks are also ready so they won't activate at the same time, but this shit doesn't work
		//Is True For Any(Array Slice(Event Player.Soldier76KillStreaksActive, 0, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 2)) / 2), Current Array Element == true) == false;


		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 3)) / 2) == True;

		//Is True For Any(Event Player.Soldier76KillStreaksActive, Array Contains(Current Array Element, Custom String("Tactical Nuke")) && Array Contains(Current Array Element, True)) == True;



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
//Sometimes causes excessive script load during timer??? Is it when killing D.Va and she respawns?? Might actually be a problem with D.Va dummy bots as the same thing happened with her before when trying to use her ult as nuke

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

		//Should maybe set visible to to reevaluate for most things in case the player list changes mid-match
		//Create Effect(All Players(All Teams), Sphere, Color(Yellow), Global.NukePosition, Update Every Frame(Global.NukeRadius), Visible To Position and Radius);

		Chase Global Variable Over Time(NukeRadius, 200, 4.5, None);

		//Create Effect(Global.NukingPlayer, Wrecking Ball Piledriver Fire Sound, Color(Blue), Global.NukingPlayer, 1000, Position And Radius);


		/*For Global Variable(ForLoopIndexGlobal, 0, Count Of(All Players(All Teams)), 1);

		Create Effect(Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), Wrecking Ball Piledriver Fire Sound, Color(Blue), Value In Array(All Players(All Teams), Global.ForLoopIndexGlobal), 1000, Position And Radius);

		End;*/

		Wait(4.5, Ignore Condition);



		/*For Player Variable(Global.NukingPlayer, ForLoopIndexPlayer, 0, Count Of(Global.NukingPlayer.Soldier76KillStreaksActive), 1);
		If(Value In Array(Value In Array(Global.NukingPlayer.Soldier76KillStreaksActive, Global.NukingPlayer.ForLoopIndexPlayer), 0) == 20);
		Value In Array(Global.NukingPlayer.Soldier76KillStreaksActive, Global.NukingPlayer.ForLoopIndexPlayer) = Array(20, FALSE);
		End;
		End;*/

		Stop Chasing Global Variable(NukeRadius);

		Global.NukePosition = null;

		Global.NukeRadius = Null;

		Global.NukeTimer = null;

		Destroy Hud Text(Global.NukeText);

		Global.NukeText = Null;

		Global.NukingPlayer = Null;

		Set Slow Motion(100);


		//Set Match Time(0);

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
    //Probably should try to spawn the ac-130 so that it's kind of on an arc around the player and will circle around his position, that way it should hopefully have a good view of the map
//I think it's already working like the above??

//Got a couple of crashes after making this. Seemed to happen when I had a full server of dummy bots which might tank performance. Probably need to make sure the conditions don't run unnecessarily on every player.
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

		//Tried to check if any of the previous killstreaks are also ready so they won't activate at the same time, but this shit doesn't work
		//Is True For Any(Array Slice(Event Player.Soldier76KillStreaksActive, 0, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 2)) / 2), Current Array Element == true) == false;


		Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 4)) / 2) == True;

		//Is True For Any(Event Player.Soldier76KillStreaksActive, Array Contains(Current Array Element, Custom String("Tactical Nuke")) && Array Contains(Current Array Element, True)) == True;



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


		//Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), 8, Value In Array(Event Player.Soldier76Variables, 6), Forward);
		Create Dummy Bot(Hero(Wrecking Ball), Team Of(Event Player), -1, Value In Array(Event Player.Soldier76Variables, 6), Forward);
		Value In Array(Event Player.Soldier76Variables, 7) = Last Created Entity;

		//One problem with this is that the Ac-130 might go inside a building and can't actually shoot outside of it
		Disable Movement Collision With Environment(Value In Array(Event Player.Soldier76Variables, 7), True);


		Start Camera(Event Player, Value In Array(Event Player.Soldier76Variables, 7) + Down, Value In Array(Event Player.Soldier76Variables, 7) + Down + Facing Direction Of(Event Player), 0);


		Wait(0.1, Ignore Condition);
		Set Gravity(Value In Array(Event Player.Soldier76Variables, 7), 0);
		Set Knockback Received(Value In Array(Event Player.Soldier76Variables, 7), 0);

		Start Scaling Player(Value In Array(Event Player.Soldier76Variables, 7), 5, false);

		Start Holding Button(Value In Array(Event Player.Soldier76Variables, 7), Button(Ability 1));

		Start Accelerating(Value In Array(Event Player.Soldier76Variables, 7), Facing Direction Of(Value In Array(Event Player.Soldier76Variables, 7)), 10, 10, To Player, DIRECTION RATE AND MAX SPEED);

		Wait Until(Is Dead(Value In Array(Event Player.Soldier76Variables, 7)) || Is Dead(Event Player), 30);
		//Could maybe use the array value and get "slot of" or something like that?
		//Destroy Dummy Bot(Team Of(Event Player), 8);
		Destroy Dummy Bot(Team Of(Event Player), Slot Of(Value In Array(Event Player.Soldier76Variables, 7)));
		

		Stop Camera(Event Player);

		//Could maybe make a subroutine out of this
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Ability 1 Enabled(Event Player, True);
		Set Ability 2 Enabled(Event Player, True);

		//This might interfere with some other abilities, but ehh whatever.
		Clear Status(Event Player, rooted);

		Value In Array(Event Player.Soldier76Variables, 6) = Null;
		Value In Array(Event Player.Soldier76Variables, 7) = Null;
		/*Value In Array(Event Player.Soldier76Variables, 8) = Null;
		Value In Array(Event Player.Soldier76Variables, 9) = Null;
		Value In Array(Event Player.Soldier76Variables, 10) = Null;
		Value In Array(Event Player.Soldier76Variables, 11) = Null;*/


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

		

		//Speed Of In Direction(Value In Array(Event Player.Soldier76Variables, 7), Down) > 0;

		//Value In Array(Event Player.Soldier76KillStreaksActive, Index Of Array Value(Event Player.Soldier76KillStreaksEquipped, Value In Array(Event Player.SoldierAllKillStreaks, 4)) / 2) == True;



	}

	actions
	{
		Wait(0.1, Abort When False);

		If(Speed Of In Direction(Value In Array(Event Player.Soldier76Variables, 7), Down) > 0);

		Apply Impulse(Value In Array(Event Player.Soldier76Variables, 7), Up, 0.001, To Player, Cancel Contrary Motion);
		
		End;

		//Big Message(Event Player, Custom String("aaa"));

		Set Facing(Value In Array(Event Player.Soldier76Variables, 7), Direction From Angles(Horizontal Facing Angle Of(Value In Array(Event Player.Soldier76Variables, 7)) + 1, Vertical Facing Angle Of(Value In Array(Event Player.Soldier76Variables, 7))), To World);


		Loop If Condition Is True;
		


	}
}

rule("soldier 76 AC-130 shoot bombs")
{
//The explosion effect from the projectile sometimes doesn't trigger for whatever reason

	event
	{
		Ongoing - Each Player;
		All;
		Soldier: 76;
	}

	conditions
	{
		//Hero Of(Event Player) == Hero(Soldier: 76);
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

		//Old version using effects instead of projectiles
		/*Create Effect(All Players(All Teams), Orb, Team Of(Event Player),  Value In Array(Event Player.Soldier76Variables, 8), 10, Position And Radius);
		Value In Array(Event Player.Soldier76Variables, 10) = Last Created Entity;

		Value In Array(Event Player.Soldier76Variables, 9) = Ray Cast Hit Position(Value In Array(Event Player.Soldier76Variables, 7) + Down, Value In Array(Event Player.Soldier76Variables, 7) + Down + Facing Direction Of(Event Player) * 1000, null, Value In Array(Event Player.Soldier76Variables, 7), TRUE);
		*/


		//Create Effect(Event Player, Ring, Team Of(Event Player), Value In Array(Event Player.Soldier76Variables, 9), 10, Position And Radius);


		Value In Array(Event Player.Soldier76Variables, 11) = 5;

		Wait(Value In Array(Event Player.Soldier76Variables, 11), Ignore Condition);
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
		//Hero Of(Event Player) == Hero(Reinhardt);
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
		//Hero Of(Event Player) == Hero(Reinhardt);
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.U == True;
		disabled Global.S != Event Player;
		Is Dummy Bot(Event Player) == false;
		Event Player.S != True;


	}

	actions
	{
		Apply Impulse(Event Player, Up, 10, To World, Cancel Contrary Motion);
		//Wait(0.01, Ignore Condition);
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
		//Hero Of(Event Player) == Hero(Reinhardt);
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
		//This is if the ult jump is interrupted somehow I think
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
		//Hero Of(Event Player) == Hero(Reinhardt);
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
//I feel like this might do the same thing as "Skip If(Event Player.M == True, 1);" in the increase buffs in the air event, but keeping this just in case

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

rule("Activate Tracer's super speed ultimate")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Tracer);
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
		disabled Set Slow Motion(20);
		Set Move Speed(Event Player, 6000);
		disabled Set Aim Speed(All Players(All Teams), 20);
		disabled Set Aim Speed(Event Player, 100);
		Wait(5, Ignore Condition);
		disabled Set Slow Motion(100);
		Set Move Speed(Event Player, 100);
		disabled Set Aim Speed(Event Player, 100);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Forcing Throttle(Event Player);
		Event Player.UsingCustomUlt = False;
		Destroy Effect(Last Created Entity);
	}
}

rule("tracer died")
{
	event
	{
		Player Died;
		All;
		Tracer;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Tracer);
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == True;
	}

	actions
	{
		disabled Set Slow Motion(100);
		Set Move Speed(Event Player, 100);
		disabled Set Aim Speed(Event Player, 100);
		Event Player.CustomUltReadyToUse = False;
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Forcing Throttle(Event Player);
		Event Player.UsingCustomUlt = False;
		Destroy Effect(Last Created Entity);
	}
}

rule("Tracer 4")
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

rule("sombra: za warudo")
{
//Add some way for Sombra to let allied players move in stopped time. Wish we could change gravity and speed for projectiles that already on the air, hopefully an update.

	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Hero Of(Event Player) == Hero(Sombra);
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
		//Set Slow Motion(0);
		Wait(Global.TimeStopTimer, Ignore Condition);
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

disabled rule("sombra: stop players from mysteriously flying upwards")
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
		Speed Of In Direction(Event Player, Up) > 0;
	}

	actions
	{
		Skip(2);
		Teleport(Event Player, Event Player.P);
		Apply Impulse(Event Player, Down, 0.001, To Player, Cancel Contrary Motion);
	}
}

rule("sombra: clear stun status after time stop is over and damage players")
{
//This is apparently triggering constantly even when Sombra never used ult

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
		Hero Of(Event Player) == Hero(Sombra);
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
		Hero Of(Event Player) == Hero(Sombra);
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
		Hero Of(Event Player) == Hero(Sombra);
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




rule("Junkrat activate ultimate ability. Set up suicide bomb.")
{
    //Should add separate team colors
//Seems like the event gets interrupted when switching hero if a specific hero is set in the event settings. Should maybe despawn the bomb anyway after player switches.
//Currently can only use one bomb at a time, because of the wait timer. Would maybe have to make an array to spawn multiple bombs that would also be destroyed.
//Make the bomb disarmable for enemy players, with a minigame where you choose one wire out of 3 to disarm. Maybe make it so that there's a sequence of 3 and if you get 2 right it will turn on enemies instead. If you get 1 it disarms. If you get none it explodes
//Maybe make the explosion ignore walls, also change the explosion effect so it's not so fast and it's more noticeable, maybe some kind of expanding orb
//could add a sound to the timer when ever a second ticks
//Maybe create a big cloud after bomb explodes? Add smoke sound too
//Could also try some of the explosion effects from the extensions
//Torbjörn's overdrive visual effects gives off smoke that could maybe fit a bomb
	event
	{
		Ongoing - Each Player;
		All;
		Junkrat;
	}

	conditions
	{
		Is Button Held(Event Player, Button(Ultimate)) == True;
		Hero Of(Event Player) == Hero(junkrat);
		Event Player.CustomUltReadyToUse == True;
		Has Status(Event Player, Hacked) == False;
		Event Player.UsingCustomUlt == Null;
	}

	actions
	{
		Call Subroutine(UseCustomUlt);
		Event Player.JunkratBombPosition = Event Player;
		Create Effect(All Players(All Teams), Orb, Team Of(Event Player), Event Player.JunkratBombPosition, 10, Position And Radius);
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
		Play Effect(All Players(All Teams), Bad Explosion, Team Of(Event Player), Event Player.JunkratBombPosition, Event Player.JunkratExplosionRadius * 1.5);
		Play Effect(All Players(All Teams), Explosion Sound, Team Of(Event Player), Event Player.JunkratBombPosition, Event Player.JunkratExplosionRadius * 2);
		//Should make the explosion go through walls?
		Damage(Players Within Radius(Event Player.JunkratBombPosition, Event Player.JunkratExplosionRadius, All Teams, Surfaces And Enemy Barriers), Event Player, 800);
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
		Hero Of(Event Player) == Hero(junkrat);
		Event Player.UsingCustomUlt == true;
		Is Alive(Event Player) != true;
	}

	actions
	{
		Event Player.JunkratBombPosition = Position Of(Event Player);
		Call Subroutine(StopUsingCustomUlt);
	}
}





rule("D.Va increase upgrade counter when using ult as baby D.VA, just used so that first spawn won't trigger an upgrade.")
{
    //ability 2 cooldown needs to be fixed. 
//Extra life hud text from mercy can mess with the sort order of the menu list 
//Could maybe exclude options from the list that have already been received
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
		//Ultimate Charge Percent(Event Player) >= 100;
		Is Using Ultimate(Event Player) == True;
		//Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.DVAVariables != Null;
		//Hero Of(Event Player) == Hero(D.Va);

	}

	actions
	{
		//Without this it would actually trigger this when exploding her mech. I suppose it wouldn't necessarily be an issue though? Except that I think it could trigger the upgrade counter  twice
		Wait Until(Is In Alternate Form(Event Player) != True || Is Dead(Event Player) == True || Hero Of(Event Player) != Hero(D.Va), 9999);
		//Wait(0.01, Abort When False);
		If(Is Alive(Event Player) == True && Hero Of(Event Player) == Hero(D.Va));
		Value In Array(Event Player.DVAVariables, 1) += 1;
		//Big Message(Event Player, Custom String("777"));
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
		//Hero Of(Event Player) == Hero(D.Va);
		//|| Value In Array(Event Player.DVAVariables, 2) == Null;

	}

	actions
	{
		Create HUD Text(Event Player, String("{0} {1}", String("Damage"), String("{0}: {1}", String("Dealt"), String("{0}%",
			Event Player.G))), Null, Null, Right, 0, Color(White), Color(White), Color(White), Visible To and String, Default Visibility);
		Event Player.DVAVariables = Array(Last Text Id);

		//Upgrade count
		Modify Player Variable(Event Player, DVAVariables, Append To Array, 0);
	
		Event Player.G = Array(100, 0, 1, false);
		Event Player.B = Hero Of(Event Player);
		
		//Big Message(Event Player, Custom String("666"));


		//Wait(0.01, Ignore Condition);
		//Event Player.CustomUltReadyToUse = True;
		/*Wait Until(Hero Of(Event Player) != Hero(D.Va), 9999);
		Destroy Hud Text(Value In Array(Event Player.DVAVariables, 0));
		Event Player.DVAVariables = Null;
		Event Player.Q = Null;
		Event Player.G = Null;*/
		//Big Message(Event Player, Custom String("Initialized D.Va"));
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
		//Doesn't actually do anything??
		//Event Player.Q = Null;
		Event Player.G = Null;
		
		//Seems like these are reset automatically???
		/*Set Ability Cooldown(Event Player, Button(Ability 1), 1);

		Set Ability Cooldown(Event Player, Button(Ability 2), 1);

		Set Ability Cooldown(Event Player, Button(Secondary Fire), 1);*/
		
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
		//Event Player.CustomUltReadyToUse == True;
		Is Dummy Bot(Event Player) == false;
		//Hero Of(Event Player) == Hero(D.Va);
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.DVAVariables, 1) > 0;
		Is In Alternate Form(Event Player) != True;


	}

	actions
	{
		//Big Message(Event Player, Custom String("5555"));

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
		//Event Player.CustomUltReadyToUse == True;
		Is Dummy Bot(Event Player) == false;
		//Hero Of(Event Player) == Hero(D.Va);
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
		//Wait(0.1, Ignore Condition);
		Big Message(Event Player, Custom String("Added shields"));
		//Wait(2, ignore Condition);
		//Set Player Health(Event Player, Max Health(Event Player));
		else if(Event Player.MenuChosenOption == Custom String("Infinite defense matrix"));
		Value In Array(Event Player.G, 3) = true;
		Big Message(Event Player, Custom String("Infinite defense matrix added"));

		End;

		Set Damage Dealt(Event Player, Value In Array(Event Player.G, 0));
		//Set Max Health(Event Player, Value In Array(Event Player.G, 1));
		
		Add Health Pool To Player(Event Player, Shields, Value In Array(Event Player.G, 1), true, true);

		Modify Player Variable(Event Player, DVAVariables, Append To Array, Last Created Health Pool);



		//Event Player.Q += 0.500;
		//Skip If(Event Player.Y != 0, 2);
		//Create Effect(All Players(All Teams), Good Aura, Color(Green), Event Player, Event Player.Q, Visible To Position and Radius);
		//Event Player.Y = Last Created Entity;

		Event Player.MenuChosenOption = Null;

		//Big Message(Event Player, Custom String("4444"));

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
		//Event Player.CustomUltReadyToUse == True;
		Is Dummy Bot(Event Player) == false;
		//Hero Of(Event Player) == Hero(D.Va);
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.G, 2) >= 2;
		(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Ability Cooldown(Event Player, Button(Ability 2)) > 0 || Ability Cooldown(Event Player, Button(Secondary Fire)) > 0) == True;
		//Ability Cooldown(Event Player, Button(Ability 1)) == True;
		//Is Using Ability 2(Event Player) == True;

	}

	actions
	{
		//Big Message(Event Player, Ability Cooldown(Event Player, Button(Ability 2)));

		//Wait(0.1, Abort When False);
		If(Ability Cooldown(Event Player, Button(Ability 1)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 1), Ability Cooldown(Event Player, Button(Ability 1)) / Value In Array(Event Player.G, 2));
		End;

		//Doesn't work, the ability cooldown check returns null always.
		If(Ability Cooldown(Event Player, Button(Ability 2)) > 0);
		Set Ability Cooldown(Event Player, Button(Ability 2), Ability Cooldown(Event Player, Button(Ability 2)) / Value In Array(Event Player.G, 2));
		End;

		If(Ability Cooldown(Event Player, Button(Secondary Fire)) > 0);
		Set Ability Cooldown(Event Player, Button(Secondary Fire), Ability Cooldown(Event Player, Button(Secondary Fire)) / Value In Array(Event Player.G, 2));
		End;

		

		//Loop If Condition Is True;


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
		//Event Player.CustomUltReadyToUse == True;
		Is Dummy Bot(Event Player) == false;
		//Hero Of(Event Player) == Hero(D.Va);
		Event Player.DVAVariables != Null;
		Value In Array(Event Player.G, 3) == True;
		//Ability Resource(Event Player, Button(Secondary Fire)) <= 0;
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
		//Hero Of(Event Player) == Hero(D.Va);
		Is Dead(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Event Player.DVAVariables != Null;
		//For some reason this causes a crash the next time you use ultimate with d.va. Disabling the baby reset rule seemed to fix it and yet commenting out all the actions inside it still caused a crash.
		//Don't remove upgrades if player had extra life from mercy
		//Event Player.ExtraLife != True;
	}

	actions
	{
		Set Damage Dealt(Event Player, 100);
		//Set Max Health(Event Player, 100);
		Event Player.G = Array(100, 0, 1, false);

		//Destroy Effect(Event Player.Y);
		//Event Player.Y = Null;
		//Event Player.Q = 0;
		Remove Health Pool From Player(Value In Array(Event Player.DVAVariables, 2));

		Value In Array(Event Player.DVAVariables, 1) = 0;


		Event Player.DVAVariables = Remove From Array(Event Player.DVAVariables, Value In Array(Event Player.DVAVariables, 2));

		//Big Message(Event Player, Custom String("UMMMM"));

		//Destroy HUD Text(Value In Array(Event Player.DVAVariables, 0));

		//Event Player.DVAVariables = Null;
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
		//Set Max Health(Event Player, 100);
		//Destroy Effect(Event Player.Y);
		//Event Player.Y = Null;
		//For Player Variable(Event Player, ForLoopIndexPlayer, 2, Count Of(Event Player.DVAVariables - 2), 1);
		
		//If(Value In Array(Event Player.DVAVariables, 2) != Null);
		Remove Health Pool From Player(Value In Array(Event Player.DVAVariables, 2));
		

		Event Player.DVAVariables = Remove From Array(Event Player.DVAVariables, Value In Array(Event Player.DVAVariables, 2));

		//End;
		//Event Player.DVAVariables = Null;

		//Big Message(Event Player, Custom String("11111"));

	}
}


rule("Bastion activate ultimate.")
{
    //Stuff to fix/add:
//Would like to decrease cooldowns on Bastion's abilities and stay in turret mode permanently, but currently doesn't seem to work. Hopefully patch will fix in the future.
//Disable ult when dying, maybe could make this into a universal thing. ACTUALLY NEVERMIND, BECAUSE SOME ULTS SHOULD STAY ACTIVE AFTER DYING LIKE MEI'S
//Add counter text for ult duration
    event
	{
		Ongoing - Each Player;
		All;
		All;
	}

    conditions{
        Is Button Held(Event Player, Button(Ultimate)) == True;
		Event Player.CustomUltReadyToUse == True;
		Event Player.UsingCustomUlt == Null;
		Hero Of(Event Player) == Hero(Bastion);
		Has Status(Event Player, Hacked) == False;
    }

    actions
    {
        Call Subroutine(UseCustomUlt);
        Event Player.BastionPos = Position Of(Event Player);
        Disable Movement Collision With Environment(Event Player, false);
        Set Gravity(Event Player, 0);
        Set Projectile Speed(Event Player, 500);
        Set Projectile Gravity(Event Player, 0);
        Set Knockback Received(Event Player, 0);
        Start Forcing Player Position(Event Player, Position Of (Event Player) + Up * 50, false);
        Wait(1, Ignore Condition);
        Stop Forcing Player Position(Event Player);
        Start Scaling Player(Event Player, 5.0, false);
        Set Damage Received(Event Player, 20);
        Set Damage Dealt(Event Player, 200);
        Set Ability Cooldown(Event Player, Button(Ability 1), 1);
        Set Ability Cooldown(Event Player, Button(Ability 2), 1);

        //Wait(20, Ignore Condition);
		Wait Until(Is Dead(Event Player) == True || Hero Of(Event Player) != Hero(Bastion), 20);
        Start Forcing Player Position(Event Player, Event Player.BastionPos, false);
        Wait(1, Ignore Condition);
        Stop Forcing Player Position(Event Player);
        Start Scaling Player(Event Player, 1, false);
        Set Damage Received(Event Player, 100);
        Set Damage Dealt(Event Player, 100);
        Set Ability Cooldown(Event Player, Button(Ability 1), 1);
        Set Ability Cooldown(Event Player, Button(Ability 2), 1);
        Set Gravity(Event Player, 100);
        Set Projectile Speed(Event Player, 100);
        Set Projectile Gravity(Event Player, 100);
        Set Knockback Received(Event Player, 100);
        Enable Movement Collision With Environment(Event Player);
        Call Subroutine(StopUsingCustomUlt);


    }
}

rule("Reaper activate ultimate.")
{
    
//For some reason reaper can use his regular teleport while it's on cooldown during this ult???
//Fixed the issue above by disabling it manually while cooldown is active
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
		//Hero Of(Event Player) == Hero(Reaper);
		Has Status(Event Player, Hacked) == False;
    }

    actions
    {
        Call Subroutine(UseCustomUlt);
		Set Primary Fire Enabled(Event Player, False);
		//Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 2000, Receivers And Damagers);
		//Event Player.ReaperVariables = Array(Last Damage Modification Id);
		Set Move Speed(Event Player, 150);

		Create Effect(All Players(All Teams), Bad Aura, Color(Black), Event Player, 1, POSITION AND RADIUS);
		Event Player.ReaperVariables = Array(Last Created Entity);

		//Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Created entity);
		Modify Player Variable(Event Player, ReaperVariables, Append To Array, 30);

		Create Hud Text(Event Player, Value In Array(Event Player.ReaperVariables, 1), Null, null, Top, 1, Color(Purple), Color(Purple), Color(Purple), Visible to and string, default Visibility);
		Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Text ID);
		//Modify Player Variable(Event Player, ReaperVariables, Append To Array, 0);

		
		//Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Event Player.LocalVariable, 1, POSITION AND RADIUS);
		//Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Created Entity);
		
		Create Effect(All Players(All Teams), Bad Aura, Color(Purple), Event Player, 1, POSITION AND RADIUS);
		//Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Created Entity);
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
//Can't chase an array variable unfortunately so have to do this

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

		/*Event Player.LocalVariable = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False);

		//Value In Array(Event Player.ReaperVariables, 4) = Nearest Walkable Position(Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False));

		If(Y Component Of(Event Player.LocalVariable) > Y Component Of(Eye Position(Event Player)));

		Event Player.LocalVariable = Empty Array;

		//Value In Array(Event Player.ReaperVariables, 4) = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 1, 35, 1);
		Value In Array(Event Player.LocalVariable, Event Player.ForLoopIndexPlayer) = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * Event Player.ForLoopIndexPlayer, null, All Players(All Teams), False);
		End;

		Big Message(Event Player, Up);

		Event Player.LocalVariable = Filtered Array(Event Player.LocalVariable, Is In Line Of Sight(Eye Position(Event Player), Nearest Walkable Position(Current Array Element), Barriers Do Not Block Los) == true);
		Event Player.LocalVariable = Filtered Array(Event Player.LocalVariable, Y Component Of(Eye Position(Event Player)) < Y Component Of(Nearest Walkable Position(Current Array Element)));
		Event Player.LocalVariable = Sorted Array(Event Player.LocalVariable, Y Component Of(Nearest Walkable Position(Current Array Element)) * -1);
		Event Player.LocalVariable = Array Slice(Event Player.LocalVariable, 0, 3);
		Event Player.LocalVariable = Sorted Array(Event Player.LocalVariable, Distance Between(Current Array Element, Nearest Walkable Position(Current Array Element)));
		Event Player.LocalVariable = Nearest Walkable Position(First Of(Event Player.LocalVariable));

		Else;

		Event Player.LocalVariable = Nearest Walkable Position(Event Player.LocalVariable);

		End;*/


		//If(Value In Array(Event Player.ReaperVariables, 4) == Null);
		//Value In Array(Event Player.ReaperVariables, 4) = Nearest Walkable Position(Eye Position(Event Player) + Facing Direction Of(Event Player) * 35);

		//Play Effect(Event Player, Good Explosion, Color(Purple), Ray Cast Hit Position(Eye Position(Event Player), Event Player + (Vector Towards(Eye Position(Event Player), Nearest Walkable Position(Value In Array(Event Player.ReaperVariables, 4)))) + Up * 10, null, All Players(All Teams), false), 5);
		//Play Effect(Event Player, Good Explosion, Color(Purple), Value In Array(Event Player.ReaperVariables, 4), 3);


		/*If(Is In Line Of Sight(Eye Position(Event Player), Value In Array(Event Player.ReaperVariables, 4), Barriers Do Not Block Los) == False || Y Component Of(Value In Array(Event Player.ReaperVariables, 4)) > Y Component Of(Eye Position(Event Player)));
		Value In Array(Event Player.ReaperVariables, 4) = Nearest Walkable Position(Ray Cast Hit Position(Eye Position(Event Player), Event Player + (Vector Towards(Eye Position(Event Player), Value In Array(Event Player.ReaperVariables, 4))), null, All Players(All Teams), false));
		
		End;*/

		

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
		//Hero Of(Event Player) == Hero(Reaper);
		Is Using Ability 1(Event Player) == True;
    }

    actions
    {
		//Big Message(Event Player, Custom String("ADADA"));
		//Wait(0.1, Ignore Condition);
        Disable Movement Collision With Environment(Event Player, false);
		Set Gravity(Event Player, 0);
		//Start Accelerating(Event Player, Facing Direction Of(Event Player), 30, 30, To World, Direction Rate and Max Speed);
		Wait Until(Ability Cooldown(Event Player, Button(Ability 1)) > 0 || Hero Of(Event Player) != Hero(Reaper) || Is Dead(Event Player) == True, 3);
        Enable Movement Collision With Environment(Event Player);
		Set Gravity(Event Player, 100);
		//Wait(0.5, Ignore Condition);
		//Set Ability Cooldown(Event Player, Button(Ability 1), 4);
		//Big Message(Event Player, Custom String("JAJAJA"));
		//Stop Accelerating(Event Player);




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
		//Hero Of(Event Player) == Hero(Reaper);
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
		//Hero Of(Event Player) == Hero(Reaper);
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
		//Hero Of(Event Player) == Hero(Reaper);
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
		//Hero Of(Event Player) == Hero(Reaper);
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
//This should work by default without having to do this separately, but it's bugged right now

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
		//Event Player.CustomUltReadyToUse != True;
		//Event Player.UsingCustomUlt != Null;
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
		//Hero Of(Event Player) == Hero(Reaper);
		Has Status(Event Player, Hacked) == False;
		//Is Using Ability 2(Event Player) == True;
		Is Button Held(Event Player, Button(Ability 2)) == True;
		Ability Cooldown(Event Player, Button(Ability 2)) == 0;
		//Is Alive(Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))) == True;
		//Is In Line Of Sight(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), BARRIERS DO NOT BLOCK LOS) == True;
	}

	actions
	{

		Cancel Primary Action(Event Player);

		Create Effect(Event Player, Bad Aura, Color(Purple), Event Player.ReaperTPPos, 1, POSITION AND RADIUS);
		//Modify Player Variable(Event Player, ReaperVariables, Append To Array, Last Created Entity);

		Value In Array(Event Player.ReaperVariables, 3) = Last Created Entity;


		/*Event Player.LocalVariable = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False);

		If(Y Component Of(Event Player.LocalVariable) > Y Component Of(Eye Position(Event Player)));

		Event Player.LocalVariable = Empty Array;

		For Player Variable(Event Player, ForLoopIndexPlayer, 1, 35, 1);
		Value In Array(Event Player.LocalVariable, Event Player.ForLoopIndexPlayer) = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * Event Player.ForLoopIndexPlayer, null, All Players(All Teams), False);
		End;

		//Big Message(Event Player, Up);

		//Event Player.LocalVariable = Filtered Array(Event Player.LocalVariable, Is In Line Of Sight(Eye Position(Event Player), Nearest Walkable Position(Current Array Element), Barriers Do Not Block Los) == true);
		Event Player.LocalVariable = Filtered Array(Event Player.LocalVariable, Y Component Of(Eye Position(Event Player)) < Y Component Of(Nearest Walkable Position(Current Array Element)));
		Event Player.LocalVariable = Sorted Array(Event Player.LocalVariable, Y Component Of(Nearest Walkable Position(Current Array Element)) * -1);
		//Event Player.LocalVariable = Array Slice(Event Player.LocalVariable, 0, 5);
		Event Player.LocalVariable = Filtered Array(Event Player.LocalVariable, Y Component Of(Nearest Walkable Position(Current Array Element)) == Y component Of(Nearest Walkable Position(First Of(Event Player.LocalVariable))));
		Event Player.LocalVariable = Sorted Array(Event Player.LocalVariable, Distance Between(Current Array Element, Nearest Walkable Position(Current Array Element)));
		Event Player.LocalVariable = Nearest Walkable Position(First Of(Event Player.LocalVariable));

		Else;

		Event Player.LocalVariable = Nearest Walkable Position(Event Player.LocalVariable);

		End;*/



		
		/*Event Player.LocalVariable = Nearest Walkable Position(Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False));*/

		/*If(Is In Line Of Sight(Eye Position(Event Player), Event Player.LocalVariable, Barriers Do Not Block Los) == False || Y Component Of(Event Player.LocalVariable) > Y Component Of(Position Of(Event Player)));
		Event Player.LocalVariable = Nearest Walkable Position(Ray Cast Hit Position(Eye Position(Event Player), Event Player + Vector Towards(Eye Position(Event Player), Event Player.LocalVariable), null, All Players(All Teams), false) + Up);
		End;*/

		/*If(Is In Line Of Sight(Eye Position(Event Player), Event Player.LocalVariable, Barriers Do Not Block Los) == False || Y Component Of(Event Player.LocalVariable) > Y Component Of(Eye Position(Event Player)));
		Event Player.LocalVariable = Nearest Walkable Position(Ray Cast Hit Position(Eye Position(Event Player), Event Player + (Direction Towards(Eye Position(Event Player), Event Player.LocalVariable)) * 100, null, All Players(All Teams), false) + Up);
		End;*/
		

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
		//Is Alive(Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))) == True;
		//Is In Line Of Sight(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), BARRIERS DO NOT BLOCK LOS) == True;
	}

	actions
	{

		Wait(0.01, Abort When False);

		Event Player.ReaperTPPos = Ray Cast Hit Position(Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 35, null, All Players(All Teams), False) - Facing Direction Of(Event Player);

		
		//Was thinking of maybe being able to auto-aim teleport behind enemy players that were close to the reticle, but determining the exact view angle is a bit tricky with distance and all that and ultimately I'm not sure if I wanna add it, because the manual teleport is more skill-based
		//If(Is In View Angle(Event Player, First Of(Sorted Array(All Living Players(Opposite Team Of(Team Of(Event Player))), Absolute Value(Angle Difference(Horizontal Facing Angle Of(Event Player) + Vertical Facing Angle Of(Event Player), Horizontal Angle From Direction(Direction Towards(Event Player, Current Array Element)) + Vertical Angle From Direction(Direction Towards(Event Player, Current Array Element)))))), ));
		
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

		//Can somehow still use regular ability while it's on cooldown
		Set Ability Cooldown(Event Player, Button(Ability 2), 2);


		Wait(0.01, Ignore Condition);

		Destroy Effect(Value In Array(Event Player.ReaperVariables, 3));

		Value In Array(Event Player.ReaperVariables, 3) = Null;


		Event Player.ReaperTPPos = Null;

		Play Effect(All Players(All Teams), Moira Fade Reappear Sound, null, Event Player, 200);


	}
}

rule("Reaper teleport back in bounds if standing out of bounds")
{
//Not a perfect solution, can cause teleporting sometimes when in bounds as well and there are some out of bounds areas where the player can sort of slide without technically being on ground. Could potentially make some kind of convoluted ray cast solution

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


rule("Symmetra ultimate activate and deactivate")
{
    //Don't think it's necessary to set the normal direction stuff into null
//Could maybe make the player sink into the portals a bit so it's a bit more like an actual portal instead of a teleport
//Maybe limit the range on the portal firing so you can't teleport people into the sky out of bounds. Although idk if that's even such a bad thing
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

		//Maybe don't destroy the portals of the enemy team too
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
//Could maybe shorten some of this code with subroutines and such

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
		//Used for debugging
		//Create Beam Effect(Event Player, Good beam, Global.P, Global.P + Global.SymmetraBluePNormal, Color(Team 1), none);
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
		//Used for debugging
		//Create Beam Effect(Event Player, Good beam, Global.Q, Global.Q + Global.SymmetraRedPNormal, Color(Team 1), none);
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
		//Direction wasn't actually necessary for the solution I went with
		//Event Player.InPortalDirection = Direction Towards(Event Player, Global.P);
		//Event PLayer.InPortalSpeed = Speed Of In Direction(Event Player, Event Player.InPortalDirection);
		//Event Player.InPortalFacingDirection = Facing Direction Of(Event Player);
		Event Player.InPortalSpeed = Speed Of(Event Player);
		Teleport(Event Player, Global.Q);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(0.01, Ignore Condition);

		//This would maybe make more sense if you could actually tell the orientation of the portals
		//Apply Impulse(Event Player, Event Player.InPortalDirection - 2 * Dot Product(Event Player.InPortalDirection, Global.SymmetraRedPNormal) * Global.SymmetraRedPNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		//Big Message(Event Player, Vertical Angle From Direction(Global.SymmetraRedPNormal));

		//Skip If((Vertical Angle From Direction(Global.SymmetraRedPNormal) >= 70 && Vertical Angle From Direction(Global.SymmetraRedPNormal) <= 110) == True, 1); 
		//Set Facing(Event Player, Direction From Angles(Horizontal Angle From Direction(Global.SymmetraRedPNormal) - (Angle Between Vectors(Facing Direction Of(Event Player), Global.SymmetraBluePNormal * -1)), Vertical Angle From Direction(Global.SymmetraRedPNormal) - (Angle Between Vectors(Facing Direction Of(Event Player), Global.SymmetraBluePNormal * -1))), To World);
		Set Facing(Event Player, Direction From Angles(Horizontal Angle From Direction(Global.SymmetraRedPNormal) - (Horizontal Angle From Direction(Global.SymmetraBluePNormal * -1) - Horizontal Angle From Direction(Facing Direction Of(Event Player))), Vertical Angle From Direction(Global.SymmetraRedPNormal) - (Vertical Angle From Direction(Global.SymmetraBluePNormal * -1) - Vertical Angle From Direction(Facing Direction Of(Event Player)))), To World);
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
		//Event Player.InPortalDirection = Direction Towards(Event Player, Global.Q);
		//Event PLayer.InPortalSpeed = Speed Of In Direction(Event Player, Event Player.InPortalDirection);
		Event Player.InPortalSpeed = Speed Of(Event Player);
		Teleport(Event Player, Global.P);
		Wait(0.01, Ignore Condition);

		//Apply Impulse(Event Player, Event Player.InPortalDirection - 2 * Dot Product(Event Player.InPortalDirection, Global.SymmetraBluePNormal) * Global.SymmetraBluePNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion); 
		Set Facing(Event Player, Direction From Angles(Horizontal Angle From Direction(Global.SymmetraBluePNormal) - (Horizontal Angle From Direction(Global.SymmetraRedPNormal * -1) - Horizontal Angle From Direction(Facing Direction Of(Event Player))), Vertical Angle From Direction(Global.SymmetraBluePNormal) - (Vertical Angle From Direction(Global.SymmetraRedPNormal * -1) - Vertical Angle From Direction(Facing Direction Of(Event Player)))), To World);
		
		//Set Facing(Event Player, Global.SymmetraBluePNormal, To World);
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
		//The direction isn't actually necessary for the solution I ended up going with
		//Event Player.InPortalDirection = Direction Towards(Event Player, Global.YellowPortalRaycast);
		Event Player.InPortalSpeed = Speed Of(Event Player);

		Teleport(Event Player, Global.GreenPortalRaycast);
		//Not sure if wait is necessary, but just in case
		Wait(0.01, Ignore Condition);
		//Set Facing(Event Player, Global.SymmetraGreenPNormal, To World);
		Set Facing(Event Player, Direction From Angles(Horizontal Angle From Direction(Global.SymmetraGreenPNormal) - (Horizontal Angle From Direction(Global.SymmetraYellowPNormal * -1) - Horizontal Angle From Direction(Facing Direction Of(Event Player))), Vertical Angle From Direction(Global.SymmetraGreenPNormal) - (Vertical Angle From Direction(Global.SymmetraYellowPNormal * -1) - Vertical Angle From Direction(Facing Direction Of(Event Player)))), To World);
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
		//Set Facing(Event Player, Global.SymmetraYellowPNormal, To World);
		Set Facing(Event Player, Direction From Angles(Horizontal Angle From Direction(Global.SymmetraYellowPNormal) - (Horizontal Angle From Direction(Global.SymmetraGreenPNormal * -1) - Horizontal Angle From Direction(Facing Direction Of(Event Player))), Vertical Angle From Direction(Global.SymmetraYellowPNormal) - (Vertical Angle From Direction(Global.SymmetraGreenPNormal * -1) - Vertical Angle From Direction(Facing Direction Of(Event Player)))), To World);
		Apply Impulse(Event Player, Global.SymmetraYellowPNormal, Event Player.InPortalSpeed, To World, Cancel Contrary Motion);
		Play Effect(All Players(All Teams), Buff Explosion Sound, Color(White), Event Player, 50);
		Wait(1, Restart When True);
		Event Player.K = Null;
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
		//Chase Player Variable At Rate(Event Player, S, 0, 8, Destination and Rate);
		Chase Player Variable Over Time(Event Player, S, 0, 1, None);
		//Chase Player Variable At Rate(Event Player, S, 0, 8, Destination and Rate);
		
		Wait(1, Ignore Condition);
		Destroy Effect(Event Player.M);
		Destroy Effect(Event Player.Y);
		Play Effect(All Players(All Teams), Doomfist Meteor Strike Impact Effect, Team Of(Event Player), Event Player.G, 10);
		Play Effect(All Players(All Teams), Doomfist Meteor Strike Impact Sound, Team Of(Event Player), Event Player.G, 100);

		/*
		//This is the explosion effect to use without extensions
		
		Play Effect(All Players(All Teams), Good Explosion, Color(Team 1), Event Player.G, 10);
		Play Effect(All Players(All Teams), Ring Explosion Sound, Color(White), Event Player.G, 10000);*/


		Damage(Players Within Radius(Event Player.G, 8, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 20);
		Damage(Players Within Radius(Event Player.G, 6, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 100);
		Damage(Players Within Radius(Event Player.G, 2, Opposite Team Of(Team Of(Event Player)), Surfaces And Enemy Barriers),
			Event Player, 180);

		//This seems to apply the same direction to all players. Maybe should do some kind of for loop here for all the players and apply impulse to them separately
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
//Should probably add some conditions here to make sure this doesn't trigger when it doesn't need to.

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

disabled rule("Show coordinates")
{
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	actions
	{
		disabled Create HUD Text(Event Player, Position Of(Event Player), Null, Null, Left, 0, Color(White), Color(White), Color(White),
			Visible To and String, Default Visibility);
	}
}

rule("Genji Omae wa mou shindeiru")
{
    
//When I got hit as Pharah using her ult, I got damaged and stunned for a while, but then it just disabled after the ult was over. Perhaps the disabling of pharah's ult also negates genji's stuff?
//Stun fails sometimes when used on ulting echo?
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
		//Set Status(Victim, Event Player, Stunned, 1);

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

		//Stunned message unfortunately gets in the way of the nani message. Could maybe create a hud text?
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
		//Hero Of(Event Player) == Hero(Pharah);
		Event Player.UsingCustomUlt != True;
		Has Status(Event Player, Hacked) == False;
	}

	actions
	{
		Destroy HUD Text(Event Player.UltReadyText);
		Event Player.UltReadyText = Null;
		Apply Impulse(Event Player, Up, 10, To World, Cancel Contrary Motion);
		Set Secondary Fire Enabled(Event Player, False);
		Set Primary Fire Enabled(Event Player, False);
		Event Player.R = 20;
		Chase Player Variable At Rate(Event Player, R, 0, 1, Destination and Rate);
		Create HUD Text(Event Player, String("{0} {1}", Custom String("Crouch to drop bombs."), Custom String("
		Ability 1 to activate tacticool camera.")), String("{0}: {1}", Custom String("Bomb Cooldown: "),
			Event Player.S), String("{0}: {1}", Custom String("Ultimate Duration: "), Event Player.R), Right, 1, Color(Blue), Color(Blue), Color(
			White), Visible To and String, Default Visibility);
		Set Damage Dealt(Event Player, 300);
		Set Projectile Speed(Event Player, 300);
		Set Ability 1 Enabled(Event Player, False);
		//Disallow Button(Event Player, Button(Jump));
		Set Gravity(Event Player, 0);
		//Wait(0.1,Ignore Condition);
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
		//Allow Button(Event Player, Button(Jump));
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
		Set Secondary Fire Enabled(Event Player, True);
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
		
		//Cooldown
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
		//Distance Between(Event Player, Nearest Walkable Position(Event Player)) < 0.01;
		//(Y Component Of(Position Of(Event Player)) - Y Component Of(Nearest Walkable Position(Event Player))) < 1;
		Distance Between(Event Player, Ray Cast Hit Position(Event Player, Event Player + Down*0.8, Null, Event Player, False)) < Distance Between(Event Player, Event Player + Down*0.8);
	}

	actions
	{
		Wait(0.2, Abort When False);
		//Start Damage Over Time(Event Player, Null, 9999, 130);
		Damage(Event Player, Event Player, 10);
		//Create Effect(Event Player, Bad Aura, Color(Green), Ray Cast Hit Position(Position Of(Event Player), Position Of(Event Player) + Down/10, Null, Null, False), 20, None);
		//Create Effect(All Players(All Teams), Sphere, Team Of(Event Player), Event Player, 20, Position and Radius);

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
		Apply Impulse(Event Player, Facing Direction Of(Event Player), 0.300, To World, Incorporate Contrary Motion);
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
		Wait(0.025, Ignore Condition);
		Create Projectile(Mercy Caduceus Blaster, Event Player, Null, Null, To World, Damage, Opposite Team Of(Team Of(Event Player)), 10, 1, 0, Bad Explosion, Explosion Sound, 0, 50, 5, 0, 0, 0);
		Play Effect(All Players(All Teams), Debuff Impact Sound, Color(White), Event Player, 10000);
		Loop If Condition Is True;
	}

}



rule("Sigma zero/high gravity")
{
//Maybe make apply the high gravity when getting damaged?

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
		//Hero Of(Event Player) == Hero(Sigma);
	}

	actions
	{
		Call Subroutine(UseCustomUlt);

		If(Global.UltingSigmas == Null);
		Global.UltingSigmas = Array(Event Player);
		//All Players(Opposite Team Of(Team Of(Event Player))).SigmaHighGravityDebuff = Array(Event Player);
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
		//Hero Of(Event Player) == Hero(Sigma);
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
    //Some of these sigma rules I believe are now sometimes running even when no Sigma has ever been present in the match so should modify the conditions somehow

//So far I think only Moira's ult is another one that uses the acceleration and it applies the acceleration continuously in a loop so stopping acceleration shouldn't be too much of an issue, Zarya does continuous impulses which hopefully aren't effected by stopping acceleration
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
		//If(Hero Of(Event Player) != Hero(Sigma) || Event Player.UsingCustomUlt != True);
		Event Player.SigmaZeroGravBuff = false;
		Stop Accelerating(Event Player);
		//Value In Array(Event Player.CurrentGravities, 0) += 100;
		//Value In Array(Event Player.CurrentGravities, 1) += 100;
		//Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		//Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
		//Set Gravity(Event Player, 100);
		//Set Projectile Gravity(Event Player, 100);
		

		//End;
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

		//Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		//Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
		//Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		//Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));

		//Set Gravity(Event Player, 100);
		//Set Projectile Gravity(Event Player, 100);
		Set Move Speed(Event Player, 100);
		Set Projectile Speed(Event Player, 100);

		//Big Message(All Players(All Teams), Value In Array(Event Player.CurrentGravities, 0));

		//Clear Status(Event Player, Rooted);
	}
}

rule("Sigma disable grav effects if buff and debuff are false")
{
    
//Gotta make sure that setting gravity and move speed here doesn't conflict with any other ultimate, could maybe set exemptions separately for all the other ultimates at some point
//This is triggering constantly without sigma at play, needs fix
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
		//Slight delay in case it's enabled again
		Wait(0.1, Abort When False);

		//If()
		//Value In Array(Event Player.CurrentGravities, 0) = Value In Array(Event Player.CurrentGravities, 0) + 100;
		Set Gravity(Event Player, 100);
		Set Projectile Gravity(Event Player, 100);
		Set Move Speed(Event Player, 100);
		//Big Message(All Players(All Teams), Custom String("This shit triggered."));
	}
}


rule("Sigma high grav debuff effects")
{
    //Sometimes it seems like this gets set right after the ultimate has ended which used to cause the gravity for the enemy to go to 0. Made it so that it only gets set if it's over a 100, but would be nice if this whole thing didn't trigger after the ult ends
//Seems a little counterintuitive for this to be based on range since you're flying and you maybe wouldn't want to get all up in your enemy's face. Maybe this could just be a static number when they get inside the radius? Or maybe damage increases the effect?
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
        //Some way to increase gravity based on distance

		//Originally wanted to always modify the current gravities for gravity but the constant looping here and the changing debuff amount makes it pretty difficult so here I set it at as an increase of the gravity variable
		//Value In Array(Event Player.CurrentGravities, 0) += Event Player.SigmaHighGravDebuff;
		//Value In Array(Event Player.CurrentGravities, 1) += Event Player.SigmaHighGravDebuff;

		//Event Player.SigmaHighGravDebuff = Filtered Array(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20);

		Event Player.SigmaDebuffGravityScale = 0;

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Filtered Array(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20)), 1);
		Event Player.SigmaDebuffGravityScale += (20/Distance Between(Event Player, Value In Array(Filtered Array(Remove From Array(Global.UltingSigmas, Team Of(Event Player)), Distance Between(Current Array Element, Event Player) <= 20), Event Player.ForLoopIndexPlayer)));
		End;

		//Set Gravity(Event Player, 100 * Event Player.SigmaDebuffGravityScale);
		//Set Projectile Gravity(Event Player, 100 * Event Player.SigmaDebuffGravityScale);
		//Set Move Speed(Event Player, 100 / Event Player.SigmaDebuffGravityScale);

		//For some reason setting projectile gravity doesn't work for enemy AI during this rule? Does it work on players? Also should debuff projectile speed too?
		/*If(((Value In Array(Event Player.CurrentGravities, 0) * Event Player.SigmaDebuffGravityScale) > 100) && (Event Player.SigmaHighGravDebuff != null));
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0) * Event Player.SigmaDebuffGravityScale);
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1) * Event Player.SigmaDebuffGravityScale);
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0) / Event Player.SigmaDebuffGravityScale);
		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2) / Event Player.SigmaDebuffGravityScale);

		Else;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));
		Set Move Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 0));
		Set Projectile Speed(Event Player, Value In Array(Event Player.CurrentSpeeds, 2));
		End;*/

		//For some reason setting projectile gravity doesn't work for enemy AI during this rule? Does it work on players? Also should debuff projectile speed too?
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

disabled rule("Sigma high grav debuff effects")
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
		

		Create Hud Text(All Players(All Teams), Value In Array(Event Player.CurrentGravities, 1), null, null, Left, 1, Color(Blue), null, Color(Yellow), Visible To And String, Default Visibility);

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
		
		/*Value In Array(Event Player.CurrentGravities, 0) -= 100;
		Value In Array(Event Player.CurrentGravities, 1) -= 100;
		Set Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 0));
		Set Projectile Gravity(Event Player, Value In Array(Event Player.CurrentGravities, 1));*/

		//Set on a loop in case the player's gravity gets altered for whatever reason, this should override it
		Wait(0.5, Abort When False);

		Set Gravity(Event Player, 0);
		Set Projectile Gravity(Event Player, 0);

		Loop If Condition Is True;

		//Big Message(All Players(All Teams), Custom String("This shit triggered."));


		//Set Gravity(Event Player, 0);
		//Set Projectile Gravity(Event Player, 0);
		//Clear Status(Event Player, Rooted);
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
		//Apply Impulse(Event Player, Down, 1, To Player, Incorporate Contrary Motion);
		
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


rule("Zenyatta activate ultimate")
{
    //Stuff to fix:
//Sometimes primary fire stays on after possession for the possessed player
//Camera got permanently fucked up when I died while activating ult
	event
	{
		Ongoing - Each Player;
		All;
		All;
	}

	conditions
	{
		Hero Of(Event Player) == Hero(Zenyatta);
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
		Skip If(Event Player.P == Null, 15);
		Stop Throttle In Direction(Event Player.P);
		Stop Facing(Event Player.P);
		Teleport(Event Player, Event Player.P + Facing Direction Of(Event Player.P) * -1);
		Allow Button(Event Player.P, Button(Primary Fire));
		Allow Button(Event Player.P, Button(Secondary Fire));
		Allow Button(Event Player.P, Button(Ability 1));
		Allow Button(Event Player.P, Button(Ability 2));
		Allow Button(Event Player.P, Button(Ultimate));
		Allow Button(Event Player.P, Button(Jump));
		Allow Button(Event Player.P, Button(Crouch));
		Stop Forcing Throttle(Event Player.P);
		Set Status(Event Player.P, Event Player, Asleep, 6);
		Stop Camera(Event Player);
		Event Player.P = 0;
		Event Player.UsingCustomUlt = 0;
		Event Player.CustomUltReadyToUse = 0;
		Event Player.B = 0;
		Set Move Speed(Event Player, 100);
		Clear Status(Event Player, Phased Out);
		Set Invisible(Event Player, None);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Ultimate Ability Enabled(Event Player, True);
		Set Ultimate Charge(Event Player, 0);
		Stop Chasing Player Variable(Event Player, Y);
		Event Player.Y = Null;
		Destroy HUD Text(Event Player.G);
		Destroy HUD Text(Event Player.M);
		Event Player.M = Null;
		Event Player.G = Null;
	}
}

rule("Zenyatta possess a player")
{
	event
	{
		Player Dealt Damage;
		All;
		All;
	}

	conditions
	{
		Event Player.UsingCustomUlt == True;
		Hero Of(Event Player) == Hero(Zenyatta);

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

		Start Forcing Player To Be Hero(Event Player, Hero Of(Event Player.P));
		Set Invisible(Event Player.P, All);
		Disable Movement Collision With Players(Event Player);
		Set Status(Event Player.P, Null, Phased Out, 30);
		Set Status(Event Player, Null, Phased Out, 30);
		Start Damage Modification(Event Player.P, Event Player, 0, None);
		Start Damage Modification(Event Player, Event Player.P, 0, None);
		Teleport(Event Player, Position Of(Event Player.P));

		/*Start Camera(Event Player, Update Every Frame(Eye Position(Event Player.P)) + Update Every Frame(Facing Direction Of(Event Player.P)), Update Every Frame(Eye Position(Event Player.P)) + Update Every Frame(Facing Direction Of(Event Player.P)) * 2, 0);
		Set Invisible(Event Player, All);
		Set Status(Event Player, Null, Phased Out, 9999);
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
		//Could maybe set rooted status instead of changing move speed?
		Set Move Speed(Event Player, 1);*/



        //Crashes server. Switching teams probably respawns the player anyway
        //Move Player To Team(Event Player.P, Opposite Team Of(Team Of(Event Player.P)), -1);
        //Move Player To Team(Event Player, Opposite Team Of(Team Of(Event Player)), -1);

	}
}

rule("Zenyatta possessed player died")
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
		Is Dead(Event Player.P) == True;

	}

	actions
	{
		Stop Throttle In Direction(Event Player.P);
		Stop Facing(Event Player.P);
		Teleport(Event Player, Event Player.P + Facing Direction Of(Event Player.P) * -1);
		Stop Forcing Throttle(Event Player.P);
		Stop Camera(Event Player);
		Set Move Speed(Event Player, 100);
		Clear Status(Event Player, Phased Out);
		Set Invisible(Event Player, None);
		Set Primary Fire Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Destroy HUD Text(Event Player.G);
		Event Player.G = Null;
		Allow Button(Event Player.P, Button(Primary Fire));
		Allow Button(Event Player.P, Button(Secondary Fire));
		Allow Button(Event Player.P, Button(Ability 1));
		Allow Button(Event Player.P, Button(Ability 2));
		Allow Button(Event Player.P, Button(Ultimate));
		Allow Button(Event Player.P, Button(Jump));
		Allow Button(Event Player.P, Button(Crouch));
		Event Player.P = 0;
	}
}

rule("Zenyatta leave possessed player")
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
		Is Button Held(Event Player, Button(Interact)) == True;
		

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
		Set Status(Event Player.P, Event Player, Asleep, 6);
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
//Maybe for emotes, move the camera to third person so you can see the emote

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

rule("Roadhog activate and deactivate ultimate")
{
//Add some kind of effect that shows when damage and heals are reflected. Could be a permanent connection to other players or something that happens when the damage and heal happens

	event
	{
		Ongoing - Each Player;
		All;
		Roadhog;
	}

	conditions
	{
		//Hero Of(Event Player) == Hero(Roadhog);
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
		//Wait(Event Player.Y, Ignore Condition);
		Wait Until(Is Dead(Event Player) == True, Event Player.Y);
		//Not sure what the idea behind this skip was. Would it prevent the ult from being reset if somehow the ult was available again while using the ult? Don't really understand, this is some ancient code. Also I would assume that a subroutine counts as one action, but maybe I should make sure that it doesn't count as multiple based on how many actions are within it.
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

rule("Hanzo")
{
//Sometimes could only ult once and then projectile gravity 0 would stay.

	event
	{
		Ongoing - Each Player;
		All;
		Hanzo;
	}

	conditions
	{
		Is Using Ultimate(Event Player) == True;
		Hero Of(Event Player) == Hero(Hanzo);
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
		Skip If(Event Player.S > 0, 2);
		Event Player.Y = 15;
		Create HUD Text(Event Player, String("{0} {1} {2}", String("Use Ultimate Ability"), String("Time"), Event Player.Y), Null, Null,
			Top, 3, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);
		Chase Player Variable At Rate(Event Player, Y, 0, 1, Destination and Rate);
		Set Projectile Speed(Event Player, 0);
		Set Projectile Gravity(Event Player, 0);
		Set Ultimate Charge(Event Player, 100);
		Event Player.S += 1;
		Skip If(Event Player.S == 5, 1);
		Wait(Event Player.Y, Restart When True);
		Stop Chasing Player Variable(Event Player, Y);
		Event Player.Y = 0;
		Destroy HUD Text(Last Text ID);
		Set Ultimate Charge(Event Player, 0);
		Event Player.S = 0;
		Wait(1, Ignore Condition);
		Set Projectile Gravity(Event Player, 100);
		Set Projectile Speed(Event Player, 100);
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
		//Hero Of(Event Player) == Hero(Junker Queen);
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
//Maybe make arena into a single global variable that all Junker queens can use? That way there could be less conflicts if both JQ's ult each other? Also could maybe add a timer to the match that automatically ends it.

    event
	{
		Player Dealt Damage;
		All;
		Junker Queen;
	}

	conditions
	{
		
		//Hero Of(Event Player) == Hero(Junker Queen);
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
//Probably should add some damage to JQ so fights don't take too long, but also can't add too much so they don't just die from the bleeding

    event
	{
		Ongoing - Each Player;
		All;
		Junker Queen;
	}

	conditions
	{
		Event Player.JunkerReadyToTeleport == True;
		//Is Using Ultimate(Event Player) != True;
		//Hero Of(Event Player) == Hero(Junker Queen);
		Is Dummy Bot(Event Player) == false;
		Event Player.JunkerQueenEnemyArray != Null;
		Event Player.JunkerQueenInArena != true;
		Is Alive(Event Player) == True;
		Is True For All(Event Player.JunkerQueenEnemyArray, Is Dead(Current Array Element) == True) == false;
	}

	actions
	{

		Event Player.JunkerQueenPositions = Array(Position Of(Event Player));


		//Just to make sure that the positions are set correctly into the array
		Wait(0.01, Abort When False);

		Event Player.JunkerReadyToTeleport = Null;


		Teleport(Event Player.JunkerQueenEnemyArray, Position Of(Event Player) + Facing Direction Of(Event Player) * 10 + Up * 150);
		Teleport(Event Player, Position Of(Event Player) + Up * 150);
		Set Gravity(Event Player, 0);
		Set Gravity(Event Player.JunkerQueenEnemyArray, 0);
		Set Ultimate Ability Enabled(Event Player, False);
		Event Player.JunkerQueenInArena = true;
		Event Player.JunkerQueenEnemyArray.JunkerQueenInArena = True;

		//Big Message(Event Player, Count Of(Event Player.JunkerQueenEnemyArray));

		Create Effect(All Players(All Teams), Winston Primal Rage Effect, Team Of(Event Player), Event Player, 100, None);

		If(Event Player.JunkerRageEffects == Null);
		Event Player.JunkerRageEffects = Array(Last Created Entity);
		Else;
		Modify Player Variable(Event Player, JunkerRageEffects, Append To Array, Last Created Entity);
		End;
		
		//Buffs have diminishing returns, divided by number of wins. INSTEAD OF DIMINISHING RETURNS, MAYBE COULD DO SOME KIND OF SYSTEM WHERE THE BUFF DECAYS OVER TIME??
		If(Event Player.JunkerDamageCounter == Null);
		Event Player.JunkerDamageCounter = 100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects);
		Else;
		Modify Player Variable(Event Player, JunkerDamageCounter, Multiply, (100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects)) / 100);
		End;

		Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 100 + (20*Count Of(Event Player.JunkerQueenEnemyArray)) / Count of(Event Player.JunkerRageEffects), None);

		If(Event Player.JunkerDamageMods == Null);
		//Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 100 + 10*Count Of(Event Player.JunkerQueenEnemyArray), None);
		Event Player.JunkerDamageMods = Array(Last Damage Modification ID);
		//Event Player.JunkerDamageMod = Last Damage Modification ID;
		Else;
		Modify Player Variable(Event Player, JunkerDamageMods, Append To Array, Last Damage Modification ID);
		//Stop Damage Modification(Event Player.JunkerDamageMod);
		//Start Damage Modification(All Players(Opposite Team Of(Team Of(Event Player))), Event Player, 100 + 10*Count Of(Event Player.JunkerQueenEnemyArray), None);
		//Event Player.JunkerDamageMod = Last Damage Modification ID;
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

		//Hero Of(Event Player) == Hero(Junker Queen);
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
//Although maybe Tracer should be able to escape it? But then might have to disable some stuff for her separately.

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
		//Event Player.JunkerQueenInArena == true;
		//Event Player.JunkerQueenEnemyArray != Null;
		//Is Using Ability 1(Event Player) == true;
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
		//Event Player.JunkerQueenInArena == true;
		//Event Player.JunkerQueenEnemyArray != Null;
		//Is Using Ability 2(Event Player) == true;
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
		//Event Player.JunkerQueenInArena == true;
		//Event Player.JunkerQueenEnemyArray != Null;
		//Is Firing Secondary(Event Player) == true;
		Ability Cooldown(Event Player, Button(Secondary Fire)) > 0;

	}

	actions
	{
		Set Ability Cooldown(Event Player, Button(Secondary Fire), 3);

	}
}

rule("If Junker queen lost, teleport enemies back to map and remove her buff.")
{
//Should probably use some global variable for the whole arena thing and if the JQ player leaves the match then all the others should be teleported back.

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
		
		//Reset knife knockback to normal for all junker queens
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
    //Set for all players, because it needs to work when switching to other hero.
//Above comment is no longer true as this is now replaced with the new event near the top of this file that checks for all heroes if they've switched character and then calls the correct subroutine.
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
		//((Is Dead(Event Player) == True && Event Player.ExtraLife != True)|| Hero Of(Event Player) != Hero(Junker Queen)) == True;
		(Is Dead(Event Player) == True && Event Player.ExtraLife != True) == True;
		
	}

	actions
	{
		Call Subroutine(ResetJQ);
	}
}


rule("Reset Junker Queen effects and buffs.")
{
    //This only resets things that affect the JQ player herself while she's buffed outside the arena and not things that only happen within the arena or the arena itself. Could maybe set those other things to reset here so that they will also be reset when player switches hero, but then again the player shouldn't be able to switch hero when in the arena so it shouldn't really be necessary unless somehow the arena persisted even when Junker Queen already left it, but that shouldn't happen either.
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

		//Not sure if this should be set to null when called outside of the event that triggers when character is changed.
		//Event Player.B = Null;

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
		//Reset knife knockback to normal for all junker queens
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
		//Big Message(All Players(All Teams), Custom String("Competitor out"));
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
		//Event Player.JunkerQueenEnemyArray == Null;
		Hero Of(Event Player) == Hero(Junker Queen);
	}

	actions
	{
		Set Knockback Dealt(Event Player, 1);
		Apply Impulse(Victim, Direction Towards(Victim, Event Player), 30, To World, Cancel Contrary Motion);
		//Big Message(Event Player, Custom String("Pulled with knife"));
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
		//Hero Of(Event Player) == Hero(Sojourn);
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
    //The reason why it's updated here is, because when sojourn fires, the weapon slightly kicks upwards which causes the beam to be placed a little bit above where she's actually aiming so the position is taken from the previous frame
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

        //Maybe should just get position here and then do the ray later? Performance cost?
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
		//Hero Of(Event Player) == Hero(Sojourn);
        Event Player.SojournBeamArray != null;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
        Wait(0.1, Abort When False);

		For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count Of(Event Player.SojournEyePosArray), 1);

        //Skip if(Event Player.SojournArrayIndex <= Count Of(Event Player.SojournEyePosArray) - 1, 1);
        //Event Player.SojournArrayIndex = 0;

        Event Player.SojournDamageRay = Ray Cast Hit Player(Value In Array(Event Player.SojournEyePosArray, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.SojournRayArray, Event Player.ForLoopIndexPlayer), All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        //If no player was hit, cast the other way around. Could maybe do this with Widow's ult too so that it doesn't do multiple casts unnecessarily?
        Skip if(Event Player.SojournDamageRay != null, 1);
        Event Player.SojournDamageRay = Ray Cast Hit Player(Value In Array(Event Player.SojournRayArray, Event Player.ForLoopIndexPlayer), Value In Array(Event Player.SojournEyePosArray, Event Player.ForLoopIndexPlayer), All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        Damage(Event Player.SojournDamageRay, Event Player, 50);

		//Big Message(Event Player, 111);

        //Modify Player Variable(Event Player, SojournArrayIndex, Add, 1);

		End;

        Loop If Condition Is True;
	}
}

rule("Sojourn reset values and destroy beams.")
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



rule("Widowmaker fire through wall")
{
    //Stuff to fix/add: 
//When tapping fire, the shot sometimes does like 60 damage instead of the usual 12. 
//The shot beam effect that appears briefly sometimes goes into the position of the recoil which is above the player. Though the actual shot hit detection seems to work? Changed the hit detection loop to be 0.016 instead of 0.032, the latter worked for hit detection, dunno if 0.016 is as good, but tried it to see if it would fix the issue with the shot effect
//Make beam team colored instead
//Should maybe reset some of the variables to null?
//optimization??
	event
	{
		Ongoing - Each Player;
		All;
		Widowmaker;
	}

	conditions
	{
		//Update Every Frame(Is Using Ultimate(Event Player)) == True;
		Is Using Ultimate(Event Player) == True;
        //Update Every Frame(Is Button Held(Event Player, Button(Primary Fire))) == True;
        //Update Every Frame(Is Firing Secondary(Event Player)) == true;
        Is Firing Primary(Event Player) == true;
        //Update Every Frame(Event Player.WidowZoomedIn) == true;
        Event Player.WidowZoomedIn == true;
        //Is Reloading(Event Player) != true;
        //Update Every Frame(Is In Line Of Sight(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), Barriers Do Not Block LOS)) != true;
        Is In Line Of Sight(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted), Barriers Do Not Block LOS) != true;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{

        //Sometimes the shot seems to trigger during the recoil which causes the positioning to be higher than the point of impact. Not sure why sometimes it happens and sometimes doesn't.
        //Event Player.WidowRayCastStartPos = (Update Every Frame(Eye Position(Event Player)) + Update Every Frame(Facing Direction Of(Event Player)) * Update Every Frame(Distance Between(Update Every Frame(Event Player), Update Every Frame(Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))))));

        

        Event Player.WidowRayCastForward = Ray Cast Hit Player(Event Player.WidowRayCastStartPos, Event Player.WidowRayCastEndPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);
        Event Player.WidowRayCastBackward = Ray Cast Hit Player(Event Player.WidowRayCastEndPos, Event Player.WidowRayCastStartPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        Event Player.WidowRayCastHeadForward = Ray Cast Hit Position(Event Player.WidowRayCastStartPos, Event Player.WidowRayCastEndPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);
        Event Player.WidowRayCastHeadBackward = Ray Cast Hit Position(Event Player.WidowRayCastEndPos, Event Player.WidowRayCastStartPos, All Living Players(Opposite Team Of(Team Of(Event Player))), All Living Players(Team Of(Event Player)), false);

        
        /*Skip If(Event Player.WidowReloadWait != true, 3);
        Wait(Event Player.WidowReloadWaitTime, Ignore Condition);
        Event Player.WidowReloadWait = false;
        Big Message(Event Player, Custom String("Reload waited"));*/

        Stop Chasing Player Variable(Event Player, WidowDamage);

        //Big Message(Event Player, Event Player.WidowRayCastHeadForward);
        //Big Message(Event Player, Event Player.WidowRayCastHeadBackward);

        //For testing purposes to show the ray cast position used for hit detection
        //Create Beam Effect(All Players(All Teams), Good Beam, Event Player.WidowRayCastStartPos, Event Player.WidowRayCastEndPos, Color(Purple), None);

        //This sometimes will be affected by the delay issue where the beam will be drawn where the recoil is. Tried to fix it by using the facing direction in the loop that happens before the shot, but for some reason that gave inconsistent results. Idk what's up with it.
        Create Beam Effect(Remove From Array(All Players(All Teams), Event Player), Good Beam, Eye Position(Event Player), Eye Position(Event Player) + Facing Direction Of(Event Player) * 1000, Team Of(Event Player), None);
        Event Player.WidowFireBeam = Last Created Entity;

        //Create HUD Text(Event Player, Event Player.WidowRayCastForward, Null, Null, Left, 1, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);

        //Create HUD Text(Event Player, Event Player.WidowRayCastBackward, Null, Null, Right, 1, Color(Blue), Color(White), Color(White), Visible To and String, Default Visibility);

        

        //Big Message(Event Player, Distance Between(Event Player.WidowRayCastHeadForward, Eye Position(Event Player.WidowRayCastForward)));
        //Big Message(Event Player, Distance Between(Event Player.WidowRayCastHeadBackward, Eye Position(Event Player.WidowRayCastBackward)));

        Skip If(Distance Between(Event Player.WidowRayCastHeadForward, Update Every Frame(Eye Position(Event Player.WidowRayCastForward))) > 0.3 && Distance Between(Event Player.WidowRayCastHeadBackward, Update Every Frame(Eye Position(Event Player.WidowRayCastBackward))) > 0.3, 4);
        //Big Message(Event Player, Custom String("First step"));
        Skip If(Event Player.WidowRayCastForward == null && Event Player.WidowRayCastBackward == null, 3);
        //Big Message(Event Player, Custom String("Second step"));
        Skip If((Event Player.WidowRayCastForward == null && Distance Between(Event Player.WidowRayCastHeadBackward, Update Every Frame(Eye Position(Event Player.WidowRayCastBackward))) > 0.3) || (Event Player.WidowRayCastBackward == null && Distance Between(Event Player.WidowRayCastHeadForward, Update Every Frame(Eye Position(Event Player.WidowRayCastForward))) > 0.3), 2);
        //Big Message(Event Player, Custom String("Third step"));
        Event Player.WidowDamage *= 2.5;
        Play Effect(Event Player, Buff Impact Sound, Color(White), Event Player, 100);

        Skip If(Event Player.WidowRayCastForward == null, 1);
        Damage(Event Player.WidowRayCastForward, Event Player, Event Player.WidowDamage); 
        //Create HUD Text(Event Player, Event Player.WidowDamage, Null, Null, Left, 1, Color(Blue), Color(White), Color(White), None, Default Visibility);

        Skip If(Event Player.WidowRayCastBackward == null || Event Player.WidowRayCastForward != null, 1);
        Damage(Event Player.WidowRayCastBackward, Event Player, Event Player.WidowDamage); 
        //Create HUD Text(Event Player, Event Player.WidowDamage, Null, Null, Left, 1, Color(Blue), Color(White), Color(White), None, Default Visibility);

        Event Player.WidowDamage = 12;

        Stop Chasing Player Variable(Event Player, WidowDamage);

        //Waited for fire rate delay, but since I switched to using the firing primary condition, this might not be necessary
        //Wait(0.464, Ignore Condition);

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
        //disabled Is In View Angle(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), 1) == True;
		Is Using Ultimate(Event Player) == True;
        //Is Button Held(Event Player, Button(Primary Fire)) == True;
        Is Firing Primary(Event Player) == true;
        //Update Every Frame(Is Firing Secondary(Event Player)) == true;
        //Update Every Frame(Is Button Held(Event Player, Button(Primary Fire))) == True;
        Event Player.WidowZoomedIn == true;
        Is Reloading(Event Player) != true;
        Is In Line Of Sight(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted), Barriers Do Not Block LOS) != true;
		Is Dummy Bot(Event Player) == false;

		//Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))
	}

    actions
    {
        
        /*Skip If(Event Player.WidowReloadWait != true, 2);
        Wait(Event Player.WidowReloadWaitTime, Ignore Condition);
        Event Player.WidowReloadWait = false;*/

        //Wait until gun damage starts recharging
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
        //Is Firing Secondary(Event Player) == true;
        Update Every Frame(Is Reloading(Event Player)) != true;
        Is In Spawn Room(Event Player) == false;
		Is Dummy Bot(Event Player) == false;

	}

	actions
	{
        Event Player.WidowDamage = 12;

        //Wait for the time it takes to aim
        Wait(0.32, Abort When False);

        Event Player.WidowZoomedIn = true;

        Create Beam Effect(Remove From Array(All Players(All Teams), Event Player), Bad Beam, Eye Position(Event Player), Event Player + Facing Direction Of (Event Player) * 1000, Team Of(Event Player), Visible To Position and Radius);
        
        Event Player.WidowAimBeam = Last Created Entity;

        //disabled Create HUD Text(Event Player, Distance Between(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))), Null, Null, Left, 1, Color(Blue), Color(White),	Color(White), Visible To and String, Default Visibility);

        //disabled Create HUD Text(All Players(Team Of(Event Player)), Distance Between(Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player))), Position Of(Event Player) + Vector(X Component Of(Facing Direction Of(Event Player)) * Distance Between(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))), Y Component Of(Facing Direction Of(Event Player)) * Distance Between(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))), Z Component Of(Facing Direction Of(Event Player)) * Distance Between(Event Player, Player Closest To Reticle(Event Player, Opposite Team Of(Team Of(Event Player)))))), Null, Null, Top, 0, Color(Purple), Color(White), Color(White), Visible To and String, Default Visibility);

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
        //Is Firing Secondary(Event Player) == true;
        Update Every Frame(Is Reloading(Event Player)) != true;
        Is Firing Primary(Event Player) == false;
        Is In Spawn Room(Event Player) == false;
		Is Dummy Bot(Event Player) == false;

	}

    actions
    {
        //Seems like this works every time with 0.032? So far hasn't failed, but it could still happen. Dunno if you need all the update every frame values
        Wait(0.016, Ignore Condition);
        //May not need the update every frame here on every value as well as in some of the event conditions, should maybe test later if it works without
        //Player closest to reticle also includes dead players. Someone had an alternate solution for this: use a sorted array of living players sorted based on angle between facing direction of event player and vector from event player towards living players
        Event Player.WidowRayCastStartPos = (Update Every Frame(Eye Position(Event Player)) + Update Every Frame(Facing Direction Of(Event Player)) * Update Every Frame(Distance Between(Update Every Frame(Event Player), Update Every Frame(First Of(Event Player.WidowPlayersInViewAngleSorted)))));

        //MOVE THE RAY CAST START POSITION SLIGHTLY BACKWARDS SO IT WILL HIT EVERY PART OF THE PLAYER
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
		//Debugging text, could maybe use the variable for something else
		//Skip If(Event Player.WidowViewAngleDebugText != Null, 2);
		//Create Hud Text(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted), Absolute Value(Angle Difference(Horizontal Facing Angle Of(Event Player) + Vertical Facing Angle Of(Event Player), Horizontal Angle From Direction(Direction Towards(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted))) + Vertical Angle From Direction(Direction Towards(Event Player, First Of(Event Player.WidowPlayersInViewAngleSorted))))), null, Left, 0, Color(Yellow), Color(Yellow), Color(Yellow), Visible To And String, Default Visibility);
		//Event Player.WidowViewAngleDebugText = Last Text Id;

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
        Event Player.WidowZoomedIn = false;
        Stop Chasing Player Variable(Event Player, WidowDamage);
        Destroy Effect(Event Player.WidowAimBeam);
        Event Player.WidowAimBeam = null;
    }

}

rule("Widowmaker reloading.")
{
    
//Maybe add using ultimate to condition??
//FOR SOME REASON 2ND SHOT AFTER RELOAD DOES MORE DAMAGE WHEN CONTINUOUSLY FIRING WITHOUT DROPPING AIM??
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
        //These aren't necessary when using the firing primary value
        //Event Player.WidowReloadWaitTime = 0.272;
        //Event Player.WidowReloadWait = true;
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
        
        
	}
}

rule("McCree enable ult")
{
//Doesn't support more than 1 player atm

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
		//disabled Set Invisible(Event Player, Enemies);
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
		//Could maybe just set this to 0.016 but might be slightly more taxing on performance though 0.023 is pretty fast already as well
		Wait(0.023, Ignore Condition);
		//Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Eye Position(Event Player) + Facing Direction Of(Event Player), 7.500);
		//Play Effect(All Players(All Teams), Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player), 7.500);
		Play Effect(Remove From Array(All Players(All Teams), Event Player), Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player), 7.500);
		//Play Effect(Event Player, Good Explosion, Color(Yellow), Update Every Frame(Eye Position(Event Player) + Facing Direction Of(Event Player)), 7.500);
		
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
		//Play Effect(All Players(All Teams), Good Explosion, Color(Yellow), Eye Position(Event Player) + Facing Direction Of(Event Player), 7.500);
		//Play Effect(All Players(All Teams), Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player), 7.500);
		Play Effect(Event Player, Ashe Dynamite Explosion Effect, Team Of(Event Player), Eye Position(Event Player) - Facing Direction Of(Event Player), 7.500);
		//Play Effect(Event Player, Good Explosion, Color(Yellow), Update Every Frame(Eye Position(Event Player) + Facing Direction Of(Event Player)), 7.500);
		
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
		//Event Player.McCreeUltBlind = True;
		Damage(Event Player, Event Player.UltingEnemyMcCree, 5);
		//Start Damage Over Time(Event Player, Event Player.UltingEnemyMcCree, 9999, 100);
		//Event Player.McCreeDPS = Last Damage Over Time ID;
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
		//Event Player.McCreeUltBlind = True;
		Damage(Event Player, Event Player.UltingEnemyMcCree, 10);
		//Start Damage Over Time(Event Player, Event Player.UltingEnemyMcCree, 9999, 100);
		//Event Player.McCreeDPS = Last Damage Over Time ID;
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

rule("If dead disable all damage over time")
{
//I hope this doesn't interfere with anything

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

rule("Mei activate ultimate")
{
//Apparently the healing block doesn't always work??

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
		//Call Subroutine(CustomUltStopTimerMei);
		//Wait Until((Is Dead(Event Player) == true || Hero Of(Event Player) != Hero(Mei)) == true, Event Player.P);
		//Call Subroutine(StopUsingCustomUlt);
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
		//Hero Of(Event Player) == Hero(Orisa);
		Is Using Ultimate(Event Player) == True;
		Is Dummy Bot(Event Player) == false;
		Is Button Held(Event Player, Button(Jump)) == True;
		Is On Ground(Event Player) == True;

	}

	actions
	{

		Apply Impulse(Event Player, Facing Direction Of(Event Player), 20, To World, Cancel Contrary Motion);

		Wait(0.1, Ignore Condition);
		//Stop Accelerating(Event Player);
		//Start Accelerating(Event Player, Up, 20, 20, To World, DIRECTION RATE AND MAX SPEED);

		//Loop If Condition Is True;
	}
}




rule("Wrecking ball activate ultimate.")
{
    //Stuff to add/fix:
//Timer UI
//Disable ult when dying or when changing hero(should make this into a universal thing)
//Could maybe make the collision detection stop without line of sight
//Could maybe have a general damage reduction variable as well if there are abilities that give dmg reduction to other players
//could maybe make grapple hook rolling collision work by detecting using damage event and checking for the ability used and then applying extra damage
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
		Hero Of(Event Player) == Hero(Wrecking Ball);
		Has Status(Event Player, Hacked) == False;
	}

    actions
    {
        Call Subroutine(UseCustomUlt);
        Start Scaling Player(Event Player, 3, false);
        //Event Player.WreckingBallForLoop = 0;
        Skip If(Is In Alternate Form(Event Player) == true, 1);
        Press Button(Event Player, Button(Ability 1));

		Set Ability 1 Enabled(Event Player, False);
		Set Primary Fire Enabled(Event Player, False);
		Set Secondary Fire Enabled(Event Player, False);
        //Disallow Button(Event Player, Button(Ability 1));
        //Disallow Button(Event Player, Button(Secondary Fire));
        //could maybe give all players some kind of move speed variable that can be modified so that different move speed effects don't overwrite each other and stack instead
        //Set Move Speed(Event Player, 50);
        Set Damage Received(Event Player, 33);
        Set Knockback Received(Event Player, 33);
        Wait(15, Ignore Condition);
        Skip If(Event Player.UsingCustomUlt == Null, 6);
        Call Subroutine(StopUsingCustomUlt);
        Start Scaling Player(Event Player, 1, false);
		Set Ability 1 Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
        //Allow Button(Event Player, Button(Ability 1));
        //Allow Button(Event Player, Button(Secondary Fire));
        Set Damage Received(Event Player, 100);
        Set Knockback Received(Event Player, 100);


        //Set Move Speed(Event Player, 100);


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
        //Has Status(Closest Player To(Event Player, Opposite Team of(Team Of(Event Player))), Invincible) != true; 
        //Has Status(Closest Player To(Event Player, Opposite Team of(Team Of(Event Player))), Phased Out) != true; 
	}

    actions
    {
        //Kill(Closest Player To(Event Player, Opposite Team of(Team Of(Event Player))), Event Player);
        //Damage(Closest Player To(Event Player, Opposite Team of(Team Of(Event Player))), Event Player);
        //Wait(0.1, Abort When False);
        Damage(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces), Event Player, 400);
        Apply Impulse(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces), Position Of(Players Within Radius(Event Player, 4, Opposite Team of(Team Of(Event Player)), Surfaces)) - Event Player, 50, To World, Cancel Contrary Motion);
        //Loop If Condition Is True;
    }
}

disabled rule("Wrecking ball disable ULT when hacked")
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
        Has Status(Event Player, Hacked) == true;
	}

    actions
    {
        Call Subroutine(StopUsingCustomUlt);
        Start Scaling Player(Event Player, 1, false);
        //Allow Button(Event Player, Button(Ability 1));
        //Allow Button(Event Player, Button(Secondary Fire));
		Set Ability 1 Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Primary Fire Enabled(Event Player, True);
        Set Damage Received(Event Player, 100);
        Set Knockback Received(Event Player, 100);

    }
}

rule("Wrecking ball disable ULT when dead")
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
        Is Alive(Event Player) == false;
	}

    actions
    {
        Call Subroutine(StopUsingCustomUlt);
        Start Scaling Player(Event Player, 1, false);
        Set Ability 1 Enabled(Event Player, True);
		Set Secondary Fire Enabled(Event Player, True);
		Set Primary Fire Enabled(Event Player, True);

        Set Damage Received(Event Player, 100);
        Set Knockback Received(Event Player, 100);

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
        Set Ability 1 Enabled(Event Player, True);
        Press Button(Event Player, Button(Ability 1));
		Set Ability 1 Enabled(Event Player, False);
        Loop If Condition Is True;

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

		//Big Message(Event Player, Value In Array(Event Player.MenuOptions, 0));

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
		//For Player Variable(Event Player, ForLoopIndexPlayer, 0, Count of(Event Player.MenuOptions), 1);

		//Modify Player Variable(Event Player, MenuHUDOptions, Append To Array, Last Text Id);
		
		//End;

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
		//Event Player.UsingCustomUlt != True;
	}

	actions
	{
		//Create Dummy Bot(Remove From Array(All Heroes, Hero(D.Va)), Opposite Team Of(Team Of(Event Player)), -1, Event Player, Vector(0, 0, 0));
		Create Dummy Bot(Hero(Cassidy), Opposite Team Of(Team Of(Event Player)), -1, Event Player, Vector(0, 0, 0));
		Set Ultimate Charge(Last Created Entity, 100);
		Start Holding Button(Last Created Entity, Button(Ultimate));
		//Start Holding Button(Last Created Entity, Button(Primary Fire));
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