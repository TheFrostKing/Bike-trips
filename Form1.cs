using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialAssignment_Bike_trips
{
    public partial class Form1 : Form
    {
        List<int> destinationTime = new List<int>();
        List<string> destinationName = new List<string>();
        List<int> destinationLength = new List<int>();

        public Form1()
        {
            InitializeComponent();
            destinationName.Insert(0, "Sliven");
            destinationLength.Insert(0, 123);
            destinationTime.Insert(0, 12);
            destinationName.Insert(1, "Burgas");
            destinationLength.Insert(1, 13);
            destinationTime.Insert(1, 124);
            destinationName.Insert(2, "Sofia");
            destinationLength.Insert(2, 55);
            destinationTime.Insert(1, 50);
            destinationName.Insert(3, "Sofia");
            destinationLength.Insert(3, 554);
            destinationTime.Insert(3, 503);
            UpdateListBox();
            TotalBikedTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateListBox()
        {
            lsbDisplay.Items.Clear();
            for (int i = 0; i < destinationLength.Count; i++)
            {
                lsbDisplay.Items.Add($"{destinationName[i]}, {destinationLength[i]} km, {destinationTime[i]} min");
            }
        }
        private void TotalBikedTime()
        {
            lsbTotal.Items.Clear();
            int totalMinutesBiked= 0;
            int totalKmBiked = 0;
            for (int i = 0; i < destinationTime.Count; i++)
            {
                totalMinutesBiked += destinationTime[i];
                totalKmBiked += destinationLength[i];
            }
            lsbTotal.Items.Add($"Total: {totalKmBiked} km, {totalMinutesBiked} min");
        }

        private void btnAddTrip_Click(object sender, EventArgs e)// A
        {
            destinationTime.Add(Convert.ToInt32 (txtDestTime.Text));
            destinationName.Add(txtDestName.Text);
            destinationLength.Add(Convert.ToInt32(txtDest.Text));
            UpdateListBox();
            TotalBikedTime();
        }

        private void btnRemove_Click(object sender, EventArgs e) //D 
        {
            for (int i = 0; i < destinationLength.Count; i++)
            {
                if (destinationName[i]==txtTripName.Text || destinationTime[i] ==Convert.ToInt32(txtTripLength.Text))
                {
                    destinationName.RemoveAt(i);
                    destinationLength.RemoveAt(i);
                    destinationTime.RemoveAt(i);
                }
            }
            UpdateListBox();
            TotalBikedTime();
        }

        private void btnFilter_Click(object sender, EventArgs e) //E
        {
            int totalDist = 0;
            int totalTime = 0;
            lsbFilter.Items.Clear();
            lsbTotal.Items.Clear();
            string tripName = txtName.Text;
            for (int i = 0; i < destinationName.Count; i++)
            {
                if (tripName==destinationName[i])
                {
                    lsbFilter.Items.Add($"{destinationName[i]}, {destinationLength[i]} km, {destinationTime[i]} min");
                    totalDist += destinationLength[i];
                    totalTime += destinationTime[i];
                }
            }
            lsbTotal.Items.Add($"Total: {totalDist} km, {totalTime} min");
        }

        private void btnRequestAboveTime_Click(object sender, EventArgs e)
        {
            int totalDist = 0;
            int totalTime = 0;
            lsbTotal.Items.Clear();
            lsbFilterAboveTime.Items.Clear();
            int time = Convert.ToInt32(txtTime.Text);
            for (int i = 0; i < destinationTime.Count; i++)
            {
                if (time<destinationTime[i])
                {
                    lsbFilterAboveTime.Items.Add($"{destinationName[i]}, {destinationLength[i]} km, {destinationTime[i]} min");
                    totalDist += destinationLength[i];
                    totalTime += destinationTime[i];
                }
            }
            lsbTotal.Items.Add($"Total: {totalDist} km, {totalTime} min");
        }

        private void btnSurpass_Click(object sender, EventArgs e)
        {
            lsbDisplay.Items.Clear();
            int calcDist = 0;
            for (int i = 0; i < destinationTime.Count; i++)
            {
                calcDist += destinationLength[i];
                if (calcDist <= Convert.ToInt32(txtSurpass.Text))
                {
                    lsbDisplay.Items.Add($"{destinationName[i]}, {destinationLength[i]} km, {destinationTime[i]} min");
                }
            }
        }

        private int AverageSpeed(int index)
        {
            int result = 0;
            result = destinationLength[index]*60/destinationTime[index];
            return result;
        }

        private int AverageOfAll()
        {
            int keepAverage = 0;
            int totalDest = destinationLength.Count;
            int calc = 0;
            for (int i = 0; i < destinationLength.Count; i++)
            {
                keepAverage+= AverageSpeed(i);
            }
            calc = keepAverage / totalDest;
            return calc;
        }

        private void MaxThanAvgSpeed()
        {
            for (int i = 0; i < destinationLength.Count; i++)
            {
                if (AverageSpeed(i)>AverageOfAll())
                {
                    lsbMaxAvg.Items.Add($"{destinationName[i]}, {destinationLength[i]} km, {destinationTime[i]} min");
                }
            } 
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int index = lsbDisplay.SelectedIndex;
            lsbAverage.Items.Add($"Average is {AverageSpeed(index)} km");
        }

        private void btnMaxAvg_Click(object sender, EventArgs e)
        {
            lsbMaxAvg.Items.Clear();
            MaxThanAvgSpeed();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            TotalBikedTime();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
