using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyWorkoutDiary
{
    public partial class MainForm : Form
    {
        // Класс тренировки
        public class Workout
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Exercise { get; set; }
            public int Sets { get; set; }
            public int Reps { get; set; }
            public decimal Weight { get; set; }
            public string Notes { get; set; }
        }

        private List<Workout> workouts = new List<Workout>();
        private string filePath = "workouts.txt";

        public MainForm()
        {
            InitializeComponent();

            // Добавляем обработчики
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;
            btnFilterExercise.Click += btnFilterExercise_Click;
            btnFilterDate.Click += btnFilterDate_Click;
            btnSort.Click += btnSort_Click;
            btnShowAll.Click += btnShowAll_Click;
            dataGridViewWorkouts.CellClick += dataGridViewWorkouts_CellClick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные при запуске
            LoadData();
        }

        // Загрузить данные
        private void LoadData()
        {
            // Если есть файл - читаем
            if (File.Exists(filePath))
            {
                workouts.Clear();
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        try
                        {
                            var parts = line.Split('|');
                            workouts.Add(new Workout
                            {
                                Id = int.Parse(parts[0]),
                                Date = DateTime.Parse(parts[1]),
                                Exercise = parts[2],
                                Sets = int.Parse(parts[3]),
                                Reps = int.Parse(parts[4]),
                                Weight = decimal.Parse(parts[5]),
                                Notes = parts[6]
                            });
                        }
                        catch { }
                    }
                }
            }
            else
            {
                // Если файла нет - создаем примерные данные
                workouts.Add(new Workout { Id = 1, Date = DateTime.Today, Exercise = "Жим лежа", Sets = 3, Reps = 10, Weight = 50, Notes = "Хорошо" });
                workouts.Add(new Workout { Id = 2, Date = DateTime.Today.AddDays(-1), Exercise = "Приседания", Sets = 4, Reps = 8, Weight = 70, Notes = "Тяжело" });
            }

            // Показываем в таблице
            dataGridViewWorkouts.DataSource = null;
            dataGridViewWorkouts.DataSource = workouts;

            // Настраиваем колонки
            if (dataGridViewWorkouts.Columns.Count > 0)
            {
                dataGridViewWorkouts.Columns["Id"].Visible = false;
                dataGridViewWorkouts.Columns["Date"].HeaderText = "Дата";
                dataGridViewWorkouts.Columns["Exercise"].HeaderText = "Упражнение";
                dataGridViewWorkouts.Columns["Sets"].HeaderText = "Подходы";
                dataGridViewWorkouts.Columns["Reps"].HeaderText = "Повторения";
                dataGridViewWorkouts.Columns["Weight"].HeaderText = "Вес (кг)";
                dataGridViewWorkouts.Columns["Notes"].HeaderText = "Заметки";
            }
        }

        // Сохранить данные в файл
        private void SaveData()
        {
            var lines = workouts.Select(w =>
                $"{w.Id}|{w.Date:yyyy-MM-dd}|{w.Exercise}|{w.Sets}|{w.Reps}|{w.Weight}|{w.Notes}");
            File.WriteAllLines(filePath, lines);
        }

        // кнопка"ДОБАВИТЬ"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbExercise.Text))
            {
                MessageBox.Show("Выберите упражнение!");
                return;
            }

            var workout = new Workout
            {
                Id = workouts.Count > 0 ? workouts.Max(w => w.Id) + 1 : 1,
                Date = datePicker.Value,
                Exercise = cmbExercise.Text.Replace("- ", ""), 
                Sets = (int)numSets.Value,
                Reps = (int)numReps.Value,
                Weight = numWeight.Value,
                Notes = txtNotes.Text
            };

            workouts.Add(workout);
            SaveData();
            LoadData();
            ClearFields();

            MessageBox.Show("Тренировка добавлена!");
        }

        // кнопка "ОБНОВИТЬ"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkouts.CurrentRow == null)
            {
                MessageBox.Show("Выберите тренировку для обновления!");
                return;
            }

            var selected = (Workout)dataGridViewWorkouts.CurrentRow.DataBoundItem;

            selected.Date = datePicker.Value;
            selected.Exercise = cmbExercise.Text.Replace("- ", "");
            selected.Sets = (int)numSets.Value;
            selected.Reps = (int)numReps.Value;
            selected.Weight = numWeight.Value;
            selected.Notes = txtNotes.Text;

            SaveData();
            LoadData();

            MessageBox.Show("Данные обновлены!");
        }

        // кнопка "УДАЛИТЬ"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkouts.CurrentRow == null)
            {
                MessageBox.Show("Выберите тренировку для удаления!");
                return;
            }

            var selected = (Workout)dataGridViewWorkouts.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Удалить тренировку от {selected.Date:dd.MM.yyyy}?",
                "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                workouts.Remove(selected);
                SaveData();
                LoadData();
                ClearFields();

                MessageBox.Show("Тренировка удалена!");
            }
        }

        // кнопка "ОЧИСТИТЬ"
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Ккнопка "НАЙТИ"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadData();
                return;
            }

          
            var results = workouts
                .Where(w => w.Exercise.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                           w.Notes.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            dataGridViewWorkouts.DataSource = results;
        }

        //кнопка "ФИЛЬТР ПО УПРАЖНЕНИЮ"
        private void btnFilterExercise_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbFilterExercise.Text))
            {
                LoadData();
                return;
            }

            // LINQ для фильтрации
            string exercise = cmbFilterExercise.Text.Replace("- ", "");
            var results = workouts
                .Where(w => w.Exercise.Equals(exercise, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewWorkouts.DataSource = results;
        }

        // кнопка "ФИЛЬТР ПО ДАТЕ"
        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            // LINQ для фильтрации по дате
            var results = workouts
                .Where(w => w.Date >= dateFrom.Value && w.Date <= dateTo.Value)
                .ToList();

            dataGridViewWorkouts.DataSource = results;
        }

        // кнопка "СОРТИРОВАТЬ"
        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Workout> sorted;

            if (rbWeightAsc.Checked)
                sorted = workouts.OrderBy(w => w.Weight).ToList(); // LINQ
            else if (rbWeightDesc.Checked)
                sorted = workouts.OrderByDescending(w => w.Weight).ToList(); // LINQ
            else if (rbDateAsc.Checked)
                sorted = workouts.OrderBy(w => w.Date).ToList(); // LINQ
            else if (rbDateDesc.Checked)
                sorted = workouts.OrderByDescending(w => w.Date).ToList(); // LINQ
            else
            {
                MessageBox.Show("Выберите тип сортировки!");
                return;
            }

            dataGridViewWorkouts.DataSource = sorted;
        }

        // кнопка "ПОКАЗАТЬ ВСЕ"
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterExercise.SelectedIndex = -1;
            dateFrom.Value = DateTime.Today.AddDays(-7);
            dateTo.Value = DateTime.Today;
            rbWeightAsc.Checked = false;
            rbWeightDesc.Checked = false;
            rbDateAsc.Checked = false;
            rbDateDesc.Checked = false;

            LoadData();
        }

        // КЛИК ПО СТРОКЕ В ТАБЛИЦЕ
        private void dataGridViewWorkouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewWorkouts.Rows.Count)
            {
                var workout = (Workout)dataGridViewWorkouts.Rows[e.RowIndex].DataBoundItem;

                datePicker.Value = workout.Date;
                cmbExercise.Text = workout.Exercise;
                numSets.Value = workout.Sets;
                numReps.Value = workout.Reps;
                numWeight.Value = workout.Weight;
                txtNotes.Text = workout.Notes;
            }
        }

        // ОЧИСТКА ПОЛЕЙ
        private void ClearFields()
        {
            datePicker.Value = DateTime.Today;
            cmbExercise.SelectedIndex = -1;
            numSets.Value = 3;
            numReps.Value = 10;
            numWeight.Value = 20;
            txtNotes.Clear();
        }
    }
}