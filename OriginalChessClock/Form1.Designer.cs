namespace OriginalChessClock
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
            this.components = new System.ComponentModel.Container();
            this.wtptxt = new System.Windows.Forms.NumericUpDown();
            this.startb = new System.Windows.Forms.Button();
            this.wtpl = new System.Windows.Forms.Label();
            this.btptxt = new System.Windows.Forms.NumericUpDown();
            this.btpl = new System.Windows.Forms.Label();
            this.tapttxt = new System.Windows.Forms.NumericUpDown();
            this.taptl = new System.Windows.Forms.Label();
            this.wtgl = new System.Windows.Forms.Label();
            this.btgl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.wtgtxt = new System.Windows.Forms.Label();
            this.btgtxt = new System.Windows.Forms.Label();
            this.ttxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wtptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapttxt)).BeginInit();
            this.SuspendLayout();
            // 
            // wtptxt
            // 
            this.wtptxt.Location = new System.Drawing.Point(264, 128);
            this.wtptxt.Name = "wtptxt";
            this.wtptxt.Size = new System.Drawing.Size(120, 20);
            this.wtptxt.TabIndex = 0;
            this.wtptxt.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // startb
            // 
            this.startb.Location = new System.Drawing.Point(480, 200);
            this.startb.Name = "startb";
            this.startb.Size = new System.Drawing.Size(144, 80);
            this.startb.TabIndex = 1;
            this.startb.Text = "Zapnout";
            this.startb.UseVisualStyleBackColor = true;
            this.startb.Click += new System.EventHandler(this.startb_Click);
            // 
            // wtpl
            // 
            this.wtpl.AutoSize = true;
            this.wtpl.Location = new System.Drawing.Point(272, 104);
            this.wtpl.Name = "wtpl";
            this.wtpl.Size = new System.Drawing.Size(100, 13);
            this.wtpl.TabIndex = 2;
            this.wtpl.Text = "Čas bílý v minutách";
            // 
            // btptxt
            // 
            this.btptxt.Location = new System.Drawing.Point(424, 128);
            this.btptxt.Name = "btptxt";
            this.btptxt.Size = new System.Drawing.Size(120, 20);
            this.btptxt.TabIndex = 3;
            this.btptxt.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btpl
            // 
            this.btpl.AutoSize = true;
            this.btpl.Location = new System.Drawing.Point(432, 104);
            this.btpl.Name = "btpl";
            this.btpl.Size = new System.Drawing.Size(109, 13);
            this.btpl.TabIndex = 4;
            this.btpl.Text = "Čas černý v minutách";
            // 
            // tapttxt
            // 
            this.tapttxt.Location = new System.Drawing.Point(280, 232);
            this.tapttxt.Name = "tapttxt";
            this.tapttxt.Size = new System.Drawing.Size(120, 20);
            this.tapttxt.TabIndex = 5;
            this.tapttxt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // taptl
            // 
            this.taptl.AutoSize = true;
            this.taptl.Location = new System.Drawing.Point(248, 200);
            this.taptl.Name = "taptl";
            this.taptl.Size = new System.Drawing.Size(177, 13);
            this.taptl.TabIndex = 6;
            this.taptl.Text = "Přidávání času za tah v sekundách";
            // 
            // wtgl
            // 
            this.wtgl.AutoSize = true;
            this.wtgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wtgl.Location = new System.Drawing.Point(112, 88);
            this.wtgl.Name = "wtgl";
            this.wtgl.Size = new System.Drawing.Size(97, 25);
            this.wtgl.TabIndex = 8;
            this.wtgl.Text = "Čas bílý";
            this.wtgl.Visible = false;
            // 
            // btgl
            // 
            this.btgl.AutoSize = true;
            this.btgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btgl.Location = new System.Drawing.Point(568, 88);
            this.btgl.Name = "btgl";
            this.btgl.Size = new System.Drawing.Size(125, 25);
            this.btgl.TabIndex = 10;
            this.btgl.Text = "Čas černý ";
            this.btgl.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // wtgtxt
            // 
            this.wtgtxt.AutoSize = true;
            this.wtgtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wtgtxt.Location = new System.Drawing.Point(88, 128);
            this.wtgtxt.Name = "wtgtxt";
            this.wtgtxt.Size = new System.Drawing.Size(151, 37);
            this.wtgtxt.TabIndex = 11;
            this.wtgtxt.Text = "00:00:00";
            this.wtgtxt.Visible = false;
            // 
            // btgtxt
            // 
            this.btgtxt.AutoSize = true;
            this.btgtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btgtxt.Location = new System.Drawing.Point(552, 128);
            this.btgtxt.Name = "btgtxt";
            this.btgtxt.Size = new System.Drawing.Size(151, 37);
            this.btgtxt.TabIndex = 12;
            this.btgtxt.Text = "00:00:00";
            this.btgtxt.Visible = false;
            // 
            // ttxt
            // 
            this.ttxt.AutoSize = true;
            this.ttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ttxt.Location = new System.Drawing.Point(144, 344);
            this.ttxt.Name = "ttxt";
            this.ttxt.Size = new System.Drawing.Size(248, 37);
            this.ttxt.TabIndex = 13;
            this.ttxt.Text = "Na tahu je: Bílý";
            this.ttxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ttxt);
            this.Controls.Add(this.btgtxt);
            this.Controls.Add(this.wtgtxt);
            this.Controls.Add(this.btgl);
            this.Controls.Add(this.wtgl);
            this.Controls.Add(this.taptl);
            this.Controls.Add(this.tapttxt);
            this.Controls.Add(this.btpl);
            this.Controls.Add(this.btptxt);
            this.Controls.Add(this.wtpl);
            this.Controls.Add(this.startb);
            this.Controls.Add(this.wtptxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wtptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapttxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown wtptxt;
        private System.Windows.Forms.Button startb;
        private System.Windows.Forms.Label wtpl;
        private System.Windows.Forms.NumericUpDown btptxt;
        private System.Windows.Forms.Label btpl;
        private System.Windows.Forms.NumericUpDown tapttxt;
        private System.Windows.Forms.Label taptl;
        private System.Windows.Forms.Label wtgl;
        private System.Windows.Forms.Label btgl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label wtgtxt;
        private System.Windows.Forms.Label btgtxt;
        private System.Windows.Forms.Label ttxt;
    }
}

