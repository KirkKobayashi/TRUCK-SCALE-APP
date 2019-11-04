<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrans))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWeighout = New System.Windows.Forms.Label()
        Me.lblWeighin = New System.Windows.Forms.Label()
        Me.cmdScale = New System.Windows.Forms.Button()
        Me.txtTare = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboTruck = New System.Windows.Forms.ComboBox()
        Me.cboPlate = New System.Windows.Forms.ComboBox()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransPanel = New System.Windows.Forms.Panel()
        Me.DG_Trans = New System.Windows.Forms.DataGridView()
        Me.RbPending = New System.Windows.Forms.RadioButton()
        Me.RbCompleted = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.ToolTipTrans = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 40)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(5, 893)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(1254, 40)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(5, 893)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TransPanel)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtNotes)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.cboProduct)
        Me.Panel2.Controls.Add(Me.cboSupplier)
        Me.Panel2.Controls.Add(Me.cboCustomer)
        Me.Panel2.Controls.Add(Me.cboTruck)
        Me.Panel2.Controls.Add(Me.cboPlate)
        Me.Panel2.Controls.Add(Me.txtTicket)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DG_Trans)
        Me.Panel2.Controls.Add(Me.RbPending)
        Me.Panel2.Controls.Add(Me.RbCompleted)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dateStart)
        Me.Panel2.Controls.Add(Me.dateEnd)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(5, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1249, 893)
        Me.Panel2.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 357)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Notes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Truck Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Customer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Supplier"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Product"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Plate Number"
        '
        'cmdClear
        '
        Me.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.Location = New System.Drawing.Point(249, 664)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(87, 108)
        Me.cmdClear.TabIndex = 59
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.cmdClear, "Clear")
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(156, 664)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 108)
        Me.cmdSave.TabIndex = 58
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.cmdSave, "Save / update transaction")
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWeighout)
        Me.GroupBox1.Controls.Add(Me.lblWeighin)
        Me.GroupBox1.Controls.Add(Me.cmdScale)
        Me.GroupBox1.Controls.Add(Me.txtTare)
        Me.GroupBox1.Controls.Add(Me.txtNet)
        Me.GroupBox1.Controls.Add(Me.txtGross)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 463)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 195)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'lblWeighout
        '
        Me.lblWeighout.AutoSize = True
        Me.lblWeighout.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeighout.Location = New System.Drawing.Point(104, 167)
        Me.lblWeighout.Name = "lblWeighout"
        Me.lblWeighout.Size = New System.Drawing.Size(0, 15)
        Me.lblWeighout.TabIndex = 52
        '
        'lblWeighin
        '
        Me.lblWeighin.AutoSize = True
        Me.lblWeighin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeighin.Location = New System.Drawing.Point(104, 143)
        Me.lblWeighin.Name = "lblWeighin"
        Me.lblWeighin.Size = New System.Drawing.Size(0, 15)
        Me.lblWeighin.TabIndex = 51
        '
        'cmdScale
        '
        Me.cmdScale.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdScale.Image = CType(resources.GetObject("cmdScale.Image"), System.Drawing.Image)
        Me.cmdScale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdScale.Location = New System.Drawing.Point(202, 32)
        Me.cmdScale.Name = "cmdScale"
        Me.cmdScale.Size = New System.Drawing.Size(87, 108)
        Me.cmdScale.TabIndex = 9
        Me.cmdScale.Text = "Clear"
        Me.cmdScale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdScale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.cmdScale, "Update weights")
        Me.cmdScale.UseVisualStyleBackColor = True
        '
        'txtTare
        '
        Me.txtTare.BackColor = System.Drawing.Color.LightGray
        Me.txtTare.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTare.Location = New System.Drawing.Point(105, 69)
        Me.txtTare.Name = "txtTare"
        Me.txtTare.ReadOnly = True
        Me.txtTare.Size = New System.Drawing.Size(91, 31)
        Me.txtTare.TabIndex = 8
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.Color.LightGray
        Me.txtNet.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(105, 109)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(91, 31)
        Me.txtNet.TabIndex = 7
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.Color.LightGray
        Me.txtGross.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(105, 29)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(91, 31)
        Me.txtGross.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tare Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Net Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Gross Weight"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.LightGray
        Me.txtNotes.Location = New System.Drawing.Point(133, 354)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(203, 103)
        Me.txtNotes.TabIndex = 57
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.LightGray
        Me.txtQuantity.Location = New System.Drawing.Point(133, 326)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(203, 22)
        Me.txtQuantity.TabIndex = 56
        '
        'cboProduct
        '
        Me.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProduct.BackColor = System.Drawing.Color.LightGray
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(133, 295)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(203, 25)
        Me.cboProduct.TabIndex = 55
        '
        'cboSupplier
        '
        Me.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSupplier.BackColor = System.Drawing.Color.LightGray
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(133, 264)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(203, 25)
        Me.cboSupplier.TabIndex = 54
        '
        'cboCustomer
        '
        Me.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCustomer.BackColor = System.Drawing.Color.LightGray
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(133, 233)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(203, 25)
        Me.cboCustomer.TabIndex = 53
        '
        'cboTruck
        '
        Me.cboTruck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTruck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTruck.BackColor = System.Drawing.Color.LightGray
        Me.cboTruck.FormattingEnabled = True
        Me.cboTruck.Location = New System.Drawing.Point(133, 202)
        Me.cboTruck.Name = "cboTruck"
        Me.cboTruck.Size = New System.Drawing.Size(137, 25)
        Me.cboTruck.TabIndex = 52
        '
        'cboPlate
        '
        Me.cboPlate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPlate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPlate.BackColor = System.Drawing.Color.LightGray
        Me.cboPlate.FormattingEnabled = True
        Me.cboPlate.Location = New System.Drawing.Point(133, 171)
        Me.cboPlate.Name = "cboPlate"
        Me.cboPlate.Size = New System.Drawing.Size(203, 25)
        Me.cboPlate.TabIndex = 51
        '
        'txtTicket
        '
        Me.txtTicket.BackColor = System.Drawing.Color.White
        Me.txtTicket.ForeColor = System.Drawing.Color.Red
        Me.txtTicket.Location = New System.Drawing.Point(133, 144)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(203, 22)
        Me.txtTicket.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Ticket Number"
        '
        'TransPanel
        '
        Me.TransPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TransPanel.Location = New System.Drawing.Point(771, 14)
        Me.TransPanel.Name = "TransPanel"
        Me.TransPanel.Size = New System.Drawing.Size(34, 44)
        Me.TransPanel.TabIndex = 2
        Me.TransPanel.Visible = False
        '
        'DG_Trans
        '
        Me.DG_Trans.AllowUserToAddRows = False
        Me.DG_Trans.AllowUserToDeleteRows = False
        Me.DG_Trans.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DG_Trans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Trans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Trans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_Trans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DG_Trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Trans.Location = New System.Drawing.Point(363, 139)
        Me.DG_Trans.Name = "DG_Trans"
        Me.DG_Trans.ReadOnly = True
        Me.DG_Trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Trans.Size = New System.Drawing.Size(879, 711)
        Me.DG_Trans.TabIndex = 20
        '
        'RbPending
        '
        Me.RbPending.AutoSize = True
        Me.RbPending.Location = New System.Drawing.Point(568, 84)
        Me.RbPending.Name = "RbPending"
        Me.RbPending.Size = New System.Drawing.Size(74, 21)
        Me.RbPending.TabIndex = 18
        Me.RbPending.Text = "Pending"
        Me.RbPending.UseVisualStyleBackColor = True
        '
        'RbCompleted
        '
        Me.RbCompleted.AutoSize = True
        Me.RbCompleted.Checked = True
        Me.RbCompleted.Location = New System.Drawing.Point(568, 36)
        Me.RbCompleted.Name = "RbCompleted"
        Me.RbCompleted.Size = New System.Drawing.Size(94, 21)
        Me.RbCompleted.TabIndex = 17
        Me.RbCompleted.TabStop = True
        Me.RbCompleted.Text = "Completed"
        Me.RbCompleted.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(668, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(87, 108)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.btnRefresh, "Refresh records")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "End"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Start"
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(298, 36)
        Me.dateStart.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateStart.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(236, 22)
        Me.dateStart.TabIndex = 15
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(298, 87)
        Me.dateEnd.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateEnd.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(236, 22)
        Me.dateEnd.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(193, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 108)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.btnDelete, "Delete transaction")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(100, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 108)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print "
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.btnPrint, "Print selected transaction")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(7, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 108)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "New Transaction"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipTrans.SetToolTip(Me.btnNew, "Begin an new transaction")
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 933)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTrans"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmTrans"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dateStart As DateTimePicker
    Friend WithEvents dateEnd As DateTimePicker
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents RbPending As RadioButton
    Friend WithEvents RbCompleted As RadioButton
    Friend WithEvents DG_Trans As DataGridView
    Friend WithEvents TransPanel As Panel
    Friend WithEvents ToolTipTrans As ToolTip
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblWeighout As Label
    Friend WithEvents lblWeighin As Label
    Friend WithEvents cmdScale As Button
    Friend WithEvents txtTare As TextBox
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtGross As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents cboTruck As ComboBox
    Friend WithEvents cboPlate As ComboBox
End Class
