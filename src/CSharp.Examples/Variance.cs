
namespace CSharp.Examples
{
	public class Variance
	{
		// IList is invariant as it contains no 'in' or 'out' parameters
		public void PrintLifeForms(IList<LifeForm> lifeForms)
		{
			foreach(var lifeForm in lifeForms)
			{
				Console.WriteLine(lifeForm.GetType().ToString());
			}
		}
	}

	public abstract class LifeForm { }

	public abstract class Animal : LifeForm { }

	public class Giraffe : Animal { }

	public class Zebra : Animal { }
}
