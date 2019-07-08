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
            if (InputSelectedCounter.SelectedIndex == 1) //NUMERIC
            {
                int delayTime = Decimal.ToInt32(InputDelayTime.Value);
                int countTill = Decimal.ToInt32(CountTill.Value);

                CounterDelay Counter = new CounterDelay(delayTime, countTill);
                CounterList.Add(Counter);
                OutputTextBox.AppendText($"Counter {CounterList.Count.ToString()} - Counting till {countTill} Delay -{delayTime}\r\n");
            }
            else if (InputSelectedCounter.SelectedIndex == 0) //TEXT
            {
                ConvertToNumeric num = new ConvertToNumeric(textBox1.Text, textBox2.Text);
                CounterDelay Counter = new CounterDelay(num.ReturnNumericDelayTime(textBox1.Text), num.ReturnNumericcountTill(textBox2.Text));
                CounterList.Add(Counter);
                OutputTextBox.AppendText($"Counter {CounterList.Count.ToString()} - Counting till {num.ReturnNumericcountTill(textBox2.Text)} Delay -{num.ReturnNumericDelayTime(textBox1.Text)}\r\n");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
		{	
			OutputTextBox.Clear();

            foreach (var counterx in CounterList)
            {
                counterx.Count((x) => OutputTextBox.AppendText($"{x}"));
                OutputTextBox.AppendText("\r\n");
            }
            //int delayTime = Decimal.ToInt32(InputDelayTime.Value);
            //int countTill = Decimal.ToInt32(CountTill.Value);
            //CounterDelay counter = new CounterDelay();

            //Action<int> callback = output;
            //counter.Count(countTill, delayTime, (x)=> OutputTextBox.AppendText($"{x}"));

            //counter.Count(countTill, delayTime, callback);

            //OutputCounters();
            //OutputCounters();
            //BeginInvoke(new Action (() =>OutputCounters()));

        }

        private void InputSelectedCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputSelectedCounter.SelectedIndex == 0) //TEXT
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else if (InputSelectedCounter.SelectedIndex == 1) //NUMERIC
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        //private async void OutputCounters()
        //{
        //    foreach (var counterx in CounterList)
        //    {   
        //        counterx.Count((x) =>  OutputTextBox.AppendText($"{x}"));
        //        OutputTextBox.AppendText("\r\n");

        //    }

        //}



        //private void OutputCounters(int x)
        //{
        //    OutputTextBox.AppendText($"{x}");
        //}

    }
}
