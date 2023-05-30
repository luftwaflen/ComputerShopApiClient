namespace WinFormsApiClient
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Component = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_GetAllComp = new System.Windows.Forms.Button();
            this.button_AddComp = new System.Windows.Forms.Button();
            this.button_UpdateComp = new System.Windows.Forms.Button();
            this.button_DeleteComp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Component.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Component);
            this.tabControl1.Controls.Add(this.Order);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Component
            // 
            this.Component.Controls.Add(this.button_DeleteComp);
            this.Component.Controls.Add(this.button_UpdateComp);
            this.Component.Controls.Add(this.button_AddComp);
            this.Component.Controls.Add(this.button_GetAllComp);
            this.Component.Controls.Add(this.label5);
            this.Component.Controls.Add(this.label4);
            this.Component.Controls.Add(this.label3);
            this.Component.Controls.Add(this.label2);
            this.Component.Controls.Add(this.label1);
            this.Component.Controls.Add(this.textBox5);
            this.Component.Controls.Add(this.textBox4);
            this.Component.Controls.Add(this.textBox3);
            this.Component.Controls.Add(this.textBox2);
            this.Component.Controls.Add(this.textBox1);
            this.Component.Controls.Add(this.dataGridView1);
            this.Component.Location = new System.Drawing.Point(4, 24);
            this.Component.Name = "Component";
            this.Component.Padding = new System.Windows.Forms.Padding(3);
            this.Component.Size = new System.Drawing.Size(792, 422);
            this.Component.TabIndex = 0;
            this.Component.Text = "Component";
            this.Component.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(4, 24);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(792, 422);
            this.Order.TabIndex = 1;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 349);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(261, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(261, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Coast:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "ImageUrl:";
            // 
            // button_GetAllComp
            // 
            this.button_GetAllComp.Location = new System.Drawing.Point(457, 270);
            this.button_GetAllComp.Name = "button_GetAllComp";
            this.button_GetAllComp.Size = new System.Drawing.Size(96, 35);
            this.button_GetAllComp.TabIndex = 11;
            this.button_GetAllComp.Text = "GetAll";
            this.button_GetAllComp.UseVisualStyleBackColor = true;
            this.button_GetAllComp.Click += new System.EventHandler(this.button_GetAllComp_Click);
            // 
            // button_AddComp
            // 
            this.button_AddComp.Location = new System.Drawing.Point(584, 270);
            this.button_AddComp.Name = "button_AddComp";
            this.button_AddComp.Size = new System.Drawing.Size(96, 35);
            this.button_AddComp.TabIndex = 12;
            this.button_AddComp.Text = "Add";
            this.button_AddComp.UseVisualStyleBackColor = true;
            this.button_AddComp.Click += new System.EventHandler(this.button_AddComp_Click);
            // 
            // button_UpdateComp
            // 
            this.button_UpdateComp.Location = new System.Drawing.Point(457, 329);
            this.button_UpdateComp.Name = "button_UpdateComp";
            this.button_UpdateComp.Size = new System.Drawing.Size(96, 35);
            this.button_UpdateComp.TabIndex = 13;
            this.button_UpdateComp.Text = "Update";
            this.button_UpdateComp.UseVisualStyleBackColor = true;
            this.button_UpdateComp.Click += new System.EventHandler(this.button_UpdateComp_Click);
            // 
            // button_DeleteComp
            // 
            this.button_DeleteComp.Location = new System.Drawing.Point(584, 329);
            this.button_DeleteComp.Name = "button_DeleteComp";
            this.button_DeleteComp.Size = new System.Drawing.Size(96, 35);
            this.button_DeleteComp.TabIndex = 14;
            this.button_DeleteComp.Text = "Delete";
            this.button_DeleteComp.UseVisualStyleBackColor = true;
            this.button_DeleteComp.Click += new System.EventHandler(this.button_DeleteComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Component.ResumeLayout(false);
            this.Component.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Component;
        private TabPage Order;
        private Button button_DeleteComp;
        private Button button_UpdateComp;
        private Button button_AddComp;
        private Button button_GetAllComp;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}