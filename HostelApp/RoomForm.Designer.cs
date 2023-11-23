namespace HostelApp
{
    partial class RoomForm
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
            RoomGrid = new DataGridView();
            RoomTypeField = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MinCapacityField = new NumericUpDown();
            MaxCapacityField = new NumericUpDown();
            OnePlaceBedNumberField = new NumericUpDown();
            TwoPlaceBedNumberField = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MaxFloorNumberField = new NumericUpDown();
            MinFloorNumberField = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            MaxAreaNumberField = new NumericUpDown();
            MinAreaNumberField = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            MaxBathroomNumberField = new NumericUpDown();
            MinBathroomNumberField = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            MaxBedroomNumberField = new NumericUpDown();
            MinBedroomNumberField = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            IsVacantField = new CheckBox();
            TabControl = new TabControl();
            RoomTab = new TabPage();
            BedroomTab = new TabPage();
            BedTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)RoomGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinCapacityField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxCapacityField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OnePlaceBedNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TwoPlaceBedNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxFloorNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinFloorNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxAreaNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAreaNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBathroomNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBathroomNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBedroomNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBedroomNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            TabControl.SuspendLayout();
            RoomTab.SuspendLayout();
            SuspendLayout();
            // 
            // RoomGrid
            // 
            RoomGrid.AllowUserToAddRows = false;
            RoomGrid.AllowUserToDeleteRows = false;
            RoomGrid.AllowUserToOrderColumns = true;
            RoomGrid.AllowUserToResizeRows = false;
            RoomGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RoomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomGrid.Location = new Point(-3, 0);
            RoomGrid.Name = "RoomGrid";
            RoomGrid.ReadOnly = true;
            RoomGrid.RowTemplate.Height = 25;
            RoomGrid.Size = new Size(703, 432);
            RoomGrid.TabIndex = 0;
            RoomGrid.CellContentClick += RoomGrid_CellContentClick;
            // 
            // RoomTypeField
            // 
            RoomTypeField.FormattingEnabled = true;
            RoomTypeField.Location = new Point(5, 20);
            RoomTypeField.Name = "RoomTypeField";
            RoomTypeField.Size = new Size(114, 23);
            RoomTypeField.TabIndex = 1;
            RoomTypeField.SelectedValueChanged += FilterChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 4);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Класс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Кол-во человек";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "От";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 67);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "До";
            // 
            // MinCapacityField
            // 
            MinCapacityField.Location = new Point(27, 64);
            MinCapacityField.Name = "MinCapacityField";
            MinCapacityField.Size = new Size(47, 23);
            MinCapacityField.TabIndex = 10;
            MinCapacityField.ValueChanged += FilterChanged;
            // 
            // MaxCapacityField
            // 
            MaxCapacityField.Location = new Point(104, 64);
            MaxCapacityField.Name = "MaxCapacityField";
            MaxCapacityField.Size = new Size(47, 23);
            MaxCapacityField.TabIndex = 11;
            MaxCapacityField.ValueChanged += FilterChanged;
            // 
            // OnePlaceBedNumberField
            // 
            OnePlaceBedNumberField.Location = new Point(268, 21);
            OnePlaceBedNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OnePlaceBedNumberField.Name = "OnePlaceBedNumberField";
            OnePlaceBedNumberField.Size = new Size(47, 23);
            OnePlaceBedNumberField.TabIndex = 12;
            OnePlaceBedNumberField.ValueChanged += FilterChanged;
            // 
            // TwoPlaceBedNumberField
            // 
            TwoPlaceBedNumberField.Location = new Point(268, 50);
            TwoPlaceBedNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            TwoPlaceBedNumberField.Name = "TwoPlaceBedNumberField";
            TwoPlaceBedNumberField.Size = new Size(47, 23);
            TwoPlaceBedNumberField.TabIndex = 13;
            TwoPlaceBedNumberField.ValueChanged += FilterChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 23);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 14;
            label5.Text = "1-сп кровати";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 52);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 15;
            label6.Text = "2-сп кровати";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, -1);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 16;
            label7.Text = "Этаж";
            // 
            // MaxFloorNumberField
            // 
            MaxFloorNumberField.Location = new Point(112, 17);
            MaxFloorNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxFloorNumberField.Name = "MaxFloorNumberField";
            MaxFloorNumberField.Size = new Size(47, 23);
            MaxFloorNumberField.TabIndex = 20;
            MaxFloorNumberField.ValueChanged += FilterChanged;
            // 
            // MinFloorNumberField
            // 
            MinFloorNumberField.Location = new Point(35, 17);
            MinFloorNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinFloorNumberField.Name = "MinFloorNumberField";
            MinFloorNumberField.Size = new Size(47, 23);
            MinFloorNumberField.TabIndex = 19;
            MinFloorNumberField.ValueChanged += FilterChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 20);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 18;
            label8.Text = "До";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 20);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 17;
            label9.Text = "От";
            // 
            // MaxAreaNumberField
            // 
            MaxAreaNumberField.Location = new Point(112, 55);
            MaxAreaNumberField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            MaxAreaNumberField.Name = "MaxAreaNumberField";
            MaxAreaNumberField.Size = new Size(47, 23);
            MaxAreaNumberField.TabIndex = 25;
            MaxAreaNumberField.ValueChanged += FilterChanged;
            // 
            // MinAreaNumberField
            // 
            MinAreaNumberField.Location = new Point(35, 55);
            MinAreaNumberField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            MinAreaNumberField.Name = "MinAreaNumberField";
            MinAreaNumberField.Size = new Size(47, 23);
            MinAreaNumberField.TabIndex = 24;
            MinAreaNumberField.ValueChanged += FilterChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 58);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 23;
            label10.Text = "До";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 58);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 22;
            label11.Text = "От";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 37);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 21;
            label12.Text = "Площадь";
            // 
            // MaxBathroomNumberField
            // 
            MaxBathroomNumberField.Location = new Point(118, 55);
            MaxBathroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxBathroomNumberField.Name = "MaxBathroomNumberField";
            MaxBathroomNumberField.Size = new Size(47, 23);
            MaxBathroomNumberField.TabIndex = 30;
            MaxBathroomNumberField.ValueChanged += FilterChanged;
            // 
            // MinBathroomNumberField
            // 
            MinBathroomNumberField.Location = new Point(41, 55);
            MinBathroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinBathroomNumberField.Name = "MinBathroomNumberField";
            MinBathroomNumberField.Size = new Size(47, 23);
            MinBathroomNumberField.TabIndex = 29;
            MinBathroomNumberField.ValueChanged += FilterChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(90, 61);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 28;
            label13.Text = "До";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 61);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 27;
            label14.Text = "От";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 40);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 26;
            label15.Text = "Ванные";
            // 
            // MaxBedroomNumberField
            // 
            MaxBedroomNumberField.Location = new Point(118, 18);
            MaxBedroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxBedroomNumberField.Name = "MaxBedroomNumberField";
            MaxBedroomNumberField.Size = new Size(47, 23);
            MaxBedroomNumberField.TabIndex = 35;
            MaxBedroomNumberField.ValueChanged += FilterChanged;
            // 
            // MinBedroomNumberField
            // 
            MinBedroomNumberField.Location = new Point(41, 18);
            MinBedroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinBedroomNumberField.Name = "MinBedroomNumberField";
            MinBedroomNumberField.Size = new Size(47, 23);
            MinBedroomNumberField.TabIndex = 34;
            MinBedroomNumberField.ValueChanged += FilterChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(90, 21);
            label16.Name = "label16";
            label16.Size = new Size(22, 15);
            label16.TabIndex = 33;
            label16.Text = "До";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 21);
            label17.Name = "label17";
            label17.Size = new Size(21, 15);
            label17.TabIndex = 32;
            label17.Text = "От";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 0);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 31;
            label18.Text = "Спальни";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(157, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(MinFloorNumberField);
            splitContainer1.Panel1.Controls.Add(MaxFloorNumberField);
            splitContainer1.Panel1.Controls.Add(MaxAreaNumberField);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(MinAreaNumberField);
            splitContainer1.Panel1.Controls.Add(label10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TwoPlaceBedNumberField);
            splitContainer1.Panel2.Controls.Add(MaxBedroomNumberField);
            splitContainer1.Panel2.Controls.Add(OnePlaceBedNumberField);
            splitContainer1.Panel2.Controls.Add(MinBedroomNumberField);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label16);
            splitContainer1.Panel2.Controls.Add(MaxBathroomNumberField);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(MinBathroomNumberField);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Panel2.Controls.Add(label18);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Size = new Size(548, 83);
            splitContainer1.SplitterDistance = 185;
            splitContainer1.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(IsVacantField);
            panel1.Location = new Point(715, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 190);
            panel1.TabIndex = 37;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 22);
            monthCalendar1.MaxSelectionCount = 31;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // IsVacantField
            // 
            IsVacantField.AutoSize = true;
            IsVacantField.Location = new Point(5, 3);
            IsVacantField.Name = "IsVacantField";
            IsVacantField.Size = new Size(151, 19);
            IsVacantField.TabIndex = 0;
            IsVacantField.Text = "Доступно к заселению";
            IsVacantField.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(RoomTab);
            TabControl.Controls.Add(BedroomTab);
            TabControl.Controls.Add(BedTab);
            TabControl.Location = new Point(5, 93);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(708, 460);
            TabControl.TabIndex = 38;
            // 
            // RoomTab
            // 
            RoomTab.Controls.Add(RoomGrid);
            RoomTab.Location = new Point(4, 24);
            RoomTab.Name = "RoomTab";
            RoomTab.Padding = new Padding(3);
            RoomTab.Size = new Size(700, 432);
            RoomTab.TabIndex = 0;
            RoomTab.Text = "Номера";
            RoomTab.UseVisualStyleBackColor = true;
            // 
            // BedroomTab
            // 
            BedroomTab.Location = new Point(4, 24);
            BedroomTab.Name = "BedroomTab";
            BedroomTab.Padding = new Padding(3);
            BedroomTab.Size = new Size(700, 432);
            BedroomTab.TabIndex = 1;
            BedroomTab.Text = "Спальни";
            BedroomTab.UseVisualStyleBackColor = true;
            // 
            // BedTab
            // 
            BedTab.Location = new Point(4, 24);
            BedTab.Name = "BedTab";
            BedTab.Size = new Size(700, 432);
            BedTab.TabIndex = 2;
            BedTab.Text = "Спальные места";
            BedTab.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 565);
            Controls.Add(TabControl);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(RoomTypeField);
            Controls.Add(label4);
            Controls.Add(MinCapacityField);
            Controls.Add(MaxCapacityField);
            Name = "RoomForm";
            Text = "Номера";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)RoomGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinCapacityField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxCapacityField).EndInit();
            ((System.ComponentModel.ISupportInitialize)OnePlaceBedNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)TwoPlaceBedNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxFloorNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinFloorNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxAreaNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAreaNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxBathroomNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBathroomNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxBedroomNumberField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBedroomNumberField).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabControl.ResumeLayout(false);
            RoomTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomGrid;
        private ComboBox RoomTypeField;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown MinCapacityField;
        private NumericUpDown MaxCapacityField;
        private NumericUpDown OnePlaceBedNumberField;
        private NumericUpDown TwoPlaceBedNumberField;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown MaxFloorNumberField;
        private NumericUpDown MinFloorNumberField;
        private Label label8;
        private Label label9;
        private NumericUpDown MaxAreaNumberField;
        private NumericUpDown MinAreaNumberField;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown MaxBathroomNumberField;
        private NumericUpDown MinBathroomNumberField;
        private Label label13;
        private Label label14;
        private Label label15;
        private NumericUpDown MaxBedroomNumberField;
        private NumericUpDown MinBedroomNumberField;
        private Label label16;
        private Label label17;
        private Label label18;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private CheckBox IsVacantField;
        private MonthCalendar monthCalendar1;
        private TabControl TabControl;
        private TabPage RoomTab;
        private TabPage BedroomTab;
        private TabPage BedTab;
    }
}