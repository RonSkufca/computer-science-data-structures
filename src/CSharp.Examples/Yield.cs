namespace CSharp.Examples
{
	internal class Yield
	{
        public void Consumer()
        {
            // Code inside CreateSimpleIterator will NOT execute.
            IEnumerable<int> enumerable = CreateSimpleIterator();

            // Code inside CreateSimpleIterator will NOT execute.
            using(IEnumerator<int> enumerator = enumerable.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    int value = enumerator.Current;
                    Console.WriteLine(value);
                }
			}
        }

        public IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;

            for(int i = 0; i < 3; i++)
                yield return i;

            yield return 20;
        }

        public void ConsumeFibonacci()
        {
            foreach(var value in Fibonacci())
            {
                Console.WriteLine(value);

                if(value > 1000)
                    break;
			}
		}

        public IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;

            while(true)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;        
			}
		}

        
    }
}
