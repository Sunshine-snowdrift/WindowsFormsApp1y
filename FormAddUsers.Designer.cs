namespace WindowsFormsApp1
{
    partial class FormAddUsers
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextbox = new System.Windows.Forms.TextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(26, 30);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(115, 47);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(234, 181);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(167, 20);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(234, 249);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(167, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(234, 315);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(167, 20);
            this.passwordTextBox2.TabIndex = 3;
            this.passwordTextBox2.TextChanged += new System.EventHandler(this.passwordTextBox2_TextChanged);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(234, 381);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(167, 20);
            this.emailTextbox.TabIndex = 4;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Location = new System.Drawing.Point(788, 181);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(167, 20);
            this.first_NameTextBox.TabIndex = 6;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            // 
            // second_NameTextbox
            // 
            this.second_NameTextbox.Location = new System.Drawing.Point(788, 249);
            this.second_NameTextbox.Name = "second_NameTextbox";
            this.second_NameTextbox.Size = new System.Drawing.Size(167, 20);
            this.second_NameTextbox.TabIndex = 7;
            this.second_NameTextbox.TextChanged += new System.EventHandler(this.second_NameTextbox_TextChanged);
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataSource = this.bindingSource1;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(788, 315);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(167, 21);
            this.roleIDComboBox.TabIndex = 8;
            this.roleIDComboBox.ValueMember = "ID";
            this.roleIDComboBox.SelectedIndexChanged += new System.EventHandler(this.roleIDComboBox_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.DBContext.Roles);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(747, 436);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужской";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(870, 436);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Женский";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(1032, 551);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(115, 47);
            this.ButtonAdd.TabIndex = 11;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Повтор пароля:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Эл. Почта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Фамилия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Роль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Пол:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(234, 461);
            this.maskedTextBox1.Mask = "+7(___) ___-__-__";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(167, 20);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 637);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.second_NameTextbox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ButtonBack);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox second_NameTextbox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}