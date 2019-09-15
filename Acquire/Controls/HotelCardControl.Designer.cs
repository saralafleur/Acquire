namespace Acquire.Controls
{
    partial class HotelCardControl
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
            this.lblHotelCount = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHotelCount
            // 
            this.lblHotelCount.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelCount.Location = new System.Drawing.Point(1, 12);
            this.lblHotelCount.Name = "lblHotelCount";
            this.lblHotelCount.Size = new System.Drawing.Size(118, 36);
            this.lblHotelCount.TabIndex = 77;
            this.lblHotelCount.Text = "25";
            this.lblHotelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHotelName
            // 
            this.lblHotelName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.Black;
            this.lblHotelName.Location = new System.Drawing.Point(1, -1);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(118, 22);
            this.lblHotelName.TabIndex = 76;
            this.lblHotelName.Text = "Continental";
            this.lblHotelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HotelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.lblHotelCount);
            this.Name = "HotelCard";
            this.Size = new System.Drawing.Size(118, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHotelCount;
        private System.Windows.Forms.Label lblHotelName;
    }
}
