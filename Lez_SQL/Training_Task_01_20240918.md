# Il sistema di gestione musei

Si vuole progettare una base di dati per gestire informazioni su musei, le opere conservate, gli artisti che hanno creato tali opere.
Di un museo interessano il nome, che lo identifica, la città, l’indirizzo e il nome del direttore.
Un artista è identificato dal nome; di lui interessano la nazionalità, la data di nascita, la eventuale data di morte.
Di un’opera, identificata da un codice, interessano, l’anno di creazione, il titolo, il nome dei personaggi rappresentati.
Un’opera può essere un dipinto od una scultura; se è un dipinto interessano il tipo di pittura e le dimensioni; se è una scultura interessano il materiale, l’altezza ed il peso.

# Il sistema di gestione ospedaliera

L'obiettivo è tracciare le informazioni relative ai pazienti, i ricoveri ed il reparto di riferimento.
Ad ogni reparto afferiscono più medici, di ogni medico dobbiamo tener traccia delle informazioni di base compreso il numero identificativo univoco. Possiamo asserire che un medico appartiene ad un solo reparto.
Ogni giorno un paziente ricoverato riceve una o più visite, una visita è caratterizzata solo dalla data e dalle note.
Inoltre, vi viene chiesto di tener traccia degli esami di laboratorio. Un paziente potrebbe venire in struttura anche solo per effettuare un esame delle urine.

# Il sistema di gestione alberghi:

La catena alberghiera "Sogni D'oro" necessita di un sistema di gestone delle prenotazioni per gestre le sue diverse struture sparse in tutto il paese. Ogni albergo si distngue per nome, indirizzo, e valutazione (espressa in stelle). All'interno di ogni albergo, vi sono diverse camere, ognuna caraterizzata da un numero univoco per albergo, un tipo (singola, doppia, suite, ecc.), una capacità massima di ospiti e una tariffa per notte.
I clienti possono prenotare camere scegliendo specifiche date di check-in e check-out. Ogni prenotazione riguarda una sola camera in un determinato periodo, e il sistema deve tenere traccia dell'identità del cliente, che include detagli come nome, cognome, e contatto. Si noti che un cliente può effetuare più prenotazioni nel tempo, ma una camera può essere prenotata solo da un cliente alla volta per qualsiasi data.
Inoltre, l'albergo impiega diversi dipendenti, inclusi receptionist, personale di pulizia e manager. Ogni dipendente è associato a un unico albergo e ha un ruolo specifico nell'organizzazione. È importante tracciare anche i detagli del dipendente, inclusi nome, cognome, posizione, e detagli del contatto.
Il sistema dovrebbe anche consentire la gestione delle facilites offerte da ogni albergo, come palestre, piscine o spa. Ogni facility è caraterizzata da un nome, una descrizione e un insieme di orari di apertura.
Si richiede di progetare uno schema ER per questo sistema, identficando chiaramente entità, atributi, e relazioni.