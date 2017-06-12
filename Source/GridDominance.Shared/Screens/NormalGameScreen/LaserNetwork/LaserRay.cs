﻿using GridDominance.Shared.Screens.NormalGameScreen.Entities;
using Microsoft.Xna.Framework;

namespace GridDominance.Shared.Screens.NormalGameScreen.LaserNetwork
{
	public struct LaserRay
	{
		public Vector2 Start;
		public Vector2 End;

		public Cannon Target;
	}
}