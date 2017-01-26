using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace BusinesLog
{
    public partial class Form1 : Form
    {

        Image m_image; // 로고 이미지 담을 객체
        DataBase m_DB = DataBase.GetInstance();

        private string WarningMsg = ""; // 정보 미입력 메세지 담는 변수

        public Form1()
        {
            InitializeComponent();
            ImageResize(); 
        }

        public void ImageResize() // 회사 로고 이미지 크기를 재조정 하여 넣음
        {
            m_image = new Bitmap("../../../Images/login.bmp");
            m_image = new Bitmap(m_image, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = m_image;
        }

        #region 텍스트 박스 입력 

        private void ID_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(TextBox_UserID.Text == "아이디")
            {
                TextBox_UserID.Text = "";
            }
        }

        private void ID_TextBox_FocusLeave(object sender, EventArgs e)
        {
            if (TextBox_UserID.Text == "")
            {
                TextBox_UserID.Text = "아이디";
            }
        }

        private void PW_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextBox_UserPW.Text == "비밀번호")
            {
                TextBox_UserPW.Text = "";
            }
        }

        private void PW_TextBox_FocusLeave(object sender, EventArgs e)
        {
            if (TextBox_UserPW.Text == "")
            {
                TextBox_UserPW.Text = "비밀번호";
            }
        }

        private void ID_TextBox_Click(object sender, EventArgs e)
        {
            if (TextBox_UserID.Text == "아이디")
            {
                TextBox_UserID.Text = "";
            }
        }

        private void PW_TextBox_Click(object sender, EventArgs e)
        {
            if (TextBox_UserPW.Text == "비밀번호")
            {
                TextBox_UserPW.Text = "";
            }
        }

        #endregion

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if(m_DB.Login(TextBox_UserID.Text, TextBox_UserPW.Text) == true)
            {
                //성공 했으면 정보를 입력하고 볼수있는 다른 폼으로 이동
            }
            else
            {
                //실패 메세지  아이디가 없다 , 비밀번호가 틀렸다
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e) // 엔터 이벤트 적용
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (TextBox_UserID.Text == "아이디")
                {
                    WarningMsg = "아이디를 입력해주세요.";
                    return;
                }
                if (TextBox_UserPW.Text == "비밀번호")
                {
                    WarningMsg = "비밀번호를 입력해주세요.";
                    return;
                }

                Login_Btn_Click(null,null);
            }
        }
    }
}
