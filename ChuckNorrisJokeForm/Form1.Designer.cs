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
            this.txtDisplayjoke = new System.Windows.Forms.TextBox();
            this.btnGetJoke = new System.Windows.Forms.Button();
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
            // txtDisplayjoke
            // 
            this.txtDisplayjoke.Location = new System.Drawing.Point(179, 52);
            this.txtDisplayjoke.Name = "txtDisplayjoke";
            this.txtDisplayjoke.Size = new System.Drawing.Size(213, 23);
            this.txtDisplayjoke.TabIndex = 1;
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(317, 96);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(75, 23);
            this.btnGetJoke.TabIndex = 2;
            this.btnGetJoke.Text = "Get Joke";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetJoke);
            this.Controls.Add(this.txtDisplayjoke);
            this.Controls.Add(this.lblDisplayJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDisplayJoke;
        private TextBox txtDisplayjoke;
        private Button btnGetJoke;
    }
}