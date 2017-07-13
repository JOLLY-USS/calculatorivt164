namespace calculator
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.generation = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.degreeoftwo = new System.Windows.Forms.Button();
            this.degreeofx = new System.Windows.Forms.Button();
            this.lognature = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.Button();
            this.degreeoften = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.logtwo = new System.Windows.Forms.Button();
            this.xdegreey = new System.Windows.Forms.Button();
            this.xTo1dY = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.Ostxy = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Geometric = new System.Windows.Forms.Button();
            this.EdegreeX = new System.Windows.Forms.Button();
            this.DivisionX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plus.Location = new System.Drawing.Point(38, 121);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.act_Click);
            // 
            // minus
            // 
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minus.Location = new System.Drawing.Point(38, 169);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.act_Click);
            // 
            // generation
            // 
            this.generation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generation.Location = new System.Drawing.Point(119, 121);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(75, 23);
            this.generation.TabIndex = 2;
            this.generation.Text = "*";
            this.generation.UseVisualStyleBackColor = true;
            this.generation.Click += new System.EventHandler(this.act_Click);
            // 
            // division
            // 
            this.division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.division.Location = new System.Drawing.Point(119, 169);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.act_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // sin
            // 
            this.sin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sin.Location = new System.Drawing.Point(244, 121);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 10;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // cos
            // 
            this.cos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cos.Location = new System.Drawing.Point(334, 121);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 11;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // degreeoftwo
            // 
            this.degreeoftwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreeoftwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.degreeoftwo.Location = new System.Drawing.Point(244, 168);
            this.degreeoftwo.Name = "degreeoftwo";
            this.degreeoftwo.Size = new System.Drawing.Size(75, 23);
            this.degreeoftwo.TabIndex = 12;
            this.degreeoftwo.Text = "2^x";
            this.degreeoftwo.UseVisualStyleBackColor = true;
            this.degreeoftwo.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // degreeofx
            // 
            this.degreeofx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreeofx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.degreeofx.Location = new System.Drawing.Point(334, 169);
            this.degreeofx.Name = "degreeofx";
            this.degreeofx.Size = new System.Drawing.Size(75, 23);
            this.degreeofx.TabIndex = 13;
            this.degreeofx.Text = "x^2";
            this.degreeofx.UseVisualStyleBackColor = true;
            this.degreeofx.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // lognature
            // 
            this.lognature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lognature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lognature.Location = new System.Drawing.Point(244, 256);
            this.lognature.Name = "lognature";
            this.lognature.Size = new System.Drawing.Size(75, 23);
            this.lognature.TabIndex = 14;
            this.lognature.Text = "ln";
            this.lognature.UseVisualStyleBackColor = true;
            this.lognature.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // module
            // 
            this.module.Cursor = System.Windows.Forms.Cursors.Hand;
            this.module.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.module.Location = new System.Drawing.Point(334, 211);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(75, 23);
            this.module.TabIndex = 15;
            this.module.Text = "mod";
            this.module.UseVisualStyleBackColor = true;
            this.module.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // degreeoften
            // 
            this.degreeoften.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreeoften.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.degreeoften.Location = new System.Drawing.Point(244, 211);
            this.degreeoften.Name = "degreeoften";
            this.degreeoften.Size = new System.Drawing.Size(75, 23);
            this.degreeoften.TabIndex = 16;
            this.degreeoften.Text = "10^x";
            this.degreeoften.UseVisualStyleBackColor = true;
            this.degreeoften.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // tan
            // 
            this.tan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tan.Location = new System.Drawing.Point(334, 256);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 17;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // ctan
            // 
            this.ctan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctan.Location = new System.Drawing.Point(244, 296);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 18;
            this.ctan.Text = "ctan";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // logtwo
            // 
            this.logtwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logtwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logtwo.Location = new System.Drawing.Point(334, 296);
            this.logtwo.Name = "logtwo";
            this.logtwo.Size = new System.Drawing.Size(75, 23);
            this.logtwo.TabIndex = 19;
            this.logtwo.Text = "log2";
            this.logtwo.UseVisualStyleBackColor = true;
            this.logtwo.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // xdegreey
            // 
            this.xdegreey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xdegreey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xdegreey.Location = new System.Drawing.Point(38, 212);
            this.xdegreey.Name = "xdegreey";
            this.xdegreey.Size = new System.Drawing.Size(75, 23);
            this.xdegreey.TabIndex = 20;
            this.xdegreey.Text = "x^y";
            this.xdegreey.UseVisualStyleBackColor = true;
            this.xdegreey.Click += new System.EventHandler(this.act_Click);
            // 
            // xTo1dY
            // 
            this.xTo1dY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xTo1dY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xTo1dY.Location = new System.Drawing.Point(119, 212);
            this.xTo1dY.Name = "xTo1dY";
            this.xTo1dY.Size = new System.Drawing.Size(75, 23);
            this.xTo1dY.TabIndex = 21;
            this.xTo1dY.Text = "x^(1/y)";
            this.xTo1dY.UseVisualStyleBackColor = true;
            this.xTo1dY.Click += new System.EventHandler(this.act_Click);
            // 
            // logxy
            // 
            this.logxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logxy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logxy.Location = new System.Drawing.Point(38, 257);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(75, 23);
            this.logxy.TabIndex = 22;
            this.logxy.Text = "logx(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.act_Click);
            // 
            // Ostxy
            // 
            this.Ostxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ostxy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ostxy.Location = new System.Drawing.Point(118, 256);
            this.Ostxy.Name = "Ostxy";
            this.Ostxy.Size = new System.Drawing.Size(75, 23);
            this.Ostxy.TabIndex = 23;
            this.Ostxy.Text = "%(x/y)";
            this.Ostxy.UseVisualStyleBackColor = true;
            this.Ostxy.Click += new System.EventHandler(this.act_Click);
            // 
            // min
            // 
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.min.Location = new System.Drawing.Point(37, 296);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 24;
            this.min.Text = "min(x,y)";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.act_Click);
            // 
            // max
            // 
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.max.Location = new System.Drawing.Point(118, 296);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 25;
            this.max.Text = "max(x,y)";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.act_Click);
            // 
            // Average
            // 
            this.Average.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Average.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Average.Location = new System.Drawing.Point(37, 335);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(75, 23);
            this.Average.TabIndex = 26;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.act_Click);
            // 
            // Geometric
            // 
            this.Geometric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geometric.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Geometric.Location = new System.Drawing.Point(117, 334);
            this.Geometric.Name = "Geometric";
            this.Geometric.Size = new System.Drawing.Size(75, 23);
            this.Geometric.TabIndex = 27;
            this.Geometric.Text = "Geometric";
            this.Geometric.UseVisualStyleBackColor = true;
            this.Geometric.Click += new System.EventHandler(this.act_Click);
            // 
            // EdegreeX
            // 
            this.EdegreeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdegreeX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EdegreeX.Location = new System.Drawing.Point(244, 334);
            this.EdegreeX.Name = "EdegreeX";
            this.EdegreeX.Size = new System.Drawing.Size(75, 23);
            this.EdegreeX.TabIndex = 28;
            this.EdegreeX.Text = "e^x";
            this.EdegreeX.UseVisualStyleBackColor = true;
            this.EdegreeX.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // DivisionX
            // 
            this.DivisionX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DivisionX.Location = new System.Drawing.Point(334, 335);
            this.DivisionX.Name = "DivisionX";
            this.DivisionX.Size = new System.Drawing.Size(75, 23);
            this.DivisionX.TabIndex = 29;
            this.DivisionX.Text = "1/X";
            this.DivisionX.UseVisualStyleBackColor = true;
            this.DivisionX.Click += new System.EventHandler(this.OneArgumentOperation_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 410);
            this.Controls.Add(this.DivisionX);
            this.Controls.Add(this.EdegreeX);
            this.Controls.Add(this.Geometric);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.Ostxy);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.xTo1dY);
            this.Controls.Add(this.xdegreey);
            this.Controls.Add(this.logtwo);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.degreeoften);
            this.Controls.Add(this.module);
            this.Controls.Add(this.lognature);
            this.Controls.Add(this.degreeofx);
            this.Controls.Add(this.degreeoftwo);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button generation;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button degreeoftwo;
        private System.Windows.Forms.Button degreeofx;
        private System.Windows.Forms.Button lognature;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button degreeoften;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button logtwo;
        private System.Windows.Forms.Button xdegreey;
        private System.Windows.Forms.Button xTo1dY;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button Ostxy;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Geometric;
        private System.Windows.Forms.Button EdegreeX;
        private System.Windows.Forms.Button DivisionX;
    }
}

