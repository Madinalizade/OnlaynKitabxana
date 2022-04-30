
namespace FormUİ.AddForms
{
    partial class FormGenreAdd
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
            this.lblGenreAddName = new System.Windows.Forms.Label();
            this.btnGenreAddSave = new System.Windows.Forms.Button();
            this.btnGenreAddCancel = new System.Windows.Forms.Button();
            this.tbxGenreAddName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGenreAddName
            // 
            this.lblGenreAddName.AutoSize = true;
            this.lblGenreAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenreAddName.Location = new System.Drawing.Point(98, 73);
            this.lblGenreAddName.Name = "lblGenreAddName";
            this.lblGenreAddName.Size = new System.Drawing.Size(55, 20);
            this.lblGenreAddName.TabIndex = 1;
            this.lblGenreAddName.Text = "Name";
            // 
            // btnGenreAddSave
            // 
            this.btnGenreAddSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenreAddSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreAddSave.Location = new System.Drawing.Point(48, 129);
            this.btnGenreAddSave.Name = "btnGenreAddSave";
            this.btnGenreAddSave.Size = new System.Drawing.Size(114, 41);
            this.btnGenreAddSave.TabIndex = 2;
            this.btnGenreAddSave.Text = "SAVE";
            this.btnGenreAddSave.UseVisualStyleBackColor = false;
            this.btnGenreAddSave.Click += new System.EventHandler(this.btnGenreAddSave_Click);
            // 
            // btnGenreAddCancel
            // 
            this.btnGenreAddCancel.BackColor = System.Drawing.Color.Red;
            this.btnGenreAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreAddCancel.Location = new System.Drawing.Point(200, 129);
            this.btnGenreAddCancel.Name = "btnGenreAddCancel";
            this.btnGenreAddCancel.Size = new System.Drawing.Size(114, 41);
            this.btnGenreAddCancel.TabIndex = 3;
            this.btnGenreAddCancel.Text = "CANCEL";
            this.btnGenreAddCancel.UseVisualStyleBackColor = false;
            this.btnGenreAddCancel.Click += new System.EventHandler(this.btnGenreAddCancel_Click);
            // 
            // tbxGenreAddName
            // 
            this.tbxGenreAddName.Location = new System.Drawing.Point(185, 75);
            this.tbxGenreAddName.Name = "tbxGenreAddName";
            this.tbxGenreAddName.Size = new System.Drawing.Size(100, 20);
            this.tbxGenreAddName.TabIndex = 5;
            // 
            // FormGenreAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 195);
            this.ControlBox = false;
            this.Controls.Add(this.tbxGenreAddName);
            this.Controls.Add(this.btnGenreAddCancel);
            this.Controls.Add(this.btnGenreAddSave);
            this.Controls.Add(this.lblGenreAddName);
            this.Name = "FormGenreAdd";
            this.Text = "FormGenreAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenreAddName;
        private System.Windows.Forms.Button btnGenreAddSave;
        private System.Windows.Forms.Button btnGenreAddCancel;
        private System.Windows.Forms.TextBox tbxGenreAddName;
    }
}