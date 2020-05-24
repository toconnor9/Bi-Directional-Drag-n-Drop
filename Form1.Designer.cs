namespace Bi_Directional_Drag_n_Drop
{
    partial class Form1
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
            this.lstFirst = new System.Windows.Forms.ListBox();
            this.lstSecond = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFirst
            // 
            this.lstFirst.AllowDrop = true;
            this.lstFirst.FormattingEnabled = true;
            this.lstFirst.ItemHeight = 20;
            this.lstFirst.Location = new System.Drawing.Point(20, 30);
            this.lstFirst.Name = "lstFirst";
            this.lstFirst.Size = new System.Drawing.Size(450, 224);
            this.lstFirst.TabIndex = 3;
            this.lstFirst.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFirst_DragDrop);
            this.lstFirst.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFirst_DragEnter);
            this.lstFirst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFirst_MouseDown);
            // 
            // lstSecond
            // 
            this.lstSecond.AllowDrop = true;
            this.lstSecond.FormattingEnabled = true;
            this.lstSecond.ItemHeight = 20;
            this.lstSecond.Location = new System.Drawing.Point(500, 30);
            this.lstSecond.Name = "lstSecond";
            this.lstSecond.Size = new System.Drawing.Size(450, 224);
            this.lstSecond.TabIndex = 4;
            this.lstSecond.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstSecond_DragDrop);
            this.lstSecond.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstSecond_DragEnter);
            this.lstSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstSecond_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 277);
            this.Controls.Add(this.lstSecond);
            this.Controls.Add(this.lstFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstFirst;
        private System.Windows.Forms.ListBox lstSecond;
    }
}

