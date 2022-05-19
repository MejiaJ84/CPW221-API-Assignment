namespace ChuckNorrisJokeForm
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
            this.lblDisplayJoke = new System.Windows.Forms.Label();
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.rTxtDisplayJoke = new System.Windows.Forms.RichTextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayJoke
            // 
            this.lblDisplayJoke.AutoSize = true;
            this.lblDisplayJoke.Location = new System.Drawing.Point(36, 60);
            this.lblDisplayJoke.Name = "lblDisplayJoke";
            this.lblDisplayJoke.Size = new System.Drawing.Size(105, 15);
            this.lblDisplayJoke.TabIndex = 0;
            this.lblDisplayJoke.Text = "Chuck Norris Joke:";
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(306, 197);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(75, 23);
            this.btnGetJoke.TabIndex = 2;
            this.btnGetJoke.Text = "Get Joke";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            this.btnGetJoke.Click += new System.EventHandler(this.btnGetJoke_Click);
            // 
            // rTxtDisplayJoke
            // 
            this.rTxtDisplayJoke.Location = new System.Drawing.Point(156, 60);
            this.rTxtDisplayJoke.Name = "rTxtDisplayJoke";
            this.rTxtDisplayJoke.Size = new System.Drawing.Size(225, 98);
            this.rTxtDisplayJoke.TabIndex = 3;
            this.rTxtDisplayJoke.Text = "";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(474, 60);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 23);
            this.cbCategories.TabIndex = 4;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(474, 31);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(66, 15);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.rTxtDisplayJoke);
            this.Controls.Add(this.btnGetJoke);
            this.Controls.Add(this.lblDisplayJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDisplayJoke;
        private Button btnGetJoke;
        private RichTextBox rTxtDisplayJoke;
        private ComboBox cbCategories;
        private Label lblCategories;
    }
}