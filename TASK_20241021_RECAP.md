# Il sistema di prenotazione corsi

Si vuole realizzare un sistema di prenotazione corsi con approccio ibrido.

Creare un progetto ASP WEB che permetta, con weak validation Cookie di accedere al sistema e di inserire un corso di formazione.
Ogni corso è caratterizzato almeno da:
- Nome del corso
- Codice del corso
- Descrizione
- Prezzo
- Numero massimo di partecipanti
Un amministratore può eliminare una richiesta di iscrizione in qualsiasi momento.

Le iscrizioni vengono effettuate tramite una lista di iscrizione aperta che potrà avvenire solo tramite API con una web app sviluppata in angular. Ovviamente sulla web app in angular verranno visualizzati tutti i corsi, prevedere un filtro che ricerchi il corso per titolo (anche parziale).

ATTENZIONE: Non è necessaria autenticazione, il sistema è del tipo Whitelist, ovvero le iscrizioni si fanno tramite inserimento del proprio nome, cognome ed indirizzo email.
Da notare che:
- Non è possibile iscrivere due volte lo stesso indirizzo email
- Una volta raggiunto il numero massimo di partecipanti non è possbile più iscriversi.

HARD: Alla iscrizione viene fornito all'utente (a video) un codice tramite il quale, in un apposito form, inserendo il proprio indirizzo email ed il suddetto codice, può disiscriversi da un corso in maniera autonoma. Sarebbe carino anche prevedere un sistema di invio mail automatiche, ma potrebbe essere magia per voi ;).