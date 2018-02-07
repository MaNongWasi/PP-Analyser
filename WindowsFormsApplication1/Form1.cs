using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String fileName= null;
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle[] squares = new Rectangle[64];
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw color bar
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(400, 200, 350, 50);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Blue, Color.Red, LinearGradientMode.Horizontal);
            
            Pen pen = new Pen(brush);
            g.FillRectangle(brush, rect);
            pen.Dispose();
            brush.Dispose();

            //draw square
            for (int i = 0; i < squares.Length; ++i)
            {
                squares[i] = new Rectangle(30 + i / 8 * 35, 70 + i % 8 * 35, 35, 35);
            }

            Pen sp = new Pen(Color.Black, 1);
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangles(sb, squares);
            g.DrawRectangles(sp, squares);
            sb.Dispose();
            sp.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init_param();
            openFileDialog1.InitialDirectory = "Desktop";//"C:\\";
            openFileDialog1.Filter = "Text Document (*.txt)| *.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog1.FileName;
                    textBox1.Text = fileName;
                    openFile();
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        const int l = 20;
        int line_nr = 0;
        string s = "";
        Dictionary<string, float[]> dict = new Dictionary<string, float[]>();
        ArrayList date_array = new ArrayList();
        string[] lines;
        bool pause = true;

        private void openFile()
        {
            if(fileName != null)
            {
                try
                {
                    StreamReader fs = new StreamReader(fileName);
                    s = fs.ReadToEnd();             
                    fs.Close();
                    updateUI(s);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("File Name is not Defined");
            }
        }

        private void updateUI(string s)
        {
            lines = s.Split(new[] { "\n" }, StringSplitOptions.None);
            get_array(l);
            line_nr += l;
          
            if (date_array.Count > 0)
            {
                compare_array(0);
            }
        }

        private void get_array(int count)
        {
            date_array.Clear();
            dict.Clear();

            total_lb.Text = count.ToString();

            string[] line;
            for(int i = 0; i < count; ++i)
            {
                line = lines[i+line_nr].Split(new[] { "," }, StringSplitOptions.None);
                if (line.Length == 65)
                {
                    date_array.Add(line[0]);
                    dict.Add(line[0], Array.ConvertAll(line.Skip(1).ToArray(), float.Parse));
                }
            }

            if(date_array.Count > 0)
            {
                trackBar1.Maximum = date_array.Count - 1;
                st_lb.Text = date_array[0].ToString();
                et_lb.Text = (string)date_array[date_array.Count - 1];
                ct_lb.Text = (string)date_array[trackBar1.Value];
            }
            
        }

        private void compare_array(int nr)
        {
            ct_lb.Text = (string)date_array[nr];
            float[] arr = dict[ct_lb.Text];
            float min = arr[0], max = arr[0];
            float sum = 0.0f;
            for(int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
                if(min > arr[i])
                {
                    min = arr[i];
                }

                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            detail_lb.Text = String.Format("Min = {0:f1}   Max = {1:f1}   Gain = {2:f1}", min, max, sum/arr.Length); //"Min = " + min + "   Max = " + max +"   Gain = " + sum/arr.Length;
            draw_squares(arr, min, 255/(max- min));
        }

        private void draw_squares(float[] data, float min, float times)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Blue);
            for (int i = 0; i < data.Length; ++i)
            {
                int red_color = (int)((data[i] - min) * times);
                brush = new SolidBrush(Color.FromArgb(red_color, 0, 255 - red_color));
                g.FillRectangle(brush, squares[i]);
            }

            g.DrawRectangles(pen, squares);
            brush.Dispose();
            pen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
            time_tb.Text = "1000";
            tc_tb.Text = l.ToString();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if(date_array != null)
            {
                if (date_array.Count > 0 && trackBar1.Value < date_array.Count)
                {
                    compare_array(trackBar1.Value);
                }
            }
            
        }

        private void next_bt_Click(object sender, EventArgs e)
        {
            if (check_file()){
                if (!change_view(trackBar1.Value + 1))
                {
                    MessageBox.Show("Already to the end.");
                }        
            }
        }

        private void before_bt_Click(object sender, EventArgs e)
        {
            if (check_file()){
                if (!change_view(trackBar1.Value - 1))
                {
                    MessageBox.Show("Already to the end.");
                }
            }
        }

        private bool change_view(int value)
        {
            if (value >= 0 && value < date_array.Count)
            {
                trackBar1.Value = value;
                compare_array(value);
                current_lb.Text = (value+1).ToString();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void play_bt_Click(object sender, EventArgs e)
        {    
            if(check_file())
            {
                if (pause)
                {
                    try
                    {
                        timer1.Interval = Int32.Parse(time_tb.Text);
                    }catch(Exception es)
                    {
                        MessageBox.Show("Error  " + es.Message);
                        timer1.Interval = 1000;
                    }

                    if (trackBar1.Value == trackBar1.Maximum)
                    {
                        trackBar1.Value = 0;
                    }

                    timer1.Enabled = true;
                    play_bt.Text = "Pause";
                }
                else
                {
                    timer1.Enabled = false;
                    play_bt.Text = "Play";
                }
                pause = !pause;
            }
        }

        private void nextq_bt_Click(object sender, EventArgs e)
        {
            if (check_file())
            {
                int count = get_count();
                if(line_nr >= 0 && line_nr < lines.Length)
                {
                    if(line_nr + count >= lines.Length)
                    {
                        count = lines.Length - line_nr;
                    }

                    get_array(count);
                    line_nr += count;
                }
                else
                {
                    MessageBox.Show("Already to the end");
                }
            }               
        }

        private void lastq_bt_Click(object sender, EventArgs e)
        {
            if (check_file())
            {
                int count = get_count();
                if (line_nr > 0 && line_nr <= lines.Length)
                {
                    if (line_nr <= count) //line_nr - count <= 0
                    {
                        count = line_nr; //0 + line_nr
                    }
                    line_nr -= count;
                    get_array(count);
                }
                else
                {
                    MessageBox.Show("Already to the end");
                }
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            if (!change_view(++value))
            {
                timer1.Enabled = false;
                play_bt.Text = "Play";
                pause = !pause;
                //MessageBox.Show("Already to the end.");
            }
        }

        private bool check_file()
        {
            if (lines.Length > 0) {
                return true;
            }
            else
            {
                MessageBox.Show("Please load file");
                return false;
            }
        }

        private int get_count()
        {
            int count = l;

            try
            {
                count = Int32.Parse(tc_tb.Text);
            }
            catch (Exception es)
            {
                MessageBox.Show("Error  " + es.Message);
                count = l;
            }
            
            return count;
        }

        private void init_param()
        {
            line_nr = 0;
            date_array.Clear();
            dict.Clear();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bool enter = false;
            for (int i = 0; i < squares.Length; ++i)
            {
                if (squares[i].Contains(e.Location))
                {
                    enter = true;
                    if(dict.Count > 0)
                    {
                        toolTip1.Show(String.Format("{0:f1}", dict[ct_lb.Text][i]), this, e.Location);
                    }
                }
            }
            if (!enter)
            {
                toolTip1.Hide(this);
            }
        }

        private void tc_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(date_array.Contains(st_lb.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    line_nr = date_array.IndexOf(st_lb.Text);
                    int count = get_count();
                    if (line_nr >= 0 && line_nr < lines.Length)
                    {
                        if (line_nr + count >= lines.Length)
                        {
                            count = lines.Length - line_nr;
                        }

                        get_array(count);
                        line_nr += count;
                    }
                }
            }
        }
    }
}
