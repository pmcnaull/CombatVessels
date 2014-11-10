namespace CombatVessels
{
    partial class CombatVesselsMainForm
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
            this.boardUserControl1 = new CombatVessels.BoardUserControl();
            this.SuspendLayout();
            // 
            // boardUserControl1
            // 
            this.boardUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardUserControl1.Location = new System.Drawing.Point(32, 30);
            this.boardUserControl1.Name = "boardUserControl1";
            this.boardUserControl1.Size = new System.Drawing.Size(500, 500);
            this.boardUserControl1.TabIndex = 0;
            // 
            // CombatVesselsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 713);
            this.Controls.Add(this.boardUserControl1);
            this.Name = "CombatVesselsMainForm";
            this.Text = "Combat Vessels";
            this.ResumeLayout(false);

        }

        #endregion

        private BoardUserControl boardUserControl1;
    }
}

