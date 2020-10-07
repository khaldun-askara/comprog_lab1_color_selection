namespace ColorRGBPicker
{
    partial class ColorRGBPicker
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_ResultColor = new System.Windows.Forms.Panel();
            this.rB_nex = new System.Windows.Forms.RadioButton();
            this.rB_dec = new System.Windows.Forms.RadioButton();
            this.lb_blue = new System.Windows.Forms.Label();
            this.cTB_blue = new ColorTextBox.ColorTextBox(this.components);
            this.cTB_green = new ColorTextBox.ColorTextBox(this.components);
            this.lb_green = new System.Windows.Forms.Label();
            this.lb_red = new System.Windows.Forms.Label();
            this.cTB_red = new ColorTextBox.ColorTextBox(this.components);
            this.SuspendLayout();
            // 
            // pnl_ResultColor
            // 
            this.pnl_ResultColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_ResultColor.BackColor = System.Drawing.Color.Black;
            this.pnl_ResultColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl_ResultColor.Location = new System.Drawing.Point(214, 21);
            this.pnl_ResultColor.Name = "pnl_ResultColor";
            this.pnl_ResultColor.Size = new System.Drawing.Size(164, 156);
            this.pnl_ResultColor.TabIndex = 17;
            // 
            // rB_nex
            // 
            this.rB_nex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rB_nex.AutoSize = true;
            this.rB_nex.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_nex.Location = new System.Drawing.Point(90, 139);
            this.rB_nex.Name = "rB_nex";
            this.rB_nex.Size = new System.Drawing.Size(57, 23);
            this.rB_nex.TabIndex = 16;
            this.rB_nex.Text = "HEX";
            this.rB_nex.UseVisualStyleBackColor = true;
            // 
            // rB_dec
            // 
            this.rB_dec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rB_dec.AutoSize = true;
            this.rB_dec.Checked = true;
            this.rB_dec.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_dec.Location = new System.Drawing.Point(28, 139);
            this.rB_dec.Name = "rB_dec";
            this.rB_dec.Size = new System.Drawing.Size(59, 23);
            this.rB_dec.TabIndex = 15;
            this.rB_dec.TabStop = true;
            this.rB_dec.Text = "DEC";
            this.rB_dec.UseVisualStyleBackColor = true;
            this.rB_dec.CheckedChanged += new System.EventHandler(this.rB_CheckedChanged);
            // 
            // lb_blue
            // 
            this.lb_blue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_blue.AutoSize = true;
            this.lb_blue.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_blue.Location = new System.Drawing.Point(25, 102);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(38, 19);
            this.lb_blue.TabIndex = 14;
            this.lb_blue.Text = "Blue";
            // 
            // cTB_blue
            // 
            this.cTB_blue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTB_blue.Color = 0;
            this.cTB_blue.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTB_blue.Is_input_decimal = true;
            this.cTB_blue.Location = new System.Drawing.Point(90, 99);
            this.cTB_blue.Name = "cTB_blue";
            this.cTB_blue.Size = new System.Drawing.Size(100, 23);
            this.cTB_blue.TabIndex = 13;
            this.cTB_blue.TextChanged += new System.EventHandler(this.cTB_TextChanged);
            // 
            // cTB_green
            // 
            this.cTB_green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTB_green.Color = 0;
            this.cTB_green.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTB_green.Is_input_decimal = true;
            this.cTB_green.Location = new System.Drawing.Point(90, 71);
            this.cTB_green.Name = "cTB_green";
            this.cTB_green.Size = new System.Drawing.Size(100, 23);
            this.cTB_green.TabIndex = 12;
            this.cTB_green.TextChanged += new System.EventHandler(this.cTB_TextChanged);
            // 
            // lb_green
            // 
            this.lb_green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_green.AutoSize = true;
            this.lb_green.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_green.Location = new System.Drawing.Point(25, 74);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(52, 19);
            this.lb_green.TabIndex = 11;
            this.lb_green.Text = "Green";
            // 
            // lb_red
            // 
            this.lb_red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_red.AutoSize = true;
            this.lb_red.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_red.Location = new System.Drawing.Point(25, 46);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(37, 19);
            this.lb_red.TabIndex = 10;
            this.lb_red.Text = "Red";
            // 
            // cTB_red
            // 
            this.cTB_red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTB_red.Color = 0;
            this.cTB_red.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTB_red.Is_input_decimal = true;
            this.cTB_red.Location = new System.Drawing.Point(90, 43);
            this.cTB_red.Name = "cTB_red";
            this.cTB_red.Size = new System.Drawing.Size(100, 23);
            this.cTB_red.TabIndex = 9;
            this.cTB_red.TextChanged += new System.EventHandler(this.cTB_TextChanged);
            // 
            // ColorRGBPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_ResultColor);
            this.Controls.Add(this.rB_nex);
            this.Controls.Add(this.rB_dec);
            this.Controls.Add(this.lb_blue);
            this.Controls.Add(this.cTB_blue);
            this.Controls.Add(this.cTB_green);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.lb_red);
            this.Controls.Add(this.cTB_red);
            this.Name = "ColorRGBPicker";
            this.Size = new System.Drawing.Size(402, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ResultColor;
        private System.Windows.Forms.RadioButton rB_nex;
        private System.Windows.Forms.RadioButton rB_dec;
        private System.Windows.Forms.Label lb_blue;
        private ColorTextBox.ColorTextBox cTB_blue;
        private ColorTextBox.ColorTextBox cTB_green;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.Label lb_red;
        private ColorTextBox.ColorTextBox cTB_red;
    }
}
