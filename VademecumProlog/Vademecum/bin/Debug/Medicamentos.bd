sintomas(tosConFlema, gripa).
sintomas(escurrimientoNasal, gripa).
sintomas(cuerpoCortado, gripa).
sintomas(dolorCabeza, gripa).

sintomas(dolorGarganta, infeccionAnginas).
sintomas(tosSinFlemas, infeccionAnginas).
sintomas(fiebre, infeccionAnginas).

sintomas(dolorGarganta, infeccionGarganta).
sintomas(perdidaVoz, infeccionGarganta).
sintomas(fiebre, infeccionGarganta).

sintomas(tosConFlema, bronquitis).
sintomas(cuerpoCortado, bronquitis).
sintomas(dificultadRespirar, bronquitis).

sintomas(dolorOido, otitis).

sintomas(dolorCabeza, migrania).
sintomas(dolorCabezaMovimiento, migrania).
sintomas(nauseasVomito, migrania).

sintomas(dolorEstomago, intoxicacion).
sintomas(nauseasVomito, intoxicacion).
sintomas(diarrea, intoxicacion).

medicina(amoxicilina, gripa, mexico).
medicina(tylenol, gripa, mexico).
medicina(tempra, gripa, mexico).
medicina(mucoangin, gripa, mexico).
medicina(tamiflu, gripa, mexico).
medicina(ibuprofeno, infeccionGarganta, mexico).
medicina(mucoangin, infeccionGarganta, mexico).
medicina(ambroxol, infeccionAnginas, mexico).
medicina(ibuprofeno, infeccionAnginas, mexico).
medicina(amoxicilina, bronquitis, mexico).
medicina(ambroxol, bronquitis, mexico).
medicina(otoclean, otitis, mexico).
medicina(azitromicina, otitis, mexico).
medicina(aspirina, migrania, mexico).
medicina(naproxeno, migrania, mexico).
medicina(bioelectro, migrania, mexico).
medicina(paracetamol, migrania, mexico).
medicina(ranitidina, intoxicacion, mexico).
medicina(omeprazol, intoxicacion, mexico).
medicina(amoxicilina, intoxicacion, mexico).
medicina(butilhioscina, intoxicacion, mexico).

medicina(amoxicilin, gripa, republicaCheca).
medicina(vicks, gripa, republicaCheca).
medicina(theraflu, gripa, republicaCheca).
medicina(tamiflu, gripa, republicaCheca).
medicina(ibuprofen, infeccionGarganta, republicaCheca).
medicina(tantumVerde, infeccionGarganta, republicaCheca).
medicina(neoangin, infeccionGarganta, republicaCheca).
medicina(neoangin, infeccionAnginas, republicaCheca).
medicina(septabene, infeccionAnginas, republicaCheca).
medicina(amoxicilin, bronquitis, republicaCheca).
medicina(stoptussin, bronquitis, republicaCheca).
medicina(robitussin, bronquitis, republicaCheca).
medicina(azithromycin, otitis, republicaCheca).
medicina(migralgin, migrania, republicaCheca).
medicina(nalgesin, migrania, republicaCheca).
medicina(panadol, migrania, republicaCheca).
medicina(biopron, intoxicacion, republicaCheca).
medicina(iberogast, intoxicacion, republicaCheca).
medicina(pancreolanForte, intoxicacion, republicaCheca).

medicina(tylenol, gripa, estadosUnidos).
medicina(acetaminophen, gripa, estadosUnidos).
medicina(tamiflu, gripa, estadosUnidos).
medicina(ibuprofen, infeccionGarganta, estadosUnidos).
medicina(throatCalm, infeccionGarganta, estadosUnidos).
medicina(ibuprofen, infeccionAnginas, estadosUnidos).
medicina(lidocaine, infeccionAnginas, estadosUnidos).
medicina(robitussin, infeccionAnginas, estadosUnidos).
medicina(ambroxol, bronquitis, estadosUnidos).
medicina(vanquish, migrania, estadosUnidos).
medicina(acetaminophen, migrania, estadosUnidos).
medicina(excedrin, migrania, estadosUnidos).
medicina(polysporin, otitis, estadosUnidos).
medicina(hylandsEarAcheDrops, otitis, estadosUnidos).
medicina(omeprazole, intoxicacion, estadosUnidos).
medicina(equate, intoxicacion, estadosUnidos).
medicina(imodium, intoxicacion, estadosUnidos).

especialista(medicoGeneral, gripa).
especialista(otorrinolaringologo, gripa).
especialista(otorrinolaringologo, infeccionAnginas).
especialista(otorrinolaringologo, infeccionGarganta).
especialista(otorrinolaringologo, bronquitis).
especialista(medicoGeneral, bronquitis).
especialista(otorrinolaringologo, otitis).
especialista(medicoGeneral, migrania).
especialista(neurologo, migrania).
especialista(medicoGeneral, intoxicacion).
especialista(Gastroenterologo, intoxicacion).

cargar(A):-exists_file(A),consult(A).

receta(Medicina,Sintoma,Pais):-sintomas(Sintoma,Z), medicina(Medicina,Z,Pais).

tipoEspecialista(Especialidad,Sintoma):-sintomas(Sintoma,Z), especialista(Especialidad,Z).

diagnosticar(Sintoma,Z):-sintomas(Sintoma,Z).

diagnosticar(SintomaA,SintomaB,Z):- sintomas(SintomaA,Z), sintomas(SintomaB,Z).

diagnosticar(SintomaA,SintomaB,SintomaC,Z):- sintomas(SintomaA,Z), sintomas(SintomaB,Z), sintomas(SintomaC,Z).