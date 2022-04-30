
namespace FormUİ.AddForms
{
    partial class FormBookAdd
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
            this.lblBookAddName = new System.Windows.Forms.Label();
            this.lblBookAddUserId = new System.Windows.Forms.Label();
            this.lblBookAddAuthorId = new System.Windows.Forms.Label();
            this.tbxBookAddName = new System.Windows.Forms.TextBox();
            this.btnBookAddSave = new System.Windows.Forms.Button();
            this.btnBookAddCancel = new System.Windows.Forms.Button();
            this.cbxGenres = new System.Windows.Forms.ComboBox();
            this.cbxAuthors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBookAddName
            // 
            this.lblBookAddName.AutoSize = true;
            this.lblBookAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAddName.Location = new System.Drawing.Point(169, 53);
            this.lblBookAddName.Name = "lblBookAddName";
            this.lblBookAddName.Size = new System.Drawing.Size(65, 24);
            this.lblBookAddName.TabIndex = 2;
            this.lblBookAddName.Text = "Name";
            // 
            // lblBookAddUserId
            // 
            this.lblBookAddUserId.AutoSize = true;
            this.lblBookAddUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAddUserId.Location = new System.Drawing.Point(169, 107);
            this.lblBookAddUserId.Name = "lblBookAddUserId";
            this.lblBookAddUserId.Size = new System.Drawing.Size(68, 24);
            this.lblBookAddUserId.TabIndex = 4;
            this.lblBookAddUserId.Text = "Genre";
            // 
            // lblBookAddAuthorId
            // 
            this.lblBookAddAuthorId.AutoSize = true;
            this.lblBookAddAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAddAuthorId.Location = new System.Drawing.Point(170, 168);
            this.lblBookAddAuthorId.Name = "lblBookAddAuthorId";
            this.lblBookAddAuthorId.Size = new System.Drawing.Size(72, 24);
            this.lblBookAddAuthorId.TabIndex = 6;
            this.lblBookAddAuthorId.Text = "Author";
            // 
            // tbxBookAddName
            // 
            this.tbxBookAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookAddName.Location = new System.Drawing.Point(255, 53);
            this.tbxBookAddName.Name = "tbxBookAddName";
            this.tbxBookAddName.Size = new System.Drawing.Size(141, 29);
            this.tbxBookAddName.TabIndex = 15;
            // 
            // btnBookAddSave
            // 
            this.btnBookAddSave.BackColor = System.Drawing.Color.Green;
            this.btnBookAddSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookAddSave.Location = new System.Drawing.Point(93, 228);
            this.btnBookAddSave.Name = "btnBookAddSave";
            this.btnBookAddSave.Size = new System.Drawing.Size(111, 46);
            this.btnBookAddSave.TabIndex = 18;
            this.btnBookAddSave.Text = "SAVE";
            this.btnBookAddSave.UseVisualStyleBackColor = false;
            this.btnBookAddSave.Click += new System.EventHandler(this.btnBookAddSave_Click);
            // 
            // btnBookAddCancel
            // 
            this.btnBookAddCancel.BackColor = System.Drawing.Color.Red;
            this.btnBookAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookAddCancel.Location = new System.Drawing.Point(331, 228);
            this.btnBookAddCancel.Name = "btnBookAddCancel";
            this.btnBookAddCancel.Size = new System.Drawing.Size(111, 46);
            this.btnBookAddCancel.TabIndex = 19;
            this.btnBookAddCancel.Text = "CANCEL";
            this.btnBookAddCancel.UseVisualStyleBackColor = false;
            this.btnBookAddCancel.Click += new System.EventHandler(this.btnBookAddCancel_Click);
            // 
            // cbxGenres
            // 
            this.cbxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxGenres.FormattingEnabled = true;
            this.cbxGenres.Location = new System.Drawing.Point(255, 104);
            this.cbxGenres.Name = "cbxGenres";
            this.cbxGenres.Size = new System.Drawing.Size(141, 32);
            this.cbxGenres.TabIndex = 20;
            // 
            // cbxAuthors
            // 
            this.cbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxAuthors.FormattingEnabled = true;
            this.cbxAuthors.Location = new System.Drawing.Point(257, 161);
            this.cbxAuthors.Name = "cbxAuthors";
            this.cbxAuthors.Size = new System.Drawing.Size(141, 32);
            this.cbxAuthors.TabIndex = 21;
            // 
            // FormBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 300);
            this.ControlBox = false;
            this.Controls.Add(this.cbxAuthors);
            this.Controls.Add(this.cbxGenres);
            this.Controls.Add(this.btnBookAddCancel);
            this.Controls.Add(this.btnBookAddSave);
            this.Controls.Add(this.tbxBookAddName);
            this.Controls.Add(this.lblBookAddAuthorId);
            this.Controls.Add(this.lblBookAddUserId);
            this.Controls.Add(this.lblBookAddName);
            this.Name = "FormBookAdd";
            this.Text = "FormBookAdd";
            this.Load += new System.EventHandler(this.FormBookAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookAddName;
        private System.Windows.Forms.Label lblBookAddUserId;
        private System.Windows.Forms.Label lblBookAddAuthorId;
        private System.Windows.Forms.TextBox tbxBookAddName;
        private System.Windows.Forms.Button btnBookAddSave;
        private System.Windows.Forms.Button btnBookAddCancel;
        private System.Windows.Forms.ComboBox cbxGenres;
        private System.Windows.Forms.ComboBox cbxAuthors;
    }
}