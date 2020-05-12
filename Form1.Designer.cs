namespace ConverorImageToHexForOled
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z128x32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z128x64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z240x64ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.z240x128ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomXyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.H16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.H10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.H2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типСканераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckan1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckan2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияРисункаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.размерToolStripMenuItem,
            this.типДанныхToolStripMenuItem,
            this.типСканераToolStripMenuItem,
            this.инверсияРисункаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.copyТекстToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openToolStripMenuItem.Text = "открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveToolStripMenuItem.Text = "сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // copyТекстToolStripMenuItem
            // 
            this.copyТекстToolStripMenuItem.Name = "copyТекстToolStripMenuItem";
            this.copyТекстToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyТекстToolStripMenuItem.Text = "скопировать текст";
            this.copyТекстToolStripMenuItem.Click += new System.EventHandler(this.copyТекстToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.z128x32ToolStripMenuItem,
            this.z128x64ToolStripMenuItem,
            this.z240x64ToolStripMenuItem1,
            this.z240x128ToolStripMenuItem,
            this.zoomXyToolStripMenuItem});
            this.размерToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.размерToolStripMenuItem.Text = " размер ";
            this.размерToolStripMenuItem.ToolTipText = "Размер экрана. ";
            // 
            // z128x32ToolStripMenuItem
            // 
            this.z128x32ToolStripMenuItem.Name = "z128x32ToolStripMenuItem";
            this.z128x32ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.z128x32ToolStripMenuItem.Text = "128x32";
            this.z128x32ToolStripMenuItem.Click += new System.EventHandler(this.z128x32ToolStripMenuItem_Click);
            // 
            // z128x64ToolStripMenuItem
            // 
            this.z128x64ToolStripMenuItem.Name = "z128x64ToolStripMenuItem";
            this.z128x64ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.z128x64ToolStripMenuItem.Text = "128x64";
            this.z128x64ToolStripMenuItem.Click += new System.EventHandler(this.z128x64ToolStripMenuItem_Click);
            // 
            // z240x64ToolStripMenuItem1
            // 
            this.z240x64ToolStripMenuItem1.Name = "z240x64ToolStripMenuItem1";
            this.z240x64ToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.z240x64ToolStripMenuItem1.Text = "240x64";
            this.z240x64ToolStripMenuItem1.Click += new System.EventHandler(this.z240x64ToolStripMenuItem1_Click);
            // 
            // z240x128ToolStripMenuItem
            // 
            this.z240x128ToolStripMenuItem.Name = "z240x128ToolStripMenuItem";
            this.z240x128ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.z240x128ToolStripMenuItem.Text = "240x128";
            this.z240x128ToolStripMenuItem.Click += new System.EventHandler(this.z240x128ToolStripMenuItem_Click);
            // 
            // zoomXyToolStripMenuItem
            // 
            this.zoomXyToolStripMenuItem.Name = "zoomXyToolStripMenuItem";
            this.zoomXyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zoomXyToolStripMenuItem.Text = "произвольный";
            this.zoomXyToolStripMenuItem.Click += new System.EventHandler(this.zoomXyToolStripMenuItem_Click);
            // 
            // типДанныхToolStripMenuItem
            // 
            this.типДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.H16ToolStripMenuItem,
            this.H10ToolStripMenuItem,
            this.H2ToolStripMenuItem});
            this.типДанныхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.типДанныхToolStripMenuItem.Name = "типДанныхToolStripMenuItem";
            this.типДанныхToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.типДанныхToolStripMenuItem.Text = "тип данных";
            // 
            // H16ToolStripMenuItem
            // 
            this.H16ToolStripMenuItem.Name = "H16ToolStripMenuItem";
            this.H16ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.H16ToolStripMenuItem.Text = "16-ричный";
            this.H16ToolStripMenuItem.Click += new System.EventHandler(this.H16ToolStripMenuItem_Click);
            // 
            // H10ToolStripMenuItem
            // 
            this.H10ToolStripMenuItem.Name = "H10ToolStripMenuItem";
            this.H10ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.H10ToolStripMenuItem.Text = "10-тичный";
            this.H10ToolStripMenuItem.Click += new System.EventHandler(this.H10ToolStripMenuItem_Click);
            // 
            // H2ToolStripMenuItem
            // 
            this.H2ToolStripMenuItem.Name = "H2ToolStripMenuItem";
            this.H2ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.H2ToolStripMenuItem.Text = "бинарный";
            this.H2ToolStripMenuItem.Click += new System.EventHandler(this.H2ToolStripMenuItem_Click);
            // 
            // типСканераToolStripMenuItem
            // 
            this.типСканераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ckan1ToolStripMenuItem,
            this.ckan2ToolStripMenuItem});
            this.типСканераToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.типСканераToolStripMenuItem.Name = "типСканераToolStripMenuItem";
            this.типСканераToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.типСканераToolStripMenuItem.Text = "тип сканера";
            // 
            // ckan1ToolStripMenuItem
            // 
            this.ckan1ToolStripMenuItem.Name = "ckan1ToolStripMenuItem";
            this.ckan1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ckan1ToolStripMenuItem.Text = "прямой";
            this.ckan1ToolStripMenuItem.Click += new System.EventHandler(this.ckan1ToolStripMenuItem_Click);
            // 
            // ckan2ToolStripMenuItem
            // 
            this.ckan2ToolStripMenuItem.Name = "ckan2ToolStripMenuItem";
            this.ckan2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ckan2ToolStripMenuItem.Text = "обратный";
            this.ckan2ToolStripMenuItem.Click += new System.EventHandler(this.ckan2ToolStripMenuItem_Click);
            // 
            // инверсияРисункаToolStripMenuItem
            // 
            this.инверсияРисункаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positiveToolStripMenuItem,
            this.negativeToolStripMenuItem});
            this.инверсияРисункаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инверсияРисункаToolStripMenuItem.Name = "инверсияРисункаToolStripMenuItem";
            this.инверсияРисункаToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.инверсияРисункаToolStripMenuItem.Text = "инверсия рисунка";
            // 
            // positiveToolStripMenuItem
            // 
            this.positiveToolStripMenuItem.Name = "positiveToolStripMenuItem";
            this.positiveToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.positiveToolStripMenuItem.Text = "позитив";
            this.positiveToolStripMenuItem.Click += new System.EventHandler(this.positiveToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.negativeToolStripMenuItem.Text = "негатив";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YouTubeToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.readToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "справка";
            // 
            // YouTubeToolStripMenuItem
            // 
            this.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem";
            this.YouTubeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.YouTubeToolStripMenuItem.Text = "видео ютуб";
            this.YouTubeToolStripMenuItem.Click += new System.EventHandler(this.YouTubeToolStripMenuItem_Click);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.linkToolStripMenuItem.Text = "https://www.drive2.ru/borzov161";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.readToolStripMenuItem.Text = "текст читать";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "zoom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(138, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(217, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(320, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 24);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 128);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(323, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 128);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 302);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(590, 500);
            this.Name = "Form1";
            this.Text = "Конвертор рисунка для AVR  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem z128x32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem z128x64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem z240x64ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem z240x128ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomXyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem H16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem H10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem H2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типСканераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ckan1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ckan2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияРисункаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YouTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem copyТекстToolStripMenuItem;
    }
}

