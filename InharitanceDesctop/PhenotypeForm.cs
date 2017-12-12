using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InharitanceDesctop.Classes;

namespace InharitanceDesctop
{
    public partial class PhenotypeForm : Form
    {
        private Dictionary<int, bool> _attributs = new Dictionary<int, bool>()
        {
            {0,false},                                    //{false, "eyes"}, 
            {1,false},                                    //{false,"hair" },
            {2,false},                                    //{false,"height"},
            {3,false},                                    //{false,"ears"},
            {4,false},                               //{false,"features"},
            {5,false}                                   //{false, "nose" }
        };
        public Eyes EyesResult = new Eyes();
        public Height HeightResult = new Height();
        public Face FaceResult = new Face();
        public Nose NoseResult = new Nose();
        public Eyars EyarsResult = new Eyars();
        public Blood BloodResult = new Blood();
        private int _pageIndex = 0;
        public List<GroupBox> Pages = new List<GroupBox>();
        public PhenotypeForm()
        {
            InitializeComponent();
           Pages.Add(groupBox1);
            
     
        }

        public void NextPage()
        {
            int step = 1;
          

                _pageIndex++;
                if (_pageIndex - 1 < Pages.Count-1)
                {
                   if(_pageIndex == Pages.Count-1)
                     ViewResult();
                    int endpoint = Pages[_pageIndex - 1].Location.X - Pages[_pageIndex - 1].Size.Width-20;
                    while (Pages[_pageIndex - 1].Location.X > endpoint)
                    {
                        
                        Pages[_pageIndex - 1].Location = new Point(Pages[_pageIndex - 1].Location.X - step,
                            Pages[_pageIndex - 1].Location.Y);
                        Pages[_pageIndex].Location = new Point(Pages[_pageIndex].Location.X - step,
                            Pages[_pageIndex].Location.Y);
                        if(Pages[_pageIndex].Location.X%50 == 0)
                           Update();
                       
                    }
                }
                else
                {   ViewResult();
                    _pageIndex = Pages.Count-1;
                }
         
            
        }

