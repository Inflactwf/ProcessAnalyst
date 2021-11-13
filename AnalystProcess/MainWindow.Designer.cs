namespace AnalystProcess
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StartBtn = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.CheckDisk = new System.Windows.Forms.Button();
            this.DrivesList = new System.Windows.Forms.ComboBox();
            this.FirstWorker = new System.ComponentModel.BackgroundWorker();
            this.FirstProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.StartBtn.ForeColor = System.Drawing.Color.Black;
            this.StartBtn.Location = new System.Drawing.Point(289, 205);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 47);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.TabStop = false;
            this.StartBtn.Text = "Начать";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // LogBox
            // 
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogBox.Location = new System.Drawing.Point(12, 12);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(376, 191);
            this.LogBox.TabIndex = 0;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "";
            // 
            // CheckDisk
            // 
            this.CheckDisk.BackColor = System.Drawing.SystemColors.Control;
            this.CheckDisk.Enabled = false;
            this.CheckDisk.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.CheckDisk.ForeColor = System.Drawing.Color.Black;
            this.CheckDisk.Location = new System.Drawing.Point(103, 205);
            this.CheckDisk.Name = "CheckDisk";
            this.CheckDisk.Size = new System.Drawing.Size(82, 23);
            this.CheckDisk.TabIndex = 2;
            this.CheckDisk.TabStop = false;
            this.CheckDisk.Text = "Проверить";
            this.CheckDisk.UseVisualStyleBackColor = false;
            this.CheckDisk.Click += new System.EventHandler(this.CheckDisk_Click);
            // 
            // DrivesList
            // 
            this.DrivesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrivesList.Enabled = false;
            this.DrivesList.FormattingEnabled = true;
            this.DrivesList.Location = new System.Drawing.Point(12, 206);
            this.DrivesList.Name = "DrivesList";
            this.DrivesList.Size = new System.Drawing.Size(82, 21);
            this.DrivesList.TabIndex = 3;
            // 
            // FirstWorker
            // 
            this.FirstWorker.WorkerReportsProgress = true;
            this.FirstWorker.WorkerSupportsCancellation = true;
            this.FirstWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FirstWorker_DoWork);
            this.FirstWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FirstWorker_RunWorkerCompleted);
            // 
            // FirstProgress
            // 
            this.FirstProgress.Location = new System.Drawing.Point(12, 229);
            this.FirstProgress.MarqueeAnimationSpeed = 0;
            this.FirstProgress.Name = "FirstProgress";
            this.FirstProgress.Size = new System.Drawing.Size(172, 23);
            this.FirstProgress.Step = 4;
            this.FirstProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.FirstProgress.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.FirstProgress);
            this.Controls.Add(this.DrivesList);
            this.Controls.Add(this.CheckDisk);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Analyst";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button CheckDisk;
        private System.Windows.Forms.ComboBox DrivesList;
        private System.ComponentModel.BackgroundWorker FirstWorker;
        private System.Windows.Forms.ProgressBar FirstProgress;
    }
}

