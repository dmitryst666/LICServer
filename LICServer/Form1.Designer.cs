namespace LICServer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.connDB = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N/A";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "CreateDB";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // connDB
            // 
            this.connDB.Location = new System.Drawing.Point(93, 12);
            this.connDB.Name = "connDB";
            this.connDB.Size = new System.Drawing.Size(100, 23);
            this.connDB.TabIndex = 2;
            this.connDB.Text = "Connect to DB";
            this.connDB.UseVisualStyleBackColor = true;
            this.connDB.Click += new System.EventHandler(this.connDB_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(199, 12);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(100, 23);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Read All from DB";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.AllowUserToOrderColumns = true;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(12, 41);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(776, 384);
            this.dgvViewer.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate HWID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.connDB);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button connDB;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button button1;
    }
}

