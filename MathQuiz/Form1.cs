using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class frmMain : Form
    {
        private int timeLeft = 60;
        private Quiz quiz1, quiz2, quiz3, quiz4;
        private Random random = new Random();
        // private bool isRunning = false;

        public frmMain()
        {
            InitializeComponent();
        }
        private void CheckAnswers()
        {
            SystemSounds.Exclamation.Play();

            int correctAnswers = 0;
            if (quiz1.Result == numQ1.Value) correctAnswers++;
            if (quiz2.Result == numQ1.Value) correctAnswers++;
            if (quiz3.Result == numQ1.Value) correctAnswers++;
            if (quiz4.Result == numQ1.Value) correctAnswers++;

            MessageBox.Show(String.Format("Liczba poprawnych odpowiedzi = {0}", correctAnswers));

            setupQuiz();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            setupQuiz();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = String.Format("Pozostaly czas: {0}sek.", timeLeft);
            if (timeLeft < 30)
            {
                lblTimer.ForeColor = Color.Green;
            }
            if (timeLeft < 15)
            {
                lblTimer.ForeColor = Color.Red;
            }

            if (timeLeft == 0)
            {
                timerQuiz.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timerQuiz.Enabled)
            {
                setupQuiz();
                timerQuiz.Enabled = true;
                btnStart.Text = "STOP";

            } else
          
            {
                timerQuiz.Enabled = false;
                CheckAnswers();
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            String message = "Czy na pewno chcesz zamknac okno?";
            String caption = "Pytanie";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private int RandomNumber(int min, int max)
        {
            
            return random.Next(min, max);
        }

        public void setupQuiz()
        {
            quiz1 = new Quiz(RandomNumber(-10, 10), RandomNumber(-10, 10), "+");
            quiz2 = new Quiz(RandomNumber(-10, 10), RandomNumber(-10, 10), "-");
            quiz3 = new Quiz(RandomNumber(-10, 10), RandomNumber(-10, 10), "*");
            quiz4 = new Quiz(RandomNumber(-10, 10), RandomNumber(-10, 10), "/");

            lblQ1.Text = quiz1.ToString();
            lblQ2.Text = quiz2.ToString();
            lblQ3.Text = quiz3.ToString();
            lblQ4.Text = quiz4.ToString();

            numQ1.Value = 0; numQ1.Minimum = Int32.MinValue; numQ1.Maximum = Int32.MaxValue;
            numQ2.Value = 0; numQ1.Minimum = Int32.MinValue; numQ2.Maximum = Int32.MaxValue;
            numQ3.Value = 0; numQ1.Minimum = Int32.MinValue; numQ3.Maximum = Int32.MaxValue;
            numQ4.Value = 0; numQ1.Minimum = Int32.MinValue; numQ4.Maximum = Int32.MaxValue;

            timeLeft = 60;
            lblTimer.Text = String.Format("Pozostaly czas: {0}sek.", timeLeft);
            lblTimer.ForeColor = Color.Black;

        }

    }
}
