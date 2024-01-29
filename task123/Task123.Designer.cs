
namespace task123
{
    partial class Task123
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameLabel = new System.Windows.Forms.Label();
            this.secondNamelabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(334, 252);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 66);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Запиши";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(122, 281);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(82, 29);
            this.classTextBox.TabIndex = 17;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(122, 252);
            this.classLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(47, 24);
            this.classLabel.TabIndex = 16;
            this.classLabel.Text = "Клас";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(122, 216);
            this.familyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(190, 29);
            this.familyNameTextBox.TabIndex = 15;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(122, 153);
            this.secondNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(190, 29);
            this.secondNameTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(122, 82);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 29);
            this.nameTextBox.TabIndex = 13;
            // 
            // familyNameLabel
            // 
            this.familyNameLabel.AutoSize = true;
            this.familyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.familyNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyNameLabel.Location = new System.Drawing.Point(122, 187);
            this.familyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyNameLabel.Name = "familyNameLabel";
            this.familyNameLabel.Size = new System.Drawing.Size(77, 24);
            this.familyNameLabel.TabIndex = 12;
            this.familyNameLabel.Text = "Фамилия";
            // 
            // secondNamelabel
            // 
            this.secondNamelabel.AutoSize = true;
            this.secondNamelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondNamelabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNamelabel.Location = new System.Drawing.Point(122, 116);
            this.secondNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondNamelabel.Name = "secondNamelabel";
            this.secondNamelabel.Size = new System.Drawing.Size(75, 24);
            this.secondNamelabel.TabIndex = 11;
            this.secondNamelabel.Text = "Презиме";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(122, 53);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 24);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Име";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthDateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(122, 315);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(150, 24);
            this.birthDateLabel.TabIndex = 22;
            this.birthDateLabel.Text = "Дата на раждане";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Task123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(591, 392);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.familyNameLabel);
            this.Controls.Add(this.secondNamelabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task123";
            this.Text = "Task123";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label familyNameLabel;
        private System.Windows.Forms.Label secondNamelabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

