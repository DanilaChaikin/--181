namespace Factory
{
    partial class Form1
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
            this.bPeople1 = new System.Windows.Forms.Button();
            this.statusMachine = new System.Windows.Forms.Label();
            this.people1 = new System.Windows.Forms.Label();
            this.loader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.item = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bPeople1
            // 
            this.bPeople1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPeople1.Location = new System.Drawing.Point(624, 375);
            this.bPeople1.Margin = new System.Windows.Forms.Padding(4);
            this.bPeople1.Name = "bPeople1";
            this.bPeople1.Size = new System.Drawing.Size(241, 49);
            this.bPeople1.TabIndex = 4;
            this.bPeople1.Text = "Создать деталь";
            this.bPeople1.UseVisualStyleBackColor = true;
            this.bPeople1.Click += new System.EventHandler(this.newItem);
            // 
            // statusMachine
            // 
            this.statusMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusMachine.Location = new System.Drawing.Point(13, 192);
            this.statusMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusMachine.Name = "statusMachine";
            this.statusMachine.Size = new System.Drawing.Size(348, 70);
            this.statusMachine.TabIndex = 6;
            this.statusMachine.Text = "Готов";
            // 
            // people1
            // 
            this.people1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.people1.Location = new System.Drawing.Point(199, 375);
            this.people1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.people1.Name = "people1";
            this.people1.Size = new System.Drawing.Size(281, 48);
            this.people1.TabIndex = 8;
            this.people1.Text = "Ожидаю";
            // 
            // loader
            // 
            this.loader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loader.Location = new System.Drawing.Point(603, 192);
            this.loader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(433, 48);
            this.loader.TabIndex = 16;
            this.loader.Text = "Готов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // item
            // 
            this.item.Enabled = false;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item.Location = new System.Drawing.Point(185, 104);
            this.item.Margin = new System.Windows.Forms.Padding(4);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(64, 64);
            this.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item.TabIndex = 19;
            this.item.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(608, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 142);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 437);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.item);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.people1);
            this.Controls.Add(this.statusMachine);
            this.Controls.Add(this.bPeople1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Изготовление детали";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label loader;
        private System.Windows.Forms.Button bPeople1;
        private System.Windows.Forms.Label statusMachine;
        private System.Windows.Forms.Label people1;

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox item;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
