namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.link_input = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.paste_button = new System.Windows.Forms.Button();
            this.path_input = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.state_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resolution_group = new System.Windows.Forms.GroupBox();
            this.res_360p = new System.Windows.Forms.RadioButton();
            this.res_720p = new System.Windows.Forms.RadioButton();
            this.res_480p = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ext_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_mp4 = new System.Windows.Forms.RadioButton();
            this.check_mp3 = new System.Windows.Forms.RadioButton();
            this.progress_panel = new System.Windows.Forms.Panel();
            this.resolution_group.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ext_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.progress_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(489, 34);
            this.progressBar.TabIndex = 1;
            // 
            // link_input
            // 
            this.link_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_input.Location = new System.Drawing.Point(59, 49);
            this.link_input.Name = "link_input";
            this.link_input.Size = new System.Drawing.Size(345, 33);
            this.link_input.TabIndex = 2;
            // 
            // start_button
            // 
            this.start_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(360, 20);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(150, 53);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Download";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // paste_button
            // 
            this.paste_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paste_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paste_button.Location = new System.Drawing.Point(410, 49);
            this.paste_button.Name = "paste_button";
            this.paste_button.Size = new System.Drawing.Size(100, 34);
            this.paste_button.TabIndex = 4;
            this.paste_button.Text = "Paste";
            this.paste_button.UseVisualStyleBackColor = true;
            this.paste_button.Click += new System.EventHandler(this.paste_button_Click);
            // 
            // path_input
            // 
            this.path_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path_input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.path_input.Location = new System.Drawing.Point(59, 9);
            this.path_input.Name = "path_input";
            this.path_input.Size = new System.Drawing.Size(345, 33);
            this.path_input.TabIndex = 5;
            // 
            // browse_button
            // 
            this.browse_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_button.Location = new System.Drawing.Point(410, 9);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(100, 33);
            this.browse_button.TabIndex = 6;
            this.browse_button.Text = "Browse...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state_label.Location = new System.Drawing.Point(8, 11);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(251, 25);
            this.state_label.TabIndex = 9;
            this.state_label.Text = "Paste url link and download!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path";
            // 
            // resolution_group
            // 
            this.resolution_group.Controls.Add(this.res_360p);
            this.resolution_group.Controls.Add(this.res_720p);
            this.resolution_group.Controls.Add(this.res_480p);
            this.resolution_group.Dock = System.Windows.Forms.DockStyle.Top;
            this.resolution_group.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resolution_group.Location = new System.Drawing.Point(0, 177);
            this.resolution_group.Name = "resolution_group";
            this.resolution_group.Size = new System.Drawing.Size(534, 80);
            this.resolution_group.TabIndex = 15;
            this.resolution_group.TabStop = false;
            this.resolution_group.Text = "Resolution";
            // 
            // res_360p
            // 
            this.res_360p.Appearance = System.Windows.Forms.Appearance.Button;
            this.res_360p.AutoSize = true;
            this.res_360p.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res_360p.Location = new System.Drawing.Point(168, 34);
            this.res_360p.Name = "res_360p";
            this.res_360p.Size = new System.Drawing.Size(63, 35);
            this.res_360p.TabIndex = 16;
            this.res_360p.TabStop = true;
            this.res_360p.Text = "360p";
            this.res_360p.UseVisualStyleBackColor = true;
            // 
            // res_720p
            // 
            this.res_720p.Appearance = System.Windows.Forms.Appearance.Button;
            this.res_720p.AutoSize = true;
            this.res_720p.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res_720p.Location = new System.Drawing.Point(30, 34);
            this.res_720p.Name = "res_720p";
            this.res_720p.Size = new System.Drawing.Size(63, 35);
            this.res_720p.TabIndex = 17;
            this.res_720p.TabStop = true;
            this.res_720p.Text = "720p";
            this.res_720p.UseVisualStyleBackColor = true;
            // 
            // res_480p
            // 
            this.res_480p.Appearance = System.Windows.Forms.Appearance.Button;
            this.res_480p.AutoSize = true;
            this.res_480p.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res_480p.Location = new System.Drawing.Point(99, 34);
            this.res_480p.Name = "res_480p";
            this.res_480p.Size = new System.Drawing.Size(63, 35);
            this.res_480p.TabIndex = 18;
            this.res_480p.TabStop = true;
            this.res_480p.Text = "480p";
            this.res_480p.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.paste_button);
            this.panel1.Controls.Add(this.path_input);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.browse_button);
            this.panel1.Controls.Add(this.link_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 95);
            this.panel1.TabIndex = 16;
            // 
            // ext_panel
            // 
            this.ext_panel.Controls.Add(this.groupBox1);
            this.ext_panel.Controls.Add(this.start_button);
            this.ext_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ext_panel.Location = new System.Drawing.Point(0, 95);
            this.ext_panel.Name = "ext_panel";
            this.ext_panel.Size = new System.Drawing.Size(534, 82);
            this.ext_panel.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_mp4);
            this.groupBox1.Controls.Add(this.check_mp3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extension";
            // 
            // check_mp4
            // 
            this.check_mp4.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_mp4.AutoSize = true;
            this.check_mp4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_mp4.Location = new System.Drawing.Point(30, 32);
            this.check_mp4.Name = "check_mp4";
            this.check_mp4.Size = new System.Drawing.Size(59, 35);
            this.check_mp4.TabIndex = 19;
            this.check_mp4.Text = "mp4";
            this.check_mp4.UseVisualStyleBackColor = true;
            this.check_mp4.CheckedChanged += new System.EventHandler(this.check_mp4_CheckedChanged_1);
            // 
            // check_mp3
            // 
            this.check_mp3.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_mp3.AutoSize = true;
            this.check_mp3.Checked = true;
            this.check_mp3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_mp3.Location = new System.Drawing.Point(99, 32);
            this.check_mp3.Name = "check_mp3";
            this.check_mp3.Size = new System.Drawing.Size(59, 35);
            this.check_mp3.TabIndex = 20;
            this.check_mp3.TabStop = true;
            this.check_mp3.Text = "mp3";
            this.check_mp3.UseVisualStyleBackColor = true;
            // 
            // progress_panel
            // 
            this.progress_panel.Controls.Add(this.state_label);
            this.progress_panel.Controls.Add(this.progressBar);
            this.progress_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress_panel.Location = new System.Drawing.Point(0, 257);
            this.progress_panel.Name = "progress_panel";
            this.progress_panel.Size = new System.Drawing.Size(534, 77);
            this.progress_panel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.progress_panel);
            this.Controls.Add(this.resolution_group);
            this.Controls.Add(this.ext_panel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(450, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.resolution_group.ResumeLayout(false);
            this.resolution_group.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ext_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.progress_panel.ResumeLayout(false);
            this.progress_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar progressBar;
        private TextBox link_input;
        private Button start_button;
        private Button paste_button;
        private TextBox path_input;
        private Button browse_button;
        private Label state_label;
        private Label label1;
        private Label label2;
        private GroupBox resolution_group;
        private RadioButton res_360p;
        private RadioButton res_720p;
        private RadioButton res_480p;
        private Panel panel1;
        private Panel ext_panel;
        private Panel progress_panel;
        private GroupBox groupBox1;
        private RadioButton check_mp4;
        private RadioButton check_mp3;
    }
}