# Русская рулетка,
 но при каждом выстреле падает один из микросервисов.

## Содержание
- [Наша команда](#команда-microservices-adventure)
- [Tech Stack](#tech-stack)
- [Описание сервисов](#описание-сервисов)
- [Текущее состояние сервисов](#текущее-состояние-сервисов)
- [Настройка проекта](#настройка-проекта)

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

## Настройка проекта
### Для окружения разработки

1. В корневую папку проекта AuthorizationAPI добавьте файл appsettings.secrets.json (уже включён в .gitignore):
```
{
  "JwtSettings": {
    "SecretKey": "your_secret_key_here"
  },
  "ConnectionStrings": {
    "DefaultConnection": "YourConnectionStringHere"
  }
}
```
Используйте свои значения. 
Для JwtSettings:SecretKey ключ должен быть длиной не менее 256 бит или 32 байта. 
Ключ можно сгенерировать [здесь](https://save-editor.com/crypto/crypt_key_generator.html).

### Для окружения продакшена

1. Запуск происходит в Docker со следующим окружением:
```
  environment:
    - ASPNETCORE_ENVIRONMENT=Production
    - JWT_SECRET_KEY=${JWT_SECRET_KEY}
```
При запуске следует указать JWT_SECRET_KEY следующим образом:
```
JWT_SECRET_KEY=your_secret_key docker-compose up
```
Ключ должен быть длиной не менее 256 бит или 32 байта.
Ключ можно сгенерировать [здесь](https://save-editor.com/crypto/crypt_key_generator.html).

