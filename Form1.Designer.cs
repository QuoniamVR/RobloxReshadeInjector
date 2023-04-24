namespace ReshadeCraft
{
    partial class ReshadeCraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReshadeCraft));
            this.Title = new System.Windows.Forms.Label();
            this.INJECT = new System.Windows.Forms.Button();
            this.PROGRESS = new System.Windows.Forms.Label();
            this.InjectionProgress = new System.Windows.Forms.ProgressBar();
            this.githubsource = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(768, 88);
            this.Title.TabIndex = 0;
            this.Title.Text = "Roblox Reshade Injector";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // INJECT
            // 
            this.INJECT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.INJECT.Cursor = System.Windows.Forms.Cursors.Default;
            this.INJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INJECT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.INJECT.Location = new System.Drawing.Point(12, 117);
            this.INJECT.Name = "INJECT";
            this.INJECT.Size = new System.Drawing.Size(172, 38);
            this.INJECT.TabIndex = 2;
            this.INJECT.Text = "Inject";
            this.INJECT.UseVisualStyleBackColor = false;
            this.INJECT.Click += new System.EventHandler(this.button1_Click);
            // 
            // PROGRESS
            // 
            this.PROGRESS.AutoSize = true;
            this.PROGRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROGRESS.ForeColor = System.Drawing.SystemColors.Control;
            this.PROGRESS.Location = new System.Drawing.Point(192, 124);
            this.PROGRESS.Name = "PROGRESS";
            this.PROGRESS.Size = new System.Drawing.Size(170, 25);
            this.PROGRESS.TabIndex = 3;
            this.PROGRESS.Text = "NOT INJECTED!";
            this.PROGRESS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PROGRESS.Click += new System.EventHandler(this.PROGRESS_Click);
            // 
            // InjectionProgress
            // 
            this.InjectionProgress.Location = new System.Drawing.Point(13, 415);
            this.InjectionProgress.Name = "InjectionProgress";
            this.InjectionProgress.Size = new System.Drawing.Size(775, 23);
            this.InjectionProgress.TabIndex = 5;
            // 
            // githubsource
            // 
            this.githubsource.Location = new System.Drawing.Point(372, 117);
            this.githubsource.MinimumSize = new System.Drawing.Size(20, 20);
            this.githubsource.Name = "githubsource";
            this.githubsource.Size = new System.Drawing.Size(415, 292);
            this.githubsource.TabIndex = 6;
            this.githubsource.Url = new System.Uri("http://nullinteractive.com/", System.UriKind.Absolute);
            // 
            // ReshadeCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.githubsource);
            this.Controls.Add(this.InjectionProgress);
            this.Controls.Add(this.PROGRESS);
            this.Controls.Add(this.INJECT);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReshadeCraft";
            this.Text = "Roblox Reshade Injector";
            this.Load += new System.EventHandler(this.ReshadeCraft_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button INJECT;
        private System.Windows.Forms.Label PROGRESS;
        private System.Windows.Forms.ProgressBar InjectionProgress;
        private System.Windows.Forms.WebBrowser githubsource;
    }
}

