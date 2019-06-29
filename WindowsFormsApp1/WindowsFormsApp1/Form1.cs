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
		
		private void StartButton_Click(object sender, EventArgs e)
		{
			
			OutputTextBox.Clear();

			int delayTime = Decimal.ToInt32(InputDelayTime.Value);
			int countTill = Decimal.ToInt32(CountTill.Value);

			CounterDelay counter = new CounterDelay();

			Action<int> callback = output;
			//counter.Count(countTill, delayTime, (x)=> OutputTextBox.AppendText($"{x}"));

			counter.Count(countTill, delayTime, callback);

		}

		private void output(int x)
		{
			OutputTextBox.AppendText($"{x}");
		}
	}
}
