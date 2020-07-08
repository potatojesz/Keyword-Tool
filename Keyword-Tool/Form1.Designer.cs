namespace Keyword_Tool
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
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.textBoxGenerated = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAction
            // 
            this.buttonAction.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAction.Location = new System.Drawing.Point(418, 12);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(172, 518);
            this.buttonAction.TabIndex = 5;
            this.buttonAction.Text = ">>>";
            this.buttonAction.UseVisualStyleBackColor = false;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(12, 12);
            this.textBoxEnter.Multiline = true;
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(400, 517);
            this.textBoxEnter.TabIndex = 6;
            // 
            // textBoxGenerated
            // 
            this.textBoxGenerated.Location = new System.Drawing.Point(596, 12);
            this.textBoxGenerated.Multiline = true;
            this.textBoxGenerated.Name = "textBoxGenerated";
            this.textBoxGenerated.Size = new System.Drawing.Size(400, 517);
            this.textBoxGenerated.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.textBoxGenerated);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.buttonAction);
            this.MaximumSize = new System.Drawing.Size(1024, 580);
            this.MinimumSize = new System.Drawing.Size(1024, 580);
            this.Name = "Form1";
            this.Text = "KeywordTool v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.TextBox textBoxGenerated;
    }
}

