using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamuraiSudokuSolver
{
    public partial class Form2 : Form
    {

        public static int sayilar = 5;
        public static List<TimeSpan> gecenSure = new List<TimeSpan>();
        public static List<int> bulunanKareler = new List<int>();
        public static List<int> siralama = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            gecenSure[0].ToString();
            chart1.Series["sudoku 1"].Points.AddXY("" + gecenSure[0 ].ToString(), 81 * bulunanKareler[0]);
            chart1.Series["sudoku 1"].Points.AddXY("" + gecenSure[1 ].ToString(), 81 * bulunanKareler[1]);
            chart1.Series["sudoku 1"].Points.AddXY("" + gecenSure[2 ].ToString(), 81 * bulunanKareler[2]);
            chart1.Series["sudoku 1"].Points.AddXY("" + gecenSure[3 ].ToString(), 81 * bulunanKareler[3]);
            chart1.Series["sudoku 1"].Points.AddXY("" + gecenSure[4 ].ToString(), 81 * bulunanKareler[4]);


            Label label1 = new Label();
            label1.SetBounds(175, 375, 100, 100);
            label1.Text = "thread " + (siralama[0]+1);
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label1);


            Label label2 = new Label();
            label2.SetBounds(300, 375, 100, 100);
            label2.Text = "thread " + (siralama[1]+1);
            label2.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label2);

            Label label3 = new Label();
            label3.SetBounds(425, 375, 100, 100);
            label3.Text = "thread " + (siralama[2]+1);
            label3.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label3);


            Label label4 = new Label();
            label4.SetBounds(550, 375, 100, 100);
            label4.Text = "thread " + (siralama[3]+1);
            label4.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label4);

            Label label5 = new Label();
            label5.SetBounds(675, 375, 100, 100);
            label5.Text = "thread " + (siralama[4]+1);
            label5.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label5);

            Label label6 = new Label();
            label6.SetBounds(20, 5, 100, 100);
            label6.Text = "kare sayısı ";
            label6.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label6);

            Label label7 = new Label();
            label7.SetBounds(800, 360, 100, 100);
            label7.Text = "zaman";
            label7.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label7);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
