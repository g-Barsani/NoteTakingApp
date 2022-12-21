namespace NoteTakingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutOption = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.messageListLabel = new System.Windows.Forms.Label();
            this.notesList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitOption});
            this.fileMenu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 22);
            this.fileMenu.Text = "&File";
            // 
            // exitOption
            // 
            this.exitOption.Name = "exitOption";
            this.exitOption.Size = new System.Drawing.Size(103, 22);
            this.exitOption.Text = "E&xit";
            this.exitOption.Click += new System.EventHandler(this.exitOption_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutOption});
            this.helpMenu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(52, 22);
            this.helpMenu.Text = "&Help";
            // 
            // aboutOption
            // 
            this.aboutOption.Name = "aboutOption";
            this.aboutOption.Size = new System.Drawing.Size(120, 22);
            this.aboutOption.Text = "&About";
            this.aboutOption.Click += new System.EventHandler(this.aboutOption_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(94, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleText.Location = new System.Drawing.Point(154, 34);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(180, 26);
            this.titleText.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.messageLabel.Location = new System.Drawing.Point(57, 84);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(86, 18);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message:";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // messageText
            // 
            this.messageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.messageText.Location = new System.Drawing.Point(154, 81);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(351, 228);
            this.messageText.TabIndex = 2;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.SandyBrown;
            this.newButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(154, 346);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(93, 30);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SandyBrown;
            this.saveButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(414, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.Color.SandyBrown;
            this.readButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readButton.Location = new System.Drawing.Point(590, 346);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(86, 30);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.SandyBrown;
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(682, 346);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // messageListLabel
            // 
            this.messageListLabel.AutoSize = true;
            this.messageListLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageListLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageListLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.messageListLabel.Location = new System.Drawing.Point(528, 59);
            this.messageListLabel.Name = "messageListLabel";
            this.messageListLabel.Size = new System.Drawing.Size(115, 18);
            this.messageListLabel.TabIndex = 1;
            this.messageListLabel.Text = "Message List";
            // 
            // notesList
            // 
            this.notesList.AllowUserToAddRows = false;
            this.notesList.AllowUserToDeleteRows = false;
            this.notesList.AllowUserToOrderColumns = true;
            this.notesList.AllowUserToResizeColumns = false;
            this.notesList.AllowUserToResizeRows = false;
            this.notesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesList.ColumnHeadersVisible = false;
            this.notesList.Location = new System.Drawing.Point(528, 81);
            this.notesList.Name = "notesList";
            this.notesList.ReadOnly = true;
            this.notesList.RowHeadersVisible = false;
            this.notesList.RowTemplate.Height = 28;
            this.notesList.Size = new System.Drawing.Size(240, 228);
            this.notesList.TabIndex = 4;
            this.notesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesList_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::NoteTakingApp.Properties.Resources.starry_sky;
            this.ClientSize = new System.Drawing.Size(795, 409);
            this.Controls.Add(this.notesList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.messageListLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form by Gabriel B.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem exitOption;
        private Label titleLabel;
        private TextBox titleText;
        private Label messageLabel;
        private TextBox messageText;
        private Button newButton;
        private Button saveButton;
        private Button readButton;
        private Button deleteButton;
        private Label messageListLabel;
        private DataGridView notesList;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutOption;
    }
}