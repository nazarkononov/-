using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class Form1 : Form
    {
        // ������ ������
        private List<Hotel> hotels = new List<Hotel>();

        public Form1()
        {
            InitializeComponent();

            // ��������� �������� �����
            hotels.Add(new Hotel("�����", "����������", 25));
            hotels.Add(new Hotel("��� ������", "�������", 10));
            hotels.Add(new Hotel("��������", "�����������", 5));

            // ���������� ������ �� ������� ������ ����
            hotels.Sort((x, y) => x.AvailableRooms.CompareTo(y.AvailableRooms));

            // ³���������� ������ ������
            DisplayHotels();
        }

        // ����� ��� ����������� ������ ������ � ListView
        private void DisplayHotels()
        {
            hotelsListView.Items.Clear();

            foreach (var hotel in hotels)
            {
                ListViewItem item = new ListViewItem($"{hotel.Name}, {hotel.Address}, {hotel.AvailableRooms} ������ ����");
                hotelsListView.Items.Add(item);
            }
        }

        // �������� ��䳿 ��� ������ "����������� ������"
        private void bookHotelButton_Click(object sender, EventArgs e)
        {
            // ��������, �� ������� ������
            if (hotelsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("���� �����, ������� ������ ��� ����������.");
                return;
            }

            // ��������� ��������� ������
            var selectedHotel = hotels[hotelsListView.SelectedIndices[0]];

            // ��������� ������� ������ ����� ��� ����������
            int roomsToBook = (int)availableRoomsNumericUpDown.Value;

            // ��������, �� � ���� ����
            if (selectedHotel.AvailableRooms >= roomsToBook)
            {
                // ���������� ����
                selectedHotel.BookRooms(roomsToBook);
                MessageBox.Show($"������ ������������ {roomsToBook} ����� � ����� {selectedHotel.Name}!");
                // ��������� ����������� ������ ������
                DisplayHotels();
            }
            else
            {
                MessageBox.Show($"�������� ������ {selectedHotel.Name} �� �� ��������� ������ ����.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    // ����, �� ����������� ������
    public class Hotel
    {
        public string Name { get; }
        public string Address { get; }
        public int AvailableRooms { get; private set; }

        public Hotel(string name, string address, int availableRooms)
        {
            Name = name;
            Address = address;
            AvailableRooms = availableRooms;
        }

        // ����� ��� ���������� ����
        public void BookRooms(int roomsToBook)
        {
            AvailableRooms -= roomsToBook;
        }
    }
}
