namespace HostelApp
{
    partial class EditEntityForm
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
            MainContentLayoutPanel = new FlowLayoutPanel();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // MainContentLayoutPanel
            // 
            MainContentLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContentLayoutPanel.Location = new Point(12, 12);
            MainContentLayoutPanel.Name = "MainContentLayoutPanel";
            MainContentLayoutPanel.Size = new Size(367, 399);
            MainContentLayoutPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(160, 417);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditEntityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(SaveButton);
            Controls.Add(MainContentLayoutPanel);
            Name = "EditEntityForm";
            Text = "Редактировать";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel MainContentLayoutPanel;
        private Button SaveButton;
    }
}