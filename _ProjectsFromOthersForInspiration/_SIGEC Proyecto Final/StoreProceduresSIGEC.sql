USE [SIGEC]
GO

/****** Object:  StoredProcedure [dbo].[PrintStudyIndication]    Script Date: 01/30/2014 10:24:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[PrintStudyIndication] (@cons_ID int)
as
select  s.name studyName,
       u.firstName+' '+u.lastName fullName,
       isnull(YEAR(GETDATE()) - YEAR(u.bornDate),0) age,
       c.createDate creationDate,
       ap.appointmentDate nextAppointnment
from Consultations c
inner join Consultations_Studies cs on cs.consultationID = c.ID
inner join Studies s on cs.studyID = s.ID
inner join Patients p on c.patientID = p.ID
inner join Appointments ap on ap.ID = c.appointmentID
inner join Users u on p.userID = u.ID
where c.ID = @cons_ID
GO



CREATE procedure [dbo].[PrintProcedureIndication] (@cons_ID int)
as
select pr.name procedureName,
       u.firstName+' '+u.lastName fullName,
       isnull(YEAR(GETDATE()) - YEAR(u.bornDate),0) age,
       c.createDate creationDate,
       ap.appointmentDate nextAppointnment
from Consultations c
inner join Consultations_Procedures cp on cp.consultationID = c.ID
inner join Procedures pr on cp.procedureID = pr.ID
inner join Patients p on c.patientID = p.ID
inner join Appointments ap on ap.ID = c.appointmentID
inner join Users u on p.userID = u.ID
where c.ID = @cons_ID
GO


CREATE procedure [dbo].[PrintPrescription] (@cons_ID int)
as
select m.name medicine,
	   pm.administration dosage,
	   u.firstName+' '+u.lastName fullName,
	   isnull(YEAR(GETDATE()) - YEAR(u.bornDate),0) age,
	   c.createDate creationDate,
	   a.appointmentDate nextAppointment
from Consultations c
inner join Prescriptions_Medicines pm on pm.consultationID = c.ID
inner join Medicines m on pm.medicineID = m.ID
inner join Appointments a on c.appointmentID = a.ID
inner join Patients p on pm.patientID = p.ID
inner join Users u on u.ID = p.userID
where pm.consultationID = @cons_ID;

GO



CREATE procedure [dbo].[PrintAnalysisIndication] (@cons_ID int)
as
select a.name analysis,
       u.firstName+' '+u.lastName fullName,
       isnull(YEAR(GETDATE()) - YEAR(u.bornDate),0) age,
       c.createDate  creationDate,
       ap.appointmentDate nextAppointnment
      
from Consultations c
inner join Consultations_Analysis ca on ca.consultationID = c.ID
inner join Analysis a on ca.analysisID = a.ID
inner join Patients p on c.patientID = p.ID
inner join Appointments ap on ap.ID = c.appointmentID
inner join Users u on p.userID = u.ID
where c.ID = @cons_ID

GO




CREATE procedure [dbo].[PrintIncomes](@date date)
as
select ROW_NUMBER() over (order by c.createDate) No,
	  u.firstName+' '+u.lastName fullName,
	   cp.price price,
	   cp.discount discount,
	   cp.insurer insurer,
	   cp.total total,  
	   cast (c.createDate as date) reportDate
from Consultations_Payment cp
inner join Consultations c on c.ID = cp.consultationID
inner join Patients p on p.ID = c.patientID
inner join Users u on u.ID = p.userID
where cast (c.createDate as date) = @date;
GO
