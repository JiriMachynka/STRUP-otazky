using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace STRUP_Otázky
{
    public partial class Testovac : Form
    {
        public Testovac()
        {
            InitializeComponent();
            LoadQuestions();
            ShowQuestion();
        }

        List<string> questions = new List<string>();
        int[] points = new int[4];

        int pointCount = 0;
        int questionCount = 0;

        void LoadQuestions()
        {
            questions = File.ReadAllLines(@"C:\Users\jirka\Desktop\Programování\C#\STRUP-Otázky\STRUP-otazky.txt").ToList();
        }

        void ShowQuestion()
        {
            lblQCount.Text = "Počet otázek: " + questionCount.ToString();
            lblPoints.Text = "Body: " + pointCount.ToString();
            Random random = new Random();
            int index = random.Next(0, questions.Count / 5);
            tbQuestion.Text = questions[index * 5];
            points[0] = int.Parse(questions[index * 5 + 1].Split(' ')[0]);
            points[1] = int.Parse(questions[index * 5 + 2].Split(' ')[0]);
            points[2] = int.Parse(questions[index * 5 + 3].Split(' ')[0]);
            points[3] = int.Parse(questions[index * 5 + 4].Split(' ')[0]);
            lblAns0.Text = questions[index * 5 + 1].Substring(2);
            lblAns1.Text = questions[index * 5 + 2].Substring(2);
            lblAns2.Text = questions[index * 5 + 3].Substring(2);
            lblAns3.Text = questions[index * 5 + 4].Substring(2);
        }

        string CorrectAnswer()
        {
            int index = 0;
            foreach (Control c in gbAns.Controls)
            {
                if (points[index] == 1)
                {
                    index = 0;
                    return c.Text.ToString();
                }
                else index++;
            }
            return "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbAns.Controls)
            {
                if (c.BackColor == Color.Green)
                {
                    int index = int.Parse(c.Name.ToString().Last().ToString());
                    if (points[index] == 0)
                    {
                        MessageBox.Show("Správná odpoveď: " + CorrectAnswer(), "", MessageBoxButtons.OK);
                    }
                    pointCount += points[index];
                    questionCount++;
                }
            }

            ShowQuestion();
            // Reseting label highlighting
            foreach (Control c in gbAns.Controls)
                if (c.BackColor == Color.Green) c.BackColor = Color.Transparent;
        }

        private void ans_click(object sender, EventArgs e)
        {
            // If other label is highlighted, its highlighting is removed
            foreach (Control c in gbAns.Controls)
                if (c.BackColor == Color.Green) c.BackColor = Color.Transparent;
            // Highlighting label we clicked
            ((Control)sender).BackColor = Color.Green;
        }
    }
}
