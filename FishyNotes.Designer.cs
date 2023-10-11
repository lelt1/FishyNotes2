namespace Fishy_Notes
{
    partial class FishyNotes
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
            this.AddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(60, 59);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(188, 101);
            this.AddNote.TabIndex = 0;
            this.AddNote.Text = "More Fish";
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 219);
            this.Controls.Add(this.AddNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNotes";
            this.Text = "FishyNotes";
            this.Load += new System.EventHandler(this.FishyNotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNote;
    }
}

