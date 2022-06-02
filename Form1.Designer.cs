
namespace tabuada
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbox_tabuada = new System.Windows.Forms.ListBox();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabuada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbox_tabuada
            // 
            this.lbox_tabuada.FormattingEnabled = true;
            this.lbox_tabuada.Location = new System.Drawing.Point(210, 52);
            this.lbox_tabuada.Name = "lbox_tabuada";
            this.lbox_tabuada.Size = new System.Drawing.Size(168, 238);
            this.lbox_tabuada.TabIndex = 2;
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(81, 49);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(82, 20);
            this.txt_box.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 367);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.lbox_tabuada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbox_tabuada;
        private System.Windows.Forms.TextBox txt_box;
    }
}

