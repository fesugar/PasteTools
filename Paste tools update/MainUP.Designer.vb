<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUP
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUP))
        Me.Label_tip = New System.Windows.Forms.Label()
        Me.Label_url = New System.Windows.Forms.Label()
        Me.LinkLabel_url = New System.Windows.Forms.LinkLabel()
        Me.TextBox_Msg = New System.Windows.Forms.TextBox()
        Me.Btn_down = New System.Windows.Forms.Button()
        Me.Btn_exit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_tip
        '
        Me.Label_tip.AutoSize = True
        Me.Label_tip.BackColor = System.Drawing.Color.Transparent
        Me.Label_tip.Location = New System.Drawing.Point(12, 54)
        Me.Label_tip.Name = "Label_tip"
        Me.Label_tip.Size = New System.Drawing.Size(65, 12)
        Me.Label_tip.TabIndex = 0
        Me.Label_tip.Text = "检测新版本"
        '
        'Label_url
        '
        Me.Label_url.AutoSize = True
        Me.Label_url.Location = New System.Drawing.Point(12, 217)
        Me.Label_url.Name = "Label_url"
        Me.Label_url.Size = New System.Drawing.Size(65, 12)
        Me.Label_url.TabIndex = 1
        Me.Label_url.Text = "下载地址："
        '
        'LinkLabel_url
        '
        Me.LinkLabel_url.AutoSize = True
        Me.LinkLabel_url.Location = New System.Drawing.Point(74, 217)
        Me.LinkLabel_url.Name = "LinkLabel_url"
        Me.LinkLabel_url.Size = New System.Drawing.Size(89, 12)
        Me.LinkLabel_url.TabIndex = 3
        Me.LinkLabel_url.TabStop = True
        Me.LinkLabel_url.Text = "点击下载完整版"
        '
        'TextBox_Msg
        '
        Me.TextBox_Msg.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Msg.Enabled = False
        Me.TextBox_Msg.Location = New System.Drawing.Point(14, 73)
        Me.TextBox_Msg.Multiline = True
        Me.TextBox_Msg.Name = "TextBox_Msg"
        Me.TextBox_Msg.ReadOnly = True
        Me.TextBox_Msg.ShortcutsEnabled = False
        Me.TextBox_Msg.Size = New System.Drawing.Size(317, 120)
        Me.TextBox_Msg.TabIndex = 4
        Me.TextBox_Msg.Text = "正在获取最新版本，请稍候..."
        '
        'Btn_down
        '
        Me.Btn_down.Location = New System.Drawing.Point(217, 212)
        Me.Btn_down.Name = "Btn_down"
        Me.Btn_down.Size = New System.Drawing.Size(55, 22)
        Me.Btn_down.TabIndex = 5
        Me.Btn_down.Text = "升级"
        Me.Btn_down.UseVisualStyleBackColor = True
        '
        'Btn_exit
        '
        Me.Btn_exit.Location = New System.Drawing.Point(278, 212)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.Size = New System.Drawing.Size(53, 22)
        Me.Btn_exit.TabIndex = 6
        Me.Btn_exit.Text = "关闭"
        Me.Btn_exit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 199)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(317, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'backgroundWorker1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "粘贴工具"
        '
        'MainUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 238)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.Btn_down)
        Me.Controls.Add(Me.TextBox_Msg)
        Me.Controls.Add(Me.LinkLabel_url)
        Me.Controls.Add(Me.Label_url)
        Me.Controls.Add(Me.Label_tip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "粘贴工具在线升级"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_tip As System.Windows.Forms.Label
    Friend WithEvents Label_url As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_url As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox_Msg As System.Windows.Forms.TextBox
    Friend WithEvents Btn_down As System.Windows.Forms.Button
    Friend WithEvents Btn_exit As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
