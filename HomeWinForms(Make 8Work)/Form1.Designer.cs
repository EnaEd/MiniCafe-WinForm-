namespace HomeWinForms_Make_8Work_
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
            this.GasOil = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumOil = new System.Windows.Forms.RadioButton();
            this.qntOil = new System.Windows.Forms.RadioButton();
            this.OilPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalGas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cafe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClQuan = new System.Windows.Forms.TextBox();
            this.FrQuan = new System.Windows.Forms.TextBox();
            this.BrgrQuan = new System.Windows.Forms.TextBox();
            this.HDQuan = new System.Windows.Forms.TextBox();
            this.ClPrice = new System.Windows.Forms.TextBox();
            this.FrPrice = new System.Windows.Forms.TextBox();
            this.BrgrPrice = new System.Windows.Forms.TextBox();
            this.HDPrice = new System.Windows.Forms.TextBox();
            this.Cola = new System.Windows.Forms.CheckBox();
            this.Fri = new System.Windows.Forms.CheckBox();
            this.Burger = new System.Windows.Forms.CheckBox();
            this.HotDog = new System.Windows.Forms.CheckBox();
            this.TotalCafe = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalSum = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Label();
            this.resault = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GasOil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TotalGas.SuspendLayout();
            this.Cafe.SuspendLayout();
            this.TotalCafe.SuspendLayout();
            this.TotalSum.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasOil
            // 
            this.GasOil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GasOil.Controls.Add(this.comboBox1);
            this.GasOil.Controls.Add(this.label4);
            this.GasOil.Controls.Add(this.label3);
            this.GasOil.Controls.Add(this.maskedTextBox2);
            this.GasOil.Controls.Add(this.maskedTextBox1);
            this.GasOil.Controls.Add(this.panel1);
            this.GasOil.Controls.Add(this.OilPrice);
            this.GasOil.Controls.Add(this.label2);
            this.GasOil.Controls.Add(this.label1);
            this.GasOil.Controls.Add(this.TotalGas);
            this.GasOil.Location = new System.Drawing.Point(12, 52);
            this.GasOil.Name = "GasOil";
            this.GasOil.Size = new System.Drawing.Size(224, 316);
            this.GasOil.TabIndex = 0;
            this.GasOil.TabStop = false;
            this.GasOil.Text = "Автозаправка";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "А-76",
            "А-92",
            "А-95",
            "А-95Euro",
            "Disel"});
            this.comboBox1.Location = new System.Drawing.Point(98, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(185, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "грн.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(185, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "лт.";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(114, 193);
            this.maskedTextBox2.Mask = "000#.##";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(114, 141);
            this.maskedTextBox1.Mask = "#.##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sumOil);
            this.panel1.Controls.Add(this.qntOil);
            this.panel1.Location = new System.Drawing.Point(6, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 97);
            this.panel1.TabIndex = 5;
            // 
            // sumOil
            // 
            this.sumOil.AutoSize = true;
            this.sumOil.Location = new System.Drawing.Point(4, 67);
            this.sumOil.Name = "sumOil";
            this.sumOil.Size = new System.Drawing.Size(59, 17);
            this.sumOil.TabIndex = 1;
            this.sumOil.Text = "Сумма";
            this.sumOil.UseVisualStyleBackColor = true;
            this.sumOil.CheckedChanged += new System.EventHandler(this.sumOil_CheckedChanged);
            // 
            // qntOil
            // 
            this.qntOil.AutoSize = true;
            this.qntOil.Checked = true;
            this.qntOil.Location = new System.Drawing.Point(4, 15);
            this.qntOil.Name = "qntOil";
            this.qntOil.Size = new System.Drawing.Size(59, 17);
            this.qntOil.TabIndex = 0;
            this.qntOil.TabStop = true;
            this.qntOil.Text = "Кол-во";
            this.qntOil.UseVisualStyleBackColor = true;
            this.qntOil.CheckedChanged += new System.EventHandler(this.qntOil_CheckedChanged);
            // 
            // OilPrice
            // 
            this.OilPrice.Location = new System.Drawing.Point(98, 55);
            this.OilPrice.Name = "OilPrice";
            this.OilPrice.Size = new System.Drawing.Size(120, 20);
            this.OilPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бензин";
            // 
            // TotalGas
            // 
            this.TotalGas.Controls.Add(this.label8);
            this.TotalGas.Location = new System.Drawing.Point(6, 231);
            this.TotalGas.Name = "TotalGas";
            this.TotalGas.Size = new System.Drawing.Size(212, 71);
            this.TotalGas.TabIndex = 0;
            this.TotalGas.TabStop = false;
            this.TotalGas.Text = "К оплате";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // Cafe
            // 
            this.Cafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cafe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cafe.Controls.Add(this.label6);
            this.Cafe.Controls.Add(this.label5);
            this.Cafe.Controls.Add(this.ClQuan);
            this.Cafe.Controls.Add(this.FrQuan);
            this.Cafe.Controls.Add(this.BrgrQuan);
            this.Cafe.Controls.Add(this.HDQuan);
            this.Cafe.Controls.Add(this.ClPrice);
            this.Cafe.Controls.Add(this.FrPrice);
            this.Cafe.Controls.Add(this.BrgrPrice);
            this.Cafe.Controls.Add(this.HDPrice);
            this.Cafe.Controls.Add(this.Cola);
            this.Cafe.Controls.Add(this.Fri);
            this.Cafe.Controls.Add(this.Burger);
            this.Cafe.Controls.Add(this.HotDog);
            this.Cafe.Controls.Add(this.TotalCafe);
            this.Cafe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cafe.Location = new System.Drawing.Point(256, 52);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(224, 316);
            this.Cafe.TabIndex = 1;
            this.Cafe.TabStop = false;
            this.Cafe.Text = "Мини-Кафе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // ClQuan
            // 
            this.ClQuan.Location = new System.Drawing.Point(139, 104);
            this.ClQuan.Name = "ClQuan";
            this.ClQuan.Size = new System.Drawing.Size(67, 20);
            this.ClQuan.TabIndex = 12;
            this.ClQuan.TextChanged += new System.EventHandler(this.ClQuan_TextChanged);
            // 
            // FrQuan
            // 
            this.FrQuan.Location = new System.Drawing.Point(139, 77);
            this.FrQuan.Name = "FrQuan";
            this.FrQuan.Size = new System.Drawing.Size(67, 20);
            this.FrQuan.TabIndex = 11;
            this.FrQuan.TextChanged += new System.EventHandler(this.FrQuan_TextChanged);
            // 
            // BrgrQuan
            // 
            this.BrgrQuan.Location = new System.Drawing.Point(139, 52);
            this.BrgrQuan.Name = "BrgrQuan";
            this.BrgrQuan.Size = new System.Drawing.Size(67, 20);
            this.BrgrQuan.TabIndex = 10;
            this.BrgrQuan.TextChanged += new System.EventHandler(this.BrgrQuan_TextChanged);
            // 
            // HDQuan
            // 
            this.HDQuan.Location = new System.Drawing.Point(139, 26);
            this.HDQuan.Name = "HDQuan";
            this.HDQuan.Size = new System.Drawing.Size(67, 20);
            this.HDQuan.TabIndex = 9;
            this.HDQuan.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ClPrice
            // 
            this.ClPrice.Enabled = false;
            this.ClPrice.Location = new System.Drawing.Point(94, 104);
            this.ClPrice.Name = "ClPrice";
            this.ClPrice.Size = new System.Drawing.Size(38, 20);
            this.ClPrice.TabIndex = 8;
            this.ClPrice.Text = "4.40";
            // 
            // FrPrice
            // 
            this.FrPrice.Enabled = false;
            this.FrPrice.Location = new System.Drawing.Point(94, 77);
            this.FrPrice.Name = "FrPrice";
            this.FrPrice.Size = new System.Drawing.Size(38, 20);
            this.FrPrice.TabIndex = 7;
            this.FrPrice.Text = "7.20";
            // 
            // BrgrPrice
            // 
            this.BrgrPrice.Enabled = false;
            this.BrgrPrice.Location = new System.Drawing.Point(94, 52);
            this.BrgrPrice.Name = "BrgrPrice";
            this.BrgrPrice.Size = new System.Drawing.Size(38, 20);
            this.BrgrPrice.TabIndex = 6;
            this.BrgrPrice.Text = "5.40";
            // 
            // HDPrice
            // 
            this.HDPrice.Enabled = false;
            this.HDPrice.Location = new System.Drawing.Point(94, 26);
            this.HDPrice.Name = "HDPrice";
            this.HDPrice.Size = new System.Drawing.Size(38, 20);
            this.HDPrice.TabIndex = 5;
            this.HDPrice.Text = "4.00";
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cola.Location = new System.Drawing.Point(6, 107);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(55, 17);
            this.Cola.TabIndex = 4;
            this.Cola.Text = "Кола";
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.CheckedChanged += new System.EventHandler(this.Cola_CheckedChanged);
            // 
            // Fri
            // 
            this.Fri.AutoSize = true;
            this.Fri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fri.Location = new System.Drawing.Point(6, 80);
            this.Fri.Name = "Fri";
            this.Fri.Size = new System.Drawing.Size(52, 17);
            this.Fri.TabIndex = 3;
            this.Fri.Text = "Фри";
            this.Fri.UseVisualStyleBackColor = true;
            this.Fri.CheckedChanged += new System.EventHandler(this.Fri_CheckedChanged);
            // 
            // Burger
            // 
            this.Burger.AutoSize = true;
            this.Burger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Burger.Location = new System.Drawing.Point(6, 53);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(89, 17);
            this.Burger.TabIndex = 2;
            this.Burger.Text = "Гамбургер";
            this.Burger.UseVisualStyleBackColor = true;
            this.Burger.CheckedChanged += new System.EventHandler(this.Burger_CheckedChanged);
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotDog.Location = new System.Drawing.Point(6, 29);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(74, 17);
            this.HotDog.TabIndex = 1;
            this.HotDog.Text = "Хот-Дог";
            this.HotDog.UseVisualStyleBackColor = true;
            this.HotDog.CheckedChanged += new System.EventHandler(this.HotDog_CheckedChanged);
            // 
            // TotalCafe
            // 
            this.TotalCafe.Controls.Add(this.label7);
            this.TotalCafe.Location = new System.Drawing.Point(6, 231);
            this.TotalCafe.Name = "TotalCafe";
            this.TotalCafe.Size = new System.Drawing.Size(212, 71);
            this.TotalCafe.TabIndex = 0;
            this.TotalCafe.TabStop = false;
            this.TotalCafe.Text = "К оплате";
            this.TotalCafe.Enter += new System.EventHandler(this.TotalCafe_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // TotalSum
            // 
            this.TotalSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalSum.BackColor = System.Drawing.SystemColors.Info;
            this.TotalSum.Controls.Add(this.total);
            this.TotalSum.Controls.Add(this.resault);
            this.TotalSum.Location = new System.Drawing.Point(12, 411);
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.Size = new System.Drawing.Size(468, 114);
            this.TotalSum.TabIndex = 2;
            this.TotalSum.TabStop = false;
            this.TotalSum.Text = "Всего к оплате";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(357, 58);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 1;
            // 
            // resault
            // 
            this.resault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resault.Location = new System.Drawing.Point(98, 44);
            this.resault.Name = "resault";
            this.resault.Size = new System.Drawing.Size(108, 41);
            this.resault.TabIndex = 0;
            this.resault.Text = "Посчитать";
            this.resault.UseVisualStyleBackColor = true;
            this.resault.Click += new System.EventHandler(this.resault_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Всего выручки";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TotalSum);
            this.Controls.Add(this.Cafe);
            this.Controls.Add(this.GasOil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GasOil.ResumeLayout(false);
            this.GasOil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TotalGas.ResumeLayout(false);
            this.TotalGas.PerformLayout();
            this.Cafe.ResumeLayout(false);
            this.Cafe.PerformLayout();
            this.TotalCafe.ResumeLayout(false);
            this.TotalCafe.PerformLayout();
            this.TotalSum.ResumeLayout(false);
            this.TotalSum.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GasOil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sumOil;
        private System.Windows.Forms.RadioButton qntOil;
        private System.Windows.Forms.TextBox OilPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TotalGas;
        private System.Windows.Forms.GroupBox Cafe;
        private System.Windows.Forms.GroupBox TotalCafe;
        private System.Windows.Forms.GroupBox TotalSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClQuan;
        private System.Windows.Forms.TextBox FrQuan;
        private System.Windows.Forms.TextBox BrgrQuan;
        private System.Windows.Forms.TextBox HDQuan;
        private System.Windows.Forms.TextBox ClPrice;
        private System.Windows.Forms.TextBox FrPrice;
        private System.Windows.Forms.TextBox BrgrPrice;
        private System.Windows.Forms.TextBox HDPrice;
        private System.Windows.Forms.CheckBox Cola;
        private System.Windows.Forms.CheckBox Fri;
        private System.Windows.Forms.CheckBox Burger;
        private System.Windows.Forms.CheckBox HotDog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button resault;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

