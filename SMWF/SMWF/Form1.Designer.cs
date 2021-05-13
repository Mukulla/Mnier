namespace SMWF
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denuoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sileoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediocrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.circaToolStripMenuItem,
            this.новаяИграToolStripMenuItem,
            this.зановоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denuoToolStripMenuItem,
            this.sileoToolStripMenuItem,
            this.toolStripSeparator1,
            this.facileToolStripMenuItem,
            this.mediocrisToolStripMenuItem,
            this.durumToolStripMenuItem,
            this.eiusToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitusToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // denuoToolStripMenuItem
            // 
            this.denuoToolStripMenuItem.Name = "denuoToolStripMenuItem";
            this.denuoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.denuoToolStripMenuItem.Text = "F1 Новая игра";
            this.denuoToolStripMenuItem.Click += new System.EventHandler(this.denuoToolStripMenuItem_Click);
            // 
            // sileoToolStripMenuItem
            // 
            this.sileoToolStripMenuItem.Name = "sileoToolStripMenuItem";
            this.sileoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sileoToolStripMenuItem.Text = "F2 Перезапуск";
            this.sileoToolStripMenuItem.Click += new System.EventHandler(this.sileoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facileToolStripMenuItem.Text = "Легко";
            this.facileToolStripMenuItem.Click += new System.EventHandler(this.facileToolStripMenuItem_Click);
            // 
            // mediocrisToolStripMenuItem
            // 
            this.mediocrisToolStripMenuItem.Name = "mediocrisToolStripMenuItem";
            this.mediocrisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediocrisToolStripMenuItem.Text = "Средне";
            this.mediocrisToolStripMenuItem.Click += new System.EventHandler(this.mediocrisToolStripMenuItem_Click);
            // 
            // durumToolStripMenuItem
            // 
            this.durumToolStripMenuItem.Name = "durumToolStripMenuItem";
            this.durumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durumToolStripMenuItem.Text = "Сложно";
            this.durumToolStripMenuItem.Click += new System.EventHandler(this.durumToolStripMenuItem_Click);
            // 
            // eiusToolStripMenuItem
            // 
            this.eiusToolStripMenuItem.Name = "eiusToolStripMenuItem";
            this.eiusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eiusToolStripMenuItem.Text = "Свой выбор";
            this.eiusToolStripMenuItem.Click += new System.EventHandler(this.eiusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitusToolStripMenuItem
            // 
            this.exitusToolStripMenuItem.Name = "exitusToolStripMenuItem";
            this.exitusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitusToolStripMenuItem.Text = "Esc Выход";
            this.exitusToolStripMenuItem.Click += new System.EventHandler(this.exitusToolStripMenuItem_Click);
            // 
            // circaToolStripMenuItem
            // 
            this.circaToolStripMenuItem.Name = "circaToolStripMenuItem";
            this.circaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.circaToolStripMenuItem.Text = "Об игре";
            this.circaToolStripMenuItem.Click += new System.EventHandler(this.circaToolStripMenuItem_Click);
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // зановоToolStripMenuItem
            // 
            this.зановоToolStripMenuItem.Name = "зановоToolStripMenuItem";
            this.зановоToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.зановоToolStripMenuItem.Text = "Заново";
            this.зановоToolStripMenuItem.Click += new System.EventHandler(this.зановоToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Супер Сапёр Венда";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denuoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sileoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediocrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зановоToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

