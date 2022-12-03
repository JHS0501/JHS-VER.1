
namespace My_Server
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Receive_data = new System.Windows.Forms.Button();
            this.textBox_csv = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.uiBtn_Read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PC_connect = new System.Windows.Forms.Button();
            this.btdisconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(31, 386);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(461, 187);
            this.textBox3.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(31, 108);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(461, 152);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 28);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "536";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 28);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "192.168.0.55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP Address";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 313);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "보내기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Receive_data
            // 
            this.Btn_Receive_data.Location = new System.Drawing.Point(31, 22);
            this.Btn_Receive_data.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Receive_data.Name = "Btn_Receive_data";
            this.Btn_Receive_data.Size = new System.Drawing.Size(124, 54);
            this.Btn_Receive_data.TabIndex = 10;
            this.Btn_Receive_data.Text = "Receive_data";
            this.Btn_Receive_data.UseVisualStyleBackColor = true;
            this.Btn_Receive_data.Click += new System.EventHandler(this.btn_Receive_data_Click);
            // 
            // textBox_csv
            // 
            this.textBox_csv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_csv.Location = new System.Drawing.Point(31, 685);
            this.textBox_csv.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_csv.Multiline = true;
            this.textBox_csv.Name = "textBox_csv";
            this.textBox_csv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_csv.Size = new System.Drawing.Size(461, 186);
            this.textBox_csv.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(537, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 788);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 22);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Load_image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uiBtn_Read
            // 
            this.uiBtn_Read.Location = new System.Drawing.Point(381, 608);
            this.uiBtn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.uiBtn_Read.Name = "uiBtn_Read";
            this.uiBtn_Read.Size = new System.Drawing.Size(111, 54);
            this.uiBtn_Read.TabIndex = 18;
            this.uiBtn_Read.Text = "Read_csv";
            this.uiBtn_Read.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Port";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 337);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 28);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "192.168.0.55";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(334, 337);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 28);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "487";
            // 
            // PC_connect
            // 
            this.PC_connect.Location = new System.Drawing.Point(31, 310);
            this.PC_connect.Margin = new System.Windows.Forms.Padding(4);
            this.PC_connect.Name = "PC_connect";
            this.PC_connect.Size = new System.Drawing.Size(124, 54);
            this.PC_connect.TabIndex = 25;
            this.PC_connect.Text = "PC_Connect";
            this.PC_connect.UseVisualStyleBackColor = true;
            this.PC_connect.Click += new System.EventHandler(this.PC_connect_Click);
            // 
            // btdisconnect
            // 
            this.btdisconnect.Location = new System.Drawing.Point(379, 23);
            this.btdisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btdisconnect.Name = "btdisconnect";
            this.btdisconnect.Size = new System.Drawing.Size(113, 52);
            this.btdisconnect.TabIndex = 26;
            this.btdisconnect.Text = "disconnect";
            this.btdisconnect.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 27;
            this.button1.Text = "Make_array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 28;
            this.button4.Text = "point";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1723, 937);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btdisconnect);
            this.Controls.Add(this.PC_connect);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_csv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uiBtn_Read);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Receive_data);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "서버 Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Receive_data;
        private System.Windows.Forms.TextBox textBox_csv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button uiBtn_Read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button PC_connect;
        private System.Windows.Forms.Button btdisconnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

