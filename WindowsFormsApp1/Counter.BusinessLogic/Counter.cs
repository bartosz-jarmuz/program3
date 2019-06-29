using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Counter.BusinessLogic
{

	public class CounterDelay
	{

		public void Count(int countTill, int delayTime, Action<int> whenWaitingIsFinished)
		{
			for (int i = 0; i < countTill; i++)
			{
				Thread.Sleep(delayTime);
				whenWaitingIsFinished(i);
			}
		}
	}
}
