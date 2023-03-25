namespace WindowsFormsApp1
{
    partial class Parametrs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineThicknessTb = new System.Windows.Forms.TextBox();
            this.dotSizeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorChangeLineBtn = new System.Windows.Forms.Button();
            this.colorChangeDoteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.escapeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Толщина линий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер точек";
            // 
            // lineThicknessTb
            // 
            this.lineThicknessTb.Location = new System.Drawing.Point(171, 42);
            this.lineThicknessTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineThicknessTb.Name = "lineThicknessTb";
            this.lineThicknessTb.Size = new System.Drawing.Size(33, 20);
            this.lineThicknessTb.TabIndex = 2;
            this.lineThicknessTb.TextChanged += new System.EventHandler(this.lineThicknessTb_TextChanged);
            // 
            // dotSizeTb
            // 
            this.dotSizeTb.Location = new System.Drawing.Point(171, 72);
            this.dotSizeTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dotSizeTb.Name = "dotSizeTb";
            this.dotSizeTb.Size = new System.Drawing.Size(33, 20);
            this.dotSizeTb.TabIndex = 3;
            this.dotSizeTb.TextChanged += new System.EventHandler(this.dotSizeTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет точек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цвет линий";
            // 
            // colorChangeLineBtn
            // 
            this.colorChangeLineBtn.Location = new System.Drawing.Point(161, 139);
            this.colorChangeLineBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorChangeLineBtn.Name = "colorChangeLineBtn";
            this.colorChangeLineBtn.Size = new System.Drawing.Size(81, 25);
            this.colorChangeLineBtn.TabIndex = 6;
            this.colorChangeLineBtn.Text = "Цвет линий";
            this.colorChangeLineBtn.UseVisualStyleBackColor = true;
            this.colorChangeLineBtn.Click += new System.EventHandler(this.colorChangeLineBtn_Click);
            // 
            // colorChangeDoteBtn
            // 
            this.colorChangeDoteBtn.Location = new System.Drawing.Point(161, 107);
            this.colorChangeDoteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorChangeDoteBtn.Name = "colorChangeDoteBtn";
            this.colorChangeDoteBtn.Size = new System.Drawing.Size(81, 28);
            this.colorChangeDoteBtn.TabIndex = 7;
            this.colorChangeDoteBtn.Text = "Цвет точек";
            this.colorChangeDoteBtn.UseVisualStyleBackColor = true;
            this.colorChangeDoteBtn.Click += new System.EventHandler(this.colorChangeDoteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(203, 183);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(68, 28);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // escapeBtn
            // 
            this.escapeBtn.Location = new System.Drawing.Point(292, 184);
            this.escapeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.escapeBtn.Name = "escapeBtn";
            this.escapeBtn.Size = new System.Drawing.Size(68, 28);
            this.escapeBtn.TabIndex = 9;
            this.escapeBtn.Text = "Отмена";
            this.escapeBtn.UseVisualStyleBackColor = true;
            this.escapeBtn.Click += new System.EventHandler(this.escapeBtn_Click);
            // 
            // Parametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 233);
            this.Controls.Add(this.escapeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.colorChangeDoteBtn);
            this.Controls.Add(this.colorChangeLineBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dotSizeTb);
            this.Controls.Add(this.lineThicknessTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Parametrs";
            this.Text = "Parametrs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lineThicknessTb;
        private System.Windows.Forms.TextBox dotSizeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button colorChangeLineBtn;
        private System.Windows.Forms.Button colorChangeDoteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button escapeBtn;
    }
}