using System;

namespace CheckPoint2
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblActorName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboActors = new System.Windows.Forms.ComboBox();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(594, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRead,
            this.mnuWrite,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuRead
            // 
            this.mnuRead.Name = "mnuRead";
            this.mnuRead.Size = new System.Drawing.Size(158, 22);
            this.mnuRead.Text = "&Read Arraylist";
            this.mnuRead.Click += new System.EventHandler(this.mnuRead_Click);
            // 
            // mnuWrite
            // 
            this.mnuWrite.Name = "mnuWrite";
            this.mnuWrite.Size = new System.Drawing.Size(158, 22);
            this.mnuWrite.Text = "&Write Arraylist";
            this.mnuWrite.Click += new System.EventHandler(this.mnuWrite_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(158, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblActorName
            // 
            this.lblActorName.AutoSize = true;
            this.lblActorName.Location = new System.Drawing.Point(13, 61);
            this.lblActorName.Name = "lblActorName";
            this.lblActorName.Size = new System.Drawing.Size(65, 12);
            this.lblActorName.TabIndex = 1;
            this.lblActorName.Text = "Actor &Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 109);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(53, 12);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "&Position";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(13, 154);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(41, 12);
            this.lblActors.TabIndex = 3;
            this.lblActors.Text = "&Actors";
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(104, 51);
            this.txtActorName.Multiline = true;
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(123, 22);
            this.txtActorName.TabIndex = 4;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(104, 99);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(69, 21);
            this.txtPosition.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(343, 51);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(163, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "&Insert into Arraylist";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(343, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete from Arraylist";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboActors
            // 
            this.cboActors.FormattingEnabled = true;
            this.cboActors.Location = new System.Drawing.Point(104, 145);
            this.cboActors.Name = "cboActors";
            this.cboActors.Size = new System.Drawing.Size(123, 20);
            this.cboActors.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 204);
            this.Controls.Add(this.cboActors);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtActorName);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblActorName);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Array Lists";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.Label lblActorName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboActors;
        private System.Windows.Forms.ToolStripMenuItem mnuRead;
        private System.Windows.Forms.ToolStripMenuItem mnuWrite;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private EventHandler Form1_Load;
    }
}

