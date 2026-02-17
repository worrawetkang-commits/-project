namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableData = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Name = new TextBox();
            label2 = new Label();
            Total = new TextBox();
            label3 = new Label();
            Price = new TextBox();
            label4 = new Label();
            CustomerName = new TextBox();
            label5 = new Label();
            Type = new TextBox();
            label6 = new Label();
            Add = new Button();
            Del = new Button();
            Edit = new Button();
            Receipt = new Button();
            ClearAll = new Button();
            ID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TableData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TableData
            // 
            TableData.BackgroundColor = Color.FromArgb(210, 193, 193);
            TableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableData.Location = new Point(12, 12);
            TableData.Name = "TableData";
            TableData.Size = new Size(557, 448);
            TableData.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ChatGPT_Image_Feb_17__2026__11_41_21_PM;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 78);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(586, 116);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 2;
            label1.Text = "รหัสสินค้า";
            // 
            // Name
            // 
            Name.Font = new Font("Segoe UI", 12F);
            Name.Location = new Point(679, 148);
            Name.Name = "Name";
            Name.Size = new Size(266, 29);
            Name.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(586, 151);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 4;
            label2.Text = "ชื่อสินค้า";
            // 
            // Total
            // 
            Total.Font = new Font("Segoe UI", 12F);
            Total.Location = new Point(679, 218);
            Total.Name = "Total";
            Total.Size = new Size(266, 29);
            Total.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(586, 221);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 8;
            label3.Text = "จำนวนสินค้า";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 12F);
            Price.Location = new Point(679, 183);
            Price.Name = "Price";
            Price.Size = new Size(266, 29);
            Price.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(586, 186);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 6;
            label4.Text = "ราคา";
            // 
            // CustomerName
            // 
            CustomerName.Font = new Font("Segoe UI", 12F);
            CustomerName.Location = new Point(679, 288);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(266, 29);
            CustomerName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(586, 291);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 12;
            label5.Text = "ชื่อลูกค้า";
            // 
            // Type
            // 
            Type.Font = new Font("Segoe UI", 12F);
            Type.Location = new Point(679, 253);
            Type.Name = "Type";
            Type.Size = new Size(266, 29);
            Type.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(586, 256);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 10;
            label6.Text = "หมวดหมู่";
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(192, 255, 192);
            Add.Cursor = Cursors.Hand;
            Add.FlatStyle = FlatStyle.Popup;
            Add.Font = new Font("Segoe UI", 12F);
            Add.Location = new Point(608, 338);
            Add.Name = "Add";
            Add.Size = new Size(115, 53);
            Add.TabIndex = 14;
            Add.Text = "เพิ่ม";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Del
            // 
            Del.BackColor = Color.FromArgb(255, 192, 192);
            Del.Cursor = Cursors.Hand;
            Del.FlatStyle = FlatStyle.Popup;
            Del.Font = new Font("Segoe UI", 12F);
            Del.Location = new Point(729, 338);
            Del.Name = "Del";
            Del.Size = new Size(115, 53);
            Del.TabIndex = 15;
            Del.Text = "ลบ";
            Del.UseVisualStyleBackColor = false;
            Del.Click += Del_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(255, 255, 192);
            Edit.Cursor = Cursors.Hand;
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.Font = new Font("Segoe UI", 12F);
            Edit.Location = new Point(852, 338);
            Edit.Name = "Edit";
            Edit.Size = new Size(115, 53);
            Edit.TabIndex = 16;
            Edit.Text = "แก้ไข";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Receipt
            // 
            Receipt.BackColor = Color.FromArgb(192, 192, 255);
            Receipt.Cursor = Cursors.Hand;
            Receipt.FlatStyle = FlatStyle.Popup;
            Receipt.Font = new Font("Segoe UI", 12F);
            Receipt.Location = new Point(788, 397);
            Receipt.Name = "Receipt";
            Receipt.Size = new Size(115, 53);
            Receipt.TabIndex = 18;
            Receipt.Text = "ออกใบเสร็จ";
            Receipt.UseVisualStyleBackColor = false;
            Receipt.Click += Receipt_Click;
            // 
            // ClearAll
            // 
            ClearAll.BackColor = Color.FromArgb(224, 224, 224);
            ClearAll.Cursor = Cursors.Hand;
            ClearAll.FlatStyle = FlatStyle.Popup;
            ClearAll.Font = new Font("Segoe UI", 12F);
            ClearAll.Location = new Point(665, 397);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(115, 53);
            ClearAll.TabIndex = 17;
            ClearAll.Text = "ล้างทั้งหมด";
            ClearAll.UseVisualStyleBackColor = false;
            ClearAll.Click += ClearAll_Click;
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 12F);
            ID.FormattingEnabled = true;
            ID.Location = new Point(679, 113);
            ID.Name = "ID";
            ID.Size = new Size(266, 29);
            ID.TabIndex = 19;
            ID.SelectedIndexChanged += ID_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(993, 488);
            Controls.Add(ID);
            Controls.Add(Receipt);
            Controls.Add(ClearAll);
            Controls.Add(Edit);
            Controls.Add(Del);
            Controls.Add(Add);
            Controls.Add(CustomerName);
            Controls.Add(label5);
            Controls.Add(Type);
            Controls.Add(label6);
            Controls.Add(Total);
            Controls.Add(label3);
            Controls.Add(Price);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(TableData);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TableData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableData;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Name;
        private Label label2;
        private TextBox Total;
        private Label label3;
        private TextBox Price;
        private Label label4;
        private TextBox CustomerName;
        private Label label5;
        private TextBox Type;
        private Label label6;
        private Button Add;
        private Button Del;
        private Button Edit;
        private Button Receipt;
        private Button ClearAll;
        private ComboBox ID;
    }
}
