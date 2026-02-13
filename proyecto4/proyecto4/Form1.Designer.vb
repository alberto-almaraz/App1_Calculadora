<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Numero1 = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxnum1 = New System.Windows.Forms.TextBox()
        Me.txtbxnum2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Numero2 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Multiplica = New System.Windows.Forms.Button()
        Me.Entre = New System.Windows.Forms.Button()
        Me.Cero = New System.Windows.Forms.Button()
        Me.Dos = New System.Windows.Forms.Button()
        Me.Tres = New System.Windows.Forms.Button()
        Me.Uno = New System.Windows.Forms.Button()
        Me.Cuatro = New System.Windows.Forms.Button()
        Me.Cinco = New System.Windows.Forms.Button()
        Me.Seis = New System.Windows.Forms.Button()
        Me.Siete = New System.Windows.Forms.Button()
        Me.Ocho = New System.Windows.Forms.Button()
        Me.Nueve = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Numero1
        '
        Me.Numero1.AutoSize = True
        Me.Numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Numero1.ForeColor = System.Drawing.Color.Maroon
        Me.Numero1.Location = New System.Drawing.Point(35, 48)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(82, 18)
        Me.Numero1.TabIndex = 0
        Me.Numero1.Text = "Número 1"
        '
        'Suma
        '
        Me.Suma.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma.Location = New System.Drawing.Point(614, 51)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(77, 65)
        Me.Suma.TabIndex = 1
        Me.Suma.Text = "+"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'txtbxnum1
        '
        Me.txtbxnum1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtbxnum1.Location = New System.Drawing.Point(148, 46)
        Me.txtbxnum1.Name = "txtbxnum1"
        Me.txtbxnum1.Size = New System.Drawing.Size(144, 20)
        Me.txtbxnum1.TabIndex = 3
        Me.txtbxnum1.Text = "0"
        '
        'txtbxnum2
        '
        Me.txtbxnum2.Location = New System.Drawing.Point(148, 87)
        Me.txtbxnum2.Name = "txtbxnum2"
        Me.txtbxnum2.Size = New System.Drawing.Size(144, 20)
        Me.txtbxnum2.TabIndex = 4
        Me.txtbxnum2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(407, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'Numero2
        '
        Me.Numero2.AutoSize = True
        Me.Numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Numero2.ForeColor = System.Drawing.Color.Maroon
        Me.Numero2.Location = New System.Drawing.Point(35, 89)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(82, 18)
        Me.Numero2.TabIndex = 7
        Me.Numero2.Text = "Número 2"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Resultado.ForeColor = System.Drawing.Color.Maroon
        Me.Resultado.Location = New System.Drawing.Point(35, 137)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(84, 18)
        Me.Resultado.TabIndex = 9
        Me.Resultado.Text = "Resultado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(201, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "0"
        '
        'Resta
        '
        Me.Resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(614, 137)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(77, 64)
        Me.Resta.TabIndex = 11
        Me.Resta.Text = "-"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplica
        '
        Me.Multiplica.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplica.Location = New System.Drawing.Point(614, 225)
        Me.Multiplica.Name = "Multiplica"
        Me.Multiplica.Size = New System.Drawing.Size(77, 63)
        Me.Multiplica.TabIndex = 12
        Me.Multiplica.Text = "*"
        Me.Multiplica.UseVisualStyleBackColor = True
        '
        'Entre
        '
        Me.Entre.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entre.Location = New System.Drawing.Point(614, 307)
        Me.Entre.Name = "Entre"
        Me.Entre.Size = New System.Drawing.Size(77, 70)
        Me.Entre.TabIndex = 13
        Me.Entre.Text = "/"
        Me.Entre.UseVisualStyleBackColor = True
        '
        'Cero
        '
        Me.Cero.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cero.Location = New System.Drawing.Point(410, 307)
        Me.Cero.Name = "Cero"
        Me.Cero.Size = New System.Drawing.Size(75, 70)
        Me.Cero.TabIndex = 14
        Me.Cero.Text = "0"
        Me.Cero.UseVisualStyleBackColor = True
        '
        'Dos
        '
        Me.Dos.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dos.Location = New System.Drawing.Point(410, 220)
        Me.Dos.Name = "Dos"
        Me.Dos.Size = New System.Drawing.Size(75, 70)
        Me.Dos.TabIndex = 15
        Me.Dos.Text = "2"
        Me.Dos.UseVisualStyleBackColor = True
        '
        'Tres
        '
        Me.Tres.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tres.Location = New System.Drawing.Point(503, 220)
        Me.Tres.Name = "Tres"
        Me.Tres.Size = New System.Drawing.Size(75, 70)
        Me.Tres.TabIndex = 16
        Me.Tres.Text = "3"
        Me.Tres.UseVisualStyleBackColor = True
        '
        'Uno
        '
        Me.Uno.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uno.Location = New System.Drawing.Point(313, 220)
        Me.Uno.Name = "Uno"
        Me.Uno.Size = New System.Drawing.Size(75, 70)
        Me.Uno.TabIndex = 17
        Me.Uno.Text = "1"
        Me.Uno.UseVisualStyleBackColor = True
        '
        'Cuatro
        '
        Me.Cuatro.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuatro.Location = New System.Drawing.Point(313, 128)
        Me.Cuatro.Name = "Cuatro"
        Me.Cuatro.Size = New System.Drawing.Size(75, 70)
        Me.Cuatro.TabIndex = 18
        Me.Cuatro.Text = "4"
        Me.Cuatro.UseVisualStyleBackColor = True
        '
        'Cinco
        '
        Me.Cinco.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cinco.Location = New System.Drawing.Point(410, 128)
        Me.Cinco.Name = "Cinco"
        Me.Cinco.Size = New System.Drawing.Size(75, 70)
        Me.Cinco.TabIndex = 19
        Me.Cinco.Text = "5"
        Me.Cinco.UseVisualStyleBackColor = True
        '
        'Seis
        '
        Me.Seis.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seis.Location = New System.Drawing.Point(503, 128)
        Me.Seis.Name = "Seis"
        Me.Seis.Size = New System.Drawing.Size(75, 70)
        Me.Seis.TabIndex = 20
        Me.Seis.Text = "6"
        Me.Seis.UseVisualStyleBackColor = True
        '
        'Siete
        '
        Me.Siete.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siete.Location = New System.Drawing.Point(313, 46)
        Me.Siete.Name = "Siete"
        Me.Siete.Size = New System.Drawing.Size(75, 70)
        Me.Siete.TabIndex = 21
        Me.Siete.Text = "7"
        Me.Siete.UseVisualStyleBackColor = True
        '
        'Ocho
        '
        Me.Ocho.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ocho.Location = New System.Drawing.Point(410, 46)
        Me.Ocho.Name = "Ocho"
        Me.Ocho.Size = New System.Drawing.Size(75, 70)
        Me.Ocho.TabIndex = 22
        Me.Ocho.Text = "8"
        Me.Ocho.UseVisualStyleBackColor = True
        '
        'Nueve
        '
        Me.Nueve.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nueve.Location = New System.Drawing.Point(503, 46)
        Me.Nueve.Name = "Nueve"
        Me.Nueve.Size = New System.Drawing.Size(75, 70)
        Me.Nueve.TabIndex = 23
        Me.Nueve.Text = "9"
        Me.Nueve.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(512, 307)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(66, 70)
        Me.Borrar.TabIndex = 24
        Me.Borrar.Text = "C"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(962, 598)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Nueve)
        Me.Controls.Add(Me.Ocho)
        Me.Controls.Add(Me.Siete)
        Me.Controls.Add(Me.Seis)
        Me.Controls.Add(Me.Cinco)
        Me.Controls.Add(Me.Cuatro)
        Me.Controls.Add(Me.Uno)
        Me.Controls.Add(Me.Tres)
        Me.Controls.Add(Me.Dos)
        Me.Controls.Add(Me.Cero)
        Me.Controls.Add(Me.Entre)
        Me.Controls.Add(Me.Multiplica)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Numero2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxnum2)
        Me.Controls.Add(Me.txtbxnum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.Numero1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Numero1 As Label
    Friend WithEvents Suma As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxnum1 As TextBox
    Friend WithEvents txtbxnum2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Numero2 As Label
    Friend WithEvents Resultado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Resta As Button
    Friend WithEvents Multiplica As Button
    Friend WithEvents Entre As Button
    Friend WithEvents Cero As Button
    Friend WithEvents Dos As Button
    Friend WithEvents Tres As Button
    Friend WithEvents Uno As Button
    Friend WithEvents Cuatro As Button
    Friend WithEvents Cinco As Button
    Friend WithEvents Seis As Button
    Friend WithEvents Siete As Button
    Friend WithEvents Ocho As Button
    Friend WithEvents Nueve As Button
    Friend WithEvents Borrar As Button
End Class
