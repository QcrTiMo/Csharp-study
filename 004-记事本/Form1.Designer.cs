namespace _004_记事本
{
    partial class mainview
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
            menu = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            menuFileNewView = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuFileSaveAs = new ToolStripMenuItem();
            menuFileSetting = new ToolStripMenuItem();
            menuFilePrint = new ToolStripMenuItem();
            menuFileExit = new ToolStripMenuItem();
            menuFileEdit = new ToolStripMenuItem();
            menuFileZ = new ToolStripMenuItem();
            menuFileX = new ToolStripMenuItem();
            menuFileC = new ToolStripMenuItem();
            menuFileV = new ToolStripMenuItem();
            menuFileD = new ToolStripMenuItem();
            menuFileF = new ToolStripMenuItem();
            menuFileF3 = new ToolStripMenuItem();
            menuFileSF3 = new ToolStripMenuItem();
            menuFileH = new ToolStripMenuItem();
            menuFileG = new ToolStripMenuItem();
            menuFileA = new ToolStripMenuItem();
            menuFileF5 = new ToolStripMenuItem();
            menuFormatFont = new ToolStripMenuItem();
            menuFileCheck = new ToolStripMenuItem();
            zoom = new ToolStripMenuItem();
            large = new ToolStripMenuItem();
            small = new ToolStripMenuItem();
            back_to_default = new ToolStripMenuItem();
            status_bar = new ToolStripMenuItem();
            AutoLM = new ToolStripMenuItem();
            txtEditor = new TextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuFile, menuFileEdit, menuFileCheck, toolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(907, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menu_ItemClicked;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, menuFileNewView, menuFileOpen, menuFileSave, menuFileSaveAs, menuFileSetting, menuFilePrint, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(53, 24);
            menuFile.Text = "文件";
            menuFile.Click += menuFile_Click;
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.Size = new Size(265, 26);
            menuFileNew.Text = "新建            Ctrl+N";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // menuFileNewView
            // 
            menuFileNewView.Name = "menuFileNewView";
            menuFileNewView.Size = new Size(265, 26);
            menuFileNewView.Text = "新建窗口     Ctrl+Shift+N";
            menuFileNewView.Click += menuFileNewView_Click;
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(265, 26);
            menuFileOpen.Text = "打开             Ctrl+O";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(265, 26);
            menuFileSave.Text = "保存             Ctrl+S";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuFileSaveAs
            // 
            menuFileSaveAs.Name = "menuFileSaveAs";
            menuFileSaveAs.Size = new Size(265, 26);
            menuFileSaveAs.Text = "另存为         Ctrl+Shift+S";
            menuFileSaveAs.Click += menuFileSaveAs_Click;
            // 
            // menuFileSetting
            // 
            menuFileSetting.Name = "menuFileSetting";
            menuFileSetting.Size = new Size(265, 26);
            menuFileSetting.Text = "页面设置";
            menuFileSetting.Click += menuFileSetting_Click;
            // 
            // menuFilePrint
            // 
            menuFilePrint.Name = "menuFilePrint";
            menuFilePrint.Size = new Size(265, 26);
            menuFilePrint.Text = "打印             Ctrl+P";
            menuFilePrint.Click += menuFilePrint_Click;
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.Size = new Size(265, 26);
            menuFileExit.Text = "退出";
            menuFileExit.Click += 退出ToolStripMenuItem_Click;
            // 
            // menuFileEdit
            // 
            menuFileEdit.DropDownItems.AddRange(new ToolStripItem[] { menuFileZ, menuFileX, menuFileC, menuFileV, menuFileD, menuFileF, menuFileF3, menuFileSF3, menuFileH, menuFileG, menuFileA, menuFileF5, menuFormatFont });
            menuFileEdit.Name = "menuFileEdit";
            menuFileEdit.Size = new Size(53, 24);
            menuFileEdit.Text = "编辑";
            menuFileEdit.Click += menuFileEdit_Click;
            // 
            // menuFileZ
            // 
            menuFileZ.Name = "menuFileZ";
            menuFileZ.Size = new Size(260, 26);
            menuFileZ.Text = "撤销                    Ctrl+Z";
            menuFileZ.Click += 撤销ToolStripMenuItem_Click;
            // 
            // menuFileX
            // 
            menuFileX.Name = "menuFileX";
            menuFileX.Size = new Size(260, 26);
            menuFileX.Text = "剪切                    Ctrl+X";
            menuFileX.Click += menuFileX_Click;
            // 
            // menuFileC
            // 
            menuFileC.Name = "menuFileC";
            menuFileC.Size = new Size(260, 26);
            menuFileC.Text = "复制                    Ctrl+C";
            menuFileC.Click += menuFileC_Click;
            // 
            // menuFileV
            // 
            menuFileV.Name = "menuFileV";
            menuFileV.Size = new Size(260, 26);
            menuFileV.Text = "黏贴                    Ctrl+V";
            menuFileV.Click += menuFileV_Click;
            // 
            // menuFileD
            // 
            menuFileD.Name = "menuFileD";
            menuFileD.Size = new Size(260, 26);
            menuFileD.Text = "删除                    Del";
            menuFileD.Click += menuFileD_Click;
            // 
            // menuFileF
            // 
            menuFileF.Name = "menuFileF";
            menuFileF.Size = new Size(260, 26);
            menuFileF.Text = "查找                    Ctrl+F";
            menuFileF.Click += menuFileF_Click;
            // 
            // menuFileF3
            // 
            menuFileF3.Name = "menuFileF3";
            menuFileF3.Size = new Size(260, 26);
            menuFileF3.Text = "查找下一个         F3";
            menuFileF3.Click += menuFileF3_Click;
            // 
            // menuFileSF3
            // 
            menuFileSF3.Name = "menuFileSF3";
            menuFileSF3.Size = new Size(260, 26);
            menuFileSF3.Text = "查找上一个        Shift+F3";
            menuFileSF3.Click += menuFileSF3_Click;
            // 
            // menuFileH
            // 
            menuFileH.Name = "menuFileH";
            menuFileH.Size = new Size(260, 26);
            menuFileH.Text = "替换                    Ctrl+H";
            menuFileH.Click += menuFileH_Click;
            // 
            // menuFileG
            // 
            menuFileG.Name = "menuFileG";
            menuFileG.Size = new Size(260, 26);
            menuFileG.Text = "转到                    Ctrl+G";
            menuFileG.Click += menuFileG_Click;
            // 
            // menuFileA
            // 
            menuFileA.Name = "menuFileA";
            menuFileA.Size = new Size(260, 26);
            menuFileA.Text = "全选                    Ctrl+A";
            menuFileA.Click += menuFileA_Click;
            // 
            // menuFileF5
            // 
            menuFileF5.Name = "menuFileF5";
            menuFileF5.Size = new Size(260, 26);
            menuFileF5.Text = "时间/日期           F5";
            menuFileF5.Click += menuFileF5_Click;
            // 
            // menuFormatFont
            // 
            menuFormatFont.Name = "menuFormatFont";
            menuFormatFont.Size = new Size(260, 26);
            menuFormatFont.Text = "字体";
            menuFormatFont.Click += menuFormatFont_Click;
            // 
            // menuFileCheck
            // 
            menuFileCheck.DropDownItems.AddRange(new ToolStripItem[] { zoom, status_bar, AutoLM });
            menuFileCheck.Name = "menuFileCheck";
            menuFileCheck.Size = new Size(53, 24);
            menuFileCheck.Text = "查看";
            menuFileCheck.Click += menuFileCheck_Click;
            // 
            // zoom
            // 
            zoom.DropDownItems.AddRange(new ToolStripItem[] { large, small, back_to_default });
            zoom.Name = "zoom";
            zoom.Size = new Size(224, 26);
            zoom.Text = "缩放";
            zoom.Click += zoom_Click;
            // 
            // large
            // 
            large.Name = "large";
            large.Size = new Size(281, 26);
            large.Text = "放大                       Ctrl+加号";
            large.Click += large_Click;
            // 
            // small
            // 
            small.Name = "small";
            small.Size = new Size(281, 26);
            small.Text = "缩小                       Ctrl+减号";
            small.Click += 缩小ToolStripMenuItem_Click;
            // 
            // back_to_default
            // 
            back_to_default.Name = "back_to_default";
            back_to_default.Size = new Size(281, 26);
            back_to_default.Text = "还原默认缩放        Ctrl+0";
            back_to_default.Click += back_to_default_Click;
            // 
            // status_bar
            // 
            status_bar.Name = "status_bar";
            status_bar.Size = new Size(224, 26);
            status_bar.Text = "状态栏";
            status_bar.Click += status_bar_Click;
            // 
            // AutoLM
            // 
            AutoLM.Name = "AutoLM";
            AutoLM.Size = new Size(224, 26);
            AutoLM.Text = "自动换行";
            AutoLM.Click += AutoLM_Click;
            // 
            // txtEditor
            // 
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Location = new Point(0, 28);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.Size = new Size(907, 581);
            txtEditor.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(27, 24);
            toolStripMenuItem1.Text = " ";
            // 
            // mainview
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 609);
            Controls.Add(txtEditor);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "mainview";
            Text = "简单记事本";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileNew;
        private ToolStripMenuItem menuFileNewView;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileSaveAs;
        private ToolStripMenuItem menuFileSetting;
        private ToolStripMenuItem menuFilePrint;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem menuFileEdit;
        private ToolStripMenuItem menuFileCheck;
        private ToolStripMenuItem zoom;
        private ToolStripMenuItem large;
        private ToolStripMenuItem small;
        private ToolStripMenuItem back_to_default;
        private ToolStripMenuItem status_bar;
        private ToolStripMenuItem AutoLM;
        private ToolStripMenuItem menuFileZ;
        private ToolStripMenuItem menuFileX;
        private ToolStripMenuItem menuFileC;
        private ToolStripMenuItem menuFileV;
        private ToolStripMenuItem menuFileD;
        private ToolStripMenuItem menuFileF;
        private ToolStripMenuItem menuFileF3;
        private ToolStripMenuItem menuFileSF3;
        private ToolStripMenuItem menuFileH;
        private ToolStripMenuItem menuFileG;
        private ToolStripMenuItem menuFileA;
        private ToolStripMenuItem menuFileF5;
        private ToolStripMenuItem menuFormatFont;
        private TextBox txtEditor;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
