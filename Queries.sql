USE Kursovaya_Polina
GO


/* 10 ������� �������� */


/*1*/
/*������� ���������� ���������� ����� � ������������� �� ����*/

--DECLARE @idDoctor int = 3

--SELECT IdAppointment, DateTime AS [Date and time], FIO AS [Patient], PhoneNumber AS [Phone number] FROM Appointments
--	JOIN Patients ON Appointments.IdPatient = Patients.IdPatient
--		WHERE IdDoctor = @idDoctor
--UNION
--	SELECT IdAppointment, DateTime, '-', '-' FROM Appointments
--		LEFT JOIN Patients ON Appointments.IdPatient = Patients.IdPatient
--			WHERE IdDoctor = @idDoctor AND FIO IS NULL
--ORDER BY DateTime


/*2*/
/*������� ������ �������� � ��������� ������ �������*/

--DECLARE @dosageForm int = 2

--SELECT Medicaments.Name AS Name, DosageForms.Name AS DosageForm, Price, Quantity, Suppliers.Name AS Supplier FROM Medicaments
--	JOIN Suppliers ON Medicaments.IdSupplier = Suppliers.IdSupplier
--		JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm
--			WHERE DosageForm = @dosageForm


/*3*/
/*������� ��� ��������, ������� ������� � ���������� ����� �� ��������� �����*/

--DECLARE @dateTime datetime = '2021-10-17T18:00:00', @idDoctor int = 2

--SELECT FIO FROM Patients
--	JOIN Appointments ON Patients.IdPatient = Appointments.IdPatient
--		WHERE DateTime =  @dateTime AND IdDoctor = @idDoctor


/*4*/
/*������� ���������� �������, �� ������� ���������� �������� ��� ���� ������*/

--SELECT FIO, COUNT(IdPatient) FROM Doctors
--	JOIN Appointments ON Doctors.IdDoctor = Appointments.IdDoctor
--		GROUP BY FIO


/*5*/
/*������� ������ ���� ������, � ������� ��� ������� � ��������� ����*/

--DECLARE @dateTime date = '2021-10-22'

--SELECT FIO FROM Doctors
--EXCEPT
--SELECT FIO FROM Doctors 
--	JOIN Appointments ON Doctors.IdDoctor = Appointments.IdDoctor
--		WHERE CONVERT(DATE, DateTime) =  @dateTime


/*6*/
/*������� ������ ���� ���������, � ������� ����� ���� ������� ������������*/

--SELECT FIO FROM Patients
--	JOIN Orders ON Patients.IdPatient = Orders.IdPatient
--		GROUP BY FIO
--			HAVING COUNT(Orders.IdPatient) > 2


/*7*/
/*������� ������ ���� ������, � ������� ���� ������ � ��������� ����*/

--DECLARE @dateTime date = '2021-11-14'

--SELECT FIO FROM Doctors
--	WHERE EXISTS (SELECT * FROM Appointments WHERE CONVERT(DATE, DateTime) =  @dateTime AND Appointments.IdDoctor = Doctors.IdDoctor)


/*8*/
/*��� ������ �� ��������� ������������� � ������� �������� ����*/

--DECLARE @specialization int = 2

--SELECT DISTINCT Name, Price FROM Services
--	JOIN ServicesDoctors ON Services.IdService = ServicesDoctors.IdService
--		JOIN Doctors ON ServicesDoctors.IdDoctor = Doctors.IdDoctor
--			WHERE IdSpecialization = @specialization
--				ORDER BY Price DESC


/*9*/
/*������� �������� � ���� ������ �������� ���������*/

--SELECT Medicaments.Name, DosageForms.Name, Price FROM Medicaments
--	JOIN DosageForms ON Medicaments.DosageForm = DosageForms.IdForm
--		WHERE Price = (SELECT MAX(Price) FROM Medicaments)


/*10*/
/*������� ���������, ������� �� ���� �� ���������� ��������� � �� ���� �� �� ����� ������*/

--SELECT FIO FROM Patients
--	WHERE NOT EXISTS (SELECT IdPatient FROM Orders WHERE Orders.IdPatient = Patients.IdPatient
--					  UNION
--					  SELECT IdPatient FROM Appointments WHERE Appointments.IdPatient = Patients.IdPatient)



/* �������� ��������� � �������� */


/*1*/
/*������� ��� ����� ������� ������������*/

--CREATE PROCEDURE dosage_forms
--AS
--SELECT Name FROM DosageForms;
--GO

--EXEC dosage_forms


/*2*/
/*������� ���� ������ � ��������� ��������������*/

--CREATE PROCEDURE foi_of_doctor @specialization AS INT
--AS
--SELECT FIO FROM Doctors WHERE IdSpecialization = (SELECT IdSpecialization FROM Specializations WHERE IdSpecialization = @specialization)
--GO

--DECLARE @idSpecialization int = 1;
--EXEC foi_of_doctor @idSpecialization;


/*3*/
/*������� ������ ������������ ���������� ��������*/

--CREATE PROCEDURE get_orders @patient AS INT
--AS
--SELECT Date, TotalPrice FROM Orders WHERE IdPatient = @patient
--GO

--DECLARE @idPatient int = 5;
--EXEC get_orders @idPatient;


/*4*/
/*������� � ������� Orders ����� �����*/

--CREATE PROCEDURE insert_into_orders (@date_ AS DATE, @id_patient AS INT, @total_price AS INT)
--AS
--INSERT INTO Orders (Date, IdPatient, TotalPrice) VALUES (@date_, @id_patient, @total_price);
--GO

--DECLARE @date date = '2022-02-11', @idPatient int = 5, @totalPrice int = 500;
--EXEC insert_into_orders @date, @idPatient, @totalPrice;


/*�������*/

--CREATE TRIGGER orders_insert_trigger
--ON Orders
--AFTER INSERT
--AS
--UPDATE Orders SET TotalPrice = TotalPrice + TotalPrice * 0.2
--	WHERE IdOrder = (SELECT IdOrder FROM INSERTED)

SELECT CONVERT(DATE, DateTime) AS Date, FIO, Specializations.Name AS Specialization, Services.Name AS Service, Diagnoses.Name AS Diagnose, Complaints, Recommendations FROM Appointments
	JOIN Doctors ON Appointments.IdDoctor = Doctors.IdDoctor
		JOIN Specializations ON Doctors.IdSpecialization = Specializations.IdSpecialization
			JOIN AppointmentsServices ON Appointments.IdAppointment = AppointmentsServices.IdAppointment
				JOIN Services ON AppointmentsServices.IdService = Services.IdService
					JOIN AppointmentsDiagnoses ON Appointments.IdAppointment = AppointmentsDiagnoses.IdAppointment
						JOIN Diagnoses ON AppointmentsDiagnoses.IdDiagnose = Diagnoses.IdDiagnose
							WHERE IdPatient = '4'