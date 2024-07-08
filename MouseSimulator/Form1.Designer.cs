namespace MouseSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCordY = new System.Windows.Forms.Label();
            this.lblCordX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkArrastarClique = new System.Windows.Forms.CheckBox();
            this.chkClicarFimMovimento = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCord = new System.Windows.Forms.Panel();
            this.txtXend = new System.Windows.Forms.TextBox();
            this.txtYend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdoParaCord = new System.Windows.Forms.RadioButton();
            this.rdoParaImg = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoDeImg = new System.Windows.Forms.RadioButton();
            this.rdoDeCord = new System.Windows.Forms.RadioButton();
            this.btnSearchImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXgo = new System.Windows.Forms.TextBox();
            this.txtYgo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pnlCord.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Alef", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Move Auto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label1, "Caio =s");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCordY);
            this.groupBox1.Controls.Add(this.lblCordX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cordenadas";
            // 
            // lblCordY
            // 
            this.lblCordY.AutoSize = true;
            this.lblCordY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCordY.Location = new System.Drawing.Point(82, 22);
            this.lblCordY.Name = "lblCordY";
            this.lblCordY.Size = new System.Drawing.Size(28, 20);
            this.lblCordY.TabIndex = 3;
            this.lblCordY.Text = "Y: ";
            // 
            // lblCordX
            // 
            this.lblCordX.AutoSize = true;
            this.lblCordX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCordX.Location = new System.Drawing.Point(17, 22);
            this.lblCordX.Name = "lblCordX";
            this.lblCordX.Size = new System.Drawing.Size(28, 20);
            this.lblCordX.TabIndex = 2;
            this.lblCordX.Text = "X: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCord);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mover";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(137, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Ocultar Imagens";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(36, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Seleciona a imagem a destino final");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkArrastarClique);
            this.groupBox3.Controls.Add(this.chkClicarFimMovimento);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(167, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ação";
            // 
            // chkArrastarClique
            // 
            this.chkArrastarClique.AutoSize = true;
            this.chkArrastarClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArrastarClique.Location = new System.Drawing.Point(132, 22);
            this.chkArrastarClique.Name = "chkArrastarClique";
            this.chkArrastarClique.Size = new System.Drawing.Size(124, 22);
            this.chkArrastarClique.TabIndex = 1;
            this.chkArrastarClique.Text = "Arrastar Clique";
            this.toolTip1.SetToolTip(this.chkArrastarClique, "Mantém o mouse pressionado enquanto é faz o trajeto.");
            this.chkArrastarClique.UseVisualStyleBackColor = true;
            // 
            // chkClicarFimMovimento
            // 
            this.chkClicarFimMovimento.AutoSize = true;
            this.chkClicarFimMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClicarFimMovimento.Location = new System.Drawing.Point(8, 22);
            this.chkClicarFimMovimento.Name = "chkClicarFimMovimento";
            this.chkClicarFimMovimento.Size = new System.Drawing.Size(116, 22);
            this.chkClicarFimMovimento.TabIndex = 0;
            this.chkClicarFimMovimento.Text = "Clicar no final";
            this.chkClicarFimMovimento.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(307, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "INICIAR";
            this.toolTip1.SetToolTip(this.button1, "teste");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(167, 343);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(276, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(14, 349);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(147, 13);
            this.lblVelocidade.TabIndex = 6;
            this.lblVelocidade.Text = "Velocidade do movimento: 10";
            this.toolTip1.SetToolTip(this.lblVelocidade, "Velocidade do cursor");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Caio ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 31);
            this.label6.TabIndex = 7;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCord
            // 
            this.pnlCord.Controls.Add(this.groupBox5);
            this.pnlCord.Controls.Add(this.label11);
            this.pnlCord.Controls.Add(this.groupBox4);
            this.pnlCord.Controls.Add(this.checkBox1);
            this.pnlCord.Location = new System.Drawing.Point(6, 23);
            this.pnlCord.Name = "pnlCord";
            this.pnlCord.Size = new System.Drawing.Size(405, 182);
            this.pnlCord.TabIndex = 13;
            // 
            // txtXend
            // 
            this.txtXend.Location = new System.Drawing.Point(59, 23);
            this.txtXend.Name = "txtXend";
            this.txtXend.Size = new System.Drawing.Size(47, 24);
            this.txtXend.TabIndex = 6;
            // 
            // txtYend
            // 
            this.txtYend.Location = new System.Drawing.Point(131, 23);
            this.txtYend.Name = "txtYend";
            this.txtYend.Size = new System.Drawing.Size(47, 24);
            this.txtYend.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "X: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Y: ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(194, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 133);
            this.label11.TabIndex = 14;
            // 
            // rdoParaCord
            // 
            this.rdoParaCord.AutoSize = true;
            this.rdoParaCord.Location = new System.Drawing.Point(16, 26);
            this.rdoParaCord.Name = "rdoParaCord";
            this.rdoParaCord.Size = new System.Drawing.Size(14, 13);
            this.rdoParaCord.TabIndex = 17;
            this.rdoParaCord.UseVisualStyleBackColor = true;
            // 
            // rdoParaImg
            // 
            this.rdoParaImg.AutoSize = true;
            this.rdoParaImg.Checked = true;
            this.rdoParaImg.Location = new System.Drawing.Point(16, 88);
            this.rdoParaImg.Name = "rdoParaImg";
            this.rdoParaImg.Size = new System.Drawing.Size(14, 13);
            this.rdoParaImg.TabIndex = 18;
            this.rdoParaImg.TabStop = true;
            this.rdoParaImg.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoDeImg);
            this.groupBox4.Controls.Add(this.rdoDeCord);
            this.groupBox4.Controls.Add(this.btnSearchImg);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtXgo);
            this.groupBox4.Controls.Add(this.txtYgo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 140);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "De:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.rdoParaImg);
            this.groupBox5.Controls.Add(this.rdoParaCord);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtYend);
            this.groupBox5.Controls.Add(this.txtXend);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Location = new System.Drawing.Point(201, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 140);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Para:";
            // 
            // rdoDeImg
            // 
            this.rdoDeImg.AutoSize = true;
            this.rdoDeImg.Checked = true;
            this.rdoDeImg.Location = new System.Drawing.Point(10, 88);
            this.rdoDeImg.Name = "rdoDeImg";
            this.rdoDeImg.Size = new System.Drawing.Size(14, 13);
            this.rdoDeImg.TabIndex = 25;
            this.rdoDeImg.TabStop = true;
            this.rdoDeImg.UseVisualStyleBackColor = true;
            // 
            // rdoDeCord
            // 
            this.rdoDeCord.AutoSize = true;
            this.rdoDeCord.Location = new System.Drawing.Point(10, 26);
            this.rdoDeCord.Name = "rdoDeCord";
            this.rdoDeCord.Size = new System.Drawing.Size(14, 13);
            this.rdoDeCord.TabIndex = 24;
            this.rdoDeCord.UseVisualStyleBackColor = true;
            // 
            // btnSearchImg
            // 
            this.btnSearchImg.FlatAppearance.BorderSize = 0;
            this.btnSearchImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImg.Image = global::MouseSimulator.Properties.Resources.open;
            this.btnSearchImg.Location = new System.Drawing.Point(104, 75);
            this.btnSearchImg.Name = "btnSearchImg";
            this.btnSearchImg.Size = new System.Drawing.Size(23, 26);
            this.btnSearchImg.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnSearchImg, "Buscar a imagem em diretórios.");
            this.btnSearchImg.UseVisualStyleBackColor = true;
            this.btnSearchImg.Click += new System.EventHandler(this.btnSearchImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(31, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Seleciona a imagem a destino final. Caso a imagem2 for encontrada, irá do ponto d" +
        "a imagem1 a imagem2.");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "ou";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label9, "Da imagem acima ou cordenadas até a imagem abaixo.");
            // 
            // txtXgo
            // 
            this.txtXgo.Location = new System.Drawing.Point(51, 23);
            this.txtXgo.Name = "txtXgo";
            this.txtXgo.Size = new System.Drawing.Size(47, 24);
            this.txtXgo.TabIndex = 17;
            // 
            // txtYgo
            // 
            this.txtYgo.Location = new System.Drawing.Point(124, 23);
            this.txtYgo.Name = "txtYgo";
            this.txtYgo.Size = new System.Drawing.Size(47, 24);
            this.txtYgo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Y: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "ou";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "Da imagem acima ou cordenadas até a imagem abaixo.");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulate Human Mouse Move";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.pnlCord.ResumeLayout(false);
            this.pnlCord.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCordY;
        private System.Windows.Forms.Label lblCordX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkArrastarClique;
        private System.Windows.Forms.CheckBox chkClicarFimMovimento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlCord;
        private System.Windows.Forms.TextBox txtXend;
        private System.Windows.Forms.TextBox txtYend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoParaImg;
        private System.Windows.Forms.RadioButton rdoParaCord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoDeImg;
        private System.Windows.Forms.RadioButton rdoDeCord;
        private System.Windows.Forms.Button btnSearchImg;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXgo;
        private System.Windows.Forms.TextBox txtYgo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

