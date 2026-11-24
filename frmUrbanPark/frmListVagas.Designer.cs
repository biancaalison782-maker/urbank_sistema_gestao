namespace frmUrbanPark
{
    partial class frmListVagas
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
            flwCardVagas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flwCardVagas
            // 
            flwCardVagas.Location = new Point(191, 156);
            flwCardVagas.Name = "flwCardVagas";
            flwCardVagas.Size = new Size(200, 100);
            flwCardVagas.TabIndex = 0;
            // 
            // frmListVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flwCardVagas);
            Name = "frmListVagas";
            Text = "frmListVagas";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flwCardVagas;
    }
}