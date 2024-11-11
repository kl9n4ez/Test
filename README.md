# Русская рулетка,
 но при каждом выстреле падает один из микросервисов.

## Содержание
- [Наша команда](#команда-microservices-adventure)
- [Tech Stack](#tech-stack)
- [Описание сервисов](#описание-сервисов)
- [Текущее состояние проекта](#текущее-состояние-проекта)
- [Запуск проекта](#запуск-проекта)

## Команда Microservices Adventure
1. Казанков Руслан - Team Lead, Fullstack
2. Спиваченко Михаил - Backend-Developer
3. Заголовец Иван - Тестировщик

## Tech Stack
- ASP NET - платформа разработки веб-приложений. ASP NET MVC для клиента. ASP NET API для бэкэнда.
- xUnit - фреймворк для тестирования.

## Описание сервисов
### **Frontend**
Frontend - ASP NET MVC веб-клиент приложения. Именно сюда попадают пользователи, когда заходят на наш сайт. Здесь весь пользовательский интерфейс и "ручки" через которые происходит обращение к бэкенду.
### **AuthorizationAPI**
AuthorizationAPI - ASP NET Web API приложение для авторизации пользователей.

## Текущее состояние проекта
- Frontend - \[Находится в разработке\] создан базовый проект ASP NET MVC. Проект приведён к FSD архитектуре, но папки Properties и wwwroot остались в корне проекта из-за особенностей ASP NET приложения.
- XUnitTestProject - создан проект для тестирования. К проекту написан workflow для CI тестирования.
- AuthorizationAPI - \[Находится в разработке\]
- Revolver - \[В планах\]
- LiveMonitor - \[В планах\]
- FallStatistics - \[В планах\]
- ActionLog - \[В планах\]

## Запуск проекта
1. Склонировать репозиторий на локальную машину.
2. Запустить проект из папки с файлом docker-compose.yml:
```
docker-compose up
```
3. Перейти по одному из адресов:
- https://localhost:8081
- http://localhost:8080

Во втором случае всё равно произойдёт перенаправление на https адрес.
