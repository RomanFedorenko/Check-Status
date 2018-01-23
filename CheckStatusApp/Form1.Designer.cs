namespace CheckStatusApp
{
    partial class Main
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
            this.lstView_main = new System.Windows.Forms.ListView();
            this.web = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstView_main
            // 
            this.lstView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.web,
            this.status});
            this.lstView_main.Location = new System.Drawing.Point(33, 41);
            this.lstView_main.Name = "lstView_main";
            this.lstView_main.Size = new System.Drawing.Size(610, 97);
            this.lstView_main.TabIndex = 0;
            this.lstView_main.UseCompatibleStateImageBehavior = false;
            this.lstView_main.View = System.Windows.Forms.View.Details;
            this.lstView_main.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // web
            // 
            this.web.Text = "Website";
            this.web.Width = 407;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 199;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 285);
            this.Controls.Add(this.lstView_main);
            this.Name = "Main";
            this.Text = "Check Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstView_main;
        private System.Windows.Forms.ColumnHeader web;
        private System.Windows.Forms.ColumnHeader status;
    }
}

