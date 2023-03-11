
namespace demexam
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.dateTimeOrder = new System.Windows.Forms.DateTimePicker();
            this.cboxClient = new System.Windows.Forms.ComboBox();
            this.cboxService = new System.Windows.Forms.ComboBox();
            this.tboxCost = new System.Windows.Forms.TextBox();
            this.tboxPercent = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(717, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новый заказ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата оформления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Клиент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Услуга:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Стоимость, руб.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(389, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "С учетом скидки, %:";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowTemplate.Height = 25;
            this.dataGridOrders.Size = new System.Drawing.Size(780, 225);
            this.dataGridOrders.TabIndex = 8;
            this.dataGridOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellValueChanged);
            // 
            // dateTimeOrder
            // 
            this.dateTimeOrder.CustomFormat = "yyyy-MM-dd";
            this.dateTimeOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOrder.Location = new System.Drawing.Point(161, 308);
            this.dateTimeOrder.Name = "dateTimeOrder";
            this.dateTimeOrder.Size = new System.Drawing.Size(200, 23);
            this.dateTimeOrder.TabIndex = 10;
            // 
            // cboxClient
            // 
            this.cboxClient.FormattingEnabled = true;
            this.cboxClient.Location = new System.Drawing.Point(161, 340);
            this.cboxClient.Name = "cboxClient";
            this.cboxClient.Size = new System.Drawing.Size(200, 23);
            this.cboxClient.TabIndex = 11;
            // 
            // cboxService
            // 
            this.cboxService.FormattingEnabled = true;
            this.cboxService.Location = new System.Drawing.Point(161, 369);
            this.cboxService.Name = "cboxService";
            this.cboxService.Size = new System.Drawing.Size(200, 23);
            this.cboxService.TabIndex = 12;
            // 
            // tboxCost
            // 
            this.tboxCost.Location = new System.Drawing.Point(161, 399);
            this.tboxCost.Name = "tboxCost";
            this.tboxCost.Size = new System.Drawing.Size(200, 23);
            this.tboxCost.TabIndex = 13;
            // 
            // tboxPercent
            // 
            this.tboxPercent.Location = new System.Drawing.Point(542, 399);
            this.tboxPercent.Name = "tboxPercent";
            this.tboxPercent.Size = new System.Drawing.Size(200, 23);
            this.tboxPercent.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(624, 369);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(622, 308);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(120, 23);
            this.btnAddData.TabIndex = 16;
            this.btnAddData.Text = "Добавить заказ";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(672, 243);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 23);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Обновить данные";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tboxPercent);
            this.Controls.Add(this.tboxCost);
            this.Controls.Add(this.cboxService);
            this.Controls.Add(this.cboxClient);
            this.Controls.Add(this.dateTimeOrder);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.DateTimePicker dateTimeOrder;
        private System.Windows.Forms.ComboBox cboxClient;
        private System.Windows.Forms.ComboBox cboxService;
        private System.Windows.Forms.TextBox tboxCost;
        private System.Windows.Forms.TextBox tboxPercent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnReload;
    }
}