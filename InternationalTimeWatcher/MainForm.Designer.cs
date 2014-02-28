namespace InternationalTimeWatcher
{
    partial class InternationalTimeWatcherForm
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
            this.TimeZonesComboBox = new System.Windows.Forms.ComboBox();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeZonesComboBox
            // 
            this.TimeZonesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeZonesComboBox.FormattingEnabled = true;
            this.TimeZonesComboBox.Location = new System.Drawing.Point(12, 9);
            this.TimeZonesComboBox.Name = "TimeZonesComboBox";
            this.TimeZonesComboBox.Size = new System.Drawing.Size(480, 21);
            this.TimeZonesComboBox.TabIndex = 0;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            // 
            // InternationalTimeWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 42);
            this.Controls.Add(this.TimeZonesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InternationalTimeWatcherForm";
            this.Text = "Fetching...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TimeZonesComboBox;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

