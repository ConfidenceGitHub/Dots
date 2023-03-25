namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShadedLineBtn = new System.Windows.Forms.Button();
            this.basersBtn = new System.Windows.Forms.Button();
            this.brokenLineBnt = new System.Windows.Forms.Button();
            this.curlyLineBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.movementBtn = new System.Windows.Forms.Button();
            this.parametersBtn = new System.Windows.Forms.Button();
            this.periodsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShadedLineBtn);
            this.panel1.Controls.Add(this.basersBtn);
            this.panel1.Controls.Add(this.brokenLineBnt);
            this.panel1.Controls.Add(this.curlyLineBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.movementBtn);
            this.panel1.Controls.Add(this.parametersBtn);
            this.panel1.Controls.Add(this.periodsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 361);
            this.panel1.TabIndex = 0;
            // 
            // ShadedLineBtn
            // 
            this.ShadedLineBtn.Location = new System.Drawing.Point(29, 283);
            this.ShadedLineBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShadedLineBtn.Name = "ShadedLineBtn";
            this.ShadedLineBtn.Size = new System.Drawing.Size(93, 26);
            this.ShadedLineBtn.TabIndex = 7;
            this.ShadedLineBtn.Text = "Закрашенная";
            this.ShadedLineBtn.UseVisualStyleBackColor = true;
            this.ShadedLineBtn.Click += new System.EventHandler(this.ShadedLineBtn_Click);
            // 
            // basersBtn
            // 
            this.basersBtn.Location = new System.Drawing.Point(29, 242);
            this.basersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basersBtn.Name = "basersBtn";
            this.basersBtn.Size = new System.Drawing.Size(93, 24);
            this.basersBtn.TabIndex = 6;
            this.basersBtn.Text = "Бейзеры";
            this.basersBtn.UseVisualStyleBackColor = true;
            this.basersBtn.Click += new System.EventHandler(this.BasersBtn_Click);
            // 
            // brokenLineBnt
            // 
            this.brokenLineBnt.Location = new System.Drawing.Point(29, 206);
            this.brokenLineBnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brokenLineBnt.Name = "brokenLineBnt";
            this.brokenLineBnt.Size = new System.Drawing.Size(93, 23);
            this.brokenLineBnt.TabIndex = 5;
            this.brokenLineBnt.Text = "Ломанная";
            this.brokenLineBnt.UseVisualStyleBackColor = true;
            this.brokenLineBnt.Click += new System.EventHandler(this.BrokenLineBnt_Click);
            // 
            // curlyLineBtn
            // 
            this.curlyLineBtn.Location = new System.Drawing.Point(29, 165);
            this.curlyLineBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.curlyLineBtn.Name = "curlyLineBtn";
            this.curlyLineBtn.Size = new System.Drawing.Size(93, 27);
            this.curlyLineBtn.TabIndex = 4;
            this.curlyLineBtn.Text = "Кривая";
            this.curlyLineBtn.UseVisualStyleBackColor = true;
            this.curlyLineBtn.Click += new System.EventHandler(this.CurlyLineBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(29, 131);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 21);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // movementBtn
            // 
            this.movementBtn.Location = new System.Drawing.Point(29, 92);
            this.movementBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movementBtn.Name = "movementBtn";
            this.movementBtn.Size = new System.Drawing.Size(93, 26);
            this.movementBtn.TabIndex = 2;
            this.movementBtn.Text = "Движение";
            this.movementBtn.UseVisualStyleBackColor = true;
            this.movementBtn.Click += new System.EventHandler(this.MovementBtn_Click);
            // 
            // parametersBtn
            // 
            this.parametersBtn.Location = new System.Drawing.Point(29, 58);
            this.parametersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parametersBtn.Name = "parametersBtn";
            this.parametersBtn.Size = new System.Drawing.Size(93, 23);
            this.parametersBtn.TabIndex = 1;
            this.parametersBtn.Text = "Параметры";
            this.parametersBtn.UseVisualStyleBackColor = true;
            this.parametersBtn.Click += new System.EventHandler(this.ParametersBtn_Click);
            // 
            // periodsBtn
            // 
            this.periodsBtn.Location = new System.Drawing.Point(29, 23);
            this.periodsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.periodsBtn.Name = "periodsBtn";
            this.periodsBtn.Size = new System.Drawing.Size(93, 24);
            this.periodsBtn.TabIndex = 0;
            this.periodsBtn.Text = "Точки";
            this.periodsBtn.UseVisualStyleBackColor = true;
            this.periodsBtn.Click += new System.EventHandler(this.PeriodsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button basersBtn;
        private System.Windows.Forms.Button brokenLineBnt;
        private System.Windows.Forms.Button curlyLineBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button movementBtn;
        private System.Windows.Forms.Button parametersBtn;
        private System.Windows.Forms.Button periodsBtn;
        private System.Windows.Forms.Button ShadedLineBtn;
    }
}

