using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingAsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<int> CalculateAsync()
        {
            await Task.Delay(7000); //UI should respond within these 7 seconds
            return 123;
        }

        private async void Btn_Calculate_Click(object sender, EventArgs e)
        {
            int value = await CalculateAsync();
            LblResult.Text = value.ToString();
        }
    }
}
