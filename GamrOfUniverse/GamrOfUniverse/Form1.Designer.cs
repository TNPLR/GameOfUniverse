namespace GamrOfUniverse
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartGame = new System.Windows.Forms.Button();
            this.QuitGame = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.CheckMouseHover = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartGame.Location = new System.Drawing.Point(117, 26);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(388, 114);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // QuitGame
            // 
            this.QuitGame.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.QuitGame.Location = new System.Drawing.Point(117, 161);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(388, 114);
            this.QuitGame.TabIndex = 1;
            this.QuitGame.Text = "Quit Game";
            this.QuitGame.UseVisualStyleBackColor = true;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Copyright.ForeColor = System.Drawing.SystemColors.Menu;
            this.Copyright.Location = new System.Drawing.Point(1146, 646);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(106, 27);
            this.Copyright.TabIndex = 2;
            this.Copyright.Text = "GNU v3.0";
            // 
            // CheckMouseHover
            // 
            this.CheckMouseHover.Interval = 3000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GamrOfUniverse.Properties.Resources.VoyagerEarthGameStart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.QuitGame);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = "Game of Universe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button QuitGame;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Timer CheckMouseHover;
    }
}

