using System;
using System.Collections.Generic;
using System.IO;  
using System.Linq;
using MyWorkoutDiary.Models;

namespace MyWorkoutDiary.Services
{
 
    public class WorkoutService : IWorkoutService
    {
        private string filePath;

        public WorkoutService(string path)
        {
            filePath = path;
            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "");
        }

        // Получить все тренировки
        public List<Workout> GetAllWorkouts()
        {
            var list = new List<Workout>();

            if (!File.Exists(filePath))
                return list;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var workout = Workout.FromFileString(line);
                    if (workout != null)
                        list.Add(workout);
                }
            }

            return list;
        }

        // Добавить тренировку
        public void AddWorkout(Workout workout)
        {
            workout.Id = GetNextId();
            File.AppendAllText(filePath, workout.ToFileString() + Environment.NewLine);
        }

        // Обновить тренировку
        public void UpdateWorkout(Workout updatedWorkout)
        {
            var workouts = GetAllWorkouts();

            for (int i = 0; i < workouts.Count; i++)
            {
                if (workouts[i].Id == updatedWorkout.Id)
                {
                    workouts[i] = updatedWorkout;
                    break;
                }
            }

            SaveAll(workouts);
        }

        // Удалить тренировку
        public void DeleteWorkout(int id)
        {
            var workouts = GetAllWorkouts();
            workouts.RemoveAll(w => w.Id == id);
            SaveAll(workouts);
        }

        // Поиск
        public List<Workout> SearchWorkouts(string keyword)
        {
            var workouts = GetAllWorkouts();
            return workouts
                .Where(w => w.Exercise.ToLower().Contains(keyword.ToLower()) ||
                           w.Notes.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }

        // Фильтр по упражнению
        public List<Workout> FilterByExercise(string exercise)
        {
            var workouts = GetAllWorkouts();
            return workouts
                .Where(w => w.Exercise.Equals(exercise, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Фильтр по дате
        public List<Workout> FilterByDate(DateTime from, DateTime to)
        {
            var workouts = GetAllWorkouts();
            return workouts
                .Where(w => w.Date >= from && w.Date <= to)
                .ToList();
        }

        // Сортировка по весу
        public List<Workout> SortByWeight(bool ascending)
        {
            var workouts = GetAllWorkouts();
            return ascending
                ? workouts.OrderBy(w => w.Weight).ToList()
                : workouts.OrderByDescending(w => w.Weight).ToList();
        }

        // Сортировка по дате
        public List<Workout> SortByDate(bool ascending)
        {
            var workouts = GetAllWorkouts();
            return ascending
                ? workouts.OrderBy(w => w.Date).ToList()
                : workouts.OrderByDescending(w => w.Date).ToList();
        }

        // Новый ID
        public int GetNextId()
        {
            var workouts = GetAllWorkouts();
            if (workouts.Count == 0)
                return 1;

            return workouts.Max(w => w.Id) + 1;
        }

        // Сохранить все
        private void SaveAll(List<Workout> workouts)
        {
            var lines = workouts.Select(w => w.ToFileString()).ToArray();
            File.WriteAllLines(filePath, lines);
        }
    }
}