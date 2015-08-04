namespace LiveSplit.UI.Components
{
    partial class ManualGameTimeSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualGameTimeSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoSegmentTimes = new System.Windows.Forms.RadioButton();
            this.rdoSplitTimes = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 4);
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.rdoSegmentTimes, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rdoSplitTimes, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // rdoSegmentTimes
            // 
            resources.ApplyResources(this.rdoSegmentTimes, "rdoSegmentTimes");
            this.rdoSegmentTimes.Name = "rdoSegmentTimes";
            this.rdoSegmentTimes.TabStop = true;
            this.rdoSegmentTimes.UseVisualStyleBackColor = true;
            // 
            // rdoSplitTimes
            // 
            resources.ApplyResources(this.rdoSplitTimes, "rdoSplitTimes");
            this.rdoSplitTimes.Name = "rdoSplitTimes";
            this.rdoSplitTimes.TabStop = true;
            this.rdoSplitTimes.UseVisualStyleBackColor = true;
            // 
            // ManualGameTimeSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManualGameTimeSettings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoSegmentTimes;
        private System.Windows.Forms.RadioButton rdoSplitTimes;
    }
}
