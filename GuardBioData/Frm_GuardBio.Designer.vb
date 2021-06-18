<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GuardBio
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
        Me.GuardNavigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.Page1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.Page2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        CType(Me.GuardNavigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuardNavigationFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'GuardNavigationFrame
        '
        Me.GuardNavigationFrame.Controls.Add(Me.Page1)
        Me.GuardNavigationFrame.Controls.Add(Me.Page2)
        Me.GuardNavigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuardNavigationFrame.Location = New System.Drawing.Point(0, 0)
        Me.GuardNavigationFrame.Name = "GuardNavigationFrame"
        Me.GuardNavigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.Page1, Me.Page2})
        Me.GuardNavigationFrame.SelectedPage = Me.Page1
        Me.GuardNavigationFrame.Size = New System.Drawing.Size(986, 444)
        Me.GuardNavigationFrame.TabIndex = 0
        Me.GuardNavigationFrame.Text = "GuardBioData"
        '
        'Page1
        '
        Me.Page1.Name = "Page1"
        Me.Page1.Size = New System.Drawing.Size(986, 444)
        '
        'Page2
        '
        Me.Page2.Name = "Page2"
        Me.Page2.Size = New System.Drawing.Size(986, 444)
        '
        'Frm_GuardBio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 444)
        Me.Controls.Add(Me.GuardNavigationFrame)
        Me.Name = "Frm_GuardBio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guard BIO DATA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GuardNavigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuardNavigationFrame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GuardNavigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents Page1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents Page2 As DevExpress.XtraBars.Navigation.NavigationPage
End Class
