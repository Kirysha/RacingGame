namespace RacingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameStart = new System.Windows.Forms.Panel();
            this.textGameOver = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.Score_point = new System.Windows.Forms.Label();
            this.GameStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameStart
            // 
            this.GameStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameStart.BackgroundImage")));
            this.GameStart.Controls.Add(this.textGameOver);
            this.GameStart.Controls.Add(this.PlayButton);
            this.GameStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameStart.Location = new System.Drawing.Point(0, 0);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(651, 753);
            this.GameStart.TabIndex = 1;
            // 
            // textGameOver
            // 
            this.textGameOver.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGameOver.ForeColor = System.Drawing.Color.Red;
            this.textGameOver.Location = new System.Drawing.Point(201, 247);
            this.textGameOver.Name = "textGameOver";
            this.textGameOver.Size = new System.Drawing.Size(267, 74);
            this.textGameOver.TabIndex = 1;
            this.textGameOver.Text = "Game Over";
            this.textGameOver.Visible = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Location = new System.Drawing.Point(225, 349);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(202, 198);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayButton_Paint);
            // 
            // road
            // 
            this.road.Dock = System.Windows.Forms.DockStyle.Fill;
            this.road.Location = new System.Drawing.Point(0, 0);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(651, 753);
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            this.road.Paint += new System.Windows.Forms.PaintEventHandler(this.road1_Paint);
            // 
            // Score_point
            // 
            this.Score_point.AutoSize = true;
            this.Score_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_point.Location = new System.Drawing.Point(586, 9);
            this.Score_point.Name = "Score_point";
            this.Score_point.Size = new System.Drawing.Size(0, 20);
            this.Score_point.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 753);
            this.Controls.Add(this.Score_point);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.road);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(669, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.GameStart.ResumeLayout(false);
            this.GameStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel GameStart;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.TextBox textGameOver;
        private System.Windows.Forms.Label Score_point;
    }
}

