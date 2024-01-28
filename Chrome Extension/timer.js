document.addEventListener('DOMContentLoaded', function() {    // Ожидание загрузки DOM перед выполнением скрипта
  let timer;                                                  // Объявление переменных для таймера
  let totalSeconds;                                           // Объявление переменных для общего количества секунд

  const display = document.querySelector('h1');               // Получение ссылок на элементы DOM
  const startBtn = document.getElementById('start-btn');
  const stopBtn = document.getElementById('stop-btn');
  const minutesInput = document.getElementById('minutes-input');
  const secondsInput = document.getElementById('seconds-input');

  function startTimer() {                                                            // Функция запуска таймера
    totalSeconds = parseInt(minutesInput.value) * 60 + parseInt(secondsInput.value); // Вычисление общего количества секунд на основе введенных пользователем значений

    if (isNaN(totalSeconds) || totalSeconds <= 0) {          // Проверка на корректность введенных данных
      alert('Пожалуйста, введите корректное время.');
      return;
    }

    timer = setInterval(() => {         // Установка интервала для обновления времени каждую секунду
      if (totalSeconds > 0) {
        totalSeconds--;
        displayTime();                  // Обновление отображаемого времени
      } else {
        stopTimer();                    // Остановка таймера и вывод сообщения, когда время вышло
        alert('Время вышло!');
      }
    }, 1000);

    startBtn.disabled = true;           // Деактивация кнопки "Старт"
    stopBtn.disabled = false;           // Активация кнопки "Стоп"
    minutesInput.disabled = true;       // Блокировка полей ввода времени
    secondsInput.disabled = true;
  }

  function stopTimer() {                // Функция остановки таймера      
    clearInterval(timer);               // Очистка интервала и восстановление кнопок
    startBtn.disabled = false;
    stopBtn.disabled = true;
    minutesInput.disabled = false;
    secondsInput.disabled = false;
  }

  function displayTime() {                            // Функция отображения времени в формате "мм:сс"
    const minutes = Math.floor(totalSeconds / 60);
    const remainingSeconds = totalSeconds % 60;

    const formattedTime = `${String(minutes).padStart(2, '0')}:${String(remainingSeconds).padStart(2, '0')}`; // Форматирование времени и обновление содержимого h1
    display.textContent = formattedTime;
  }

  startBtn.addEventListener('click', startTimer);     // Привязка обработчиков событий к кнопкам "Старт" и "Стоп"
  stopBtn.addEventListener('click', stopTimer);
})