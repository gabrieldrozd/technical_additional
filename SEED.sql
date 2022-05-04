INSERT INTO Contractor VALUES ('WSIZ', '1234567890', '178660000', 'wsiz@wsiz.edu.pl');
INSERT INTO Contractor VALUES ('UR', '0987654321', '179999999', 'ur@ur.edu.pl');

INSERT INTO Address(ContractorId, City, Street, BuildingNo, PostalCode, Country) 
VALUES(1, 'Rzeszów', 'Sucharskiego', '10', '35-000', 'Polska');
INSERT INTO Address(ContractorId, City, Street, BuildingNo, PostalCode, Country) 
VALUES(1, 'Kielnarowa', 'Krzywa', '9', '37-000', 'Polska');
INSERT INTO Address(ContractorId, City, Street, BuildingNo, PostalCode, Country) 
VALUES(2, 'Rzeszów', 'Rejtana', '1', '35-000', 'Polska');

INSERT INTO KindOfAddress VALUES('Główny adres', 1);
INSERT INTO KindOfAddress VALUES('Adres siedziby', 2);
INSERT INTO KindOfAddress VALUES('Adres oddziału', 3);
INSERT INTO KindOfAddress VALUES('Adres korespondencyjny', 4);

INSERT INTO KindOfAddressAddresses(Address_AddressId, KindOfAddress_KindOfAddessId)
VALUES(1, 1);
INSERT INTO KindOfAddressAddresses(Address_AddressId, KindOfAddress_KindOfAddessId)
VALUES(1, 4);
INSERT INTO KindOfAddressAddresses(Address_AddressId, KindOfAddress_KindOfAddessId)
VALUES(2, 3);
INSERT INTO KindOfAddressAddresses(Address_AddressId, KindOfAddress_KindOfAddessId)
VALUES(3, 1);


SELECT * FROM Contractor

Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contractor;Integrated Security=True;