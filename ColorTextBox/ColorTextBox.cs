using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTextBox
{
    public partial class ColorTextBox : TextBox
    {
        //так как ввод у нас может быть в 10 и 16, необходимо знать, как мы сейчас вводим
        //по умолчанию вводим в 10 системе, если не в ней, то в 16
        private bool is_input_decimal = true;
        public bool Is_input_decimal
        {
            get
            {
                return is_input_decimal;
            }
            set
            {
                is_input_decimal = value;
                TextUpdate();
            }
        }

        private void TextUpdate()
        {
            int x = 0;
            // число было в 10, x нужно в 16
            if (!is_input_decimal && int.TryParse(Text, out x)
                // число было в 16, x нужно в 10
                || is_input_decimal && int.TryParse(Text, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out x))
                Text = Convert.ToString(x, is_input_decimal ? 10 : 16).ToUpper();
        }

        public ColorTextBox()
        {
            InitializeComponent();
        }

        public ColorTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //проверка: является ли введённое число цифрой
        //принимается во внимание система счисления
        private bool IsDigit(char x)
        {
            x = char.ToUpper(x);
            return 
                // ввод 10ый и цифра
                (is_input_decimal && x >= '0' && x <= '9') 
                // ввод не 10ый и (цифра или буква от A до F)
                || (!is_input_decimal && (x >= '0' && x <= '9' || x >= 'A' && x <= 'F'));
        }

        private string StrNornalisation (string str)
        {
            string result = "";
            foreach (char ch in str)
                result += IsDigit(ch) ? ch.ToString() : "";
            return result;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            //находим наше число из текста в число, учитывая систему счисления
            int x = 0;
            Text = StrNornalisation(Text);
            if (is_input_decimal && int.TryParse(Text, out x)
                || !is_input_decimal && int.TryParse(Text, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out x))
            {
                // если число будет меньше 0, то оно превратится в 0
                if (x < 0)
                    Text = "0";
                // если больше максимума, то в 255 или FF в зависимости от системы счисления
                if (x > 255)
                    Text = is_input_decimal ? "255" : "FF";
            }
                       
            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // как я понял, мы проверяем, является ли символ цифрой или управляющим символом
            // и если нет, то считаем нажатие обработанным, тем самым пропуская его
            if (!this.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
