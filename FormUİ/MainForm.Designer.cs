
using System;
using System.Windows.Forms;

namespace FormUİ
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnBookUsers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.FlowLayoutPanel();
            this.dgwForm = new System.Windows.Forms.DataGridView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.gbxDlete = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedOption = new System.Windows.Forms.Button();
            this.lblSelectDeleteOption = new System.Windows.Forms.Label();
            this.cbxDeleteOption = new System.Windows.Forms.ComboBox();
            this.gbxUpDate = new System.Windows.Forms.GroupBox();
            this.btnGenreUpDate = new System.Windows.Forms.Button();
            this.btnBookUserUpDate = new System.Windows.Forms.Button();
            this.btnBookUpDate = new System.Windows.Forms.Button();
            this.btnUserUpDate = new System.Windows.Forms.Button();
            this.btnAuthorUpDate = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.btnBookUserAdd = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwForm)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.gbxDlete.SuspendLayout();
            this.gbxUpDate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnGenre);
            this.panelMenu.Controls.Add(this.btnBookUsers);
            this.panelMenu.Controls.Add(this.btnBooks);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnAuthors);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(183, 454);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Library Managment System";
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenre.Location = new System.Drawing.Point(0, 322);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(188, 45);
            this.btnGenre.TabIndex = 7;
            this.btnGenre.Text = "Genres";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnBookUsers
            // 
            this.btnBookUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUsers.Location = new System.Drawing.Point(-5, 265);
            this.btnBookUsers.Name = "btnBookUsers";
            this.btnBookUsers.Size = new System.Drawing.Size(188, 39);
            this.btnBookUsers.TabIndex = 5;
            this.btnBookUsers.Text = "Book Users";
            this.btnBookUsers.UseVisualStyleBackColor = false;
            this.btnBookUsers.Click += new System.EventHandler(this.btnBookUsers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBooks.Location = new System.Drawing.Point(0, 196);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(188, 44);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUsers.Location = new System.Drawing.Point(0, 125);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(188, 46);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuthors.Location = new System.Drawing.Point(0, 61);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(188, 44);
            this.btnAuthors.TabIndex = 0;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // panelView
            // 
            this.panelView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelView.Controls.Add(this.dgwForm);
            this.panelView.Location = new System.Drawing.Point(183, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(802, 159);
            this.panelView.TabIndex = 0;
            // 
            // dgwForm
            // 
            this.dgwForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwForm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwForm.Location = new System.Drawing.Point(3, 3);
            this.dgwForm.Name = "dgwForm";
            this.dgwForm.Size = new System.Drawing.Size(799, 156);
            this.dgwForm.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.Controls.Add(this.gbxDlete);
            this.controlPanel.Controls.Add(this.gbxUpDate);
            this.controlPanel.Controls.Add(this.gbxAdd);
            this.controlPanel.Location = new System.Drawing.Point(183, 159);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(802, 292);
            this.controlPanel.TabIndex = 1;
            // 
            // gbxDlete
            // 
            this.gbxDlete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDlete.Controls.Add(this.btnDeleteSelectedOption);
            this.gbxDlete.Controls.Add(this.lblSelectDeleteOption);
            this.gbxDlete.Controls.Add(this.cbxDeleteOption);
            this.gbxDlete.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDlete.Location = new System.Drawing.Point(429, 24);
            this.gbxDlete.Name = "gbxDlete";
            this.gbxDlete.Size = new System.Drawing.Size(300, 184);
            this.gbxDlete.TabIndex = 2;
            this.gbxDlete.TabStop = false;
            this.gbxDlete.Text = "Delete Menu";
            // 
            // btnDeleteSelectedOption
            // 
            this.btnDeleteSelectedOption.Location = new System.Drawing.Point(17, 128);
            this.btnDeleteSelectedOption.Name = "btnDeleteSelectedOption";
            this.btnDeleteSelectedOption.Size = new System.Drawing.Size(248, 37);
            this.btnDeleteSelectedOption.TabIndex = 3;
            this.btnDeleteSelectedOption.Text = "Delete Selected Option";
            this.btnDeleteSelectedOption.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedOption.Click += new System.EventHandler(this.btnDeleteSelectedOption_Click);
            // 
            // lblSelectDeleteOption
            // 
            this.lblSelectDeleteOption.AutoSize = true;
            this.lblSelectDeleteOption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDeleteOption.Location = new System.Drawing.Point(67, 46);
            this.lblSelectDeleteOption.Name = "lblSelectDeleteOption";
            this.lblSelectDeleteOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectDeleteOption.Size = new System.Drawing.Size(148, 19);
            this.lblSelectDeleteOption.TabIndex = 1;
            this.lblSelectDeleteOption.Text = "Select Delete Option";
            // 
            // cbxDeleteOption
            // 
            this.cbxDeleteOption.FormattingEnabled = true;
            this.cbxDeleteOption.Location = new System.Drawing.Point(67, 72);
            this.cbxDeleteOption.Name = "cbxDeleteOption";
            this.cbxDeleteOption.Size = new System.Drawing.Size(164, 32);
            this.cbxDeleteOption.TabIndex = 0;
            // 
            // gbxUpDate
            // 
            this.gbxUpDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxUpDate.Controls.Add(this.btnGenreUpDate);
            this.gbxUpDate.Controls.Add(this.btnBookUserUpDate);
            this.gbxUpDate.Controls.Add(this.btnBookUpDate);
            this.gbxUpDate.Controls.Add(this.btnUserUpDate);
            this.gbxUpDate.Controls.Add(this.btnAuthorUpDate);
            this.gbxUpDate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpDate.Location = new System.Drawing.Point(253, 24);
            this.gbxUpDate.Name = "gbxUpDate";
            this.gbxUpDate.Size = new System.Drawing.Size(155, 241);
            this.gbxUpDate.TabIndex = 1;
            this.gbxUpDate.TabStop = false;
            this.gbxUpDate.Text = "UpDate Menu";
            // 
            // btnGenreUpDate
            // 
            this.btnGenreUpDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenreUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreUpDate.Location = new System.Drawing.Point(18, 200);
            this.btnGenreUpDate.Name = "btnGenreUpDate";
            this.btnGenreUpDate.Size = new System.Drawing.Size(92, 25);
            this.btnGenreUpDate.TabIndex = 4;
            this.btnGenreUpDate.Text = "Genre";
            this.btnGenreUpDate.UseVisualStyleBackColor = false;
            this.btnGenreUpDate.Click += new System.EventHandler(this.btnGenreUpDate_Click);
            // 
            // btnBookUserUpDate
            // 
            this.btnBookUserUpDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBookUserUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUserUpDate.Location = new System.Drawing.Point(18, 159);
            this.btnBookUserUpDate.Name = "btnBookUserUpDate";
            this.btnBookUserUpDate.Size = new System.Drawing.Size(92, 25);
            this.btnBookUserUpDate.TabIndex = 3;
            this.btnBookUserUpDate.Text = "Book User";
            this.btnBookUserUpDate.UseVisualStyleBackColor = false;
            this.btnBookUserUpDate.Click += new System.EventHandler(this.btnBookUserUpDate_Click);
            // 
            // btnBookUpDate
            // 
            this.btnBookUpDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBookUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUpDate.Location = new System.Drawing.Point(18, 115);
            this.btnBookUpDate.Name = "btnBookUpDate";
            this.btnBookUpDate.Size = new System.Drawing.Size(92, 25);
            this.btnBookUpDate.TabIndex = 2;
            this.btnBookUpDate.Text = "Book";
            this.btnBookUpDate.UseVisualStyleBackColor = false;
            this.btnBookUpDate.Click += new System.EventHandler(this.btnBookUpDate_Click);
            // 
            // btnUserUpDate
            // 
            this.btnUserUpDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUserUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserUpDate.Location = new System.Drawing.Point(18, 72);
            this.btnUserUpDate.Name = "btnUserUpDate";
            this.btnUserUpDate.Size = new System.Drawing.Size(92, 25);
            this.btnUserUpDate.TabIndex = 1;
            this.btnUserUpDate.Text = "User";
            this.btnUserUpDate.UseVisualStyleBackColor = false;
            this.btnUserUpDate.Click += new System.EventHandler(this.btnUserUpDate_Click);
            // 
            // btnAuthorUpDate
            // 
            this.btnAuthorUpDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAuthorUpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuthorUpDate.Location = new System.Drawing.Point(18, 32);
            this.btnAuthorUpDate.Name = "btnAuthorUpDate";
            this.btnAuthorUpDate.Size = new System.Drawing.Size(92, 25);
            this.btnAuthorUpDate.TabIndex = 0;
            this.btnAuthorUpDate.Text = "Author";
            this.btnAuthorUpDate.UseVisualStyleBackColor = false;
            this.btnAuthorUpDate.Click += new System.EventHandler(this.btnAuthorUpDate_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxAdd.Controls.Add(this.btnGenreAdd);
            this.gbxAdd.Controls.Add(this.btnBookUserAdd);
            this.gbxAdd.Controls.Add(this.btnBookAdd);
            this.gbxAdd.Controls.Add(this.btnUserAdd);
            this.gbxAdd.Controls.Add(this.btnAuthorAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.Location = new System.Drawing.Point(66, 24);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(145, 241);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add Menu";
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenreAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenreAdd.Location = new System.Drawing.Point(18, 200);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(92, 25);
            this.btnGenreAdd.TabIndex = 4;
            this.btnGenreAdd.Text = "Genre";
            this.btnGenreAdd.UseVisualStyleBackColor = false;
            this.btnGenreAdd.Click += new System.EventHandler(this.btnGenreAdd_Click);
            // 
            // btnBookUserAdd
            // 
            this.btnBookUserAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBookUserAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUserAdd.Location = new System.Drawing.Point(18, 159);
            this.btnBookUserAdd.Name = "btnBookUserAdd";
            this.btnBookUserAdd.Size = new System.Drawing.Size(92, 25);
            this.btnBookUserAdd.TabIndex = 3;
            this.btnBookUserAdd.Text = "Book User";
            this.btnBookUserAdd.UseVisualStyleBackColor = false;
            this.btnBookUserAdd.Click += new System.EventHandler(this.btnBookUserAdd_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBookAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookAdd.Location = new System.Drawing.Point(18, 115);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(92, 25);
            this.btnBookAdd.TabIndex = 2;
            this.btnBookAdd.Text = "Book";
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUserAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserAdd.Location = new System.Drawing.Point(18, 72);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(92, 25);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "User";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAuthorAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuthorAdd.Location = new System.Drawing.Point(18, 32);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(92, 25);
            this.btnAuthorAdd.TabIndex = 0;
            this.btnAuthorAdd.Text = "Author";
            this.btnAuthorAdd.UseVisualStyleBackColor = false;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwForm)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.gbxDlete.ResumeLayout(false);
            this.gbxDlete.PerformLayout();
            this.gbxUpDate.ResumeLayout(false);
            this.gbxAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel panelView;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnBookUsers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.DataGridView dgwForm;
        private System.Windows.Forms.Panel controlPanel;
        private Label label1;
        private GroupBox gbxAdd;
        private Button btnGenreAdd;
        private Button btnBookUserAdd;
        private Button btnBookAdd;
        private Button btnUserAdd;
        private Button btnAuthorAdd;
        private GroupBox gbxUpDate;
        private Button btnGenreUpDate;
        private Button btnBookUserUpDate;
        private Button btnBookUpDate;
        private Button btnUserUpDate;
        private Button btnAuthorUpDate;
        private GroupBox gbxDlete;
        private Label lblSelectDeleteOption;
        private ComboBox cbxDeleteOption;
        private Button btnDeleteSelectedOption;
    }
}

