namespace TreeView
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Luu bi");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Vua", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quan Vu");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Truong Phi");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Trieu Tu Long");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hoang Trung");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ma Sieu");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tuong", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gia cat luong");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tu Thu");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Bang Thong");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Muu Si", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Thuc", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode8,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Tao Thao");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Vua", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Truong Cap");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Truong Lieu");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Nhac Tien");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Vu Cam");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tu Hoang");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Tuong", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Quach Gia");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Tu Ma Y");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Muu si", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Nguy", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode21,
            treeNode24});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvDuLieu = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMoRong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuGom = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValue = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDuLieu
            // 
            this.tvDuLieu.ContextMenuStrip = this.contextMenuStrip1;
            this.tvDuLieu.ImageIndex = 4;
            this.tvDuLieu.ImageList = this.imageList1;
            this.tvDuLieu.Location = new System.Drawing.Point(117, 72);
            this.tvDuLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvDuLieu.Name = "tvDuLieu";
            treeNode1.Name = "Node5";
            treeNode1.Text = "Luu bi";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Vua";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Quan Vu";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Truong Phi";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Trieu Tu Long";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Hoang Trung";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Ma Sieu";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Tuong";
            treeNode9.Name = "Node14";
            treeNode9.Text = "Gia cat luong";
            treeNode10.Name = "Node15";
            treeNode10.Text = "Tu Thu";
            treeNode11.Name = "Node16";
            treeNode11.Text = "Bang Thong";
            treeNode12.Name = "Node13";
            treeNode12.Text = "Muu Si";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Thuc";
            treeNode14.Name = "Node19";
            treeNode14.Text = "Tao Thao";
            treeNode15.Name = "Node18";
            treeNode15.Text = "Vua";
            treeNode16.Name = "Node21";
            treeNode16.Text = "Truong Cap";
            treeNode17.Name = "Node22";
            treeNode17.Text = "Truong Lieu";
            treeNode18.Name = "Node23";
            treeNode18.Text = "Nhac Tien";
            treeNode19.Name = "Node24";
            treeNode19.Text = "Vu Cam";
            treeNode20.Name = "Node25";
            treeNode20.Text = "Tu Hoang";
            treeNode21.Name = "Node20";
            treeNode21.Text = "Tuong";
            treeNode22.Name = "Node27";
            treeNode22.Text = "Quach Gia";
            treeNode23.Name = "Node28";
            treeNode23.Text = "Tu Ma Y";
            treeNode24.Name = "Node26";
            treeNode24.Text = "Muu si";
            treeNode25.Name = "Node17";
            treeNode25.Text = "Nguy";
            this.tvDuLieu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode25});
            this.tvDuLieu.SelectedImageIndex = 2;
            this.tvDuLieu.Size = new System.Drawing.Size(349, 321);
            this.tvDuLieu.TabIndex = 0;
            this.tvDuLieu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDuLieu_AfterSelect);
            this.tvDuLieu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDuLieu_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNut,
            this.mnuSuaNut,
            this.mnuXoaNut,
            this.toolStripMenuItem1,
            this.mnuMoRong,
            this.mnuThuGom});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 130);
            // 
            // mnuThemNut
            // 
            this.mnuThemNut.Name = "mnuThemNut";
            this.mnuThemNut.Size = new System.Drawing.Size(143, 24);
            this.mnuThemNut.Text = "Them Nut";
            this.mnuThemNut.Click += new System.EventHandler(this.mnuThemNut_Click);
            // 
            // mnuSuaNut
            // 
            this.mnuSuaNut.Name = "mnuSuaNut";
            this.mnuSuaNut.Size = new System.Drawing.Size(143, 24);
            this.mnuSuaNut.Text = "Sua Nut";
            this.mnuSuaNut.Click += new System.EventHandler(this.mnuSuaNut_Click);
            // 
            // mnuXoaNut
            // 
            this.mnuXoaNut.Name = "mnuXoaNut";
            this.mnuXoaNut.Size = new System.Drawing.Size(143, 24);
            this.mnuXoaNut.Text = "Xoa Nut";
            this.mnuXoaNut.Click += new System.EventHandler(this.mnuXoaNut_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // mnuMoRong
            // 
            this.mnuMoRong.Name = "mnuMoRong";
            this.mnuMoRong.Size = new System.Drawing.Size(143, 24);
            this.mnuMoRong.Text = "Mo rong";
            this.mnuMoRong.Click += new System.EventHandler(this.mnuMoRong_Click);
            // 
            // mnuThuGom
            // 
            this.mnuThuGom.Name = "mnuThuGom";
            this.mnuThuGom.Size = new System.Drawing.Size(143, 24);
            this.mnuThuGom.Text = "Thu gom";
            this.mnuThuGom.Click += new System.EventHandler(this.mnuThuGom_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(560, 72);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(64, 25);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add2.png");
            this.imageList1.Images.SetKeyName(1, "addProject.png");
            this.imageList1.Images.SetKeyName(2, "exit.png");
            this.imageList1.Images.SetKeyName(3, "new.png");
            this.imageList1.Images.SetKeyName(4, "open.png");
            this.imageList1.Images.SetKeyName(5, "open2.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tvDuLieu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDuLieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNut;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNut;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaNut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuMoRong;
        private System.Windows.Forms.ToolStripMenuItem mnuThuGom;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ImageList imageList1;
    }
}

