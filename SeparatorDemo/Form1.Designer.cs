namespace SeparatorDemo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mySeparator3 = new SeparatorDemo.MySeparator();
            this.mySeparator2 = new SeparatorDemo.MySeparator();
            this.mySeparator1 = new SeparatorDemo.MySeparator();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Ui Academy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "We Create, We Design, We Develop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mySeparator3
            // 
            this.mySeparator3.ForeColor = System.Drawing.Color.Red;
            this.mySeparator3.isVertical = true;
            this.mySeparator3.Location = new System.Drawing.Point(585, 73);
            this.mySeparator3.Name = "mySeparator3";
            this.mySeparator3.Size = new System.Drawing.Size(10, 273);
            this.mySeparator3.TabIndex = 4;
            this.mySeparator3.Text = "mySeparator3";
            this.mySeparator3.Thickness = 3;
            // 
            // mySeparator2
            // 
            this.mySeparator2.ForeColor = System.Drawing.Color.Red;
            this.mySeparator2.isVertical = true;
            this.mySeparator2.Location = new System.Drawing.Point(118, 73);
            this.mySeparator2.Name = "mySeparator2";
            this.mySeparator2.Size = new System.Drawing.Size(10, 273);
            this.mySeparator2.TabIndex = 3;
            this.mySeparator2.Text = "mySeparator2";
            this.mySeparator2.Thickness = 3;
            // 
            // mySeparator1
            // 
            this.mySeparator1.ForeColor = System.Drawing.Color.Red;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(125, 173);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(457, 23);
            this.mySeparator1.TabIndex = 0;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.mySeparator3);
            this.Controls.Add(this.mySeparator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mySeparator1);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySeparator mySeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MySeparator mySeparator2;
        private MySeparator mySeparator3;
    }
}

