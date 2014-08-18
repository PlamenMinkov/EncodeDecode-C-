namespace PlamenMinkov_1201561022__FirstProject
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
            this.result = new System.Windows.Forms.RichTextBox();
            this.Text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.hesh = new System.Windows.Forms.RichTextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 224);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(303, 127);
            this.result.TabIndex = 0;
            this.result.Text = "";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(12, 54);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(303, 127);
            this.Text.TabIndex = 1;
            this.Text.Text = "";
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Резултат:";
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(397, 83);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(226, 34);
            this.encode.TabIndex = 4;
            this.encode.Text = "Encode";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(397, 123);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(226, 34);
            this.decode.TabIndex = 5;
            this.decode.Text = "Decode";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(397, 163);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(226, 23);
            this.copy.TabIndex = 6;
            this.copy.Text = "Copy from result";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(397, 193);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(226, 31);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // hesh
            // 
            this.hesh.Location = new System.Drawing.Point(372, 283);
            this.hesh.Name = "hesh";
            this.hesh.ReadOnly = true;
            this.hesh.Size = new System.Drawing.Size(278, 67);
            this.hesh.TabIndex = 8;
            this.hesh.Text = "";
            this.hesh.Visible = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(406, 260);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(91, 17);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "Hash in ASCII";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Visible = false;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(505, 260);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(100, 17);
            this.rb2.TabIndex = 10;
            this.rb2.TabStop = true;
            this.rb2.Text = "Hash in Base64";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.Visible = false;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(406, 237);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(113, 17);
            this.checkBox.TabIndex = 11;
            this.checkBox.Text = "Calculate SHA512";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(577, 234);
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Size = new System.Drawing.Size(45, 20);
            this.length.TabIndex = 12;
            this.length.Visible = false;
            this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дължина:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Хеш:";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.length);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.hesh);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.RichTextBox Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox hesh;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

