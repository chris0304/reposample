Public Class SerialMon

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

    Private Sub SerialMon_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed




    End Sub

    Private Sub SerialMon_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        mscMonitor.PortOpen = False

        Me.Dispose()

    End Sub

    Private Sub SerialMon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

       


    End Sub

    Private Sub SerialMon_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try

            With mscMonitor

                .CommPort = CInt(CommPort)
                .RThreshold = 1
                .Settings = "9600,n,8,1"
                .PortOpen = True

            End With

            cboAppend.SelectedIndex = 2


        Catch ex As Exception

            MessageBox.Show("Cannot Connect To Serial Port", "Fatal Error")
            Me.Dispose()
        End Try
    End Sub

    Private Sub mscMonitor_OnComm(sender As System.Object, e As System.EventArgs) Handles mscMonitor.OnComm

        Select Case mscMonitor.CommEvent

            Case MSCommLib.OnCommConstants.comEvReceive

                txtRcv.AppendText(mscMonitor.Input)

                If chkAutoScroll.Checked = False Then

                    txtRcv.Select(0, 0)
                    txtRcv.ScrollToCaret()
                End If

        End Select


    End Sub

    Private Sub txtRcv_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRcv.TextChanged

    End Sub
End Class