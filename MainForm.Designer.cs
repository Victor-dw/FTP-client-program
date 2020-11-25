namespace FtpClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spCtrlOuter = new System.Windows.Forms.SplitContainer();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tbtnPre = new System.Windows.Forms.ToolStripButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.spCtrlContent = new System.Windows.Forms.SplitContainer();
            this.flowPnlLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.treeLocal = new System.Windows.Forms.TreeView();
            this.menuLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuRightKey = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spCtrlOuter)).BeginInit();
            this.spCtrlOuter.Panel1.SuspendLayout();
            this.spCtrlOuter.Panel2.SuspendLayout();
            this.spCtrlOuter.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCtrlContent)).BeginInit();
            this.spCtrlContent.Panel1.SuspendLayout();
            this.spCtrlContent.Panel2.SuspendLayout();
            this.spCtrlContent.SuspendLayout();
            this.menuLocal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuRightKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // spCtrlOuter
            // 
            this.spCtrlOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spCtrlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCtrlOuter.Location = new System.Drawing.Point(0, 0);
            this.spCtrlOuter.Name = "spCtrlOuter";
            this.spCtrlOuter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spCtrlOuter.Panel1
            // 
            this.spCtrlOuter.Panel1.Controls.Add(this.toolBar);
            this.spCtrlOuter.Panel1.Controls.Add(this.btnLogin);
            this.spCtrlOuter.Panel1.Controls.Add(this.txtPassword);
            this.spCtrlOuter.Panel1.Controls.Add(this.txtUserName);
            this.spCtrlOuter.Panel1.Controls.Add(this.label5);
            this.spCtrlOuter.Panel1.Controls.Add(this.txtPort);
            this.spCtrlOuter.Panel1.Controls.Add(this.label4);
            this.spCtrlOuter.Panel1.Controls.Add(this.label3);
            this.spCtrlOuter.Panel1.Controls.Add(this.txtAddress);
            this.spCtrlOuter.Panel1.Controls.Add(this.label1);
            this.spCtrlOuter.Panel1.Controls.Add(this.menuMain);
            // 
            // spCtrlOuter.Panel2
            // 
            this.spCtrlOuter.Panel2.Controls.Add(this.spCtrlContent);
            this.spCtrlOuter.Size = new System.Drawing.Size(784, 562);
            this.spCtrlOuter.SplitterDistance = 100;
            this.spCtrlOuter.TabIndex = 0;
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnPre});
            this.toolBar.Location = new System.Drawing.Point(0, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(782, 25);
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "toolStrip1";
            // 
            // tbtnPre
            // 
            this.tbtnPre.Image = global::FtpClient.Properties.Resources.up;
            this.tbtnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPre.Name = "tbtnPre";
            this.tbtnPre.Size = new System.Drawing.Size(76, 22);
            this.tbtnPre.Text = "上级目录";
            this.tbtnPre.Click += new System.EventHandler(this.tbtnPre_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(678, 61);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(558, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "ftp123";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(400, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "ftp123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密码：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(227, 62);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "21";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "端口：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(67, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "192.168.1.102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP地址：";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(782, 25);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(F)";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(115, 22);
            this.menuLogin.Text = "登录(L)";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(115, 22);
            this.menuExit.Text = "退出(E)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(59, 21);
            this.menuEdit.Text = "编辑(E)";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(124, 22);
            this.menuConfig.Text = "配置文件";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(H)";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(116, 22);
            this.menuAbout.Text = "关于(A)";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // spCtrlContent
            // 
            this.spCtrlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spCtrlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCtrlContent.Location = new System.Drawing.Point(0, 0);
            this.spCtrlContent.Name = "spCtrlContent";
            // 
            // spCtrlContent.Panel1
            // 
            this.spCtrlContent.Panel1.Controls.Add(this.flowPnlLeft);
            // 
            // spCtrlContent.Panel2
            // 
            this.spCtrlContent.Panel2.Controls.Add(this.treeLocal);
            this.spCtrlContent.Size = new System.Drawing.Size(784, 458);
            this.spCtrlContent.SplitterDistance = 349;
            this.spCtrlContent.TabIndex = 0;
            // 
            // flowPnlLeft
            // 
            this.flowPnlLeft.BackColor = System.Drawing.SystemColors.Window;
            this.flowPnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnlLeft.Location = new System.Drawing.Point(0, 0);
            this.flowPnlLeft.Name = "flowPnlLeft";
            this.flowPnlLeft.Size = new System.Drawing.Size(347, 456);
            this.flowPnlLeft.TabIndex = 0;
            // 
            // treeLocal
            // 
            this.treeLocal.ContextMenuStrip = this.menuLocal;
            this.treeLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLocal.ImageIndex = 0;
            this.treeLocal.ImageList = this.imgList;
            this.treeLocal.Location = new System.Drawing.Point(0, 0);
            this.treeLocal.Name = "treeLocal";
            treeNode1.Name = "节点0";
            treeNode1.Text = "计算机";
            this.treeLocal.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeLocal.SelectedImageIndex = 0;
            this.treeLocal.Size = new System.Drawing.Size(429, 456);
            this.treeLocal.TabIndex = 0;
            this.treeLocal.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeLocal_BeforeExpand);
            this.treeLocal.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeLocal_AfterSelect);
            // 
            // menuLocal
            // 
            this.menuLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad});
            this.menuLocal.Name = "menuLocal";
            this.menuLocal.Size = new System.Drawing.Size(101, 26);
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(100, 22);
            this.menuLoad.Text = "上传";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "computer.gif");
            this.imgList.Images.SetKeyName(1, "drive.gif");
            this.imgList.Images.SetKeyName(2, "folder.ico");
            this.imgList.Images.SetKeyName(3, "file.ico");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWelcome,
            this.toolStripProgressBar1,
            this.lblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(76, 17);
            this.lblWelcome.Text = "欢迎使用……";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // menuRightKey
            // 
            this.menuRightKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveAs,
            this.menuDelete});
            this.menuRightKey.Name = "menuRightKey";
            this.menuRightKey.Size = new System.Drawing.Size(122, 48);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(121, 22);
            this.menuSaveAs.Text = "另存为...";
            this.menuSaveAs.Click += new System.EventHandler(this.MenuSaveAs_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(121, 22);
            this.menuDelete.Text = "删除";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spCtrlOuter);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.spCtrlOuter.Panel1.ResumeLayout(false);
            this.spCtrlOuter.Panel1.PerformLayout();
            this.spCtrlOuter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCtrlOuter)).EndInit();
            this.spCtrlOuter.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.spCtrlContent.Panel1.ResumeLayout(false);
            this.spCtrlContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCtrlContent)).EndInit();
            this.spCtrlContent.ResumeLayout(false);
            this.menuLocal.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuRightKey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spCtrlOuter;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcome;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.SplitContainer spCtrlContent;
        private System.Windows.Forms.FlowLayoutPanel flowPnlLeft;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tbtnPre;
        private System.Windows.Forms.ContextMenuStrip menuRightKey;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.TreeView treeLocal;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ContextMenuStrip menuLocal;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
    }
}

