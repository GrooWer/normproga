namespace WindowsFormsApp3
{
    partial class Навигация
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
            this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
            this.btnGoToAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(595, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите действие";
            // 
            // btnGoToFillOrCancel
            // 
            this.btnGoToFillOrCancel.Location = new System.Drawing.Point(130, 308);
            this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            this.btnGoToFillOrCancel.Size = new System.Drawing.Size(220, 23);
            this.btnGoToFillOrCancel.TabIndex = 5;
            this.btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
            this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            this.btnGoToFillOrCancel.Click += new System.EventHandler(this.btnGoToFillOrCancel_Click);
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.Location = new System.Drawing.Point(130, 195);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(191, 23);
            this.btnGoToAdd.TabIndex = 4;
            this.btnGoToAdd.Text = "Добавить учётную запись";
            this.btnGoToAdd.UseVisualStyleBackColor = true;
            this.btnGoToAdd.Click += new System.EventHandler(this.btnGoToAdd_Click);
            // 
            // Навигация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoToFillOrCancel);
            this.Controls.Add(this.btnGoToAdd);
            this.Name = "Навигация";
            this.Text = "Навигация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToFillOrCancel;
        private System.Windows.Forms.Button btnGoToAdd;
    }
}