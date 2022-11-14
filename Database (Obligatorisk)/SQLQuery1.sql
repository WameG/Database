CREATE TABLE Facility (
    Facility_No INT NOT NULL,
    Name varchar(50) NOT NULL,
    PRIMARY KEY (Facility_No),
    UNIQUE (Name)
);

INSERT INTO Facility(Facility_No, Name)
VALUES(1, 'Pool Bord')

CREATE TABLE Hotel_Facility (
    HotelFacility_No int NOT NULL,
    Facility_No INT NOT NULL,
    Hotel_No INT NOT NULL,
    PRIMARY KEY (HotelFacility_No),
    FOREIGN KEY (Facility_No) REFERENCES Facility(Facility_No),
    FOREIGN KEY (Hotel_No) REFERENCES Hotel(Hotel_No),
    CONSTRAINT UC_Hotel_Facility UNIQUE (Facility_No,Hotel_No)
);

INSERT INTO Hotel_Facility(HotelFacility_No, Facility_No, Hotel_No)
VALUES(1,1,1)


