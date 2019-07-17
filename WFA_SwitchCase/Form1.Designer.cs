namespace WFA_SwitchCase
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
            this.txtGelenDeger1 = new System.Windows.Forms.TextBox();
            this.txtGelenDeger2 = new System.Windows.Forms.TextBox();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGelenDeger1
            // 
            this.txtGelenDeger1.Location = new System.Drawing.Point(12, 12);
            this.txtGelenDeger1.Name = "txtGelenDeger1";
            this.txtGelenDeger1.Size = new System.Drawing.Size(334, 26);
            this.txtGelenDeger1.TabIndex = 0;
            // 
            // txtGelenDeger2
            // 
            this.txtGelenDeger2.Location = new System.Drawing.Point(12, 44);
            this.txtGelenDeger2.Name = "txtGelenDeger2";
            this.txtGelenDeger2.Size = new System.Drawing.Size(334, 26);
            this.txtGelenDeger2.TabIndex = 0;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek1.Location = new System.Drawing.Point(12, 76);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(334, 57);
            this.btnOrnek1.TabIndex = 1;
            this.btnOrnek1.Text = "ONAYLA";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.BtnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek2.Location = new System.Drawing.Point(12, 202);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(334, 57);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "KULLANICI GİRİŞİ";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.BtnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek3.Location = new System.Drawing.Point(12, 265);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(334, 57);
            this.btnOrnek3.TabIndex = 1;
            this.btnOrnek3.Text = "İÇ İÇE SWITCH";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.BtnOrnek3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek4.Location = new System.Drawing.Point(12, 328);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(334, 57);
            this.btnOrnek4.TabIndex = 1;
            this.btnOrnek4.Text = "C#7 Gelen Özellik";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.BtnOrnek4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtGelenDeger2);
            this.Controls.Add(this.txtGelenDeger1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelenDeger1;
        private System.Windows.Forms.TextBox txtGelenDeger2;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.Button button1;
    }
}

