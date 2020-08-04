Public Class frmSerialMon

    Private Sub mscMonitor_OnComm(sender As System.Object, e As System.EventArgs) Handles mscMonitor.OnComm

         Select mscMonitor.CommEvent

            Case MSCommLib.OnCommConstants.comEvReceive

                txtRcv.AppendText(mscMonitor.Input)

        End Select


    End Sub

    Private Sub frmSerialMon_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Dispose()

    End Sub

    Private Sub frmSerialMon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub frmSerialMon_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        Try

            With mscMonitor

                .CommPort = CInt(CommPort)
                .RThreshold = 1
                .Settings = "9600,n,8,1"
                .PortOpen = True

            End With

            cboAppend.Text = "Carriage Return"


        Catch ex As Exception

            MessageBox.Show("Cannot Connect To Serial Port", "Fatal Error")
            Me.Dispose()

        End Try

    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click

        mscMonitor.Output = txtTransmit.Text

        Select Case cboAppend.SelectedIndex

            Case 1

                mscMonitor.Output = CStr(Chr(10))

            Case 2

                mscMonitor.Output = CStr(Chr(13))

            Case 3

                mscMonitor.Output = vbCrLf


        End Select

        txtTransmit.Clear()


    End Sub
End Class