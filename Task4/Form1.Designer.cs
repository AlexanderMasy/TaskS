
namespace Task4
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSelfAssessment = new System.Windows.Forms.TextBox();
            this.textBoxEvaluationOfPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEvaluationByDescendants = new System.Windows.Forms.TextBox();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonClearCalculatData = new System.Windows.Forms.Button();
            this.labelDirectorData = new System.Windows.Forms.Label();
            this.labelSubsidiaryData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(134, 6);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(148, 26);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.Text = "Иванов";
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Самооценка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Оценка людей:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxSelfAssessment
            // 
            this.textBoxSelfAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelfAssessment.Location = new System.Drawing.Point(134, 46);
            this.textBoxSelfAssessment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSelfAssessment.Name = "textBoxSelfAssessment";
            this.textBoxSelfAssessment.Size = new System.Drawing.Size(148, 26);
            this.textBoxSelfAssessment.TabIndex = 4;
            this.textBoxSelfAssessment.Text = "7";
            // 
            // textBoxEvaluationOfPeople
            // 
            this.textBoxEvaluationOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEvaluationOfPeople.Location = new System.Drawing.Point(134, 89);
            this.textBoxEvaluationOfPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEvaluationOfPeople.Name = "textBoxEvaluationOfPeople";
            this.textBoxEvaluationOfPeople.Size = new System.Drawing.Size(148, 26);
            this.textBoxEvaluationOfPeople.TabIndex = 5;
            this.textBoxEvaluationOfPeople.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(350, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оценка потомка (P):";
            // 
            // textBoxEvaluationByDescendants
            // 
            this.textBoxEvaluationByDescendants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEvaluationByDescendants.Location = new System.Drawing.Point(519, 9);
            this.textBoxEvaluationByDescendants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEvaluationByDescendants.Name = "textBoxEvaluationByDescendants";
            this.textBoxEvaluationByDescendants.Size = new System.Drawing.Size(131, 26);
            this.textBoxEvaluationByDescendants.TabIndex = 7;
            this.textBoxEvaluationByDescendants.Text = "9";
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalculator.Location = new System.Drawing.Point(354, 77);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(130, 38);
            this.buttonCalculator.TabIndex = 8;
            this.buttonCalculator.Text = "Расчёт";
            this.buttonCalculator.UseVisualStyleBackColor = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonClearCalculatData
            // 
            this.buttonClearCalculatData.Image = global::Task4.Properties.Resources.корзинка;
            this.buttonClearCalculatData.Location = new System.Drawing.Point(519, 52);
            this.buttonClearCalculatData.Name = "buttonClearCalculatData";
            this.buttonClearCalculatData.Size = new System.Drawing.Size(59, 63);
            this.buttonClearCalculatData.TabIndex = 9;
            this.buttonClearCalculatData.UseVisualStyleBackColor = true;
            this.buttonClearCalculatData.Click += new System.EventHandler(this.buttonClearCalculatData_Click);
            // 
            // labelDirectorData
            // 
            this.labelDirectorData.AutoSize = true;
            this.labelDirectorData.Location = new System.Drawing.Point(6, 34);
            this.labelDirectorData.Name = "labelDirectorData";
            this.labelDirectorData.Size = new System.Drawing.Size(0, 20);
            this.labelDirectorData.TabIndex = 10;
            // 
            // labelSubsidiaryData
            // 
            this.labelSubsidiaryData.AutoSize = true;
            this.labelSubsidiaryData.Location = new System.Drawing.Point(6, 34);
            this.labelSubsidiaryData.Name = "labelSubsidiaryData";
            this.labelSubsidiaryData.Size = new System.Drawing.Size(0, 20);
            this.labelSubsidiaryData.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDirectorData);
            this.groupBox1.Location = new System.Drawing.Point(17, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 323);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные родителя:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSubsidiaryData);
            this.groupBox2.Location = new System.Drawing.Point(354, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 323);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные потомка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearCalculatData);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.textBoxEvaluationByDescendants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEvaluationOfPeople);
            this.Controls.Add(this.textBoxSelfAssessment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSelfAssessment;
        private System.Windows.Forms.TextBox textBoxEvaluationOfPeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEvaluationByDescendants;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonClearCalculatData;
        private System.Windows.Forms.Label labelDirectorData;
        private System.Windows.Forms.Label labelSubsidiaryData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

