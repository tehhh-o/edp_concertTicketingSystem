namespace projectEDPforreal
{
    partial class AdminMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label booking_idLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label concert_idLabel;
            System.Windows.Forms.Label booking_dateLabel;
            System.Windows.Forms.Label total_ticketLabel;
            System.Windows.Forms.Label total_priceLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.ticket2U = new projectEDPforreal.Ticket2U();
            this.concertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.concertBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConIdTB = new System.Windows.Forms.TextBox();
            this.ConNameTB = new System.Windows.Forms.TextBox();
            this.ConDetailTB = new System.Windows.Forms.TextBox();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.TicPriceTB = new System.Windows.Forms.TextBox();
            this.SeatTB = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.ReceiptBtn = new System.Windows.Forms.Button();
            this.BoMarkBtn = new System.Windows.Forms.Button();
            this.concertTableAdapter = new projectEDPforreal.Ticket2UTableAdapters.ConcertTableAdapter();
            this.tableAdapterManager = new projectEDPforreal.Ticket2UTableAdapters.TableAdapterManager();
            this.VenueTB = new System.Windows.Forms.TextBox();
            this.concertDataGridView = new System.Windows.Forms.DataGridView();
            this.concertidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableseatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTableAdapter = new projectEDPforreal.Ticket2UTableAdapters.BookingTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new projectEDPforreal.Ticket2UTableAdapters.PaymentTableAdapter();
            booking_idLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            concert_idLabel = new System.Windows.Forms.Label();
            booking_dateLabel = new System.Windows.Forms.Label();
            total_ticketLabel = new System.Windows.Forms.Label();
            total_priceLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticket2U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingNavigator)).BeginInit();
            this.concertBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booking_idLabel
            // 
            booking_idLabel.AutoSize = true;
            booking_idLabel.Location = new System.Drawing.Point(1134, 34);
            booking_idLabel.Name = "booking_idLabel";
            booking_idLabel.Size = new System.Drawing.Size(75, 16);
            booking_idLabel.TabIndex = 2;
            booking_idLabel.Text = "Concert ID :";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(1134, 62);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(99, 16);
            user_idLabel.TabIndex = 4;
            user_idLabel.Text = "Concert Name :";
            // 
            // concert_idLabel
            // 
            concert_idLabel.AutoSize = true;
            concert_idLabel.Location = new System.Drawing.Point(1134, 90);
            concert_idLabel.Name = "concert_idLabel";
            concert_idLabel.Size = new System.Drawing.Size(107, 16);
            concert_idLabel.TabIndex = 6;
            concert_idLabel.Text = "Concert Details : ";
            // 
            // booking_dateLabel
            // 
            booking_dateLabel.AutoSize = true;
            booking_dateLabel.Location = new System.Drawing.Point(1134, 238);
            booking_dateLabel.Name = "booking_dateLabel";
            booking_dateLabel.Size = new System.Drawing.Size(42, 16);
            booking_dateLabel.TabIndex = 8;
            booking_dateLabel.Text = "Date :";
            // 
            // total_ticketLabel
            // 
            total_ticketLabel.AutoSize = true;
            total_ticketLabel.Location = new System.Drawing.Point(1134, 269);
            total_ticketLabel.Name = "total_ticketLabel";
            total_ticketLabel.Size = new System.Drawing.Size(122, 16);
            total_ticketLabel.TabIndex = 10;
            total_ticketLabel.Text = "Ticket Price ( RM ) :";
            // 
            // total_priceLabel
            // 
            total_priceLabel.AutoSize = true;
            total_priceLabel.Location = new System.Drawing.Point(1134, 297);
            total_priceLabel.Name = "total_priceLabel";
            total_priceLabel.Size = new System.Drawing.Size(104, 16);
            total_priceLabel.TabIndex = 12;
            total_priceLabel.Text = "Available Seat : ";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(1134, 325);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(0, 16);
            statusLabel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1134, 207);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 16);
            label1.TabIndex = 23;
            label1.Text = "Venue :";
            // 
            // ticket2U
            // 
            this.ticket2U.DataSetName = "Ticket2U";
            this.ticket2U.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concertBindingSource
            // 
            this.concertBindingSource.DataMember = "Concert";
            this.concertBindingSource.DataSource = this.ticket2U;
            // 
            // concertBindingNavigator
            // 
            this.concertBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.concertBindingNavigator.BindingSource = this.concertBindingSource;
            this.concertBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.concertBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.concertBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.concertBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.concertBindingNavigatorSaveItem});
            this.concertBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.concertBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.concertBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.concertBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.concertBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.concertBindingNavigator.Name = "concertBindingNavigator";
            this.concertBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.concertBindingNavigator.Size = new System.Drawing.Size(1527, 27);
            this.concertBindingNavigator.TabIndex = 0;
            this.concertBindingNavigator.Text = "bindingNavigator1";
            this.concertBindingNavigator.RefreshItems += new System.EventHandler(this.concertBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // concertBindingNavigatorSaveItem
            // 
            this.concertBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.concertBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("concertBindingNavigatorSaveItem.Image")));
            this.concertBindingNavigatorSaveItem.Name = "concertBindingNavigatorSaveItem";
            this.concertBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.concertBindingNavigatorSaveItem.Text = "Save Data";
            this.concertBindingNavigatorSaveItem.Click += new System.EventHandler(this.concertBindingNavigatorSaveItem_Click);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.ticket2U;
            // 
            // ConIdTB
            // 
            this.ConIdTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "booking_id", true));
            this.ConIdTB.Location = new System.Drawing.Point(1266, 34);
            this.ConIdTB.Name = "ConIdTB";
            this.ConIdTB.Size = new System.Drawing.Size(238, 22);
            this.ConIdTB.TabIndex = 3;
            // 
            // ConNameTB
            // 
            this.ConNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "user_id", true));
            this.ConNameTB.Location = new System.Drawing.Point(1266, 62);
            this.ConNameTB.Name = "ConNameTB";
            this.ConNameTB.Size = new System.Drawing.Size(238, 22);
            this.ConNameTB.TabIndex = 5;
            // 
            // ConDetailTB
            // 
            this.ConDetailTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "concert_id", true));
            this.ConDetailTB.Location = new System.Drawing.Point(1266, 90);
            this.ConDetailTB.Multiline = true;
            this.ConDetailTB.Name = "ConDetailTB";
            this.ConDetailTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ConDetailTB.Size = new System.Drawing.Size(238, 98);
            this.ConDetailTB.TabIndex = 7;
            // 
            // DateDTP
            // 
            this.DateDTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingBindingSource, "booking_date", true));
            this.DateDTP.Location = new System.Drawing.Point(1266, 238);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(238, 22);
            this.DateDTP.TabIndex = 9;
            // 
            // TicPriceTB
            // 
            this.TicPriceTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "total_ticket", true));
            this.TicPriceTB.Location = new System.Drawing.Point(1266, 269);
            this.TicPriceTB.Name = "TicPriceTB";
            this.TicPriceTB.Size = new System.Drawing.Size(238, 22);
            this.TicPriceTB.TabIndex = 11;
            // 
            // SeatTB
            // 
            this.SeatTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "total_price", true));
            this.SeatTB.Location = new System.Drawing.Point(1266, 297);
            this.SeatTB.Name = "SeatTB";
            this.SeatTB.Size = new System.Drawing.Size(238, 22);
            this.SeatTB.TabIndex = 13;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(1137, 345);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 35);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Location = new System.Drawing.Point(1279, 345);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(90, 35);
            this.UpdateBtn.TabIndex = 17;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Olive;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Location = new System.Drawing.Point(1415, 345);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 35);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.Location = new System.Drawing.Point(1279, 401);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 35);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(27, 416);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(128, 35);
            this.ReportBtn.TabIndex = 20;
            this.ReportBtn.Text = "REPORT PAGE";
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // ReceiptBtn
            // 
            this.ReceiptBtn.Location = new System.Drawing.Point(195, 416);
            this.ReceiptBtn.Name = "ReceiptBtn";
            this.ReceiptBtn.Size = new System.Drawing.Size(128, 35);
            this.ReceiptBtn.TabIndex = 21;
            this.ReceiptBtn.Text = "RECEIPT PAGE";
            this.ReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // BoMarkBtn
            // 
            this.BoMarkBtn.Location = new System.Drawing.Point(360, 416);
            this.BoMarkBtn.Name = "BoMarkBtn";
            this.BoMarkBtn.Size = new System.Drawing.Size(170, 35);
            this.BoMarkBtn.TabIndex = 22;
            this.BoMarkBtn.Text = "BOOKMARK PAGE";
            this.BoMarkBtn.UseVisualStyleBackColor = true;
            // 
            // concertTableAdapter
            // 
            this.concertTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.BookMarkTableAdapter = null;
            this.tableAdapterManager.ConcertTableAdapter = this.concertTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.SeatTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.TicketTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projectEDPforreal.Ticket2UTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // VenueTB
            // 
            this.VenueTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "total_price", true));
            this.VenueTB.Location = new System.Drawing.Point(1266, 207);
            this.VenueTB.Name = "VenueTB";
            this.VenueTB.Size = new System.Drawing.Size(238, 22);
            this.VenueTB.TabIndex = 24;
            // 
            // concertDataGridView
            // 
            this.concertDataGridView.AutoGenerateColumns = false;
            this.concertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.concertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertidDataGridViewTextBoxColumn,
            this.concertnameDataGridViewTextBoxColumn,
            this.concertdetailsDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.ticketpriceDataGridViewTextBoxColumn,
            this.availableseatDataGridViewTextBoxColumn});
            this.concertDataGridView.DataSource = this.concertBindingSource;
            this.concertDataGridView.Location = new System.Drawing.Point(12, 40);
            this.concertDataGridView.Name = "concertDataGridView";
            this.concertDataGridView.RowHeadersWidth = 51;
            this.concertDataGridView.RowTemplate.Height = 24;
            this.concertDataGridView.Size = new System.Drawing.Size(1086, 356);
            this.concertDataGridView.TabIndex = 24;
            // 
            // concertidDataGridViewTextBoxColumn
            // 
            this.concertidDataGridViewTextBoxColumn.DataPropertyName = "concert_id";
            this.concertidDataGridViewTextBoxColumn.HeaderText = "concert_id";
            this.concertidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.concertidDataGridViewTextBoxColumn.Name = "concertidDataGridViewTextBoxColumn";
            this.concertidDataGridViewTextBoxColumn.Width = 125;
            // 
            // concertnameDataGridViewTextBoxColumn
            // 
            this.concertnameDataGridViewTextBoxColumn.DataPropertyName = "concert_name";
            this.concertnameDataGridViewTextBoxColumn.HeaderText = "concert_name";
            this.concertnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.concertnameDataGridViewTextBoxColumn.Name = "concertnameDataGridViewTextBoxColumn";
            this.concertnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // concertdetailsDataGridViewTextBoxColumn
            // 
            this.concertdetailsDataGridViewTextBoxColumn.DataPropertyName = "concert_details";
            this.concertdetailsDataGridViewTextBoxColumn.HeaderText = "concert_details";
            this.concertdetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.concertdetailsDataGridViewTextBoxColumn.Name = "concertdetailsDataGridViewTextBoxColumn";
            this.concertdetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "venue";
            this.venueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            this.venueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketpriceDataGridViewTextBoxColumn
            // 
            this.ticketpriceDataGridViewTextBoxColumn.DataPropertyName = "ticket_price";
            this.ticketpriceDataGridViewTextBoxColumn.HeaderText = "ticket_price";
            this.ticketpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketpriceDataGridViewTextBoxColumn.Name = "ticketpriceDataGridViewTextBoxColumn";
            this.ticketpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableseatDataGridViewTextBoxColumn
            // 
            this.availableseatDataGridViewTextBoxColumn.DataPropertyName = "available_seat";
            this.availableseatDataGridViewTextBoxColumn.HeaderText = "available_seat";
            this.availableseatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableseatDataGridViewTextBoxColumn.Name = "availableseatDataGridViewTextBoxColumn";
            this.availableseatDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.ticket2U;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 471);
            this.Controls.Add(this.concertDataGridView);
            this.Controls.Add(this.VenueTB);
            this.Controls.Add(label1);
            this.Controls.Add(this.BoMarkBtn);
            this.Controls.Add(this.ReceiptBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(booking_idLabel);
            this.Controls.Add(this.ConIdTB);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.ConNameTB);
            this.Controls.Add(concert_idLabel);
            this.Controls.Add(this.ConDetailTB);
            this.Controls.Add(booking_dateLabel);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(total_ticketLabel);
            this.Controls.Add(this.TicPriceTB);
            this.Controls.Add(total_priceLabel);
            this.Controls.Add(this.SeatTB);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.concertBindingNavigator);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ticket2U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingNavigator)).EndInit();
            this.concertBindingNavigator.ResumeLayout(false);
            this.concertBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ticket2U ticket2U;
        private System.Windows.Forms.BindingSource concertBindingSource;
        private System.Windows.Forms.BindingNavigator concertBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton concertBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.TextBox ConIdTB;
        private System.Windows.Forms.TextBox ConNameTB;
        private System.Windows.Forms.TextBox ConDetailTB;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.TextBox TicPriceTB;
        private System.Windows.Forms.TextBox SeatTB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button ReceiptBtn;
        private System.Windows.Forms.Button BoMarkBtn;
        private Ticket2UTableAdapters.ConcertTableAdapter concertTableAdapter;
        private Ticket2UTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox VenueTB;
        private System.Windows.Forms.DataGridView concertDataGridView;
        private Ticket2UTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Ticket2UTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableseatDataGridViewTextBoxColumn;
    }
}