namespace ListadeCompras
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lbItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(31, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(31, 60);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(256, 23);
            this.txtItem.TabIndex = 1;
            // 
            // lbItem
            // 
            this.lbItem.FormattingEnabled = true;
            this.lbItem.ItemHeight = 15;
            this.lbItem.Location = new System.Drawing.Point(31, 137);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(256, 229);
            this.lbItem.TabIndex = 2;
            this.lbItem.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LISTA DE COMPRAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtItem;
        private ListBox lbItem;
    }
}