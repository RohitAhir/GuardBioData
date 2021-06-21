<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Profile
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainPanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ResignationDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.JoinDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DesignationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.CompanyNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.ResignationDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResignationDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoinDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoinDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.Controls.Add(Me.CompanyNameTextEdit)
        Me.MainPanel.Controls.Add(Me.btnCancel)
        Me.MainPanel.Controls.Add(Me.btnSave)
        Me.MainPanel.Controls.Add(Me.ResignationDateDateEdit)
        Me.MainPanel.Controls.Add(Me.JoinDateDateEdit)
        Me.MainPanel.Controls.Add(Me.DesignationTextEdit)
        Me.MainPanel.Controls.Add(Me.LabelControl4)
        Me.MainPanel.Controls.Add(Me.LabelControl3)
        Me.MainPanel.Controls.Add(Me.LabelControl2)
        Me.MainPanel.Controls.Add(Me.LabelControl1)
        Me.MainPanel.Location = New System.Drawing.Point(12, 12)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(325, 195)
        Me.MainPanel.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(217, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 41)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(124, 141)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 41)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        '
        'ResignationDateDateEdit
        '
        Me.ResignationDateDateEdit.EditValue = Nothing
        Me.ResignationDateDateEdit.Location = New System.Drawing.Point(124, 109)
        Me.ResignationDateDateEdit.Name = "ResignationDateDateEdit"
        Me.ResignationDateDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResignationDateDateEdit.Properties.Appearance.Options.UseFont = True
        Me.ResignationDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ResignationDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ResignationDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ResignationDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ResignationDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.ResignationDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ResignationDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.ResignationDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.ResignationDateDateEdit.Size = New System.Drawing.Size(180, 26)
        Me.ResignationDateDateEdit.TabIndex = 3
        '
        'JoinDateDateEdit
        '
        Me.JoinDateDateEdit.EditValue = Nothing
        Me.JoinDateDateEdit.Location = New System.Drawing.Point(124, 77)
        Me.JoinDateDateEdit.Name = "JoinDateDateEdit"
        Me.JoinDateDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoinDateDateEdit.Properties.Appearance.Options.UseFont = True
        Me.JoinDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JoinDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JoinDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.JoinDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.JoinDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.JoinDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.JoinDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.JoinDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.JoinDateDateEdit.Size = New System.Drawing.Size(180, 26)
        Me.JoinDateDateEdit.TabIndex = 2
        '
        'DesignationTextEdit
        '
        Me.DesignationTextEdit.Location = New System.Drawing.Point(124, 45)
        Me.DesignationTextEdit.Name = "DesignationTextEdit"
        Me.DesignationTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignationTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.DesignationTextEdit.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(22, 115)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Resignation Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(22, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Company Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(22, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Join Date"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Designation"
        '
        'CompanyNameTextEdit
        '
        Me.CompanyNameTextEdit.Location = New System.Drawing.Point(124, 13)
        Me.CompanyNameTextEdit.Name = "CompanyNameTextEdit"
        Me.CompanyNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CompanyNameTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.CompanyNameTextEdit.TabIndex = 0
        '
        'Frm_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 219)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profile"
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.ResignationDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResignationDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoinDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoinDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ResignationDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents JoinDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DesignationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents CompanyNameTextEdit As DevExpress.XtraEditors.TextEdit
End Class
