using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Преобразуем значения из текстовых полей
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);

            // Проверяем диапазоны
            if (fromX > toX)
            {
                MessageBox.Show("Начальное значение X должно быть меньше конечного.", "Ошибка");
                return;
            }

            if (fromY > toY)
            {
                MessageBox.Show("Начальное значение Y должно быть меньше конечного.", "Ошибка");
                return;
            }

            // Очищаем список результатов
            lstResult.Items.Clear();

            // Вычисляем значения функции z(x, y) = x - y
            for (int x = fromX; x <= toX; x++)
            {
                for (int y = fromY; y <= toY; y++)
                {
                    lstResult.Items.Add($"z({x}, {y}) = {x - y}");
                }
            }
        }


    }
}
