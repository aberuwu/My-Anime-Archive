Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Namespace Mal_Anime_Archive_Frm
    Public Class CustomPgb
        Inherits System.Windows.Forms.ProgressBar
        Private _Color As Color
        Private brush As New System.Drawing.Drawing2D.LinearGradientBrush(New Rectangle(1, 1, 1, 1), Color.FloralWhite, Color.Firebrick, LinearGradientMode.Vertical)
        Private m_rec As Rectangle
        Private draw As Boolean

        Private indraw As Boolean = True
        Public Sub New()
            MyBase.New()
            Me.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, True)
            _Color = Color.Red
            m_rec = New Rectangle(1, 1, 1, 1)
            draw = False
        End Sub

        <Category("Appearance"), Description("The Color of the progress bar")>
        <Browsable(True)>
        Public Property Color() As Color
            Get
                Return _Color
            End Get
            Set
                _Color = Value
            End Set
        End Property


        <Category("Behavior"), Description("Whether or not the progress bar should draw itself when the value hasn't changed")>
        <Browsable(True)>
        Public Property DrawEveryFrame() As Boolean
            Get
                Return draw
            End Get
            Set
                draw = Value
            End Set
        End Property

        Public Property Rec() As Rectangle
            Get
                Return m_rec
            End Get
            Set
                If Value.Height = 0 Then
                    Value.Height = 1
                End If
                If Value.Width = 0 Then
                    Value.Width = 1
                End If
                m_rec = Value
                brush = New LinearGradientBrush(Value, _Color, Color.FromArgb(_Color.R / 2, _Color.G / 2, _Color.B / 2), LinearGradientMode.Vertical)
            End Set
        End Property

        Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)

        End Sub

        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
            Dim width As Integer = 0
            If Value <> 0 Then
                width = (e.ClipRectangle.Width * Value \ Maximum) - 4
            End If
            If (m_rec.X <> e.ClipRectangle.X OrElse m_rec.Y <> e.ClipRectangle.Y OrElse m_rec.Width <> width OrElse m_rec.Height <> e.ClipRectangle.Height - 4) OrElse draw OrElse indraw Then
                indraw = False
                Rec = New Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, Me.Size.Width, Me.Size.Height)
                If m_rec.Height = 0 Then
                    m_rec.Height = 1
                End If
                If ProgressBarRenderer.IsSupported Then
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle)
                End If
                m_rec.Width = CInt(m_rec.Width * (CDbl(Value) / Maximum)) - 4
                m_rec.Height -= 4
                If m_rec.Width = 0 Then
                    m_rec.Width = 1
                End If
                e.Graphics.FillRectangle(brush, 2, 2, m_rec.Width, m_rec.Height)
                MyBase.OnPaint(e)
            End If
        End Sub
    End Class
End Namespace

