namespace Gazovik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ученикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУченикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьУченикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеУченикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ученикиToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ученикиToolStripMenuItem
            // 
            this.ученикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУченикаToolStripMenuItem,
            this.удалитьУченикаToolStripMenuItem,
            this.изменитьДанныеУченикаToolStripMenuItem});
            this.ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            this.ученикиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ученикиToolStripMenuItem.Text = "Ученики";
            this.ученикиToolStripMenuItem.Visible = false;
            // 
            // добавитьУченикаToolStripMenuItem
            // 
            this.добавитьУченикаToolStripMenuItem.Name = "добавитьУченикаToolStripMenuItem";
            this.добавитьУченикаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьУченикаToolStripMenuItem.Text = "Добавить ученика";
            this.добавитьУченикаToolStripMenuItem.Click += new System.EventHandler(this.добавитьУченикаToolStripMenuItem_Click);
            // 
            // удалитьУченикаToolStripMenuItem
            // 
            this.удалитьУченикаToolStripMenuItem.Name = "удалитьУченикаToolStripMenuItem";
            this.удалитьУченикаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьУченикаToolStripMenuItem.Text = "Удалить ученика";
            this.удалитьУченикаToolStripMenuItem.Click += new System.EventHandler(this.удалитьУченикаToolStripMenuItem_Click);
            // 
            // изменитьДанныеУченикаToolStripMenuItem
            // 
            this.изменитьДанныеУченикаToolStripMenuItem.Name = "изменитьДанныеУченикаToolStripMenuItem";
            this.изменитьДанныеУченикаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.изменитьДанныеУченикаToolStripMenuItem.Text = "Изменить данные ученика";
            this.изменитьДанныеУченикаToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеУченикаToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(258, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать учителя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 4;
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.birthday,
            this.mobile,
            this.address,
            this.nameParent,
            this.fio_mobile});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 273);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(258, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 71);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить учителя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.FillWeight = 150F;
            this.name.Frozen = true;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // birthday
            // 
            this.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.birthday.Frozen = true;
            this.birthday.HeaderText = "День рождение";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 80;
            // 
            // mobile
            // 
            this.mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mobile.Frozen = true;
            this.mobile.HeaderText = "Номер телефона";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.address.Frozen = true;
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 120;
            // 
            // nameParent
            // 
            this.nameParent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameParent.Frozen = true;
            this.nameParent.HeaderText = "Имя родителя";
            this.nameParent.Name = "nameParent";
            this.nameParent.ReadOnly = true;
            this.nameParent.Width = 150;
            // 
            // fio_mobile
            // 
            this.fio_mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fio_mobile.Frozen = true;
            this.fio_mobile.HeaderText = "Номер родителя";
            this.fio_mobile.Name = "fio_mobile";
            this.fio_mobile.ReadOnly = true;
            this.fio_mobile.Width = 110;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 302);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "СОК \"Газовик\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ученикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУченикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьУченикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеУченикаToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio_mobile;
    }
}

