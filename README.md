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

etc
# Inizio risuluzione
Inizializzare un stinga vuota e un itero, la stringa la useremo per tornare il numero di telefono e l'intero invece ci servirà per controllare se nella striga ci siano spazzi vuoti
```c#
string d="";
int f=1000;
```
Creare poi un ciclo for che scorra tutto il vettore di stringhe
```c#
 for(int i=0;i<input.Length;i++)
```
All'interno del for inizializzare un'altra strigna in cui salveremo ad ogni giro una striga del vettore
```
string s= input[i];
```
Sempre all'interno del for ne creeremo un altro con lo scopo di controllare se all'interno della stringa appena iniziallizata ci sono degli spazzi, se ci sono la strigna verra posta uguale a "" perchè compromessa
```c#
for(int j=0;j<s.Length;j++)
            {
                if(s[j]==' ')
                    s="";
            }
```
