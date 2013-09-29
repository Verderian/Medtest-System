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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        //Кнопка далее
        private void button_structure_cancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Question = "";
            Properties.Settings.Default.Result = "";
            Properties.Settings.Default.Sections = "";
            Properties.Settings.Default.People = "";
            Properties.Settings.Default.Save();
            Next F = new Next();
            F.Show();
            this.Close();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            string[] enter = Properties.Settings.Default.Sections.Split('|');
            label_name_section_structure.Text = "Название раздела: " + enter[1];
            for (int i = 0; i < 10; i++)
            {
                if (enter[3 + 2*i] == "Нет")
                {
                    enter[3 + 2*i] = "";
                }
            }
            richTextBox_competence_1.Text = enter[3];
            richTextBox_competence_2.Text = enter[5];
            richTextBox_competence_3.Text = enter[7];
            richTextBox_competence_4.Text = enter[9];
            richTextBox_competence_5.Text = enter[11];
            richTextBox_competence_6.Text = enter[13];
            richTextBox_competence_7.Text = enter[15];
            richTextBox_competence_8.Text = enter[17];
            richTextBox_competence_9.Text = enter[19];
            richTextBox_competence_10.Text = enter[21];
            enter = Properties.Settings.Default.Result.Split(',');
            for (int i = 0; i < 10; i++)
            {
                if (enter[3 + i] == "NULL")
                {
                    enter[3 + i] = "";
                }
            }
            richTextBox_question_1.Text = enter[3];
            richTextBox_question_2.Text = enter[4];
            richTextBox_question_3.Text = enter[5];
            richTextBox_question_4.Text = enter[6];
            richTextBox_question_5.Text = enter[7];
            richTextBox_question_6.Text = enter[8];
            richTextBox_question_7.Text = enter[9];
            richTextBox_question_8.Text = enter[10];
            richTextBox_question_9.Text = enter[11];
            richTextBox_question_10.Text = enter[12];
            string[] result = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (enter[3 + i] != "")
                {
                    if (Convert.ToInt32(enter[3+i]) < 25)
                    {
                        result[i] = "Не владеет";
                    }
                    else
                    {
                        if (Convert.ToInt32(enter[3 + i]) < 50)
                        {
                            result[i] = "Низкий";
                        }
                        else
                        {
                            if (Convert.ToInt32(enter[3 + i]) < 80)
                            {
                                result[i] = "Средний";
                            }
                            else
                            {
                                result[i] = "Высокий";
                            }
                        }
                    }
                }
            }
            richTextBox1.Text = result[0];
            richTextBox2.Text = result[1];
            richTextBox3.Text = result[2];
            richTextBox4.Text = result[3];
            richTextBox5.Text = result[4];
            richTextBox6.Text = result[5];
            richTextBox7.Text = result[6];
            richTextBox8.Text = result[7];
            richTextBox9.Text = result[8];
            richTextBox10.Text = result[9];
            if ((Convert.ToInt32(enter[2])/20)*100 < 50)
            {
                richTextBox_result_all.Text = "Итоговый результат: неудовлетворительно - " +
                                              Convert.ToString((Convert.ToDouble(enter[2]) / 20) * 100) + "%";
            }
            else
            {
                if ((Convert.ToInt32(enter[2])/20)*100 < 64)
                {
                    richTextBox_result_all.Text = "Итоговый результат: удовлетворительно - " +
                                                  Convert.ToString((Convert.ToDouble(enter[2])/20)*100) + "%";
                }
                else
                {
                    if ((Convert.ToInt32(enter[2])/20)*100 < 80)
                    {
                        richTextBox_result_all.Text = "Итоговый результат: средний уровень - " +
                                                      Convert.ToString((Convert.ToDouble(enter[2]) / 20) * 100) + "%";
                    }
                    else
                    {
                        if ((Convert.ToInt32(enter[2])/20)*100 < 90)
                        {
                            richTextBox_result_all.Text = "Итоговый результат: хорошо - " +
                                                          Convert.ToString((Convert.ToDouble(enter[2]) / 20) * 100) + "%";
                        }
                        else
                        {
                            richTextBox_result_all.Text = "Итоговый результат: отлично - " +
                                                          Convert.ToString((Convert.ToDouble(enter[2]) / 20) * 100) + "%";
                        }
                    }
                }
            }
        }
    }
}
