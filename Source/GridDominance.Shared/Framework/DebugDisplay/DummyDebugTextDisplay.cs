﻿using System;
using Microsoft.Xna.Framework;

namespace GridDominance.Shared.Framework.DebugDisplay
{
	class DummyDebugTextDisplay : IDebugTextDisplay
	{
		private readonly DebugTextDisplayLine dummy = new DebugTextDisplayLine(() => string.Empty);

		public DummyDebugTextDisplay()
		{
			// DUMMY
		}

		public DebugTextDisplayLine AddLine(DebugTextDisplayLine l)
		{
			return dummy;
		}

		public DebugTextDisplayLine AddLine(Func<string> text)
		{
			return dummy;
		}

		public DebugTextDisplayLine AddLine(string text)
		{
			return dummy;
		}

		public DebugTextDisplayLine AddDecayLine(string text, float lifetime = 2, float decaytime = 0.75f, float spawntime = 0.25f)
		{
			return dummy;
		}

		public DebugTextDisplayLine AddErrorDecayLine(string text, float lifetime = 2, float decaytime = 0.75f, float spawntime = 0.25f)
		{
			return dummy;
		}

		public void Update(GameTime gameTime, InputState istate)
		{
			// DUMMY
		}

		public void Draw(GameTime gameTime)
		{
			// DUMMY
		}
	}
}
