﻿using GridDominance.Shared.Screens.NormalGameScreen.Entities;
using MonoSAMFramework.Portable.GameMath.Geometry.Alignment;

namespace GridDominance.Shared.Screens.NormalGameScreen.Physics
{
	public sealed class MarkerRefractionCorner : IPhysicsMarker
	{
		public GlassBlock Source;
		public FlatAlign4C Side;
	}
}
