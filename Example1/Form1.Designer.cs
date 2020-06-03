namespace Example1
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
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tvLoadXML = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(617, 355);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(143, 68);
            this.btnMsgBox.TabIndex = 0;
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tvLoadXML
            // 
            this.tvLoadXML.Location = new System.Drawing.Point(52, 65);
            this.tvLoadXML.Name = "tvLoadXML";
            this.tvLoadXML.Size = new System.Drawing.Size(555, 234);
            this.tvLoadXML.TabIndex = 2;
            this.tvLoadXML.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvLoadXML_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvLoadXML);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMsgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView tvLoadXML;
    }
}

