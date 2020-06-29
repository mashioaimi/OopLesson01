namespace ListCollectionSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbMaker = new System.Windows.Forms.TextBox();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btClearImage = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.btModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "車名";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(124, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 31);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "メーカー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(31, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "カテゴリ";
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCategory.Location = new System.Drawing.Point(124, 219);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(243, 31);
            this.tbCategory.TabIndex = 1;
            // 
            // tbMaker
            // 
            this.tbMaker.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaker.Location = new System.Drawing.Point(124, 131);
            this.tbMaker.Name = "tbMaker";
            this.tbMaker.Size = new System.Drawing.Size(243, 31);
            this.tbMaker.TabIndex = 1;
            // 
            // dgvCarData
            // 
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(16, 256);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.ReadOnly = true;
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(628, 186);
            this.dgvCarData.TabIndex = 2;
            this.dgvCarData.Click += new System.EventHandler(this.dgvCarData_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(580, 151);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(97, 47);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "登録";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOpenImage
            // 
            this.btOpenImage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenImage.Location = new System.Drawing.Point(581, 37);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(97, 51);
            this.btOpenImage.TabIndex = 3;
            this.btOpenImage.Text = "開く...";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(382, 30);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(193, 220);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btClearImage
            // 
            this.btClearImage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClearImage.Location = new System.Drawing.Point(581, 94);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(97, 51);
            this.btClearImage.TabIndex = 3;
            this.btClearImage.Text = "クリア";
            this.btClearImage.UseVisualStyleBackColor = true;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // btModify
            // 
            this.btModify.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btModify.Location = new System.Drawing.Point(581, 204);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(96, 46);
            this.btModify.TabIndex = 5;
            this.btModify.Text = "変更";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 454);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.tbMaker);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "車登録アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbMaker;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btClearImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.Button btModify;
    }
}

