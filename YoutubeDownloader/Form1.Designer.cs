using PaintedControls;
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
            state_label = new Label();
            progressBar = new PaintedProgressBar();
            customPanel1 = new CustomPanel();
            label4 = new Label();
            link_input = new CustomTextBox();
            path_input = new CustomTextBox();
            paste_button = new CustomButton();
            browse_button = new CustomButton();
            label3 = new Label();
            ext_panel = new CustomPanel();
            check_mp3 = new CustomCheckBox();
            check_mp4 = new CustomCheckBox();
            label1 = new Label();
            start_button = new CustomButton();
            resolution_group = new CustomPanel();
            check_360 = new CustomCheckBox();
            check_480 = new CustomCheckBox();
            check_720 = new CustomCheckBox();
            label2 = new Label();
            progress_panel = new CustomPanel();
            customPanel1.SuspendLayout();
            ext_panel.SuspendLayout();
            resolution_group.SuspendLayout();
            progress_panel.SuspendLayout();
            SuspendLayout();
            // 
            // state_label
            // 
            state_label.AutoSize = true;
            state_label.BackColor = Color.Black;
            state_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            state_label.ForeColor = Color.White;
            state_label.Location = new Point(30, 9);
            state_label.Name = "state_label";
            state_label.Size = new Size(250, 25);
            state_label.TabIndex = 9;
            state_label.Text = "Paste url link and download!";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(255, 192, 255);
            progressBar.Location = new Point(23, 43);
            progressBar.Name = "progressBar";
            progressBar.Percent = 10F;
            progressBar.ProgressMainColor = Color.Cyan;
            progressBar.ProgressSubColor = Color.Blue;
            progressBar.Size = new Size(480, 28);
            progressBar.TabIndex = 10;
            progressBar.Text = "paintedProgressBar1";
            // 
            // customPanel1
            // 
            customPanel1.BackColors.CurrentState = 0;
            customPanel1.BackColors.DefaultColor = Color.Black;
            customPanel1.BackColors.HoverColor = Color.Black;
            customPanel1.BackColors.PressColor = Color.Black;
            customPanel1.BorderWidth = 2;
            customPanel1.ClientHeight = 98;
            customPanel1.ClientWidth = 518;
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(paste_button);
            customPanel1.Controls.Add(browse_button);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(link_input);
            customPanel1.Controls.Add(path_input);
            customPanel1.CurrentState = 0;
            customPanel1.Dock = DockStyle.Top;
            customPanel1.ForeColors.CurrentState = 0;
            customPanel1.ForeColors.DefaultColor = Color.FromArgb(255, 192, 255);
            customPanel1.ForeColors.HoverColor = Color.FromArgb(255, 192, 255);
            customPanel1.ForeColors.PressColor = Color.Yellow;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            // 
            // 
            // 
            customPanel1.Panel.BackColor = Color.Black;
            customPanel1.Panel.Location = new Point(2, 2);
            customPanel1.Panel.Name = "";
            customPanel1.Panel.Size = new Size(518, 98);
            customPanel1.Panel.TabIndex = 0;
            customPanel1.Size = new Size(522, 102);
            customPanel1.TabIndex = 19;
            customPanel1.Text = "customPanel1";
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(49, 30);
            label4.TabIndex = 13;
            label4.Text = "Path";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // link_input
            // 
            link_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            link_input.BackColors.CurrentState = 0;
            link_input.BackColors.DefaultColor = Color.Black;
            link_input.BackColors.HoverColor = Color.Black;
            link_input.BackColors.PressColor = Color.Black;
            link_input.BorderWidth = 2;
            link_input.ClientHeight = 26;
            link_input.ClientWidth = 306;
            link_input.CurrentState = 0;
            link_input.FontName = "Consolas";
            link_input.ForeColors.CurrentState = 0;
            link_input.ForeColors.DefaultColor = Color.White;
            link_input.ForeColors.HoverColor = Color.FromArgb(255, 192, 128);
            link_input.ForeColors.PressColor = Color.Yellow;
            link_input.Location = new Point(67, 54);
            link_input.MinimumSize = new Size(7, 7);
            link_input.Name = "link_input";
            link_input.Size = new Size(310, 30);
            link_input.TabIndex = 15;
            link_input.Text = " ";
            // 
            // path_input
            // 
            path_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            path_input.BackColors.CurrentState = 0;
            path_input.BackColors.DefaultColor = Color.Black;
            path_input.BackColors.HoverColor = Color.Black;
            path_input.BackColors.PressColor = Color.Black;
            path_input.BorderWidth = 2;
            path_input.ClientHeight = 26;
            path_input.ClientWidth = 306;
            path_input.CurrentState = 0;
            path_input.FontName = "Consolas";
            path_input.ForeColors.CurrentState = 0;
            path_input.ForeColors.DefaultColor = Color.White;
            path_input.ForeColors.HoverColor = Color.FromArgb(255, 192, 128);
            path_input.ForeColors.PressColor = Color.Yellow;
            path_input.Location = new Point(67, 12);
            path_input.MinimumSize = new Size(7, 7);
            path_input.Name = "path_input";
            path_input.Size = new Size(310, 30);
            path_input.TabIndex = 14;
            path_input.Text = " ";
            // 
            // paste_button
            // 
            paste_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            paste_button.BackColors.CurrentState = 0;
            paste_button.BackColors.DefaultColor = Color.Black;
            paste_button.BackColors.HoverColor = Color.Navy;
            paste_button.BackColors.PressColor = Color.FromArgb(192, 192, 255);
            paste_button.BorderWidth = 2;
            paste_button.ClientHeight = 26;
            paste_button.ClientWidth = 96;
            paste_button.CurrentState = 0;
            paste_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            paste_button.ForeColors.CurrentState = 0;
            paste_button.ForeColors.DefaultColor = Color.White;
            paste_button.ForeColors.HoverColor = Color.FromArgb(192, 255, 255);
            paste_button.ForeColors.PressColor = Color.Maroon;
            paste_button.Location = new Point(397, 54);
            paste_button.Name = "paste_button";
            paste_button.Size = new Size(100, 30);
            paste_button.TabIndex = 17;
            paste_button.Text = "Paste";
            paste_button.Click += paste_button_Click;
            // 
            // browse_button
            // 
            browse_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browse_button.BackColors.CurrentState = 0;
            browse_button.BackColors.DefaultColor = Color.Black;
            browse_button.BackColors.HoverColor = Color.Navy;
            browse_button.BackColors.PressColor = Color.FromArgb(192, 192, 255);
            browse_button.BorderWidth = 2;
            browse_button.ClientHeight = 26;
            browse_button.ClientWidth = 96;
            browse_button.CurrentState = 0;
            browse_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            browse_button.ForeColors.CurrentState = 0;
            browse_button.ForeColors.DefaultColor = Color.White;
            browse_button.ForeColors.HoverColor = Color.FromArgb(192, 255, 255);
            browse_button.ForeColors.PressColor = Color.Maroon;
            browse_button.Location = new Point(397, 12);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(100, 30);
            browse_button.TabIndex = 16;
            browse_button.Text = "Browse...";
            browse_button.Click += browse_button_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(49, 30);
            label3.TabIndex = 12;
            label3.Text = "Link";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ext_panel
            // 
            ext_panel.BackColors.CurrentState = 0;
            ext_panel.BackColors.DefaultColor = Color.Black;
            ext_panel.BackColors.HoverColor = Color.Black;
            ext_panel.BackColors.PressColor = Color.Black;
            ext_panel.BorderWidth = 2;
            ext_panel.ClientHeight = 98;
            ext_panel.ClientWidth = 518;
            ext_panel.Controls.Add(check_mp3);
            ext_panel.Controls.Add(check_mp4);
            ext_panel.Controls.Add(label1);
            ext_panel.Controls.Add(start_button);
            ext_panel.CurrentState = 0;
            ext_panel.Dock = DockStyle.Top;
            ext_panel.ForeColors.CurrentState = 0;
            ext_panel.ForeColors.DefaultColor = Color.FromArgb(255, 192, 255);
            ext_panel.ForeColors.HoverColor = Color.FromArgb(255, 192, 255);
            ext_panel.ForeColors.PressColor = Color.Yellow;
            ext_panel.Location = new Point(0, 102);
            ext_panel.Name = "ext_panel";
            // 
            // 
            // 
            ext_panel.Panel.BackColor = Color.Black;
            ext_panel.Panel.Location = new Point(2, 2);
            ext_panel.Panel.Name = "";
            ext_panel.Panel.Size = new Size(518, 98);
            ext_panel.Panel.TabIndex = 0;
            ext_panel.Size = new Size(522, 102);
            ext_panel.TabIndex = 20;
            ext_panel.Text = "customPanel2";
            // 
            // check_mp3
            // 
            check_mp3.BackColors.CheckColor = Color.Cyan;
            check_mp3.BackColors.CurrentState = 0;
            check_mp3.BackColors.DefaultColor = Color.Black;
            check_mp3.BackColors.HoverColor = Color.Navy;
            check_mp3.BackColors.PressColor = Color.Yellow;
            check_mp3.BorderWidth = 2;
            check_mp3.Checked = false;
            check_mp3.ClientHeight = 40;
            check_mp3.ClientWidth = 64;
            check_mp3.CurrentState = 0;
            check_mp3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_mp3.ForeColors.CheckColor = Color.Black;
            check_mp3.ForeColors.CurrentState = 0;
            check_mp3.ForeColors.DefaultColor = Color.White;
            check_mp3.ForeColors.HoverColor = Color.FromArgb(255, 255, 128);
            check_mp3.ForeColors.PressColor = Color.FromArgb(0, 0, 192);
            check_mp3.Location = new Point(109, 41);
            check_mp3.Name = "check_mp3";
            check_mp3.Size = new Size(68, 44);
            check_mp3.TabIndex = 20;
            check_mp3.Text = "mp3";
            check_mp3.Click += OnMPClick;
            // 
            // check_mp4
            // 
            check_mp4.BackColors.CheckColor = Color.Cyan;
            check_mp4.BackColors.CurrentState = 0;
            check_mp4.BackColors.DefaultColor = Color.Black;
            check_mp4.BackColors.HoverColor = Color.Navy;
            check_mp4.BackColors.PressColor = Color.Yellow;
            check_mp4.BorderWidth = 2;
            check_mp4.Checked = false;
            check_mp4.ClientHeight = 40;
            check_mp4.ClientWidth = 64;
            check_mp4.CurrentState = 0;
            check_mp4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_mp4.ForeColors.CheckColor = Color.Black;
            check_mp4.ForeColors.CurrentState = 0;
            check_mp4.ForeColors.DefaultColor = Color.White;
            check_mp4.ForeColors.HoverColor = Color.FromArgb(255, 255, 128);
            check_mp4.ForeColors.PressColor = Color.FromArgb(0, 0, 192);
            check_mp4.Location = new Point(30, 41);
            check_mp4.Name = "check_mp4";
            check_mp4.Size = new Size(68, 44);
            check_mp4.TabIndex = 19;
            check_mp4.Text = "mp4";
            check_mp4.Click += OnMPClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 2);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 18;
            label1.Text = "Extension";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start_button
            // 
            start_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            start_button.BackColors.CurrentState = 0;
            start_button.BackColors.DefaultColor = Color.Black;
            start_button.BackColors.HoverColor = Color.Black;
            start_button.BackColors.PressColor = Color.FromArgb(128, 255, 255);
            start_button.BorderWidth = 2;
            start_button.ClientHeight = 55;
            start_button.ClientWidth = 195;
            start_button.CurrentState = 0;
            start_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            start_button.ForeColors.CurrentState = 0;
            start_button.ForeColors.DefaultColor = Color.White;
            start_button.ForeColors.HoverColor = Color.Yellow;
            start_button.ForeColors.PressColor = Color.Red;
            start_button.Location = new Point(298, 26);
            start_button.Name = "start_button";
            start_button.Size = new Size(199, 59);
            start_button.TabIndex = 21;
            start_button.Text = "Download";
            start_button.Click += start_button_Click;
            // 
            // resolution_group
            // 
            resolution_group.BackColors.CurrentState = 0;
            resolution_group.BackColors.DefaultColor = Color.Black;
            resolution_group.BackColors.HoverColor = Color.Black;
            resolution_group.BackColors.PressColor = Color.Black;
            resolution_group.BorderWidth = 2;
            resolution_group.ClientHeight = 98;
            resolution_group.ClientWidth = 518;
            resolution_group.Controls.Add(check_360);
            resolution_group.Controls.Add(check_480);
            resolution_group.Controls.Add(check_720);
            resolution_group.Controls.Add(label2);
            resolution_group.CurrentState = 0;
            resolution_group.Dock = DockStyle.Top;
            resolution_group.ForeColors.CurrentState = 0;
            resolution_group.ForeColors.DefaultColor = Color.FromArgb(255, 192, 255);
            resolution_group.ForeColors.HoverColor = Color.FromArgb(255, 192, 255);
            resolution_group.ForeColors.PressColor = Color.Yellow;
            resolution_group.Location = new Point(0, 204);
            resolution_group.Name = "resolution_group";
            // 
            // 
            // 
            resolution_group.Panel.BackColor = Color.Black;
            resolution_group.Panel.Location = new Point(2, 2);
            resolution_group.Panel.Name = "";
            resolution_group.Panel.Size = new Size(518, 98);
            resolution_group.Panel.TabIndex = 0;
            resolution_group.Size = new Size(522, 102);
            resolution_group.TabIndex = 21;
            resolution_group.Text = "customPanel2";
            // 
            // check_360
            // 
            check_360.BackColors.CheckColor = Color.Cyan;
            check_360.BackColors.CurrentState = 0;
            check_360.BackColors.DefaultColor = Color.Black;
            check_360.BackColors.HoverColor = Color.Navy;
            check_360.BackColors.PressColor = Color.Yellow;
            check_360.BorderWidth = 2;
            check_360.Checked = false;
            check_360.ClientHeight = 40;
            check_360.ClientWidth = 64;
            check_360.CurrentState = 0;
            check_360.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_360.ForeColors.CheckColor = Color.Black;
            check_360.ForeColors.CurrentState = 0;
            check_360.ForeColors.DefaultColor = Color.White;
            check_360.ForeColors.HoverColor = Color.FromArgb(255, 255, 128);
            check_360.ForeColors.PressColor = Color.FromArgb(0, 0, 192);
            check_360.Location = new Point(190, 42);
            check_360.Name = "check_360";
            check_360.Size = new Size(68, 44);
            check_360.TabIndex = 24;
            check_360.Text = "360p";
            check_360.Click += OnResClick;
            check_360.DoubleClick += OnResClick;
            // 
            // check_480
            // 
            check_480.BackColors.CheckColor = Color.Cyan;
            check_480.BackColors.CurrentState = 0;
            check_480.BackColors.DefaultColor = Color.Black;
            check_480.BackColors.HoverColor = Color.Navy;
            check_480.BackColors.PressColor = Color.Yellow;
            check_480.BorderWidth = 2;
            check_480.Checked = false;
            check_480.ClientHeight = 40;
            check_480.ClientWidth = 64;
            check_480.CurrentState = 0;
            check_480.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_480.ForeColors.CheckColor = Color.Black;
            check_480.ForeColors.CurrentState = 0;
            check_480.ForeColors.DefaultColor = Color.White;
            check_480.ForeColors.HoverColor = Color.FromArgb(255, 255, 128);
            check_480.ForeColors.PressColor = Color.FromArgb(0, 0, 192);
            check_480.Location = new Point(109, 42);
            check_480.Name = "check_480";
            check_480.Size = new Size(68, 44);
            check_480.TabIndex = 23;
            check_480.Text = "480p";
            check_480.Click += OnResClick;
            check_480.DoubleClick += OnResClick;
            // 
            // check_720
            // 
            check_720.BackColors.CheckColor = Color.Cyan;
            check_720.BackColors.CurrentState = 0;
            check_720.BackColors.DefaultColor = Color.Black;
            check_720.BackColors.HoverColor = Color.Navy;
            check_720.BackColors.PressColor = Color.Yellow;
            check_720.BorderWidth = 2;
            check_720.Checked = false;
            check_720.ClientHeight = 40;
            check_720.ClientWidth = 64;
            check_720.CurrentState = 0;
            check_720.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_720.ForeColors.CheckColor = Color.Black;
            check_720.ForeColors.CurrentState = 0;
            check_720.ForeColors.DefaultColor = Color.White;
            check_720.ForeColors.HoverColor = Color.FromArgb(255, 255, 128);
            check_720.ForeColors.PressColor = Color.FromArgb(0, 0, 192);
            check_720.Location = new Point(30, 42);
            check_720.Name = "check_720";
            check_720.Size = new Size(68, 44);
            check_720.TabIndex = 22;
            check_720.Text = "720p";
            check_720.Click += OnResClick;
            check_720.DoubleClick += OnResClick;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 3);
            label2.Name = "label2";
            label2.Size = new Size(147, 36);
            label2.TabIndex = 21;
            label2.Text = "Resolution";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progress_panel
            // 
            progress_panel.BackColors.CurrentState = 0;
            progress_panel.BackColors.DefaultColor = Color.Black;
            progress_panel.BackColors.HoverColor = Color.Black;
            progress_panel.BackColors.PressColor = Color.Black;
            progress_panel.BorderWidth = 2;
            progress_panel.ClientHeight = 90;
            progress_panel.ClientWidth = 518;
            progress_panel.Controls.Add(progressBar);
            progress_panel.Controls.Add(state_label);
            progress_panel.CurrentState = 0;
            progress_panel.Dock = DockStyle.Fill;
            progress_panel.ForeColors.CurrentState = 0;
            progress_panel.ForeColors.DefaultColor = Color.FromArgb(255, 192, 255);
            progress_panel.ForeColors.HoverColor = Color.FromArgb(255, 192, 255);
            progress_panel.ForeColors.PressColor = Color.Yellow;
            progress_panel.Location = new Point(0, 306);
            progress_panel.Name = "progress_panel";
            // 
            // 
            // 
            progress_panel.Panel.BackColor = Color.Black;
            progress_panel.Panel.Location = new Point(2, 2);
            progress_panel.Panel.Name = "";
            progress_panel.Panel.Size = new Size(518, 90);
            progress_panel.Panel.TabIndex = 0;
            progress_panel.Size = new Size(522, 94);
            progress_panel.TabIndex = 22;
            progress_panel.Text = "customPanel2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 400);
            Controls.Add(progress_panel);
            Controls.Add(resolution_group);
            Controls.Add(ext_panel);
            Controls.Add(customPanel1);
            MinimumSize = new Size(450, 0);
            Name = "Form1";
            Text = "Form1";
            customPanel1.ResumeLayout(false);
            ext_panel.ResumeLayout(false);
            resolution_group.ResumeLayout(false);
            progress_panel.ResumeLayout(false);
            progress_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomTextBox link_input;
        private CustomButton paste_button;
        private CustomTextBox path_input;
        private CustomButton browse_button;
        private CustomCheckBox check_mp3;
        private CustomCheckBox check_mp4;
        private CustomPanel ext_panel;
        private Label state_label;
        private Label label1;
        private CustomPanel resolution_group;
        private Panel panel1;
        private PaintedProgressBar progressBar;
        private CustomPanel customPanel1;
        private Label label3;
        private Label label4;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox1;
        private CustomButton start_button;
        private CustomPanel customPanel2;
        private Label label2;
        private CustomCheckBox check_480;
        private CustomCheckBox check_360;
        private CustomCheckBox check_720;
        private CustomButton customButton1;
        private CustomPanel progress_panel;
    }
}