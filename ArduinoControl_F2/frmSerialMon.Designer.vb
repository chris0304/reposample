<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialMon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerialMon))
        Me.mscMonitor = New AxMSCommLib.AxMSComm()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtRcv = New System.Windows.Forms.TextBox()
        Me.cboAppend = New System.Windows.Forms.ComboBox()
        CType(Me.mscMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mscMonitor
        '
        Me.mscMonitor.Enabled = True
        Me.mscMonitor.Location = New System.Drawing.Point(1, 343)
        Me.mscMonitor.Name = "mscMonitor"
        Me.mscMonitor.OcxState = CType(resources.GetObject("mscMonitor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mscMonitor.Size = New System.Drawing.Size(38, 38)
        Me.mscMonitor.TabIndex = 0
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(12, 12)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(425, 20)
        Me.txtTransmit.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(454, 13)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtRcv
        '
        Me.txtRcv.Location = New System.Drawing.Point(12, 38)
        Me.txtRcv.MaxLength = 0
        Me.txtRcv.Multiline = True
        Me.txtRcv.Name = "txtRcv"
        Me.txtRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRcv.Size = New System.Drawing.Size(425, 290)
        Me.txtRcv.TabIndex = 3
        '
        'cboAppend
        '
        Me.cboAppend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppend.FormattingEnabled = True
        Me.cboAppend.Items.AddRange(New Object() {"No Line Ends", "New Line", "Carriage Return", "Both NL & CR"})
        Me.cboAppend.Location = New System.Drawing.Point(298, 343)
        Me.cboAppend.Name = "cboAppend"
        Me.cboAppend.Size = New System.Drawing.Size(121, 21)
        Me.cboAppend.TabIndex = 4
        '
        'frmSerialMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 384)
        Me.Controls.Add(Me.cboAppend)
        Me.Controls.Add(Me.txtRcv)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtTransmit)
        Me.Controls.Add(Me.mscMonitor)
        Me.Name = "frmSerialMon"
        Me.Text = "frmSerialMon"
        CType(Me.mscMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mscMonitor As AxMSCommLib.AxMSComm
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtRcv As System.Windows.Forms.TextBox
    Friend WithEvents cboAppend As System.Windows.Forms.ComboBox
End Class
