# Редактор геометрических фигур

Простой редактор для создания и настройки геометрических фигур.

## Технические детали 🔧

1. Архитектура: MVVM (Model-View-ViewModel)
2. Основные технологии:
  - Avalonia UI
  - CommunityToolkit.Mvvm
3. Конвертеры:
  - CenterConverter - вычисление центра для трансформаций
  - ColorToBrushConverter - преобразование Color в Brush

## Почему **AvaloniaUI**? ![](https://img.shields.io/badge/Avalonia-UI-blue)
  Avalonia UI — это кроссплатформенный фреймворк для создания нативных десктопных и мобильных приложений с использованием .NET и XAML.
1. Кроссплатформеность 📱
   - Можно разрабатывать приложения под разные ОС, используя единую кодовую базу
2. Производительность ⚡
   - Собственный рендер без лишних накладных расходов
3. Гибкость и расширяемость 🎨
   - Кастомизация стилей через Control Templates и Styles
4. Совместимость с .NET 🔌
   -  Работает с .NET 6, 7, 8 и .NET Standard 2.0

## Зачем CommunityToolkit.Mvvm? ![](https://img.shields.io/badge/Pattern-MVVM-green)
  CommunityToolkit.Mvvm (ранее Microsoft.Toolkit.Mvvm) — это библиотека для .NET, которая упрощает реализацию паттерна MVVM и предоставляет готовые компоненты, которые сокращают объем шаблонного кодав приложениях WPF, UWP, MAUI, Avalonia и других XAML-платформах.  

## Установка
1. Необходимы перед установкой:
  - [.NET 6.0 SDK](https://dotnet.microsoft.com/ru-ru/download)
  - любая IDE (Visual Studio 2022/Rider/VS Code)
2. Клонируйте репозиторий:
```
git clone https://github.com/TOTOMCG/Shape-Editor.git
cd Task№1/ShapeEditor
```
3. Запуск:
```
dotnet run
```
