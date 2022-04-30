
namespace FormUİ.AddForms
{
    partial class FormBookUserAdd
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
            this.lblBookUserAddUserId = new System.Windows.Forms.Label();
            this.lblBookUserAddBookId = new System.Windows.Forms.Label();
            this.tbxBookUserAddUserId = new System.Windows.Forms.TextBox();
            this.tbxBookUserAddBookId = new System.Windows.Forms.TextBox();
            this.btnBookUserSave = new System.Windows.Forms.Button();
            this.btnBookUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookUserAddUserId
            // 
            this.lblBookUserAddUserId.AutoSize = true;
            this.lblBookUserAddUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookUserAddUserId.Location = new System.Drawing.Point(113, 41);
            this.lblBookUserAddUserId.Name = "lblBookUserAddUserId";
            this.lblBookUserAddUserId.Size = new System.Drawing.Size(76, 24);
            this.lblBookUserAddUserId.TabIndex = 1;
            this.lblBookUserAddUserId.Text = "User Id";
            // 
            // lblBookUserAddBookId
            // 
            this.lblBookUserAddBookId.AutoSize = true;
            this.lblBookUserAddBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookUserAddBookId.Location = new System.Drawing.Point(113, 85);
            this.lblBookUserAddBookId.Name = "lblBookUserAddBookId";
            this.lblBookUserAddBookId.Size = new System.Drawing.Size(80, 24);
            this.lblBookUserAddBookId.TabIndex = 2;
            this.lblBookUserAddBookId.Text = "Book Id";
            // 
            // tbxBookUserAddUserId
            // 
            this.tbxBookUserAddUserId.Location = new System.Drawing.Point(225, 45);
            this.tbxBookUserAddUserId.Name = "tbxBookUserAddUserId";
            this.tbxBookUserAddUserId.Size = new System.Drawing.Size(130, 20);
            this.tbxBookUserAddUserId.TabIndex = 4;
            // 
            // tbxBookUserAddBookId
            // 
            this.tbxBookUserAddBookId.Location = new System.Drawing.Point(225, 85);
            this.tbxBookUserAddBookId.Name = "tbxBookUserAddBookId";
            this.tbxBookUserAddBookId.Size = new System.Drawing.Size(130, 20);
            this.tbxBookUserAddBookId.TabIndex = 5;
            // 
            // btnBookUserSave
            // 
            this.btnBookUserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookUserSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUserSave.Location = new System.Drawing.Point(59, 147);
            this.btnBookUserSave.Name = "btnBookUserSave";
            this.btnBookUserSave.Size = new System.Drawing.Size(130, 49);
            this.btnBookUserSave.TabIndex = 6;
            this.btnBookUserSave.Text = "SAVE";
            this.btnBookUserSave.UseVisualStyleBackColor = false;
            this.btnBookUserSave.Click += new System.EventHandler(this.btnBookUserSave_Click);
            // 
            // btnBookUserCancel
            // 
            this.btnBookUserCancel.BackColor = System.Drawing.Color.Red;
            this.btnBookUserCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUserCancel.Location = new System.Drawing.Point(267, 147);
            this.btnBookUserCancel.Name = "btnBookUserCancel";
            this.btnBookUserCancel.Size = new System.Drawing.Size(130, 49);
            this.btnBookUserCancel.TabIndex = 7;
            this.btnBookUserCancel.Text = "CANCEL";
            this.btnBookUserCancel.UseVisualStyleBackColor = false;
            this.btnBookUserCancel.Click += new System.EventHandler(this.btnBookUserCancel_Click);
            // 
            // FormBookUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 227);
            this.Controls.Add(this.btnBookUserCancel);
            this.Controls.Add(this.btnBookUserSave);
            this.Controls.Add(this.tbxBookUserAddBookId);
            this.Controls.Add(this.tbxBookUserAddUserId);
            this.Controls.Add(this.lblBookUserAddBookId);
            this.Controls.Add(this.lblBookUserAddUserId);
            this.Name = "FormBookUserAdd";
            this.Text = "FormBookUserAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookUserAddUserId;
        private System.Windows.Forms.Label lblBookUserAddBookId;
        private System.Windows.Forms.TextBox tbxBookUserAddUserId;
        private System.Windows.Forms.TextBox tbxBookUserAddBookId;
        private System.Windows.Forms.Button btnBookUserSave;
        private System.Windows.Forms.Button btnBookUserCancel;
    }
}