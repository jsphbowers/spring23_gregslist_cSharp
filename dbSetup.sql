CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE IF NOT EXISTS cars(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  make VARCHAR(255) NOT NULL,
  model VARCHAR(255) NOT NULL,
  price MEDIUMINT NOT NULL,
  year SMALLINT NOT NULL DEFAULT 1990,
  hasTires BOOLEAN NOT NULL DEFAULT true,
  createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  color VARCHAR(8) DEFAULT '#FFFFFF'
) default charset utf8mb4 COMMENT 'emojis enabled 🦞';


INSERT INTO cars(make, model, price, year, hasTires, color)
values('mazda', 'miata', 5000, 2005, true, DEFAULT) ;

INSERT INTO cars(make, model, price, year, hasTires)
values
('mazda', 'miata', 5000, 2005, true), 
('subaru', 'impreza', 13000, 2013, true);

SELECT * FROM cars ORDER BY price DESC LIMIT 1;

SELECT * FROM cars WHERE make = 'mazda' AND model = 'miata';

SELECT * FROM cars WHERE id = 4;

UPDATE cars
SET 
model = 'rx-7', 
color = '#000000' 
WHERE id = 4;

DELETE FROM cars WHERE id = 1 ;

DROP TABLE cars;