### Compito Finale: Realizzazione di una Chat in Tempo Reale

#### Obiettivo

Sviluppare una chat in tempo reale utilizzando **C# (per il backend)** e **Angular (per il frontend)** su architettura 3 Tier. La chat dovrà consentire la registrazione e il login degli utenti, permettendo loro di comunicare in tempo reale in una stanza comune.

------

### Specifiche lato UTENTE

#### Registrazione Utente

1. Creare una pagina di registrazione che consenta agli utenti di creare un nuovo account.
2. Validazioni richieste:
   - **Username**: Unico per ogni utente; visualizzare un messaggio se l’username è già in uso.
   - **Email**: Valida e unica per ogni utente; avvisare l’utente se l’email è già registrata.
   - **Password**: Almeno 8 caratteri, con un mix di lettere e numeri. Richiedere la conferma della password durante la registrazione.

#### Autenticazione

1. Implementare la funzionalità di login tramite email e password.
2. Una volta autenticato, l'utente può accedere alla chat.
3. Gestione della sessione utente e delle autorizzazioni di accesso per garantire che solo gli utenti registrati possano visualizzare e partecipare alla chat.

#### Chat in Tempo Reale

1. **Stanza Comune**: Una singola stanza di chat dove tutti gli utenti autenticati possono scrivere e visualizzare i messaggi.
2. Messaggi in Tempo Reale:
   - Ogni nuovo messaggio deve essere visibile agli altri utenti in tempo reale.
   - È possibile utilizzare `setInterval` per la sincronizzazione iniziale dei messaggi, ma si incoraggia a esplorare l’utilizzo di **SignalR** o **WebSockets** per migliorare l’esperienza in tempo reale.
3. **Data e Ora dei Messaggi**: Ogni messaggio deve riportare la data e l’ora di invio.
4. **Nome Utente**: I messaggi devono visualizzare il nome dell'utente che li ha inviati.

#### Interfaccia Utente (UI)

1. Layout chiaro e intuitivo:
   - Area centrale per i messaggi, con scorrimento automatico ai nuovi messaggi ("scroll to latest message").
   - Una barra di input per scrivere e inviare messaggi.
   - Pulsante per logout visibile e accessibile.
2. **Interfaccia reattiva**: La UI dovrebbe adattarsi bene su diversi dispositivi, inclusi mobile e desktop.

#### Sicurezza

1. Hashing delle password lato server per la protezione dei dati (opzionale).
2. Accesso alla chat limitato agli utenti autenticati.

#### Extra (Opzionale)

1. Notifiche di ingresso e uscita: mostrare un messaggio quando un utente si connette o disconnette dalla chat.
2. Emoji nei messaggi: consentire l'invio di emoji (es. utilizzando una libreria di emoji o codici come Font Awesome). Un suggerimento potrebbe essere quello di inserire un [fa-trash] per visualizzare l'emoji del secchio dell'immondizia.
3. Messaggi di conferma per azioni importanti, come il logout, per evitare azioni non intenzionali.

------

### Specifiche lato AMMINISTRATORE

Creare un backend su architettura 2 Tier utilizzando **ASP.NET** che permetta ad un utente amministratore di:

1. **Gestione Utenti**:
   - **Eliminare un Utente**: L’amministratore deve poter eliminare account utente con conferma prima dell’azione.
   - **Bloccare un Utente**: Bloccare un utente impedendogli di inviare messaggi, con un avviso che lo invita a richiedere lo sblocco.
2. **Moderazione dei Messaggi**:
   - **Eliminare Messaggi di Chat**: L’amministratore deve poter eliminare i messaggi inappropriati in chat, agendo come moderatore.

#### Accesso

1. Il pannello amministrativo deve essere protetto e accessibile solo agli utenti con privilegi di amministratore.
2. Implementare la sicurezza di base per garantire la protezione delle operazioni di amministrazione.

------

### Requisiti Tecnologici

- **Backend**: .NET (C#) con SignalR o setInterval per la comunicazione in tempo reale.
- **Frontend**: Angular, con il framework di UI a scelta (es. Bootstrap o Angular Material).

------

### Criteri di Valutazione

1. **Funzionalità**: Implementazione delle specifiche di base e avanzate.
2. **Qualità del Codice**: Struttura e leggibilità del codice, uso di pattern adeguati e applicazione dei principi OOP.
3. **UI e UX**: Facilità di utilizzo e pulizia dell'interfaccia.
4. **Sicurezza**: Applicazione delle best practices per la sicurezza.
5. **Creatività**: Valutazione delle funzionalità extra come valore aggiunto.

### Opzione DATABASE eterogeneo

Consiglio di esplorare l'approccio di persistenza dei dati in modo che:

- Gli utenti siano salvati su SQL Server
- Messaggi degli utenti su MongoDB

