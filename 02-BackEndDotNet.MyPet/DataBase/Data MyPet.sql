delete from gender;
delete from breed;
delete from species;

set @male:=uuid(),
	@female:=uuid(),
    @dog:=uuid(),
    @cat:=uuid(),
    @parrot:=uuid(),
    @hamster:=uuid(),
    @tutle:=uuid(),
    @germanshepherd:=uuid(),
    @persiancat:=uuid();

insert gender (Id, Name) values
	(@male, 'Male'),
    (@female, 'Female');

insert species (Id, Name, ScientificName) values 
	(@dog, 'Dog', 'Canis lupus'),
    (@cat, 'Cat', 'Felis silvestris catus'),
    (@parrot, 'Parrot', 'Psittacoidea'),
    (@hamster, 'Hamster', null),
    (@tutle, 'Tutle', null);
    
insert breed (Id, Name, IdSpecies) values 
	(@germanshepherd, 'German Shepherd', @dog),
    (@persiancat, 'Persian Cat', @cat);

insert clinic (Id, Name, Address, PhoneNumber, Email) values 
	(uuid(), 'Clinica Cerbero', 'Rua del Percebe nº 13', '5550001', 'info@clinicacerbero.es'),
    (uuid(), 'Clinica Panda Chulin', 'Plaza Mayor nº666', '5550002', 'info@clinicachulin.es'),
    (uuid(), 'Clinica Misifu', 'Avenida de España', '5550003', 'info@clinicamisifu.es');
     