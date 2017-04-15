namespace LTTCommunity_WindowsForms_Example_App.Examples.BrowserControls
{
    partial class Browser
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
            this.componentView = new System.Windows.Forms.Panel();
            this.codeView = new System.Windows.Forms.Panel();
            this.textPane = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lightRadioButton = new System.Windows.Forms.RadioButton();
            this.darkRadioButton = new System.Windows.Forms.RadioButton();
            this.textPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentView
            // 
            this.componentView.Location = new System.Drawing.Point(4, 4);
            this.componentView.Name = "componentView";
            this.componentView.Size = new System.Drawing.Size(919, 767);
            this.componentView.TabIndex = 0;
            // 
            // codeView
            // 
            this.codeView.Location = new System.Drawing.Point(923, 167);
            this.codeView.Name = "codeView";
            this.codeView.Size = new System.Drawing.Size(441, 583);
            this.codeView.TabIndex = 1;
            // 
            // textPane
            // 
            this.textPane.Controls.Add(this.applyButton);
            this.textPane.Controls.Add(this.label1);
            this.textPane.Controls.Add(this.lightRadioButton);
            this.textPane.Controls.Add(this.darkRadioButton);
            this.textPane.Location = new System.Drawing.Point(923, 4);
            this.textPane.Name = "textPane";
            this.textPane.Size = new System.Drawing.Size(468, 157);
            this.textPane.TabIndex = 2;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(79, 104);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(138, 40);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply Settings";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a theme";
            // 
            // lightRadioButton
            // 
            this.lightRadioButton.AutoSize = true;
            this.lightRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightRadioButton.Location = new System.Drawing.Point(77, 72);
            this.lightRadioButton.Name = "lightRadioButton";
            this.lightRadioButton.Size = new System.Drawing.Size(114, 25);
            this.lightRadioButton.TabIndex = 1;
            this.lightRadioButton.TabStop = true;
            this.lightRadioButton.Text = "Light Theme";
            this.lightRadioButton.UseVisualStyleBackColor = true;
            // 
            // darkRadioButton
            // 
            this.darkRadioButton.AutoSize = true;
            this.darkRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkRadioButton.Location = new System.Drawing.Point(79, 39);
            this.darkRadioButton.Name = "darkRadioButton";
            this.darkRadioButton.Size = new System.Drawing.Size(112, 25);
            this.darkRadioButton.TabIndex = 0;
            this.darkRadioButton.TabStop = true;
            this.darkRadioButton.Text = "Dark Theme";
            this.darkRadioButton.UseVisualStyleBackColor = true;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textPane);
            this.Controls.Add(this.codeView);
            this.Controls.Add(this.componentView);
            this.Name = "Browser";
            this.Size = new System.Drawing.Size(1394, 774);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.textPane.ResumeLayout(false);
            this.textPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel componentView;
        private System.Windows.Forms.Panel codeView;
        private System.Windows.Forms.Panel textPane;
        private System.Windows.Forms.RadioButton lightRadioButton;
        private System.Windows.Forms.RadioButton darkRadioButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
    }
}
