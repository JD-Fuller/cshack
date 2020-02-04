/*Notifies us what we are using - safety check*/
USE burgerShack9;

-- DROP TABLE burgers


/* ---Startup Commands --*/
-- CREATE TABLE burgers (
--   id int NOT NULL AUTO_INCREMENT , 
--   name VARCHAR(255) NOT NULL, 
--   description VARCHAR(255),
--   PRIMARY KEY (id)
-- );


-- ALTER TABLE burgers
-- ADD price DECIMAL DEFAULT=10;

-- NOTE Edit
UPDATE burgers
SET name = "The Mountain Plus", price = 15.00
WHERE id = 1;



/* NOTE Add to table */

-- INSERT INTO burgers (name, description) VALUES ("The Mountain", "Lannister for Life.");
-- INSERT INTO burgers (name, description) VALUES ("Jon Snow", "R + L = J");



-- --NOTE GetAll
-- SELECT * FROM burgers;

-- --NOTE GetById
-- SELECT * FROM burgers, WHERE id = 2;




/* -----DANGER ZONE -------*/
-- DELETE FROM burgers -- DELETES ALL DATA
-- DROP TABLE burgers --- DELETES TABLE burgers
-- DROP DATABASE --- DELETES WHOLE TABLE