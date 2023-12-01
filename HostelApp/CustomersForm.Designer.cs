namespace HostelApp
{
    partial class CustomersForm
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
            CustomersGrid = new DataGridView();
            BirthdayPicker = new DateTimePicker();
            NameField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CreateButton = new Button();
            EditButton = new Button();
            RemoveButton = new Button();
            CancelSelectionButton = new Button();
            SelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).BeginInit();
            SuspendLayout();
            // 
            // CustomersGrid
            // 
            CustomersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CustomersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGrid.Location = new Point(12, 12);
            CustomersGrid.Name = "CustomersGrid";
            CustomersGrid.ReadOnly = true;
            CustomersGrid.RowTemplate.Height = 25;
            CustomersGrid.Size = new Size(440, 301);
            CustomersGrid.TabIndex = 0;
            CustomersGrid.SelectionChanged += CustomersGrid_SelectionChanged;
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Format = DateTimePickerFormat.Short;
            BirthdayPicker.Location = new Point(131, 358);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(270, 23);
            BirthdayPicker.TabIndex = 1;
            // 
            // NameField
            // 
            NameField.Location = new Point(131, 319);
            NameField.Name = "NameField";
            NameField.Size = new Size(270, 23);
            NameField.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 322);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 364);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата рождения:";
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateButton.Location = new Point(91, 404);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.Location = new Point(203, 404);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(313, 404);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Удалить";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // CancelSelectionButton
            // 
            CancelSelectionButton.Location = new Point(313, 451);
            CancelSelectionButton.Name = "CancelSelectionButton";
            CancelSelectionButton.Size = new Size(75, 23);
            CancelSelectionButton.TabIndex = 8;
            CancelSelectionButton.Text = "Отмена";
            CancelSelectionButton.UseVisualStyleBackColor = true;
            CancelSelectionButton.Click += CancelButton_Click;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(91, 451);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(75, 23);
            SelectButton.TabIndex = 9;
            SelectButton.Text = "Выбрать";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 486);
            Controls.Add(SelectButton);
            Controls.Add(CancelSelectionButton);
            Controls.Add(RemoveButton);
            Controls.Add(EditButton);
            Controls.Add(CreateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameField);
            Controls.Add(BirthdayPicker);
            Controls.Add(CustomersGrid);
            Name = "CustomersForm";
            Text = "Гости";
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustomersGrid;
        private DateTimePicker BirthdayPicker;
        private TextBox NameField;
        private Label label1;
        private Label label2;
        private Button CreateButton;
        private Button EditButton;
        private Button RemoveButton;
        private Button CancelSelectionButton;
        private Button SelectButton;
    }
}