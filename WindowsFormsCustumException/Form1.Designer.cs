namespace WindowsFormsCustumException
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
            this.label_beolvasott_sorok = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_eredmeny = new System.Windows.Forms.TextBox();
            this.comboBox_muvelet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_beolvasott_sorok
            // 
            this.label_beolvasott_sorok.AutoSize = true;
            this.label_beolvasott_sorok.Location = new System.Drawing.Point(15, 22);
            this.label_beolvasott_sorok.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_beolvasott_sorok.Name = "label_beolvasott_sorok";
            this.label_beolvasott_sorok.Size = new System.Drawing.Size(209, 24);
            this.label_beolvasott_sorok.TabIndex = 0;
            this.label_beolvasott_sorok.Text = "beolvasott sorok száma:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_eredmeny);
            this.groupBox1.Controls.Add(this.comboBox_muvelet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Location = new System.Drawing.Point(19, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aritmetikai művelet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_eredmeny
            // 
            this.textBox_eredmeny.Location = new System.Drawing.Point(545, 35);
            this.textBox_eredmeny.Name = "textBox_eredmeny";
            this.textBox_eredmeny.Size = new System.Drawing.Size(100, 29);
            this.textBox_eredmeny.TabIndex = 14;
            // 
            // comboBox_muvelet
            // 
            this.comboBox_muvelet.FormattingEnabled = true;
            this.comboBox_muvelet.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox_muvelet.Location = new System.Drawing.Point(174, 32);
            this.comboBox_muvelet.Name = "comboBox_muvelet";
            this.comboBox_muvelet.Size = new System.Drawing.Size(121, 32);
            this.comboBox_muvelet.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "b:";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(344, 35);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 29);
            this.textBox_b.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "a:";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(51, 35);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 29);
            this.textBox_a.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_beolvasott_sorok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_beolvasott_sorok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_eredmeny;
        private System.Windows.Forms.ComboBox comboBox_muvelet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_a;
    }
}