        public void ViewResult()
        {
            textBox3.Text = "";
            if (EyesResult.EyesColor != null)
            {
                textBox3.Text += "Колір очей:" + Environment.NewLine;
                foreach (var e in EyesResult.EyesColor)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + Environment.NewLine;
                }
            }
            if (EyesResult.EyesSize != null)
            {
                textBox3.Text += "Розмір очей:" + Environment.NewLine;
                foreach (var e in EyesResult.EyesSize)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + Environment.NewLine;
                }
            }
            if (EyesResult.EyesSplit != null)
            {
                textBox3.Text += "Розріз очей:" + Environment.NewLine;
                foreach (var e in EyesResult.EyesSplit)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + Environment.NewLine;
                }
            }
            if (EyesResult.EyesType != null)
            {
                textBox3.Text += "Тип очей:" + Environment.NewLine;
                foreach (var e in EyesResult.EyesType)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + Environment.NewLine;
                }
            }
            if (BloodResult.BloodGroup != null)
            {
                textBox3.Text += "Група крові:" + Environment.NewLine;
                foreach (var e in BloodResult.BloodGroup)
                {
                    textBox3.Text +="  "+e.Key + " - " + e.Value + Environment.NewLine;
                }
            }
            if (BloodResult.ResusFactor != null)
            {
                textBox3.Text += "Резус фактор:" + Environment.NewLine;
                foreach (var e in BloodResult.ResusFactor)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value +"%" + Environment.NewLine;
                }
            }
            if (HeightResult.ManHeightH != 0)
            {
                textBox3.Text += "Зріст:" + Environment.NewLine;
                textBox3.Text += " Зріст за Хокером:" + Environment.NewLine;
                textBox3.Text += "  " +"Жінки - " +HeightResult.WomanHeightH+Environment.NewLine;
                textBox3.Text += "  " + "Чоловіка - " + HeightResult.ManHeightH+ Environment.NewLine;
                textBox3.Text += " Зріст за Каркусовим:" + Environment.NewLine;
                textBox3.Text += "  " + "Жінки - " + HeightResult.WomanHeightK + Environment.NewLine;
                textBox3.Text += "  " + "Чоловіка - " + HeightResult.ManHeightK + Environment.NewLine;

            }
            if (EyarsResult.EyarsType != null)
            {
                textBox3.Text += "Тип вух:" + Environment.NewLine;
                foreach (var e in EyarsResult.EyarsType)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value+"%"+ Environment.NewLine;
                }
            }
            if (EyarsResult.EyarsTip != null)
            {
                textBox3.Text += "Верхушка вух:" + Environment.NewLine;
                foreach (var e in EyarsResult.EyarsTip)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (EyarsResult.EyarsLobe != null)
            {
                textBox3.Text += "Мочка вух:" + Environment.NewLine;
                foreach (var e in EyarsResult.EyarsLobe)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceForm != null)
            {
                textBox3.Text += "Форма обличчя:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceForm)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceBrow != null)
            {
                textBox3.Text += "Брови:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceBrow)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceCheek != null)
            {
                textBox3.Text += "Ямочки на щоках:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceCheek)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceChin != null)
            {
                textBox3.Text += "Ямочки на підборідді:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceChin)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceCilia != null)
            {
                textBox3.Text += "Вії:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceCilia)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (FaceResult.FaceFreckles != null)
            {
                textBox3.Text += "Ластовиння:" + Environment.NewLine;
                foreach (var e in FaceResult.FaceFreckles)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (NoseResult.NoseForm != null)
            {
                textBox3.Text += "Форма носа:" + Environment.NewLine;
                foreach (var e in NoseResult.NoseForm)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (NoseResult.NoseNostris != null)
            {
                textBox3.Text += "Форма ніздрів:" + Environment.NewLine;
                foreach (var e in NoseResult.NoseNostris)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (NoseResult.NoseTip != null)
            {
                textBox3.Text += "Кінчик носа:" + Environment.NewLine;
                foreach (var e in NoseResult.NoseTip)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
                }
            }
            if (NoseResult.NoseBridge != null)
            {
                textBox3.Text += "Форма переносиці:" + Environment.NewLine;
                foreach (var e in NoseResult.NoseBridge)
                {
                    textBox3.Text += "  " + e.Key + " - " + e.Value + "%" + Environment.NewLine;
    
                }
            }
        }
        public void PrewPage()
        {
            int step = 1;
           
                _pageIndex--;
                if (_pageIndex >= 0)
                {

                    int endpoint = Pages[_pageIndex + 1].Location.X + Pages[_pageIndex + 1].Size.Width + 20;
                    while (Pages[_pageIndex + 1].Location.X < endpoint)
                    {

                        Pages[_pageIndex + 1].Location = new Point(Pages[_pageIndex + 1].Location.X + step,
                            Pages[_pageIndex + 1].Location.Y);
                        Pages[_pageIndex].Location = new Point(Pages[_pageIndex].Location.X + step,
                            Pages[_pageIndex].Location.Y);
                        if (Pages[_pageIndex].Location.X % 50 == 0)
                            Update();

                    }
                }
                else
                {
                    _pageIndex = 0;
                }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!Pages.Any(x=>x.Name==ResultBox.Name))
             Pages.Add(ResultBox);
            NextPage();
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[2] = checkBox3.Checked;
            Pages.Add(HightBox);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[0] = checkBox1.Checked;
            Pages.Add(EyesBox);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[1] = checkBox2.Checked;
            Pages.Add(BloodBox);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[3] = checkBox4.Checked;
                Pages.Add(EyarsBox);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[4] = checkBox5.Checked;
            Pages.Add(FaceBox);
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            _attributs[5] = checkBox6.Checked;
            Pages.Add(NoseBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrewPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrewPage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrewPage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex>=0)
             EyesResult.GetColorByParents(comboBox1.Items[comboBox1.SelectedIndex].ToString(), comboBox2.Items[comboBox2.SelectedIndex].ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
               EyesResult.GetColorByParents(comboBox1.Items[comboBox1.SelectedIndex].ToString(),comboBox2.Items[comboBox2.SelectedIndex].ToString());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightResult.GetHeightResult((float) Convert.ToDouble(textBox1.Text),
                    (float) Convert.ToDouble(textBox2.Text));
            }
            catch 
            {
                // ignored
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightResult.GetHeightResult((float)Convert.ToDouble(textBox1.Text),
                    (float)Convert.ToDouble(textBox2.Text));
            }
            catch
            {
                // ignored
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
                BloodResult.GetGroupByParents(comboBox4.Items[comboBox4.SelectedIndex].ToString(), comboBox3.Items[comboBox3.SelectedIndex].ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
                BloodResult.GetGroupByParents(comboBox4.Items[comboBox4.SelectedIndex].ToString(), comboBox3.Items[comboBox3.SelectedIndex].ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex >= 0)
                BloodResult.GetResusFactor(comboBox6.Items[comboBox6.SelectedIndex].ToString(), comboBox5.Items[comboBox5.SelectedIndex].ToString());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex >= 0)
                BloodResult.GetResusFactor(comboBox6.Items[comboBox6.SelectedIndex].ToString(), comboBox5.Items[comboBox5.SelectedIndex].ToString());
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //Pages.Add();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //Rozriz ochei jinki
            if (comboBox12.SelectedIndex >= 0)
                EyesResult.GetEyesSplit(comboBox11.Items[comboBox11.SelectedIndex].ToString(), comboBox12.Items[comboBox12.SelectedIndex].ToString());
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //rozriz ochei chol
            if (comboBox11.SelectedIndex >= 0)
                EyesResult.GetEyesSplit(comboBox11.Items[comboBox11.SelectedIndex].ToString(), comboBox12.Items[comboBox12.SelectedIndex].ToString());
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type eyas woman
            if (comboBox10.SelectedIndex >= 0)
                EyesResult.GetEyesType(comboBox9.Items[comboBox9.SelectedIndex].ToString(), comboBox10.Items[comboBox10.SelectedIndex].ToString());
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type eyas man
            if (comboBox9.SelectedIndex >= 0)
                EyesResult.GetEyesType(comboBox9.Items[comboBox9.SelectedIndex].ToString(), comboBox10.Items[comboBox10.SelectedIndex].ToString());
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type size eyas man
            if (comboBox7.SelectedIndex >= 0)
                EyesResult.GetEyesSize(comboBox7.Items[comboBox7.SelectedIndex].ToString(), comboBox8.Items[comboBox8.SelectedIndex].ToString());
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type size eyas woman
            if (comboBox8.SelectedIndex >= 0)
                EyesResult.GetEyesSize(comboBox7.Items[comboBox7.SelectedIndex].ToString(), comboBox8.Items[comboBox8.SelectedIndex].ToString());
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            // eyars tip man
            if (comboBox16.SelectedIndex >= 0)
                EyarsResult.GetEyarsTip(comboBox16.Items[comboBox16.SelectedIndex].ToString(), comboBox13.Items[comboBox13.SelectedIndex].ToString());
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eyars lobe man
            if (comboBox18.SelectedIndex >= 0)
                EyarsResult.GetEyarsLobe(comboBox18.Items[comboBox18.SelectedIndex].ToString(), comboBox14.Items[comboBox14.SelectedIndex].ToString());
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type eyars man
            if (comboBox20.SelectedIndex >= 0)
                EyarsResult.GetEyarsType(comboBox20.Items[comboBox20.SelectedIndex].ToString(), comboBox15.Items[comboBox15.SelectedIndex].ToString());
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            // eyars tip woman
            if (comboBox13.SelectedIndex >= 0)
                EyarsResult.GetEyarsTip(comboBox16.Items[comboBox16.SelectedIndex].ToString(), comboBox13.Items[comboBox13.SelectedIndex].ToString());
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eyars lobe woman
            if (comboBox14.SelectedIndex >= 0)
                EyarsResult.GetEyarsLobe(comboBox18.Items[comboBox18.SelectedIndex].ToString(), comboBox14.Items[comboBox14.SelectedIndex].ToString());
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox25.SelectedIndex >= 0)
                FaceResult.GetFaceCilia(comboBox21.Items[comboBox21.SelectedIndex].ToString(), comboBox25.Items[comboBox25.SelectedIndex].ToString());

        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dovjina vij man
            if (comboBox21.SelectedIndex >= 0)
               FaceResult.GetFaceCilia(comboBox21.Items[comboBox21.SelectedIndex].ToString(), comboBox25.Items[comboBox25.SelectedIndex].ToString());
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            // type briv man
            if (comboBox19.SelectedIndex >= 0)
                FaceResult.GetFaceBrow(comboBox19.Items[comboBox19.SelectedIndex].ToString(), comboBox26.Items[comboBox26.SelectedIndex].ToString());

        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            // yama chik man
            if (comboBox17.SelectedIndex >= 0)
                FaceResult.GetFaceCheek(comboBox17.Items[comboBox17.SelectedIndex].ToString(), comboBox27.Items[comboBox27.SelectedIndex].ToString());
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            // yama boroda man
            if (comboBox22.SelectedIndex >= 0)
                FaceResult.GetFaceChin(comboBox22.Items[comboBox22.SelectedIndex].ToString(), comboBox28.Items[comboBox28.SelectedIndex].ToString());
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lastovinaya man
            if (comboBox23.SelectedIndex >= 0)
                FaceResult.GetFaceFreckles(comboBox23.Items[comboBox23.SelectedIndex].ToString(), comboBox29.Items[comboBox29.SelectedIndex].ToString());
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            // form face man
            if (comboBox24.SelectedIndex >= 0)
                FaceResult.GetFaceForm(comboBox24.Items[comboBox24.SelectedIndex].ToString(), comboBox30.Items[comboBox30.SelectedIndex].ToString());
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            // type briv woman
            if (comboBox26.SelectedIndex >= 0)
                FaceResult.GetFaceBrow(comboBox19.Items[comboBox19.SelectedIndex].ToString(), comboBox26.Items[comboBox26.SelectedIndex].ToString());
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            // yama chik woman
            if (comboBox27.SelectedIndex >= 0)
                FaceResult.GetFaceCheek(comboBox17.Items[comboBox17.SelectedIndex].ToString(), comboBox27.Items[comboBox27.SelectedIndex].ToString());
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            // yama boroda woman
            if (comboBox28.SelectedIndex >= 0)
                FaceResult.GetFaceChin(comboBox22.Items[comboBox22.SelectedIndex].ToString(), comboBox28.Items[comboBox28.SelectedIndex].ToString());
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lastovinya woman
            if (comboBox29.SelectedIndex >= 0)
                FaceResult.GetFaceFreckles(comboBox23.Items[comboBox23.SelectedIndex].ToString(), comboBox29.Items[comboBox29.SelectedIndex].ToString());
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            // form face woman
            if (comboBox30.SelectedIndex >= 0)
                FaceResult.GetFaceForm(comboBox24.Items[comboBox24.SelectedIndex].ToString(), comboBox30.Items[comboBox30.SelectedIndex].ToString());
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose man pryamij
            if (comboBox32.SelectedIndex >= 0)
                NoseResult.GetNoseTrip(comboBox32.Items[comboBox32.SelectedIndex].ToString(), comboBox33.Items[comboBox33.SelectedIndex].ToString());
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            // form nose man krug
            if (comboBox31.SelectedIndex >= 0)
                NoseResult.GetNoseNostris(comboBox31.Items[comboBox31.SelectedIndex].ToString(), comboBox34.Items[comboBox34.SelectedIndex].ToString());
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose man vuzika
            if (comboBox40.SelectedIndex >= 0)
                NoseResult.GetNoseBridge(comboBox40.Items[comboBox40.SelectedIndex].ToString(), comboBox35.Items[comboBox35.SelectedIndex].ToString());
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose man zagostrena
            if (comboBox42.SelectedIndex >= 0)
               NoseResult.GetNoseForm(comboBox42.Items[comboBox42.SelectedIndex].ToString(), comboBox36.Items[comboBox36.SelectedIndex].ToString());
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose woman pryama
            if (comboBox33.SelectedIndex >= 0)
                NoseResult.GetNoseTrip(comboBox32.Items[comboBox32.SelectedIndex].ToString(), comboBox33.Items[comboBox33.SelectedIndex].ToString());
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose woman krug
            if (comboBox34.SelectedIndex >= 0)
               NoseResult.GetNoseNostris(comboBox31.Items[comboBox31.SelectedIndex].ToString(), comboBox34.Items[comboBox34.SelectedIndex].ToString());
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose woman visoka
            if (comboBox35.SelectedIndex >= 0)
                NoseResult.GetNoseBridge(comboBox40.Items[comboBox40.SelectedIndex].ToString(), comboBox35.Items[comboBox35.SelectedIndex].ToString());
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form nose woman zagostrena
            if (comboBox36.SelectedIndex >= 0)
              NoseResult.GetNoseForm(comboBox42.Items[comboBox42.SelectedIndex].ToString(), comboBox36.Items[comboBox36.SelectedIndex].ToString());
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex >= 0)
                EyarsResult.GetEyarsType(comboBox20.Items[comboBox20.SelectedIndex].ToString(), comboBox15.Items[comboBox15.SelectedIndex].ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
