
namespace GraphicsPackage
{
    partial class Elipse
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
            this.lbl_rx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xdw = new System.Windows.Forms.Label();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.txtbox_rx = new System.Windows.Forms.TextBox();
            this.txtbox_ycenter = new System.Windows.Forms.TextBox();
            this.txtbox_xcenter = new System.Windows.Forms.TextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lbl_ry = new System.Windows.Forms.Label();
            this.txtbox_ry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rx
            // 
            this.lbl_rx.AutoSize = true;
            this.lbl_rx.Location = new System.Drawing.Point(13, 188);
            this.lbl_rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rx.Name = "lbl_rx";
            this.lbl_rx.Size = new System.Drawing.Size(69, 18);
            this.lbl_rx.TabIndex = 15;
            this.lbl_rx.Text = "X Radius ";
            this.lbl_rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y Center";
            // 
            // Xdw
            // 
            this.Xdw.AutoSize = true;
            this.Xdw.Location = new System.Drawing.Point(13, 9);
            this.Xdw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Xdw.Name = "Xdw";
            this.Xdw.Size = new System.Drawing.Size(67, 18);
            this.Xdw.TabIndex = 13;
            this.Xdw.Text = "X Center";
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.HotPink;
            this.btn_ellipse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ellipse.FlatAppearance.BorderSize = 3;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Location = new System.Drawing.Point(85, 366);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(227, 52);
            this.btn_ellipse.TabIndex = 12;
            this.btn_ellipse.Text = "Draw Ellipse  ";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // txtbox_rx
            // 
            this.txtbox_rx.Location = new System.Drawing.Point(16, 226);
            this.txtbox_rx.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_rx.Multiline = true;
            this.txtbox_rx.Name = "txtbox_rx";
            this.txtbox_rx.Size = new System.Drawing.Size(63, 26);
            this.txtbox_rx.TabIndex = 11;
            this.txtbox_rx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_ycenter
            // 
            this.txtbox_ycenter.Location = new System.Drawing.Point(85, 135);
            this.txtbox_ycenter.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ycenter.Multiline = true;
            this.txtbox_ycenter.Name = "txtbox_ycenter";
            this.txtbox_ycenter.Size = new System.Drawing.Size(63, 26);
            this.txtbox_ycenter.TabIndex = 10;
            this.txtbox_ycenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_xcenter
            // 
            this.txtbox_xcenter.Location = new System.Drawing.Point(16, 49);
            this.txtbox_xcenter.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_xcenter.Multiline = true;
            this.txtbox_xcenter.Name = "txtbox_xcenter";
            this.txtbox_xcenter.Size = new System.Drawing.Size(63, 26);
            this.txtbox_xcenter.TabIndex = 9;
            this.txtbox_xcenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.LavenderBlush;
            this.picbox.Location = new System.Drawing.Point(320, 8);
            this.picbox.Margin = new System.Windows.Forms.Padding(4);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(622, 635);
            this.picbox.TabIndex = 8;
            this.picbox.TabStop = false;
            // 
            // lbl_ry
            // 
            this.lbl_ry.AutoSize = true;
            this.lbl_ry.Location = new System.Drawing.Point(82, 277);
            this.lbl_ry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ry.Name = "lbl_ry";
            this.lbl_ry.Size = new System.Drawing.Size(68, 18);
            this.lbl_ry.TabIndex = 17;
            this.lbl_ry.Text = "Y Radius ";
            this.lbl_ry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_ry
            // 
            this.txtbox_ry.Location = new System.Drawing.Point(85, 316);
            this.txtbox_ry.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ry.Multiline = true;
            this.txtbox_ry.Name = "txtbox_ry";
            this.txtbox_ry.Size = new System.Drawing.Size(63, 26);
            this.txtbox_ry.TabIndex = 16;
            this.txtbox_ry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Elipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.lbl_ry);
            this.Controls.Add(this.txtbox_ry);
            this.Controls.Add(this.lbl_rx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xdw);
            this.Controls.Add(this.btn_ellipse);
            this.Controls.Add(this.txtbox_rx);
            this.Controls.Add(this.txtbox_ycenter);
            this.Controls.Add(this.txtbox_xcenter);
            this.Controls.Add(this.picbox);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Elipse";
            this.Text = "Midpoint Ellipse Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Xdw;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.TextBox txtbox_rx;
        private System.Windows.Forms.TextBox txtbox_ycenter;
        private System.Windows.Forms.TextBox txtbox_xcenter;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lbl_ry;
        private System.Windows.Forms.TextBox txtbox_ry;
    }
}