namespace ES.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addperson = new Button();
            personsWeights = new Label();
            noOfPersons = new Label();
            overAllWeights = new Label();
            SuspendLayout();
            // 
            // addperson
            // 
            addperson.Location = new Point(175, 94);
            addperson.Name = "addperson";
            addperson.Size = new Size(94, 29);
            addperson.TabIndex = 0;
            addperson.Text = "AddPerson";
            addperson.UseVisualStyleBackColor = true;
            addperson.Click += addperson_Click;
            // 
            // personsWeights
            // 
            personsWeights.AccessibleName = "personsWeights";
            personsWeights.AutoSize = true;
            personsWeights.Location = new Point(493, 98);
            personsWeights.Name = "personsWeights";
            personsWeights.Size = new Size(0, 20);
            personsWeights.TabIndex = 2;
            // 
            // noOfPersons
            // 
            noOfPersons.AutoSize = true;
            noOfPersons.Location = new Point(409, 98);
            noOfPersons.Name = "noOfPersons";
            noOfPersons.Size = new Size(17, 20);
            noOfPersons.TabIndex = 1;
            noOfPersons.Text = "0";
            // 
            // overAllWeights
            // 
            overAllWeights.AutoSize = true;
            overAllWeights.Location = new Point(362, 174);
            overAllWeights.Name = "overAllWeights";
            overAllWeights.Size = new Size(17, 20);
            overAllWeights.TabIndex = 3;
            overAllWeights.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(overAllWeights);
            Controls.Add(personsWeights);
            Controls.Add(noOfPersons);
            Controls.Add(addperson);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addperson;
        private Label personsWeights;
        private Label noOfPersons;
        private Label overAllWeights;
    }
}