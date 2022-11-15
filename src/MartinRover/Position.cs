
namespace MartinRover
{
	internal sealed class Position
	{
		/// <summary>
		/// The position in x/y coordinates on a grid
		/// </summary>
		internal Coordinate Location { get; set; }

		/// <summary>
		/// How the item is oriented i.e. N, S, E, W
		/// </summary>
		internal char Orientation { get; set; }
	}
}
