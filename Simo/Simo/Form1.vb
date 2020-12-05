Imports System.Speech
Imports System.Speech.Synthesis

Public Class Form1
    Dim simo As New SpeechSynthesizer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        simo.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simo.Volume = TrackBarvolume.Value
        simo.Rate = TrackBarSpeed.Value
        If ComboBoxChooseVoice.Text = "Male" Then
            simo.SelectVoiceByHints(VoiceGender.Male)
        ElseIf ComboBoxChooseVoice.Text = "Female" Then
            simo.SelectVoiceByHints(VoiceGender.Female)
        End If
        simo.SpeakAsync(RichTextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simo.SpeakAsyncCancelAll()
    End Sub

    Private Sub ButtonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPause.Click
        simo.Pause()

    End Sub

    Private Sub ButtonResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResume.Click
        simo.Resume()

    End Sub
End Class
