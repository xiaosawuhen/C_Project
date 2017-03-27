using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordControl
{
    public partial class main_form : Form
    {
        Config config = null;
        private string basePath = "config\\base.xml";

        private WordStore wordStore = null;
        private string file = null;

        public main_form()
        {
            InitializeComponent();

            wordListMenuControl = new WordListMenuControl();
            config = ConfigIO.getConfig(basePath);
            loadWordInfo(config.WordPath);

            this.learn_book_text.ShowSelectionMargin = true;
            this.learn_book_text.MouseUp += learn_example_text_MouseUp;

            learn_book_text.Text = File.ReadAllText("config\\book.txt");

            //config = new Config();
            //config.WelcomePath = "config\\welcome\\";
            //config.WordPath = "config\\word\\";
            //ConfigIO.setConfig(config, basePath);
        }

        void learn_example_text_MouseUp(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;

            if (rtb.SelectionLength > 0)
            {
                Word word = wordStore.getWord(rtb.SelectedText);
                if (word != null)
                {
                    rtb.Select(rtb.SelectionStart, rtb.SelectionLength);
                    rtb.SelectionColor = Color.Blue;
                    rtb.SelectionFont = new Font("宋体", 12, (FontStyle.Bold));
                    resetWordInfo(word);
                }
            }

            rtb.Select(rtb.SelectionStart + rtb.SelectionLength, 0);
            rtb.SelectionColor = Color.Black;
            rtb.SelectionFont = new Font("宋体", 12, (FontStyle.Regular));
        }

        public TabPage getTabPage()
        {
            return this.learnTab;
        }

        public void loadWordInfo(string filePath)
        {
            file = filePath + "Word.xml";
            bool fileExist = File.Exists(file);

            if (fileExist)
            {
                wordStore = WordIO.getWordInfo(file);
                fillWordListView(wordStore);
                Word word = wordStore.getFirstWord();

                resetWordInfo(word);
            }
            else
            {
                WordIO.setWordInfo(new WordStore(), file);
            }
        }

        private void learnExampleTextKeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;

            //rtb.Select(i - s.Length, s.Length);
            rtb.SelectionColor = Color.Red;
            //是否改变字体
            rtb.SelectionFont = new Font("宋体", 12, (FontStyle.Bold));

            //以下是把光标放到原来位置，并把光标后输入的文字重置
        }

        private void fillWordListView(WordStore wordStore)
        {
            learn_word_list.Nodes.Clear();
            int wordCount = wordStore.getWordCount();

            TreeNode headNode = createTreeNode("", "単語");
            for (int i = 0; i < wordCount; i++)
            {
                Word word = wordStore.getWord(i);

                TreeNode treeNode = createTreeNode(word,i);
                headNode.Nodes.Add(treeNode);

            }

            learn_word_list.Nodes.Add(headNode);
            learn_word_list.ExpandAll();
        }

        private TreeNode createTreeNode(Word word, int index)
        {
            return createTreeNode(index.ToString(), word.JpWord);
        }

        private TreeNode createTreeNode(string name, string text)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Name = name;
            treeNode.Text = text;

            return treeNode;
        }

        private void learn_menu_modify_Click(object sender, EventArgs e)
        {
            Word word = wordStore.getCurrentWord();
            fillWordInfo(word);
            WordIO.setWordInfo(wordStore, file);
            loadWordInfo(config.WordPath);
        }

        private void learn_menu_add_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            fillWordInfo(word);
            wordStore.addWord(word);
            WordIO.setWordInfo(wordStore, file);
            loadWordInfo(config.WordPath);
        }

        private void learn_menu_delete_Click(object sender, EventArgs e)
        {
            wordStore.deleteCurrentWord();
            WordIO.setWordInfo(wordStore, file);
            loadWordInfo(config.WordPath);
        }

        private void learn_menu_next_Click(object sender, EventArgs e)
        {
            Word word = wordStore.getNextWord();

            resetWordInfo(word);
        }

        private void learn_menu_pre_Click(object sender, EventArgs e)
        {
            Word word = wordStore.getPreWord();

            resetWordInfo(word);
        }

        private void learn_menu_random_Click(object sender, EventArgs e)
        {
            Word word = wordStore.getRandomWord();

            resetWordInfo(word);
        }

        private void resetWordInfo(Word word)
        {
            if (word == null)
                return;

            List<string> exampleList = word.Example;
            this.learn_example_text.Text = "";
            foreach (string example in exampleList)
            {
                this.learn_example_text.Text += example + "\r\n";
            }

            this.learn_jp_word_text.Text = word.JpWord;
            this.learn_jp2_word_text.Text = word.Jp2Word;
            this.learn_ch_word_text.Text = word.CnWord;
        }

        private void fillWordInfo(Word word)
        {
            List<string> exampleList = new List<string>();

            string[] examples = this.learn_example_text.Text.Split('\n'); ;
            foreach (string example in examples)
            {
                exampleList.Add(example.Replace("\r", ""));
            }

            word.Example = exampleList;
            word.JpWord = this.learn_jp_word_text.Text;
            word.Jp2Word = this.learn_jp2_word_text.Text;
            word.CnWord = this.learn_ch_word_text.Text;
        }

        private WordListMenuControl wordListMenuControl = null;

        private void learn_word_list_MouseDown(object sender, MouseEventArgs e)
        {
            learn_word_list.ContextMenuStrip = null;
            if(e.Button == MouseButtons.Right)
            {
                Point point = learn_word_list.PointToClient(Control.MousePosition);
                TreeNode treeNode = learn_word_list.GetNodeAt(point.X, point.Y);
                if (treeNode != null)
                {
                    learn_word_list.SelectedNode = treeNode;

                    learn_word_list.ContextMenuStrip = createContextMenuStrip();
                }
            }
        }

        public ToolStripMenuItem createToolItem(string name, string text)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.BackColor = System.Drawing.Color.WhiteSmoke;
            item.Name = name;
            item.Size = new System.Drawing.Size(44, 22);
            item.Text = text;

            if (text.ToUpper().Equals("SHOW"))
            {
                item.Click += new EventHandler(show_menu_Click);
            }
            else if (text.ToUpper().Equals("DELETE"))
            {
                item.Click += new EventHandler(delete_menu_Click);
            }

            return item;
        }

        private void show_menu_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = learn_word_list.SelectedNode;
            Word word = wordStore.getWord(int.Parse(treeNode.Name));
            resetWordInfo(word);
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = learn_word_list.SelectedNode;
            Word word = wordStore.getWord(int.Parse(treeNode.Name));
            wordStore.deleteCurrentWord();
            WordIO.setWordInfo(wordStore, file);
            loadWordInfo(config.WordPath);
        }

        public ContextMenuStrip createContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            contextMenuStrip.Size = new System.Drawing.Size(44, 22);

            contextMenuStrip.Items.Add(createToolItem("Show", "Show"));
            contextMenuStrip.Items.Add(createToolItem("Delete", "Delete"));
            return contextMenuStrip;
        }

        private void bookStore_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\book.txt", learn_book_text.Text);
        }
    }
}
