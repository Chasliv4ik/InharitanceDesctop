using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InharitanceDesctop.Classes;

namespace InharitanceDesctop
{
    public partial class GenotypeForm : Form
    {
        private string[] Allel = new[] {"a", "b", "c", "d", "e", "f"};
        private int IndexAllel = 0;

        public List<Gene> Genes = new List<Gene>();
        public Dictionary<ComboBox, Gene> WomanGene = new Dictionary<ComboBox, Gene>();
        public Dictionary<Gene, string> WomanAllel = new Dictionary<Gene, string>();
        public Dictionary<Gene, string> ManAllel = new Dictionary<Gene, string>();
        public Dictionary<ComboBox, Gene> ManGene = new Dictionary<ComboBox, Gene>();

        public GenotypeForm()
        {
            InitializeComponent();
            DataBaseController db = new DataBaseController();
            Genes = db.GetGenes();
            Genes.ForEach(x => comboBox1.Items.Add(x.Name));
        }

        public void AddGene(int index)
        {
            Genes[index].DominanteSymbol = Allel[IndexAllel].ToUpper();
            Genes[index].RecessiveSymbol = Allel[IndexAllel];
            IndexAllel++;
            ComboBox w;
            tableLayaut.Controls.Add(w = new ComboBox()
            {

                Text = Genes[index].Name,
                Items =
                {
                    "Повне домінування " + Genes[index].DominanteAllele,
                    "Неповне домінування",
                    "Прояв " + Genes[index].RecessiveAllele
                },
                Margin = new Padding(25, 10, 3, 3),
                Size = new Size(290, 21),


            });
            w.SelectedIndexChanged += new EventHandler(SelectedWomanChange);
            WomanGene.Add(w, Genes[index]);
            ComboBox m;
            tableLayaut.Controls.Add(m = new ComboBox()
            {
                Text = Genes[index].Name,
                Items =
                {
                    "Повне домінування " + Genes[index].DominanteAllele,
                    "Неповне домінування",
                    "Прояв " + Genes[index].RecessiveAllele
                },
                Margin = new Padding(25, 10, 3, 3),
                Size = new Size(290, 21)
            });
            m.SelectedIndexChanged += new EventHandler(SelectedManChange);
            ManGene.Add(m, Genes[index]);

        }

        public void SelectedManChange(object sender, EventArgs e)
        {
            var m = sender as ComboBox;
            switch (m.SelectedIndex)
            {
                case 0:
                    ManAllel[ManGene[m]] = ManGene[m].DominanteSymbol + ManGene[m].DominanteSymbol;
                    break;
                case 1:
                    ManAllel[ManGene[m]] = ManGene[m].DominanteSymbol + ManGene[m].RecessiveSymbol;
                    break;
                case 2:
                    ManAllel[ManGene[m]] = ManGene[m].RecessiveSymbol + ManGene[m].RecessiveSymbol;
                    break;
            }

        }

        public void SelectedWomanChange(object sender, EventArgs e)
        {
            var w = sender as ComboBox;
            switch (w.SelectedIndex)
            {
                case 0:
                    WomanAllel[WomanGene[w]] = WomanGene[w].DominanteSymbol + WomanGene[w].DominanteSymbol;
                    break;
                case 1:
                    WomanAllel[WomanGene[w]] = WomanGene[w].DominanteSymbol + WomanGene[w].RecessiveSymbol;
                    break;
                case 2:
                    WomanAllel[WomanGene[w]] = WomanGene[w].RecessiveSymbol + WomanGene[w].RecessiveSymbol;
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items[comboBox1.SelectedIndex] != "Додано")
            AddGene(comboBox1.SelectedIndex);
            comboBox1.Items[comboBox1.SelectedIndex] = "Додано";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            string woman = "";
            string man = "";
            foreach (var womanAllelValue in WomanAllel.Values)
            {
                woman += womanAllelValue;
            }
            foreach (var m in ManAllel.Values)
            {
                man += m;
            }
            SetGridPannet(GetGamet(woman), GetGamet(man));
         
        }

        public  void SetGridPannet(List<string> women, List<string> man)
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
            // textBox.Text
        }
        public string Sort(string str)
        {
            var c = str.ToArray();
            var s = new string[c.Length];
            for (var i = 0; i < c.Length; i++)
                s[i] = c[i].ToString();
            IComparer rev = new GenCalculator.ReverseComparer();
            Array.Sort(s, rev);
            str = "";
            for (var i = 0; i < c.Length; i++)
                str += s[i];
            return str;
        }
        public void GetGenotype()
        {
            var res = new List<string>();
            try
            {
                for (var i = 1; i < dataGridView1.ColumnCount; i++)
                {
                    for (var j = 0; j < dataGridView1.RowCount; j++)
                        res.Add(dataGridView1.Rows[j].Cells[i].Value.ToString());
                }
            }
            catch
            {

            }

            foreach (var gen in WomanGene.Values)
            {
                float countD = 0;
                float countR = 0;
                float countN = 0;
                var strD = "(";
                var strR = "(";
                foreach (var r in res)
                {

                    if (r.Contains(gen.DominanteSymbol))
                    {
                        strD += r + ",";
                        countD++;
                    }
                   
                   
                        if (r.Contains(gen.RecessiveSymbol + gen.RecessiveSymbol))
                        {
                            strR += r + ",";
                            countR++;
                        }
                        else
                        {
                            if (r.Contains(gen.RecessiveSymbol))
                            {
                                countN++;
                            }
                        }
                    
                }

                textBox1.Text += gen.Name + ":" + Environment.NewLine;
                textBox1.Text += gen.DominanteAllele + " = " + (countD / res.Count) * 100 + "%" +
                                 Environment.NewLine;
                textBox1.Text += gen.RecessiveAllele + " = " + (countR / res.Count) * 100 + "%" +
                                 Environment.NewLine;
                textBox1.Text += "Носій "+gen.RecessiveAllele + " = " + (countN / res.Count) * 100 + "%" +
                                 Environment.NewLine+Environment.NewLine;

            }
        }
    }
}
