
namespace HR_department
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.TBFlat = new System.Windows.Forms.TextBox();
            this.TBHouse = new System.Windows.Forms.TextBox();
            this.TBStreet = new System.Windows.Forms.TextBox();
            this.TBPhoneNumber = new System.Windows.Forms.TextBox();
            this.TBDepartment = new System.Windows.Forms.TextBox();
            this.TBBirthday = new System.Windows.Forms.TextBox();
            this.TBPatronymic = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFilterDepartment = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(239, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonInsert);
            this.tabPage1.Controls.Add(this.TBFlat);
            this.tabPage1.Controls.Add(this.TBHouse);
            this.tabPage1.Controls.Add(this.TBStreet);
            this.tabPage1.Controls.Add(this.TBPhoneNumber);
            this.tabPage1.Controls.Add(this.TBDepartment);
            this.tabPage1.Controls.Add(this.TBBirthday);
            this.tabPage1.Controls.Add(this.TBPatronymic);
            this.tabPage1.Controls.Add(this.TBName);
            this.tabPage1.Controls.Add(this.TBSurname);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(231, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(28, 359);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(181, 48);
            this.buttonInsert.TabIndex = 28;
            this.buttonInsert.Text = "Добавить в базу данных";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // TBFlat
            // 
            this.TBFlat.Location = new System.Drawing.Point(109, 323);
            this.TBFlat.Name = "TBFlat";
            this.TBFlat.Size = new System.Drawing.Size(100, 20);
            this.TBFlat.TabIndex = 27;
            // 
            // TBHouse
            // 
            this.TBHouse.Location = new System.Drawing.Point(109, 286);
            this.TBHouse.Name = "TBHouse";
            this.TBHouse.Size = new System.Drawing.Size(100, 20);
            this.TBHouse.TabIndex = 26;
            // 
            // TBStreet
            // 
            this.TBStreet.Location = new System.Drawing.Point(109, 242);
            this.TBStreet.Name = "TBStreet";
            this.TBStreet.Size = new System.Drawing.Size(100, 20);
            this.TBStreet.TabIndex = 25;
            // 
            // TBPhoneNumber
            // 
            this.TBPhoneNumber.Location = new System.Drawing.Point(109, 207);
            this.TBPhoneNumber.Name = "TBPhoneNumber";
            this.TBPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TBPhoneNumber.TabIndex = 24;
            // 
            // TBDepartment
            // 
            this.TBDepartment.Location = new System.Drawing.Point(109, 171);
            this.TBDepartment.Name = "TBDepartment";
            this.TBDepartment.Size = new System.Drawing.Size(100, 20);
            this.TBDepartment.TabIndex = 23;
            // 
            // TBBirthday
            // 
            this.TBBirthday.Location = new System.Drawing.Point(109, 136);
            this.TBBirthday.Name = "TBBirthday";
            this.TBBirthday.Size = new System.Drawing.Size(100, 20);
            this.TBBirthday.TabIndex = 22;
            // 
            // TBPatronymic
            // 
            this.TBPatronymic.Location = new System.Drawing.Point(109, 101);
            this.TBPatronymic.Name = "TBPatronymic";
            this.TBPatronymic.Size = new System.Drawing.Size(100, 20);
            this.TBPatronymic.TabIndex = 21;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(109, 62);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 20;
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(109, 27);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(100, 20);
            this.TBSurname.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Квартира";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Дом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Улица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(231, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(239, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Поиск";
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(302, 365);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(204, 20);
            this.TBSearch.TabIndex = 3;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // comboBoxFilterDepartment
            // 
            this.comboBoxFilterDepartment.FormattingEnabled = true;
            this.comboBoxFilterDepartment.Items.AddRange(new object[] {
            "Все",
            "Аналитический",
            "Хозяйственный",
            "Рабочий",
            "Управляющий",
            "Охраняющий"});
            this.comboBoxFilterDepartment.Location = new System.Drawing.Point(248, 408);
            this.comboBoxFilterDepartment.Name = "comboBoxFilterDepartment";
            this.comboBoxFilterDepartment.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFilterDepartment.TabIndex = 4;
            this.comboBoxFilterDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDepartment_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFilterDepartment);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TBFlat;
        private System.Windows.Forms.TextBox TBHouse;
        private System.Windows.Forms.TextBox TBStreet;
        private System.Windows.Forms.TextBox TBPhoneNumber;
        private System.Windows.Forms.TextBox TBDepartment;
        private System.Windows.Forms.TextBox TBBirthday;
        private System.Windows.Forms.TextBox TBPatronymic;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterDepartment;
    }
}

