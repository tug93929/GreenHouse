namespace GreenHouse02
{
    partial class SerialMonitor
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.DataDisplay = new System.Windows.Forms.RichTextBox();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Customize = new System.Windows.Forms.RadioButton();
            this.Preset = new System.Windows.Forms.RadioButton();
            this.CommunicationPort2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(507, 120);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(169, 68);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start\r\n";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(507, 199);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(169, 68);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // DataDisplay
            // 
            this.DataDisplay.Location = new System.Drawing.Point(39, 49);
            this.DataDisplay.Name = "DataDisplay";
            this.DataDisplay.Size = new System.Drawing.Size(383, 374);
            this.DataDisplay.TabIndex = 3;
            this.DataDisplay.Text = "";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(507, 64);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(169, 22);
            this.PortInput.TabIndex = 4;
            this.PortInput.TextChanged += new System.EventHandler(this.PortInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Communication Port";
            // 
            // Customize
            // 
            this.Customize.AutoSize = true;
            this.Customize.Location = new System.Drawing.Point(507, 307);
            this.Customize.Name = "Customize";
            this.Customize.Size = new System.Drawing.Size(94, 21);
            this.Customize.TabIndex = 6;
            this.Customize.TabStop = true;
            this.Customize.Text = "Customize";
            this.Customize.UseVisualStyleBackColor = true;
            this.Customize.CheckedChanged += new System.EventHandler(this.Customize_CheckedChanged);
            // 
            // Preset
            // 
            this.Preset.AutoSize = true;
            this.Preset.Location = new System.Drawing.Point(507, 359);
            this.Preset.Name = "Preset";
            this.Preset.Size = new System.Drawing.Size(70, 21);
            this.Preset.TabIndex = 7;
            this.Preset.TabStop = true;
            this.Preset.Text = "Preset";
            this.Preset.UseVisualStyleBackColor = true;
            this.Preset.CheckedChanged += new System.EventHandler(this.Preset_CheckedChanged);
            // 
            // CommunicationPort2
            // 
            this.CommunicationPort2.Location = new System.Drawing.Point(507, 92);
            this.CommunicationPort2.Name = "CommunicationPort2";
            this.CommunicationPort2.Size = new System.Drawing.Size(169, 22);
            this.CommunicationPort2.TabIndex = 8;
            this.CommunicationPort2.TextChanged += new System.EventHandler(this.CommunicationPort2_TextChanged);
            // 
            // SerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommunicationPort2);
            this.Controls.Add(this.Preset);
            this.Controls.Add(this.Customize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.DataDisplay);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "SerialMonitor";
            this.Text = "SerialMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.RichTextBox DataDisplay;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Customize;
        private System.Windows.Forms.RadioButton Preset;
        private System.Windows.Forms.TextBox CommunicationPort2;
    }
}