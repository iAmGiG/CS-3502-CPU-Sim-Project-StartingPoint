using System;
using System.Windows.Forms;

namespace CpuScheduler
{
    public static class Algorithms
    {
        public class Process
        {
            public int Id { get; set; }
            public double BurstTime { get; set; }
            public int Priority { get; set; }
            public double ArrivalTime { get; set; }
        }

        /// <summary>
        /// Executes the First Come First Serve scheduling algorithm.
        /// </summary>
        /// <param name="processCountInput">The number of processes to schedule.</param>
        public static void RunFirstComeFirstServe(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] burstTimes = new double[processCount];
            double[] waitingTimes = new double[processCount];
            double totalWaitingTime = 0.0;
            double averageWaitingTime;
            int i;

            DialogResult result = MessageBox.Show(
                "First Come First Serve Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (i = 0; i < processCount; i++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter Burst time:",
                        "Burst time for P" + (i + 1),
                        string.Empty,
                        -1,
                        -1);

                    if (!double.TryParse(input, out burstTimes[i]) || burstTimes[i] < 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                for (i = 0; i < processCount; i++)
                {
                    if (i == 0)
                    {
                        waitingTimes[i] = 0;
                    }
                    else
                    {
                        waitingTimes[i] = waitingTimes[i - 1] + burstTimes[i - 1];
                        MessageBox.Show(
                            "Waiting time for P" + (i + 1) + " = " + waitingTimes[i],
                            "Job Queue",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None);
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    totalWaitingTime = totalWaitingTime + waitingTimes[i];
                }
                averageWaitingTime = totalWaitingTime / processCount;
                MessageBox.Show(
                    "Average waiting time for " + processCount + " processes = " + averageWaitingTime + " sec(s)",
                    "Average Waiting Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
        }

        /// <summary>
        /// Executes the Shortest Job First scheduling algorithm.
        /// </summary>
        /// <param name="processCountInput">The number of processes to schedule.</param>
        public static void RunShortestJobFirst(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] burstTimes = new double[processCount];
            double[] waitingTimes = new double[processCount];
            double[] sortedBurstTimes = new double[processCount];
            double totalWaitingTime = 0.0;
            double averageWaitingTime;
            int x, i;
            double temp = 0.0;
            bool found = false;

            DialogResult result = MessageBox.Show(
                "Shortest Job First Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (i = 0; i < processCount; i++)
                {
                    string input =
                        Microsoft.VisualBasic.Interaction.InputBox("Enter burst time: ",
                                                           "Burst time for P" + (i + 1),
                                                           "",
                                                           -1, -1);

                    if (!double.TryParse(input, out burstTimes[i]) || burstTimes[i] < 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    sortedBurstTimes[i] = burstTimes[i];
                }
                for (x = 0; x <= processCount - 2; x++)
                {
                    for (i = 0; i <= processCount - 2; i++)
                    {
                        if (sortedBurstTimes[i] > sortedBurstTimes[i + 1])
                        {
                            temp = sortedBurstTimes[i];
                            sortedBurstTimes[i] = sortedBurstTimes[i + 1];
                            sortedBurstTimes[i + 1] = temp;
                        }
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    if (i == 0)
                    {
                        for (x = 0; x < processCount; x++)
                        {
                            if (sortedBurstTimes[i] == burstTimes[x] && found == false)
                            {
                                waitingTimes[i] = 0;
                                MessageBox.Show(
                                    "Waiting time for P" + (x + 1) + " = " + waitingTimes[i],
                                    "Waiting time:",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
                                burstTimes[x] = 0;
                                found = true;
                            }
                        }
                        found = false;
                    }
                    else
                    {
                        for (x = 0; x < processCount; x++)
                        {
                            if (sortedBurstTimes[i] == burstTimes[x] && found == false)
                            {
                                waitingTimes[i] = waitingTimes[i - 1] + sortedBurstTimes[i - 1];
                                MessageBox.Show(
                                    "Waiting time for P" + (x + 1) + " = " + waitingTimes[i],
                                    "Waiting time",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
                                burstTimes[x] = 0;
                                found = true;
                            }
                        }
                        found = false;
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    totalWaitingTime = totalWaitingTime + waitingTimes[i];
                }
                averageWaitingTime = totalWaitingTime / processCount;
                MessageBox.Show(
                    "Average waiting time for " + processCount + " processes = " + averageWaitingTime + " sec(s)",
                    "Average waiting time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Executes the Priority scheduling algorithm.
        /// </summary>
        /// <param name="processCountInput">The number of processes to schedule.</param>
        public static void RunPriorityScheduling(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Priority Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                double[] burstTimes = new double[processCount];
                double[] waitingTimes = new double[processCount + 1];
                int[] priorities = new int[processCount];
                int[] sortedPriorities = new int[processCount];
                int x, i;
                double totalWaitingTime = 0.0;
                double averageWaitingTime;
                int temp = 0;
                bool found = false;
                for (i = 0; i < processCount; i++)
                {
                    string input =
                        Microsoft.VisualBasic.Interaction.InputBox("Enter burst time: ",
                                                           "Burst time for P" + (i + 1),
                                                           "",
                                                           -1, -1);
                    if (!double.TryParse(input, out burstTimes[i]) || burstTimes[i] < 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    string input2 =
                        Microsoft.VisualBasic.Interaction.InputBox("Enter priority: ",
                                                           "Priority for P" + (i + 1),
                                                           "",
                                                           -1, -1);
                    if (!int.TryParse(input2, out priorities[i]) || priorities[i] < 0)
                    {
                        MessageBox.Show("Invalid priority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    sortedPriorities[i] = priorities[i];
                }
                for (x = 0; x <= processCount - 2; x++)
                {
                    for (i = 0; i <= processCount - 2; i++)
                    {
                        if (sortedPriorities[i] > sortedPriorities[i + 1])
                        {
                            temp = sortedPriorities[i];
                            sortedPriorities[i] = sortedPriorities[i + 1];
                            sortedPriorities[i + 1] = temp;
                        }
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    if (i == 0)
                    {
                        for (x = 0; x < processCount; x++)
                        {
                            if (sortedPriorities[i] == priorities[x] && found == false)
                            {
                                waitingTimes[i] = 0;
                                MessageBox.Show(
                                    "Waiting time for P" + (x + 1) + " = " + waitingTimes[i],
                                    "Waiting time",
                                    MessageBoxButtons.OK);
                                temp = x;
                                priorities[x] = 0;
                                found = true;
                            }
                        }
                        found = false;
                    }
                    else
                    {
                        for (x = 0; x < processCount; x++)
                        {
                            if (sortedPriorities[i] == priorities[x] && found == false)
                            {
                                waitingTimes[i] = waitingTimes[i - 1] + burstTimes[temp];
                                MessageBox.Show(
                                    "Waiting time for P" + (x + 1) + " = " + waitingTimes[i],
                                    "Waiting time",
                                    MessageBoxButtons.OK);
                                temp = x;
                                priorities[x] = 0;
                                found = true;
                            }
                        }
                        found = false;
                    }
                }
                for (i = 0; i < processCount; i++)
                {
                    totalWaitingTime = totalWaitingTime + waitingTimes[i];
                }
                averageWaitingTime = totalWaitingTime / processCount;
                MessageBox.Show(
                    "Average waiting time for " + processCount + " processes = " + averageWaitingTime + " sec(s)",
                    "Average waiting time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Executes the Round Robin scheduling algorithm.
        /// </summary>
        /// <param name="processCountInput">The number of processes to schedule.</param>
        public static void RunRoundRobin(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index, counter = 0;
            double total;
            double timeQuantum;
            double waitTime = 0, turnaroundTime = 0;
            double averageWaitTime, averageTurnaroundTime;
            double[] arrivalTimes = new double[processCount];
            double[] burstTimes = new double[processCount];
            double[] remainingTimes = new double[processCount];
            int remainingProcesses = processCount;

            DialogResult result = MessageBox.Show(
                "Round Robin Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (index = 0; index < processCount; index++)
                {
                    string arrivalInput =
                            Microsoft.VisualBasic.Interaction.InputBox("Enter arrival time: ",
                                                               "Arrival time for P" + (index + 1),
                                                               "",
                                                               -1, -1);
                    if (!double.TryParse(arrivalInput, out arrivalTimes[index]) || arrivalTimes[index] < 0)
                    {
                        MessageBox.Show("Invalid arrival time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string burstInput =
                            Microsoft.VisualBasic.Interaction.InputBox("Enter burst time: ",
                                                               "Burst time for P" + (index + 1),
                                                               "",
                                                               -1, -1);
                    if (!double.TryParse(burstInput, out burstTimes[index]) || burstTimes[index] < 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    remainingTimes[index] = burstTimes[index];
                }
                string timeQuantumInput =
                            Microsoft.VisualBasic.Interaction.InputBox("Enter time quantum: ", "Time Quantum",
                                                               "",
                                                               -1, -1);

                if (!double.TryParse(timeQuantumInput, out timeQuantum) || timeQuantum <= 0)
                {
                    MessageBox.Show("Invalid quantum time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Helper.QuantumTime = timeQuantumInput;

                for (total = 0, index = 0; remainingProcesses != 0;)
                {
                    if (remainingTimes[index] <= timeQuantum && remainingTimes[index] > 0)
                    {
                        total = total + remainingTimes[index];
                        remainingTimes[index] = 0;
                        counter = 1;
                    }
                    else if (remainingTimes[index] > 0)
                    {
                        remainingTimes[index] = remainingTimes[index] - timeQuantum;
                        total = total + timeQuantum;
                    }
                    if (remainingTimes[index] == 0 && counter == 1)
                    {
                        remainingProcesses--;
                        MessageBox.Show("Turnaround time for Process " + (index + 1) + " : " + (total - arrivalTimes[index]), "Turnaround time for Process " + (index + 1), MessageBoxButtons.OK);
                        MessageBox.Show("Wait time for Process " + (index + 1) + " : " + (total - arrivalTimes[index] - burstTimes[index]), "Wait time for Process " + (index + 1), MessageBoxButtons.OK);
                        turnaroundTime = turnaroundTime + total - arrivalTimes[index];
                        waitTime = waitTime + total - arrivalTimes[index] - burstTimes[index];
                        counter = 0;
                    }
                    if (index == processCount - 1)
                    {
                        index = 0;
                    }
                    else if (arrivalTimes[index + 1] <= total)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }
                averageWaitTime = Convert.ToInt64(waitTime * 1.0 / processCount);
                averageTurnaroundTime = Convert.ToInt64(turnaroundTime * 1.0 / processCount);
                MessageBox.Show("Average wait time for " + processCount + " processes: " + averageWaitTime + " sec(s)", string.Empty, MessageBoxButtons.OK);
                MessageBox.Show("Average turnaround time for " + processCount + " processes: " + averageTurnaroundTime + " sec(s)", string.Empty, MessageBoxButtons.OK);
            }
        }
        public static void RunShortestRemainingTimeFirst(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] arrivalTimes = new double[processCount];
            double[] burstTimes = new double[processCount];
            double[] remainingTimes = new double[processCount];
            int[] processIds = new int[processCount];

            DialogResult result = MessageBox.Show(
                "Shortest Remaining Time First Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < processCount; i++)
                {
                    string arrivalInput =
                        Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter arrival time:",
                        "Arrival time for P" + (i + 1),
                        string.Empty,
                        -1,
                        -1);

                    if (!double.TryParse(arrivalInput, out arrivalTimes[i]) || arrivalTimes[i] < 0)
                    {
                        MessageBox.Show("Invalid arrival time", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string burstInput =
                        Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter burst time:",
                        "Burst time for P" + (i + 1),
                        string.Empty,
                        -1,
                        -1);

                    if (!double.TryParse(burstInput, out burstTimes[i]) || burstTimes[i] <= 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    remainingTimes[i] = burstTimes[i];
                    processIds[i] = i + 1;
                }

                double currentTime = 0;
                int completedProcesses = 0;
                double totalWaitingTime = 0;
                double totalTurnaroundTime = 0;
                int shortestProcessIndex = -1;
                double minRemainingTime = double.MaxValue;

                while (completedProcesses < processCount)
                {
                    shortestProcessIndex = -1;
                    minRemainingTime = double.MaxValue;

                    for (int i = 0; i < processCount; i++)
                    {
                        if (arrivalTimes[i] <= currentTime && remainingTimes[i] > 0)
                        {
                            if (remainingTimes[i] < minRemainingTime)
                            {
                                minRemainingTime = remainingTimes[i];
                                shortestProcessIndex = i;
                            }
                        }
                    }

                    if (shortestProcessIndex != -1)
                    {
                        remainingTimes[shortestProcessIndex]--;
                        currentTime++;

                        if (remainingTimes[shortestProcessIndex] == 0)
                        {
                            completedProcesses++;
                            double completionTime = currentTime;
                            double turnaroundTime = completionTime - arrivalTimes[shortestProcessIndex];
                            double waitingTime = turnaroundTime - burstTimes[shortestProcessIndex];
                            totalWaitingTime += waitingTime;
                            totalTurnaroundTime += turnaroundTime;

                            MessageBox.Show(
                                $"Process {processIds[shortestProcessIndex]} completed at time: {completionTime}\n" +
                                $"Waiting time: {waitingTime}\n" +
                                $"Turnaround time: {turnaroundTime}",
                                "Process Completed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        currentTime++;
                    }
                }

                double averageWaitingTime = totalWaitingTime / processCount;
                double averageTurnaroundTime = totalTurnaroundTime / processCount;

                MessageBox.Show(
                    $"Average waiting time for {processCount} processes: {averageWaitingTime} sec(s)\n" +
                    $"Average turnaround time for {processCount} processes: {averageTurnaroundTime} sec(s)",
                    "Average Times",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public static void RunLotteryScheduling(string processCountInput)
        {
            if (!int.TryParse(processCountInput, out int processCount) || processCount <= 0)
            {
                MessageBox.Show("Invalid number of processes", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Lottery Scheduling",
                string.Empty,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                double[] burstTimes = new double[processCount];
                int[] priorities = new int[processCount];
                int[] tickets = new int[processCount];
                double[] waitingTimes = new double[processCount];
                double[] remainingTimes = new double[processCount];
                double totalWaitingTime = 0.0;
                double averageWaitingTime;

                for (int i = 0; i < processCount; i++)
                {
                    string input =
                        Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter burst time:",
                        "Burst time for P" + (i + 1),
                        string.Empty,
                        -1,
                        -1);

                    if (!double.TryParse(input, out burstTimes[i]) || burstTimes[i] < 0)
                    {
                        MessageBox.Show("Invalid burst time", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    remainingTimes[i] = burstTimes[i];
                }

                for (int i = 0; i < processCount; i++)
                {
                    string input2 =
                        Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter number of lottery tickets:",
                        "Tickets for P" + (i + 1),
                        string.Empty,
                        -1,
                        -1);

                    if (!int.TryParse(input2, out tickets[i]) || tickets[i] < 0)
                    {
                        MessageBox.Show("Invalid number of tickets", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                int totalTickets = 0;
                for (int i = 0; i < processCount; i++)
                {
                    totalTickets += tickets[i];
                }

                Random random = new Random();
                double currentTime = 0;
                int completedProcesses = 0;

                while (completedProcesses < processCount)
                {
                    if (totalTickets == 0)
                    {
                        MessageBox.Show("No processes with tickets remaining.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    int winningTicket = random.Next(1, totalTickets + 1);
                    int ticketCounter = 0;
                    int winnerIndex = -1;

                    for (int i = 0; i < processCount; i++)
                    {
                        if (remainingTimes[i] > 0)
                        {
                            ticketCounter += tickets[i];
                            if (winningTicket <= ticketCounter)
                            {
                                winnerIndex = i;
                                break;
                            }
                        }
                    }

                    if (winnerIndex != -1)
                    {
                        remainingTimes[winnerIndex]--;
                        currentTime++;
                        if (remainingTimes[winnerIndex] == 0)
                        {
                            completedProcesses++;
                            tickets[winnerIndex] = 0;
                            totalTickets = 0;
                            for (int i = 0; i < processCount; i++)
                            {
                                totalTickets += tickets[i];
                            }
                            double waitingTime = currentTime - burstTimes[winnerIndex];
                            waitingTimes[winnerIndex] = waitingTime;
                            totalWaitingTime += waitingTime;
                        }
                    }
                }

                averageWaitingTime = totalWaitingTime / processCount;
                MessageBox.Show(
                    "Average waiting time for " + processCount + " processes = " +
                    averageWaitingTime + " sec(s)",
                    "Average Waiting Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}