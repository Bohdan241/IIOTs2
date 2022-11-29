using System;
using System.Windows.Forms;
using S7PROSIMLib;

namespace IIoT2
{
    public partial class Form1 : Form
    {
        public S7ProSim PS = new S7ProSim();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {         
            PS.Connect();
            PS.SetState("RUN");
            PS.SetScanMode(ScanModeConstants.ContinuousScan);

            label_connection.Text = "Підключення";
            label_connection.ForeColor = System.Drawing.Color.Green;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            PS.SetState("STOP");
            PS.Disconnect();

            label_connection.Text = "Відключення";
            label_connection.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void checkBox_I00_CheckedChanged(object sender, EventArgs e)
        {
            object I0_0 = checkBox_I00.Checked;
            PS.WriteInputPoint(0, 0, ref I0_0);
        }

        private void checkBox_I01_CheckedChanged(object sender, EventArgs e)
        {
            object I0_1 = checkBox_I01.Checked;
            PS.WriteInputPoint(0, 1, ref I0_1);
        }

        private void checkBox_I02_CheckedChanged(object sender, EventArgs e)
        {
            object I0_2 = checkBox_I02.Checked;
            PS.WriteInputPoint(0, 2, ref I0_2);
        }

        private void checkBox_I03_CheckedChanged(object sender, EventArgs e)
        {
            object I0_3 = checkBox_I03.Checked;
            PS.WriteInputPoint(0, 3, ref I0_3);
        }

        private void checkBox_I04_CheckedChanged(object sender, EventArgs e)
        {
            object I0_4 = checkBox_I04.Checked;
            PS.WriteInputPoint(0, 4, ref I0_4);
        }

        private void timer_read_output_Tick(object sender, EventArgs e)
        {
            object Q0_0 = false;
            PS.ReadOutputPoint(0, 0, PointDataTypeConstants.S7_Bit, ref Q0_0);
            
            if ((bool)Q0_0)
            {
                label_status.Text = "Відчинені";
                label_status.ForeColor = System.Drawing.Color.Green;
                pictureBox1.Image = Properties.Resources.open;
            }
            else
            {
                label_status.Text = "Зачинені";
                label_status.ForeColor = System.Drawing.Color.Red;
                pictureBox1.Image = Properties.Resources.closed;
            }
        }
    }
}
