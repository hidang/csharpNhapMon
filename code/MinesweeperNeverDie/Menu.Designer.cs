
namespace MinesweeperNeverDie
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PlayEasy = new System.Windows.Forms.Button();
            this.btn_PlayIntermediate = new System.Windows.Forms.Button();
            this.btn_PlayExpert = new System.Windows.Forms.Button();
            this.btn_PlayCustom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Row = new System.Windows.Forms.TextBox();
            this.text_Col = new System.Windows.Forms.TextBox();
            this.text_Mine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_NhanPham = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.btn_ShowNhanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PlayEasy
            // 
            this.btn_PlayEasy.Location = new System.Drawing.Point(12, 91);
            this.btn_PlayEasy.Name = "btn_PlayEasy";
            this.btn_PlayEasy.Size = new System.Drawing.Size(229, 29);
            this.btn_PlayEasy.TabIndex = 0;
            this.btn_PlayEasy.Text = "Beginner";
            this.btn_PlayEasy.UseVisualStyleBackColor = true;
            this.btn_PlayEasy.Click += new System.EventHandler(this.btn_PlayEasy_Click);
            // 
            // btn_PlayIntermediate
            // 
            this.btn_PlayIntermediate.Location = new System.Drawing.Point(12, 126);
            this.btn_PlayIntermediate.Name = "btn_PlayIntermediate";
            this.btn_PlayIntermediate.Size = new System.Drawing.Size(229, 29);
            this.btn_PlayIntermediate.TabIndex = 1;
            this.btn_PlayIntermediate.Text = "Intermediate";
            this.btn_PlayIntermediate.UseVisualStyleBackColor = true;
            this.btn_PlayIntermediate.Click += new System.EventHandler(this.btn_PlayIntermediate_Click);
            // 
            // btn_PlayExpert
            // 
            this.btn_PlayExpert.Location = new System.Drawing.Point(12, 161);
            this.btn_PlayExpert.Name = "btn_PlayExpert";
            this.btn_PlayExpert.Size = new System.Drawing.Size(229, 29);
            this.btn_PlayExpert.TabIndex = 2;
            this.btn_PlayExpert.Text = "Expert";
            this.btn_PlayExpert.UseVisualStyleBackColor = true;
            this.btn_PlayExpert.Click += new System.EventHandler(this.btn_PlayExpert_Click);
            // 
            // btn_PlayCustom
            // 
            this.btn_PlayCustom.Location = new System.Drawing.Point(11, 254);
            this.btn_PlayCustom.Name = "btn_PlayCustom";
            this.btn_PlayCustom.Size = new System.Drawing.Size(229, 29);
            this.btn_PlayCustom.TabIndex = 3;
            this.btn_PlayCustom.Text = "Custom";
            this.btn_PlayCustom.UseVisualStyleBackColor = true;
            this.btn_PlayCustom.Click += new System.EventHandler(this.btn_PlayCustom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "0s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time: ";
            // 
            // text_Row
            // 
            this.text_Row.Location = new System.Drawing.Point(12, 221);
            this.text_Row.Name = "text_Row";
            this.text_Row.Size = new System.Drawing.Size(75, 27);
            this.text_Row.TabIndex = 6;
            // 
            // text_Col
            // 
            this.text_Col.Location = new System.Drawing.Point(93, 221);
            this.text_Col.Name = "text_Col";
            this.text_Col.Size = new System.Drawing.Size(75, 27);
            this.text_Col.TabIndex = 7;
            // 
            // text_Mine
            // 
            this.text_Mine.Location = new System.Drawing.Point(174, 221);
            this.text_Mine.Name = "text_Mine";
            this.text_Mine.Size = new System.Drawing.Size(66, 27);
            this.text_Mine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Col";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "NhanPham:";
            // 
            // label_NhanPham
            // 
            this.label_NhanPham.AutoSize = true;
            this.label_NhanPham.Location = new System.Drawing.Point(510, 129);
            this.label_NhanPham.Name = "label_NhanPham";
            this.label_NhanPham.Size = new System.Drawing.Size(17, 20);
            this.label_NhanPham.TabIndex = 13;
            this.label_NhanPham.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(77, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 42);
            this.label7.TabIndex = 14;
            this.label7.Text = "MinesweeperNeverDie";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Status.Location = new System.Drawing.Point(393, 170);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 20);
            this.label_Status.TabIndex = 15;
            // 
            // btn_ShowNhanPham
            // 
            this.btn_ShowNhanPham.Location = new System.Drawing.Point(446, 254);
            this.btn_ShowNhanPham.Name = "btn_ShowNhanPham";
            this.btn_ShowNhanPham.Size = new System.Drawing.Size(102, 29);
            this.btn_ShowNhanPham.TabIndex = 19;
            this.btn_ShowNhanPham.Text = "NhanPham?";
            this.btn_ShowNhanPham.UseVisualStyleBackColor = true;
            this.btn_ShowNhanPham.Click += new System.EventHandler(this.btn_ShowNhanPham_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 309);
            this.Controls.Add(this.btn_ShowNhanPham);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_NhanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Mine);
            this.Controls.Add(this.text_Col);
            this.Controls.Add(this.text_Row);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PlayCustom);
            this.Controls.Add(this.btn_PlayExpert);
            this.Controls.Add(this.btn_PlayIntermediate);
            this.Controls.Add(this.btn_PlayEasy);
            this.Name = "Menu";
            this.Text = "MinesweeperNeverDie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlayEasy;
        private System.Windows.Forms.Button btn_PlayIntermediate;
        private System.Windows.Forms.Button btn_PlayExpert;
        private System.Windows.Forms.Button btn_PlayCustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Row;
        private System.Windows.Forms.TextBox text_Col;
        private System.Windows.Forms.TextBox text_Mine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_NhanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button btn_ShowNhanPham;
    }
}

