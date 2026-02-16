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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTBXNumero1 = New System.Windows.Forms.TextBox()
        Me.TXTBXNumero2 = New System.Windows.Forms.TextBox()
        Me.BotonMas = New System.Windows.Forms.Button()
        Me.BotonResta = New System.Windows.Forms.Button()
        Me.BotonMultiplicacion = New System.Windows.Forms.Button()
        Me.BotonDivision = New System.Windows.Forms.Button()
        Me.BotonCero = New System.Windows.Forms.Button()
        Me.BotonUno = New System.Windows.Forms.Button()
        Me.ButonTres = New System.Windows.Forms.Button()
        Me.BotonOcho = New System.Windows.Forms.Button()
        Me.BotonCinco = New System.Windows.Forms.Button()
        Me.ButonDos = New System.Windows.Forms.Button()
        Me.BotonSiete = New System.Windows.Forms.Button()
        Me.BotonCuatro = New System.Windows.Forms.Button()
        Me.BotonSeis = New System.Windows.Forms.Button()
        Me.BotonNueve = New System.Windows.Forms.Button()
        Me.BotonBorrar = New System.Windows.Forms.Button()
        Me.botonpunto = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0"
        '
        'TXTBXNumero1
        '
        Me.TXTBXNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBXNumero1.Location = New System.Drawing.Point(213, 62)
        Me.TXTBXNumero1.Name = "TXTBXNumero1"
        Me.TXTBXNumero1.Size = New System.Drawing.Size(191, 20)
        Me.TXTBXNumero1.TabIndex = 4
        Me.TXTBXNumero1.Text = "0"
        '
        'TXTBXNumero2
        '
        Me.TXTBXNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBXNumero2.Location = New System.Drawing.Point(213, 146)
        Me.TXTBXNumero2.Name = "TXTBXNumero2"
        Me.TXTBXNumero2.Size = New System.Drawing.Size(191, 20)
        Me.TXTBXNumero2.TabIndex = 5
        Me.TXTBXNumero2.Text = "0"
        '
        'BotonMas
        '
        Me.BotonMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMas.Location = New System.Drawing.Point(532, 53)
        Me.BotonMas.Name = "BotonMas"
        Me.BotonMas.Size = New System.Drawing.Size(103, 75)
        Me.BotonMas.TabIndex = 6
        Me.BotonMas.Text = "+"
        Me.BotonMas.UseVisualStyleBackColor = True
        '
        'BotonResta
        '
        Me.BotonResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonResta.Location = New System.Drawing.Point(663, 53)
        Me.BotonResta.Name = "BotonResta"
        Me.BotonResta.Size = New System.Drawing.Size(103, 75)
        Me.BotonResta.TabIndex = 7
        Me.BotonResta.Text = "-"
        Me.BotonResta.UseVisualStyleBackColor = True
        '
        'BotonMultiplicacion
        '
        Me.BotonMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMultiplicacion.Location = New System.Drawing.Point(532, 146)
        Me.BotonMultiplicacion.Name = "BotonMultiplicacion"
        Me.BotonMultiplicacion.Size = New System.Drawing.Size(103, 75)
        Me.BotonMultiplicacion.TabIndex = 8
        Me.BotonMultiplicacion.Text = "*"
        Me.BotonMultiplicacion.UseVisualStyleBackColor = True
        '
        'BotonDivision
        '
        Me.BotonDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonDivision.Location = New System.Drawing.Point(663, 146)
        Me.BotonDivision.Name = "BotonDivision"
        Me.BotonDivision.Size = New System.Drawing.Size(103, 75)
        Me.BotonDivision.TabIndex = 9
        Me.BotonDivision.Text = "/"
        Me.BotonDivision.UseVisualStyleBackColor = True
        '
        'BotonCero
        '
        Me.BotonCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCero.Location = New System.Drawing.Point(577, 527)
        Me.BotonCero.Name = "BotonCero"
        Me.BotonCero.Size = New System.Drawing.Size(86, 69)
        Me.BotonCero.TabIndex = 10
        Me.BotonCero.Text = "0"
        Me.BotonCero.UseVisualStyleBackColor = True
        '
        'BotonUno
        '
        Me.BotonUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonUno.Location = New System.Drawing.Point(470, 452)
        Me.BotonUno.Name = "BotonUno"
        Me.BotonUno.Size = New System.Drawing.Size(86, 69)
        Me.BotonUno.TabIndex = 11
        Me.BotonUno.Text = "1"
        Me.BotonUno.UseVisualStyleBackColor = True
        '
        'ButonTres
        '
        Me.ButonTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButonTres.Location = New System.Drawing.Point(680, 452)
        Me.ButonTres.Name = "ButonTres"
        Me.ButonTres.Size = New System.Drawing.Size(86, 69)
        Me.ButonTres.TabIndex = 12
        Me.ButonTres.Text = "3"
        Me.ButonTres.UseVisualStyleBackColor = True
        '
        'BotonOcho
        '
        Me.BotonOcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonOcho.Location = New System.Drawing.Point(577, 302)
        Me.BotonOcho.Name = "BotonOcho"
        Me.BotonOcho.Size = New System.Drawing.Size(86, 69)
        Me.BotonOcho.TabIndex = 13
        Me.BotonOcho.Text = "8"
        Me.BotonOcho.UseVisualStyleBackColor = True
        '
        'BotonCinco
        '
        Me.BotonCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCinco.Location = New System.Drawing.Point(577, 377)
        Me.BotonCinco.Name = "BotonCinco"
        Me.BotonCinco.Size = New System.Drawing.Size(86, 69)
        Me.BotonCinco.TabIndex = 14
        Me.BotonCinco.Text = "5"
        Me.BotonCinco.UseVisualStyleBackColor = True
        '
        'ButonDos
        '
        Me.ButonDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButonDos.Location = New System.Drawing.Point(577, 452)
        Me.ButonDos.Name = "ButonDos"
        Me.ButonDos.Size = New System.Drawing.Size(86, 69)
        Me.ButonDos.TabIndex = 15
        Me.ButonDos.Text = "2"
        Me.ButonDos.UseVisualStyleBackColor = True
        '
        'BotonSiete
        '
        Me.BotonSiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSiete.Location = New System.Drawing.Point(470, 302)
        Me.BotonSiete.Name = "BotonSiete"
        Me.BotonSiete.Size = New System.Drawing.Size(86, 69)
        Me.BotonSiete.TabIndex = 16
        Me.BotonSiete.Text = "7"
        Me.BotonSiete.UseVisualStyleBackColor = True
        '
        'BotonCuatro
        '
        Me.BotonCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCuatro.Location = New System.Drawing.Point(470, 377)
        Me.BotonCuatro.Name = "BotonCuatro"
        Me.BotonCuatro.Size = New System.Drawing.Size(86, 69)
        Me.BotonCuatro.TabIndex = 17
        Me.BotonCuatro.Text = "4"
        Me.BotonCuatro.UseVisualStyleBackColor = True
        '
        'BotonSeis
        '
        Me.BotonSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSeis.Location = New System.Drawing.Point(680, 377)
        Me.BotonSeis.Name = "BotonSeis"
        Me.BotonSeis.Size = New System.Drawing.Size(86, 69)
        Me.BotonSeis.TabIndex = 18
        Me.BotonSeis.Text = "6"
        Me.BotonSeis.UseVisualStyleBackColor = True
        '
        'BotonNueve
        '
        Me.BotonNueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonNueve.Location = New System.Drawing.Point(680, 302)
        Me.BotonNueve.Name = "BotonNueve"
        Me.BotonNueve.Size = New System.Drawing.Size(86, 69)
        Me.BotonNueve.TabIndex = 19
        Me.BotonNueve.Text = "9"
        Me.BotonNueve.UseVisualStyleBackColor = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorrar.Location = New System.Drawing.Point(680, 527)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(86, 69)
        Me.BotonBorrar.TabIndex = 20
        Me.BotonBorrar.Text = "Borrar"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'botonpunto
        '
        Me.botonpunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonpunto.Location = New System.Drawing.Point(470, 527)
        Me.botonpunto.Name = "botonpunto"
        Me.botonpunto.Size = New System.Drawing.Size(86, 69)
        Me.botonpunto.TabIndex = 21
        Me.botonpunto.Text = "Punto"
        Me.botonpunto.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(410, 62)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(410, 146)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(807, 620)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.botonpunto)
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.BotonNueve)
        Me.Controls.Add(Me.BotonSeis)
        Me.Controls.Add(Me.BotonCuatro)
        Me.Controls.Add(Me.BotonSiete)
        Me.Controls.Add(Me.ButonDos)
        Me.Controls.Add(Me.BotonCinco)
        Me.Controls.Add(Me.BotonOcho)
        Me.Controls.Add(Me.ButonTres)
        Me.Controls.Add(Me.BotonUno)
        Me.Controls.Add(Me.BotonCero)
        Me.Controls.Add(Me.BotonDivision)
        Me.Controls.Add(Me.BotonMultiplicacion)
        Me.Controls.Add(Me.BotonResta)
        Me.Controls.Add(Me.BotonMas)
        Me.Controls.Add(Me.TXTBXNumero2)
        Me.Controls.Add(Me.TXTBXNumero1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTBXNumero1 As TextBox
    Friend WithEvents TXTBXNumero2 As TextBox
    Friend WithEvents BotonMas As Button
    Friend WithEvents BotonResta As Button
    Friend WithEvents BotonMultiplicacion As Button
    Friend WithEvents BotonDivision As Button
    Friend WithEvents BotonCero As Button
    Friend WithEvents BotonUno As Button
    Friend WithEvents ButonTres As Button
    Friend WithEvents BotonOcho As Button
    Friend WithEvents BotonCinco As Button
    Friend WithEvents ButonDos As Button
    Friend WithEvents BotonSiete As Button
    Friend WithEvents BotonCuatro As Button
    Friend WithEvents BotonSeis As Button
    Friend WithEvents BotonNueve As Button
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents botonpunto As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
