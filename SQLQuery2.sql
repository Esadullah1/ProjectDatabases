USE [2122_INF1b_db5]

ALTER TABLE Teachers

ADD FOREIGN KEY (NameOfDrink) REFERENCES Drinks(NameOfDrink);



