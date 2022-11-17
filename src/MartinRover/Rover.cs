using System.Collections.ObjectModel;

namespace MartinRover
{
	public sealed class Rover
	{
		private char[] _validCommands = new char[] {'f', 'b', 'l', 'r'};
		private bool _roverReady = false;
		private Position _position;
		private ICollection<Coordinate> _obstacles;
		private int[,] _surfaceMap;

		public Position Position => _position;

		public bool Ready => _roverReady;

		public Rover()
		{			
		}

		public void Initialize(Position startPosition = default, ICollection<Coordinate> obstacles = default(ICollection<Coordinate>), int[,] surfaceMap = default(int[,]))
		{
			if (startPosition == null)
			{
				_position = new Position()
				{
					Orientation = 'N',
					Location = new Coordinate() { X = 0, Y = 0 }
				};			
			}

			// if we don't have any obstacles, then create a blank obstacle map. 
			_obstacles = (obstacles != null) ? obstacles : new Collection<Coordinate>();

			// if we don't have a valid surface map, then create a default one.
			_surfaceMap = (surfaceMap != null) ? surfaceMap : new int[4, 5];		
		}

		public string ProcessCommands(char[] commands)
		{
			if (commands == null || commands.Length == 0)
				return "No commands found to process.";



			return "Successfully Processed Commands";
		}		
	}
}
