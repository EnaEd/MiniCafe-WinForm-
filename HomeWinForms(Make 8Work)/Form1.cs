using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//В прогре поставил вместо textbox maskedtextbox т.к. хотел просто попробовать. получилось не очень удобно

namespace HomeWinForms_Make_8Work_
{
    public partial class Form1 : Form
    {
        decimal buf = 0.00m;
        //Таймер на обнуление результатов
        public void ShowTimer(object obj, EventArgs e) {
            timer1.Stop();
            DialogResult rs= MessageBox.Show("Следующий клиент?", "###", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );
            if (rs == DialogResult.Yes)
            {
                HDQuan.Text = "0.00";
                FrQuan.Text = "0.00";
                BrgrQuan.Text = "0.00";
                ClQuan.Text = "0.00";
                label7.Text = "0.00 грн";
                total.Text = "0.00 грн";
                label8.Text = "0.00 грн";
                maskedTextBox1.Text = "0.00";
                maskedTextBox2.Text = "0.00";
            }
            else
                timer1.Start();
        } 


        //переменная для суммы по кафе
        decimal totalSumCafe = 0;
        //переменная для суммы по заправке
        decimal totalSumOil = 0;

        public Form1()
        {
            InitializeComponent();
            #region Checkout check posion
            /*
            //Проверяем отмечены ли позиции по кафе
             * 
            if (HotDog.Checked) {
                //Ловим забытое кол-во продукции
                if (Int32.Parse(HDQuan.Text.ToString()) == 0) { throw new Exception("Нужно указать кол-во"); }
                    totalSumCafe = Decimal.Parse(HDPrice.Text.ToString()) * Decimal.Parse(HDQuan.Text.ToString());
               
            }
            if (Burger.Checked)
            {
                //Ловим забытое кол-во продукции
                if (Int32.Parse(BrgrQuan.Text.ToString()) == 0) { throw new Exception("Нужно указать кол-во"); }
                totalSumCafe = Int32.Parse(BrgrPrice.Text.ToString()) * Int32.Parse(BrgrQuan.Text.ToString());

            }
            if (Fri.Checked)
            {
                //Ловим забытое кол-во продукции
                if (Int32.Parse(FrQuan.Text.ToString()) == 0) { throw new Exception("Нужно указать кол-во"); }
                totalSumCafe = Int32.Parse(FrPrice.Text.ToString()) * Int32.Parse(FrQuan.Text.ToString());

            }
            if (Cola.Checked)
            {
                //Ловим забытое кол-во продукции
                if (Int32.Parse(ClQuan.Text.ToString()) == 0) { throw new Exception("Нужно указать кол-во"); }
                totalSumCafe = Int32.Parse(ClPrice.Text.ToString()) * Int32.Parse(ClQuan.Text.ToString());

            }
            */
            #endregion

            //Закрываем позиции для исключения возжможности ошибочного ввода
            HDQuan.Enabled = false;
            HDQuan.Text = "0.00";
            FrQuan.Enabled = false;
            FrQuan.Text = "0.00";
            BrgrQuan.Enabled = false;
            BrgrQuan.Text = "0.00";
            ClQuan.Enabled = false;
            ClQuan.Text = "0.00";
            OilPrice.Enabled = false;
            maskedTextBox2.Enabled = false;
            //Итоговая сумма по кафе 
            label7.Text = totalSumCafe.ToString($"{totalSumCafe} грн");
            //Итоговая сумма по заправке
            label8.Text = totalSumOil.ToString($"{totalSumOil} грн");
            timer1.Tick += new EventHandler(ShowTimer);
            
        }
        
