namespace HotelBookingSystem
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
            hotelNameTextBox = new TextBox();
            hotelAddressTextBox = new TextBox();
            availableRoomsNumericUpDown = new NumericUpDown();
            bookHotelButton = new Button();
            hotelsListView = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)availableRoomsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // hotelNameTextBox
            // 
            hotelNameTextBox.Location = new Point(51, 63);
            hotelNameTextBox.Name = "hotelNameTextBox";
            hotelNameTextBox.Size = new Size(297, 27);
            hotelNameTextBox.TabIndex = 0;
            // 
            // hotelAddressTextBox
            // 
            hotelAddressTextBox.Location = new Point(51, 132);
            hotelAddressTextBox.Name = "hotelAddressTextBox";
            hotelAddressTextBox.Size = new Size(297, 27);
            hotelAddressTextBox.TabIndex = 1;
            // 
            // availableRoomsNumericUpDown
            // 
            availableRoomsNumericUpDown.Location = new Point(573, 63);
            availableRoomsNumericUpDown.Name = "availableRoomsNumericUpDown";
            availableRoomsNumericUpDown.Size = new Size(308, 27);
            availableRoomsNumericUpDown.TabIndex = 2;
            // 
            // bookHotelButton
            // 
            bookHotelButton.BackColor = SystemColors.HotTrack;
            bookHotelButton.ForeColor = Color.FloralWhite;
            bookHotelButton.Location = new Point(51, 222);
            bookHotelButton.Name = "bookHotelButton";
            bookHotelButton.Size = new Size(168, 128);
            bookHotelButton.TabIndex = 3;
            bookHotelButton.Text = "Забронювати";
            bookHotelButton.UseVisualStyleBackColor = false;
            bookHotelButton.Click += bookHotelButton_Click;
            // 
            // hotelsListView
            // 
            hotelsListView.Location = new Point(477, 151);
            hotelsListView.Name = "hotelsListView";
            hotelsListView.Size = new Size(490, 211);
            hotelsListView.TabIndex = 4;
            hotelsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Назва готелю";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Адреса";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 40);
            label3.Name = "label3";
            label3.Size = new Size(235, 20);
            label3.TabIndex = 5;
            label3.Text = "Кількість місць для бронювання";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 128);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 5;
            label4.Text = "Доступні готелі";
            label4.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hotelsListView);
            Controls.Add(bookHotelButton);
            Controls.Add(availableRoomsNumericUpDown);
            Controls.Add(hotelAddressTextBox);
            Controls.Add(hotelNameTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)availableRoomsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hotelNameTextBox;
        private TextBox hotelAddressTextBox;
        private NumericUpDown availableRoomsNumericUpDown;
        private Button bookHotelButton;
        private ListView hotelsListView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
