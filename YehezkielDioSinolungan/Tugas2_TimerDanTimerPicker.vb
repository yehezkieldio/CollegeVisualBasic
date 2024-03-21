' This practice project is authored by: @elizielx - https://github.com/yehezkieldio
' Licensed under the MIT license, refer to the LICENSE file for more information.

Public Class Tugas2_TimerDanTimerPicker
    ' Handle the Tugas2_TimerDanTimerPicker_Load event
    Private Sub Tugas2_TimerDanTimerPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd,dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    ' Handle the Timer1_Tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "h:mm:ss tt")
        Label2.Text = Format(Now, "hh:mm:ss")
    End Sub
End Class