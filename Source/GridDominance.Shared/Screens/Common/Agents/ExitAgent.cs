﻿using System;
using MonoSAMFramework.Portable.ColorHelper;
using MonoSAMFramework.Portable.Input;
using MonoSAMFramework.Portable.Screens;
using MonoSAMFramework.Portable.Screens.Agents;
using GridDominance.Shared.Resources;
using MonoSAMFramework.Portable.Localization;

namespace GridDominance.Shared.Screens.Common.Agents
{
	class ExitAgent : GameScreenAgent
	{
		public override bool Alive => true;

		private float _lastBackClick = -9999f;

		public ExitAgent(GameScreen scrn) : base(scrn)
		{
		}

		public override void Update(SAMTime gameTime, InputState istate)
		{
			if (istate.IsKeyJustDown(SKeys.AndroidBack) || istate.IsKeyJustDown(SKeys.Backspace))
			{
				var delta = gameTime.TotalElapsedSeconds - _lastBackClick;

				if (delta < 2f)
				{
					MainGame.Inst.CleanExit();
					return;
				}
				else
				{
					Screen.HUD.ShowToast(L10N.T(L10NImpl.STR_GLOB_EXITTOAST), 40, FlatColors.Silver, FlatColors.Foreground, 2f);
				}

				_lastBackClick = gameTime.TotalElapsedSeconds;
			}
		}

	}
}
