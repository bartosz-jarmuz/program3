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
            InputSelectedCounter.SelectedIndex = 1;
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
                ConvertToNumeric Numeric = new ConvertToNumeric(textBox1.Text, textBox2.Text);
                CounterDelay Counter = new CounterDelay(Numeric.ReturnNumericDelayTime(textBox1.Text), Numeric.ReturnNumericcountTill(textBox2.Text));
                CounterList.Add(Counter);
                OutputTextBox.AppendText($"Counter {CounterList.Count.ToString()} - Counting till {Numeric.ReturnNumericcountTill(textBox2.Text)} Delay -{Numeric.ReturnNumericDelayTime(textBox1.Text)}\r\n");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
		{	
			OutputTextBox.Clear();
            OutputCounters();
        }

        private void InputSelectedCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputSelectedCounter.SelectedIndex == 0) //TEXT
            {
                PanelTextInput.Visible = true;
                PanelNumericInput.Visible = false;
            }
            else if (InputSelectedCounter.SelectedIndex == 1) //NUMERIC
            {
                PanelTextInput.Visible = false;
                PanelNumericInput.Visible = true;
            }
        }

        private async void OutputCounters()
        {
            foreach (var counter in CounterList)
            {
                await Task.Run(() => {
                    counter.Count((x) => OutputTextBox.AppendText($"{x}"));
                });
                //counterx.Count((x) => OutputTextBox.AppendText($"{x}"));
                OutputTextBox.AppendText("\r\n");
            }
        }
    }
}
