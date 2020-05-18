namespace Metody_Asynchroniczne
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Async_RTB = new System.Windows.Forms.RichTextBox();
            this.listaStron_ListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sleep_CHeckB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pobierz 1 strone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(141, 451);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "DeadLock";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Async_RTB
            // 
            this.Async_RTB.Location = new System.Drawing.Point(12, 12);
            this.Async_RTB.Name = "Async_RTB";
            this.Async_RTB.Size = new System.Drawing.Size(733, 433);
            this.Async_RTB.TabIndex = 5;
            this.Async_RTB.Text = "";
            // 
            // listaStron_ListBox
            // 
            this.listaStron_ListBox.FormattingEnabled = true;
            this.listaStron_ListBox.Location = new System.Drawing.Point(753, 12);
            this.listaStron_ListBox.Name = "listaStron_ListBox";
            this.listaStron_ListBox.Size = new System.Drawing.Size(120, 420);
            this.listaStron_ListBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pobieraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(880, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "100 znaków";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sleep_CHeckB
            // 
            this.Sleep_CHeckB.AutoSize = true;
            this.Sleep_CHeckB.Location = new System.Drawing.Point(880, 101);
            this.Sleep_CHeckB.Name = "Sleep_CHeckB";
            this.Sleep_CHeckB.Size = new System.Drawing.Size(47, 17);
            this.Sleep_CHeckB.TabIndex = 9;
            this.Sleep_CHeckB.Text = "Śpię";
            this.Sleep_CHeckB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 485);
            this.Controls.Add(this.Sleep_CHeckB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listaStron_ListBox);
            this.Controls.Add(this.Async_RTB);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "metody Asynchroniczne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox Async_RTB;
        private System.Windows.Forms.ListBox listaStron_ListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Sleep_CHeckB;
    }
}

