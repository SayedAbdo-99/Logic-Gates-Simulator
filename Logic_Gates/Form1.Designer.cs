namespace Logic_Gates
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
            this.Btm_OR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btm_NAND = new System.Windows.Forms.Button();
            this.Btm_XOR = new System.Windows.Forms.Button();
            this.Btm_NOT = new System.Windows.Forms.Button();
            this.Btm_AND = new System.Windows.Forms.Button();
            this.Btm_NXOR = new System.Windows.Forms.Button();
            this.Btm_NOR = new System.Windows.Forms.Button();
            this.Btn_Buffer = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btm_OR
            // 
            this.Btm_OR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_OR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_OR.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_OR.ForeColor = System.Drawing.Color.White;
            this.Btm_OR.Location = new System.Drawing.Point(31, 114);
            this.Btm_OR.Name = "Btm_OR";
            this.Btm_OR.Size = new System.Drawing.Size(171, 111);
            this.Btm_OR.TabIndex = 0;
            this.Btm_OR.Text = "OR";
            this.Btm_OR.UseVisualStyleBackColor = false;
            this.Btm_OR.Click += new System.EventHandler(this.Btm_OR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logic Gates";
            // 
            // Btm_NAND
            // 
            this.Btm_NAND.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_NAND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_NAND.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_NAND.ForeColor = System.Drawing.Color.White;
            this.Btm_NAND.Location = new System.Drawing.Point(257, 279);
            this.Btm_NAND.Name = "Btm_NAND";
            this.Btm_NAND.Size = new System.Drawing.Size(171, 108);
            this.Btm_NAND.TabIndex = 2;
            this.Btm_NAND.Text = "NAND";
            this.Btm_NAND.UseVisualStyleBackColor = false;
            this.Btm_NAND.Click += new System.EventHandler(this.Btm_NAND_Click);
            // 
            // Btm_XOR
            // 
            this.Btm_XOR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_XOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_XOR.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_XOR.ForeColor = System.Drawing.Color.White;
            this.Btm_XOR.Location = new System.Drawing.Point(710, 114);
            this.Btm_XOR.Name = "Btm_XOR";
            this.Btm_XOR.Size = new System.Drawing.Size(171, 111);
            this.Btm_XOR.TabIndex = 4;
            this.Btm_XOR.Text = "XOR";
            this.Btm_XOR.UseVisualStyleBackColor = false;
            this.Btm_XOR.Click += new System.EventHandler(this.Btm_XOR_Click);
            // 
            // Btm_NOT
            // 
            this.Btm_NOT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_NOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_NOT.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_NOT.ForeColor = System.Drawing.Color.White;
            this.Btm_NOT.Location = new System.Drawing.Point(483, 114);
            this.Btm_NOT.Name = "Btm_NOT";
            this.Btm_NOT.Size = new System.Drawing.Size(171, 111);
            this.Btm_NOT.TabIndex = 5;
            this.Btm_NOT.Text = "NOT";
            this.Btm_NOT.UseVisualStyleBackColor = false;
            this.Btm_NOT.Click += new System.EventHandler(this.Btm_NOT_Click);
            // 
            // Btm_AND
            // 
            this.Btm_AND.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_AND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_AND.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_AND.ForeColor = System.Drawing.Color.White;
            this.Btm_AND.Location = new System.Drawing.Point(257, 114);
            this.Btm_AND.Name = "Btm_AND";
            this.Btm_AND.Size = new System.Drawing.Size(171, 111);
            this.Btm_AND.TabIndex = 6;
            this.Btm_AND.Text = "AND";
            this.Btm_AND.UseVisualStyleBackColor = false;
            this.Btm_AND.Click += new System.EventHandler(this.Btm_AND_Click);
            // 
            // Btm_NXOR
            // 
            this.Btm_NXOR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_NXOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_NXOR.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_NXOR.ForeColor = System.Drawing.Color.White;
            this.Btm_NXOR.Location = new System.Drawing.Point(710, 273);
            this.Btm_NXOR.Name = "Btm_NXOR";
            this.Btm_NXOR.Size = new System.Drawing.Size(171, 108);
            this.Btm_NXOR.TabIndex = 7;
            this.Btm_NXOR.Text = "NXOR";
            this.Btm_NXOR.UseVisualStyleBackColor = false;
            this.Btm_NXOR.Click += new System.EventHandler(this.Btm_NXOR_Click);
            // 
            // Btm_NOR
            // 
            this.Btm_NOR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btm_NOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_NOR.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_NOR.ForeColor = System.Drawing.Color.White;
            this.Btm_NOR.Location = new System.Drawing.Point(35, 273);
            this.Btm_NOR.Name = "Btm_NOR";
            this.Btm_NOR.Size = new System.Drawing.Size(167, 108);
            this.Btm_NOR.TabIndex = 8;
            this.Btm_NOR.Text = "NOR";
            this.Btm_NOR.UseVisualStyleBackColor = false;
            this.Btm_NOR.Click += new System.EventHandler(this.Btm_NOR_Click);
            // 
            // Btn_Buffer
            // 
            this.Btn_Buffer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Buffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buffer.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buffer.ForeColor = System.Drawing.Color.White;
            this.Btn_Buffer.Location = new System.Drawing.Point(483, 276);
            this.Btn_Buffer.Name = "Btn_Buffer";
            this.Btn_Buffer.Size = new System.Drawing.Size(171, 111);
            this.Btn_Buffer.TabIndex = 9;
            this.Btn_Buffer.Text = "Buffer";
            this.Btn_Buffer.UseVisualStyleBackColor = false;
            this.Btn_Buffer.Click += new System.EventHandler(this.Btn_Buffer_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.White;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(800, 437);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(115, 53);
            this.Btn_Exit.TabIndex = 10;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Buffer);
            this.Controls.Add(this.Btm_NOR);
            this.Controls.Add(this.Btm_NXOR);
            this.Controls.Add(this.Btm_AND);
            this.Controls.Add(this.Btm_NOT);
            this.Controls.Add(this.Btm_XOR);
            this.Controls.Add(this.Btm_NAND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btm_OR);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_OR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btm_NAND;
        private System.Windows.Forms.Button Btm_XOR;
        private System.Windows.Forms.Button Btm_NOT;
        private System.Windows.Forms.Button Btm_AND;
        private System.Windows.Forms.Button Btm_NXOR;
        private System.Windows.Forms.Button Btm_NOR;
        private System.Windows.Forms.Button Btn_Buffer;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

