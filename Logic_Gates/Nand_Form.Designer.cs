namespace Logic_Gates
{
    partial class Nand_Form
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
            this.checkBox_OR_A = new System.Windows.Forms.CheckBox();
            this.checkBox_OR_B = new System.Windows.Forms.CheckBox();
            this.pictureBox_OR1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_OR = new System.Windows.Forms.PictureBox();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "NAND Gate";
            // 
            // checkBox_OR_A
            // 
            this.checkBox_OR_A.AutoSize = true;
            this.checkBox_OR_A.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_OR_A.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_OR_A.ForeColor = System.Drawing.Color.Black;
            this.checkBox_OR_A.Location = new System.Drawing.Point(83, 242);
            this.checkBox_OR_A.Name = "checkBox_OR_A";
            this.checkBox_OR_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_OR_A.Size = new System.Drawing.Size(48, 33);
            this.checkBox_OR_A.TabIndex = 15;
            this.checkBox_OR_A.Text = "A";
            this.checkBox_OR_A.UseVisualStyleBackColor = false;
            this.checkBox_OR_A.CheckedChanged += new System.EventHandler(this.checkBox_OR_A_CheckedChanged);
            // 
            // checkBox_OR_B
            // 
            this.checkBox_OR_B.AutoSize = true;
            this.checkBox_OR_B.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_OR_B.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_OR_B.ForeColor = System.Drawing.Color.Black;
            this.checkBox_OR_B.Location = new System.Drawing.Point(83, 319);
            this.checkBox_OR_B.Name = "checkBox_OR_B";
            this.checkBox_OR_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_OR_B.Size = new System.Drawing.Size(48, 33);
            this.checkBox_OR_B.TabIndex = 14;
            this.checkBox_OR_B.Text = "B";
            this.checkBox_OR_B.UseVisualStyleBackColor = false;
            this.checkBox_OR_B.CheckedChanged += new System.EventHandler(this.checkBox_OR_B_CheckedChanged);
            // 
            // pictureBox_OR1
            // 
            this.pictureBox_OR1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox_OR1.Enabled = false;
            this.pictureBox_OR1.Image = global::Logic_Gates.Properties.Resources.lampada_desligada;
            this.pictureBox_OR1.Location = new System.Drawing.Point(464, 141);
            this.pictureBox_OR1.Name = "pictureBox_OR1";
            this.pictureBox_OR1.Size = new System.Drawing.Size(453, 302);
            this.pictureBox_OR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OR1.TabIndex = 16;
            this.pictureBox_OR1.TabStop = false;
            this.pictureBox_OR1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = global::Logic_Gates.Properties.Resources._127px_NAND_gate_svg;
            this.pictureBox2.Location = new System.Drawing.Point(126, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_OR
            // 
            this.pictureBox_OR.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox_OR.Enabled = false;
            this.pictureBox_OR.Image = global::Logic_Gates.Properties.Resources.cc7b58cbcd341a19a6545d947e48329b;
            this.pictureBox_OR.Location = new System.Drawing.Point(464, 141);
            this.pictureBox_OR.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_OR.Name = "pictureBox_OR";
            this.pictureBox_OR.Size = new System.Drawing.Size(453, 302);
            this.pictureBox_OR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OR.TabIndex = 12;
            this.pictureBox_OR.TabStop = false;
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.Black;
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Home.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.ForeColor = System.Drawing.Color.White;
            this.Btn_Home.Location = new System.Drawing.Point(13, 460);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(115, 53);
            this.Btn_Home.TabIndex = 27;
            this.Btn_Home.Text = "Back";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Black;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(901, 460);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(115, 53);
            this.Btn_Exit.TabIndex = 26;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Nand_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1028, 525);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_OR1);
            this.Controls.Add(this.checkBox_OR_A);
            this.Controls.Add(this.checkBox_OR_B);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_OR);
            this.MaximizeBox = false;
            this.Name = "Nand_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_OR1;
        private System.Windows.Forms.CheckBox checkBox_OR_A;
        private System.Windows.Forms.CheckBox checkBox_OR_B;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_OR;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Button Btn_Exit;
    }
}