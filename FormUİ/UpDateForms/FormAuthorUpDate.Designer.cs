
namespace FormUİ.UpDateForms
{
    partial class FormAuthorUpDate
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
            this.btnUpDateSave = new System.Windows.Forms.Button();
            this.btnUpDateCancel = new System.Windows.Forms.Button();
            this.lblAuthorIdUpDate = new System.Windows.Forms.Label();
            this.lblAuthorLastNameUpDate = new System.Windows.Forms.Label();
            this.lblAuthorFirstNameUpDate = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpDateSave
            // 
            this.btnUpDateSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpDateSave.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpDateSave.Location = new System.Drawing.Point(72, 208);
            this.btnUpDateSave.Name = "btnUpDateSave";
            this.btnUpDateSave.Size = new System.Drawing.Size(102, 35);
            this.btnUpDateSave.TabIndex = 0;
            this.btnUpDateSave.Text = "SAVE";
            this.btnUpDateSave.UseVisualStyleBackColor = false;
            this.btnUpDateSave.Click += new System.EventHandler(this.btnUpDateSave_Click);
            // 
            // btnUpDateCancel
            // 
            this.btnUpDateCancel.BackColor = System.Drawing.Color.Red;
            this.btnUpDateCancel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpDateCancel.Location = new System.Drawing.Point(300, 208);
            this.btnUpDateCancel.Name = "btnUpDateCancel";
            this.btnUpDateCancel.Size = new System.Drawing.Size(97, 35);
            this.btnUpDateCancel.TabIndex = 1;
            this.btnUpDateCancel.Text = "CANCEL";
            this.btnUpDateCancel.UseVisualStyleBackColor = false;
            this.btnUpDateCancel.Click += new System.EventHandler(this.btnUpDateCancel_Click);
            // 
            // lblAuthorIdUpDate
            // 
            this.lblAuthorIdUpDate.AutoSize = true;
            this.lblAuthorIdUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorIdUpDate.Location = new System.Drawing.Point(118, 48);
            this.lblAuthorIdUpDate.Name = "lblAuthorIdUpDate";
            this.lblAuthorIdUpDate.Size = new System.Drawing.Size(29, 18);
            this.lblAuthorIdUpDate.TabIndex = 2;
            this.lblAuthorIdUpDate.Text = "ID:";
            // 
            // lblAuthorLastNameUpDate
            // 
            this.lblAuthorLastNameUpDate.AutoSize = true;
            this.lblAuthorLastNameUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorLastNameUpDate.Location = new System.Drawing.Point(118, 139);
            this.lblAuthorLastNameUpDate.Name = "lblAuthorLastNameUpDate";
            this.lblAuthorLastNameUpDate.Size = new System.Drawing.Size(94, 18);
            this.lblAuthorLastNameUpDate.TabIndex = 4;
            this.lblAuthorLastNameUpDate.Text = "Last Name:";
            // 
            // lblAuthorFirstNameUpDate
            // 
            this.lblAuthorFirstNameUpDate.AutoSize = true;
            this.lblAuthorFirstNameUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorFirstNameUpDate.Location = new System.Drawing.Point(118, 91);
            this.lblAuthorFirstNameUpDate.Name = "lblAuthorFirstNameUpDate";
            this.lblAuthorFirstNameUpDate.Size = new System.Drawing.Size(96, 18);
            this.lblAuthorFirstNameUpDate.TabIndex = 6;
            this.lblAuthorFirstNameUpDate.Text = "First Name:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(234, 46);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 7;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(234, 137);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(234, 89);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstName.TabIndex = 11;
            // 
            // FormAuthorUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 278);
            this.ControlBox = false;
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblAuthorFirstNameUpDate);
            this.Controls.Add(this.lblAuthorLastNameUpDate);
            this.Controls.Add(this.lblAuthorIdUpDate);
            this.Controls.Add(this.btnUpDateCancel);
            this.Controls.Add(this.btnUpDateSave);
            this.Name = "FormAuthorUpDate";
            this.Text = "FormAuthorUpDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpDateSave;
        private System.Windows.Forms.Button btnUpDateCancel;
        private System.Windows.Forms.Label lblAuthorIdUpDate;
        private System.Windows.Forms.Label lblAuthorLastNameUpDate;
        private System.Windows.Forms.Label lblAuthorFirstNameUpDate;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
    }
}