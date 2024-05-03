using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class Form1 : Form
    {
        // Список готелів
        private List<Hotel> hotels = new List<Hotel>();

        public Form1()
        {
            InitializeComponent();

            // Додавання тестових даних
            hotels.Add(new Hotel("Софія", "Агрономічне", 25));
            hotels.Add(new Hotel("Пан Отаман", "Бохонки", 10));
            hotels.Add(new Hotel("Панорама", "Стрижавська", 5));

            // Сортування готелів за кількістю вільних місць
            hotels.Sort((x, y) => x.AvailableRooms.CompareTo(y.AvailableRooms));

            // Відображення списку готелів
            DisplayHotels();
        }

        // Метод для відображення списку готелів в ListView
        private void DisplayHotels()
        {
            hotelsListView.Items.Clear();

            foreach (var hotel in hotels)
            {
                ListViewItem item = new ListViewItem($"{hotel.Name}, {hotel.Address}, {hotel.AvailableRooms} вільних місць");
                hotelsListView.Items.Add(item);
            }
        }

        // Обробник події для кнопки "Забронювати готель"
        private void bookHotelButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано готель
            if (hotelsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть готель для бронювання.");
                return;
            }

            // Отримання вибраного готелю
            var selectedHotel = hotels[hotelsListView.SelectedIndices[0]];

            // Отримання кількості вільних кімнат для бронювання
            int roomsToBook = (int)availableRoomsNumericUpDown.Value;

            // Перевірка, чи є вільні місця
            if (selectedHotel.AvailableRooms >= roomsToBook)
            {
                // Бронювання місць
                selectedHotel.BookRooms(roomsToBook);
                MessageBox.Show($"Успішно заброньовано {roomsToBook} кімнат в готелі {selectedHotel.Name}!");
                // Оновлення відображення списку готелів
                DisplayHotels();
            }
            else
            {
                MessageBox.Show($"Вибраний готель {selectedHotel.Name} не має достатньо вільних місць.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    // Клас, що представляє готель
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

        // Метод для бронювання місця
        public void BookRooms(int roomsToBook)
        {
            AvailableRooms -= roomsToBook;
        }
    }
}
