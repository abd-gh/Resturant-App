if not exists (select guid from GUsers where guid='6ACE8DA6-86A7-48E1-B956-849172E8B502')


INSERT INTO GUsers (Number,GUID, LoginName, Password, IsAdmin,ParentUser)
	    Values(1,'{6ACE8DA6-86A7-48E1-B956-849172E8B502}','Admin','21232f297a57a5a743894a0e4a801fc3',1,(0x00))	
	go	