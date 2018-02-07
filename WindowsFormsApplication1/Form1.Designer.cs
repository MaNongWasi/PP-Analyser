namespace WindowsFormsApplication1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.detail_lb = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.st_lb = new System.Windows.Forms.Label();
            this.et_lb = new System.Windows.Forms.Label();
            this.ct_lb = new System.Windows.Forms.Label();
            this.before_bt = new System.Windows.Forms.Button();
            this.play_bt = new System.Windows.Forms.Button();
            this.next_bt = new System.Windows.Forms.Button();
            this.lastq_bt = new System.Windows.Forms.Button();
            this.nextq_bt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.current_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 20);
            this.textBox1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detail_lb
            // 
            this.detail_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_lb.Location = new System.Drawing.Point(459, 361);
            this.detail_lb.Name = "detail_lb";
            this.detail_lb.Size = new System.Drawing.Size(313, 27);
            this.detail_lb.TabIndex = 68;
            this.detail_lb.Text = "Min = 0   Max = 0   Gain = 0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 395);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(511, 45);
            this.trackBar1.TabIndex = 69;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Hot";
            // 
            // st_lb
            // 
            this.st_lb.AutoSize = true;
            this.st_lb.Location = new System.Drawing.Point(36, 443);
            this.st_lb.Name = "st_lb";
            this.st_lb.Size = new System.Drawing.Size(55, 13);
            this.st_lb.TabIndex = 74;
            this.st_lb.Text = "Start Time";
            // 
            // et_lb
            // 
            this.et_lb.AutoSize = true;
            this.et_lb.Location = new System.Drawing.Point(451, 443);
            this.et_lb.Name = "et_lb";
            this.et_lb.Size = new System.Drawing.Size(52, 13);
            this.et_lb.TabIndex = 75;
            this.et_lb.Text = "End Time";
            // 
            // ct_lb
            // 
            this.ct_lb.AutoSize = true;
            this.ct_lb.Location = new System.Drawing.Point(566, 395);
            this.ct_lb.Name = "ct_lb";
            this.ct_lb.Size = new System.Drawing.Size(75, 13);
            this.ct_lb.TabIndex = 76;
            this.ct_lb.Text = "Choosen Time";
            // 
            // before_bt
            // 
            this.before_bt.Location = new System.Drawing.Point(403, 129);
            this.before_bt.Name = "before_bt";
            this.before_bt.Size = new System.Drawing.Size(54, 23);
            this.before_bt.TabIndex = 77;
            this.before_bt.Text = "Last";
            this.before_bt.UseVisualStyleBackColor = true;
            this.before_bt.Click += new System.EventHandler(this.before_bt_Click);
            // 
            // play_bt
            // 
            this.play_bt.Location = new System.Drawing.Point(546, 129);
            this.play_bt.Name = "play_bt";
            this.play_bt.Size = new System.Drawing.Size(52, 23);
            this.play_bt.TabIndex = 78;
            this.play_bt.Text = "Play";
            this.play_bt.UseVisualStyleBackColor = true;
            this.play_bt.Click += new System.EventHandler(this.play_bt_Click);
            // 
            // next_bt
            // 
            this.next_bt.Location = new System.Drawing.Point(700, 129);
            this.next_bt.Name = "next_bt";
            this.next_bt.Size = new System.Drawing.Size(52, 23);
            this.next_bt.TabIndex = 79;
            this.next_bt.Text = "Next";
            this.next_bt.UseVisualStyleBackColor = true;
            this.next_bt.Click += new System.EventHandler(this.next_bt_Click);
            // 
            // lastq_bt
            // 
            this.lastq_bt.Location = new System.Drawing.Point(566, 422);
            this.lastq_bt.Name = "lastq_bt";
            this.lastq_bt.Size = new System.Drawing.Size(57, 23);
            this.lastq_bt.TabIndex = 80;
            this.lastq_bt.Text = "Last";
            this.lastq_bt.UseVisualStyleBackColor = true;
            this.lastq_bt.Click += new System.EventHandler(this.lastq_bt_Click);
            // 
            // nextq_bt
            // 
            this.nextq_bt.Location = new System.Drawing.Point(665, 422);
            this.nextq_bt.Name = "nextq_bt";
            this.nextq_bt.Size = new System.Drawing.Size(53, 23);
            this.nextq_bt.TabIndex = 81;
            this.nextq_bt.Text = "Next";
            this.nextq_bt.UseVisualStyleBackColor = true;
            this.nextq_bt.Click += new System.EventHandler(this.nextq_bt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_tb
            // 
            this.time_tb.Location = new System.Drawing.Point(546, 94);
            this.time_tb.Name = "time_tb";
            this.time_tb.Size = new System.Drawing.Size(50, 20);
            this.time_tb.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "ms";
            // 
            // tc_tb
            // 
            this.tc_tb.Location = new System.Drawing.Point(739, 391);
            this.tc_tb.Name = "tc_tb";
            this.tc_tb.Size = new System.Drawing.Size(48, 20);
            this.tc_tb.TabIndex = 84;
            this.tc_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tc_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tc_tb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Track Count";
            // 
            // current_lb
            // 
            this.current_lb.AutoSize = true;
            this.current_lb.Location = new System.Drawing.Point(205, 443);
            this.current_lb.Name = "current_lb";
            this.current_lb.Size = new System.Drawing.Size(13, 13);
            this.current_lb.TabIndex = 86;
            this.current_lb.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Current:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Total:";
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Location = new System.Drawing.Point(276, 443);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(13, 13);
            this.total_lb.TabIndex = 89;
            this.total_lb.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.current_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tc_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.nextq_bt);
            this.Controls.Add(this.lastq_bt);
            this.Controls.Add(this.next_bt);
            this.Controls.Add(this.play_bt);
            this.Controls.Add(this.before_bt);
            this.Controls.Add(this.ct_lb);
            this.Controls.Add(this.et_lb);
            this.Controls.Add(this.st_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.detail_lb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label detail_lb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label st_lb;
        private System.Windows.Forms.Label et_lb;
        private System.Windows.Forms.Label ct_lb;
        private System.Windows.Forms.Button before_bt;
        private System.Windows.Forms.Button play_bt;
        private System.Windows.Forms.Button next_bt;
        private System.Windows.Forms.Button lastq_bt;
        private System.Windows.Forms.Button nextq_bt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox time_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label current_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total_lb;
    }
}

