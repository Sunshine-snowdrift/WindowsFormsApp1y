namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.UserList = new System.Windows.Forms.DataGridView();
            this.buttonAdd_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(495, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблица пользователей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserList
            // 
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(142, 110);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(946, 395);
            this.UserList.TabIndex = 2;
            this.UserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_CellContentClick);
            // 
            // buttonAdd_Click
            // 
            this.buttonAdd_Click.Location = new System.Drawing.Point(556, 564);
            this.buttonAdd_Click.Name = "buttonAdd_Click";
            this.buttonAdd_Click.Size = new System.Drawing.Size(142, 52);
            this.buttonAdd_Click.TabIndex = 3;
            this.buttonAdd_Click.Text = "Добавить";
            this.buttonAdd_Click.UseVisualStyleBackColor = true;
            this.buttonAdd_Click.Click += new System.EventHandler(this.buttonAdd_Click_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 655);
            this.Controls.Add(this.buttonAdd_Click);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView UserList;
        private System.Windows.Forms.Button buttonAdd_Click;
    }
}

