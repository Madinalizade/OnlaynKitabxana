
namespace FormUİ.UpDateForms
{
    partial class FormGenreUpDate
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
            this.lblGenreUpDateId = new System.Windows.Forms.Label();
            this.lblGenreUpDateName = new System.Windows.Forms.Label();
            this.tbxGenreUpDateId = new System.Windows.Forms.TextBox();
            this.tbxGenreUpDateName = new System.Windows.Forms.TextBox();
            this.btnGenreUpDateSave = new System.Windows.Forms.Button();
            this.btnGenreUpDateCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenreUpDateId
            // 
            this.lblGenreUpDateId.AutoSize = true;
            this.lblGenreUpDateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenreUpDateId.Location = new System.Drawing.Point(88, 36);
            this.lblGenreUpDateId.Name = "lblGenreUpDateId";
            this.lblGenreUpDateId.Size = new System.Drawing.Size(27, 24);
            this.lblGenreUpDateId.TabIndex = 0;
            this.lblGenreUpDateId.Text = "Id";
            // 
            // lblGenreUpDateName
            // 
            this.lblGenreUpDateName.AutoSize = true;
            this.lblGenreUpDateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenreUpDateName.Location = new System.Drawing.Point(50, 92);
            this.lblGenreUpDateName.Name = "lblGenreUpDateName";
            this.lblGenreUpDateName.Size = new System.Drawing.Size(65, 24);
            this.lblGenreUpDateName.TabIndex = 1;
            this.lblGenreUpDateName.Text = "Name";
            // 
            // tbxGenreUpDateId
            // 
            this.tbxGenreUpDateId.Location = new System.Drawing.Point(146, 40);
            this.tbxGenreUpDateId.Name = "tbxGenreUpDateId";
            this.tbxGenreUpDateId.Size = new System.Drawing.Size(124, 20);
            this.tbxGenreUpDateId.TabIndex = 2;
            // 
            // tbxGenreUpDateName
            // 
            this.tbxGenreUpDateName.Location = new System.Drawing.Point(146, 97);
            this.tbxGenreUpDateName.Name = "tbxGenreUpDateName";
            this.tbxGenreUpDateName.Size = new System.Drawing.Size(124, 20);
            this.tbxGenreUpDateName.TabIndex = 3;
            // 
            // btnGenreUpDateSave
            // 
            this.btnGenreUpDateSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenreUpDateSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreUpDateSave.Location = new System.Drawing.Point(32, 160);
            this.btnGenreUpDateSave.Name = "btnGenreUpDateSave";
            this.btnGenreUpDateSave.Size = new System.Drawing.Size(111, 36);
            this.btnGenreUpDateSave.TabIndex = 4;
            this.btnGenreUpDateSave.Text = "SAVE";
            this.btnGenreUpDateSave.UseVisualStyleBackColor = false;
            this.btnGenreUpDateSave.Click += new System.EventHandler(this.btnGenreUpDateSave_Click);
            // 
            // btnGenreUpDateCancel
            // 
            this.btnGenreUpDateCancel.BackColor = System.Drawing.Color.Red;
            this.btnGenreUpDateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreUpDateCancel.Location = new System.Drawing.Point(181, 160);
            this.btnGenreUpDateCancel.Name = "btnGenreUpDateCancel";
            this.btnGenreUpDateCancel.Size = new System.Drawing.Size(111, 36);
            this.btnGenreUpDateCancel.TabIndex = 5;
            this.btnGenreUpDateCancel.Text = "CANCEL";
            this.btnGenreUpDateCancel.UseVisualStyleBackColor = false;
            this.btnGenreUpDateCancel.Click += new System.EventHandler(this.btnGenreUpDateCancel_Click);
            // 
            // FormGenreUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenreUpDateCancel);
            this.Controls.Add(this.btnGenreUpDateSave);
            this.Controls.Add(this.tbxGenreUpDateName);
            this.Controls.Add(this.tbxGenreUpDateId);
            this.Controls.Add(this.lblGenreUpDateName);
            this.Controls.Add(this.lblGenreUpDateId);
            this.Name = "FormGenreUpDate";
            this.Text = "FormGenreUpDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenreUpDateId;
        private System.Windows.Forms.Label lblGenreUpDateName;
        private System.Windows.Forms.TextBox tbxGenreUpDateId;
        private System.Windows.Forms.TextBox tbxGenreUpDateName;
        private System.Windows.Forms.Button btnGenreUpDateSave;
        private System.Windows.Forms.Button btnGenreUpDateCancel;
    }
}