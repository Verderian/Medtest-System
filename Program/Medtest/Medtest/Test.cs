using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtest
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        #region Initialize_const
        /// <summary>
        /// Переменная содержащая номер текущего вопроса
        /// </summary>
        private int during_count = 1;

        /// <summary>
        /// Время тестирования:
        /// m - минуты, 
        /// s - секунды
        /// </summary>
        private int m, s;

        /// <summary>
        /// Список вопросов для тестирования
        /// </summary>
        private string[] questions = Properties.Settings.Default.Question.Split('\n');

        /// <summary>
        /// Список результатов тестирования
        /// </summary>
        private string[] answers = new string[20];

        /// <summary>
        /// Тип ответов на каждый из вопросов:
        /// 0 - одиночный ответ,
        /// 1 - множественный ответ,
        /// 2 - текстовый ответ
        /// </summary>
        private int[] question_type = new int[20];
        #endregion Initialize_const

        //Горячие клавиши
        private void Test_KeyDown(object sender, KeyEventArgs e)
        {
            //клавиша - справка с описанием работы программы
            if (e.KeyCode == Keys.F1)
            {
                Help F = new Help();
                F.Show();
            }
            //клавиша, показывавающая информацию о продукте
            if (e.KeyCode == Keys.F2)
            {
                AboutBox1 F = new AboutBox1();
                F.Show();
            }
        }

        //Клавиша помощь
        private void button_help_Click(object sender, EventArgs e)
        {
            Help F = new Help();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked | checkBox3.Checked | checkBox4.Checked | checkBox5.Checked |
                radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton4.Checked |
                radioButton5.Checked | textBox1.Text != "")
            {
                #region Button_color_done
                switch (during_count)
                {
                    case 1:
                        button1.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 2:
                        button2.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 3:
                        button3.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 4:
                        button4.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 5:
                        button5.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 6:
                        button6.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 7:
                        button7.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 8:
                        button8.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 9:
                        button9.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 10:
                        button10.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 11:
                        button11.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 12:
                        button12.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 13:
                        button13.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 14:
                        button14.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 15:
                        button15.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 16:
                        button16.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 17:
                        button17.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 18:
                        button18.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 19:
                        button19.Image = Medtest.Properties.Resources.button6;;
                        break;
                    case 20:
                        button20.Image = Medtest.Properties.Resources.button6;;
                        break;
                }
                #endregion Button_color_done
            }
            else
            {
                #region Button_color_none
                switch (during_count)
                {
                    case 1:
                        button1.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 2:
                        button2.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 3:
                        button3.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 4:
                        button4.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 5:
                        button5.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 6:
                        button6.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 7:
                        button7.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 8:
                        button8.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 9:
                        button9.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 10:
                        button10.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 11:
                        button11.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 12:
                        button12.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 13:
                        button13.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 14:
                        button14.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 15:
                        button15.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 16:
                        button16.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 17:
                        button17.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 18:
                        button18.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 19:
                        button19.Image = Medtest.Properties.Resources.button4; ;
                        break;
                    case 20:
                        button20.Image = Medtest.Properties.Resources.button4; ;
                        break;
                }
                #endregion Button_color_none
            }
            Save();
            panel_ans_0.Visible = false;
            panel_ans_1.Visible = false;
            panel_ans_2.Visible = false;
            if (Convert.ToInt32(((Button)(sender)).Tag) != 21 & Convert.ToInt32(((Button)(sender)).Tag) != 22)
            {
                during_count = Convert.ToInt32(((Button)(sender)).Tag);
            }
            else
            {
                if (Convert.ToInt32(((Button)(sender)).Tag) == 21 & during_count != 1)
                {
                    during_count--;
                }
                if (Convert.ToInt32(((Button)(sender)).Tag) == 22 & during_count != 20)
                {
                    during_count++;
                }
            }
            #region Button_color_current
            switch (during_count)
            {
                case 1:
                    button1.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 2:
                    button2.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 3:
                    button3.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 4:
                    button4.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 5:
                    button5.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 6:
                    button6.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 7:
                    button7.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 8:
                    button8.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 9:
                    button9.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 10:
                    button10.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 11:
                    button11.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 12:
                    button12.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 13:
                    button13.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 14:
                    button14.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 15:
                    button15.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 16:
                    button16.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 17:
                    button17.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 18:
                    button18.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 19:
                    button19.Image = Medtest.Properties.Resources.button5; ;
                    break;
                case 20:
                    button20.Image = Medtest.Properties.Resources.button5; ;
                    break;
            }
            #endregion Button_color_current
            label_name_question.Text = "Задание №" + Convert.ToString(during_count);
            string[] current_question = answers[during_count - 1].Split('|');
            richTextBox_question.Text = current_question[0];
            if (question_type[during_count - 1] == 0)
            {
                panel_ans_0.Visible = true;
                radioButton1.Text = current_question[1];
                radioButton1.Visible = true;
                radioButton1.Checked = Convert.ToBoolean(current_question[2]);
                radioButton2.Text = current_question[3];
                radioButton2.Visible = true;
                radioButton2.Checked = Convert.ToBoolean(current_question[4]);
                if (current_question[5] != "")
                {
                    radioButton3.Text = current_question[5];
                    radioButton3.Visible = true;
                    radioButton3.Checked = Convert.ToBoolean(current_question[6]);
                }
                if (current_question[7] != "")
                {
                    radioButton4.Text = current_question[7];
                    radioButton4.Visible = true;
                    radioButton4.Checked = Convert.ToBoolean(current_question[8]);
                }
                if (current_question[9] != "")
                {
                    radioButton5.Text = current_question[9];
                    radioButton5.Visible = true;
                    radioButton5.Checked = Convert.ToBoolean(current_question[10]);
                }
            }
            else
            {
                if (question_type[during_count - 1] == 1)
                {
                    panel_ans_1.Visible = true;
                    checkBox1.Text = current_question[1];
                    checkBox1.Visible = true;
                    checkBox1.Checked = Convert.ToBoolean(current_question[2]);
                    checkBox2.Text = current_question[3];
                    checkBox2.Visible = true;
                    checkBox2.Checked = Convert.ToBoolean(current_question[4]);
                    if (current_question[5] != "")
                    {
                        checkBox3.Text = current_question[5];
                        checkBox3.Visible = true;
                        checkBox3.Checked = Convert.ToBoolean(current_question[6]);
                    }
                    if (current_question[7] != "")
                    {
                        checkBox4.Text = current_question[7];
                        checkBox4.Visible = true;
                        checkBox4.Checked = Convert.ToBoolean(current_question[8]);
                    }
                    if (current_question[9] != "")
                    {
                        checkBox5.Text = current_question[9];
                        checkBox5.Visible = true;
                        checkBox5.Checked = Convert.ToBoolean(current_question[10]);
                    }
                }
                else
                {
                    panel_ans_2.Visible = true;
                    textBox1.Text = current_question[11];
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            panel_question.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2;
            panel_answer.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2;
            timer1.Interval = 500;
            m = Convert.ToInt32(Properties.Settings.Default.Sections.Split('|')[2]); s = 0;
            label_time_twopoint.Visible = true;
            timer1.Enabled = true;
            for (int i = 1; i < 21; i++)
            {
                string[] enter = questions[i].Split('|');
                answers[i - 1] = enter[2] + "|" + enter[5] + "|False|" + enter[7] + "|False|" + enter[9] + "|False|" +
                                 enter[11] + "|False|" + enter[13] + "|False||";
                if (enter[15] != "")
                {
                    question_type[i - 1] = 2;
                }
                else
                {
                    int control = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (enter[6 + 2*j]=="True")
                        {
                            control++;
                        }
                    }
                    if (control == 1)
                    {
                        question_type[i-1] = 0;
                    }
                    else
                    {
                        question_type[i-1] = 1;
                    }
                }
            }
            string[] current_question = answers[during_count - 1].Split('|');
            richTextBox_question.Text = current_question[0];
            if (question_type[during_count-1] == 0)
            {
                panel_ans_0.Visible = true;
                radioButton1.Text=current_question[1];
                radioButton1.Visible = true;
                radioButton2.Text = current_question[3];
                radioButton2.Visible = true;
                if (current_question[5] != "")
                {
                    radioButton3.Text = current_question[5];
                    radioButton3.Visible = true;
                }
                if (current_question[7] != "")
                {
                    radioButton4.Text = current_question[7];
                    radioButton4.Visible = true;
                }
                if (current_question[9] != "")
                {
                    radioButton5.Text = current_question[9];
                    radioButton5.Visible = true;
                }
            }
            else
            {
                if (question_type[during_count - 1] == 1)
                {
                    panel_ans_1.Visible = true;
                    checkBox1.Text = current_question[1];
                    checkBox1.Visible = true;
                    checkBox2.Text = current_question[3];
                    checkBox2.Visible = true;
                    if (current_question[5] != "")
                    {
                        checkBox3.Text = current_question[5];
                        checkBox3.Visible = true;
                    }
                    if (current_question[7] != "")
                    {
                        checkBox4.Text = current_question[7];
                        checkBox4.Visible = true;
                    }
                    if (current_question[9] != "")
                    {
                        checkBox5.Text = current_question[9];
                        checkBox5.Visible = true;
                    }
                }
                else
                {
                    panel_ans_2.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label_time_twopoint.Visible)
            {
                if (s > 0)
                {
                    s--;
                    if (s < 10)
                        label_time_second.Text = "0" + s.ToString();
                    else
                        label_time_second.Text = s.ToString();
                }
                else
                {
                    if (m > 0)
                    {
                        m--;
                        if (m < 10)
                            label_time_minute.Text = "0" + m.ToString();
                        else
                            label_time_minute.Text = m.ToString();
                        s = 59;
                        label_time_second.Text = "59";
                    }
                }
                label_time_twopoint.Visible = false;
            }
            else
            {
                label_time_twopoint.Visible = true;
            }
            if ((label_time_minute.Text == "00") & (label_time_second.Text == "00"))
            {
                Save();
                string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n5";
                int[] answers_competence = new int[10];
                int count_result = 0;
                for (int i = 0; i < 10; i++)
                {
                    answers_competence[i] = 0;
                }
                for (int i = 0; i < 20; i++)
                {
                    message += "\n";
                    string[] enter = questions[i + 1].Split('|');
                    string[] enter_answer = answers[i].Split('|');
                    int count = 0;
                    message += Properties.Settings.Default.People.Split('|')[0] + ",";
                    message += Properties.Settings.Default.Sections.Split('|')[0] + ",";
                    message += enter[0] + ",";
                    for (int j = 0; j < 6; j++)
                    {
                        if (enter[6 + 2 * j] != "")
                        {
                            if (enter[6 + 2 * j] == enter_answer[2 + 2 * j])
                            {
                                count++;
                                message += "1";
                            }
                            else
                            {
                                message += "0";
                            }
                        }
                        else
                        {
                            message += "1";
                            count++;
                        }
                        message += ",";
                    }
                    if (enter_answer[12] != "")
                    {
                        message += enter_answer[12] + ",";
                    }
                    else
                    {
                        message += "NULL,";
                    }
                    if (count == 6)
                    {
                        message += "1";
                        count_result++;
                        string[] competence = Properties.Settings.Default.Sections_competence.Split('|');
                        for (int j = 0; j < 10; j++)
                        {
                            if (competence[5 + 2 * j] == enter[1])
                            {
                                answers_competence[j]++;
                            }
                        }
                    }
                    else
                    {
                        message += "0";
                    }
                }
                message += "\n";
                message += Properties.Settings.Default.People.Split('|')[0] + ",";
                message += Properties.Settings.Default.Sections.Split('|')[0] + ",";
                message += Convert.ToString(count_result);
                for (int i = 0; i < 10; i++)
                {
                    string question_count = Properties.Settings.Default.Sections_competence.Split('|')[6 + 2 * i];
                    if (question_count != "")
                    {
                        message += "," + Convert.ToString((Convert.ToDouble(answers_competence[i]) / Convert.ToDouble(question_count)) * 100);
                    }
                    else
                    {
                        message += "," + "NULL";
                    }
                }
                Properties.Settings.Default.Result = message.Split('\n')[22];
                Properties.Settings.Default.Save();
                Send send = new Send(Properties.Settings.Default.IP_server, message);
                Result F = new Result();
                F.Show();
                this.Close();
            }
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Save();
            string message = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0] + "\n5";
            int[] answers_competence = new int[10];
            int count_result = 0;
            for (int i = 0; i < 10; i++)
            {
                answers_competence[i] = 0;
            }
            for (int i = 0; i < 20; i++)
            {
                message += "\n";
                string[] enter = questions[i + 1].Split('|');
                string[] enter_answer = answers[i].Split('|');
                int count = 0;
                message += Properties.Settings.Default.People.Split('|')[0] + ",";
                message += Properties.Settings.Default.Sections.Split('|')[0] + ",";
                message += enter[0] + ",";
                for (int j = 0; j < 6; j++)
                {
                    if (enter[6 + 2*j] != "")
                    {
                        if (enter[6 + 2*j] == enter_answer[2 + 2*j])
                        {
                            count++;
                            message += "1";
                        }
                        else
                        {
                            message += "0";
                        }
                    }
                    else
                    {
                        message += "1";
                        count++;
                    }
                    message += ",";
                }
                if (enter_answer[12] != "")
                {
                    message += enter_answer[12] + ",";
                }
                else
                {
                    message += "NULL,";
                }
                if (count == 6)
                {
                    message += "1";
                    count_result++;
                    string[] competence = Properties.Settings.Default.Sections_competence.Split('|');
                    for (int j = 0; j < 10; j++)
                    {
                        if (competence[5 + 2*j] == enter[1])
                        {
                            answers_competence[j]++;
                        }
                    }
                }
                else
                {
                    message += "0";
                }
            }
            message += "\n";
            message += Properties.Settings.Default.People.Split('|')[0] + ",";
            message += Properties.Settings.Default.Sections.Split('|')[0] + ",";
            message += Convert.ToString(count_result);
            for (int i = 0; i < 10; i++)
            {
                string question_count = Properties.Settings.Default.Sections_competence.Split('|')[6 + 2*i];
                if (question_count != "")
                {
                    message += "," + Convert.ToString((Convert.ToDouble(answers_competence[i]) / Convert.ToDouble(question_count)) * 100);
                }
                else
                {
                    message += "," + "NULL";
                }
            }
            Properties.Settings.Default.Result = message.Split('\n')[22];
            Properties.Settings.Default.Save();
            Send send = new Send(Properties.Settings.Default.IP_server, message);
            Result F = new Result();
            F.Show();
            this.Close();
        }

        private void Save()
        {
            if (question_type[during_count - 1] == 1)
            {
                answers[during_count - 1] = richTextBox_question.Text + "|" + checkBox1.Text + "|" +
                                            Convert.ToString(checkBox1.Checked) + "|" + checkBox2.Text + "|" +
                                            Convert.ToString(checkBox2.Checked) + "|" + checkBox3.Text + "|" +
                                            Convert.ToString(checkBox3.Checked) + "|" + checkBox4.Text + "|" +
                                            Convert.ToString(checkBox4.Checked) + "|" + checkBox5.Text + "|" +
                                            Convert.ToString(checkBox5.Checked) + "||";
            }
            if (question_type[during_count - 1] == 0)
            {
                answers[during_count - 1] = richTextBox_question.Text + "|" + radioButton1.Text + "|" +
                                            Convert.ToString(radioButton1.Checked) + "|" + radioButton2.Text + "|" +
                                            Convert.ToString(radioButton2.Checked) + "|" + radioButton3.Text + "|" +
                                            Convert.ToString(radioButton3.Checked) + "|" + radioButton4.Text + "|" +
                                            Convert.ToString(radioButton4.Checked) + "|" + radioButton5.Text + "|" +
                                            Convert.ToString(radioButton5.Checked) + "||";
            }
            if (question_type[during_count - 1] == 2)
            {
                answers[during_count - 1] = richTextBox_question.Text + "|||||||||||" + textBox1.Text + "|";
            }
        }

        private void panel_ans_0_VisibleChanged(object sender, EventArgs e)
        {
            panel_ans_0.Dock=DockStyle.Fill;
            radioButton1.Text = "";
            radioButton1.Checked = false;
            radioButton1.Visible = false;
            radioButton2.Text = "";
            radioButton2.Checked = false;
            radioButton2.Visible = false;
            radioButton3.Text = "";
            radioButton3.Checked = false;
            radioButton3.Visible = false;
            radioButton4.Text = "";
            radioButton4.Checked = false;
            radioButton4.Visible = false;
            radioButton5.Text = "";
            radioButton5.Checked = false;
            radioButton5.Visible = false;
        }

        private void panel_ans_1_VisibleChanged(object sender, EventArgs e)
        {
            panel_ans_1.Dock = DockStyle.Fill;
            checkBox1.Text = "";
            checkBox1.Checked = false;
            checkBox1.Visible = false;
            checkBox2.Text = "";
            checkBox2.Checked = false;
            checkBox2.Visible = false;
            checkBox3.Text = "";
            checkBox3.Checked = false;
            checkBox3.Visible = false;
            checkBox4.Text = "";
            checkBox4.Checked = false;
            checkBox4.Visible = false;
            checkBox5.Text = "";
            checkBox5.Checked = false;
            checkBox5.Visible = false;
        }

        private void panel_ans_2_VisibleChanged(object sender, EventArgs e)
        {
            panel_ans_2.Dock = DockStyle.Fill;
            textBox1.Text = "";
        }
    }
}
