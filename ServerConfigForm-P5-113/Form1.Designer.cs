
namespace ServerConfigForm_P5_113
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ON = new System.Windows.Forms.Button();
            this.btn_OFF = new System.Windows.Forms.Button();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnorOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ON
            // 
            this.btn_ON.Location = new System.Drawing.Point(261, 211);
            this.btn_ON.Name = "btn_ON";
            this.btn_ON.Size = new System.Drawing.Size(75, 23);
            this.btn_ON.TabIndex = 1;
            this.btn_ON.Text = "ON";
            this.btn_ON.UseVisualStyleBackColor = true;
            this.btn_ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_OFF
            // 
            this.btn_OFF.Location = new System.Drawing.Point(464, 211);
            this.btn_OFF.Name = "btn_OFF";
            this.btn_OFF.Size = new System.Drawing.Size(75, 23);
            this.btn_OFF.TabIndex = 2;
            this.btn_OFF.Text = "OFF";
            this.btn_OFF.UseVisualStyleBackColor = true;
            this.btn_OFF.Click += new System.EventHandler(this.btn_OFF_Click);
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(367, 165);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 17);
            this.labelKet.TabIndex = 3;
            // 
            // labelOnorOff
            // 
            this.labelOnorOff.AutoSize = true;
            this.labelOnorOff.Location = new System.Drawing.Point(367, 137);
            this.labelOnorOff.Name = "labelOnorOff";
            this.labelOnorOff.Size = new System.Drawing.Size(0, 17);
            this.labelOnorOff.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOnorOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.btn_OFF);
            this.Controls.Add(this.btn_ON);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ON;
        private System.Windows.Forms.Button btn_OFF;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnorOff;
    }
}

