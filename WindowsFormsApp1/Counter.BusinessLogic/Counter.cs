using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Counter.BusinessLogic
{

	public class CounterDelay
	{

        private int delayTime;
        private int countTill;

        public CounterDelay(int delay, int count)
        {
            delayTime = delay;
            countTill = count;
        }

        public void Count(Action<int> whenWaitingIsFinished)
		{
			for (int i = 0; i < countTill; i++)
			{
				Thread.Sleep(delayTime);
				whenWaitingIsFinished(i);
			}
		}
	}
}
