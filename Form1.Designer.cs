
namespace RSA_для_конфы
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
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.secondNumberText = new System.Windows.Forms.TextBox();
            this.firstNumberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateRSASys_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(12, 100);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(100, 23);
            this.publicKey.TabIndex = 0;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(143, 100);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(100, 23);
            this.privateKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Открытый ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Закрытый ключ";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(12, 164);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(231, 109);
            this.messageText.TabIndex = 5;
            // 
            // secondNumberText
            // 
            this.secondNumberText.Location = new System.Drawing.Point(143, 43);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(100, 23);
            this.secondNumberText.TabIndex = 4;
            // 
            // firstNumberText
            // 
            this.firstNumberText.Location = new System.Drawing.Point(12, 43);
            this.firstNumberText.Name = "firstNumberText";
            this.firstNumberText.Size = new System.Drawing.Size(100, 23);
            this.firstNumberText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Второе число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Первое число";
            // 
            // generateRSASys_button
            // 
            this.generateRSASys_button.Location = new System.Drawing.Point(279, 43);
            this.generateRSASys_button.Name = "generateRSASys_button";
            this.generateRSASys_button.Size = new System.Drawing.Size(121, 80);
            this.generateRSASys_button.TabIndex = 9;
            this.generateRSASys_button.Text = "Сгенерирвоать систему RSA";
            this.generateRSASys_button.UseVisualStyleBackColor = true;
            this.generateRSASys_button.Click += new System.EventHandler(this.generateRSASys_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сообщение";
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(279, 164);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(121, 53);
            this.encrypt_button.TabIndex = 11;
            this.encrypt_button.Text = "Зашифровать";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(279, 223);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(121, 50);
            this.decrypt_button.TabIndex = 12;
            this.decrypt_button.Text = "Расшифрвоать";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 303);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generateRSASys_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNumberText);
            this.Controls.Add(this.firstNumberText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.TextBox secondNumberText;
        private System.Windows.Forms.TextBox firstNumberText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateRSASys_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
    }
}

