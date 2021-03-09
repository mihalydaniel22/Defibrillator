namespace Defibrillator
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
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.lbKiiras = new System.Windows.Forms.ListBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLekeres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(257, 559);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(115, 40);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(12, 559);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(173, 40);
            this.btnUj.TabIndex = 1;
            this.btnUj.Text = "Új adat megadása";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // lbKiiras
            // 
            this.lbKiiras.FormattingEnabled = true;
            this.lbKiiras.ItemHeight = 20;
            this.lbKiiras.Location = new System.Drawing.Point(12, 201);
            this.lbKiiras.Name = "lbKiiras";
            this.lbKiiras.Size = new System.Drawing.Size(360, 304);
            this.lbKiiras.TabIndex = 2;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(84, 13);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(113, 26);
            this.tbX.TabIndex = 3;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(84, 45);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(113, 26);
            this.tbY.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // btnLekeres
            // 
            this.btnLekeres.Location = new System.Drawing.Point(84, 127);
            this.btnLekeres.Name = "btnLekeres";
            this.btnLekeres.Size = new System.Drawing.Size(218, 37);
            this.btnLekeres.TabIndex = 7;
            this.btnLekeres.Text = "ADATOK LEKÉRÉSE";
            this.btnLekeres.UseVisualStyleBackColor = true;
            this.btnLekeres.Click += new System.EventHandler(this.btnLekeres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.btnLekeres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbKiiras);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Defibrillátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.ListBox lbKiiras;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLekeres;
    }
}

