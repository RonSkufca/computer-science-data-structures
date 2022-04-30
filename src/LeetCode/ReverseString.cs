namespace LeetCode
{
	internal class StringReverser
	{
		/// <summary>
		/// In the 2 pointer algorithm we have an array with 2 pointers
		/// 1 at the beginning
		/// 1 at the end
		/// We loop until the pointer at the beginning is less than the pointer at the end
		/// </summary>
		/// <param name="s"></param>
		public void ReverseUsingTwoPointerApproach(char[] s)
		{
			int ptrStart = 0;
			int ptrEnd = s.Length - 1;
			char temp;

			while(ptrStart <= ptrEnd)
			{
				temp = s[ptrStart];
				s[ptrStart] = s[ptrEnd];
				s[ptrEnd] = temp;
				ptrStart++;	
				ptrEnd--;
			}

			Console.WriteLine(s.ToArray());	
		}
	}
}
