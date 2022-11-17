
namespace MartinRover
{
	public sealed class Position
	{
		/// <summary>
		/// The position in x/y coordinates on a grid
		/// </summary>
		public Coordinate Location { get; set; }

		/// <summary>
		/// How the item is oriented i.e. N, S, E, W
		/// </summary>
		public char Orientation { get; set; }
	}
}
