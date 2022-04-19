
namespace SpecialAssignment_Bike_trips
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.txtDestName = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtDestTime = new System.Windows.Forms.TextBox();
            this.lblDestName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lsbDisplay = new System.Windows.Forms.ListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lsbTotal = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDestLength = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtTripLength = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTripName = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.Panel();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lsbFilter = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lsbFilterAboveTime = new System.Windows.Forms.ListBox();
            this.btnRequestAboveTime = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimeToSurpass = new System.Windows.Forms.Label();
            this.txtSurpass = new System.Windows.Forms.TextBox();
            this.btnSurpass = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbAverage = new System.Windows.Forms.ListBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbMaxAvg = new System.Windows.Forms.ListBox();
            this.btnMaxAvg = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.F.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTrip.Location = new System.Drawing.Point(166, 47);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(70, 48);
            this.btnAddTrip.TabIndex = 0;
            this.btnAddTrip.Text = "Add trip ";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // txtDestName
            // 
            this.txtDestName.Location = new System.Drawing.Point(42, 47);
            this.txtDestName.Name = "txtDestName";
            this.txtDestName.Size = new System.Drawing.Size(100, 20);
            this.txtDestName.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(42, 98);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 2;
            // 
            // txtDestTime
            // 
            this.txtDestTime.Location = new System.Drawing.Point(42, 146);
            this.txtDestTime.Name = "txtDestTime";
            this.txtDestTime.Size = new System.Drawing.Size(100, 20);
            this.txtDestTime.TabIndex = 3;
            // 
            // lblDestName
            // 
            this.lblDestName.AutoSize = true;
            this.lblDestName.Location = new System.Drawing.Point(29, 31);
            this.lblDestName.Name = "lblDestName";
            this.lblDestName.Size = new System.Drawing.Size(60, 13);
            this.lblDestName.TabIndex = 4;
            this.lblDestName.Text = "Destination";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(29, 130);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(29, 82);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance";
            // 
            // lsbDisplay
            // 
            this.lsbDisplay.FormattingEnabled = true;
            this.lsbDisplay.Location = new System.Drawing.Point(23, 201);
            this.lsbDisplay.Name = "lsbDisplay";
            this.lsbDisplay.Size = new System.Drawing.Size(119, 121);
            this.lsbDisplay.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(5, 45);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Request";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lsbTotal
            // 
            this.lsbTotal.FormattingEnabled = true;
            this.lsbTotal.Location = new System.Drawing.Point(166, 146);
            this.lsbTotal.Name = "lsbTotal";
            this.lsbTotal.Size = new System.Drawing.Size(119, 95);
            this.lsbTotal.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(163, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblDestLength);
            this.panel1.Controls.Add(this.lblDest);
            this.panel1.Controls.Add(this.txtTripLength);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.txtTripName);
            this.panel1.Location = new System.Drawing.Point(372, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            // 
            // lblDestLength
            // 
            this.lblDestLength.AutoSize = true;
            this.lblDestLength.Location = new System.Drawing.Point(11, 49);
            this.lblDestLength.Name = "lblDestLength";
            this.lblDestLength.Size = new System.Drawing.Size(40, 13);
            this.lblDestLength.TabIndex = 17;
            this.lblDestLength.Text = "Length";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(11, 10);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(54, 13);
            this.lblDest.TabIndex = 16;
            this.lblDest.Text = "Trip name";
            // 
            // txtTripLength
            // 
            this.txtTripLength.Location = new System.Drawing.Point(14, 63);
            this.txtTripLength.Name = "txtTripLength";
            this.txtTripLength.Size = new System.Drawing.Size(100, 20);
            this.txtTripLength.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(120, 43);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTripName
            // 
            this.txtTripName.Location = new System.Drawing.Point(14, 26);
            this.txtTripName.Name = "txtTripName";
            this.txtTripName.Size = new System.Drawing.Size(100, 20);
            this.txtTripName.TabIndex = 14;
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.SystemColors.ControlDark;
            this.F.Controls.Add(this.lblFilterByName);
            this.F.Controls.Add(this.txtName);
            this.F.Controls.Add(this.lsbFilter);
            this.F.Controls.Add(this.btnFilter);
            this.F.Location = new System.Drawing.Point(372, 12);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(182, 185);
            this.F.TabIndex = 14;
            // 
            // lblFilterByName
            // 
            this.lblFilterByName.AutoSize = true;
            this.lblFilterByName.Location = new System.Drawing.Point(3, 3);
            this.lblFilterByName.Name = "lblFilterByName";
            this.lblFilterByName.Size = new System.Drawing.Size(72, 13);
            this.lblFilterByName.TabIndex = 16;
            this.lblFilterByName.Text = "Filter by name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // lsbFilter
            // 
            this.lsbFilter.FormattingEnabled = true;
            this.lsbFilter.Location = new System.Drawing.Point(5, 96);
            this.lsbFilter.Name = "lsbFilter";
            this.lsbFilter.Size = new System.Drawing.Size(165, 69);
            this.lsbFilter.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.lsbFilterAboveTime);
            this.panel2.Controls.Add(this.btnRequestAboveTime);
            this.panel2.Location = new System.Drawing.Point(582, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 185);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter above time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(5, 19);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 15;
            // 
            // lsbFilterAboveTime
            // 
            this.lsbFilterAboveTime.FormattingEnabled = true;
            this.lsbFilterAboveTime.Location = new System.Drawing.Point(5, 96);
            this.lsbFilterAboveTime.Name = "lsbFilterAboveTime";
            this.lsbFilterAboveTime.Size = new System.Drawing.Size(165, 69);
            this.lsbFilterAboveTime.TabIndex = 15;
            // 
            // btnRequestAboveTime
            // 
            this.btnRequestAboveTime.Location = new System.Drawing.Point(5, 45);
            this.btnRequestAboveTime.Name = "btnRequestAboveTime";
            this.btnRequestAboveTime.Size = new System.Drawing.Size(75, 23);
            this.btnRequestAboveTime.TabIndex = 8;
            this.btnRequestAboveTime.Text = "Request";
            this.btnRequestAboveTime.UseVisualStyleBackColor = true;
            this.btnRequestAboveTime.Click += new System.EventHandler(this.btnRequestAboveTime_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.lblTimeToSurpass);
            this.panel3.Controls.Add(this.txtSurpass);
            this.panel3.Controls.Add(this.btnSurpass);
            this.panel3.Location = new System.Drawing.Point(181, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 88);
            this.panel3.TabIndex = 18;
            // 
            // lblTimeToSurpass
            // 
            this.lblTimeToSurpass.AutoSize = true;
            this.lblTimeToSurpass.Location = new System.Drawing.Point(3, 3);
            this.lblTimeToSurpass.Name = "lblTimeToSurpass";
            this.lblTimeToSurpass.Size = new System.Drawing.Size(100, 13);
            this.lblTimeToSurpass.TabIndex = 18;
            this.lblTimeToSurpass.Text = "Distance to surpass";
            // 
            // txtSurpass
            // 
            this.txtSurpass.Location = new System.Drawing.Point(5, 19);
            this.txtSurpass.Name = "txtSurpass";
            this.txtSurpass.Size = new System.Drawing.Size(100, 20);
            this.txtSurpass.TabIndex = 15;
            // 
            // btnSurpass
            // 
            this.btnSurpass.Location = new System.Drawing.Point(5, 45);
            this.btnSurpass.Name = "btnSurpass";
            this.btnSurpass.Size = new System.Drawing.Size(75, 23);
            this.btnSurpass.TabIndex = 8;
            this.btnSurpass.Text = "Surpass";
            this.btnSurpass.UseVisualStyleBackColor = true;
            this.btnSurpass.Click += new System.EventHandler(this.btnSurpass_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lsbAverage);
            this.panel4.Controls.Add(this.btnAverage);
            this.panel4.Location = new System.Drawing.Point(600, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 105);
            this.panel4.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Average speed";
            // 
            // lsbAverage
            // 
            this.lsbAverage.FormattingEnabled = true;
            this.lsbAverage.Location = new System.Drawing.Point(3, 26);
            this.lsbAverage.Name = "lsbAverage";
            this.lsbAverage.Size = new System.Drawing.Size(136, 30);
            this.lsbAverage.TabIndex = 20;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(33, 62);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 19;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lsbMaxAvg);
            this.panel5.Controls.Add(this.btnMaxAvg);
            this.panel5.Location = new System.Drawing.Point(756, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 105);
            this.panel5.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "maxAvg > avg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lsbMaxAvg
            // 
            this.lsbMaxAvg.FormattingEnabled = true;
            this.lsbMaxAvg.Location = new System.Drawing.Point(3, 26);
            this.lsbMaxAvg.Name = "lsbMaxAvg";
            this.lsbMaxAvg.Size = new System.Drawing.Size(136, 43);
            this.lsbMaxAvg.TabIndex = 20;
            // 
            // btnMaxAvg
            // 
            this.btnMaxAvg.Location = new System.Drawing.Point(30, 79);
            this.btnMaxAvg.Name = "btnMaxAvg";
            this.btnMaxAvg.Size = new System.Drawing.Size(75, 23);
            this.btnMaxAvg.TabIndex = 19;
            this.btnMaxAvg.Text = "Average";
            this.btnMaxAvg.UseVisualStyleBackColor = true;
            this.btnMaxAvg.Click += new System.EventHandler(this.btnMaxAvg_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Location = new System.Drawing.Point(42, 334);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 48);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 436);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lsbTotal);
            this.Controls.Add(this.lsbDisplay);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDestName);
            this.Controls.Add(this.txtDestTime);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtDestName);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.F.ResumeLayout(false);
            this.F.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.TextBox txtDestName;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtDestTime;
        private System.Windows.Forms.Label lblDestName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.ListBox lsbDisplay;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lsbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDestLength;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtTripLength;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtTripName;
        private System.Windows.Forms.Panel F;
        private System.Windows.Forms.ListBox lsbFilter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFilterByName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ListBox lsbFilterAboveTime;
        private System.Windows.Forms.Button btnRequestAboveTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSurpass;
        private System.Windows.Forms.Button btnSurpass;
        private System.Windows.Forms.Label lblTimeToSurpass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbAverage;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbMaxAvg;
        private System.Windows.Forms.Button btnMaxAvg;
        private System.Windows.Forms.Button btnRefresh;
    }
}

