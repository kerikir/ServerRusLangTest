# 🎓 Тест на знание русского языка

[![Frontend Repository](https://img.shields.io/badge/Frontend-GitHub-blue?logo=github)](https://github.com/kerikir/rus-lang-test-react/tree/master)
[![Frontend Docker](https://img.shields.io/badge/Frontend-Docker_Hub-2496ED?logo=docker)](https://hub.docker.com/r/kerikir/react-sixth-lab-frontend)
[![Backend Docker](https://img.shields.io/badge/Backend-Docker_Hub-2496ED?logo=docker)](https://hub.docker.com/r/kerikir/react-sixth-lab-backend)

Проект представляет собой интерактивный тест по русскому языку с современным веб-интерфейсом и REST API.

## 🌟 Особенности
- **Интуитивный интерфейс** с пошаговым прохождением теста
- **Автоматическая проверка** ответов
- **Детальные результаты** после завершения
- **Полностью контейнеризированное** решение (Docker)

## 🛠 Технологический стек
### Frontend
![React](https://img.shields.io/badge/React-18.2.0-blue?logo=react)
![Axios](https://img.shields.io/badge/Axios-1.3.4-purple)
- Функциональные компоненты с Hooks
- Адаптивный дизайн

### Backend
![ASP.NET](https://img.shields.io/badge/ASP.NET-6.0-blueviolet?logo=.net)
![Entity Framework](https://img.shields.io/badge/EF_Core-7.0-green)
- REST API
- Swagger для документации
- CORS для кросс-доменных запросов

### База данных
![SQL Server](https://img.shields.io/badge/SQL_Server-2019-cc2927?logo=microsoft-sql-server)

### Инфраструктура
![Docker](https://img.shields.io/badge/Docker-20.10-blue?logo=docker)

## 📸 Скриншоты

### Стартовый экран
<img src="https://github.com/user-attachments/assets/b59126e6-cc73-41fe-bfc8-048db6354a4a" width="600" alt="Стартовый экран">

### Вопрос теста
<img src="https://github.com/user-attachments/assets/65b0a4c2-1697-46cf-a9d9-8045e1bf1623" width="600" alt="Вопрос теста">

### Результаты
<img src="https://github.com/user-attachments/assets/d4bddaf3-bc5b-406f-9911-e6cf901a0ec8" width="600" alt="Результаты теста">

### Документация API (Swagger)
<img src="https://github.com/user-attachments/assets/c9163121-e61f-4127-8f81-97136bf6b33c" width="600" alt="Swagger UI">

### Docker
<img src="https://github.com/user-attachments/assets/7939804f-8398-434b-a8db-31f2a879c09d" width="600" alt="Docker контейнер">

## 🚀 Запуск проекта

### Вариант 1: Через Docker Hub
```bash
docker pull kerikir/react-sixth-lab-frontend
docker pull kerikir/react-sixth-lab-backend
docker-compose up
