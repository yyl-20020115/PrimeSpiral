namespace PrimeSpiral
{
    partial class FormMain
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
            pictureBox = new PictureBox();
            buttonGenerate = new Button();
            panelScroll = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelScroll.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Yellow;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(888, 554);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGenerate.Location = new Point(910, 537);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // panelScroll
            // 
            panelScroll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelScroll.AutoScroll = true;
            panelScroll.BorderStyle = BorderStyle.Fixed3D;
            panelScroll.Controls.Add(pictureBox);
            panelScroll.Location = new Point(12, 12);
            panelScroll.Name = "panelScroll";
            panelScroll.Size = new Size(892, 558);
            panelScroll.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 582);
            Controls.Add(panelScroll);
            Controls.Add(buttonGenerate);
            Name = "FormMain";
            Text = "Prime Spiral";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelScroll.ResumeLayout(false);
            panelScroll.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonGenerate;
        private Panel panelScroll;
    }
}
