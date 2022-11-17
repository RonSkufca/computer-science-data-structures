namespace MartinRover.Tests
{
	[TestClass]
	public class RoverTests
	{
		[TestMethod]
		public void Rover_Initialize_To_Defaults()
		{
			var rover = new Rover();

			rover.Initialize();

			var position = new Position()
			{
				Orientation = 'N',
				Location = new Coordinate() { X = 0, Y = 0 }
			};

			Assert.AreEqual(position.Orientation, rover.Position.Orientation);
			Assert.AreEqual(position.Location.X, rover.Position.Location.X);
			Assert.AreEqual(position.Location.Y, rover.Position.Location.Y);
		}		

		/// <summary>
		/// Scenario: Mission control would like to know the rover's position
		///    Given: Command is sent to get the rovers position
		///     Then: Message is sent back with position.
		/// </summary>
		[TestMethod]
		public void Rover_Get_Initial_Position()
		{
			var rover = new Rover();

			rover.Initialize();

			var position = new Position()
			{
				Orientation = 'N',
				Location = new Coordinate() { X = 0, Y = 0 }
			};

			Assert.AreEqual(position.Orientation, rover.Position.Orientation);
			Assert.AreEqual(position.Location.X, rover.Position.Location.X);
			Assert.AreEqual(position.Location.Y, rover.Position.Location.Y);
		}

		/// <summary>
		/// Scenario: An invalid command is sent to the rover
		///    Given: Command 'X' is sent to the rover
		///      And: 'X' is an invalid command
		///     Then: Message is sent back to mission control stating an invalid command was sent
		///      And: Rover will not move
		///      And: Rover will not change direction
		/// </summary>
		[TestMethod]
		public void Invalid_Command_Is_Entered()
		{
			char[] commands = null;

			var rover = new Rover();

			rover.Initialize();

			var response = rover.ProcessCommands(commands);

			Assert.AreEqual("Invalid command 'X' found.", response);
		}

		[TestMethod]
		public void No_Command_Is_Entered()
		{
			char[] commands = null;

			var rover = new Rover();

			rover.Initialize();

			var response = rover.ProcessCommands(commands);

			Assert.AreEqual("No commands found to process.", response);
		}

		/// <summary>
		/// Scenario: Rover moves forward 1 unit on the grid
		///    Given: 'f' command is processed
		///     Then: Rover position is incremented by 1 unit
		///      And: Rover direction is unchanged
		/// </summary>
		[TestMethod]
		public void Rover_Move_Forward()
		{
		}

		/// <summary>
		/// Scenario: Rover moves backward 1 unit on the grid
		///    Given: 'b' command is processed
		///     Then: Rover position is decremented by 1 unit
		///      And: Rover direction is unchanged
		/// </summary>
		[TestMethod]
		public void Rover_Move_Backward()
		{
		}

		/// <summary>
		/// Scenario: Rover turns left
		///    Given: 'l' command is processed
		///     Then: Rover direction is updated to reflect a left turn
		///      And: Rover position is unchanged
		/// </summary>
		[TestMethod]
		public void Rover_Move_Left()
		{
		}

		/// <summary>
		/// Scenario: Rover turns left
		///    Given: 'r' command is processed
		///     Then: Rover direction is updated to reflect a right turn
		///      And: Rover position is unchanged
		/// </summary>
		[TestMethod]
		public void Rover_Move_Right()
		{
		}		
	}
}