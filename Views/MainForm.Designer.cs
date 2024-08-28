namespace FrameShare
{
    partial class MainForm
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
            originalPicture = new PictureBox();
            processedPicture = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            captureButton = new Button();
            streamButton = new Button();
            captureSource = new TextBox();
            label2 = new Label();
            label1 = new Label();
            logBox = new RichTextBox();
            ipAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)processedPicture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // originalPicture
            // 
            originalPicture.Dock = DockStyle.Fill;
            originalPicture.Location = new Point(3, 3);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(858, 480);
            originalPicture.TabIndex = 0;
            originalPicture.TabStop = false;
            // 
            // processedPicture
            // 
            processedPicture.Dock = DockStyle.Fill;
            processedPicture.Location = new Point(867, 3);
            processedPicture.Name = "processedPicture";
            processedPicture.Size = new Size(859, 480);
            processedPicture.TabIndex = 1;
            processedPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel1.Size = new Size(1735, 800);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(originalPicture, 0, 0);
            tableLayoutPanel2.Controls.Add(processedPicture, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1729, 486);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(captureButton);
            panel1.Controls.Add(streamButton);
            panel1.Controls.Add(captureSource);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logBox);
            panel1.Controls.Add(ipAddress);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(1729, 302);
            panel1.TabIndex = 4;
            // 
            // captureButton
            // 
            captureButton.Location = new Point(430, 236);
            captureButton.Name = "captureButton";
            captureButton.Size = new Size(321, 46);
            captureButton.TabIndex = 6;
            captureButton.UseVisualStyleBackColor = true;
            // 
            // streamButton
            // 
            streamButton.Location = new Point(430, 176);
            streamButton.Name = "streamButton";
            streamButton.Size = new Size(321, 46);
            streamButton.TabIndex = 5;
            streamButton.UseVisualStyleBackColor = true;
            // 
            // captureSource
            // 
            captureSource.Location = new Point(174, 236);
            captureSource.Name = "captureSource";
            captureSource.Size = new Size(200, 39);
            captureSource.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 237);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 3;
            label2.Text = "Capture From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 179);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 2;
            label1.Text = "Multicast IP:";
            // 
            // logBox
            // 
            logBox.Location = new Point(1106, 25);
            logBox.Name = "logBox";
            logBox.Size = new Size(604, 250);
            logBox.TabIndex = 1;
            logBox.Text = "";
            // 
            // ipAddress
            // 
            ipAddress.Location = new Point(174, 176);
            ipAddress.Name = "ipAddress";
            ipAddress.Size = new Size(200, 39);
            ipAddress.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 800);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Frame Share";
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)processedPicture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox originalPicture;
        private PictureBox processedPicture;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private RichTextBox logBox;
        private TextBox ipAddress;
        private TextBox captureSource;
        private Label label2;
        private Button streamButton;
        private Button captureButton;
    }
}
