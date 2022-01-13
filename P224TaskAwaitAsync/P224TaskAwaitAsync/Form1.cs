using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P224TaskAwaitAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_1_Click(object sender, EventArgs e)
        {
            long result =await CalculateAsync();

            #region Comment
            //Task task = Task.Run(() => 
            //{
            //    for (long i = 0; i < 999999999; i++)
            //    {
            //        result += i;
            //    }
            //});

            //await task;
            #endregion

            lbl_1.Text = "Hello World "+result;
        }

        private async static Task<long> CalculateAsync()
        {
            long result = 0;

            Task task = Task.Run(() =>
            {
                for (long i = 0; i < 999999999; i++)
                {
                    result += i;
                }
            });

            await task;

            return result;
        }

        private async void btn_2_Click(object sender, EventArgs e)
        {
            long result = await CalculateAsync();

            #region Comment
            //Task task = Task.Run(() => 
            //{
            //    for (long i = 0; i < 999999999; i++)
            //    {
            //        result += i;
            //    }
            //});

            //await task;
            #endregion

            lbl_2.Text = "P224 "+result;
        }
    }
}
