namespace WFA_ArrayMethods
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
            this.txtGelenDeger = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGelenDeger
            // 
            this.txtGelenDeger.Location = new System.Drawing.Point(12, 12);
            this.txtGelenDeger.Name = "txtGelenDeger";
            this.txtGelenDeger.Size = new System.Drawing.Size(220, 20);
            this.txtGelenDeger.TabIndex = 29;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 314);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(220, 40);
            this.btnReverse.TabIndex = 28;
            this.btnReverse.Text = "ARRAY.REVERSE()";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 268);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(220, 40);
            this.btnSort.TabIndex = 27;
            this.btnSort.Text = "ARRAY.SORT()";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(12, 222);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(220, 40);
            this.btnResize.TabIndex = 26;
            this.btnResize.Text = "ARRAY.RESIZE()";
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(12, 176);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(220, 40);
            this.btnLastIndexOf.TabIndex = 25;
            this.btnLastIndexOf.Text = "ARRAY.LASTINDEXOF()";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(12, 130);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(220, 40);
            this.btnIndexOf.TabIndex = 24;
            this.btnIndexOf.Text = "ARRAY.INDEXOF()";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 84);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(220, 40);
            this.btnCopy.TabIndex = 23;
            this.btnCopy.Text = "ARRAY.COPY()";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 40);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "ARRAY.CLEAR()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 365);
            this.Controls.Add(this.txtGelenDeger);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelenDeger;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
    }
}

