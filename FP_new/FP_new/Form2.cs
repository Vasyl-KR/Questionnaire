using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_new
{
    public partial class Form2 : Form
    {
        static int count = 0;

        public Form2()
        {
            List<string> a1 = new List<string>();
            a1.Add("Траса без швидкісних обмежень");
            a1.Add("Довга дорога вздовж берега");
            a1.Add("Безкінечне бездоріжжя Української глибинки");
            List<string> a2 = new List<string>();
            a2.Add("Всі необхідні документи");
            a2.Add("Неоплачені талони на штраф");
            a2.Add("Всяке сміття");
            a2.Add("Карти країни і не тільки");
            List<string> a3 = new List<string>();
            a3.Add("За перевищення швидкості");
            a3.Add("За водіння в нетверезому стані");
            a3.Add("За їзду по тротуару");
            a3.Add("За ДТП");
            List<string> a4 = new List<string>();
            a4.Add("Тишу?");
            a4.Add("Улюблене радіо");
            a4.Add("Що-небудь голосніше");
            a4.Add("Класичну музику");
            a4.Add("Власний спів");
            List<string> a5 = new List<string>();
            a5.Add("Так, я люблю машини і все, що з ними пов'язано");
            a5.Add("В принципі так");
            a5.Add("Не дуже");
            Question q1 = new Question("Найзручніша дорога - це:", a1);
            Question q2 = new Question("З собою Ви зазвичай возите?", a2);
            Question q3 = new Question("За що Вас могла б зупинити поліція?", a3);
            Question q4 = new Question("Що Ви зазвичай слухаєте в машині?", a4);
            Question q5 = new Question("Ви цікавитеся останніми автомобільними новинками?", a5);
            List<Question> qs = new List<Question>();
            qs.Add(q1);
            qs.Add(q2);
            qs.Add(q3);
            qs.Add(q4);
            qs.Add(q5);
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            MaximizeBox = false;
            foreach (string s in qs[count].answers)
            {
                this.checkedListBox1.Items.Add(s, false);
            }
            this.label1.Text = qs[count].question;
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                    if (e.Index != ix) checkedListBox1.SetItemChecked(ix, false);
        }


        
    }
}
