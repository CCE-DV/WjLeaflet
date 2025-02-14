﻿
using System;
using System.ComponentModel;

namespace LeafletjsMaps
{
	/// <summary>
	/// A LatLngBounds instance represents a rectangle in geographical coordinates, including one that crosses the 180 degrees longitudinal meridian.
	/// </summary>
	[ApiCategory("LeafletMap")]
	public class LatLngBounds
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:LeafletMap.LatLngBounds"/> class.
		/// </summary>
		public LatLngBounds()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:LeafletMap.LatLngBounds"/> class.
		/// </summary>
		/// <param name="east">East longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.</param>
		/// <param name="north">North latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.</param>
		/// <param name="south">South latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.</param>
		/// <param name="west">West longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.</param>
		internal LatLngBounds(double east, double north, double south, double west)
		{
			this.East = east;
			this.North = north;
			this.South = south;
			this.West = west;
		}

		/// <summary>
		/// East longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.
		/// </summary>
		public double East { get; set; }

		/// <summary>
		/// North latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.
		/// </summary>
		public double North { get; set; }

		/// <summary>
		/// South latitude in degrees. Values will be clamped to the range [-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.
		/// </summary>
		public double South { get; set; }

		/// <summary>
		/// West longitude in degrees. Values outside the range [-180, 180] will be wrapped to the range [-180, 180). For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.
		/// </summary>
		public double West { get; set; }

		/// <summary>
		/// Returns a string representation of a <see cref="T:LeafletMap.LatLngBounds"/> object.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return String.Concat(
				"{East=", this.East,
				", North=", this.North,
				", South=", this.South,
				", West=", this.West, "}"
			);
		}
	}
}
