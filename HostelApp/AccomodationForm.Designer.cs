namespace HostelApp
{
    partial class AccomodationForm
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
            panel1 = new Panel();
            DeleteButton = new Button();
            label5 = new Label();
            label6 = new Label();
            RoomComboBox = new ComboBox();
            SearchRoomField = new TextBox();
            CreateAccomodationButton = new Button();
            label4 = new Label();
            label3 = new Label();
            ToDatePicker = new DateTimePicker();
            FromDatePicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            CustomerComboBox = new ComboBox();
            SearchNameField = new TextBox();
            AccomodationGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccomodationGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(RoomComboBox);
            panel1.Controls.Add(SearchRoomField);
            panel1.Controls.Add(CreateAccomodationButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ToDatePicker);
            panel1.Controls.Add(FromDatePicker);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Controls.Add(SearchNameField);
            panel1.Controls.Add(AccomodationGrid);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 530);
            panel1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(890, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(125, 23);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(26, 379);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 13;
            label5.Text = "Номер:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(26, 340);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 12;
            label6.Text = "Поиск номера:";
            // 
            // RoomComboBox
            // 
            RoomComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RoomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomComboBox.FormattingEnabled = true;
            RoomComboBox.Location = new Point(122, 376);
            RoomComboBox.Name = "RoomComboBox";
            RoomComboBox.Size = new Size(278, 23);
            RoomComboBox.TabIndex = 11;
            // 
            // SearchRoomField
            // 
            SearchRoomField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchRoomField.Location = new Point(122, 337);
            SearchRoomField.Name = "SearchRoomField";
            SearchRoomField.Size = new Size(278, 23);
            SearchRoomField.TabIndex = 10;
            SearchRoomField.TextChanged += RoomSearchField_TextChanged;
            // 
            // CreateAccomodationButton
            // 
            CreateAccomodationButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateAccomodationButton.Location = new Point(350, 501);
            CreateAccomodationButton.Name = "CreateAccomodationButton";
            CreateAccomodationButton.Size = new Size(75, 23);
            CreateAccomodationButton.TabIndex = 9;
            CreateAccomodationButton.Text = "Заселить";
            CreateAccomodationButton.UseVisualStyleBackColor = true;
            CreateAccomodationButton.Click += CreateAccomodationButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(429, 424);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Дата ПО";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(429, 385);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Дата С";
            // 
            // ToDatePicker
            // 
            ToDatePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ToDatePicker.Format = DateTimePickerFormat.Short;
            ToDatePicker.Location = new Point(505, 421);
            ToDatePicker.Name = "ToDatePicker";
            ToDatePicker.Size = new Size(79, 23);
            ToDatePicker.TabIndex = 6;
            // 
            // FromDatePicker
            // 
            FromDatePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromDatePicker.Format = DateTimePickerFormat.Short;
            FromDatePicker.Location = new Point(505, 382);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(79, 23);
            FromDatePicker.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(26, 463);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Гость:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(26, 424);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Поиск гостя:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(122, 460);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(278, 23);
            CustomerComboBox.TabIndex = 2;
            // 
            // SearchNameField
            // 
            SearchNameField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchNameField.Location = new Point(122, 421);
            SearchNameField.Name = "SearchNameField";
            SearchNameField.Size = new Size(278, 23);
            SearchNameField.TabIndex = 1;
            SearchNameField.TextChanged += SearchNameField_TextChanged;
            // 
            // AccomodationGrid
            // 
            AccomodationGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AccomodationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AccomodationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccomodationGrid.Location = new Point(0, 0);
            AccomodationGrid.Name = "AccomodationGrid";
            AccomodationGrid.RowTemplate.Height = 25;
            AccomodationGrid.Size = new Size(884, 303);
            AccomodationGrid.TabIndex = 0;
            // 
            // AccomodationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 554);
            Controls.Add(panel1);
            Name = "AccomodationForm";
            Text = "Заселения";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AccomodationGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView AccomodationGrid;
        private TextBox SearchNameField;
        private ComboBox CustomerComboBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker ToDatePicker;
        private DateTimePicker FromDatePicker;
        private Button CreateAccomodationButton;
        private Label label5;
        private Label label6;
        private ComboBox RoomComboBox;
        private TextBox SearchRoomField;
        private Button DeleteButton;
    }
}