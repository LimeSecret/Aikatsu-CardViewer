﻿using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonNina = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonNext10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonPrev10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonRandom = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonNext = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonPrev = new MaterialSkin.Controls.MaterialFlatButton();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InputCharName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.InputEndValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.InputStartValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Box8 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box7 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box6 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box5 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box4 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.Box1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonInitalize = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonRenew = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-12, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(738, 50);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 114);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(708, 571);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.ButtonNina);
            this.tabPage1.Controls.Add(this.ButtonNext10);
            this.tabPage1.Controls.Add(this.ButtonPrev10);
            this.tabPage1.Controls.Add(this.ButtonRandom);
            this.tabPage1.Controls.Add(this.ButtonNext);
            this.tabPage1.Controls.Add(this.ButtonPrev);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialProgressBar1);
            this.tabPage1.Controls.Add(this.picturebox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Card Info";
            // 
            // ButtonNina
            // 
            this.ButtonNina.AutoSize = true;
            this.ButtonNina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNina.Depth = 0;
            this.ButtonNina.Icon = null;
            this.ButtonNina.Location = new System.Drawing.Point(372, 412);
            this.ButtonNina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonNina.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNina.Name = "ButtonNina";
            this.ButtonNina.Primary = false;
            this.ButtonNina.Size = new System.Drawing.Size(53, 36);
            this.ButtonNina.TabIndex = 34;
            this.ButtonNina.Text = "Nina";
            this.ButtonNina.UseVisualStyleBackColor = true;
            this.ButtonNina.Click += new System.EventHandler(this.ButtonNina_Click);
            // 
            // ButtonNext10
            // 
            this.ButtonNext10.AutoSize = true;
            this.ButtonNext10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNext10.Depth = 0;
            this.ButtonNext10.Icon = null;
            this.ButtonNext10.Location = new System.Drawing.Point(607, 459);
            this.ButtonNext10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonNext10.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNext10.Name = "ButtonNext10";
            this.ButtonNext10.Primary = false;
            this.ButtonNext10.Size = new System.Drawing.Size(75, 36);
            this.ButtonNext10.TabIndex = 33;
            this.ButtonNext10.Text = "Next 10";
            this.ButtonNext10.UseVisualStyleBackColor = true;
            this.ButtonNext10.Click += new System.EventHandler(this.ButtonNext10_Click);
            // 
            // ButtonPrev10
            // 
            this.ButtonPrev10.AutoSize = true;
            this.ButtonPrev10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPrev10.Depth = 0;
            this.ButtonPrev10.Icon = null;
            this.ButtonPrev10.Location = new System.Drawing.Point(359, 459);
            this.ButtonPrev10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonPrev10.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonPrev10.Name = "ButtonPrev10";
            this.ButtonPrev10.Primary = false;
            this.ButtonPrev10.Size = new System.Drawing.Size(74, 36);
            this.ButtonPrev10.TabIndex = 32;
            this.ButtonPrev10.Text = "10 Prev ";
            this.ButtonPrev10.UseVisualStyleBackColor = true;
            this.ButtonPrev10.Click += new System.EventHandler(this.ButtonPrev10_Click);
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.AutoSize = true;
            this.ButtonRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRandom.Depth = 0;
            this.ButtonRandom.Icon = null;
            this.ButtonRandom.Location = new System.Drawing.Point(605, 412);
            this.ButtonRandom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonRandom.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Primary = false;
            this.ButtonRandom.Size = new System.Drawing.Size(79, 36);
            this.ButtonRandom.TabIndex = 31;
            this.ButtonRandom.Text = "Random";
            this.ButtonRandom.UseVisualStyleBackColor = true;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.AutoSize = true;
            this.ButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNext.Depth = 0;
            this.ButtonNext.Icon = null;
            this.ButtonNext.Location = new System.Drawing.Point(548, 459);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Primary = false;
            this.ButtonNext.Size = new System.Drawing.Size(55, 36);
            this.ButtonNext.TabIndex = 30;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.AutoSize = true;
            this.ButtonPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPrev.Depth = 0;
            this.ButtonPrev.Icon = null;
            this.ButtonPrev.Location = new System.Drawing.Point(436, 459);
            this.ButtonPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Primary = false;
            this.ButtonPrev.Size = new System.Drawing.Size(55, 36);
            this.ButtonPrev.TabIndex = 29;
            this.ButtonPrev.Text = "Prev";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(370, 197);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(370, 177);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Appeal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(371, 154);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(370, 135);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Character";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(370, 112);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(370, 93);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Card Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(370, 70);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(370, 51);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(397, 21);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "No.";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(16, 523);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(33, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "( / )";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(20, 513);
            this.materialProgressBar1.Maximum = 10000;
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(666, 5);
            this.materialProgressBar1.TabIndex = 17;
            // 
            // picturebox1
            // 
            this.picturebox1.Location = new System.Drawing.Point(20, 21);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(332, 475);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox1.TabIndex = 0;
            this.picturebox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.InputCharName);
            this.tabPage2.Controls.Add(this.materialLabel16);
            this.tabPage2.Controls.Add(this.InputEndValue);
            this.tabPage2.Controls.Add(this.InputStartValue);
            this.tabPage2.Controls.Add(this.materialLabel13);
            this.tabPage2.Controls.Add(this.materialLabel12);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.ButtonSearch);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.Box8);
            this.tabPage2.Controls.Add(this.Box7);
            this.tabPage2.Controls.Add(this.Box6);
            this.tabPage2.Controls.Add(this.Box5);
            this.tabPage2.Controls.Add(this.Box4);
            this.tabPage2.Controls.Add(this.Box3);
            this.tabPage2.Controls.Add(this.Box2);
            this.tabPage2.Controls.Add(this.Box1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "검색 조건";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.hat;
            this.pictureBox3.Location = new System.Drawing.Point(486, 393);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 108);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // InputCharName
            // 
            this.InputCharName.Depth = 0;
            this.InputCharName.Hint = "";
            this.InputCharName.Location = new System.Drawing.Point(37, 310);
            this.InputCharName.MaxLength = 32767;
            this.InputCharName.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputCharName.Name = "InputCharName";
            this.InputCharName.PasswordChar = '\0';
            this.InputCharName.SelectedText = "";
            this.InputCharName.SelectionLength = 0;
            this.InputCharName.SelectionStart = 0;
            this.InputCharName.Size = new System.Drawing.Size(229, 23);
            this.InputCharName.TabIndex = 16;
            this.InputCharName.TabStop = false;
            this.InputCharName.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(33, 275);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(118, 19);
            this.materialLabel16.TabIndex = 15;
            this.materialLabel16.Text = "Character Name";
            // 
            // InputEndValue
            // 
            this.InputEndValue.Depth = 0;
            this.InputEndValue.Hint = "";
            this.InputEndValue.Location = new System.Drawing.Point(442, 141);
            this.InputEndValue.MaxLength = 32767;
            this.InputEndValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputEndValue.Name = "InputEndValue";
            this.InputEndValue.PasswordChar = '\0';
            this.InputEndValue.SelectedText = "";
            this.InputEndValue.SelectionLength = 0;
            this.InputEndValue.SelectionStart = 0;
            this.InputEndValue.Size = new System.Drawing.Size(184, 23);
            this.InputEndValue.TabIndex = 14;
            this.InputEndValue.TabStop = false;
            this.InputEndValue.UseSystemPasswordChar = false;
            // 
            // InputStartValue
            // 
            this.InputStartValue.Depth = 0;
            this.InputStartValue.Hint = "";
            this.InputStartValue.Location = new System.Drawing.Point(442, 90);
            this.InputStartValue.MaxLength = 32767;
            this.InputStartValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputStartValue.Name = "InputStartValue";
            this.InputStartValue.PasswordChar = '\0';
            this.InputStartValue.SelectedText = "";
            this.InputStartValue.SelectionLength = 0;
            this.InputStartValue.SelectionStart = 0;
            this.InputStartValue.Size = new System.Drawing.Size(184, 23);
            this.InputStartValue.TabIndex = 13;
            this.InputStartValue.TabStop = false;
            this.InputStartValue.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(350, 141);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(72, 19);
            this.materialLabel13.TabIndex = 12;
            this.materialLabel13.Text = "EndValue";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(346, 92);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(79, 19);
            this.materialLabel12.TabIndex = 11;
            this.materialLabel12.Text = "StartValue";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(339, 40);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(97, 19);
            this.materialLabel11.TabIndex = 10;
            this.materialLabel11.Text = "Card Number";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSearch.Depth = 0;
            this.ButtonSearch.Icon = null;
            this.ButtonSearch.Location = new System.Drawing.Point(591, 490);
            this.ButtonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Primary = true;
            this.ButtonSearch.Size = new System.Drawing.Size(73, 36);
            this.ButtonSearch.TabIndex = 9;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(34, 40);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Rank";
            // 
            // Box8
            // 
            this.Box8.AutoSize = true;
            this.Box8.BackColor = System.Drawing.Color.White;
            this.Box8.Checked = true;
            this.Box8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box8.Depth = 0;
            this.Box8.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box8.Location = new System.Drawing.Point(109, 160);
            this.Box8.Margin = new System.Windows.Forms.Padding(0);
            this.Box8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box8.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box8.Name = "Box8";
            this.Box8.Ripple = true;
            this.Box8.Size = new System.Drawing.Size(40, 30);
            this.Box8.TabIndex = 7;
            this.Box8.Text = "N";
            this.Box8.UseVisualStyleBackColor = false;
            // 
            // Box7
            // 
            this.Box7.AutoSize = true;
            this.Box7.BackColor = System.Drawing.Color.White;
            this.Box7.Checked = true;
            this.Box7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box7.Depth = 0;
            this.Box7.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box7.Location = new System.Drawing.Point(38, 160);
            this.Box7.Margin = new System.Windows.Forms.Padding(0);
            this.Box7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box7.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box7.Name = "Box7";
            this.Box7.Ripple = true;
            this.Box7.Size = new System.Drawing.Size(47, 30);
            this.Box7.TabIndex = 6;
            this.Box7.Text = "N+";
            this.Box7.UseVisualStyleBackColor = false;
            // 
            // Box6
            // 
            this.Box6.AutoSize = true;
            this.Box6.BackColor = System.Drawing.Color.White;
            this.Box6.Checked = true;
            this.Box6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box6.Depth = 0;
            this.Box6.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box6.Location = new System.Drawing.Point(110, 130);
            this.Box6.Margin = new System.Windows.Forms.Padding(0);
            this.Box6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box6.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box6.Name = "Box6";
            this.Box6.Ripple = true;
            this.Box6.Size = new System.Drawing.Size(39, 30);
            this.Box6.TabIndex = 5;
            this.Box6.Text = "R";
            this.Box6.UseVisualStyleBackColor = false;
            // 
            // Box5
            // 
            this.Box5.AutoSize = true;
            this.Box5.BackColor = System.Drawing.Color.White;
            this.Box5.Checked = true;
            this.Box5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box5.Depth = 0;
            this.Box5.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box5.Location = new System.Drawing.Point(38, 130);
            this.Box5.Margin = new System.Windows.Forms.Padding(0);
            this.Box5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box5.Name = "Box5";
            this.Box5.Ripple = true;
            this.Box5.Size = new System.Drawing.Size(46, 30);
            this.Box5.TabIndex = 4;
            this.Box5.Text = "R+";
            this.Box5.UseVisualStyleBackColor = false;
            // 
            // Box4
            // 
            this.Box4.AutoSize = true;
            this.Box4.BackColor = System.Drawing.Color.White;
            this.Box4.Checked = true;
            this.Box4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box4.Depth = 0;
            this.Box4.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box4.Location = new System.Drawing.Point(110, 100);
            this.Box4.Margin = new System.Windows.Forms.Padding(0);
            this.Box4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box4.Name = "Box4";
            this.Box4.Ripple = true;
            this.Box4.Size = new System.Drawing.Size(47, 30);
            this.Box4.TabIndex = 3;
            this.Box4.Text = "SR";
            this.Box4.UseVisualStyleBackColor = false;
            // 
            // Box3
            // 
            this.Box3.AutoSize = true;
            this.Box3.BackColor = System.Drawing.Color.White;
            this.Box3.Checked = true;
            this.Box3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box3.Depth = 0;
            this.Box3.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box3.Location = new System.Drawing.Point(37, 100);
            this.Box3.Margin = new System.Windows.Forms.Padding(0);
            this.Box3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box3.Name = "Box3";
            this.Box3.Ripple = true;
            this.Box3.Size = new System.Drawing.Size(54, 30);
            this.Box3.TabIndex = 2;
            this.Box3.Text = "SR+";
            this.Box3.UseVisualStyleBackColor = false;
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.BackColor = System.Drawing.Color.White;
            this.Box2.Checked = true;
            this.Box2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box2.Depth = 0;
            this.Box2.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box2.Location = new System.Drawing.Point(110, 70);
            this.Box2.Margin = new System.Windows.Forms.Padding(0);
            this.Box2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box2.Name = "Box2";
            this.Box2.Ripple = true;
            this.Box2.Size = new System.Drawing.Size(47, 30);
            this.Box2.TabIndex = 1;
            this.Box2.Text = "PR";
            this.Box2.UseVisualStyleBackColor = false;
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.BackColor = System.Drawing.Color.White;
            this.Box1.Checked = true;
            this.Box1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Box1.Depth = 0;
            this.Box1.Font = new System.Drawing.Font("Roboto", 10F);
            this.Box1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box1.Location = new System.Drawing.Point(37, 70);
            this.Box1.Margin = new System.Windows.Forms.Padding(0);
            this.Box1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Box1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Box1.Name = "Box1";
            this.Box1.Ripple = true;
            this.Box1.Size = new System.Drawing.Size(55, 30);
            this.Box1.TabIndex = 0;
            this.Box1.Text = "PR+";
            this.Box1.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.materialLabel15);
            this.tabPage3.Controls.Add(this.materialLabel14);
            this.tabPage3.Controls.Add(this.ButtonInitalize);
            this.tabPage3.Controls.Add(this.ButtonRenew);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(700, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "설정";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 107);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(26, 504);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(211, 19);
            this.materialLabel15.TabIndex = 3;
            this.materialLabel15.Text = "* 프로그램을 다시 시작해야 적용됩니다.";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(26, 416);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(230, 19);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "* 로딩시 약간의 시간이 소요될 수 있습니다.";
            // 
            // ButtonInitalize
            // 
            this.ButtonInitalize.AutoSize = true;
            this.ButtonInitalize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInitalize.Depth = 0;
            this.ButtonInitalize.Icon = null;
            this.ButtonInitalize.Location = new System.Drawing.Point(30, 465);
            this.ButtonInitalize.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonInitalize.Name = "ButtonInitalize";
            this.ButtonInitalize.Primary = true;
            this.ButtonInitalize.Size = new System.Drawing.Size(194, 36);
            this.ButtonInitalize.TabIndex = 1;
            this.ButtonInitalize.Text = "데이터 초기화 (4/29/2017)";
            this.ButtonInitalize.UseVisualStyleBackColor = true;
            this.ButtonInitalize.Click += new System.EventHandler(this.ButtonInitalize_Click);
            // 
            // ButtonRenew
            // 
            this.ButtonRenew.AutoSize = true;
            this.ButtonRenew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRenew.Depth = 0;
            this.ButtonRenew.Icon = null;
            this.ButtonRenew.Location = new System.Drawing.Point(30, 377);
            this.ButtonRenew.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRenew.Name = "ButtonRenew";
            this.ButtonRenew.Primary = true;
            this.ButtonRenew.Size = new System.Drawing.Size(171, 36);
            this.ButtonRenew.TabIndex = 0;
            this.ButtonRenew.Text = "wikia에서 데이터 갱신";
            this.ButtonRenew.UseVisualStyleBackColor = true;
            this.ButtonRenew.Click += new System.EventHandler(this.ButtonRenew_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel20);
            this.tabPage4.Controls.Add(this.materialLabel19);
            this.tabPage4.Controls.Add(this.materialLabel18);
            this.tabPage4.Controls.Add(this.materialLabel17);
            this.tabPage4.Controls.Add(this.materialLabel10);
            this.tabPage4.Controls.Add(this.materialLabel9);
            this.tabPage4.Controls.Add(this.materialLabel8);
            this.tabPage4.Controls.Add(this.materialLabel7);
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(700, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "도움말";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(37, 416);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(299, 19);
            this.materialLabel20.TabIndex = 11;
            this.materialLabel20.Text = "http://aikatsu.wikia.com/wiki/Aikatsu_Wiki";
            this.materialLabel20.Click += new System.EventHandler(this.materialLabel20_Click);
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(21, 397);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(109, 19);
            this.materialLabel19.TabIndex = 10;
            this.materialLabel19.Text = "- Aikatsu Wikia";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(13, 378);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(91, 19);
            this.materialLabel18.TabIndex = 9;
            this.materialLabel18.Text = "Data Source";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(20, 172);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(162, 19);
            this.materialLabel17.TabIndex = 8;
            this.materialLabel17.Text = "- 버그 및 코드 지적 달게 받음.";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(21, 16);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(641, 19);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "* 카드를 첫 로딩할때는 카드 이미지를 인터넷에서 다운받기 때문에 느릴 수 있습니다. 이후 한번 본 카드는 빠르게 로딩됩니다.";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(21, 143);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(392, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "- DCinside Aikatsu Gallery (우유나한잔, 크-린 유저라 답 잘 안해줌.)";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(37, 112);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(380, 19);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "https://github.com/LimeSecret/Photokatsu-CardViewer";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 93);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(93, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "- LimeSecret";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 65);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Contact";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(311, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "https://github.com/IgnaceMaes/MaterialSkin";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 258);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "- MaterialSkin";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 226);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "OpenSource Information";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel21);
            this.tabPage5.Controls.Add(this.linkLabel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(700, 545);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "미세먼지 정보";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(49, 78);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(224, 19);
            this.materialLabel21.TabIndex = 1;
            this.materialLabel21.Text = "오류 때문에 못불러온다. 니가 들가서 봐라.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 83);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 686);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Form1";
            this.Text = "Photokatsu CardViewer";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonRenew;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel label10;
        private MaterialSkin.Controls.MaterialLabel label9;
        private MaterialSkin.Controls.MaterialLabel label8;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialCheckBox Box1;
        private MaterialFlatButton ButtonNext;
        private MaterialFlatButton ButtonPrev;
        private MaterialCheckBox Box4;
        private MaterialCheckBox Box3;
        private MaterialCheckBox Box2;
        private MaterialCheckBox Box8;
        private MaterialCheckBox Box7;
        private MaterialCheckBox Box6;
        private MaterialCheckBox Box5;
        private MaterialLabel materialLabel6;
        private MaterialRaisedButton ButtonSearch;
        private MaterialRaisedButton ButtonInitalize;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialFlatButton ButtonRandom;
        private MaterialLabel materialLabel9;
        private MaterialLabel materialLabel10;
        private MaterialFlatButton ButtonPrev10;
        private MaterialFlatButton ButtonNext10;
        private MaterialLabel materialLabel13;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel11;
        private MaterialSingleLineTextField InputEndValue;
        private MaterialSingleLineTextField InputStartValue;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel14;
        private MaterialSingleLineTextField InputCharName;
        private MaterialLabel materialLabel16;
        private PictureBox pictureBox2;
        private MaterialFlatButton ButtonNina;
        private PictureBox pictureBox3;
        private MaterialLabel materialLabel17;
        private MaterialLabel materialLabel18;
        private TabPage tabPage5;
        private MaterialLabel materialLabel20;
        private MaterialLabel materialLabel19;
        private MaterialLabel materialLabel21;
        private LinkLabel linkLabel1;
    }
}
