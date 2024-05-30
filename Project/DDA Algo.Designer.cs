namespace GraphicsPackage
{
    partial class DDA
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
            this.button1 = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.WWW = new System.Windows.Forms.Label();
            this.Y1WDA = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.Label();
            this.WDAD = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bf1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bf1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(140, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw DDA Line";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(13, 55);
            this.X1.Margin = new System.Windows.Forms.Padding(4);
            this.X1.Multiline = true;
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(63, 25);
            this.X1.TabIndex = 1;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(78, 305);
            this.Y2.Margin = new System.Windows.Forms.Padding(4);
            this.Y2.Multiline = true;
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(63, 25);
            this.Y2.TabIndex = 3;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(13, 216);
            this.X2.Margin = new System.Windows.Forms.Padding(4);
            this.X2.Multiline = true;
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(62, 25);
            this.X2.TabIndex = 4;
            // 
            // WWW
            // 
            this.WWW.AutoSize = true;
            this.WWW.Location = new System.Drawing.Point(13, 17);
            this.WWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WWW.Name = "WWW";
            this.WWW.Size = new System.Drawing.Size(24, 18);
            this.WWW.TabIndex = 5;
            this.WWW.Text = "X1";
            // 
            // Y1WDA
            // 
            this.Y1WDA.AutoSize = true;
            this.Y1WDA.Location = new System.Drawing.Point(76, 99);
            this.Y1WDA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y1WDA.Name = "Y1WDA";
            this.Y1WDA.Size = new System.Drawing.Size(23, 18);
            this.Y1WDA.TabIndex = 6;
            this.Y1WDA.Text = "Y1";
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.Location = new System.Drawing.Point(13, 176);
            this.AD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(25, 18);
            this.AD.TabIndex = 7;
            this.AD.Text = "X2";
            // 
            // WDAD
            // 
            this.WDAD.AutoSize = true;
            this.WDAD.Location = new System.Drawing.Point(75, 264);
            this.WDAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WDAD.Name = "WDAD";
            this.WDAD.Size = new System.Drawing.Size(24, 18);
            this.WDAD.TabIndex = 8;
            this.WDAD.Text = "Y2";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bf1
            // 
            this.bf1.BackColor = System.Drawing.Color.LavenderBlush;
            this.bf1.Location = new System.Drawing.Point(375, 17);
            this.bf1.Margin = new System.Windows.Forms.Padding(4);
            this.bf1.Name = "bf1";
            this.bf1.Size = new System.Drawing.Size(622, 635);
            this.bf1.TabIndex = 9;
            this.bf1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.HotPink;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(204, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Y1
            // 
            this.Y1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Y1.Location = new System.Drawing.Point(79, 135);
            this.Y1.Margin = new System.Windows.Forms.Padding(4);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(62, 25);
            this.Y1.TabIndex = 2;
            this.Y1.ValidatingType = typeof(int);
            // 
            // DDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bf1);
            this.Controls.Add(this.WDAD);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.Y1WDA);
            this.Controls.Add(this.WWW);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DDA";
            this.Text = "DDA Algoritm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bf1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label WWW;
        private System.Windows.Forms.Label Y1WDA;
        private System.Windows.Forms.Label AD;
        private System.Windows.Forms.Label WDAD;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox bf1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Y1;
    }
}

