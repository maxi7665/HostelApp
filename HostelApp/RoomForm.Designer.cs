﻿namespace HostelApp
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
            MaxAreaField = new NumericUpDown();
            MinAreaField = new NumericUpDown();
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
            VacantCalendar = new MonthCalendar();
            IsOnlyVacantField = new CheckBox();
            TabControl = new TabControl();
            RoomTab = new TabPage();
            BedroomTab = new TabPage();
            BedroomGrid = new DataGridView();
            BedTab = new TabPage();
            BedGrid = new DataGridView();
            CustomersButton = new Button();
            statusStrip1 = new StatusStrip();
            CurrentCustomerLabel = new ToolStripStatusLabel();
            EditButton = new Button();
            AddButton = new Button();
            AccomodationButton = new Button();
            RoomAccomodationButton = new Button();
            SelectDbButton = new Button();
            SaveDbButton = new Button();
            ClearDbButton = new Button();
            TestBdButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RoomGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinCapacityField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxCapacityField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OnePlaceBedNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TwoPlaceBedNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxFloorNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinFloorNumberField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxAreaField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAreaField).BeginInit();
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
            BedroomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BedroomGrid).BeginInit();
            BedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BedGrid).BeginInit();
            statusStrip1.SuspendLayout();
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
            RoomGrid.Margin = new Padding(3, 4, 3, 4);
            RoomGrid.Name = "RoomGrid";
            RoomGrid.ReadOnly = true;
            RoomGrid.RowHeadersWidth = 51;
            RoomGrid.RowTemplate.Height = 25;
            RoomGrid.Size = new Size(797, 549);
            RoomGrid.TabIndex = 0;
            RoomGrid.CellContentClick += RoomGrid_CellContentClick;
            RoomGrid.DataBindingComplete += RoomGrid_DataBindingComplete;
            RoomGrid.SelectionChanged += RoomGrid_SelectionChanged;
            // 
            // RoomTypeField
            // 
            RoomTypeField.FormattingEnabled = true;
            RoomTypeField.Location = new Point(6, 27);
            RoomTypeField.Margin = new Padding(3, 4, 3, 4);
            RoomTypeField.Name = "RoomTypeField";
            RoomTypeField.Size = new Size(130, 28);
            RoomTypeField.TabIndex = 1;
            RoomTypeField.SelectedValueChanged += FilterChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Класс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 61);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Кол-во человек";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 6;
            label3.Text = "От";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 89);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 7;
            label4.Text = "До";
            // 
            // MinCapacityField
            // 
            MinCapacityField.Location = new Point(31, 85);
            MinCapacityField.Margin = new Padding(3, 4, 3, 4);
            MinCapacityField.Name = "MinCapacityField";
            MinCapacityField.Size = new Size(54, 27);
            MinCapacityField.TabIndex = 10;
            MinCapacityField.ValueChanged += FilterChanged;
            // 
            // MaxCapacityField
            // 
            MaxCapacityField.Location = new Point(119, 85);
            MaxCapacityField.Margin = new Padding(3, 4, 3, 4);
            MaxCapacityField.Name = "MaxCapacityField";
            MaxCapacityField.Size = new Size(54, 27);
            MaxCapacityField.TabIndex = 11;
            MaxCapacityField.ValueChanged += FilterChanged;
            // 
            // OnePlaceBedNumberField
            // 
            OnePlaceBedNumberField.Location = new Point(312, 28);
            OnePlaceBedNumberField.Margin = new Padding(3, 4, 3, 4);
            OnePlaceBedNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OnePlaceBedNumberField.Name = "OnePlaceBedNumberField";
            OnePlaceBedNumberField.Size = new Size(54, 27);
            OnePlaceBedNumberField.TabIndex = 12;
            OnePlaceBedNumberField.ValueChanged += FilterChanged;
            // 
            // TwoPlaceBedNumberField
            // 
            TwoPlaceBedNumberField.Location = new Point(311, 67);
            TwoPlaceBedNumberField.Margin = new Padding(3, 4, 3, 4);
            TwoPlaceBedNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            TwoPlaceBedNumberField.Name = "TwoPlaceBedNumberField";
            TwoPlaceBedNumberField.Size = new Size(54, 27);
            TwoPlaceBedNumberField.TabIndex = 13;
            TwoPlaceBedNumberField.ValueChanged += FilterChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 31);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 14;
            label5.Text = "1-сп кровати";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 69);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 15;
            label6.Text = "2-сп кровати";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, -1);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 16;
            label7.Text = "Этаж";
            // 
            // MaxFloorNumberField
            // 
            MaxFloorNumberField.Location = new Point(128, 23);
            MaxFloorNumberField.Margin = new Padding(3, 4, 3, 4);
            MaxFloorNumberField.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MaxFloorNumberField.Name = "MaxFloorNumberField";
            MaxFloorNumberField.Size = new Size(54, 27);
            MaxFloorNumberField.TabIndex = 20;
            MaxFloorNumberField.ValueChanged += FilterChanged;
            // 
            // MinFloorNumberField
            // 
            MinFloorNumberField.Location = new Point(40, 23);
            MinFloorNumberField.Margin = new Padding(3, 4, 3, 4);
            MinFloorNumberField.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MinFloorNumberField.Name = "MinFloorNumberField";
            MinFloorNumberField.Size = new Size(54, 27);
            MinFloorNumberField.TabIndex = 19;
            MinFloorNumberField.ValueChanged += FilterChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 27);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 18;
            label8.Text = "До";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 27);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 17;
            label9.Text = "От";
            // 
            // MaxAreaField
            // 
            MaxAreaField.Location = new Point(128, 73);
            MaxAreaField.Margin = new Padding(3, 4, 3, 4);
            MaxAreaField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            MaxAreaField.Name = "MaxAreaField";
            MaxAreaField.Size = new Size(54, 27);
            MaxAreaField.TabIndex = 25;
            MaxAreaField.ValueChanged += FilterChanged;
            // 
            // MinAreaField
            // 
            MinAreaField.Location = new Point(40, 73);
            MinAreaField.Margin = new Padding(3, 4, 3, 4);
            MinAreaField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            MinAreaField.Name = "MinAreaField";
            MinAreaField.Size = new Size(54, 27);
            MinAreaField.TabIndex = 24;
            MinAreaField.ValueChanged += FilterChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 77);
            label10.Name = "label10";
            label10.Size = new Size(28, 20);
            label10.TabIndex = 23;
            label10.Text = "До";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 77);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 22;
            label11.Text = "От";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 49);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 21;
            label12.Text = "Площадь";
            // 
            // MaxBathroomNumberField
            // 
            MaxBathroomNumberField.Location = new Point(135, 73);
            MaxBathroomNumberField.Margin = new Padding(3, 4, 3, 4);
            MaxBathroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxBathroomNumberField.Name = "MaxBathroomNumberField";
            MaxBathroomNumberField.Size = new Size(54, 27);
            MaxBathroomNumberField.TabIndex = 30;
            MaxBathroomNumberField.ValueChanged += FilterChanged;
            // 
            // MinBathroomNumberField
            // 
            MinBathroomNumberField.Location = new Point(47, 73);
            MinBathroomNumberField.Margin = new Padding(3, 4, 3, 4);
            MinBathroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinBathroomNumberField.Name = "MinBathroomNumberField";
            MinBathroomNumberField.Size = new Size(54, 27);
            MinBathroomNumberField.TabIndex = 29;
            MinBathroomNumberField.ValueChanged += FilterChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(103, 81);
            label13.Name = "label13";
            label13.Size = new Size(28, 20);
            label13.TabIndex = 28;
            label13.Text = "До";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 81);
            label14.Name = "label14";
            label14.Size = new Size(26, 20);
            label14.TabIndex = 27;
            label14.Text = "От";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 53);
            label15.Name = "label15";
            label15.Size = new Size(63, 20);
            label15.TabIndex = 26;
            label15.Text = "Ванные";
            // 
            // MaxBedroomNumberField
            // 
            MaxBedroomNumberField.Location = new Point(135, 24);
            MaxBedroomNumberField.Margin = new Padding(3, 4, 3, 4);
            MaxBedroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxBedroomNumberField.Name = "MaxBedroomNumberField";
            MaxBedroomNumberField.Size = new Size(54, 27);
            MaxBedroomNumberField.TabIndex = 35;
            MaxBedroomNumberField.ValueChanged += FilterChanged;
            // 
            // MinBedroomNumberField
            // 
            MinBedroomNumberField.Location = new Point(47, 24);
            MinBedroomNumberField.Margin = new Padding(3, 4, 3, 4);
            MinBedroomNumberField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinBedroomNumberField.Name = "MinBedroomNumberField";
            MinBedroomNumberField.Size = new Size(54, 27);
            MinBedroomNumberField.TabIndex = 34;
            MinBedroomNumberField.ValueChanged += FilterChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(103, 28);
            label16.Name = "label16";
            label16.Size = new Size(28, 20);
            label16.TabIndex = 33;
            label16.Text = "До";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 28);
            label17.Name = "label17";
            label17.Size = new Size(26, 20);
            label17.TabIndex = 32;
            label17.Text = "От";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(23, 0);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 31;
            label18.Text = "Спальни";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(179, 5);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer1.Panel1.Controls.Add(MaxAreaField);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(MinAreaField);
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
            splitContainer1.Size = new Size(626, 111);
            splitContainer1.SplitterDistance = 210;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(VacantCalendar);
            panel1.Controls.Add(IsOnlyVacantField);
            panel1.Location = new Point(810, 7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 253);
            panel1.TabIndex = 37;
            // 
            // VacantCalendar
            // 
            VacantCalendar.Enabled = false;
            VacantCalendar.Location = new Point(10, 29);
            VacantCalendar.Margin = new Padding(10, 12, 10, 12);
            VacantCalendar.MaxSelectionCount = 31;
            VacantCalendar.Name = "VacantCalendar";
            VacantCalendar.TabIndex = 1;
            VacantCalendar.DateSelected += monthCalendar1_DateChanged;
            // 
            // IsOnlyVacantField
            // 
            IsOnlyVacantField.AutoSize = true;
            IsOnlyVacantField.Location = new Point(6, 4);
            IsOnlyVacantField.Margin = new Padding(3, 4, 3, 4);
            IsOnlyVacantField.Name = "IsOnlyVacantField";
            IsOnlyVacantField.Size = new Size(188, 24);
            IsOnlyVacantField.TabIndex = 0;
            IsOnlyVacantField.Text = "Доступно к заселению";
            IsOnlyVacantField.UseVisualStyleBackColor = true;
            IsOnlyVacantField.CheckedChanged += IsVacantField_CheckedChanged;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(RoomTab);
            TabControl.Controls.Add(BedroomTab);
            TabControl.Controls.Add(BedTab);
            TabControl.Location = new Point(6, 124);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(802, 587);
            TabControl.TabIndex = 38;
            // 
            // RoomTab
            // 
            RoomTab.Controls.Add(RoomGrid);
            RoomTab.Location = new Point(4, 29);
            RoomTab.Margin = new Padding(3, 4, 3, 4);
            RoomTab.Name = "RoomTab";
            RoomTab.Padding = new Padding(3, 4, 3, 4);
            RoomTab.Size = new Size(794, 554);
            RoomTab.TabIndex = 0;
            RoomTab.Text = "Номера";
            RoomTab.UseVisualStyleBackColor = true;
            // 
            // BedroomTab
            // 
            BedroomTab.Controls.Add(BedroomGrid);
            BedroomTab.Location = new Point(4, 29);
            BedroomTab.Margin = new Padding(3, 4, 3, 4);
            BedroomTab.Name = "BedroomTab";
            BedroomTab.Padding = new Padding(3, 4, 3, 4);
            BedroomTab.Size = new Size(794, 554);
            BedroomTab.TabIndex = 1;
            BedroomTab.Text = "Спальни";
            BedroomTab.UseVisualStyleBackColor = true;
            // 
            // BedroomGrid
            // 
            BedroomGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BedroomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BedroomGrid.Location = new Point(0, 0);
            BedroomGrid.Margin = new Padding(3, 4, 3, 4);
            BedroomGrid.Name = "BedroomGrid";
            BedroomGrid.ReadOnly = true;
            BedroomGrid.RowHeadersWidth = 51;
            BedroomGrid.RowTemplate.Height = 25;
            BedroomGrid.Size = new Size(788, 558);
            BedroomGrid.TabIndex = 0;
            BedroomGrid.DataBindingComplete += BedroomGrid_DataBindingComplete;
            BedroomGrid.SelectionChanged += BedroomGrid_SelectionChanged;
            // 
            // BedTab
            // 
            BedTab.Controls.Add(BedGrid);
            BedTab.Location = new Point(4, 29);
            BedTab.Margin = new Padding(3, 4, 3, 4);
            BedTab.Name = "BedTab";
            BedTab.Size = new Size(794, 554);
            BedTab.TabIndex = 2;
            BedTab.Text = "Спальные места";
            BedTab.UseVisualStyleBackColor = true;
            // 
            // BedGrid
            // 
            BedGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BedGrid.Location = new Point(0, 0);
            BedGrid.Margin = new Padding(3, 4, 3, 4);
            BedGrid.Name = "BedGrid";
            BedGrid.ReadOnly = true;
            BedGrid.RowHeadersWidth = 51;
            BedGrid.RowTemplate.Height = 25;
            BedGrid.Size = new Size(769, 557);
            BedGrid.TabIndex = 0;
            // 
            // CustomersButton
            // 
            CustomersButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomersButton.Location = new Point(815, 269);
            CustomersButton.Margin = new Padding(3, 4, 3, 4);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(201, 31);
            CustomersButton.TabIndex = 39;
            CustomersButton.Text = "Гости";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { CurrentCustomerLabel });
            statusStrip1.Location = new Point(0, 718);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1030, 26);
            statusStrip1.TabIndex = 40;
            statusStrip1.Text = "statusStrip1";
            // 
            // CurrentCustomerLabel
            // 
            CurrentCustomerLabel.Name = "CurrentCustomerLabel";
            CurrentCustomerLabel.Size = new Size(191, 20);
            CurrentCustomerLabel.Text = "Текущий гость: не выбран";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(815, 308);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(201, 31);
            EditButton.TabIndex = 41;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.Location = new Point(815, 347);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(201, 31);
            AddButton.TabIndex = 42;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AccomodationButton
            // 
            AccomodationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccomodationButton.Location = new Point(815, 424);
            AccomodationButton.Margin = new Padding(3, 4, 3, 4);
            AccomodationButton.Name = "AccomodationButton";
            AccomodationButton.Size = new Size(201, 31);
            AccomodationButton.TabIndex = 43;
            AccomodationButton.Text = "Заселения";
            AccomodationButton.UseVisualStyleBackColor = true;
            AccomodationButton.Click += AccomodationButton_Click;
            // 
            // RoomAccomodationButton
            // 
            RoomAccomodationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RoomAccomodationButton.Location = new Point(815, 463);
            RoomAccomodationButton.Margin = new Padding(3, 4, 3, 4);
            RoomAccomodationButton.Name = "RoomAccomodationButton";
            RoomAccomodationButton.Size = new Size(201, 31);
            RoomAccomodationButton.TabIndex = 44;
            RoomAccomodationButton.Text = "Заселения по комнате";
            RoomAccomodationButton.UseVisualStyleBackColor = true;
            RoomAccomodationButton.Click += RoomAccomodationButton_Click;
            // 
            // SelectDbButton
            // 
            SelectDbButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelectDbButton.Location = new Point(815, 501);
            SelectDbButton.Margin = new Padding(3, 4, 3, 4);
            SelectDbButton.Name = "SelectDbButton";
            SelectDbButton.Size = new Size(201, 31);
            SelectDbButton.TabIndex = 45;
            SelectDbButton.Text = "Выбрать файл БД";
            SelectDbButton.UseVisualStyleBackColor = true;
            SelectDbButton.Click += SelectDbButton_Click;
            // 
            // SaveDbButton
            // 
            SaveDbButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveDbButton.Location = new Point(815, 540);
            SaveDbButton.Margin = new Padding(3, 4, 3, 4);
            SaveDbButton.Name = "SaveDbButton";
            SaveDbButton.Size = new Size(201, 31);
            SaveDbButton.TabIndex = 46;
            SaveDbButton.Text = "Экспорт БД";
            SaveDbButton.UseVisualStyleBackColor = true;
            SaveDbButton.Click += SaveDbButton_Click;
            // 
            // ClearDbButton
            // 
            ClearDbButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearDbButton.Location = new Point(815, 579);
            ClearDbButton.Margin = new Padding(3, 4, 3, 4);
            ClearDbButton.Name = "ClearDbButton";
            ClearDbButton.Size = new Size(201, 31);
            ClearDbButton.TabIndex = 47;
            ClearDbButton.Text = "Очистить БД";
            ClearDbButton.UseVisualStyleBackColor = true;
            ClearDbButton.Click += ClearDbButton_Click;
            // 
            // TestBdButton
            // 
            TestBdButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TestBdButton.Location = new Point(815, 617);
            TestBdButton.Margin = new Padding(3, 4, 3, 4);
            TestBdButton.Name = "TestBdButton";
            TestBdButton.Size = new Size(201, 31);
            TestBdButton.TabIndex = 48;
            TestBdButton.Text = "Тестовая БД";
            TestBdButton.UseVisualStyleBackColor = true;
            TestBdButton.Click += TestBdButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(815, 385);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(201, 31);
            DeleteButton.TabIndex = 49;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 744);
            Controls.Add(DeleteButton);
            Controls.Add(TestBdButton);
            Controls.Add(ClearDbButton);
            Controls.Add(SaveDbButton);
            Controls.Add(SelectDbButton);
            Controls.Add(RoomAccomodationButton);
            Controls.Add(AccomodationButton);
            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(statusStrip1);
            Controls.Add(CustomersButton);
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
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)MaxAreaField).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAreaField).EndInit();
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
            BedroomTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BedroomGrid).EndInit();
            BedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BedGrid).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private NumericUpDown MaxAreaField;
        private NumericUpDown MinAreaField;
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
        private CheckBox IsOnlyVacantField;
        private MonthCalendar VacantCalendar;
        private TabControl TabControl;
        private TabPage RoomTab;
        private TabPage BedroomTab;
        private TabPage BedTab;
        private DataGridView BedroomGrid;
        private DataGridView BedGrid;
        private Button CustomersButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel CurrentCustomerLabel;
        private Button EditButton;
        private Button AddButton;
        private Button AccomodationButton;
        private Button RoomAccomodationButton;
        private Button SelectDbButton;
        private Button SaveDbButton;
        private Button ClearDbButton;
        private Button TestBdButton;
        private Button DeleteButton;
    }
}