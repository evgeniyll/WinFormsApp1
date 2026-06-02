-- Прейскурант туров
CREATE TABLE preuskyrant (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    name          NVARCHAR(100)  NOT NULL,  -- Название тура
    price         DECIMAL(10,2)  NOT NULL,  -- Цена
    direction     NVARCHAR(100)  NOT NULL,  -- Направление
    date_start    DATE           NOT NULL,  -- Дата отправки
    date_end      DATE           NOT NULL,  -- Дата окончания
    orders_count  INT            DEFAULT 0  -- Количество заказов
);

-- Статистика по заказам
CREATE TABLE statistiks (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    tour_name     NVARCHAR(100)  NOT NULL,  -- Название тура
    orders_count  INT            DEFAULT 0, -- Количество заказов
    total_income  DECIMAL(10,2)  DEFAULT 0  -- Общий доход
);

-- Услуги
CREATE TABLE yslugi (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    service_name  NVARCHAR(100)  NOT NULL,  -- Название услуги
    hotel         NVARCHAR(100),            -- Отель
    transfer      NVARCHAR(100),            -- Трансфер
    insurance     NVARCHAR(100),            -- Страховка
    price         DECIMAL(10,2)  NOT NULL   -- Цена услуги
);
