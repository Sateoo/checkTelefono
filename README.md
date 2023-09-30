# checkTelefono
### Testo dell'esecizio
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota ""

Ad esempio.
Se arriva "05417373", "3367726712",  "778823"
Tornare "3367726712"

Se arriva "33677267", "33677232",  "778823"
Tornare ""

Se arriva "", "05417723",  "+391231231234"
Tornare "+391231231234"

Se arriva "3", "05417723",  "00391231231230"
Tornare ""

#etc

#Inizio risuluzione
Inizializzare un stinga vuota e un itero, la stringa la useremo per tornare il numero di telefono e l'intero invece ci servirà per controllare se nella striga ci siano spazzi vuoti
```c#
string d="";
int f=1000;
```
