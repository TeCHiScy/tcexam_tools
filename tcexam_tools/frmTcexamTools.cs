using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class frmTcexamTools : Form
    {
        public enum QuestionType
        {
            Choice,
            Text,
        }
        public class Question
        {
            public QuestionType type;
            public string description;
            public List<string> answers;
            public List<bool> answer_values;
        }

        List<Question> database = new List<Question>();

        public frmTcexamTools()
        {
            InitializeComponent();
            radioChoice.Checked = true;
            radioChoice_CheckedChanged(null, null);
        }

        private void RefreshDatabase()
        {
            lstDatabase.Items.Clear();
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].type == QuestionType.Choice) lstDatabase.Items.Add("选择题");
                if (database[i].type == QuestionType.Text) lstDatabase.Items.Add("填空题");
                lstDatabase.Items[i].SubItems.Add(database[i].description);
                string line = "";
                for (int k = 0; k < database[i].answers.Count; k++)
                {
                    if (database[i].answer_values[k]) line += "** " + database[i].answers[k] + "\r\n";
                    if (!database[i].answer_values[k]) line += "* " + database[i].answers[k] + "\r\n";
                }
                lstDatabase.Items[i].SubItems.Add(line);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "tcexam database (*.tsv)|*.tsv";
            dialog.ValidateNames = true;
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine().Trim();
                    string[] elements = line.Split('\t');
                    int element_count = elements.GetUpperBound(0) + 1;
                    for (int i = 0; i < element_count; i++) elements[i] = elements[i].Trim();
                    switch (elements[0])
                    {
                        case "M":
                            if (element_count == 3) txtModule.Text = elements[2];
                            break;
                        case "S":
                            if (element_count >= 3) txtSubject.Text = elements[2];
                            break;
                        case "Q":
                            if (element_count >= 11)
                            {
                                Question item = new Question();
                                item.description = elements[2];
                                if (elements[4] == "S") item.type = QuestionType.Choice;
                                if (elements[4] == "M") item.type = QuestionType.Choice;
                                if (elements[4] == "T") item.type = QuestionType.Text;
                                item.answers = new List<string>();
                                item.answer_values = new List<bool>();
                                database.Add(item);
                            }
                            break;
                        case "A":
                            if (element_count >= 5)
                            {
                                int index = database.Count - 1;
                                database[index].answers.Add(elements[2]);
                                if (elements[4] == "1") database[index].answer_values.Add(true);
                                if (elements[4] == "0") database[index].answer_values.Add(false);
                            }
                            break;
                    }
                }
                RefreshDatabase();
                sr.Close();
            }
        }

        private void radioTrueFalse_CheckedChanged(object sender, EventArgs e)
        {
            txtAnswers.Text = "* 正确\r\n* 错误\r\n";
        }

        private void radioText_CheckedChanged(object sender, EventArgs e)
        {
            txtAnswers.Text = "** ";
        }

        private void radioChoice_CheckedChanged(object sender, EventArgs e)
        {
            txtAnswers.Text = "* \r\n* \r\n* \r\n* \r\n";
        }

        private void lstDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDatabase.SelectedIndices.Count > 0) {
                int i = lstDatabase.SelectedIndices[0];
                if (database[i].type == QuestionType.Choice) radioChoice.Checked = true;
                if (database[i].type == QuestionType.Text) radioText.Checked = true;
                txtDescription.Text = database[i].description;
                string line = "";
                for (int k = 0; k < database[i].answers.Count; k++)
                {
                    if (database[i].answer_values[k]) line += "** " + database[i].answers[k] + "\r\n";
                    if (!database[i].answer_values[k]) line += "* " + database[i].answers[k] + "\r\n";
                }
                txtAnswers.Text = line;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstDatabase.SelectedIndices.Count > 0) {
                int i = lstDatabase.SelectedIndices[0];
                database.RemoveAt(i);
                RefreshDatabase();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Question item = new Question();
            item.answers = new List<string>();
            item.answer_values = new List<bool>();
            item.description = txtDescription.Text;
            if (radioChoice.Checked) item.type = QuestionType.Choice;
            if (radioTrueFalse.Checked) item.type = QuestionType.Choice;
            if (radioText.Checked) item.type = QuestionType.Text;

            foreach(var line in txtAnswers.Lines)
            {
                string temp = line.Trim();
                if (temp.Length == 0) continue;
                bool is_right = false;
                if (temp.Length >= 2 && temp.Substring(0, 2) == "**")
                {
                    temp = temp.Substring(2).Trim();
                    is_right = true;
                }
                else
                if (temp.Length >= 1 && temp.Substring(0, 1) == "*")
                {
                    temp = temp.Substring(1).Trim();
                    is_right = false;
                }
                item.answers.Add(temp);
                item.answer_values.Add(is_right);
            }
            database.Add(item);
            RefreshDatabase();
            txtDescription.Text = "";
            txtAnswers.Text = "";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "tcexam database (*.tsv)|*.tsv";
            dialog.ValidateNames = true;
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                StreamWriter sw = new StreamWriter(filename, false);
                sw.WriteLine("M\t1\t" + txtModule.Text);
                sw.WriteLine("S\t1\t" + txtSubject.Text +"\t无描述信息");
                for (int i = 0; i < database.Count; i++)
                {
                    string line = "Q\t1\t" + database[i].description + "\t\t";
                    int value_count = 0;
                    for(int k = 0; k < database[i].answer_values.Count; k ++) {
                        if (database[i].answer_values[k]) value_count++;
                    }
                    if (database[i].type == QuestionType.Choice && value_count == 1) line += "S";
                    if (database[i].type == QuestionType.Choice && value_count > 1) line += "M";
                    if (database[i].type == QuestionType.Text) line += "T";
                    line += "\t1\t\t0\t1\t0\t1";
                    sw.WriteLine(line);
                    for (int k = 0; k < database[i].answers.Count; k++)
                    {
                        line = "A\t1\t" + database[i].answers[k] + "\t\t";
                        if (database[i].answer_values[k]) line += "1";
                        if (!database[i].answer_values[k]) line += "0";
                        line += "\t\t";
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
                MessageBox.Show("题库写入完成。");
            }
        }
    }
}
