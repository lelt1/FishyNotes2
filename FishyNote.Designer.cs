namespace Fishy_Notes
{
    partial class FishyNote
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
            this.WrittenNote = new System.Windows.Forms.RichTextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Collapse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WrittenNote
            // 
            this.WrittenNote.Location = new System.Drawing.Point(12, 98);
            this.WrittenNote.Name = "WrittenNote";
            this.WrittenNote.Size = new System.Drawing.Size(472, 332);
            this.WrittenNote.TabIndex = 0;
            this.WrittenNote.Text = "Insert note...";
            this.WrittenNote.TextChanged += new System.EventHandler(this.WrittenNote_TextChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(460, 37);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(24, 24);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "x";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Collapse
            // 
            this.Collapse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Collapse.Location = new System.Drawing.Point(29, 38);
            this.Collapse.Name = "Collapse";
            this.Collapse.Size = new System.Drawing.Size(75, 23);
            this.Collapse.TabIndex = 2;
            this.Collapse.Text = "Shrink";
            this.Collapse.UseVisualStyleBackColor = false;
            this.Collapse.Click += new System.EventHandler(this.Collapse_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(526, 443);
            this.Controls.Add(this.Collapse);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.WrittenNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox WrittenNote;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Collapse;
    }
}