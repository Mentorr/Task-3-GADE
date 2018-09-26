namespace _17605096_Task2_GADE6112
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
            this.components = new System.ComponentModel.Container();
            this.btnsave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.Stop1 = new System.Windows.Forms.Button();
            this.Start1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(529, 131);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(529, 160);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // txtTurn
            // 
            this.txtTurn.Location = new System.Drawing.Point(515, 21);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.Size = new System.Drawing.Size(100, 20);
            this.txtTurn.TabIndex = 3;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(515, 105);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 4;
            // 
            // Stop1
            // 
            this.Stop1.Location = new System.Drawing.Point(529, 76);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(75, 23);
            this.Stop1.TabIndex = 5;
            this.Stop1.Text = "Stop";
            this.Stop1.UseVisualStyleBackColor = true;
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(529, 47);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(75, 23);
            this.Start1.TabIndex = 6;
            this.Start1.Text = "Start";
            this.Start1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 508);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.btnsave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Button Start1;
    }
}

