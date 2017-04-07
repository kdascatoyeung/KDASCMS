using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    public partial class FormSupport : UserControl
    {
        List<string> questionList = new List<string>();
        List<string> answerList = new List<string>();

        public FormSupport()
        {
            InitializeComponent();

            string[] question = { "Cannot open Excel", "Cannot open Word", "Syntax Error", "Excel error occured" };
            foreach (string q in question)
                questionList.Add(q);
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string question in questionList)
            {
                if (txtQuestion.Text != "")
                {
                    if (question.ToLower().Contains(txtQuestion.Text.ToLower()))
                    {
                        if (!listBox1.Items.Contains(question))
                        {
                            listBox1.Items.Add(question);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


    }
}
