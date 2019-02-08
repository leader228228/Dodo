namespace Dodo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.areaLbl = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Location = new System.Drawing.Point(4, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.area);
            this.groupBox1.Controls.Add(this.areaLbl);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.addressLbl);
            this.groupBox1.Controls.Add(this.lastNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(175, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a record";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(21, 125);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(253, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(98, 41);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(176, 22);
            this.lastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "м2";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(98, 97);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(145, 22);
            this.area.TabIndex = 1;
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(18, 102);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(38, 17);
            this.areaLbl.TabIndex = 5;
            this.areaLbl.Text = "Area";
            this.areaLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(98, 69);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(176, 22);
            this.address.TabIndex = 2;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(18, 74);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(60, 17);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Address";
            this.addressLbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(18, 46);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(74, 17);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Last name";
            this.lastNameLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

