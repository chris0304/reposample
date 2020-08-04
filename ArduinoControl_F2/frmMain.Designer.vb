<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.ArduinoGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoystickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinearHallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetalTouchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveBuzzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommPortList = New System.Windows.Forms.ToolStripMenuItem()
        Me.cList = New System.Windows.Forms.ToolStripComboBox()
        Me.SerialMonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.btnCompile = New System.Windows.Forms.Button()
        Me.PassiveBuzzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RGBLEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagneticSpringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaserEmitterRecieverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSensorAndLEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShockSensorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightCupModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiltSwitchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BallSwitchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoresistorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalogTemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallSensorMagneticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallSensorAnalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TapSensorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightblockingSensorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BigAndSmallSoundSensorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArduinoGuideToolStripMenuItem, Me.CommPortList, Me.SerialMonitorToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(821, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'ArduinoGuideToolStripMenuItem
        '
        Me.ArduinoGuideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JoystickToolStripMenuItem, Me.RelayToolStripMenuItem, Me.LinearHallToolStripMenuItem, Me.MetalTouchToolStripMenuItem, Me.ActiveBuzzerToolStripMenuItem, Me.PassiveBuzzerToolStripMenuItem, Me.RGBLEDToolStripMenuItem, Me.SMDToolStripMenuItem, Me.MagneticSpringToolStripMenuItem, Me.LaserEmitterRecieverToolStripMenuItem, Me.ButtonSensorAndLEDToolStripMenuItem, Me.ShockSensorToolStripMenuItem, Me.LightCupModuleToolStripMenuItem, Me.TiltSwitchToolStripMenuItem, Me.BallSwitchToolStripMenuItem, Me.PhotoresistorToolStripMenuItem, Me.AnalogTemperatureToolStripMenuItem, Me.HallSensorMagneticToolStripMenuItem, Me.HallSensorAnalogToolStripMenuItem, Me.TapSensorToolStripMenuItem, Me.LightblockingSensorToolStripMenuItem, Me.BigAndSmallSoundSensorToolStripMenuItem})
        Me.ArduinoGuideToolStripMenuItem.Name = "ArduinoGuideToolStripMenuItem"
        Me.ArduinoGuideToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ArduinoGuideToolStripMenuItem.Text = "Arduino Guide"
        '
        'JoystickToolStripMenuItem
        '
        Me.JoystickToolStripMenuItem.Name = "JoystickToolStripMenuItem"
        Me.JoystickToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.JoystickToolStripMenuItem.Text = "Joystick"
        '
        'RelayToolStripMenuItem
        '
        Me.RelayToolStripMenuItem.Name = "RelayToolStripMenuItem"
        Me.RelayToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.RelayToolStripMenuItem.Text = "Relay"
        '
        'LinearHallToolStripMenuItem
        '
        Me.LinearHallToolStripMenuItem.Name = "LinearHallToolStripMenuItem"
        Me.LinearHallToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LinearHallToolStripMenuItem.Text = "Linear Hall"
        '
        'MetalTouchToolStripMenuItem
        '
        Me.MetalTouchToolStripMenuItem.Name = "MetalTouchToolStripMenuItem"
        Me.MetalTouchToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MetalTouchToolStripMenuItem.Text = "Metal Touch"
        '
        'ActiveBuzzerToolStripMenuItem
        '
        Me.ActiveBuzzerToolStripMenuItem.Name = "ActiveBuzzerToolStripMenuItem"
        Me.ActiveBuzzerToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ActiveBuzzerToolStripMenuItem.Text = "Active Buzzer"
        '
        'CommPortList
        '
        Me.CommPortList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cList})
        Me.CommPortList.Name = "CommPortList"
        Me.CommPortList.Size = New System.Drawing.Size(131, 20)
        Me.CommPortList.Text = "Communication Port"
        '
        'cList
        '
        Me.cList.Name = "cList"
        Me.cList.Size = New System.Drawing.Size(121, 23)
        '
        'SerialMonitorToolStripMenuItem
        '
        Me.SerialMonitorToolStripMenuItem.Name = "SerialMonitorToolStripMenuItem"
        Me.SerialMonitorToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.SerialMonitorToolStripMenuItem.Text = "Serial Monitor"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(12, 41)
        Me.txtSource.MaxLength = 0
        Me.txtSource.Multiline = True
        Me.txtSource.Name = "txtSource"
        Me.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSource.Size = New System.Drawing.Size(425, 332)
        Me.txtSource.TabIndex = 4
        '
        'btnCompile
        '
        Me.btnCompile.Location = New System.Drawing.Point(12, 379)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(134, 23)
        Me.btnCompile.TabIndex = 5
        Me.btnCompile.Text = "Compile"
        Me.btnCompile.UseVisualStyleBackColor = True
        '
        'PassiveBuzzerToolStripMenuItem
        '
        Me.PassiveBuzzerToolStripMenuItem.Name = "PassiveBuzzerToolStripMenuItem"
        Me.PassiveBuzzerToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PassiveBuzzerToolStripMenuItem.Text = "Passive Buzzer"
        '
        'RGBLEDToolStripMenuItem
        '
        Me.RGBLEDToolStripMenuItem.Name = "RGBLEDToolStripMenuItem"
        Me.RGBLEDToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.RGBLEDToolStripMenuItem.Text = "RGB LED"
        '
        'SMDToolStripMenuItem
        '
        Me.SMDToolStripMenuItem.Name = "SMDToolStripMenuItem"
        Me.SMDToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.SMDToolStripMenuItem.Text = "SMD"
        '
        'MagneticSpringToolStripMenuItem
        '
        Me.MagneticSpringToolStripMenuItem.Name = "MagneticSpringToolStripMenuItem"
        Me.MagneticSpringToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MagneticSpringToolStripMenuItem.Text = "Magnetic Spring"
        '
        'LaserEmitterRecieverToolStripMenuItem
        '
        Me.LaserEmitterRecieverToolStripMenuItem.Name = "LaserEmitterRecieverToolStripMenuItem"
        Me.LaserEmitterRecieverToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LaserEmitterRecieverToolStripMenuItem.Text = "Laser Emitter / Reciever"
        '
        'ButtonSensorAndLEDToolStripMenuItem
        '
        Me.ButtonSensorAndLEDToolStripMenuItem.Name = "ButtonSensorAndLEDToolStripMenuItem"
        Me.ButtonSensorAndLEDToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ButtonSensorAndLEDToolStripMenuItem.Text = "Button Sensor and LED"
        '
        'ShockSensorToolStripMenuItem
        '
        Me.ShockSensorToolStripMenuItem.Name = "ShockSensorToolStripMenuItem"
        Me.ShockSensorToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ShockSensorToolStripMenuItem.Text = "Shock Sensor"
        '
        'LightCupModuleToolStripMenuItem
        '
        Me.LightCupModuleToolStripMenuItem.Name = "LightCupModuleToolStripMenuItem"
        Me.LightCupModuleToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LightCupModuleToolStripMenuItem.Text = "Light Cup Module"
        '
        'TiltSwitchToolStripMenuItem
        '
        Me.TiltSwitchToolStripMenuItem.Name = "TiltSwitchToolStripMenuItem"
        Me.TiltSwitchToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TiltSwitchToolStripMenuItem.Text = "Tilt Switch"
        '
        'BallSwitchToolStripMenuItem
        '
        Me.BallSwitchToolStripMenuItem.Name = "BallSwitchToolStripMenuItem"
        Me.BallSwitchToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BallSwitchToolStripMenuItem.Text = "Ball Switch"
        '
        'PhotoresistorToolStripMenuItem
        '
        Me.PhotoresistorToolStripMenuItem.Name = "PhotoresistorToolStripMenuItem"
        Me.PhotoresistorToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PhotoresistorToolStripMenuItem.Text = "Photoresistor"
        '
        'AnalogTemperatureToolStripMenuItem
        '
        Me.AnalogTemperatureToolStripMenuItem.Name = "AnalogTemperatureToolStripMenuItem"
        Me.AnalogTemperatureToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AnalogTemperatureToolStripMenuItem.Text = "Analog Temperature"
        '
        'HallSensorMagneticToolStripMenuItem
        '
        Me.HallSensorMagneticToolStripMenuItem.Name = "HallSensorMagneticToolStripMenuItem"
        Me.HallSensorMagneticToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.HallSensorMagneticToolStripMenuItem.Text = "Hall Sensor (Magnetic)"
        '
        'HallSensorAnalogToolStripMenuItem
        '
        Me.HallSensorAnalogToolStripMenuItem.Name = "HallSensorAnalogToolStripMenuItem"
        Me.HallSensorAnalogToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.HallSensorAnalogToolStripMenuItem.Text = "Hall Sensor (Analog)"
        '
        'TapSensorToolStripMenuItem
        '
        Me.TapSensorToolStripMenuItem.Name = "TapSensorToolStripMenuItem"
        Me.TapSensorToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TapSensorToolStripMenuItem.Text = "Tap Sensor"
        '
        'LightblockingSensorToolStripMenuItem
        '
        Me.LightblockingSensorToolStripMenuItem.Name = "LightblockingSensorToolStripMenuItem"
        Me.LightblockingSensorToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LightblockingSensorToolStripMenuItem.Text = "Lightblocking Sensor"
        '
        'BigAndSmallSoundSensorToolStripMenuItem
        '
        Me.BigAndSmallSoundSensorToolStripMenuItem.Name = "BigAndSmallSoundSensorToolStripMenuItem"
        Me.BigAndSmallSoundSensorToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BigAndSmallSoundSensorToolStripMenuItem.Text = "Big and Small Sound Sensor"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 423)
        Me.Controls.Add(Me.btnCompile)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arduino Control"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ArduinoGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommPortList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialMonitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cList As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents JoystickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinearHallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetalTouchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActiveBuzzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents btnCompile As System.Windows.Forms.Button
    Friend WithEvents PassiveBuzzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RGBLEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagneticSpringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaserEmitterRecieverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonSensorAndLEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShockSensorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightCupModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiltSwitchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BallSwitchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotoresistorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalogTemperatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HallSensorMagneticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HallSensorAnalogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TapSensorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightblockingSensorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BigAndSmallSoundSensorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
