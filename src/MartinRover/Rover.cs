namespace MartinRover
{
	internal sealed class Rover
	{
		private readonly Position _location;
		private readonly ICollection<Coordinate> _obstacles;
		private readonly int[,] _surfaceMap;

		public Position Location => _location;		

		public Rover()
		{

		}
	}
}
