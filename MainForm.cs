using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpClient
{
    public partial class MainForm : Form
    {
        private FtpHelper ftpHelper;

        private  DateTime clickTime;

        private bool isClicked = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region 初始化加载事件

        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void InitTreeView()
        {
            string[] drives = Environment.GetLogicalDrives();
            int i = 0;
            foreach (string drive in drives)
            {
                DriveInfo d = new DriveInfo(drive);
                if ((d.DriveType & DriveType.Fixed) == DriveType.Fixed)
                {
                    string drive1 = drive.Substring(0, drive.Length - 1);
                    this.treeLocal.Nodes[0].Nodes.Add(drive1);
                    this.treeLocal.Nodes[0].Nodes[i].ImageIndex = 1;
                    this.treeLocal.Nodes[0].Nodes[i].SelectedImageIndex = 1;
                    this.treeLocal.Nodes[0].Nodes[i].Tag = drive1;
                    this.treeLocal.Nodes[0].Nodes[i].Nodes.Add("");//增加一个空白节点，看起来是加号
                    i++;
                }
            }
        }

        #endregion

        #region 菜单栏及工具栏

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin_Click(null, null);
        }

        /// <summary>
        /// 前一个目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtnPre_Click(object sender, EventArgs e)
        {
            //如果就目录,先设置上级目录，再列出目录
            ftpHelper.SetPrePath();
            this.ListDirectory();
        }

        #endregion

        #region FTP操作功能

        /// <summary>
        /// 登录时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInfo())
                {
                    string ipAddr = this.txtAddress.Text.Trim();
                    string port = this.txtPort.Text.Trim();
                    string userName = this.txtUserName.Text.Trim();
                    string password = this.txtPassword.Text.Trim();
                    ftpHelper = new FtpHelper(ipAddr, port, userName, password);
                    ListDirectory();
                }
            }
            catch (Exception ex) {

            }
        }

        /// <summary>
        /// 判断输入信息
        /// </summary>
        /// <returns></returns>
        private bool CheckInfo()
        {
            string ipAddr = this.txtAddress.Text.Trim();
            string port = this.txtPort.Text.Trim();
            string userName = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(ipAddr) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入登录信息");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTmp_DoubleClick(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            FtpContentType contentType;
            if (Enum.TryParse(btnTmp.Tag.ToString(), out contentType)) {
                switch (contentType) {
                    case FtpContentType.folder:
                        //如果是目录
                        ftpHelper.RelatePath = string.Format("{0}/{1}", ftpHelper.RelatePath, btnTmp.Text);
                        this.ListDirectory();//再次列出目录
                        break;
                    default:
                        MessageBox.Show("非目录，请点击右键","提示",MessageBoxButtons.OK);
                        break;
                }
            }
        }

        /// <summary>
        /// 列出目录
        /// </summary>
        private void ListDirectory()
        {
            bool isOk = false;
            string[] arrAccept = ftpHelper.ListDirectory(out isOk);//调用Ftp目录显示功能
            if (isOk)
            {
                this.flowPnlLeft.Controls.Clear();
                foreach (string accept in arrAccept)
                {
                    string name = accept.Substring(39);
                    Button btnTmp = new Button()
                    {
                        BackColor = Color.White,
                        TextImageRelation = TextImageRelation.ImageAboveText,
                        Text = name,
                        Width = 80,
                        Height = 80
                    };
                    btnTmp.FlatAppearance.BorderSize = 0;
                    btnTmp.FlatStyle = FlatStyle.Flat;
                    if (accept.IndexOf("<DIR>") != -1)
                    {
                        btnTmp.Image = global::FtpClient.Properties.Resources.folder.ToBitmap();
                        btnTmp.Tag = FtpContentType.folder;
                    }
                    else {
                        btnTmp.Image = global::FtpClient.Properties.Resources.file.ToBitmap();
                        btnTmp.Tag = FtpContentType.file;
                        btnTmp.ContextMenuStrip = menuRightKey;
                        btnTmp.MouseDown += new MouseEventHandler(BtnTmp_MouseDown);
                    }
                    btnTmp.Click += new EventHandler(btnTmp_Click);//此处由于双击事件被屏蔽，所以用单击事件模拟双击
                    this.flowPnlLeft.Controls.Add(btnTmp);
                }
                lblMsg.Text = "列出目录成功";
            }
            else {
                ftpHelper.SetPrePath();
                lblMsg.Text = "链接失败，或者没有数据";
            }
        }

        private void BtnTmp_MouseDown(object sender, MouseEventArgs e)
        {
            //如果是右键按下
            if (e.Button == MouseButtons.Right)
            {
                Button btnTmp = (Button)sender;
                string name = btnTmp.Text;
                this.menuSaveAs.Tag = name;
                this.menuDelete.Tag = name;
            }
        }

        private void btnTmp_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                TimeSpan span = DateTime.Now - clickTime;
                if (span.Milliseconds < SystemInformation.DoubleClickTime)
                {
                    btnTmp_DoubleClick(sender, e);
                    isClicked = false;
                }
            }
            else
            {
                isClicked = true;
                clickTime = DateTime.Now;
            }
        }

        #endregion

        #region 树菜单事件

        /// <summary>
        /// 展开之前操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeLocal_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level > 0) {
                //点击之前，先填充节点：
                string path = e.Node.FullPath.Substring(e.Node.FullPath.IndexOf("\\")+1)+"\\";
                e.Node.Nodes.Clear();
                //string path = string.Format("{0}{1}",e.Node.Tag,this.treeLocal.PathSeparator);
                string[] files= Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
                int i = 0;
                foreach (string file in files) {
                    FileInfo f = new FileInfo(file);
                    if ((f.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden && (f.Attributes & FileAttributes.System) != FileAttributes.System)
                    {
                        e.Node.Nodes.Add(Path.GetFileName(file));
                        e.Node.Nodes[i].ImageIndex = 3;
                        e.Node.Nodes[i].SelectedImageIndex = 3;
                        e.Node.Nodes[i].Tag = file;
                        i++;
                    }
                }
                string[] dirs=  Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                foreach (string dir in dirs)
                {
                    DirectoryInfo d = new DirectoryInfo(dir);
                    if ((d.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden && (d.Attributes & FileAttributes.System) != FileAttributes.System)
                    {
                        e.Node.Nodes.Add(Path.GetFileName(dir));
                        e.Node.Nodes[i].ImageIndex = 2;
                        e.Node.Nodes[i].SelectedImageIndex = 2;
                        e.Node.Nodes[i].Tag = dir;
                        e.Node.Nodes[i].Nodes.Add("");//增加一个空白节点，看起来是加号
                        i++;
                    }
                }
            }
        }

        /// <summary>
        /// 选中后，右键事件判断，只有文件类型，右键才可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeLocal_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0 && e.Node.ImageIndex == 3)
            {
                this.menuLocal.Enabled = true;
                string path = e.Node.FullPath.Substring(e.Node.FullPath.IndexOf("\\") + 1);
                this.menuLoad.Tag = path;
            }
            else {
                this.menuLocal.Enabled = false;
            }
        }

        #endregion

        #region 右键事件


        /// <summary>
        /// 右键另存为按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSaveAs_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string name = menuItem.Tag.ToString();
            SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = name,
                Filter="All Files|(*.*)",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title="另存为"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //下载文件
                string filePath = sfd.FileName;
                string fileName = Path.GetFileName(filePath);
                ftpHelper.RelatePath = string.Format("{0}/{1}", ftpHelper.RelatePath, fileName);
                bool isOk = false;
                ftpHelper.DownLoad(filePath, out isOk);
                if (isOk)
                {
                    lblMsg.Text = "下载成功";
                }
                else {
                    lblMsg.Text = "下载失败";
                }
                ftpHelper.SetPrePath();
            }
        }

        /// <summary>
        /// 右键删除功能FTP上的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDelete_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string name = menuItem.Tag.ToString();
            ftpHelper.RelatePath = string.Format("{0}/{1}", ftpHelper.RelatePath, name);
            bool isOk = false;
            ftpHelper.DeleteFile(out isOk);
            ftpHelper.SetPrePath();
            if (isOk)
            {
                this.ListDirectory();
                lblMsg.Text = "删除成功";
            }
            else {
                lblMsg.Text = "删除失败";
            }

        }
    
        /// <summary>
        /// 本地文件上传事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLoad_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            string path = mi.Tag.ToString();
            if (File.Exists(path)) {
                ftpHelper.RelatePath = string.Format("{0}/{1}", ftpHelper.RelatePath, Path.GetFileName(path));
                bool isOk = false;
                ftpHelper.UpLoad(path,out isOk);
                ftpHelper.SetPrePath();
                if (isOk)
                {
                    this.ListDirectory();
                    lblMsg.Text = "上传成功";
                }
                else {
                    lblMsg.Text = "上传失败";
                }
            }
        }

        #endregion
    }
}
