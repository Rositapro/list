namespace list
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
            lstvData = new ListView();
            btnOpen = new Button();
            txtFilter = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnSearchTime = new Button();
            SuspendLayout();
            // 
            // lstvData
            // 
            lstvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvData.Location = new Point(12, 115);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(776, 292);
            lstvData.TabIndex = 0;
            lstvData.UseCompatibleStateImageBehavior = false;
            lstvData.View = View.Details;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 28);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(87, 27);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(230, 72);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(123, 23);
            txtFilter.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresa el nombre de tu arista";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(370, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(230, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(449, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // btnSearchTime
            // 
            btnSearchTime.Location = new Point(671, 28);
            btnSearchTime.Name = "btnSearchTime";
            btnSearchTime.Size = new Size(75, 23);
            btnSearchTime.TabIndex = 7;
            btnSearchTime.Text = "Search";
            btnSearchTime.UseVisualStyleBackColor = true;
            btnSearchTime.Click += btnSearchTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchTime);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(btnOpen);
            Controls.Add(lstvData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvData;
        private Button btnOpen;
        private TextBox txtFilter;
        private Label label1;
        private Button button1;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnSearchTime;
    }
}
