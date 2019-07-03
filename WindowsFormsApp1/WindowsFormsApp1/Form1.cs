using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Counter.BusinessLogic;

namespace Counter.WinForms
{
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
        }

        List<CounterDelay> CounterList = new List<CounterDelay>();

        private void AddCounterButton_Click(object sender, EventArgs e)
        {
            int delayTime = Decimal.ToInt32(InputDelayTime.Value);
            int countTill = Decimal.ToInt32(CountTill.Value);

            CounterDelay Counter = new CounterDelay(delayTime, countTill);
            CounterList.Add(Counter);
            OutputTextBox.AppendText($"Counter {CounterList.Count.ToString()} - Counting till {countTill} Delay -{delayTime}\r\n");
        }

        private void StartButton_Click(object sender, EventArgs e)
		{	
			OutputTextBox.Clear();
            //int delayTime = Decimal.ToInt32(InputDelayTime.Value);
            //int countTill = Decimal.ToInt32(CountTill.Value);
            //CounterDelay counter = new CounterDelay();

            //Action<int> callback = output;
            //counter.Count(countTill, delayTime, (x)=> OutputTextBox.AppendText($"{x}"));

            //counter.Count(countTill, delayTime, callback);

            //OutputCounters();
            //OutputCounters();
            BeginInvoke(new Action (() =>OutputCounters()));
            
        }

        private async void OutputCounters()
        {
            foreach (var counterx in CounterList)
            {   
                counterx.Count((x) =>  OutputTextBox.AppendText($"{x}"));
                OutputTextBox.AppendText("\r\n");
                
            }
            
        }

        //private void OutputCounters(int x)
        //{
        //    OutputTextBox.AppendText($"{x}");
        //}

    }
}
