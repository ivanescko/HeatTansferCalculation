using Lib2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3
{
    public partial class frmMain : Form
    {
        private string strTempCancel;   // строковая переменная для хранения временного значения
        private const string strMsgErrCaption = "Ошибка";
        private const string strMsgErrAttention = "Внимание!" + "\n";
        private const string strMsgErrAttentionNull = "Поле не должно оставаться пустым." + "\n";
        private const string strMsgErrRepeat = "Повторите ввод!";
        private const string _strErrorLog = "errorLog.txt";  // файл для протоколирования ошибок


        public frmMain()
        {
            InitializeComponent();
        }

        cHeatCalculation exmpl = new cHeatCalculation();
        cLayerFlux[] lf = new cLayerFlux[2];
        //lf[0] = new cLayerFlux();
        
        //lf[1] = new cLayerFlux();
        private void Form1_Load(object sender, EventArgs e)
        {
            lf[0] = new cLayerFlux();
            lf[1] = new cLayerFlux();
            // Показать в заголовке главного окна номер текущей версии и пользвателя
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";
            
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\save.xml");

            //MessageBox.Show(Application.UserAppDataPath.ToString() + @"\\save.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                cHeatCalculation hcс = new cHeatCalculation();

                this.exmpl = hcс.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений
                exmpl.SetMediumHeatAlfa(1000d);
                exmpl.SetMediumHeatTemperature(900d);
                exmpl.SetMediumQAlfa (20d);
                exmpl.SetMediumQTemperature(20d);
                //exmpl.SetWallLambda(2d);
               // exmpl.Thickness = 1d;
                exmpl.SetWallLambda1(2d);
                exmpl.SetWallThickness1(1d);
                exmpl.SetWallLambda2(2d);
                exmpl.SetWallThickness2(1d);
                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                exmpl.SaveData(exmpl, fileDefaultUserAppDataPath.ToString());
            }
            
            txtTemperatureWork.Text = exmpl.GetMediumHeatTemperature().ToString();
            txtAlfaWork.Text = exmpl.AlfaWork.ToString();
            txtLambda1.Text = exmpl.GetWallLambda1().ToString();
            txtThickness1.Text = exmpl.GetWallThickness1().ToString();
            txtThickness2.Text = exmpl.GetWallThickness2().ToString();
            txtTemperatureExternal.Text = exmpl.GetQMediumTemperature().ToString();
            txtAlfaExternal.Text = exmpl.GetQMediumAlfa().ToString();
            txtLambda2.Text = exmpl.GetWallLambda2().ToString();


            txtGetQ.Text = Math.Round(exmpl.GetQ(), 4).ToString();
            txtGetRExternal.Text = exmpl.GetRExternal().ToString();
            txtGetRWall.Text = exmpl.GetRWall().ToString();
            txtGetRWork.Text = exmpl.GetRWork().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exmpl.SetMediumHeatTemperature (double.Parse(txtTemperatureWork.Text));
            exmpl.SetMediumHeatAlfa(double.Parse(txtAlfaWork.Text));
            exmpl.SetMediumQAlfa(double.Parse(txtAlfaExternal.Text));
            exmpl.SetWallThickness1 (double.Parse(txtThickness1.Text));
            exmpl.SetWallThickness2(double.Parse(txtThickness2.Text));
            exmpl.SetMediumQTemperature(double.Parse(txtTemperatureExternal.Text));
            exmpl.SetWallLambda1  (double.Parse(txtLambda1.Text));
            exmpl.SetWallLambda2 (double.Parse(txtLambda2.Text));

            string path = Application.UserAppDataPath.ToString();

            // Сохранить данные объекта на диск для последующего вызова
            exmpl.SaveData(exmpl, path + @"\\save.xml");

            Application.Exit();
        }




        private void ClearResult_TextChanged(object sender, EventArgs e)
        {
            txtGetQ.Text = "";
            txtGetRExternal.Text = "";
            txtGetRWall.Text = "";
            txtGetRWork.Text = "";
            //exmpl.TemperatureWork = Double.Parse(txtTemperatureWork.Text);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //exmpl.TemperatureWork = Double.Parse(txtTemperatureWork.Text);
            exmpl.SetMediumHeatTemperature(Double.Parse(txtTemperatureWork.Text));

            //exmpl.AlfaWork = Double.Parse(txtAlfaWork.Text);
            exmpl.SetMediumHeatAlfa(Double.Parse(txtAlfaWork.Text));

            exmpl.SetWallCountLayers(2);

            



            //lf[0].Lambda = 1.0;
            exmpl.SetWallLambda1(Double.Parse(txtLambda1.Text.ToString()));
            exmpl.SetWallThickness1(Double.Parse(txtThickness1.Text.ToString()));

            exmpl.SetWallLambda2(Double.Parse(txtLambda2.Text.ToString()));
            exmpl.SetWallThickness2 (Double.Parse(txtThickness2.Text.ToString()));
            

            //exmpl.SetWallLambda(Double.Parse(txtLambda1.Text));
            //exmpl.Thickness = Double.Parse(txtThickness1.Text);




            //exmpl.TemperatureExternal = Double.Parse(txtTemperatureExternal.Text);
            exmpl.SetMediumQTemperature(Double.Parse(txtTemperatureExternal.Text));

            //exmpl.AlfaExternal = Double.Parse(txtAlfaExternal.Text);
            exmpl.SetMediumQAlfa(Double.Parse(txtAlfaExternal.Text));


            txtGetQ.Text = Math.Round(exmpl.GetQ(), 4).ToString();
            txtGetRWork.Text = Math.Round(exmpl.GetRWork(), 4).ToString();
            txtGetRExternal.Text = exmpl.GetRExternal().ToString();
            
            txtGetRWall.Text = exmpl.GetRWall().ToString();
            
        }

        /// <summary>
        /// Поместить данные текстового поля во временную переменную.
        /// Это надо для возможной отмены введенного в поле значения.
        /// </summary>  
        #region Временные строки
        private void txtTemperatureWork_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtTemperatureWork.Text;
        }
        private void txtAlfaWork_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtAlfaWork.Text;
        }
        private void txtLambda_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtLambda1.Text;
        }
        private void txtThickness_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtThickness1.Text;
        }
        private void txtTemperatureExternal_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtTemperatureExternal.Text;
        }
        private void txtAlfaExternal_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtAlfaExternal.Text;
        }
        #endregion
        private void txtTemperatureWork_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtTemperatureWork))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtTemperatureWork.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtTemperatureWork.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtTemperatureWork.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }


        #region Проверки 

        /// <summary>
        /// Проверить текстовое поле на null и непустоту. 
        /// </summary>  
        /// <param name="TxtB">Поле для проверки</param>
        private bool CheckPoint(TextBox TxtB)
        {
            if (TxtB == null || TxtB.Text == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Проверить введенные в текстовое поле данные. 
        /// </summary>  
        /// <param name="strTxtB">Введенное в поле значение</param>
        private bool CheckPoint(string strTxtB)
        {
            float fl;
            if (!float.TryParse(strTxtB, out fl))
                return false;
            else
                return true;
        }


        #endregion  Проверки


        private void txtAlfaWork_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtAlfaWork))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtAlfaWork.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtAlfaWork.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtAlfaWork.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void txtLambda_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtLambda1))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtLambda1.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtLambda1.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtLambda1.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void txtThickness_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtThickness1))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtThickness1.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtThickness1.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtThickness1.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        private void txtTemperatureExternal_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtTemperatureExternal))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtTemperatureExternal.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtTemperatureExternal.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtTemperatureExternal.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        private void txtAlfaExternal_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtAlfaExternal))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtAlfaExternal.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtAlfaExternal.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtAlfaExternal.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        private void txtLambda2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtLambda2))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtLambda2.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtLambda2.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtLambda2.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        private void txtThickness2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtThickness2))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtThickness2.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtThickness2.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина коэффициента теплоотдачи имеет числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtThickness2.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGetQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGetRWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGetRExternal_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            frmGraph form = new frmGraph(exmpl);
            form.Show();
            
        }
    }
}
