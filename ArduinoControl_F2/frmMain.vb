Public Class frmMain

    Dim Target As String

    Private Sub CommPortList_MouseHover(sender As Object, e As System.EventArgs) Handles CommPortList.MouseHover

        Try

            Dim CPLIst() As String = System.IO.Ports.SerialPort.GetPortNames

            cList.Items.Clear()
            cList.DropDownStyle = ComboBoxStyle.DropDownList

            For Each PName As String In CPLIst

                cList.Items.Add(PName)

            Next

            If CommPort <> "" Then

                cList.Text = "COM" & CommPort

            Else

                cList.SelectedIndex = 0


            End If



        Catch ex As Exception

        End Try


    End Sub

    Private Sub cList_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cList.SelectedIndexChanged


        Try


            CommPort = CInt(cList.SelectedItem.ToString.Substring(3))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SerialMonitorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SerialMonitorToolStripMenuItem.Click

        Dim SM As New frmSerialMon

        SM.ShowDialog()

    End Sub

    Private Sub JoystickToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        JoystickToolStripMenuItem.Click, _
        RelayToolStripMenuItem.Click, _
        MetalTouchToolStripMenuItem.Click, _
        LinearHallToolStripMenuItem.Click, _
        ActiveBuzzerToolStripMenuItem.Click, _
        PassiveBuzzerToolStripMenuItem.Click, _
        RGBLEDToolStripMenuItem.Click, _
        SMDToolStripMenuItem.Click, _
        MagneticSpringToolStripMenuItem.Click, _
        LaserEmitterRecieverToolStripMenuItem.Click, _
        ButtonSensorAndLEDToolStripMenuItem.Click, _
        ShockSensorToolStripMenuItem.Click, _
        LightCupModuleToolStripMenuItem.Click, _
        TiltSwitchToolStripMenuItem.Click, _
        BallSwitchToolStripMenuItem.Click, _
        PhotoresistorToolStripMenuItem.Click, _
        AnalogTemperatureToolStripMenuItem.Click, _
        HallSensorMagneticToolStripMenuItem.Click, _
        HallSensorAnalogToolStripMenuItem.Click, _
        TapSensorToolStripMenuItem.Click, _
        LightblockingSensorToolStripMenuItem.Click, _
        BigAndSmallSoundSensorToolStripMenuItem.Click

        'Dim fileContents As String

        'Select Case sender.name

        '    Case "JoystickToolStripMenuItem"
        '        Target = "Joystick.ino.hex"
        '        fileContents = My.Computer.FileSystem.ReadAllText("C:\Compiler\Joystick.txt")

        '    Case "RelayToolStripMenuItem"
        '        Target = "Relay.ino.hex"
        '        fileContents = My.Computer.FileSystem.ReadAllText("C:\Compiler\Relay.txt")

        '    Case "MetalTouchToolStripMenuItem"
        '        Target = "MetalTouch.ino.hex"
        '        fileContents = My.Computer.FileSystem.ReadAllText("C:\Compiler\MetalTouch.txt")

        '    Case "LinearHallToolStripMenuItem"
        '        Target = "LinearHall.ino.hex"
        '        fileContents = My.Computer.FileSystem.ReadAllText("C:\Compiler\LinearHall.txt")

        '    Case "ActiveBuzzerToolStripMenuItem"
        '        Target = "ActiveBuzzer.ino.hex"
        '        fileContents = My.Computer.FileSystem.ReadAllText("C:\Compiler\ActiveBuzzer.txt")

        'End Select

        'txtSource.Text = fileContents



        Dim KW As String

        Select Case sender.name

            Case "JoystickToolStripMenuItem" : KW = "Joystick"
            Case "RelayToolStripMenuItem" : KW = "Relay"
            Case "MetalTouchToolStripMenuItem" : KW = "MetalTouch"
            Case "LinearHallToolStripMenuItem" : KW = "LinearHall"
            Case "ActiveBuzzerToolStripMenuItem" : KW = "ActiveBuzzer"
            Case "PassiveBuzzerToolStripMenuItem" : KW = "PassiveBuzzer"
            Case "RGBLEDToolStripMenuItem" : KW = "RGBLed"
            Case "SMDToolStripMenuItem" : KW = "SMD"
            Case "MagneticSpringToolStripMenuItem" : KW = "MagneticSpring"
            Case "LaserEmitterRecieverToolStripMenuItem" : KW = "LaserEmitterReciever"
            Case "ButtonSensorAndLEDToolStripMenuItem" : KW = "ButtonSensorLed"
            Case "ShockSensorToolStripMenuItem" : KW = "ShockSensor"
            Case "LightCupModuleToolStripMenuItem" : KW = "LightCupModule"
            Case "TiltSwitchToolStripMenuItem" : KW = "TiltSwitch"
            Case "BallSwitchToolStripMenuItem" : KW = "BallSwitch"
            Case "PhotoresistorToolStripMenuItem" : KW = "Photoresistor"
            Case "AnalogTemperatureToolStripMenuItem" : KW = "AnalogTemp"
            Case "HallSensorMagneticToolStripMenuItem" : KW = "HallMagnetic"
            Case "HallSensorAnalogToolStripMenuItem" : KW = "HallAnalog"
            Case "TapSensorToolStripMenuItem" : KW = "TapSensor"
            Case "LightblockingSensorToolStripMenuItem" : KW = "LightBlocking"
            Case "BigAndSmallSoundSensorToolStripMenuItem" : KW = "BigSmallSound"

        End Select

        Target = KW & ".ino.hex"
        txtSource.Text = My.Computer.FileSystem.ReadAllText("C:\Compiler\" & KW & ".txt")



    End Sub

    Private Sub btnCompile_Click(sender As System.Object, e As System.EventArgs) Handles btnCompile.Click

        If Target <> "" Then

            Dim p As New ProcessStartInfo

            ' Specify the location of the binary
            p.FileName = "C:\Compiler\avr\bin\avrdude.exe"

            ' Use these arguments for the process
            p.Arguments = "-CC:\Compiler\avr\etc/avrdude.conf -v -patmega2560 -cwiring -PCOM106 -b115200 -D -Uflash:w:C:\Compiler\" & Target & ":i"

            ' Use a hidden window
            p.WindowStyle = ProcessWindowStyle.Hidden

            ' Start the process
            Process.Start(p)

            MessageBox.Show("Sketch Uploaded")

        End If

    End Sub
End Class
