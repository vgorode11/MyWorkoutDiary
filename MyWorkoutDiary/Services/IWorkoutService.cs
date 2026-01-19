using System;
using System.Collections.Generic;
using MyWorkoutDiary.Models;

namespace MyWorkoutDiary.Services
{
    public interface IWorkoutService
    {
        // Основные операции
        List<Workout> GetAllWorkouts();
        void AddWorkout(Workout workout);
        void UpdateWorkout(Workout workout);
        void DeleteWorkout(int id);

        // Поиск и фильтрация
        List<Workout> SearchWorkouts(string keyword);
        List<Workout> FilterByExercise(string exercise);
        List<Workout> FilterByDate(DateTime from, DateTime to);

        // Сортировка
        List<Workout> SortByWeight(bool ascending);
        List<Workout> SortByDate(bool ascending);

        // Получить новый ID
        int GetNextId();
    }
}