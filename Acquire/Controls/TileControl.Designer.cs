namespace Acquire.Controls
{
    partial class TileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTile
            // 
            this.lblTile.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblTile.Location = new System.Drawing.Point(0, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(45, 45);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "12H";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTile);
            this.Name = "TileControl";
            this.Size = new System.Drawing.Size(45, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTile;
    }
}
