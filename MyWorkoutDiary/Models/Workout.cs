using System;

namespace MyWorkoutDiary.Models
{
    public class Workout
    {
        // Поля тренировки
        public int Id { get; set; }
        public DateTime Date { get; set; }          // Дата
        public string Exercise { get; set; }        // Упражнение
        public int Sets { get; set; }               // Подходы
        public int Reps { get; set; }               // Повторения
        public decimal Weight { get; set; }         // Вес
        public string Notes { get; set; }          // Заметки

        // Конструктор
        public Workout()
        {
            Date = DateTime.Today; // По умолчанию сегодня
        }

        // Для сохранения в файл 
        public string ToFileString()
        {
            return $"{Id}|{Date:yyyy-MM-dd}|{Exercise}|{Sets}|{Reps}|{Weight}|{Notes}";
        }

        // Для загрузки из файла
        public static Workout FromFileString(string line)
        {
            var parts = line.Split('|');
            return new Workout
            {
                Id = int.Parse(parts[0]),
                Date = DateTime.Parse(parts[1]),
                Exercise = parts[2],
                Sets = int.Parse(parts[3]),
                Reps = int.Parse(parts[4]),
                Weight = decimal.Parse(parts[5]),
                Notes = parts[6]
            };
        }
    }
}