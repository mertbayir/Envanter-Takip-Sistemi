namespace StajProjeCalisma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewVeriler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtMlzno = new System.Windows.Forms.TextBox();
            this.txtSerino = new System.Windows.Forms.TextBox();
            this.txtEnvno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.PrintDoc = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVeriler
            // 
            this.dataGridViewVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeriler.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewVeriler.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewVeriler.Name = "dataGridViewVeriler";
            this.dataGridViewVeriler.RowHeadersWidth = 51;
            this.dataGridViewVeriler.RowTemplate.Height = 24;
            this.dataGridViewVeriler.Size = new System.Drawing.Size(579, 359);
            this.dataGridViewVeriler.TabIndex = 0;
            this.dataGridViewVeriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Veri Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Veri Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(774, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Veri Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(748, 122);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(151, 22);
            this.txtKadi.TabIndex = 4;
            // 
            // txtMlzno
            // 
            this.txtMlzno.Location = new System.Drawing.Point(748, 161);
            this.txtMlzno.Name = "txtMlzno";
            this.txtMlzno.Size = new System.Drawing.Size(151, 22);
            this.txtMlzno.TabIndex = 5;
            // 
            // txtSerino
            // 
            this.txtSerino.Location = new System.Drawing.Point(748, 196);
            this.txtSerino.Name = "txtSerino";
            this.txtSerino.Size = new System.Drawing.Size(151, 22);
            this.txtSerino.TabIndex = 6;
            // 
            // txtEnvno
            // 
            this.txtEnvno.Location = new System.Drawing.Point(748, 232);
            this.txtEnvno.Name = "txtEnvno";
            this.txtEnvno.Size = new System.Drawing.Size(151, 22);
            this.txtEnvno.TabIndex = 7;
            this.txtEnvno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(622, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(623, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Malzeme No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(628, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(623, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Envanter No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(101, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "ENVANTER TAKİP SİSTEMİ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "Veri Yazdır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PrintDoc
            // 
            this.PrintDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printDialog.Enabled = true;
            this.printDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printDialog.Icon")));
            this.printDialog.Name = "printDialog";
            this.printDialog.Text = "Baskı önizleme";
            this.printDialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnvno);
            this.Controls.Add(this.txtSerino);
            this.Controls.Add(this.txtMlzno);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewVeriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVeriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtMlzno;
        private System.Windows.Forms.TextBox txtSerino;
        private System.Windows.Forms.TextBox txtEnvno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument PrintDoc;
        private System.Windows.Forms.PrintPreviewDialog printDialog;
    }
}

