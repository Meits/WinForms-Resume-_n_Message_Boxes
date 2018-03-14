using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.Run(new MyForm("My Resume"));
        }
    }

    class MyForm : Form {

        public MyForm(string text)
        {
            this.Text = text;
            //this.BackColor = 
            this.Size = new System.Drawing.Size(500,300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.CadetBlue;

            Label mylabel = new Label();
            mylabel.Location = new System.Drawing.Point(0,50);
            mylabel.Size = new System.Drawing.Size(500,150);
            mylabel.Text = "Для начала нажмите клавишу мыши!";
            mylabel.Font = new System.Drawing.Font("Arial", 25, System.Drawing.FontStyle.Bold);
            mylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(mylabel);

            mylabel.Click += new EventHandler(ClickHandler);
        }

        public void ClickHandler(Object sender, EventArgs e)
        {
            String[] Resume = new String[] {
                "page 1",
                "page 2",
                "page 3",
                "page 4",
                "page 5",
            };

            int i = 1, countSymbols = 0;
            string caption;

            foreach(var item in Resume)
            {
                caption = "Страница #" + i;
                countSymbols += item.Length;
                if(i == Resume.Length)
                {
                    caption = "Страница #" + i + "| Среднее количество символов - " + countSymbols/i;
                }
                MessageBox.Show(item, caption, MessageBoxButtons.OKCancel);
                ++i;
            }
            //MessageBox.Show("Click","caption", MessageBoxButtons.OKCancel);
        }

    }
}
