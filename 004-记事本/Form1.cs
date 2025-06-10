using System;
using System.IO;
using System.Windows.Forms;

namespace _004_记事本
{
    public partial class mainview : Form
    {
        private String currentFilePath = null;  //用于存储当前打开文件路径
        private bool textChanged = false;  //用于标记文本是否被修改过
        public mainview()
        {
            //可以在这里初始化，比如窗口标题
            InitializeComponent();
            UpdateTitle();
            //监听文本框内容变化
            txtEditor.TextChanged += TxtEditor_TextChanged;
        }

        private void TxtEditor_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;  //当文本框内容变化时，设置标记为true
            UpdateTitle();  //更新窗口标题
        }

        private void UpdateTitle()
        {
            String fileName = String.IsNullOrEmpty(currentFilePath) ? "无标题" : Path.GetFileName(currentFilePath);
            this.Text = fileName + (textChanged ? "*" : "") + "- 记事本";
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.CanUndo)
            {
                txtEditor.Undo();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //TODO
        }

        private void status_bar_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void AutoLM_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            if (SaveChangesIfNecessary() == DialogResult.Cancel)
            {
                return;  //如果用户选择取消，则不执行新建操作
            }
            txtEditor.Clear();  //清空文本框内容
            currentFilePath = null;  //重置当前文件路径
            textChanged = false;  //重置文本修改标记
            UpdateTitle();  //更新窗口标题
        }

        private void menuFileNewView_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if (SaveChangesIfNecessary() == DialogResult.Cancel)
            {
                return;  //如果用户选择取消，则不执行新建操作
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文档 (*.txt)|*.txt|所有文件 (*.*)|*.*";  //设置文件类型过滤器
            openFileDialog.Title = "打开文件";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = openFileDialog.FileName;
                    txtEditor.Text = File.ReadAllText(currentFilePath);  //读取文件内容到文本框
                    textChanged = false;  //重置文本修改标记
                    UpdateTitle();  //更新窗口标题
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                return SaveFileAs(); //如果没有路径，则调用另存为
            }
            else
            {
                try
                {
                    File.WriteAllText(currentFilePath, txtEditor.Text);
                    textChanged = false;
                    UpdateTitle();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存文件失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文档 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            saveFileDialog.Title = "另存为";
            saveFileDialog.DefaultExt = "txt";  //默认扩展名
            saveFileDialog.AddExtension = true;  //自动添加扩展名

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                return SaveFile();  //调用 SaveFile 来实际保存
            }
            return false;  //用户取消了另存为
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private DialogResult SaveChangesIfNecessary()
        {
            if (textChanged)
            {
                DialogResult result = MessageBox.Show(
                    $"是否要将更改保存到 {(string.IsNullOrEmpty(currentFilePath) ? "无标题" : Path.GetFileName(currentFilePath))}?",
                    "简单记事本",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (!SaveFile())  //如果保存失败 
                    {
                        return DialogResult.Cancel;  //阻止后续操作
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return DialogResult.Cancel;
                }
                //如果是 No，则不保存，继续执行后续操作
            }
            return DialogResult.OK;  //表示操作可以继续 (要么没改，要么已保存/不保存)
        }

        private void menuFileSetting_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFile_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileEdit_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileX_Click(object sender, EventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                txtEditor.Cut();
            }
        }

        private void menuFileC_Click(object sender, EventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                txtEditor.Copy();
            }
        }

        private void menuFileV_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtEditor.Paste();
            }
        }

        private void menuFileD_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileF_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileF3_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileSF3_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileG_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileA_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileF5_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = txtEditor.Font;  //将当前字体设为对话框的默认字体
            fontDialog.ShowColor = true; 

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void menuFileCheck_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void zoom_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void large_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void back_to_default_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void menuFileH_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void mainview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveChangesIfNecessary() == DialogResult.Cancel)
            {
                e.Cancel = true;  //取消关闭操作
            }
        }
    }
}
