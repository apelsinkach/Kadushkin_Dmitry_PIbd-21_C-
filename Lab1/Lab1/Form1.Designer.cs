namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addLemon_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addOil_btn = new System.Windows.Forms.Button();
            this.addMeat_btn = new System.Windows.Forms.Button();
            this.getMeat_btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингридиенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(239, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кран";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getMeat_btn);
            this.groupBox3.Controls.Add(this.addMeat_btn);
            this.groupBox3.Controls.Add(this.addOil_btn);
            this.groupBox3.Controls.Add(this.addLemon_btn);
            this.groupBox3.Location = new System.Drawing.Point(13, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Маринад";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(457, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 225);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Гриль";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Location = new System.Drawing.Point(457, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 200);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Нож";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Взять мясо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addLemon_btn
            // 
            this.addLemon_btn.Location = new System.Drawing.Point(48, 21);
            this.addLemon_btn.Name = "addLemon_btn";
            this.addLemon_btn.Size = new System.Drawing.Size(134, 59);
            this.addLemon_btn.TabIndex = 1;
            this.addLemon_btn.Text = "Добавить пряности и лимон";
            this.addLemon_btn.UseVisualStyleBackColor = true;
            this.addLemon_btn.Visible = false;
            this.addLemon_btn.Click += new System.EventHandler(this.addLemon_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Взять лимон";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Взять масло";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "Взять специи";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addOil_btn
            // 
            this.addOil_btn.Location = new System.Drawing.Point(48, 86);
            this.addOil_btn.Name = "addOil_btn";
            this.addOil_btn.Size = new System.Drawing.Size(134, 34);
            this.addOil_btn.TabIndex = 2;
            this.addOil_btn.Text = "Добавить масло";
            this.addOil_btn.UseVisualStyleBackColor = true;
            this.addOil_btn.Click += new System.EventHandler(this.addOil_btn_Click);
            // 
            // addMeat_btn
            // 
            this.addMeat_btn.Location = new System.Drawing.Point(48, 126);
            this.addMeat_btn.Name = "addMeat_btn";
            this.addMeat_btn.Size = new System.Drawing.Size(134, 34);
            this.addMeat_btn.TabIndex = 3;
            this.addMeat_btn.Text = "Добавить мясо";
            this.addMeat_btn.UseVisualStyleBackColor = true;
            this.addMeat_btn.Visible = false;
            this.addMeat_btn.Click += new System.EventHandler(this.addMeat_btn_Click);
            // 
            // getMeat_btn
            // 
            this.getMeat_btn.Location = new System.Drawing.Point(48, 166);
            this.getMeat_btn.Name = "getMeat_btn";
            this.getMeat_btn.Size = new System.Drawing.Size(134, 35);
            this.getMeat_btn.TabIndex = 4;
            this.getMeat_btn.Text = "Достать мясо";
            this.getMeat_btn.UseVisualStyleBackColor = true;
            this.getMeat_btn.Visible = false;
            this.getMeat_btn.Click += new System.EventHandler(this.getMeat_btn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Открыт";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Закрыт";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Мыть мясо";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 29);
            this.button6.TabIndex = 3;
            this.button6.Text = "Мыть лимон";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(59, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 32);
            this.button7.TabIndex = 0;
            this.button7.Text = "Резать мясо";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(59, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 34);
            this.button8.TabIndex = 1;
            this.button8.Text = "Резать лимон";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(28, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 42);
            this.button9.TabIndex = 0;
            this.button9.Text = "Жарить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Location = new System.Drawing.Point(240, 223);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 225);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Уголь";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(37, 56);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 42);
            this.button10.TabIndex = 0;
            this.button10.Text = "Разжечь уголь";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 465);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addLemon_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button getMeat_btn;
        private System.Windows.Forms.Button addMeat_btn;
        private System.Windows.Forms.Button addOil_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button10;
    }
}

