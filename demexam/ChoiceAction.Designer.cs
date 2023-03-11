
namespace demexam
{
    partial class ChoiceAction
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
            this.btnOpenAddClients = new System.Windows.Forms.Button();
            this.btnOpenOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenAddClients
            // 
            this.btnOpenAddClients.Location = new System.Drawing.Point(85, 30);
            this.btnOpenAddClients.Name = "btnOpenAddClients";
            this.btnOpenAddClients.Size = new System.Drawing.Size(143, 23);
            this.btnOpenAddClients.TabIndex = 0;
            this.btnOpenAddClients.Text = "Добавление клиентов";
            this.btnOpenAddClients.UseVisualStyleBackColor = true;
            this.btnOpenAddClients.Click += new System.EventHandler(this.btnOpenAddClients_Click);
            // 
            // btnOpenOrders
            // 
            this.btnOpenOrders.Location = new System.Drawing.Point(85, 101);
            this.btnOpenOrders.Name = "btnOpenOrders";
            this.btnOpenOrders.Size = new System.Drawing.Size(143, 23);
            this.btnOpenOrders.TabIndex = 1;
            this.btnOpenOrders.Text = "Управление заказами";
            this.btnOpenOrders.UseVisualStyleBackColor = true;
            this.btnOpenOrders.Click += new System.EventHandler(this.btnOpenOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ChoiceAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenOrders);
            this.Controls.Add(this.btnOpenAddClients);
            this.Name = "ChoiceAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceAction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddClients;
        private System.Windows.Forms.Button btnOpenOrders;
        private System.Windows.Forms.Button btnExit;
    }
}