        #region Разблокирование поля для ввода кол-ва
        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDog.Checked)
                HDQuan.Enabled = true;
            else HDQuan.Enabled = false;
        }
        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger.Checked)
                BrgrQuan.Enabled = true;
            else BrgrQuan.Enabled = false;
        }
        private void Fri_CheckedChanged(object sender, EventArgs e)
        {
            if (Fri.Checked)
                FrQuan.Enabled = true;
            else FrQuan.Enabled = false;
        }
        private void Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (Cola.Checked)
                ClQuan.Enabled = true;
            else ClQuan.Enabled = false;
        }
        private void qntOil_CheckedChanged(object sender, EventArgs e)
        {
            if (qntOil.Checked)
                maskedTextBox1.Enabled = true;
            else
                maskedTextBox1.Enabled = false;
        }
        private void sumOil_CheckedChanged(object sender, EventArgs e)
        {
            if (sumOil.Checked)
                maskedTextBox2.Enabled = true;
            else
                maskedTextBox2.Enabled = false;
        }

        #endregion

        #region Код для автоматического подсчета введеных данных
        //Нужна кнопка очистки т.к.всегда есть вариант когда клиент меняет желание уже после
        //сделанного заказа

        //private void BrgrQuan_TextChanged(object sender, EventArgs e)
        //{
        //    //для возможности менять значения и программа не вылета
        //    if (BrgrQuan.Text == "")
        //        BrgrQuan.Text = "0";
        //    //Считаем и выводим сумму в поле к оплате
        //    //доп. переменная для записи результата 
        //    decimal bufSum = decimal.Parse(BrgrQuan.Text) * decimal.Parse(BrgrPrice.Text);
        //    //проверка на правильность введенных данных
        //    DialogResult dr = MessageBox.Show("Вы ввели кол-во " + BrgrQuan.Text + " ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //Запись данных в лейбл
        //    if (dr == DialogResult.Yes)
        //    {
        //        totalSumCafe += bufSum;
        //        label7.Text = totalSumCafe.ToString() + " грн";
        //    }
        //}
        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{
        //    //для возможности менять значения и программа не вылета
        //    if (HDQuan.Text == "")
        //        HDQuan.Text = "0";
        //    //Считаем и выводим сумму в поле к оплате
        //    //доп. переменная для записи результата 
        //    decimal bufSum = decimal.Parse(HDQuan.Text) * decimal.Parse(HDPrice.Text);
        //    //проверка на правильность введенных данных
        //    DialogResult dr = MessageBox.Show("Вы ввели кол-во " + HDQuan.Text + " ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //Запись данных в лейбл
        //    if (dr == DialogResult.Yes)
        //    {
        //        totalSumCafe += bufSum;
        //        label7.Text = totalSumCafe.ToString() + " грн";
        //    }
        //}
        //private void FrQuan_TextChanged(object sender, EventArgs e)
        //{
        //    //для возможности менять значения и программа не вылета
        //    if (FrQuan.Text == "")
        //        FrQuan.Text = "0";
        //    //Считаем и выводим сумму в поле к оплате
        //    //доп. переменная для записи результата 
        //    decimal bufSum = decimal.Parse(FrQuan.Text) * decimal.Parse(FrPrice.Text);
        //    //проверка на правильность введенных данных
        //    DialogResult dr = MessageBox.Show("Вы ввели кол-во " + FrQuan.Text + " ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //Запись данных в лейбл
        //    if (dr == DialogResult.Yes)
        //    {
        //        totalSumCafe += bufSum;
        //        label7.Text = totalSumCafe.ToString() + " грн";
        //    }
        //}
        //private void ClQuan_TextChanged(object sender, EventArgs e)
        //{
        //    //для возможности менять значения и программа не вылета
        //    if (ClQuan.Text == "")
        //        ClQuan.Text = "0";
        //    //Считаем и выводим сумму в поле к оплате
        //    //доп. переменная для записи результата 
        //    decimal bufSum = decimal.Parse(ClQuan.Text) * decimal.Parse(ClPrice.Text);
        //    //проверка на правильность введенных данных
        //    DialogResult dr = MessageBox.Show("Вы ввели кол-во " + ClQuan.Text + " ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //Запись данных в лейбл
        //    if (dr == DialogResult.Yes)
        //    {
        //        totalSumCafe += bufSum;
        //        label7.Text = totalSumCafe.ToString() + " грн";
        //    }

        //}
        #endregion

        #region не нужен
        private void BrgrQuan_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void FrQuan_TextChanged(object sender, EventArgs e)
        {
        }
        private void ClQuan_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void TotalCafe_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        private void resault_Click(object sender, EventArgs e)
        {
            totalSumCafe= decimal.Parse(ClQuan.Text) * decimal.Parse(ClPrice.Text)+ decimal.Parse(FrQuan.Text) * decimal.Parse(FrPrice.Text)+ decimal.Parse(HDQuan.Text) * decimal.Parse(HDPrice.Text)+ decimal.Parse(BrgrQuan.Text) * decimal.Parse(BrgrPrice.Text);
            label7.Text = totalSumCafe.ToString()+" грн";
            if (qntOil.Checked)
            {
                totalSumOil = decimal.Parse(maskedTextBox1.Text) * decimal.Parse(OilPrice.Text);
                label8.Text = String.Format($"{totalSumOil:F} грн");
            }
            else
            {
                totalSumOil = decimal.Parse(maskedTextBox2.Text);
                TotalGas.Text = "К выдаче";
                label8.Text = String.Format($"{(totalSumOil / decimal.Parse(OilPrice.Text)):F} л") ;
            }
            total.Text = String.Format("{0:F} грн", (totalSumCafe + totalSumOil));
            
            buf += (totalSumCafe + totalSumOil);
            toolStripStatusLabel2.Text = String.Format($"{buf:F} грн.");
            timer1.Interval = 10000;
            timer1.Start();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("А-76"))
                OilPrice.Text = "15.00";
            if (comboBox1.Text.Equals("А-92"))
                OilPrice.Text = "28.99";
            if (comboBox1.Text.Equals("А-95"))
                OilPrice.Text = "29.99";
            if (comboBox1.Text.Equals("А-95Euro"))
                OilPrice.Text = "30.99";
            if (comboBox1.Text.Equals("Disel"))
                OilPrice.Text = "26.99";
        }

      
    }
}
