namespace GraphicsPackage
{
    partial class MidpointCircleAlgorithm
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
            this.circle = new System.Windows.Forms.PictureBox();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Xdw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.LavenderBlush;
            this.circle.Location = new System.Drawing.Point(282, 8);
            this.circle.Margin = new System.Windows.Forms.Padding(4);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(622, 635);
            this.circle.TabIndex = 0;
            this.circle.TabStop = false;
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(28, 43);
            this.xCenter.Margin = new System.Windows.Forms.Padding(4);
            this.xCenter.Multiline = true;
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(63, 26);
            this.xCenter.TabIndex = 1;
            this.xCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(99, 122);
            this.yCenter.Margin = new System.Windows.Forms.Padding(4);
            this.yCenter.Multiline = true;
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(63, 26);
            this.yCenter.TabIndex = 2;
            this.yCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(28, 200);
            this.Radius.Margin = new System.Windows.Forms.Padding(4);
            this.Radius.Multiline = true;
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(63, 26);
            this.Radius.TabIndex = 3;
            this.Radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(55, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Draw Midpoint Circle ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Xdw
            // 
            this.Xdw.AutoSize = true;
            this.Xdw.Location = new System.Drawing.Point(24, 9);
            this.Xdw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xdw.Name = "Xdw";
            this.Xdw.Size = new System.Drawing.Size(67, 18);
            this.Xdw.TabIndex = 5;
            this.Xdw.Text = "X Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MidpointCircleAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xdw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.circle);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MidpointCircleAlgorithm";
            this.Text = "Midpoint Circle Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Xdw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}