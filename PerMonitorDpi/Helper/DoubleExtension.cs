﻿using System;

namespace PerMonitorDpi.Helper
{
	/// <summary>
	/// Extension method for <see cref="Double"/>
	/// </summary>
	internal static class DoubleExtension
	{
		/// <summary>
		/// Convert a double to a preliminarily rounded double to prevent a FrameworkElement from getting blurred by ScaleTransform.
		/// </summary>
		/// <param name="source">Source double</param>
		/// <param name="factor">Factor of ScaleTransform</param>
		/// <returns>Rounded double</returns>
		public static double ToRounded(this double source, double factor)
		{
			if (factor <= 0)
				throw new ArgumentOutOfRangeException("factor");

			return Math.Round(source * factor) / factor;
		}
	}
}