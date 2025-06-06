﻿using System;
using System.Windows.Forms;

namespace CpuSchedulingWinForms
{
    /// <summary>
    /// Main form for demonstrating CPU scheduling algorithms.
    /// </summary>
    public partial class CpuSchedulerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CpuSchedulerForm"/> class.
        /// </summary>
        public CpuSchedulerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles dashboard navigation.
        /// </summary>
        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            //dashBoardTab.Show();
            this.tabSelection.SelectTab(0);
            this.sidePanel.Height = btnDashBoard.Height;
            this.sidePanel.Top = btnDashBoard.Top;

        }

        /// <summary>
        /// Navigates to the CPU scheduler tab.
        /// </summary>
        private void CpuSchedulerButton_Click(object sender, EventArgs e)
        {
            //this.dashBoardTab.Show();
            this.tabSelection.SelectTab(1);
            this.sidePanel.Height = btnCpuScheduler.Height;
            this.sidePanel.Top = btnCpuScheduler.Top;

        }


        /// <summary>
        /// Executes the First-Come, First-Served algorithm.
        /// </summary>
        private void FirstComeFirstServeButton_Click(object sender, EventArgs e)
        {
            if (txtProcess.Text != "")
            {
                Algorithms.RunFirstComeFirstServe(txtProcess.Text);
                int processCount = Int16.Parse(txtProcess.Text);
                if (processCount <= 10)
                {
                    this.progressBar1.Increment(4); //cpu progress bar
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(13);
                    this.progressBar2.SetState(1);
                }
                else if (processCount > 10)
                {
                    this.progressBar1.Increment(15);
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(38); //memory progress bar
                    this.progressBar2.SetState(3);
                }

                listView1.Clear();
                listView1.View = View.Details;

                listView1.Columns.Add("Process ID", 150, HorizontalAlignment.Center);
                listView1.Columns.Add("Quantum Time", 100, HorizontalAlignment.Center);

                for (int i = 0; i < processCount; i++)
                {
                    //listBoxProcess.Items.Add(" Process " + (i + 1));
                    var item = new ListViewItem();
                    item.Text = "Process " + (i + 1);
                    item.SubItems.Add("-");
                    listView1.Items.Add(item);
                }
                //listBoxProcess.Items.Add("\n");
                //listBoxProcess.Items.Add(" Total number of processes executed: " + processCount);
                listView1.Items.Add("\n");
                listView1.Items.Add("CPU handles: " + processCount);
            }
            else
            {
                MessageBox.Show("Enter number of processes", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcess.Focus();
            }
        }

        /// <summary>
        /// Executes the Shortest Job First algorithm.
        /// </summary>
        private void ShortestJobFirstButton_Click(object sender, EventArgs e)
        {
            if (txtProcess.Text != "")
            {
                Algorithms.RunShortestJobFirst(txtProcess.Text);
                int processCount = Int16.Parse(txtProcess.Text);
                if (processCount <= 10)
                {
                    this.progressBar1.Increment(4); //cpu progress bar
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(13);
                    this.progressBar2.SetState(1);
                }
                else if (processCount > 10)
                {
                    this.progressBar1.Increment(15);
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(38); //memory progress bar
                    this.progressBar2.SetState(3);
                }

                listView1.Clear();
                listView1.View = View.Details;

                listView1.Columns.Add("Process ID", 150, HorizontalAlignment.Center);
                listView1.Columns.Add("Quantum Time", 100, HorizontalAlignment.Center);

                for (int i = 0; i < processCount; i++)
                {
                    var item = new ListViewItem();
                    item.Text = "Process " + (i + 1);
                    item.SubItems.Add("-");
                    listView1.Items.Add(item);
                }

                listView1.Items.Add("\n");
                listView1.Items.Add("CPU handles: " + processCount);
            }
            else
            {
                MessageBox.Show("Enter number of processes", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcess.Focus();
            }
        }

        /// <summary>
        /// Executes the Priority algorithm.
        /// </summary>
        private void PriorityButton_Click(object sender, EventArgs e)
        {
            if (txtProcess.Text != "")
            {
                Algorithms.RunPriorityScheduling(txtProcess.Text);
                int processCount = Int16.Parse(txtProcess.Text);
                if (processCount <= 10)
                {
                    this.progressBar1.Increment(4); //cpu progress bar
                    this.progressBar1.SetState(1);  //cpu color progress bar
                    this.progressBar2.Increment(13);
                    this.progressBar2.SetState(1);
                }
                else if (processCount > 10)
                {
                    this.progressBar1.Increment(15);
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(38); //memory progress bar
                    this.progressBar2.SetState(3);   //memory color progress bar
                }
                listView1.Clear();
                listView1.View = View.Details;

                listView1.Columns.Add("Process ID", 150, HorizontalAlignment.Center);
                listView1.Columns.Add("Quantum Time", 100, HorizontalAlignment.Center);

                for (int i = 0; i < processCount; i++)
                {
                    var item = new ListViewItem();
                    item.Text = "Process " + (i + 1);
                    item.SubItems.Add("-");
                    listView1.Items.Add(item);
                }

                listView1.Items.Add("\n");
                listView1.Items.Add("CPU handles : " + processCount);
            }
            else
            {
                MessageBox.Show("Enter number of processes", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcess.Focus();
            }
        }

        /// <summary>
        /// Occurs when the process count text changes.
        /// </summary>
        private void ProcessTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Restarts the application.
        /// </summary>
        private void RestartApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            CpuSchedulerForm cpuScheduler = new CpuSchedulerForm();
            cpuScheduler.ShowDialog();
        }



        /// <summary>
        /// Handles form load logic.
        /// </summary>
        private void CpuSchedulerForm_Load(object sender, EventArgs e)
        {
            this.sidePanel.Height = btnDashBoard.Height;
            this.sidePanel.Top = btnDashBoard.Top;
            this.progressBar1.Increment(5);
            this.progressBar2.Increment(17);
            listView1.View = View.Details;
            listView1.GridLines = true;
        }

        /// <summary>
        /// Begins the fade out sequence and exits the application.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            timer1.Start();
        }

        /// <summary>
        /// Placeholder event for an unused picture box.
        /// </summary>
        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Executes the Round Robin algorithm.
        /// </summary>
        private void RoundRobinButton_Click(object sender, EventArgs e)
        {
            if (txtProcess.Text != "")
            {
                Algorithms.RunRoundRobin(txtProcess.Text);
                int processCount = Int16.Parse(txtProcess.Text);
                if (processCount <= 10)
                {
                    this.progressBar1.Increment(4); //cpu progress bar
                    this.progressBar1.SetState(1);  //cpu color progress bar
                    this.progressBar2.Increment(13);
                    this.progressBar2.SetState(1);
                }
                else if (processCount > 10)
                {
                    this.progressBar1.Increment(15);
                    this.progressBar1.SetState(1);
                    this.progressBar2.Increment(38); //memory progress bar
                    this.progressBar2.SetState(3);   //memory color progress bar
                }
                string quantumTime = Helper.QuantumTime;
                listView1.Clear();
                listView1.View = View.Details;

                listView1.Columns.Add("Process ID", 150, HorizontalAlignment.Center);
                listView1.Columns.Add("Quantum Time", 100, HorizontalAlignment.Center);

                for (int i = 0; i < processCount; i++)
                {
                    var item = new ListViewItem();
                    item.Text = "Process " + (i + 1);
                    item.SubItems.Add(quantumTime);
                    listView1.Items.Add(item);
                }

                listView1.Items.Add("\n");
                listView1.Items.Add("CPU handles: " + processCount);
            }
            else
            {
                MessageBox.Show("Enter number of processes", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcess.Focus();
            }
        }

        /// <summary>
        /// Handles opacity fade out then closes the application.
        /// </summary>
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.021;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

    }
}