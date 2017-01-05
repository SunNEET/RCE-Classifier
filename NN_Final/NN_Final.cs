using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NN_Final
{
    public partial class NN_Final : Form
    {
        InputZoneHandler input_handle;
        RCE rce;
        public int ClassSelect = 0;
        public NN_Final()
        {
            InitializeComponent();
            input_handle = new InputZoneHandler(pictureBox_InputZone);
            rce          = new RCE(input_handle.input);

            radioButton_ClassA.Tag = 1;
            radioButton_ClassB.Tag = 2;
            radioButton_ClassC.Tag = 3;
            PictureBox picbox      = pictureBox_InputZone;
            picbox.BackgroundImage = new Bitmap(picbox.Size.Width, picbox.Size.Height);
            picbox.Image           = new Bitmap(picbox.Size.Width, picbox.Size.Height);
        }

        public void SetLog(string log)
        {
            richTextBox_Log.Parent.Invoke((MethodInvoker)delegate
            {
                richTextBox_Log.Text = log.ToString();
                richTextBox_Log.SelectionStart = richTextBox_Log.TextLength;
                richTextBox_Log.ScrollToCaret();
            });
        }
        private void pictureBox_InputZone_MouseClick(object sender, MouseEventArgs e)
        {
            input_handle.AddInput(ClassSelect, e.X, e.Y);
            //input_handle.RCE_DrawRegion(0, e.X, e.Y,20);
            Refresh_DataGridView();
        }

        private void radioButton_Class_Click(object sender, EventArgs e)
        {
            ClassSelect = (int)((Control)sender).Tag;
            Refresh_DataGridView();
        }
        public void Refresh_DataGridView()
        {
            int id_cnt = 0;
            dataGridView_PosList.Rows.Clear();
            foreach(LF_Pair input in input_handle.input.inputs)
            {
                if(input.Class == ClassSelect)
                {
                    string pos = String.Format("({0,3},{1,3})", input.X, input.Y);
                    dataGridView_PosList.Rows.Add(id_cnt, pos);
                    id_cnt++;
                }
            }
            if (dataGridView_PosList.Rows.Count>0)
                dataGridView_PosList.FirstDisplayedScrollingRowIndex = dataGridView_PosList.Rows.Count - 1;
            dataGridView_PosList.Refresh();
        }

        private void button_ComputerRCE_Click(object sender, EventArgs e)
        {
            rce.Compute();
            SetLog(rce.log);
            DrawCircleZones();
        }

        public void DrawCircleZones()
        {
            
            
            using(Graphics g = Graphics.FromImage(pictureBox_InputZone.Image))
            {
                g.Clear(Color.Transparent);
                
                for(int j=0;j<rce.lamda_j.Count;++j)
                {
                    Pen pen = new Pen(InputZoneHandler.C_Map[rce.W[j].Class]);
                    int r = (int)rce.lamda_j[j];
                    int x = (int)rce.W[j].w[0];
                    int y = (int)rce.W[j].w[1];
                    Rectangle rect = new Rectangle(x - r, y - r, 2 * r, 2 * r);
                    ///
                    Color Mycolor = System.Drawing.Color.FromArgb(128, InputZoneHandler.C_Map[rce.W[j].Class]);
                    SolidBrush sbl = new SolidBrush(Mycolor);
                    g.FillEllipse(sbl, x - r, y - r, 2 * r, 2 * r);
                    ///
                    g.DrawEllipse(pen, rect);
                }
            }
            pictureBox_InputZone.Refresh();
        }

        private void button_CLR_Input_Click(object sender, EventArgs e)
        {
            //pictureBox_InputZone = Old_PicBox;
            //pictureBox_InputZone = new PictureBox();
            //input_handle.pb_ref = new PictureBox();
            using (Graphics g = Graphics.FromImage(pictureBox_InputZone.Image))
            {
                g.Clear(Color.Transparent);
            }
            using (Graphics g = Graphics.FromImage(input_handle.pb_ref.BackgroundImage))
            {
                g.Clear(Color.Transparent);
            }
            pictureBox_InputZone.Refresh();
            dataGridView_PosList.Rows.Clear();
            dataGridView_PosList.Refresh();
            input_handle.input.inputs.Clear();

        }

        private void button_RandomGenerate_Click(object sender, EventArgs e)
        {
            int[] rndX = new int[5];
            int[] rndY = new int[5];
            for(int i = 0; i < 5; i++)
            {
                rndX[i] = new Random(System.DateTime.Now.Millisecond).Next(700);
                rndY[i] = new Random(rndX[i]).Next(600);

                input_handle.AddInput(ClassSelect, rndX[i], rndY[i]);
                Refresh_DataGridView();
            }

        }
    }
    public class InputZoneHandler
    {
        const int Radius = 5;
        public static Dictionary<int, Color> C_Map;
        public PictureBox pb_ref;
        public Input input;
        public InputZoneHandler(PictureBox pb_in)
        {
            pb_ref = pb_in;
            input = new Input();
            C_Map_Init();
        }
        public void C_Map_Init()
        {
            C_Map = new Dictionary<int, Color>();
            C_Map.Add(0, Color.Gray);
            C_Map.Add(1, Color.Red);
            C_Map.Add(2, Color.Green);
            C_Map.Add(3, Color.Blue);
        }
        public void ClearInput()
        {
            input.Clear();
            using(Graphics g = Graphics.FromImage(pb_ref.BackgroundImage))
            {
                g.Clear(Color.Transparent);
            }
            pb_ref.Refresh();
        }
        public void AddInput(int Class,int X,int Y)
        {
            SolidBrush Brush = new SolidBrush(C_Map[Class]);
            Pen pen = new Pen(Color.Black);
            input.Add(Class, (double)X, (double)Y);
            Rectangle rect = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);

            using (Graphics g = Graphics.FromImage(pb_ref.BackgroundImage))
            {
                g.FillEllipse(Brush,rect);
                g.DrawEllipse(pen, rect);
            }
            pb_ref.Refresh();
        }
        public void RCE_DrawRegion(int Class,int X,int Y ,int r)
        {
            Pen pen = new Pen(C_Map[Class]);
            Rectangle rect = new Rectangle(X - r, Y - r, 2 * r, 2 * r);
            using (Graphics g = Graphics.FromImage(pb_ref.Image))
            {
                g.DrawEllipse(pen, rect);
            }
            pb_ref.Refresh();
        }
    }
}
