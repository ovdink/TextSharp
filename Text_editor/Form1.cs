using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Text_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "И", "ИЛИ" });
            comboBox1.SelectedIndex = 0;
            Cb2.Items.AddRange(new string[] { "И", "ИЛИ" });
            Cb2.SelectedIndex = 0;
            Cb1.Items.AddRange(new string[] { "И", "ИЛИ" });
            Cb1.SelectedIndex = 1;
            Cb3.Items.AddRange(new string[] { "И", "ИЛИ" });
            Cb3.SelectedIndex = 1;
        
            this.Text_read.Multiline = true;
            this.Text_read.WordWrap = false;
            this.Text_read.ScrollBars = System.Windows.Forms.ScrollBars.Both;

           
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            this.T2.TextChanged += new System.EventHandler(this.T1_TextChanged);
            this.T3.TextChanged += new System.EventHandler(this.T1_TextChanged);
            this.T4.TextChanged += new System.EventHandler(this.T1_TextChanged);
        }

        
        private List<string> Text_R;
        private List<string> Textbox_check()
        {
            List<string> Text_Textbox = new List<string>();
            foreach (Control ctrl in panel1.Controls)
                if (ctrl is TextBox)
                    Text_Textbox.Add(ctrl.Text);

            return Text_Textbox;
        }

        private void Read_text()
        {
            Text_R = new List<string>();
            for (int i = 0; i < Text_read.Lines.Count(); i++)
                Text_R.Add(Text_read.Lines[i]);

      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Read_text();
            Filters F = new Filters(Text_R);

            List<string> s = new List<string>();

            switch (Textbox_check())
            {
                case List<string> n when (n[3] !="" && n[1] == ""):
                    s = F.Two_filters("И", T1.Text.ToString());
                    break;
                case List<string> d when (d[3] != "" && d[1] != "" && d[2] == ""):
                    s = F.Two_filters(Cb1.Text, T1.Text.ToString(), T2.Text.ToString());
                    break;
                case List<string> m when (m[3] != "" && m[1] != "" && m[2] != "" && m[0] == ""):
                    s = F.Two_filters(Cb1.Text, T1.Text.ToString(), T2.Text.ToString());
                    Filters Fs =null;
                    if (Cb2.Text == "И")
                    {
                        Fs = new Filters(s);
                        s = Fs.Two_filters(Cb2.Text, T3.Text.ToString());
                    }
                    else if (Cb2.Text == "ИЛИ")
                    {
                        Fs = new Filters(Text_R);
                        var temp = Fs.Two_filters(Cb2.Text, T3.Text.ToString());
                        foreach (string d in temp)
                            s.Add(d);
                        s.Distinct();
                    }                 
                    break;          
                case List<string> m when (m[0] != "" && m[1] != "" && m[2] != "" && m[3] != ""):
                    s = F.Two_filters(Cb1.Text, T1.Text.ToString(), T2.Text.ToString());
                    Filters Fd = null;
                    if (Cb2.Text == "И")
                    {
                        Fs = new Filters(s);
                        s = Fs.Two_filters(Cb2.Text, T3.Text.ToString());
                    }
                    else if (Cb2.Text == "ИЛИ")
                    {
                        Fd = new Filters(Text_R);
                        var temp = Fd.Two_filters(Cb3.Text, T3.Text.ToString(), T4.Text.ToString());
                        foreach (string d in temp)
                            s.Add(d);
                        s.Distinct();
                    }
                   
                    break;
            }
        
            Text_read.Clear();
            foreach (string sss in s)
                Text_read.Text +=  sss+ Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";           
            openFileDialog.InitialDirectory = @"";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Text_read.Clear();
                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("iso-8859-15"));
                string str;
                
                while ((str = reader.ReadLine()) != null)              
                {
                    Text_read.Text += str + Environment.NewLine;
                }
                reader.Close();
            }
        }
        private void Text_read_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Text_read_DragDrop(object sender, DragEventArgs e)
        {
            StreamReader reader;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Text_read.Clear();
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string А in docPath)
                {
                    reader = new StreamReader(А, Encoding.GetEncoding("iso-8859-15"));
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Text_read.Text += str + Environment.NewLine;
                    }
                    reader.Close();
                }
            }
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            if (Text_R != null)
            {
                Text_read.Clear();
                foreach (string sss in Text_R)
                    Text_read.Text += sss + Environment.NewLine;
            }
        }

        private void Text_read_TextChanged(object sender, EventArgs e) {
            //
        }
    }
}
