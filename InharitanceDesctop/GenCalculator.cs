using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InharitanceDesctop.Classes;

namespace InharitanceDesctop
{
    public partial class GenCalculator : Form
    {
        private List<Gene> Genes = new List<Gene>();

        public GenCalculator()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gene = new Gene()
            {
                Name = textBox1.Text,
                DominanteAllele = textBox2.Text,
                DominanteSymbol = textBox3.Text,
                RecessiveAllele = textBox5.Text,
                RecessiveSymbol = textBox4.Text
            };
            if (Genes.Any(x => x.DominanteSymbol == gene.DominanteSymbol))
                return;
            Genes.Add(gene);
            treeView1.Nodes.Add(gene.Name, gene.Name).Nodes
                .Add(gene.DominanteAllele, gene.DominanteSymbol + " - " + gene.DominanteAllele).Parent.Nodes
                .Add(gene.RecessiveAllele, gene.RecessiveSymbol + " - " + gene.RecessiveAllele);
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var woman = textBox6.Text;
            var man = textBox7.Text;

            SetGridPannet(GetGamet(woman), GetGamet(man));
            //  dataGridView1.RowHeadersVisible = true;
        }

        public List<string> GetGamet(string str)
        {
            string s = null;
            for (var i = 0; i < str.Length; i++)
            {
                var flag = false;
                for (var j = i + 1; j < str.Length; j++)
                    if (str[i] == str[j])
                    {
                        flag = true;
                        break;
                    }
                if (!flag)
                    s += str[i].ToString();
            }
            var res = new List<string>();

            var S = s.ToUpper();
            for (var i = 0; i < s.Length; i++)
            for (var j = i + 1; j < s.Length; j++)
                if (S[i] != S[j])
                    res.Add(s[i] + s[j].ToString());
            //   res.Add(s[i]);
            return res;
        }

        public void SetGridPannet(List<string> women, List<string> man)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("type", @"woman\man");

            foreach (var m in man)
                dataGridView1.Columns.Add(m, m);

            var index = 0;
            foreach (var w in women)
            {
                index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = w;
                var j = 1;
                foreach (var m in man)
                {
                    var str = m + w;


                    dataGridView1.Rows[index].Cells[j].Value = Sort(str);
                    j++;
                }
            }
            GetGenotype();
            // textBox8.Text
        }

        public string Sort(string str)
        {
            var c = str.ToArray();
            var s = new string[c.Length];
            for (var i = 0; i < c.Length; i++)
                s[i] = c[i].ToString();
            IComparer rev = new ReverseComparer();
            Array.Sort(s, rev);
            str = "";
            for (var i = 0; i < c.Length; i++)
                str += s[i];
            return str;
        }

        public void GetGenotype()
        {
            var res = new List<string>();
            for (var i = 1; i < dataGridView1.ColumnCount; i++)
            for (var j = 0; j < dataGridView1.RowCount; j++)
                res.Add(dataGridView1.Rows[j].Cells[i].Value.ToString());


            foreach (var gen in Genes)
            {
                float countD = 0;
                float countR = 0;
                var strD = "(";
                var strR = "(";
                foreach (var r in res)
                {
                   
                    if (r.Contains(gen.DominanteSymbol))
                    {
                        strD += r + ",";
                        countD++;
                    }
                    else
                    {
                        if (r.Contains(gen.RecessiveSymbol + gen.RecessiveSymbol))
                        {
                            strR += r + ",";
                            countR++;
                        }
                    }
                }
                if (radioButton1.Checked)
                {
                    textBox8.Text += gen.Name + ":" + Environment.NewLine;
                    textBox8.Text += gen.DominanteAllele + " = " + (countD / res.Count) * 100 + "%" +
                                     Environment.NewLine;
                    textBox8.Text += gen.RecessiveAllele + " = " + (countR / res.Count) * 100 + "%" +
                                     Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        textBox8.Text += gen.Name + ":" + Environment.NewLine;
                        textBox8.Text += strD + ") - " + (countD / res.Count) * 100 + "%" +
                                         Environment.NewLine;
                        textBox8.Text += strR + ") - " + (countR / res.Count) * 100 + "%" +
                                         Environment.NewLine + Environment.NewLine;
                    }
                }
                
            }
        }

        public class ReverseComparer : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            public int Compare(object x, object y)
            {
                return new CaseInsensitiveComparer().Compare(x, y);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var woman = textBox6.Text;
            var man = textBox7.Text;
            textBox8.Text = "";
            SetGridPannet(GetGamet(woman), GetGamet(man));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var woman = textBox6.Text;
            var man = textBox7.Text;
            textBox8.Text = "";
            SetGridPannet(GetGamet(woman), GetGamet(man));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}