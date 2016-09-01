namespace IdleAvoider
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MouseMoveCheckbox = new System.Windows.Forms.CheckBox();
            this.NotepadCheckbox = new System.Windows.Forms.CheckBox();
            this.CalculatorCheckbox = new System.Windows.Forms.CheckBox();
            this.TimespanLabel = new System.Windows.Forms.Label();
            this.TimeTextbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BWStart = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.F15Checkbox = new System.Windows.Forms.CheckBox();
            this.F15Tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseMoveCheckbox
            // 
            this.MouseMoveCheckbox.AutoSize = true;
            this.MouseMoveCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseMoveCheckbox.Location = new System.Drawing.Point(12, 179);
            this.MouseMoveCheckbox.Name = "MouseMoveCheckbox";
            this.MouseMoveCheckbox.Size = new System.Drawing.Size(95, 19);
            this.MouseMoveCheckbox.TabIndex = 1;
            this.MouseMoveCheckbox.Text = "Mouse move";
            this.MouseMoveCheckbox.UseVisualStyleBackColor = true;
            this.MouseMoveCheckbox.CheckedChanged += new System.EventHandler(this.MouseMoveCheckbox_CheckedChanged);
            // 
            // NotepadCheckbox
            // 
            this.NotepadCheckbox.AutoSize = true;
            this.NotepadCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NotepadCheckbox.Location = new System.Drawing.Point(12, 203);
            this.NotepadCheckbox.Name = "NotepadCheckbox";
            this.NotepadCheckbox.Size = new System.Drawing.Size(94, 19);
            this.NotepadCheckbox.TabIndex = 2;
            this.NotepadCheckbox.Text = "Use Notepad";
            this.NotepadCheckbox.UseVisualStyleBackColor = true;
            this.NotepadCheckbox.CheckedChanged += new System.EventHandler(this.NotepadCheckbox_CheckedChanged);
            // 
            // CalculatorCheckbox
            // 
            this.CalculatorCheckbox.AutoSize = true;
            this.CalculatorCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CalculatorCheckbox.Location = new System.Drawing.Point(12, 227);
            this.CalculatorCheckbox.Name = "CalculatorCheckbox";
            this.CalculatorCheckbox.Size = new System.Drawing.Size(102, 19);
            this.CalculatorCheckbox.TabIndex = 3;
            this.CalculatorCheckbox.Text = "Use Calculator";
            this.CalculatorCheckbox.UseVisualStyleBackColor = true;
            this.CalculatorCheckbox.CheckedChanged += new System.EventHandler(this.CalculatorCheckbox_CheckedChanged);
            // 
            // TimespanLabel
            // 
            this.TimespanLabel.AutoSize = true;
            this.TimespanLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimespanLabel.Location = new System.Drawing.Point(124, 203);
            this.TimespanLabel.Name = "TimespanLabel";
            this.TimespanLabel.Size = new System.Drawing.Size(91, 15);
            this.TimespanLabel.TabIndex = 4;
            this.TimespanLabel.Text = "Run cycle (secs)";
            // 
            // TimeTextbox
            // 
            this.TimeTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeTextbox.Location = new System.Drawing.Point(127, 221);
            this.TimeTextbox.Name = "TimeTextbox";
            this.TimeTextbox.Size = new System.Drawing.Size(93, 23);
            this.TimeTextbox.TabIndex = 5;
            this.TimeTextbox.TextChanged += new System.EventHandler(this.TimeTextbox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartButton.Location = new System.Drawing.Point(76, 250);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseClick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 279);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(208, 11);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 7;
            // 
            // BWStart
            // 
            this.BWStart.WorkerSupportsCancellation = true;
            this.BWStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWStart_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7F);
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "By Aresius 2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7F);
            this.label2.Location = new System.Drawing.Point(157, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Donate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IdleAvoider.Properties.Resources.Paypal_logo_pp_2014;
            this.pictureBox2.Location = new System.Drawing.Point(198, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IdleAvoider.Properties.Resources.Status_user_away_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // F15Checkbox
            // 
            this.F15Checkbox.AutoSize = true;
            this.F15Checkbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.F15Checkbox.Location = new System.Drawing.Point(127, 179);
            this.F15Checkbox.Name = "F15Checkbox";
            this.F15Checkbox.Size = new System.Drawing.Size(92, 19);
            this.F15Checkbox.TabIndex = 11;
            this.F15Checkbox.Text = "F15 keypress";
            this.F15Tooltip.SetToolTip(this.F15Checkbox, "Unintrusive method");
            this.F15Checkbox.UseVisualStyleBackColor = true;
            this.F15Checkbox.CheckedChanged += new System.EventHandler(this.F15Checkbox_CheckedChanged);
            // 
            // F15Tooltip
            // 
            this.F15Tooltip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 318);
            this.Controls.Add(this.F15Checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeTextbox);
            this.Controls.Add(this.TimespanLabel);
            this.Controls.Add(this.CalculatorCheckbox);
            this.Controls.Add(this.NotepadCheckbox);
            this.Controls.Add(this.MouseMoveCheckbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Idle Avoider";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox MouseMoveCheckbox;
        private System.Windows.Forms.CheckBox NotepadCheckbox;
        private System.Windows.Forms.CheckBox CalculatorCheckbox;
        private System.Windows.Forms.Label TimespanLabel;
        private System.Windows.Forms.TextBox TimeTextbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker BWStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox F15Checkbox;
        private System.Windows.Forms.ToolTip F15Tooltip;
    }
}

