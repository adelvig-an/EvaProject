﻿namespace _01_Eva
{
    partial class frm_start
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
            this.cbx_typeCost = new System.Windows.Forms.ComboBox();
            this.rb_typeCustom2 = new System.Windows.Forms.RadioButton();
            this.rb_typeCustom1 = new System.Windows.Forms.RadioButton();
            this.cbx_nameAppraiser = new System.Windows.Forms.ComboBox();
            this.txb_evaluationPurpose = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_contract = new System.Windows.Forms.DateTimePicker();
            this.date_compilation = new System.Windows.Forms.DateTimePicker();
            this.date_appraisal = new System.Windows.Forms.DateTimePicker();
            this.txb_numberContract = new System.Windows.Forms.TextBox();
            this.txb_numberReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_typeCost
            // 
            this.cbx_typeCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_typeCost.FormattingEnabled = true;
            this.cbx_typeCost.Items.AddRange(new object[] {
            "Рыночная стоимость",
            "Инвестиционная стоимость",
            "Ликвидационная стоимость",
            "Кадастровая стоимость"});
            this.cbx_typeCost.Location = new System.Drawing.Point(141, 162);
            this.cbx_typeCost.Name = "cbx_typeCost";
            this.cbx_typeCost.Size = new System.Drawing.Size(396, 21);
            this.cbx_typeCost.TabIndex = 44;
            // 
            // rb_typeCustom2
            // 
            this.rb_typeCustom2.AutoSize = true;
            this.rb_typeCustom2.Location = new System.Drawing.Point(263, 219);
            this.rb_typeCustom2.Name = "rb_typeCustom2";
            this.rb_typeCustom2.Size = new System.Drawing.Size(120, 17);
            this.rb_typeCustom2.TabIndex = 41;
            this.rb_typeCustom2.Text = "Юридическое лицо";
            this.rb_typeCustom2.UseVisualStyleBackColor = true;
            // 
            // rb_typeCustom1
            // 
            this.rb_typeCustom1.AutoSize = true;
            this.rb_typeCustom1.Checked = true;
            this.rb_typeCustom1.Location = new System.Drawing.Point(141, 219);
            this.rb_typeCustom1.Name = "rb_typeCustom1";
            this.rb_typeCustom1.Size = new System.Drawing.Size(116, 17);
            this.rb_typeCustom1.TabIndex = 40;
            this.rb_typeCustom1.TabStop = true;
            this.rb_typeCustom1.Text = "Физическое лицо";
            this.rb_typeCustom1.UseVisualStyleBackColor = true;
            // 
            // cbx_nameAppraiser
            // 
            this.cbx_nameAppraiser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nameAppraiser.FormattingEnabled = true;
            this.cbx_nameAppraiser.Items.AddRange(new object[] {
            "Дельвиг Антон Денисович",
            "Рошка Андрей Ильевич",
            "Шестаков Денис Александрович"});
            this.cbx_nameAppraiser.Location = new System.Drawing.Point(141, 189);
            this.cbx_nameAppraiser.Name = "cbx_nameAppraiser";
            this.cbx_nameAppraiser.Size = new System.Drawing.Size(396, 21);
            this.cbx_nameAppraiser.TabIndex = 39;
            // 
            // txb_evaluationPurpose
            // 
            this.txb_evaluationPurpose.Location = new System.Drawing.Point(141, 136);
            this.txb_evaluationPurpose.Name = "txb_evaluationPurpose";
            this.txb_evaluationPurpose.Size = new System.Drawing.Size(396, 20);
            this.txb_evaluationPurpose.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Тип заказчика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Оценщик/Исполнитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Вид стоимости";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Цель оценки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_contract);
            this.groupBox1.Controls.Add(this.date_compilation);
            this.groupBox1.Controls.Add(this.date_appraisal);
            this.groupBox1.Controls.Add(this.txb_numberContract);
            this.groupBox1.Controls.Add(this.txb_numberReport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 118);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информацмя отчета об оценке";
            // 
            // date_contract
            // 
            this.date_contract.Location = new System.Drawing.Point(361, 60);
            this.date_contract.Name = "date_contract";
            this.date_contract.Size = new System.Drawing.Size(138, 20);
            this.date_contract.TabIndex = 19;
            // 
            // date_compilation
            // 
            this.date_compilation.Location = new System.Drawing.Point(113, 86);
            this.date_compilation.Name = "date_compilation";
            this.date_compilation.Size = new System.Drawing.Size(138, 20);
            this.date_compilation.TabIndex = 18;
            // 
            // date_appraisal
            // 
            this.date_appraisal.Location = new System.Drawing.Point(113, 60);
            this.date_appraisal.Name = "date_appraisal";
            this.date_appraisal.Size = new System.Drawing.Size(138, 20);
            this.date_appraisal.TabIndex = 17;
            // 
            // txb_numberContract
            // 
            this.txb_numberContract.Location = new System.Drawing.Point(361, 34);
            this.txb_numberContract.Name = "txb_numberContract";
            this.txb_numberContract.Size = new System.Drawing.Size(138, 20);
            this.txb_numberContract.TabIndex = 16;
            // 
            // txb_numberReport
            // 
            this.txb_numberReport.Location = new System.Drawing.Point(113, 34);
            this.txb_numberReport.Name = "txb_numberReport";
            this.txb_numberReport.Size = new System.Drawing.Size(138, 20);
            this.txb_numberReport.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер договора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата составления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата оценки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер отчета";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(389, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Далее >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_typeCost);
            this.Controls.Add(this.rb_typeCustom2);
            this.Controls.Add(this.rb_typeCustom1);
            this.Controls.Add(this.cbx_nameAppraiser);
            this.Controls.Add(this.txb_evaluationPurpose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyEva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_typeCost;
        private System.Windows.Forms.RadioButton rb_typeCustom2;
        private System.Windows.Forms.RadioButton rb_typeCustom1;
        private System.Windows.Forms.ComboBox cbx_nameAppraiser;
        private System.Windows.Forms.TextBox txb_evaluationPurpose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_contract;
        private System.Windows.Forms.DateTimePicker date_compilation;
        private System.Windows.Forms.DateTimePicker date_appraisal;
        private System.Windows.Forms.TextBox txb_numberContract;
        private System.Windows.Forms.TextBox txb_numberReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

