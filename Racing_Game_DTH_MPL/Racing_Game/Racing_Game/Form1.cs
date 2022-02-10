using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_game
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pcb_over.Visible = false;
        }

        int gamespeed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            move(gamespeed);//toc do cua tro choi
            bug(gamespeed);//toc do chay cua bug
            gameover();
            tien(gamespeed);
            laytien();
        }

        int antien;
        Random r = new Random();
        int x;

        void bug(int speed)
        {
            if (pcb_bug1.Top >= 500)
            {
                x = r.Next(0, 200);//vi tri cua bug1 duoc chay trong khoang(0,200)
                pcb_bug1.Location = new Point(x, 0);
            }
            else
                pcb_bug1.Top += speed;

            if (pcb_bug2.Top >= 500)
            {
                x = r.Next(180, 260);//bug2 chay tu (180, 260)
                pcb_bug2.Location = new Point(x, 0);
            }
            else
                pcb_bug2.Top += speed;

            if (pcb_bug3.Top >= 500)
            {
                x = r.Next(0, 80);//vi tri cua bug3
                pcb_bug3.Location = new Point(x, 0);
            }
            else
                pcb_bug3.Top += speed;
        }

        void tien(int speed)
        {

            if (lb_tien1.Top >= 500)
            {
                x = r.Next(0, 200);
                lb_tien1.Location = new Point(x, 0);
            }
            else
                lb_tien1.Top += speed;

            if (lb_tien2.Top >= 500)
            {
                x = r.Next(0, 200);
                lb_tien2.Location = new Point(x, 0);
            }
            else
                lb_tien2.Top += speed;

            if (lb_tien3.Top >= 500)
            {
                x = r.Next(0, 200);
                lb_tien3.Location = new Point(x, 0);
            }
            else
                lb_tien3.Top += speed;

            if (lb_tien4.Top >= 500)
            {
                x = r.Next(0, 200);
                lb_tien4.Location = new Point(x, 0);
            }
            else
                lb_tien4.Top += speed;
        }

        void gameover()
        {

            if (pcb_code.Bounds.IntersectsWith(pcb_bug1.Bounds))
            {
                timer1.Enabled = false;
                pcb_over.Visible = true;
                DialogResult result = MessageBox.Show("Bạn muốn chơi lại chứ ?",
                    "Hii, it's me again!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Okey, Let's go !");
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Game Over!");
                        this.Close();
                        break;
                    default:
                        break;
                }

            }

            if (pcb_code.Bounds.IntersectsWith(pcb_bug2.Bounds))
            {
                timer1.Enabled = false;
                pcb_over.Visible = true;
                DialogResult result = MessageBox.Show("Bạn muốn chơi lại chứ ?",
                    "Hii, it's me again!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Okey, Let's go !");
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Game over!");
                        this.Close();
                        break;
                    default:
                        break;
                }

            }

            if (pcb_code.Bounds.IntersectsWith(pcb_bug3.Bounds))
            {
                timer1.Enabled = false;
                pcb_over.Visible = true;
                DialogResult result = MessageBox.Show("Bạn muốn chơi lại chứ ?",
                    "Hii, it's me again!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Okey, Let's go !");
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Game Over!");
                        this.Close();
                        break;
                    default:
                        break;
                }

            }
        }

        void move(int speed)// goi ham de di chuyen cac picturebox1,2,3,4
        {
            if (pictureBox1.Top >= 500)
                pictureBox1.Top = 0;
            else
                pictureBox1.Top += speed;

            if (pictureBox2.Top >= 500)
                pictureBox2.Top = 0;
            else
                pictureBox2.Top += speed;

            if (pictureBox3.Top >= 500)
                pictureBox3.Top = 0;
            else
                pictureBox3.Top += speed;

            if (pictureBox4.Top >= 500)
                pictureBox4.Top = 0;
            else
                pictureBox4.Top += speed;

            if (pictureBox5.Top >= 500)
                pictureBox5.Top = 0;
            else
                pictureBox5.Top += speed;

            if (pictureBox6.Top >= 500)
                pictureBox6.Top = 0;
            else
                pictureBox6.Top += speed;
        }

        void laytien()
        {
            if (pcb_code.Bounds.IntersectsWith(lb_tien1.Bounds))
            {
                antien++;
                label1.Text = "Money" + antien.ToString();
                x = r.Next(0, 200);
                lb_tien1.Location = new Point(x, 0);
            }

            if (pcb_code.Bounds.IntersectsWith(lb_tien2.Bounds))
            {
                antien++;
                label1.Text = "Money = " + antien.ToString();
                x = r.Next(0, 200);//day chi la vi tri mac dinh
                lb_tien2.Location = new Point(x, 0);
            }

            if (pcb_code.Bounds.IntersectsWith(lb_tien3.Bounds))
            {
                antien++;
                label1.Text = "Money = " + antien.ToString();
                x = r.Next(0, 200);
                lb_tien3.Location = new Point(x, 0);
            }

            if (pcb_code.Bounds.IntersectsWith(lb_tien4.Bounds))
            {
                antien++;
                label1.Text = "Money = " + antien.ToString();
                x = r.Next(0, 200);
                lb_tien4.Location = new Point(x, 0);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pcb_code.Left > 1)// muc chan de khong vuot qua man hinh ben trai
                    pcb_code.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pcb_code.Right < 315)// "code" khong vuot ra man hinh ben phai
                    pcb_code.Left += 8;
            }
            if (e.KeyCode == Keys.Up)//nhan up de dieu chinh toc do nhanh hon
            {
                if (gamespeed < 21)//muc toc do toi da la 21
                    gamespeed++;
            }
            if (e.KeyCode == Keys.Down)// nhan down de giam toc do xuong
                if (gamespeed > 1)
                    gamespeed--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Start", "Hi EveryOne, I'm box and" +
                " have a nice day!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.No:
                    MessageBox.Show("Bạn có chắc muốn thoát chứ !");
                    this.Close();
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Bắt đầu thôi nào!");
                    break;
                default:
                    break;
            }
        }


    }
}
