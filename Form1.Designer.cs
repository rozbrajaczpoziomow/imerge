namespace imerge
{
    partial class Form
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
            this.BgText = new System.Windows.Forms.TextBox();
            this.BgLabel = new System.Windows.Forms.Label();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.BaseText = new System.Windows.Forms.TextBox();
            this.OverlayLabel = new System.Windows.Forms.Label();
            this.OverlayText = new System.Windows.Forms.TextBox();
            this.ErrorCaption = new System.Windows.Forms.Label();
            this.MergeButton = new System.Windows.Forms.Button();
            this.BgButton = new System.Windows.Forms.Button();
            this.BaseButton = new System.Windows.Forms.Button();
            this.OverlayButton = new System.Windows.Forms.Button();
            this.PreviewCheckbox = new System.Windows.Forms.CheckBox();
            this.PreviewImage = new System.Windows.Forms.PictureBox();
            this.RerollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BgText
            // 
            this.BgText.AllowDrop = true;
            this.BgText.Location = new System.Drawing.Point(12, 27);
            this.BgText.Name = "BgText";
            this.BgText.Size = new System.Drawing.Size(300, 20);
            this.BgText.TabIndex = 0;
            // 
            // BgLabel
            // 
            this.BgLabel.AutoSize = true;
            this.BgLabel.Location = new System.Drawing.Point(12, 9);
            this.BgLabel.Name = "BgLabel";
            this.BgLabel.Size = new System.Drawing.Size(96, 13);
            this.BgLabel.TabIndex = 1;
            this.BgLabel.Text = "Background image";
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(12, 59);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(259, 13);
            this.BaseLabel.TabIndex = 2;
            this.BaseLabel.Text = "Base images (folder, images inside will be overridden!)";
            // 
            // BaseText
            // 
            this.BaseText.AllowDrop = true;
            this.BaseText.Location = new System.Drawing.Point(12, 75);
            this.BaseText.Name = "BaseText";
            this.BaseText.Size = new System.Drawing.Size(300, 20);
            this.BaseText.TabIndex = 3;
            // 
            // OverlayLabel
            // 
            this.OverlayLabel.AutoSize = true;
            this.OverlayLabel.Location = new System.Drawing.Point(12, 109);
            this.OverlayLabel.Name = "OverlayLabel";
            this.OverlayLabel.Size = new System.Drawing.Size(74, 13);
            this.OverlayLabel.TabIndex = 4;
            this.OverlayLabel.Text = "Overlay image";
            // 
            // OverlayText
            // 
            this.OverlayText.AllowDrop = true;
            this.OverlayText.Location = new System.Drawing.Point(12, 125);
            this.OverlayText.Name = "OverlayText";
            this.OverlayText.Size = new System.Drawing.Size(300, 20);
            this.OverlayText.TabIndex = 5;
            // 
            // ErrorCaption
            // 
            this.ErrorCaption.AutoSize = true;
            this.ErrorCaption.Location = new System.Drawing.Point(12, 160);
            this.ErrorCaption.Name = "ErrorCaption";
            this.ErrorCaption.Size = new System.Drawing.Size(0, 13);
            this.ErrorCaption.TabIndex = 6;
            // 
            // MergeButton
            // 
            this.MergeButton.BackColor = System.Drawing.Color.Black;
            this.MergeButton.Enabled = false;
            this.MergeButton.ForeColor = System.Drawing.Color.White;
            this.MergeButton.Location = new System.Drawing.Point(12, 197);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(75, 23);
            this.MergeButton.TabIndex = 7;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = false;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // BgButton
            // 
            this.BgButton.BackColor = System.Drawing.Color.Black;
            this.BgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BgButton.Location = new System.Drawing.Point(318, 27);
            this.BgButton.Name = "BgButton";
            this.BgButton.Size = new System.Drawing.Size(42, 20);
            this.BgButton.TabIndex = 8;
            this.BgButton.Text = "...";
            this.BgButton.UseVisualStyleBackColor = false;
            this.BgButton.Click += new System.EventHandler(this.BgButton_Click);
            // 
            // BaseButton
            // 
            this.BaseButton.BackColor = System.Drawing.Color.Black;
            this.BaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BaseButton.Location = new System.Drawing.Point(318, 75);
            this.BaseButton.Name = "BaseButton";
            this.BaseButton.Size = new System.Drawing.Size(42, 20);
            this.BaseButton.TabIndex = 9;
            this.BaseButton.Text = "...";
            this.BaseButton.UseVisualStyleBackColor = false;
            this.BaseButton.Click += new System.EventHandler(this.BaseButton_Click);
            // 
            // OverlayButton
            // 
            this.OverlayButton.BackColor = System.Drawing.Color.Black;
            this.OverlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OverlayButton.Location = new System.Drawing.Point(318, 124);
            this.OverlayButton.Name = "OverlayButton";
            this.OverlayButton.Size = new System.Drawing.Size(42, 20);
            this.OverlayButton.TabIndex = 10;
            this.OverlayButton.Text = "...";
            this.OverlayButton.UseVisualStyleBackColor = false;
            this.OverlayButton.Click += new System.EventHandler(this.OverlayButton_Click);
            // 
            // PreviewCheckbox
            // 
            this.PreviewCheckbox.AutoSize = true;
            this.PreviewCheckbox.Location = new System.Drawing.Point(305, 220);
            this.PreviewCheckbox.Name = "PreviewCheckbox";
            this.PreviewCheckbox.Size = new System.Drawing.Size(64, 17);
            this.PreviewCheckbox.TabIndex = 11;
            this.PreviewCheckbox.Text = "Preview";
            this.PreviewCheckbox.UseVisualStyleBackColor = true;
            this.PreviewCheckbox.CheckedChanged += new System.EventHandler(this.PreviewCheckbox_CheckedChanged);
            // 
            // PreviewImage
            // 
            this.PreviewImage.Location = new System.Drawing.Point(12, 226);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(256, 256);
            this.PreviewImage.TabIndex = 12;
            this.PreviewImage.TabStop = false;
            this.PreviewImage.Visible = false;
            // 
            // RerollButton
            // 
            this.RerollButton.BackColor = System.Drawing.Color.Black;
            this.RerollButton.Location = new System.Drawing.Point(276, 214);
            this.RerollButton.Name = "RerollButton";
            this.RerollButton.Size = new System.Drawing.Size(23, 23);
            this.RerollButton.TabIndex = 13;
            this.RerollButton.Text = "R";
            this.RerollButton.UseVisualStyleBackColor = false;
            this.RerollButton.Visible = false;
            this.RerollButton.Click += new System.EventHandler(this.RerollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "made by rozbrajaczpoziomow\r\nhttps://rozbrajacz.futbol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RerollButton);
            this.Controls.Add(this.PreviewImage);
            this.Controls.Add(this.PreviewCheckbox);
            this.Controls.Add(this.OverlayButton);
            this.Controls.Add(this.BaseButton);
            this.Controls.Add(this.BgButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.ErrorCaption);
            this.Controls.Add(this.OverlayText);
            this.Controls.Add(this.OverlayLabel);
            this.Controls.Add(this.BaseText);
            this.Controls.Add(this.BaseLabel);
            this.Controls.Add(this.BgLabel);
            this.Controls.Add(this.BgText);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "imerge";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BgText;
        private System.Windows.Forms.Label BgLabel;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.TextBox BaseText;
        private System.Windows.Forms.Label OverlayLabel;
        private System.Windows.Forms.TextBox OverlayText;
        private System.Windows.Forms.Label ErrorCaption;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Button BgButton;
        private System.Windows.Forms.Button BaseButton;
        private System.Windows.Forms.Button OverlayButton;
        private System.Windows.Forms.CheckBox PreviewCheckbox;
        private System.Windows.Forms.PictureBox PreviewImage;
        private System.Windows.Forms.Button RerollButton;
        private System.Windows.Forms.Label label1;
    }
}

