namespace LiveSplit.ManualGameTime.UI.Components
{
    partial class ShitSplitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShitSplitter));
            this.txtGameTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGameTime
            // 
            resources.ApplyResources(this.txtGameTime, "txtGameTime");
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGameTime_KeyPress);
            // 
            // ShitSplitter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGameTime);
            this.Name = "ShitSplitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameTime;
    }
}